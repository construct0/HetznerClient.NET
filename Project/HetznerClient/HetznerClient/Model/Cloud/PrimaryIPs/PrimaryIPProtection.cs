namespace HetznerClient.Model.Cloud.PrimaryIPs;

public class PrimaryIPProtection {
	/// <summary>
	/// If true, prevents the Resource from being deleted
	/// </summary>
	public bool Delete { get; set; } = true;
}
