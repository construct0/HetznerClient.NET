namespace HetznerClient.Model.Cloud;

public partial class CloudActionResource {
    /// <summary>
    /// ID of the Resource
    /// </summary>
    public long Id { get; set; } = -1;

    /// <summary>
    /// Type of resource referenced
    /// </summary>
    public string Type { get; set; }

    public CloudActionResource(int id, string type)
    {
        Id = id;
        Type = type ?? throw new ArgumentNullException(nameof(type));
    }
}
