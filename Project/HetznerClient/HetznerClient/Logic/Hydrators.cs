using System.Dynamic;

namespace HetznerClient.Logic.Hydrators;

public static class UrlPathPropertyHydrator {
	/// <summary>
	/// Hydrates a string (which is the appendix of the base path) in an ASP.NET-esque manner, i.e. {id} gets hydrated by the given instance's property 'Id'. The property name replacing is case insensitive and type agnostic, values are always converted to a string and only public properties are taken into consideration. Does not support type colloraries (e.g. "{id:int}"), only property names.
	/// </summary>
	/// <typeparam name="TInstance">Restricted to class instances or anonymous objects: https://stackoverflow.com/a/315186</typeparam>
	/// <param name="instanceToExtractFrom">A class instance or an anonymous object</param>
	/// <exception cref="ArgumentException"></exception>
	public static string HydrateUsingInstance<TInstance>(string urlToHydrate, TInstance? instanceToExtractFrom=default, bool lenientHydration = true) where TInstance : class {
		if (urlToHydrate.Length == 0) {
			if (lenientHydration) {
				// The path part is empty, the part is returned verbatim
				return urlToHydrate;
			}

			throw new ArgumentException($"Can not hydrate an empty string, use lenient hydration if your base path part appendix is supposed to be empty");
		}

		if (instanceToExtractFrom is null || instanceToExtractFrom!.GetType().GetProperties().Length == 0) {
			if (lenientHydration) {
				// There is no instance given to extract from, the part is returned verbatim
				return urlToHydrate;
			}

			throw new ArgumentException($"There is no instance given to extract from or the instance does not have properties. Use lenient hydration if you wish to allow this");
		}

		// todo determine if the expandoobject results in props or fields
		foreach (var prop in instanceToExtractFrom.GetType().GetProperties()) {
			urlToHydrate = urlToHydrate.Replace("{" + prop.Name + "}", prop?.GetValue(instanceToExtractFrom)?.ToString() ?? "", StringComparison.InvariantCultureIgnoreCase);
		}

		var hydratedPart = urlToHydrate;
		return hydratedPart;
	}

	public static string HydrateUsingDictionary<TDictionary>(string urlToHydrate, TDictionary dict, bool lenientHydration) where TDictionary : IDictionary<string, object> {
		ExpandoObject expandoObject = new();

		foreach(var kvp in dict) {
			expandoObject.TryAdd(kvp.Key, kvp.Value);
		}

		return HydrateUsingInstance(urlToHydrate, (dynamic)expandoObject, lenientHydration);
	}
}
