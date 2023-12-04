using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud.PlacementGroups;

/// <summary>
/// Type of the Placement Group
/// </summary>
public enum PlacementGroupType {
	[EnumValue("spread")]
	Spread = 0,
}

