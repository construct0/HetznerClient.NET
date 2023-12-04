namespace HetznerClient.Model.Cloud.Volumes;

public class VolumeProtection {
	/// <summary>
	/// If true, prevents the Resource from being deleted
	/// </summary>
	public bool Delete { get; set; } = true;
}
