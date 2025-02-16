// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Outputs
{

    [OutputType]
    public sealed class InstanceNetworkInterfaceIpv6AccessConfig
    {
        public readonly string? ExternalIpv6;
        public readonly string? ExternalIpv6PrefixLength;
        /// <summary>
        /// The service-level to be provided for IPv6 traffic when the
        /// subnet has an external subnet. Only PREMIUM or STANDARD tier is valid for IPv6.
        /// </summary>
        public readonly string NetworkTier;
        /// <summary>
        /// The domain name to be used when creating DNSv6
        /// records for the external IPv6 ranges..
        /// </summary>
        public readonly string? PublicPtrDomainName;

        [OutputConstructor]
        private InstanceNetworkInterfaceIpv6AccessConfig(
            string? externalIpv6,

            string? externalIpv6PrefixLength,

            string networkTier,

            string? publicPtrDomainName)
        {
            ExternalIpv6 = externalIpv6;
            ExternalIpv6PrefixLength = externalIpv6PrefixLength;
            NetworkTier = networkTier;
            PublicPtrDomainName = publicPtrDomainName;
        }
    }
}
