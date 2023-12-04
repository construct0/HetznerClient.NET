using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Globalization;

namespace HetznerClient.Logic.Converters;

public static class Json {
	public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings {
		MetadataPropertyHandling = MetadataPropertyHandling.Default,
		DateParseHandling = DateParseHandling.DateTime,
		ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
		ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
		TypeNameHandling = TypeNameHandling.None,

		// Abstract client implementations and their response classes can (and do) contain all possible properties, null values are ignored while (de)serialising
		NullValueHandling = NullValueHandling.Ignore,

#if (DEBUG)
		TypeNameAssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Full,
		MissingMemberHandling = MissingMemberHandling.Error,
#else
		TypeNameAssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple,
		MissingMemberHandling = MissingMemberHandling.Ignore,
#endif

		Converters = {
			new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
		},
	};
}
