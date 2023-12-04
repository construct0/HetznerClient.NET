namespace HetznerClient.Logic.Builders;

public class QueryParameterAppendixBuilder {
	private string _appendix { get; set; } = string.Empty;

	public string GetAppendix() {
		if(_appendix.Length == 0) {
			throw new InvalidOperationException($"The appendix is empty, please use the provided {nameof(QueryParameterAppendixBuilder)} 'Add' functions first.");
		}

		return _appendix;
	}

	public QueryParameterAppendixBuilder AddPart(string k, string? v) {
		var q = _appendix.Length == 0 ? "?" : "&";
		_appendix += v is null ? $"{q}{k}" : $"{q}{k}={v}";

		return this;
	}

	public QueryParameterAppendixBuilder AddParts(Dictionary<string, string?> parts) {
		if(parts is null) {
			throw new ArgumentNullException(nameof(parts));
		}

		foreach (var kvp in parts) {
			this.AddPart(kvp.Key, kvp.Value);
		}

		return this;
	}

	public QueryParameterAppendixBuilder AddParts(object instance) {
		if(instance is null) {
			throw new ArgumentNullException(nameof(instance));
		}

		foreach(var prop in instance.GetType().GetProperties()) {
			this.AddPart(prop.Name, prop.GetValue(instance)?.ToString());
		}

		foreach(var field in instance.GetType().GetFields()) {
			this.AddPart(field.Name, field.GetValue(instance)?.ToString());
		}

		return this;
	}
}


public class HetznerLabelSelectorBuilder {
	private string _selector { get; set; } = string.Empty;

	private HetznerLabelSelectorBuilder AppendToSelector(string part) {
		if (this._selector.Length > 0) {
			_selector += ",";
		}

		_selector += part;
		return this;
	}

	/// <summary>
	/// Returns the selector, should be called after using 'Add' build functions
	/// </summary>
	/// <returns></returns>
	/// <exception cref="InvalidOperationException"></exception>
	public string GetSelector() {
		if (_selector.Length == 0) {
			throw new InvalidOperationException($"The selector is empty, please use the provided {nameof(HetznerLabelSelectorBuilder)} 'Add' functions first.");
		}

		return _selector;
	}

	/// <summary>
	/// Value of key k does equal value v
	/// </summary>
	public HetznerLabelSelectorBuilder AddKeyValueEquals(string k, string v) {
		return this.AppendToSelector($"{k}=={v}");
	}

	/// <summary>
	/// Value of key k does not equal value v
	/// </summary>
	public HetznerLabelSelectorBuilder AddKeyValueDoesNotEqual(string k, string v) {
		return this.AppendToSelector($"{k}!={v}");
	}

	/// <summary>
	/// Key k is present
	/// </summary>
	public HetznerLabelSelectorBuilder AddKeyMustOccur(string k) {
		return this.AppendToSelector($"{k}");
	}

	/// <summary>
	/// Key k is not present
	/// </summary>
	public HetznerLabelSelectorBuilder AddKeyMustNotOccur(string k) {
		return this.AppendToSelector($"!{k}");
	}

	/// <summary>
	/// Value of key k is in list
	/// </summary>
	public HetznerLabelSelectorBuilder AddKeyValueMustOccurInList(string k, List<string> vs) {
		return this.AppendToSelector($"{k} in ({string.Join(",", vs)})");
	}

	/// <summary>
	/// Value of key k is not in list
	/// </summary>
	public HetznerLabelSelectorBuilder AddKeyValueMustNotOccurInList(string k, List<string> vs) {
		return this.AppendToSelector($"{k} notin ({string.Join(",", vs)})");
	}
}




