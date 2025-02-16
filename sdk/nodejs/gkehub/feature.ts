// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * ## Example Usage
 * ### Multi Cluster Ingress
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as gcp from "@pulumi/gcp";
 *
 * const cluster = new gcp.container.Cluster("cluster", {
 *     location: "us-central1-a",
 *     initialNodeCount: 1,
 * }, {
 *     provider: google_beta,
 * });
 * const membership = new gcp.gkehub.Membership("membership", {
 *     membershipId: "my-membership",
 *     endpoint: {
 *         gkeCluster: {
 *             resourceLink: pulumi.interpolate`//container.googleapis.com/${cluster.id}`,
 *         },
 *     },
 *     description: "Membership",
 * }, {
 *     provider: google_beta,
 * });
 * const feature = new gcp.gkehub.Feature("feature", {
 *     location: "global",
 *     spec: {
 *         multiclusteringress: {
 *             configMembership: membership.id,
 *         },
 *     },
 * }, {
 *     provider: google_beta,
 * });
 * ```
 * ### Multi Cluster Service Discovery
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as gcp from "@pulumi/gcp";
 *
 * const feature = new gcp.gkehub.Feature("feature", {
 *     location: "global",
 *     labels: {
 *         foo: "bar",
 *     },
 * }, {
 *     provider: google_beta,
 * });
 * ```
 *
 * ## Import
 *
 * Feature can be imported using any of these accepted formats
 *
 * ```sh
 *  $ pulumi import gcp:gkehub/feature:Feature default projects/{{project}}/locations/{{location}}/features/{{name}}
 * ```
 *
 * ```sh
 *  $ pulumi import gcp:gkehub/feature:Feature default {{project}}/{{location}}/{{name}}
 * ```
 *
 * ```sh
 *  $ pulumi import gcp:gkehub/feature:Feature default {{location}}/{{name}}
 * ```
 */
export class Feature extends pulumi.CustomResource {
    /**
     * Get an existing Feature resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: FeatureState, opts?: pulumi.CustomResourceOptions): Feature {
        return new Feature(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'gcp:gkehub/feature:Feature';

    /**
     * Returns true if the given object is an instance of Feature.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Feature {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Feature.__pulumiType;
    }

    /**
     * Output only. When the Feature resource was created.
     */
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    /**
     * Output only. When the Feature resource was deleted.
     */
    public /*out*/ readonly deleteTime!: pulumi.Output<string>;
    /**
     * GCP labels for this Feature.
     */
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The location for the resource
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The full, unique name of this Feature resource
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The project for the resource
     */
    public readonly project!: pulumi.Output<string>;
    /**
     * State of the Feature resource itself.
     */
    public /*out*/ readonly resourceStates!: pulumi.Output<outputs.gkehub.FeatureResourceState[]>;
    /**
     * Optional. Hub-wide Feature configuration. If this Feature does not support any Hub-wide configuration, this field may be unused.
     */
    public readonly spec!: pulumi.Output<outputs.gkehub.FeatureSpec | undefined>;
    /**
     * Output only. The Hub-wide Feature state
     */
    public /*out*/ readonly states!: pulumi.Output<outputs.gkehub.FeatureState[]>;
    /**
     * Output only. When the Feature resource was last updated.
     */
    public /*out*/ readonly updateTime!: pulumi.Output<string>;

    /**
     * Create a Feature resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: FeatureArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: FeatureArgs | FeatureState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as FeatureState | undefined;
            resourceInputs["createTime"] = state ? state.createTime : undefined;
            resourceInputs["deleteTime"] = state ? state.deleteTime : undefined;
            resourceInputs["labels"] = state ? state.labels : undefined;
            resourceInputs["location"] = state ? state.location : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["project"] = state ? state.project : undefined;
            resourceInputs["resourceStates"] = state ? state.resourceStates : undefined;
            resourceInputs["spec"] = state ? state.spec : undefined;
            resourceInputs["states"] = state ? state.states : undefined;
            resourceInputs["updateTime"] = state ? state.updateTime : undefined;
        } else {
            const args = argsOrState as FeatureArgs | undefined;
            if ((!args || args.location === undefined) && !opts.urn) {
                throw new Error("Missing required property 'location'");
            }
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["project"] = args ? args.project : undefined;
            resourceInputs["spec"] = args ? args.spec : undefined;
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["deleteTime"] = undefined /*out*/;
            resourceInputs["resourceStates"] = undefined /*out*/;
            resourceInputs["states"] = undefined /*out*/;
            resourceInputs["updateTime"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Feature.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Feature resources.
 */
export interface FeatureState {
    /**
     * Output only. When the Feature resource was created.
     */
    createTime?: pulumi.Input<string>;
    /**
     * Output only. When the Feature resource was deleted.
     */
    deleteTime?: pulumi.Input<string>;
    /**
     * GCP labels for this Feature.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The location for the resource
     */
    location?: pulumi.Input<string>;
    /**
     * The full, unique name of this Feature resource
     */
    name?: pulumi.Input<string>;
    /**
     * The project for the resource
     */
    project?: pulumi.Input<string>;
    /**
     * State of the Feature resource itself.
     */
    resourceStates?: pulumi.Input<pulumi.Input<inputs.gkehub.FeatureResourceState>[]>;
    /**
     * Optional. Hub-wide Feature configuration. If this Feature does not support any Hub-wide configuration, this field may be unused.
     */
    spec?: pulumi.Input<inputs.gkehub.FeatureSpec>;
    /**
     * Output only. The Hub-wide Feature state
     */
    states?: pulumi.Input<pulumi.Input<inputs.gkehub.FeatureState>[]>;
    /**
     * Output only. When the Feature resource was last updated.
     */
    updateTime?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Feature resource.
 */
export interface FeatureArgs {
    /**
     * GCP labels for this Feature.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The location for the resource
     */
    location: pulumi.Input<string>;
    /**
     * The full, unique name of this Feature resource
     */
    name?: pulumi.Input<string>;
    /**
     * The project for the resource
     */
    project?: pulumi.Input<string>;
    /**
     * Optional. Hub-wide Feature configuration. If this Feature does not support any Hub-wide configuration, this field may be unused.
     */
    spec?: pulumi.Input<inputs.gkehub.FeatureSpec>;
}
