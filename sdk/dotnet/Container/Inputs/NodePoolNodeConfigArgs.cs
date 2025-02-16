// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Container.Inputs
{

    public sealed class NodePoolNodeConfigArgs : Pulumi.ResourceArgs
    {
        [Input("bootDiskKmsKey")]
        public Input<string>? BootDiskKmsKey { get; set; }

        [Input("diskSizeGb")]
        public Input<int>? DiskSizeGb { get; set; }

        [Input("diskType")]
        public Input<string>? DiskType { get; set; }

        [Input("ephemeralStorageConfig")]
        public Input<Inputs.NodePoolNodeConfigEphemeralStorageConfigArgs>? EphemeralStorageConfig { get; set; }

        [Input("gcfsConfig")]
        public Input<Inputs.NodePoolNodeConfigGcfsConfigArgs>? GcfsConfig { get; set; }

        [Input("guestAccelerators")]
        private InputList<Inputs.NodePoolNodeConfigGuestAcceleratorArgs>? _guestAccelerators;
        public InputList<Inputs.NodePoolNodeConfigGuestAcceleratorArgs> GuestAccelerators
        {
            get => _guestAccelerators ?? (_guestAccelerators = new InputList<Inputs.NodePoolNodeConfigGuestAcceleratorArgs>());
            set => _guestAccelerators = value;
        }

        [Input("gvnic")]
        public Input<Inputs.NodePoolNodeConfigGvnicArgs>? Gvnic { get; set; }

        [Input("imageType")]
        public Input<string>? ImageType { get; set; }

        [Input("kubeletConfig")]
        public Input<Inputs.NodePoolNodeConfigKubeletConfigArgs>? KubeletConfig { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("linuxNodeConfig")]
        public Input<Inputs.NodePoolNodeConfigLinuxNodeConfigArgs>? LinuxNodeConfig { get; set; }

        [Input("localSsdCount")]
        public Input<int>? LocalSsdCount { get; set; }

        [Input("machineType")]
        public Input<string>? MachineType { get; set; }

        [Input("metadata")]
        private InputMap<string>? _metadata;
        public InputMap<string> Metadata
        {
            get => _metadata ?? (_metadata = new InputMap<string>());
            set => _metadata = value;
        }

        [Input("minCpuPlatform")]
        public Input<string>? MinCpuPlatform { get; set; }

        [Input("nodeGroup")]
        public Input<string>? NodeGroup { get; set; }

        [Input("oauthScopes")]
        private InputList<string>? _oauthScopes;
        public InputList<string> OauthScopes
        {
            get => _oauthScopes ?? (_oauthScopes = new InputList<string>());
            set => _oauthScopes = value;
        }

        [Input("preemptible")]
        public Input<bool>? Preemptible { get; set; }

        [Input("sandboxConfig")]
        public Input<Inputs.NodePoolNodeConfigSandboxConfigArgs>? SandboxConfig { get; set; }

        [Input("serviceAccount")]
        public Input<string>? ServiceAccount { get; set; }

        [Input("shieldedInstanceConfig")]
        public Input<Inputs.NodePoolNodeConfigShieldedInstanceConfigArgs>? ShieldedInstanceConfig { get; set; }

        [Input("spot")]
        public Input<bool>? Spot { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        [Input("taints")]
        private InputList<Inputs.NodePoolNodeConfigTaintArgs>? _taints;
        public InputList<Inputs.NodePoolNodeConfigTaintArgs> Taints
        {
            get => _taints ?? (_taints = new InputList<Inputs.NodePoolNodeConfigTaintArgs>());
            set => _taints = value;
        }

        [Input("workloadMetadataConfig")]
        public Input<Inputs.NodePoolNodeConfigWorkloadMetadataConfigArgs>? WorkloadMetadataConfig { get; set; }

        public NodePoolNodeConfigArgs()
        {
        }
    }
}
