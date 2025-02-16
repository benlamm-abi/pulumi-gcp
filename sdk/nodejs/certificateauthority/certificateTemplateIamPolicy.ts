// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * ## Import
 *
 * For all import syntaxes, the "resource in question" can take any of the following forms* projects/{{project}}/locations/{{location}}/certificateTemplates/{{name}} * {{project}}/{{location}}/{{name}} * {{location}}/{{name}} Any variables not passed in the import command will be taken from the provider configuration. Certificate Authority Service certificatetemplate IAM resources can be imported using the resource identifiers, role, and member. IAM member imports use space-delimited identifiersthe resource in question, the role, and the member identity, e.g.
 *
 * ```sh
 *  $ pulumi import gcp:certificateauthority/certificateTemplateIamPolicy:CertificateTemplateIamPolicy editor "projects/{{project}}/locations/{{location}}/certificateTemplates/{{certificate_template}} roles/privateca.templateUser user:jane@example.com"
 * ```
 *
 *  IAM binding imports use space-delimited identifiersthe resource in question and the role, e.g.
 *
 * ```sh
 *  $ pulumi import gcp:certificateauthority/certificateTemplateIamPolicy:CertificateTemplateIamPolicy editor "projects/{{project}}/locations/{{location}}/certificateTemplates/{{certificate_template}} roles/privateca.templateUser"
 * ```
 *
 *  IAM policy imports use the identifier of the resource in question, e.g.
 *
 * ```sh
 *  $ pulumi import gcp:certificateauthority/certificateTemplateIamPolicy:CertificateTemplateIamPolicy editor projects/{{project}}/locations/{{location}}/certificateTemplates/{{certificate_template}}
 * ```
 *
 *  -> **Custom Roles**If you're importing a IAM resource with a custom role, make sure to use the
 *
 * full name of the custom role, e.g. `[projects/my-project|organizations/my-org]/roles/my-custom-role`.
 */
export class CertificateTemplateIamPolicy extends pulumi.CustomResource {
    /**
     * Get an existing CertificateTemplateIamPolicy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CertificateTemplateIamPolicyState, opts?: pulumi.CustomResourceOptions): CertificateTemplateIamPolicy {
        return new CertificateTemplateIamPolicy(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'gcp:certificateauthority/certificateTemplateIamPolicy:CertificateTemplateIamPolicy';

    /**
     * Returns true if the given object is an instance of CertificateTemplateIamPolicy.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CertificateTemplateIamPolicy {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CertificateTemplateIamPolicy.__pulumiType;
    }

    /**
     * Used to find the parent resource to bind the IAM policy to
     */
    public readonly certificateTemplate!: pulumi.Output<string>;
    /**
     * (Computed) The etag of the IAM policy.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    public readonly location!: pulumi.Output<string>;
    /**
     * The policy data generated by
     * a `gcp.organizations.getIAMPolicy` data source.
     */
    public readonly policyData!: pulumi.Output<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the project will be parsed from the identifier of the parent resource. If no project is provided in the parent identifier and no project is specified, the provider project is used.
     */
    public readonly project!: pulumi.Output<string>;

    /**
     * Create a CertificateTemplateIamPolicy resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CertificateTemplateIamPolicyArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CertificateTemplateIamPolicyArgs | CertificateTemplateIamPolicyState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as CertificateTemplateIamPolicyState | undefined;
            resourceInputs["certificateTemplate"] = state ? state.certificateTemplate : undefined;
            resourceInputs["etag"] = state ? state.etag : undefined;
            resourceInputs["location"] = state ? state.location : undefined;
            resourceInputs["policyData"] = state ? state.policyData : undefined;
            resourceInputs["project"] = state ? state.project : undefined;
        } else {
            const args = argsOrState as CertificateTemplateIamPolicyArgs | undefined;
            if ((!args || args.certificateTemplate === undefined) && !opts.urn) {
                throw new Error("Missing required property 'certificateTemplate'");
            }
            if ((!args || args.policyData === undefined) && !opts.urn) {
                throw new Error("Missing required property 'policyData'");
            }
            resourceInputs["certificateTemplate"] = args ? args.certificateTemplate : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["policyData"] = args ? args.policyData : undefined;
            resourceInputs["project"] = args ? args.project : undefined;
            resourceInputs["etag"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(CertificateTemplateIamPolicy.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering CertificateTemplateIamPolicy resources.
 */
export interface CertificateTemplateIamPolicyState {
    /**
     * Used to find the parent resource to bind the IAM policy to
     */
    certificateTemplate?: pulumi.Input<string>;
    /**
     * (Computed) The etag of the IAM policy.
     */
    etag?: pulumi.Input<string>;
    location?: pulumi.Input<string>;
    /**
     * The policy data generated by
     * a `gcp.organizations.getIAMPolicy` data source.
     */
    policyData?: pulumi.Input<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the project will be parsed from the identifier of the parent resource. If no project is provided in the parent identifier and no project is specified, the provider project is used.
     */
    project?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a CertificateTemplateIamPolicy resource.
 */
export interface CertificateTemplateIamPolicyArgs {
    /**
     * Used to find the parent resource to bind the IAM policy to
     */
    certificateTemplate: pulumi.Input<string>;
    location?: pulumi.Input<string>;
    /**
     * The policy data generated by
     * a `gcp.organizations.getIAMPolicy` data source.
     */
    policyData: pulumi.Input<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the project will be parsed from the identifier of the parent resource. If no project is provided in the parent identifier and no project is specified, the provider project is used.
     */
    project?: pulumi.Input<string>;
}
