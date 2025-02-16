// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * An `Environment` in Apigee.
 *
 * To get more information about Environment, see:
 *
 * * [API documentation](https://cloud.google.com/apigee/docs/reference/apis/apigee/rest/v1/organizations.environments/create)
 * * How-to Guides
 *     * [Creating an environment](https://cloud.google.com/apigee/docs/api-platform/get-started/create-environment)
 *
 * ## Example Usage
 *
 * ## Import
 *
 * Environment can be imported using any of these accepted formats
 *
 * ```sh
 *  $ pulumi import gcp:apigee/environment:Environment default {{org_id}}/environments/{{name}}
 * ```
 *
 * ```sh
 *  $ pulumi import gcp:apigee/environment:Environment default {{org_id}}/{{name}}
 * ```
 */
export class Environment extends pulumi.CustomResource {
    /**
     * Get an existing Environment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: EnvironmentState, opts?: pulumi.CustomResourceOptions): Environment {
        return new Environment(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'gcp:apigee/environment:Environment';

    /**
     * Returns true if the given object is an instance of Environment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Environment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Environment.__pulumiType;
    }

    /**
     * Optional. API Proxy type supported by the environment. The type can be set when creating
     * the Environment and cannot be changed.
     * Possible values are `API_PROXY_TYPE_UNSPECIFIED`, `PROGRAMMABLE`, and `CONFIGURABLE`.
     */
    public readonly apiProxyType!: pulumi.Output<string>;
    /**
     * Optional. Deployment type supported by the environment. The deployment type can be
     * set when creating the environment and cannot be changed. When you enable archive
     * deployment, you will be prevented from performing a subset of actions within the
     * environment, including:
     * Managing the deployment of API proxy or shared flow revisions;
     * Creating, updating, or deleting resource files;
     * Creating, updating, or deleting target servers.
     * Possible values are `DEPLOYMENT_TYPE_UNSPECIFIED`, `PROXY`, and `ARCHIVE`.
     */
    public readonly deploymentType!: pulumi.Output<string>;
    /**
     * Description of the environment.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Display name of the environment.
     */
    public readonly displayName!: pulumi.Output<string | undefined>;
    /**
     * The resource ID of the environment.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The Apigee Organization associated with the Apigee environment,
     * in the format `organizations/{{org_name}}`.
     */
    public readonly orgId!: pulumi.Output<string>;

    /**
     * Create a Environment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: EnvironmentArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: EnvironmentArgs | EnvironmentState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as EnvironmentState | undefined;
            resourceInputs["apiProxyType"] = state ? state.apiProxyType : undefined;
            resourceInputs["deploymentType"] = state ? state.deploymentType : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["displayName"] = state ? state.displayName : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["orgId"] = state ? state.orgId : undefined;
        } else {
            const args = argsOrState as EnvironmentArgs | undefined;
            if ((!args || args.orgId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'orgId'");
            }
            resourceInputs["apiProxyType"] = args ? args.apiProxyType : undefined;
            resourceInputs["deploymentType"] = args ? args.deploymentType : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["displayName"] = args ? args.displayName : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["orgId"] = args ? args.orgId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Environment.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Environment resources.
 */
export interface EnvironmentState {
    /**
     * Optional. API Proxy type supported by the environment. The type can be set when creating
     * the Environment and cannot be changed.
     * Possible values are `API_PROXY_TYPE_UNSPECIFIED`, `PROGRAMMABLE`, and `CONFIGURABLE`.
     */
    apiProxyType?: pulumi.Input<string>;
    /**
     * Optional. Deployment type supported by the environment. The deployment type can be
     * set when creating the environment and cannot be changed. When you enable archive
     * deployment, you will be prevented from performing a subset of actions within the
     * environment, including:
     * Managing the deployment of API proxy or shared flow revisions;
     * Creating, updating, or deleting resource files;
     * Creating, updating, or deleting target servers.
     * Possible values are `DEPLOYMENT_TYPE_UNSPECIFIED`, `PROXY`, and `ARCHIVE`.
     */
    deploymentType?: pulumi.Input<string>;
    /**
     * Description of the environment.
     */
    description?: pulumi.Input<string>;
    /**
     * Display name of the environment.
     */
    displayName?: pulumi.Input<string>;
    /**
     * The resource ID of the environment.
     */
    name?: pulumi.Input<string>;
    /**
     * The Apigee Organization associated with the Apigee environment,
     * in the format `organizations/{{org_name}}`.
     */
    orgId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Environment resource.
 */
export interface EnvironmentArgs {
    /**
     * Optional. API Proxy type supported by the environment. The type can be set when creating
     * the Environment and cannot be changed.
     * Possible values are `API_PROXY_TYPE_UNSPECIFIED`, `PROGRAMMABLE`, and `CONFIGURABLE`.
     */
    apiProxyType?: pulumi.Input<string>;
    /**
     * Optional. Deployment type supported by the environment. The deployment type can be
     * set when creating the environment and cannot be changed. When you enable archive
     * deployment, you will be prevented from performing a subset of actions within the
     * environment, including:
     * Managing the deployment of API proxy or shared flow revisions;
     * Creating, updating, or deleting resource files;
     * Creating, updating, or deleting target servers.
     * Possible values are `DEPLOYMENT_TYPE_UNSPECIFIED`, `PROXY`, and `ARCHIVE`.
     */
    deploymentType?: pulumi.Input<string>;
    /**
     * Description of the environment.
     */
    description?: pulumi.Input<string>;
    /**
     * Display name of the environment.
     */
    displayName?: pulumi.Input<string>;
    /**
     * The resource ID of the environment.
     */
    name?: pulumi.Input<string>;
    /**
     * The Apigee Organization associated with the Apigee environment,
     * in the format `organizations/{{org_name}}`.
     */
    orgId: pulumi.Input<string>;
}
