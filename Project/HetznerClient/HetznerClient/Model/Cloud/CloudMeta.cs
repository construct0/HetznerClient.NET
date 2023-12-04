namespace HetznerClient.Model.Cloud;

/// <summary>
/// If the response body is json and the root object is an object, that object has a pagination object inside the meta object with pagination information
/// </summary>
public class CloudMeta {
    public CloudPagination? Pagination { get; init; }

    public CloudMeta(CloudPagination pagination) {
        Pagination = pagination;
    }
}
