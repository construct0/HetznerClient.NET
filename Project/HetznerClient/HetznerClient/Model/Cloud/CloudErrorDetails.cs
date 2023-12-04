namespace HetznerClient.Model.Cloud;

// todo possible refactor opp

/// <summary>
/// Casts to this type are valid when <see cref="CloudError.Code"/> is <see cref="CloudErrorCode.InvalidInput"/>
/// </summary>
public class HetznerInvalidInputErrorDetails {
    public IEnumerable<HetznerInvalidInputDetailsConstituent> Fields { get; init; }

    public class HetznerInvalidInputDetailsConstituent {
        // e.g. broken_field
        public string Name { get; init; }

        // e.g. ["is too long"]
        public IEnumerable<string> Messages { get; init; }
    }
}

/// <summary>
/// Casts to this type are valid when <see cref="CloudError.Code"/> is <see cref="CloudErrorCode.UniquenessError"/>
/// </summary>
public class HetznerUniquenessErrorDetails {
    public List<HetznerUniquenessErrorDetailsConstituent> Fields { get; init; }

    public class HetznerUniquenessErrorDetailsConstituent {
        // e.g. name
        public string Key { get; init; }

        // e.g. public_key
        public string Value { get; set; }
    }
}

/// <summary>
/// Casts to this type are valid when <see cref="CloudError.Code"/> is <see cref="CloudErrorCode.ResourceLimitExceeded"/>
/// </summary>
public class HetznerResourceLimitExceededErrorDetails {
    public class HetznerResourceLimitExceededDetailsConstituent {
        // e.g. name
        public string Key { get; init; }

        //  e.g. project_limit
        public string Value { get; init; }
    }
}
