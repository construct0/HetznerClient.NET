using HetznerClient.Model.Cloud;

namespace HetznerClient.Model.Attributes;

/// <summary>
/// Allows for enum keys to be accompanied with a string representation instead of merely a character or integer.
/// Related <see cref="CloudErrorCode"/> & <see cref="Logic.Extensions.EnumExtensions.GetEnumValue(Enum)"/>
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
public class EnumValueAttribute : Attribute {
	public object? Value { get; set; }

	public EnumValueAttribute(object value) {
		Value = value;
	}
}

// todo use reflection when needed, otherwise rem attribute
/// <summary>
/// Indicates that a class is the main Response type for its domain.
/// Do not apply this attribute to the Hetzner encompassing <see cref="Response"/> class.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public class HetznerDomainResponseAttribute : Attribute {
	public string Domain { get; set; }

	public HetznerDomainResponseAttribute(string domain) {
		Domain = domain ?? throw new ArgumentNullException(nameof(domain) + " is required");
	}
}