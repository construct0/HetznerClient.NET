using HetznerClient.Logic.Converters;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net;
using HetznerClient.Model.Constants;
using System.Net.Http.Json;
using HetznerClient.Logic.Builders;
using HetznerClient.Logic.Hydrators;

namespace HetznerClient.Model;

#pragma warning disable CS8618
public abstract class AbstractClient {
	protected AbstractConfig ClientConfig { get; init; }
	protected HttpClient HttpClient { get; init; }

	public AbstractClient(AbstractConfig clientConfig) : this(clientConfig, new HttpClient()) { }
	public AbstractClient(AbstractConfig clientConfig, IHttpClientFactory httpClientFactory) : this(clientConfig, httpClientFactory.CreateClient()) { }
	public AbstractClient(AbstractConfig clientConfig, HttpClient httpClient) {
		ClientConfig = clientConfig ?? throw new ArgumentNullException($"A valid object inheriting from {nameof(AbstractConfig)} must be provided");
		HttpClient = httpClient ?? throw new ArgumentNullException($"A valid {nameof(HttpClient)} instance must be provided");
		this.ConfigureJsonSerializer();
		this.ConfigureTLS();
		this.ConfigureHTTPClient();
	}

	// todo assert configuration is applied correctly
	protected void ConfigureJsonSerializer() {
		JsonConvert.DefaultSettings = () => Json.Settings;
	}

	/// <summary>
	/// Cascading down to the first version which the OS supports
	/// </summary>
	protected void ConfigureTLS() {
		ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
	}

	protected void ConfigureHTTPClient() {
		HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", ClientConfig.BearerToken);
		HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		HttpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(new ProductHeaderValue($"{Application.Name}/v{Constants.Version.Number}")));
	}

	protected string ConstructUrl(string basePathAppendix, object? pathParameters=default, Dictionary<string, string?>? queryParameters=null) {
		var url = this.ClientConfig.BaseAddress.ToString();
		url = url.EndsWith("/") ? url : url + "/";

		if(pathParameters is not null) {
			url += UrlPathPropertyHydrator.HydrateUsingInstance<dynamic>(basePathAppendix, pathParameters);
		}

		if (queryParameters is not null) {
			url += new QueryParameterAppendixBuilder().AddParts(queryParameters).GetAppendix();
		}

		return url;
	}

	/// <summary>
	/// Attempts to read the (purportedly json) content into the desired type.
	/// </summary>
	/// <returns>A tuple indicating whether the status code indicated a successful operation and the casted response object.</returns>
	protected (bool, TResponse?) HandleHttpResponseMessage<TResponse>(HttpResponseMessage msg) where TResponse : Response {
		TResponse? res = msg.Content.ReadFromJsonAsync<TResponse>()?.Result;

		// todo handling, logging

		return (msg.IsSuccessStatusCode, res);
	}

	protected async Task<TResponse> PerformGETAll<TResponse>(string basePathAppendix,  object? pathParameters = default, Dictionary<string, string?>? queryParameters = null) where TResponse : Response {
		var msg = await this.PerformBareGET(basePathAppendix, pathParameters, queryParameters);

		return this.HandleHttpResponseMessage<TResponse>(msg);
	}

	protected async Task<TResponse> PerformGET<TResponse>(string basePathAppendix, object? pathParameters = default, Dictionary<string, string?>? queryParameters = null) where TResponse : Response {
		var msg = await this.PerformBareGET(basePathAppendix, pathParameters, queryParameters);

		return this.HandleHttpResponseMessage<TResponse>(msg);
	}

	protected async Task<TResponse> PerformPOST<TRequest, TResponse>(string basePathAppendix, TRequest requestBody, object? pathParameters = default, Dictionary<string, string?>? queryParameters = default) where TResponse : Response {
		var msg = await this.PerformBarePOST(basePathAppendix, requestBody, pathParameters, queryParameters);

		return this.HandleHttpResponseMessage<TResponse>(msg);
	}

	protected async Task<TResponse> PerformPUT<TRequest, TResponse>(string basePathAppendix, TRequest requestBody, object? pathParameters = default, Dictionary<string, string?>? queryParameters = null) where TResponse : Response {
		var msg = await this.PerformBarePUT(basePathAppendix, requestBody, pathParameters, queryParameters);

		return this.HandleHttpResponseMessage<TResponse>(msg);
	}

	protected async Task<TResponse> PerformDELETE<TResponse>(string basePathAppendix, object? pathParameters = default, Dictionary<string, string?>? queryParameters = null) where TResponse : Response {
		var msg = await this.PerformBareDELETE(basePathAppendix, pathParameters, queryParameters);

		return this.HandleHttpResponseMessage<TResponse>(msg);
	}

	private async Task<HttpResponseMessage> PerformBareGET(string basePathAppendix, object? pathParameters = default, Dictionary<string, string?>? queryParameters = null) {
		return await HttpClient.GetAsync(
			this.ConstructUrl(basePathAppendix, pathParameters, queryParameters)
		);
	}

	private async Task<HttpResponseMessage> PerformBarePOST<TRequest>(string basePathAppendix, TRequest requestBody, object? pathParameters = default, Dictionary<string, string?>? queryParameters = default) {
		return await HttpClient.PostAsJsonAsync<TRequest>(
			this.ConstructUrl(basePathAppendix, pathParameters, queryParameters),
			requestBody
		);
	}

	private async Task<HttpResponseMessage> PerformBarePUT<TRequest>(string basePathAppendix, TRequest requestBody, object? pathParameters = default, Dictionary<string, string?>? queryParameters = null) {
		return await HttpClient.PutAsJsonAsync<TRequest>(
			this.ConstructUrl(basePathAppendix, pathParameters, queryParameters),
			requestBody
		);
	}

	private async Task<HttpResponseMessage> PerformBareDELETE(string basePathAppendix, object? pathParameters = default, Dictionary<string, string?>? queryParameters = null) {
		return await HttpClient.DeleteAsync(
			this.ConstructUrl(basePathAppendix, pathParameters, queryParameters)
		);
	}

}
