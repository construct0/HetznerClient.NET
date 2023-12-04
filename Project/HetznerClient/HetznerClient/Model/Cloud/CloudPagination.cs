namespace HetznerClient.Model.Cloud;

/// <summary>
/// Responses contain a Link header with pagination information. (This is currently not relied upon, the pagination object should be present in the json response body. (todo followup))
/// Additionally, if the response body is JSON and the root object is an object, that object has a pagination object inside the meta object with pagination information.
/// </summary>
public class CloudPagination {
	/// <summary>
	/// Current page number
	/// </summary>
	public int Page { get; init; }

    /// <summary>
    /// Specifies the number of items returned per page. The default value is 25, the maximum value is 50 except otherwise specified in the documentation.
    /// </summary>
    public int PerPage { get; init; }

    /// <summary>
    /// Expected to be null when on the first page
    /// </summary>
    public int? PreviousPage { get; init; }

    /// <summary>
    /// Expected to be null when on the last page
    /// </summary>
    public int? NextPage { get; init; }

    /// <summary>
    /// Expected to be null when the total number of entries is unknown
    /// </summary>
    public int? LastPage { get; init; }

    /// <summary>
    /// Expected to be null when the total number of entries is unknown
    /// </summary>
    public int? TotalEntries { get; init; }

    public CloudPagination(int page, int perPage, int? previousPage, int? nextPage, int? lastPage, int? totalEntries) {
        Page = page;
        PerPage = perPage;
        PreviousPage = previousPage;
        NextPage = nextPage;
        LastPage = lastPage;
        TotalEntries = totalEntries;
    }
}
