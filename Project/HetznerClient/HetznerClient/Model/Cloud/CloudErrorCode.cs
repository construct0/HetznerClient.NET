using HetznerClient.Model.Attributes;

namespace HetznerClient.Model.Cloud;

/// <summary>
/// Depicts all known Hetzner error codes in the form of an enum, an error code may apply to multiple endpoints but only the first occurrence is taken into account regarding the order of the error codes. <see href="https://web.archive.org/web/20231015201326/https://docs.hetzner.cloud/">As per the documentation of 15/10/23.</see>
/// </summary>
public enum CloudErrorCode
{
    #region General purpose
    /// <summary>
    /// Insufficient permissions for this request
    /// </summary>
    [EnumValue("forbidden")]
    Forbidden = 0,

    /// <summary>
    /// Request was made with an invalid or unknown token
    /// </summary>
    [EnumValue("unauthorized")]
    Unauthorized = 1,

    /// <summary>
    /// Error while parsing or processing the input, indicates that the dynamic details object (<see cref="CloudError.Details"/>) can be cast to 
    /// <see cref="HetznerInvalidInputErrorDetails"/>
    /// </summary>
    [EnumValue("invalid_input")]
    InvalidInput = 2,

    /// <summary>
    /// Invalid JSON input in your request
    /// </summary>
    [EnumValue("json_error")]
    JsonError = 3,

    /// <summary>
    /// The item you are trying to access is locked (there is already an Action running)
    /// </summary>
    [EnumValue("locked")]
    Locked = 4,

    /// <summary>
    /// Entity not found
    /// </summary>
    [EnumValue("not_found")]
    NotFound = 5,

    /// <summary>
    /// Error when sending too many requests
    /// </summary>
    [EnumValue("rate_limit_exceeded")]
    RateLimitExceeded = 6,

    /// <summary>
    /// Error when exceeding the maximum quantity of a resource for an account, indicates that the dynamic details object (<see cref="CloudError.Details"/>) can be cast to 
    /// <see cref="HetznerResourceLimitExceededErrorDetails"/>
    /// </summary>
    [EnumValue("resource_limit_exceeded")]
    ResourceLimitExceeded = 7,

    /// <summary>
    /// The requested resource is currently unavailable
    /// </summary>
    [EnumValue("resource_unavailable")]
    ResourceUnavailable = 8,

    /// <summary>
    /// Error within a service
    /// </summary>
    [EnumValue("service_error")]
    ServiceError = 9,

    /// <summary>
    /// One or more of the objects fields must be unique, indicates that the dynamic details object (<see cref="CloudError.Details"/>) can be cast to 
    /// <see cref="HetznerUniquenessErrorDetails"/>
    /// </summary>
    [EnumValue("uniqueness_error")]
    UniquenessError = 10,

    /// <summary>
    /// The Action you are trying to start is protected for this resource
    /// </summary>
    [EnumValue("protected")]
    Protected = 11,

    /// <summary>
    /// Cannot perform operation due to maintenance
    /// </summary>
    [EnumValue("maintenance")]
    Maintenance = 12,

    /// <summary>
    /// The resource has changed during the request, please retry
    /// </summary>
    [EnumValue("conflict")]
    Conflict = 13,

    /// <summary>
    /// The corresponding resource does not support the Action
    /// </summary>
    [EnumValue("unsupported_error")]
    UnsupportedError = 14,

    /// <summary>
    /// The token is only allowed to perform GET requests
    /// </summary>
    [EnumValue("token_readonly")]
    TokenReadOnly = 15,

    /// <summary>
    /// A service or product is currently not available
    /// </summary>
    [EnumValue("unavailable")]
    Unavailable = 16,
    #endregion

    #region Certificate retry issuance or renewal
    /// <summary>
    /// CAA record does not allow certificate authority
    /// </summary>
    [EnumValue("caa_record_does_not_allow_ca")]
    CAARecordDoesNotAllowCA = 17,

    /// <summary>
    /// Certificate Authority: DNS validation failed
    /// </summary>
    [EnumValue("ca_dns_validation_failed")]
    CADnsValidationFailed = 18,

    /// <summary>
    /// Certificate Authority: Too many authorizations failed recently
    /// </summary>
    [EnumValue("ca_too_many_authorizations_failed_recently")]
    CATooManyAuthorizationsFailedRecently = 19,

    /// <summary>
    /// Certificate Authority: Too many certificates issued for registered domain
    /// </summary>
    [EnumValue("ca_too_many_certificates_issued_for_registered_domain")]
    CATooManyCertificatesIssuedForRegisteredDomain = 20,

    /// <summary>
    /// Certificate Authority: Too many duplicate certificates
    /// </summary>
    [EnumValue("ca_too_many_duplicate_certificates")]
    CATooManyDuplicateCertificates = 21,

    /// <summary>
    /// Could not verify domain delegated to zone
    /// </summary>
    [EnumValue("could_not_verify_domain_delegated_to_zone")]
    CouldNotVerifyDomainDelegatedToZone = 22,

    /// <summary>
    /// DNS zone not found
    /// </summary>
    [EnumValue("dns_zone_not_found")]
    DNSZoneNotFound = 23,

    /// <summary>
    /// DNS zone is a secondary zone
    /// </summary>
    [EnumValue("dns_zone_is_secondary_zone")]
    DNSZoneIsSecondaryZone = 24,
    #endregion

    #region Firewall
    /// <summary>
    /// Server added more than one time to resource
    /// </summary>
    [EnumValue("server_already_added")]
    ServerAlreadyAdded = 25,

    /// <summary>
    /// The Network type is incompatible for the given resource
    /// </summary>
    [EnumValue("incompatible_network_type")]
    IncompatibleNetworkType = 26,

    /// <summary>
    /// The resource the Firewall should be attached to was not found
    /// </summary>
    [EnumValue("firewall_resource_not_found")]
    FirewallResourceNotFound = 27,

    /// <summary>
    /// Firewall must not be in use to be deleted
    /// </summary>
    [EnumValue("resource_in_use")]
    ResourceInUse = 28,

    /// <summary>
    /// Firewall was already applied on resource
    /// </summary>
    [EnumValue("firewall_already_applied")]
    FirewallAlreadyApplied = 29,

    /// <summary>
    /// Firewall was already removed from the resource
    /// </summary>
    [EnumValue("firewall_already_removed")]
    FirewallAlreadyRemoved = 30,

    /// <summary>
    /// Firewall was applied via label selector and cannot be removed manually
    /// </summary>
    [EnumValue("firewall_managed_by_label_selector")]
    FirewallManagedByLabelSelector = 31,
    #endregion

    #region Load Balancer
    /// <summary>
    /// The IP you are trying to add as a target belongs to a Hetzner Cloud resource
    /// </summary>
    [EnumValue("cloud_resource_ip_not_allowed")]
    CloudResourceIpNotAllowed = 32,

    /// <summary>
    /// The IP is not owned by the owner of the project of the Load Balancer
    /// </summary>
    [EnumValue("ip_not_owned")]
    IpNotOwned = 33,

    /// <summary>
    /// The Load Balancer is not attached to a network
    /// </summary>
    [EnumValue("load_balancer_not_attached_to_network")]
    LoadBalancerNotAttachedToNetwork = 34,

    /// <summary>
    /// Robot was not available. The caller may retry the operation after a short delay.
    /// </summary>
    [EnumValue("robot_unavailable")]
    RobotUnavailable = 35,

    /// <summary>
    /// The server you are trying to add as a target is not attached to the same network as the Load Balancer
    /// </summary>
    [EnumValue("server_not_attached_to_network")]
    ServerNotAttachedToNetwork = 36,

    /// <summary>
    /// The source port you are trying to add is already in use
    /// </summary>
    [EnumValue("source_port_already_used")]
    SourcePortAlreadyUsed = 37,

    /// <summary>
    /// The Load Balancer target you are trying to define is already defined
    /// </summary>
    [EnumValue("target_already_defined")]
    TargetAlreadyDefined = 38,

    /// <summary>
    /// The Load Balancer is already attached to a network
    /// </summary>
    [EnumValue("load_balancer_already_attached")]
    LoadBalancerAlreadyAttached = 39,

    /// <summary>
    /// The provided Network IP is not available
    /// </summary>
    [EnumValue("ip_not_available")]
    IpNotAvailable = 40,

    /// <summary>
    /// No Subnet or IP is available for the Load Balancer within the network
    /// </summary>
    [EnumValue("no_subnet_available")]
    NoSubnetAvailable = 41,

    /// <summary>
    /// The Load Balancer type does not fit for the given Load Balancer
    /// </summary>
    [EnumValue("invalid_load_balancer_type")]
    InvalidLoadBalancerType = 42,

    /// <summary>
    /// The Load Balancer has targets that use the public IP instead of the private IP
    /// </summary>
    [EnumValue("targets_without_use_private_ip")]
    TargetsWithoutUsePrivateIp = 43,
    #endregion

    #region Primary IPs
    /// <summary>
    /// The specified server is running, but needs to be powered off
    /// </summary>
    [EnumValue("server_not_stopped")]
    ServerNotStopped = 44,

    /// <summary>
    /// Primary ip is already assigned to a different server
    /// </summary>
    [EnumValue("primary_ip_already_assigned")]
    PrimaryIpAlreadyAssigned = 45,

    /// <summary>
    /// The server already has an ipv4 address
    /// </summary>
    [EnumValue("server_has_ipv4")]
    ServerHasIpv4 = 46,

    /// <summary>
    /// The server already has an ipv6 address
    /// </summary>
    [EnumValue("server_has_ipv6")]
    ServerHasIpv6 = 47,

    /// <summary>
    /// The server ipv4 address is a loadbalancer target
    /// </summary>
    [EnumValue("server_is_load_balancer_target")]
    ServerIsLoadBalancerTarget = 48,
    #endregion

    #region Servers
    /// <summary>
    /// An error during the placement occurred
    /// </summary>
    [EnumValue("placement_error")]
    PlacementError = 49,

    /// <summary>
    /// The specified Primary IP is already assigned to a server
    /// </summary>
    [EnumValue("primary_ip_assigned")]
    PrimaryIpAssigned = 50,

    /// <summary>
    /// The specified Primary IP is in a different datacenter
    /// </summary>
    [EnumValue("primary_ip_datacenter_mismatch")]
    PrimaryIpDatacenterMismatch = 51,

    /// <summary>
    /// The specified Primary IP has the wrong IP Version
    /// </summary>
    [EnumValue("primary_ip_version_mismatch")]
    PrimaryIpVersionMismatch = 52,

    /// <summary>
    /// The server is already attached to the network
    /// </summary>
    [EnumValue("server_already_attached")]
    ServerAlreadyAttached = 53,

    /// <summary>
    /// The network IP range overlaps with one of the server networks
    /// </summary>
    [EnumValue("networks_overlap")]
    NetworksOverlap = 54,

    /// <summary>
    /// The server type does not fit for the given server or is deprecated
    /// </summary>
    [EnumValue("invalid_server_type")]
    InvalidServerType = 55,

    /// <summary>
    /// There is no volume space left in the given location
    /// </summary>
    [EnumValue("no_space_left_in_location")]
    NoSpaceLeftInLocation = 56,
    #endregion

    /// <summary>
    /// This is not communicated by Hetzner, it is an extra addition for cases whereby an error code was not received. 
    /// </summary>
    Unknown = 500
}