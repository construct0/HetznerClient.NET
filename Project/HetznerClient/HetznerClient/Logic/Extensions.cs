using HetznerClient.Model.Attributes;
using Newtonsoft.Json;
using System.Reflection;

namespace HetznerClient.Logic.Extensions;

public static class StringExtensions {
	/// <summary>
	/// Combines conversion techniques. Attempts to plain cast, enum parse, json deserialize and a last attempt using System.Convert.
	/// </summary>
	/// <exception cref="ArgumentException"/>
	public static T? Convert<T>(this String value) {
		object result = default(T)!;
		if(String.IsNullOrWhiteSpace(value)) {
			return (T?)result;
		}

		if(Enum.TryParse(typeof(T), value, true, out result!)) {
			return (T)result;
		}

		try {
			return JsonConvert.DeserializeObject<T>(value);
		} catch {
			try {
				return (T)System.Convert.ChangeType(value, typeof(T));
			} catch (Exception e) {
				throw new ArgumentException($"Could not convert to {typeof(T).Name}:\n\n{value}\n\n{e.Message}");
			}
		}
	}
}

public static class EnumExtensions {
	/// <summary>
	/// Gets the value present of the <see cref="EnumValueAttribute"/> applied to an Enum constituent
	/// </summary>
	public static string GetEnumValue(this Enum value) {
		if (value is null) {
			throw new ArgumentNullException("Enumeration value can not be null");
		}

		var valueType = value.GetType();
		var fieldInfo = valueType.GetField(value!.ToString());
		var attribs = (fieldInfo?.GetCustomAttributes(typeof(EnumValueAttribute), false) as EnumValueAttribute[]) ?? new EnumValueAttribute[] { };

		return attribs.FirstOrDefault()?.Value?.ToString() ?? throw new ArgumentException($"There is no StringValue attribute attached to enumeration value: {valueType.Name}{value}");
	}
}

public static class AssemblyExtensions {
	/// <summary>
	/// Finds types in the Assembly attributed by a given type
	/// </summary>
	public static IEnumerable<Type> FindDecoratedTypes(this Assembly assembly, Type attributeType) {
		foreach (Type type in assembly.GetTypes()) {
			if (type.GetCustomAttributes(attributeType, true).Any()) {
				yield return type;
			}
		}

		yield break;
	}
}

public static class AppDomainExtensions {
	/// <summary>
	/// Finds types in the AppDomain attributed by a given type, leverages <see cref="AssemblyExtensions.FindDecoratedTypes(Assembly, Type)"/>
	/// </summary>
	public static IEnumerable<Type> FindDecoratedTypes(this AppDomain appDomain, Type attributeType) {
		var res = new List<Type>();
		foreach(var assembly in appDomain.GetAssemblies()) {
			assembly.FindDecoratedTypes(attributeType).ToList().ForEach(x => res.Add(x));
		}

		return res;
	}
}
