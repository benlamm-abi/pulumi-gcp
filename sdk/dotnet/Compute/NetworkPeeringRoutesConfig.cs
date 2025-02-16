// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute
{
    /// <summary>
    /// Manage a network peering's route settings without managing the peering as
    /// a whole. This resource is primarily intended for use with GCP-generated
    /// peerings that shouldn't otherwise be managed by other tools. Deleting this
    /// resource is a no-op and the peering will not be modified.
    /// 
    /// To get more information about NetworkPeeringRoutesConfig, see:
    /// 
    /// * [API documentation](https://cloud.google.com/compute/docs/reference/rest/v1/networks/updatePeering)
    /// * How-to Guides
    ///     * [Official Documentation](https://cloud.google.com/vpc/docs/vpc-peering)
    /// 
    /// ## Example Usage
    /// ### Network Peering Routes Config Basic
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Gcp = Pulumi.Gcp;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var networkPrimary = new Gcp.Compute.Network("networkPrimary", new Gcp.Compute.NetworkArgs
    ///         {
    ///             AutoCreateSubnetworks = false,
    ///         });
    ///         var networkSecondary = new Gcp.Compute.Network("networkSecondary", new Gcp.Compute.NetworkArgs
    ///         {
    ///             AutoCreateSubnetworks = false,
    ///         });
    ///         var peeringPrimary = new Gcp.Compute.NetworkPeering("peeringPrimary", new Gcp.Compute.NetworkPeeringArgs
    ///         {
    ///             Network = networkPrimary.Id,
    ///             PeerNetwork = networkSecondary.Id,
    ///             ImportCustomRoutes = true,
    ///             ExportCustomRoutes = true,
    ///         });
    ///         var peeringPrimaryRoutes = new Gcp.Compute.NetworkPeeringRoutesConfig("peeringPrimaryRoutes", new Gcp.Compute.NetworkPeeringRoutesConfigArgs
    ///         {
    ///             Peering = peeringPrimary.Name,
    ///             Network = networkPrimary.Name,
    ///             ImportCustomRoutes = true,
    ///             ExportCustomRoutes = true,
    ///         });
    ///         var peeringSecondary = new Gcp.Compute.NetworkPeering("peeringSecondary", new Gcp.Compute.NetworkPeeringArgs
    ///         {
    ///             Network = networkSecondary.Id,
    ///             PeerNetwork = networkPrimary.Id,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ### Network Peering Routes Config Gke
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Gcp = Pulumi.Gcp;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var containerNetwork = new Gcp.Compute.Network("containerNetwork", new Gcp.Compute.NetworkArgs
    ///         {
    ///             AutoCreateSubnetworks = false,
    ///         });
    ///         var containerSubnetwork = new Gcp.Compute.Subnetwork("containerSubnetwork", new Gcp.Compute.SubnetworkArgs
    ///         {
    ///             Region = "us-central1",
    ///             Network = containerNetwork.Name,
    ///             IpCidrRange = "10.0.36.0/24",
    ///             PrivateIpGoogleAccess = true,
    ///             SecondaryIpRanges = 
    ///             {
    ///                 new Gcp.Compute.Inputs.SubnetworkSecondaryIpRangeArgs
    ///                 {
    ///                     RangeName = "pod",
    ///                     IpCidrRange = "10.0.0.0/19",
    ///                 },
    ///                 new Gcp.Compute.Inputs.SubnetworkSecondaryIpRangeArgs
    ///                 {
    ///                     RangeName = "svc",
    ///                     IpCidrRange = "10.0.32.0/22",
    ///                 },
    ///             },
    ///         });
    ///         var privateCluster = new Gcp.Container.Cluster("privateCluster", new Gcp.Container.ClusterArgs
    ///         {
    ///             Location = "us-central1-a",
    ///             InitialNodeCount = 1,
    ///             Network = containerNetwork.Name,
    ///             Subnetwork = containerSubnetwork.Name,
    ///             PrivateClusterConfig = new Gcp.Container.Inputs.ClusterPrivateClusterConfigArgs
    ///             {
    ///                 EnablePrivateEndpoint = true,
    ///                 EnablePrivateNodes = true,
    ///                 MasterIpv4CidrBlock = "10.42.0.0/28",
    ///             },
    ///             MasterAuthorizedNetworksConfig = ,
    ///             IpAllocationPolicy = new Gcp.Container.Inputs.ClusterIpAllocationPolicyArgs
    ///             {
    ///                 ClusterSecondaryRangeName = containerSubnetwork.SecondaryIpRanges.Apply(secondaryIpRanges =&gt; secondaryIpRanges[0].RangeName),
    ///                 ServicesSecondaryRangeName = containerSubnetwork.SecondaryIpRanges.Apply(secondaryIpRanges =&gt; secondaryIpRanges[1].RangeName),
    ///             },
    ///         });
    ///         var peeringGkeRoutes = new Gcp.Compute.NetworkPeeringRoutesConfig("peeringGkeRoutes", new Gcp.Compute.NetworkPeeringRoutesConfigArgs
    ///         {
    ///             Peering = privateCluster.PrivateClusterConfig.Apply(privateClusterConfig =&gt; privateClusterConfig.PeeringName),
    ///             Network = containerNetwork.Name,
    ///             ImportCustomRoutes = true,
    ///             ExportCustomRoutes = true,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// NetworkPeeringRoutesConfig can be imported using any of these accepted formats
    /// 
    /// ```sh
    ///  $ pulumi import gcp:compute/networkPeeringRoutesConfig:NetworkPeeringRoutesConfig default projects/{{project}}/global/networks/{{network}}/networkPeerings/{{peering}}
    /// ```
    /// 
    /// ```sh
    ///  $ pulumi import gcp:compute/networkPeeringRoutesConfig:NetworkPeeringRoutesConfig default {{project}}/{{network}}/{{peering}}
    /// ```
    /// 
    /// ```sh
    ///  $ pulumi import gcp:compute/networkPeeringRoutesConfig:NetworkPeeringRoutesConfig default {{network}}/{{peering}}
    /// ```
    /// </summary>
    [GcpResourceType("gcp:compute/networkPeeringRoutesConfig:NetworkPeeringRoutesConfig")]
    public partial class NetworkPeeringRoutesConfig : Pulumi.CustomResource
    {
        /// <summary>
        /// Whether to export the custom routes to the peer network.
        /// </summary>
        [Output("exportCustomRoutes")]
        public Output<bool> ExportCustomRoutes { get; private set; } = null!;

        /// <summary>
        /// Whether to import the custom routes to the peer network.
        /// </summary>
        [Output("importCustomRoutes")]
        public Output<bool> ImportCustomRoutes { get; private set; } = null!;

        /// <summary>
        /// The name of the primary network for the peering.
        /// </summary>
        [Output("network")]
        public Output<string> Network { get; private set; } = null!;

        /// <summary>
        /// Name of the peering.
        /// </summary>
        [Output("peering")]
        public Output<string> Peering { get; private set; } = null!;

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;


        /// <summary>
        /// Create a NetworkPeeringRoutesConfig resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NetworkPeeringRoutesConfig(string name, NetworkPeeringRoutesConfigArgs args, CustomResourceOptions? options = null)
            : base("gcp:compute/networkPeeringRoutesConfig:NetworkPeeringRoutesConfig", name, args ?? new NetworkPeeringRoutesConfigArgs(), MakeResourceOptions(options, ""))
        {
        }

        private NetworkPeeringRoutesConfig(string name, Input<string> id, NetworkPeeringRoutesConfigState? state = null, CustomResourceOptions? options = null)
            : base("gcp:compute/networkPeeringRoutesConfig:NetworkPeeringRoutesConfig", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing NetworkPeeringRoutesConfig resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NetworkPeeringRoutesConfig Get(string name, Input<string> id, NetworkPeeringRoutesConfigState? state = null, CustomResourceOptions? options = null)
        {
            return new NetworkPeeringRoutesConfig(name, id, state, options);
        }
    }

    public sealed class NetworkPeeringRoutesConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to export the custom routes to the peer network.
        /// </summary>
        [Input("exportCustomRoutes", required: true)]
        public Input<bool> ExportCustomRoutes { get; set; } = null!;

        /// <summary>
        /// Whether to import the custom routes to the peer network.
        /// </summary>
        [Input("importCustomRoutes", required: true)]
        public Input<bool> ImportCustomRoutes { get; set; } = null!;

        /// <summary>
        /// The name of the primary network for the peering.
        /// </summary>
        [Input("network", required: true)]
        public Input<string> Network { get; set; } = null!;

        /// <summary>
        /// Name of the peering.
        /// </summary>
        [Input("peering", required: true)]
        public Input<string> Peering { get; set; } = null!;

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        public NetworkPeeringRoutesConfigArgs()
        {
        }
    }

    public sealed class NetworkPeeringRoutesConfigState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to export the custom routes to the peer network.
        /// </summary>
        [Input("exportCustomRoutes")]
        public Input<bool>? ExportCustomRoutes { get; set; }

        /// <summary>
        /// Whether to import the custom routes to the peer network.
        /// </summary>
        [Input("importCustomRoutes")]
        public Input<bool>? ImportCustomRoutes { get; set; }

        /// <summary>
        /// The name of the primary network for the peering.
        /// </summary>
        [Input("network")]
        public Input<string>? Network { get; set; }

        /// <summary>
        /// Name of the peering.
        /// </summary>
        [Input("peering")]
        public Input<string>? Peering { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        public NetworkPeeringRoutesConfigState()
        {
        }
    }
}
