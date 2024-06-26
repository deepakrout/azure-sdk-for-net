// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A single API Management service resource in List or Get response.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApiManagementServiceResource : ApimResource
    {
        /// <summary>
        /// Initializes a new instance of the ApiManagementServiceResource
        /// class.
        /// </summary>
        public ApiManagementServiceResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiManagementServiceResource
        /// class.
        /// </summary>
        /// <param name="publisherEmail">Publisher email.</param>
        /// <param name="publisherName">Publisher name.</param>
        /// <param name="sku">SKU properties of the API Management
        /// service.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type for API Management resource is set
        /// to Microsoft.ApiManagement.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="notificationSenderEmail">Email address from which the
        /// notification will be sent.</param>
        /// <param name="provisioningState">The current provisioning state of
        /// the API Management service which can be one of the following:
        /// Created/Activating/Succeeded/Updating/Failed/Stopped/Terminating/TerminationFailed/Deleted.</param>
        /// <param name="targetProvisioningState">The provisioning state of the
        /// API Management service, which is targeted by the long running
        /// operation started on the service.</param>
        /// <param name="createdAtUtc">Creation UTC date of the API Management
        /// service.The date conforms to the following format:
        /// `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601
        /// standard.</param>
        /// <param name="gatewayUrl">Gateway URL of the API Management
        /// service.</param>
        /// <param name="gatewayRegionalUrl">Gateway URL of the API Management
        /// service in the Default Region.</param>
        /// <param name="portalUrl">Publisher portal endpoint Url of the API
        /// Management service.</param>
        /// <param name="managementApiUrl">Management API endpoint URL of the
        /// API Management service.</param>
        /// <param name="scmUrl">SCM endpoint URL of the API Management
        /// service.</param>
        /// <param name="developerPortalUrl">DEveloper Portal endpoint URL of
        /// the API Management service.</param>
        /// <param name="hostnameConfigurations">Custom hostname configuration
        /// of the API Management service.</param>
        /// <param name="publicIPAddresses">Public Static Load Balanced IP
        /// addresses of the API Management service in Primary region.
        /// Available only for Basic, Standard, Premium and Isolated
        /// SKU.</param>
        /// <param name="privateIPAddresses">Private Static Load Balanced IP
        /// addresses of the API Management service in Primary region which is
        /// deployed in an Internal Virtual Network. Available only for Basic,
        /// Standard, Premium and Isolated SKU.</param>
        /// <param name="publicIpAddressId">Public Standard SKU IP V4 based IP
        /// address to be associated with Virtual Network deployed service in
        /// the region. Supported only for Developer and Premium SKU being
        /// deployed in Virtual Network.</param>
        /// <param name="publicNetworkAccess">Whether or not public endpoint
        /// access is allowed for this API Management service.  Value is
        /// optional but if passed in, must be 'Enabled' or 'Disabled'. If
        /// 'Disabled', private endpoints are the exclusive access method.
        /// Default value is 'Enabled'. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        /// <param name="virtualNetworkConfiguration">Virtual network
        /// configuration of the API Management service.</param>
        /// <param name="additionalLocations">Additional datacenter locations
        /// of the API Management service.</param>
        /// <param name="customProperties">Custom properties of the API
        /// Management service.&lt;/br&gt;Setting
        /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.TripleDes168`
        /// will disable the cipher TLS_RSA_WITH_3DES_EDE_CBC_SHA for all
        /// TLS(1.0, 1.1 and 1.2).&lt;/br&gt;Setting
        /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Protocols.Tls11`
        /// can be used to disable just TLS 1.1.&lt;/br&gt;Setting
        /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Protocols.Tls10`
        /// can be used to disable TLS 1.0 on an API Management
        /// service.&lt;/br&gt;Setting
        /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Backend.Protocols.Tls11`
        /// can be used to disable just TLS 1.1 for communications with
        /// backends.&lt;/br&gt;Setting
        /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Backend.Protocols.Tls10`
        /// can be used to disable TLS 1.0 for communications with
        /// backends.&lt;/br&gt;Setting
        /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Protocols.Server.Http2`
        /// can be used to enable HTTP2 protocol on an API Management
        /// service.&lt;/br&gt;Not specifying any of these properties on PATCH
        /// operation will reset omitted properties' values to their defaults.
        /// For all the settings except Http2 the default value is `True` if
        /// the service was created on or before April 1, 2018 and `False`
        /// otherwise. Http2 setting's default value is
        /// `False`.&lt;/br&gt;&lt;/br&gt;You can disable any of the following
        /// ciphers by using settings
        /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.[cipher_name]`:
        /// TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA,
        /// TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA,
        /// TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA,
        /// TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA,
        /// TLS_RSA_WITH_AES_128_GCM_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA256,
        /// TLS_RSA_WITH_AES_128_CBC_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA,
        /// TLS_RSA_WITH_AES_128_CBC_SHA. For example,
        /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.TLS_RSA_WITH_AES_128_CBC_SHA256`:`false`.
        /// The default value is `true` for them.&lt;/br&gt; Note: The
        /// following ciphers can't be disabled since they are required by
        /// internal platform components:
        /// TLS_AES_256_GCM_SHA384,TLS_AES_128_GCM_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384,TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256,TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384,TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256</param>
        /// <param name="certificates">List of Certificates that need to be
        /// installed in the API Management service. Max supported certificates
        /// that can be installed is 10.</param>
        /// <param name="enableClientCertificate">Property only meant to be
        /// used for Consumption SKU Service. This enforces a client
        /// certificate to be presented on each request to the gateway. This
        /// also enables the ability to authenticate the certificate in the
        /// policy on the gateway.</param>
        /// <param name="natGatewayState">Property can be used to enable NAT
        /// Gateway for this API Management service. Possible values include:
        /// 'Enabled', 'Disabled'</param>
        /// <param name="outboundPublicIPAddresses">Outbound public IPV4
        /// address prefixes associated with NAT Gateway deployed service.
        /// Available only for Premium SKU on stv2 platform.</param>
        /// <param name="disableGateway">Property only valid for an Api
        /// Management service deployed in multiple locations. This can be used
        /// to disable the gateway in master region.</param>
        /// <param name="virtualNetworkType">The type of VPN in which API
        /// Management service needs to be configured in. None (Default Value)
        /// means the API Management service is not part of any Virtual
        /// Network, External means the API Management deployment is set up
        /// inside a Virtual Network having an Internet Facing Endpoint, and
        /// Internal means that API Management deployment is setup inside a
        /// Virtual Network having an Intranet Facing Endpoint only. Possible
        /// values include: 'None', 'External', 'Internal'</param>
        /// <param name="apiVersionConstraint">Control Plane Apis version
        /// constraint for the API Management service.</param>
        /// <param name="restore">Undelete Api Management Service if it was
        /// previously soft-deleted. If this flag is specified and set to True
        /// all other properties will be ignored.</param>
        /// <param name="privateEndpointConnections">List of Private Endpoint
        /// Connections of this service.</param>
        /// <param name="platformVersion">Compute Platform Version running the
        /// service in this location. Possible values include: 'undetermined',
        /// 'stv1', 'stv2', 'mtv1'</param>
        /// <param name="identity">Managed service identity of the Api
        /// Management service.</param>
        /// <param name="systemData">Metadata pertaining to creation and last
        /// modification of the resource.</param>
        /// <param name="etag">ETag of the resource.</param>
        /// <param name="zones">A list of availability zones denoting where the
        /// resource needs to come from.</param>
        public ApiManagementServiceResource(string publisherEmail, string publisherName, ApiManagementServiceSkuProperties sku, string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string notificationSenderEmail = default(string), string provisioningState = default(string), string targetProvisioningState = default(string), System.DateTime? createdAtUtc = default(System.DateTime?), string gatewayUrl = default(string), string gatewayRegionalUrl = default(string), string portalUrl = default(string), string managementApiUrl = default(string), string scmUrl = default(string), string developerPortalUrl = default(string), IList<HostnameConfiguration> hostnameConfigurations = default(IList<HostnameConfiguration>), IList<string> publicIPAddresses = default(IList<string>), IList<string> privateIPAddresses = default(IList<string>), string publicIpAddressId = default(string), string publicNetworkAccess = default(string), VirtualNetworkConfiguration virtualNetworkConfiguration = default(VirtualNetworkConfiguration), IList<AdditionalLocation> additionalLocations = default(IList<AdditionalLocation>), IDictionary<string, string> customProperties = default(IDictionary<string, string>), IList<CertificateConfiguration> certificates = default(IList<CertificateConfiguration>), bool? enableClientCertificate = default(bool?), string natGatewayState = default(string), IList<string> outboundPublicIPAddresses = default(IList<string>), bool? disableGateway = default(bool?), string virtualNetworkType = default(string), ApiVersionConstraint apiVersionConstraint = default(ApiVersionConstraint), bool? restore = default(bool?), IList<RemotePrivateEndpointConnectionWrapper> privateEndpointConnections = default(IList<RemotePrivateEndpointConnectionWrapper>), string platformVersion = default(string), ApiManagementServiceIdentity identity = default(ApiManagementServiceIdentity), SystemData systemData = default(SystemData), string etag = default(string), IList<string> zones = default(IList<string>))
            : base(id, name, type, tags)
        {
            NotificationSenderEmail = notificationSenderEmail;
            ProvisioningState = provisioningState;
            TargetProvisioningState = targetProvisioningState;
            CreatedAtUtc = createdAtUtc;
            GatewayUrl = gatewayUrl;
            GatewayRegionalUrl = gatewayRegionalUrl;
            PortalUrl = portalUrl;
            ManagementApiUrl = managementApiUrl;
            ScmUrl = scmUrl;
            DeveloperPortalUrl = developerPortalUrl;
            HostnameConfigurations = hostnameConfigurations;
            PublicIPAddresses = publicIPAddresses;
            PrivateIPAddresses = privateIPAddresses;
            PublicIpAddressId = publicIpAddressId;
            PublicNetworkAccess = publicNetworkAccess;
            VirtualNetworkConfiguration = virtualNetworkConfiguration;
            AdditionalLocations = additionalLocations;
            CustomProperties = customProperties;
            Certificates = certificates;
            EnableClientCertificate = enableClientCertificate;
            NatGatewayState = natGatewayState;
            OutboundPublicIPAddresses = outboundPublicIPAddresses;
            DisableGateway = disableGateway;
            VirtualNetworkType = virtualNetworkType;
            ApiVersionConstraint = apiVersionConstraint;
            Restore = restore;
            PrivateEndpointConnections = privateEndpointConnections;
            PlatformVersion = platformVersion;
            PublisherEmail = publisherEmail;
            PublisherName = publisherName;
            Sku = sku;
            Identity = identity;
            SystemData = systemData;
            Location = location;
            Etag = etag;
            Zones = zones;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets email address from which the notification will be
        /// sent.
        /// </summary>
        [JsonProperty(PropertyName = "properties.notificationSenderEmail")]
        public string NotificationSenderEmail { get; set; }

        /// <summary>
        /// Gets the current provisioning state of the API Management service
        /// which can be one of the following:
        /// Created/Activating/Succeeded/Updating/Failed/Stopped/Terminating/TerminationFailed/Deleted.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the API Management service, which is
        /// targeted by the long running operation started on the service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetProvisioningState")]
        public string TargetProvisioningState { get; private set; }

        /// <summary>
        /// Gets creation UTC date of the API Management service.The date
        /// conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as
        /// specified by the ISO 8601 standard.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAtUtc")]
        public System.DateTime? CreatedAtUtc { get; private set; }

        /// <summary>
        /// Gets gateway URL of the API Management service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.gatewayUrl")]
        public string GatewayUrl { get; private set; }

        /// <summary>
        /// Gets gateway URL of the API Management service in the Default
        /// Region.
        /// </summary>
        [JsonProperty(PropertyName = "properties.gatewayRegionalUrl")]
        public string GatewayRegionalUrl { get; private set; }

        /// <summary>
        /// Gets publisher portal endpoint Url of the API Management service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.portalUrl")]
        public string PortalUrl { get; private set; }

        /// <summary>
        /// Gets management API endpoint URL of the API Management service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.managementApiUrl")]
        public string ManagementApiUrl { get; private set; }

        /// <summary>
        /// Gets SCM endpoint URL of the API Management service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scmUrl")]
        public string ScmUrl { get; private set; }

        /// <summary>
        /// Gets dEveloper Portal endpoint URL of the API Management service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.developerPortalUrl")]
        public string DeveloperPortalUrl { get; private set; }

        /// <summary>
        /// Gets or sets custom hostname configuration of the API Management
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostnameConfigurations")]
        public IList<HostnameConfiguration> HostnameConfigurations { get; set; }

        /// <summary>
        /// Gets public Static Load Balanced IP addresses of the API Management
        /// service in Primary region. Available only for Basic, Standard,
        /// Premium and Isolated SKU.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAddresses")]
        public IList<string> PublicIPAddresses { get; private set; }

        /// <summary>
        /// Gets private Static Load Balanced IP addresses of the API
        /// Management service in Primary region which is deployed in an
        /// Internal Virtual Network. Available only for Basic, Standard,
        /// Premium and Isolated SKU.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAddresses")]
        public IList<string> PrivateIPAddresses { get; private set; }

        /// <summary>
        /// Gets or sets public Standard SKU IP V4 based IP address to be
        /// associated with Virtual Network deployed service in the region.
        /// Supported only for Developer and Premium SKU being deployed in
        /// Virtual Network.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIpAddressId")]
        public string PublicIpAddressId { get; set; }

        /// <summary>
        /// Gets or sets whether or not public endpoint access is allowed for
        /// this API Management service.  Value is optional but if passed in,
        /// must be 'Enabled' or 'Disabled'. If 'Disabled', private endpoints
        /// are the exclusive access method. Default value is 'Enabled'.
        /// Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

        /// <summary>
        /// Gets or sets virtual network configuration of the API Management
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkConfiguration")]
        public VirtualNetworkConfiguration VirtualNetworkConfiguration { get; set; }

        /// <summary>
        /// Gets or sets additional datacenter locations of the API Management
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.additionalLocations")]
        public IList<AdditionalLocation> AdditionalLocations { get; set; }

        /// <summary>
        /// Gets or sets custom properties of the API Management
        /// service.&amp;lt;/br&amp;gt;Setting
        /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.TripleDes168`
        /// will disable the cipher TLS_RSA_WITH_3DES_EDE_CBC_SHA for all
        /// TLS(1.0, 1.1 and 1.2).&amp;lt;/br&amp;gt;Setting
        /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Protocols.Tls11`
        /// can be used to disable just TLS 1.1.&amp;lt;/br&amp;gt;Setting
        /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Protocols.Tls10`
        /// can be used to disable TLS 1.0 on an API Management
        /// service.&amp;lt;/br&amp;gt;Setting
        /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Backend.Protocols.Tls11`
        /// can be used to disable just TLS 1.1 for communications with
        /// backends.&amp;lt;/br&amp;gt;Setting
        /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Backend.Protocols.Tls10`
        /// can be used to disable TLS 1.0 for communications with
        /// backends.&amp;lt;/br&amp;gt;Setting
        /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Protocols.Server.Http2`
        /// can be used to enable HTTP2 protocol on an API Management
        /// service.&amp;lt;/br&amp;gt;Not specifying any of these properties
        /// on PATCH operation will reset omitted properties' values to their
        /// defaults. For all the settings except Http2 the default value is
        /// `True` if the service was created on or before April 1, 2018 and
        /// `False` otherwise. Http2 setting's default value is
        /// `False`.&amp;lt;/br&amp;gt;&amp;lt;/br&amp;gt;You can disable any
        /// of the following ciphers by using settings
        /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.[cipher_name]`:
        /// TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA,
        /// TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA,
        /// TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA,
        /// TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA,
        /// TLS_RSA_WITH_AES_128_GCM_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA256,
        /// TLS_RSA_WITH_AES_128_CBC_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA,
        /// TLS_RSA_WITH_AES_128_CBC_SHA. For example,
        /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.TLS_RSA_WITH_AES_128_CBC_SHA256`:`false`.
        /// The default value is `true` for them.&amp;lt;/br&amp;gt; Note: The
        /// following ciphers can't be disabled since they are required by
        /// internal platform components:
        /// TLS_AES_256_GCM_SHA384,TLS_AES_128_GCM_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384,TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256,TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384,TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256
        /// </summary>
        [JsonProperty(PropertyName = "properties.customProperties")]
        public IDictionary<string, string> CustomProperties { get; set; }

        /// <summary>
        /// Gets or sets list of Certificates that need to be installed in the
        /// API Management service. Max supported certificates that can be
        /// installed is 10.
        /// </summary>
        [JsonProperty(PropertyName = "properties.certificates")]
        public IList<CertificateConfiguration> Certificates { get; set; }

        /// <summary>
        /// Gets or sets property only meant to be used for Consumption SKU
        /// Service. This enforces a client certificate to be presented on each
        /// request to the gateway. This also enables the ability to
        /// authenticate the certificate in the policy on the gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableClientCertificate")]
        public bool? EnableClientCertificate { get; set; }

        /// <summary>
        /// Gets or sets property can be used to enable NAT Gateway for this
        /// API Management service. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.natGatewayState")]
        public string NatGatewayState { get; set; }

        /// <summary>
        /// Gets outbound public IPV4 address prefixes associated with NAT
        /// Gateway deployed service. Available only for Premium SKU on stv2
        /// platform.
        /// </summary>
        [JsonProperty(PropertyName = "properties.outboundPublicIPAddresses")]
        public IList<string> OutboundPublicIPAddresses { get; private set; }

        /// <summary>
        /// Gets or sets property only valid for an Api Management service
        /// deployed in multiple locations. This can be used to disable the
        /// gateway in master region.
        /// </summary>
        [JsonProperty(PropertyName = "properties.disableGateway")]
        public bool? DisableGateway { get; set; }

        /// <summary>
        /// Gets or sets the type of VPN in which API Management service needs
        /// to be configured in. None (Default Value) means the API Management
        /// service is not part of any Virtual Network, External means the API
        /// Management deployment is set up inside a Virtual Network having an
        /// Internet Facing Endpoint, and Internal means that API Management
        /// deployment is setup inside a Virtual Network having an Intranet
        /// Facing Endpoint only. Possible values include: 'None', 'External',
        /// 'Internal'
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkType")]
        public string VirtualNetworkType { get; set; }

        /// <summary>
        /// Gets or sets control Plane Apis version constraint for the API
        /// Management service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiVersionConstraint")]
        public ApiVersionConstraint ApiVersionConstraint { get; set; }

        /// <summary>
        /// Gets or sets undelete Api Management Service if it was previously
        /// soft-deleted. If this flag is specified and set to True all other
        /// properties will be ignored.
        /// </summary>
        [JsonProperty(PropertyName = "properties.restore")]
        public bool? Restore { get; set; }

        /// <summary>
        /// Gets or sets list of Private Endpoint Connections of this service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpointConnections")]
        public IList<RemotePrivateEndpointConnectionWrapper> PrivateEndpointConnections { get; set; }

        /// <summary>
        /// Gets compute Platform Version running the service in this location.
        /// Possible values include: 'undetermined', 'stv1', 'stv2', 'mtv1'
        /// </summary>
        [JsonProperty(PropertyName = "properties.platformVersion")]
        public string PlatformVersion { get; private set; }

        /// <summary>
        /// Gets or sets publisher email.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publisherEmail")]
        public string PublisherEmail { get; set; }

        /// <summary>
        /// Gets or sets publisher name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publisherName")]
        public string PublisherName { get; set; }

        /// <summary>
        /// Gets or sets SKU properties of the API Management service.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public ApiManagementServiceSkuProperties Sku { get; set; }

        /// <summary>
        /// Gets or sets managed service identity of the Api Management
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ApiManagementServiceIdentity Identity { get; set; }

        /// <summary>
        /// Gets metadata pertaining to creation and last modification of the
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Gets or sets resource location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets eTag of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets or sets a list of availability zones denoting where the
        /// resource needs to come from.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PublisherEmail == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PublisherEmail");
            }
            if (PublisherName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PublisherName");
            }
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (NotificationSenderEmail != null)
            {
                if (NotificationSenderEmail.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "NotificationSenderEmail", 100);
                }
            }
            if (HostnameConfigurations != null)
            {
                foreach (var element in HostnameConfigurations)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (VirtualNetworkConfiguration != null)
            {
                VirtualNetworkConfiguration.Validate();
            }
            if (AdditionalLocations != null)
            {
                foreach (var element1 in AdditionalLocations)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (Certificates != null)
            {
                foreach (var element2 in Certificates)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (PrivateEndpointConnections != null)
            {
                foreach (var element3 in PrivateEndpointConnections)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
            if (PublisherEmail != null)
            {
                if (PublisherEmail.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "PublisherEmail", 100);
                }
            }
            if (PublisherName != null)
            {
                if (PublisherName.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "PublisherName", 100);
                }
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
            if (Identity != null)
            {
                Identity.Validate();
            }
        }
    }
}
