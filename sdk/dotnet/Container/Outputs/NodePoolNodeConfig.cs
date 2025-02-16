// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Container.Outputs
{

    [OutputType]
    public sealed class NodePoolNodeConfig
    {
        public readonly string? BootDiskKmsKey;
        public readonly int? DiskSizeGb;
        public readonly string? DiskType;
        public readonly Outputs.NodePoolNodeConfigEphemeralStorageConfig? EphemeralStorageConfig;
        public readonly Outputs.NodePoolNodeConfigGcfsConfig? GcfsConfig;
        public readonly ImmutableArray<Outputs.NodePoolNodeConfigGuestAccelerator> GuestAccelerators;
        public readonly Outputs.NodePoolNodeConfigGvnic? Gvnic;
        public readonly string? ImageType;
        public readonly Outputs.NodePoolNodeConfigKubeletConfig? KubeletConfig;
        public readonly ImmutableDictionary<string, string>? Labels;
        public readonly Outputs.NodePoolNodeConfigLinuxNodeConfig? LinuxNodeConfig;
        public readonly int? LocalSsdCount;
        public readonly string? MachineType;
        public readonly ImmutableDictionary<string, string>? Metadata;
        public readonly string? MinCpuPlatform;
        public readonly string? NodeGroup;
        public readonly ImmutableArray<string> OauthScopes;
        public readonly bool? Preemptible;
        public readonly Outputs.NodePoolNodeConfigSandboxConfig? SandboxConfig;
        public readonly string? ServiceAccount;
        public readonly Outputs.NodePoolNodeConfigShieldedInstanceConfig? ShieldedInstanceConfig;
        public readonly bool? Spot;
        public readonly ImmutableArray<string> Tags;
        public readonly ImmutableArray<Outputs.NodePoolNodeConfigTaint> Taints;
        public readonly Outputs.NodePoolNodeConfigWorkloadMetadataConfig? WorkloadMetadataConfig;

        [OutputConstructor]
        private NodePoolNodeConfig(
            string? bootDiskKmsKey,

            int? diskSizeGb,

            string? diskType,

            Outputs.NodePoolNodeConfigEphemeralStorageConfig? ephemeralStorageConfig,

            Outputs.NodePoolNodeConfigGcfsConfig? gcfsConfig,

            ImmutableArray<Outputs.NodePoolNodeConfigGuestAccelerator> guestAccelerators,

            Outputs.NodePoolNodeConfigGvnic? gvnic,

            string? imageType,

            Outputs.NodePoolNodeConfigKubeletConfig? kubeletConfig,

            ImmutableDictionary<string, string>? labels,

            Outputs.NodePoolNodeConfigLinuxNodeConfig? linuxNodeConfig,

            int? localSsdCount,

            string? machineType,

            ImmutableDictionary<string, string>? metadata,

            string? minCpuPlatform,

            string? nodeGroup,

            ImmutableArray<string> oauthScopes,

            bool? preemptible,

            Outputs.NodePoolNodeConfigSandboxConfig? sandboxConfig,

            string? serviceAccount,

            Outputs.NodePoolNodeConfigShieldedInstanceConfig? shieldedInstanceConfig,

            bool? spot,

            ImmutableArray<string> tags,

            ImmutableArray<Outputs.NodePoolNodeConfigTaint> taints,

            Outputs.NodePoolNodeConfigWorkloadMetadataConfig? workloadMetadataConfig)
        {
            BootDiskKmsKey = bootDiskKmsKey;
            DiskSizeGb = diskSizeGb;
            DiskType = diskType;
            EphemeralStorageConfig = ephemeralStorageConfig;
            GcfsConfig = gcfsConfig;
            GuestAccelerators = guestAccelerators;
            Gvnic = gvnic;
            ImageType = imageType;
            KubeletConfig = kubeletConfig;
            Labels = labels;
            LinuxNodeConfig = linuxNodeConfig;
            LocalSsdCount = localSsdCount;
            MachineType = machineType;
            Metadata = metadata;
            MinCpuPlatform = minCpuPlatform;
            NodeGroup = nodeGroup;
            OauthScopes = oauthScopes;
            Preemptible = preemptible;
            SandboxConfig = sandboxConfig;
            ServiceAccount = serviceAccount;
            ShieldedInstanceConfig = shieldedInstanceConfig;
            Spot = spot;
            Tags = tags;
            Taints = taints;
            WorkloadMetadataConfig = workloadMetadataConfig;
        }
    }
}
