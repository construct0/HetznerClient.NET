namespace HetznerClient.Model;

#pragma warning disable CS8618
public abstract class AbstractConfig {
    public Uri BaseAddress { get; private set; }
    public string BearerToken { get; private set; }

    protected AbstractConfig(string bearerToken, string baseAddress) {
        if (string.IsNullOrWhiteSpace(bearerToken) || string.IsNullOrEmpty(bearerToken)) {
            throw new ArgumentException("A valid bearer token must be provided to use the client.");
        }

        if(string.IsNullOrEmpty(baseAddress) || string.IsNullOrWhiteSpace(baseAddress) || !baseAddress.StartsWith("https://") || !baseAddress.EndsWith("/")) {
            throw new ArgumentException("A valid base address must be provided which starts with 'https://' and ends with '/'. You can omit this argument to use the default address.");
        }

        // Provides validation on Uri init beyond the aforementioned
        BaseAddress = new Uri(baseAddress);
        SetBearerToken(bearerToken);
    }

    public void SetBearerToken(string bearerToken) {
        BearerToken = bearerToken.Replace("Bearer", "", StringComparison.InvariantCultureIgnoreCase).Trim();
	}
}
