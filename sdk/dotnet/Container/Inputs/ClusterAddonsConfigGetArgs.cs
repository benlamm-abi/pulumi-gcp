// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Container.Inputs
{

    public sealed class ClusterAddonsConfigGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// . Structure is documented below.
        /// </summary>
        [Input("cloudrunConfig")]
        public Input<Inputs.ClusterAddonsConfigCloudrunConfigGetArgs>? CloudrunConfig { get; set; }

        /// <summary>
        /// .
        /// The status of the ConfigConnector addon. It is disabled by default; Set `enabled = true` to enable.
        /// </summary>
        [Input("configConnectorConfig")]
        public Input<Inputs.ClusterAddonsConfigConfigConnectorConfigGetArgs>? ConfigConnectorConfig { get; set; }

        /// <summary>
        /// .
        /// The status of the NodeLocal DNSCache addon. It is disabled by default.
        /// Set `enabled = true` to enable.
        /// </summary>
        [Input("dnsCacheConfig")]
        public Input<Inputs.ClusterAddonsConfigDnsCacheConfigGetArgs>? DnsCacheConfig { get; set; }

        /// <summary>
        /// .
        /// Whether this cluster should enable the Google Compute Engine Persistent Disk Container Storage Interface (CSI) Driver. Defaults to disabled; set `enabled = true` to enable.
        /// </summary>
        [Input("gcePersistentDiskCsiDriverConfig")]
        public Input<Inputs.ClusterAddonsConfigGcePersistentDiskCsiDriverConfigGetArgs>? GcePersistentDiskCsiDriverConfig { get; set; }

        /// <summary>
        /// The status of the Filestore CSI driver addon,
        /// which allows the usage of filestore instance as volumes.
        /// It is disabled by default; set `enabled = true` to enable.
        /// </summary>
        [Input("gcpFilestoreCsiDriverConfig")]
        public Input<Inputs.ClusterAddonsConfigGcpFilestoreCsiDriverConfigGetArgs>? GcpFilestoreCsiDriverConfig { get; set; }

        /// <summary>
        /// ).
        /// The status of the Backup for GKE agent addon. It is disabled by default; Set `enabled = true` to enable.
        /// </summary>
        [Input("gkeBackupAgentConfig")]
        public Input<Inputs.ClusterAddonsConfigGkeBackupAgentConfigGetArgs>? GkeBackupAgentConfig { get; set; }

        /// <summary>
        /// The status of the Horizontal Pod Autoscaling
        /// addon, which increases or decreases the number of replica pods a replication controller
        /// has based on the resource usage of the existing pods.
        /// It is enabled by default;
        /// set `disabled = true` to disable.
        /// </summary>
        [Input("horizontalPodAutoscaling")]
        public Input<Inputs.ClusterAddonsConfigHorizontalPodAutoscalingGetArgs>? HorizontalPodAutoscaling { get; set; }

        /// <summary>
        /// The status of the HTTP (L7) load balancing
        /// controller addon, which makes it easy to set up HTTP load balancers for services in a
        /// cluster. It is enabled by default; set `disabled = true` to disable.
        /// </summary>
        [Input("httpLoadBalancing")]
        public Input<Inputs.ClusterAddonsConfigHttpLoadBalancingGetArgs>? HttpLoadBalancing { get; set; }

        /// <summary>
        /// .
        /// Structure is documented below.
        /// </summary>
        [Input("istioConfig")]
        public Input<Inputs.ClusterAddonsConfigIstioConfigGetArgs>? IstioConfig { get; set; }

        /// <summary>
        /// .
        /// Configuration for the KALM addon, which manages the lifecycle of k8s. It is disabled by default; Set `enabled = true` to enable.
        /// </summary>
        [Input("kalmConfig")]
        public Input<Inputs.ClusterAddonsConfigKalmConfigGetArgs>? KalmConfig { get; set; }

        /// <summary>
        /// Whether we should enable the network policy addon
        /// for the master.  This must be enabled in order to enable network policy for the nodes.
        /// To enable this, you must also define a `network_policy` block,
        /// otherwise nothing will happen.
        /// It can only be disabled if the nodes already do not have network policies enabled.
        /// Defaults to disabled; set `disabled = false` to enable.
        /// </summary>
        [Input("networkPolicyConfig")]
        public Input<Inputs.ClusterAddonsConfigNetworkPolicyConfigGetArgs>? NetworkPolicyConfig { get; set; }

        public ClusterAddonsConfigGetArgs()
        {
        }
    }
}
