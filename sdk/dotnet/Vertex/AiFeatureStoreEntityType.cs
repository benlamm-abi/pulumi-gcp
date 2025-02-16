// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Vertex
{
    /// <summary>
    /// ## Example Usage
    /// ### Vertex Ai Featurestore Entitytype
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Gcp = Pulumi.Gcp;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var featurestore = new Gcp.Vertex.AiFeatureStore("featurestore", new Gcp.Vertex.AiFeatureStoreArgs
    ///         {
    ///             Labels = 
    ///             {
    ///                 { "foo", "bar" },
    ///             },
    ///             Region = "us-central1",
    ///             OnlineServingConfig = new Gcp.Vertex.Inputs.AiFeatureStoreOnlineServingConfigArgs
    ///             {
    ///                 FixedNodeCount = 2,
    ///             },
    ///         }, new CustomResourceOptions
    ///         {
    ///             Provider = google_beta,
    ///         });
    ///         var entity = new Gcp.Vertex.AiFeatureStoreEntityType("entity", new Gcp.Vertex.AiFeatureStoreEntityTypeArgs
    ///         {
    ///             Labels = 
    ///             {
    ///                 { "foo", "bar" },
    ///             },
    ///             Featurestore = featurestore.Id,
    ///             MonitoringConfig = new Gcp.Vertex.Inputs.AiFeatureStoreEntityTypeMonitoringConfigArgs
    ///             {
    ///                 SnapshotAnalysis = new Gcp.Vertex.Inputs.AiFeatureStoreEntityTypeMonitoringConfigSnapshotAnalysisArgs
    ///                 {
    ///                     Disabled = false,
    ///                     MonitoringInterval = "86400s",
    ///                 },
    ///             },
    ///         }, new CustomResourceOptions
    ///         {
    ///             Provider = google_beta,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// FeaturestoreEntitytype can be imported using any of these accepted formats
    /// 
    /// ```sh
    ///  $ pulumi import gcp:vertex/aiFeatureStoreEntityType:AiFeatureStoreEntityType default {{featurestore}}/entityTypes/{{name}}
    /// ```
    /// </summary>
    [GcpResourceType("gcp:vertex/aiFeatureStoreEntityType:AiFeatureStoreEntityType")]
    public partial class AiFeatureStoreEntityType : Pulumi.CustomResource
    {
        /// <summary>
        /// The timestamp of when the featurestore was created in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to
        /// nine fractional digits.
        /// </summary>
        [Output("createTime")]
        public Output<string> CreateTime { get; private set; } = null!;

        /// <summary>
        /// Used to perform consistent read-modify-write updates.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// The name of the Featurestore to use, in the format projects/{project}/locations/{location}/featurestores/{featurestore}.
        /// </summary>
        [Output("featurestore")]
        public Output<string> Featurestore { get; private set; } = null!;

        /// <summary>
        /// A set of key/value label pairs to assign to this EntityType.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        /// <summary>
        /// The default monitoring configuration for all Features under this EntityType.
        /// If this is populated with [FeaturestoreMonitoringConfig.monitoring_interval] specified, snapshot analysis monitoring is enabled. Otherwise, snapshot analysis monitoring is disabled.
        /// Structure is documented below.
        /// </summary>
        [Output("monitoringConfig")]
        public Output<Outputs.AiFeatureStoreEntityTypeMonitoringConfig?> MonitoringConfig { get; private set; } = null!;

        /// <summary>
        /// The name of the EntityType. This value may be up to 60 characters, and valid characters are [a-z0-9_]. The first character cannot be a number.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The timestamp of when the featurestore was last updated in RFC3339 UTC "Zulu" format, with nanosecond resolution and up
        /// to nine fractional digits.
        /// </summary>
        [Output("updateTime")]
        public Output<string> UpdateTime { get; private set; } = null!;


        /// <summary>
        /// Create a AiFeatureStoreEntityType resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AiFeatureStoreEntityType(string name, AiFeatureStoreEntityTypeArgs args, CustomResourceOptions? options = null)
            : base("gcp:vertex/aiFeatureStoreEntityType:AiFeatureStoreEntityType", name, args ?? new AiFeatureStoreEntityTypeArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AiFeatureStoreEntityType(string name, Input<string> id, AiFeatureStoreEntityTypeState? state = null, CustomResourceOptions? options = null)
            : base("gcp:vertex/aiFeatureStoreEntityType:AiFeatureStoreEntityType", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing AiFeatureStoreEntityType resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AiFeatureStoreEntityType Get(string name, Input<string> id, AiFeatureStoreEntityTypeState? state = null, CustomResourceOptions? options = null)
        {
            return new AiFeatureStoreEntityType(name, id, state, options);
        }
    }

    public sealed class AiFeatureStoreEntityTypeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Featurestore to use, in the format projects/{project}/locations/{location}/featurestores/{featurestore}.
        /// </summary>
        [Input("featurestore", required: true)]
        public Input<string> Featurestore { get; set; } = null!;

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to this EntityType.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// The default monitoring configuration for all Features under this EntityType.
        /// If this is populated with [FeaturestoreMonitoringConfig.monitoring_interval] specified, snapshot analysis monitoring is enabled. Otherwise, snapshot analysis monitoring is disabled.
        /// Structure is documented below.
        /// </summary>
        [Input("monitoringConfig")]
        public Input<Inputs.AiFeatureStoreEntityTypeMonitoringConfigArgs>? MonitoringConfig { get; set; }

        /// <summary>
        /// The name of the EntityType. This value may be up to 60 characters, and valid characters are [a-z0-9_]. The first character cannot be a number.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public AiFeatureStoreEntityTypeArgs()
        {
        }
    }

    public sealed class AiFeatureStoreEntityTypeState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The timestamp of when the featurestore was created in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to
        /// nine fractional digits.
        /// </summary>
        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        /// <summary>
        /// Used to perform consistent read-modify-write updates.
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        /// <summary>
        /// The name of the Featurestore to use, in the format projects/{project}/locations/{location}/featurestores/{featurestore}.
        /// </summary>
        [Input("featurestore")]
        public Input<string>? Featurestore { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to this EntityType.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// The default monitoring configuration for all Features under this EntityType.
        /// If this is populated with [FeaturestoreMonitoringConfig.monitoring_interval] specified, snapshot analysis monitoring is enabled. Otherwise, snapshot analysis monitoring is disabled.
        /// Structure is documented below.
        /// </summary>
        [Input("monitoringConfig")]
        public Input<Inputs.AiFeatureStoreEntityTypeMonitoringConfigGetArgs>? MonitoringConfig { get; set; }

        /// <summary>
        /// The name of the EntityType. This value may be up to 60 characters, and valid characters are [a-z0-9_]. The first character cannot be a number.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The timestamp of when the featurestore was last updated in RFC3339 UTC "Zulu" format, with nanosecond resolution and up
        /// to nine fractional digits.
        /// </summary>
        [Input("updateTime")]
        public Input<string>? UpdateTime { get; set; }

        public AiFeatureStoreEntityTypeState()
        {
        }
    }
}
