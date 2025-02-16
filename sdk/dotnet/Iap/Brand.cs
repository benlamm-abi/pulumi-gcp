// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Iap
{
    /// <summary>
    /// OAuth brand data. Only "Organization Internal" brands can be created
    /// programmatically via API. To convert it into an external brands
    /// please use the GCP Console.
    /// 
    /// &gt; **Note:** Brands can only be created once for a Google Cloud
    /// project and the underlying Google API doesn't not support DELETE or PATCH methods.
    /// Destroying a provider-managed Brand will remove it from state
    /// but *will not delete it from Google Cloud.*
    /// 
    /// To get more information about Brand, see:
    /// 
    /// * [API documentation](https://cloud.google.com/iap/docs/reference/rest/v1/projects.brands)
    /// * How-to Guides
    ///     * [Setting up IAP Brand](https://cloud.google.com/iap/docs/tutorial-gce#set_up_iap)
    /// 
    /// ## Example Usage
    /// 
    /// ## Import
    /// 
    /// Brand can be imported using any of these accepted formats
    /// 
    /// ```sh
    ///  $ pulumi import gcp:iap/brand:Brand default {{name}}
    /// ```
    /// </summary>
    [GcpResourceType("gcp:iap/brand:Brand")]
    public partial class Brand : Pulumi.CustomResource
    {
        /// <summary>
        /// Application name displayed on OAuth consent screen.
        /// </summary>
        [Output("applicationTitle")]
        public Output<string> ApplicationTitle { get; private set; } = null!;

        /// <summary>
        /// Output only. Identifier of the brand, in the format 'projects/{project_number}/brands/{brand_id}'. NOTE: The brand
        /// identification corresponds to the project number as only one brand per project can be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Whether the brand is only intended for usage inside the GSuite organization only.
        /// </summary>
        [Output("orgInternalOnly")]
        public Output<bool> OrgInternalOnly { get; private set; } = null!;

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// Support email displayed on the OAuth consent screen. Can be either a
        /// user or group email. When a user email is specified, the caller must
        /// be the user with the associated email address. When a group email is
        /// specified, the caller can be either a user or a service account which
        /// is an owner of the specified group in Cloud Identity.
        /// </summary>
        [Output("supportEmail")]
        public Output<string> SupportEmail { get; private set; } = null!;


        /// <summary>
        /// Create a Brand resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Brand(string name, BrandArgs args, CustomResourceOptions? options = null)
            : base("gcp:iap/brand:Brand", name, args ?? new BrandArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Brand(string name, Input<string> id, BrandState? state = null, CustomResourceOptions? options = null)
            : base("gcp:iap/brand:Brand", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Brand resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Brand Get(string name, Input<string> id, BrandState? state = null, CustomResourceOptions? options = null)
        {
            return new Brand(name, id, state, options);
        }
    }

    public sealed class BrandArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Application name displayed on OAuth consent screen.
        /// </summary>
        [Input("applicationTitle", required: true)]
        public Input<string> ApplicationTitle { get; set; } = null!;

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// Support email displayed on the OAuth consent screen. Can be either a
        /// user or group email. When a user email is specified, the caller must
        /// be the user with the associated email address. When a group email is
        /// specified, the caller can be either a user or a service account which
        /// is an owner of the specified group in Cloud Identity.
        /// </summary>
        [Input("supportEmail", required: true)]
        public Input<string> SupportEmail { get; set; } = null!;

        public BrandArgs()
        {
        }
    }

    public sealed class BrandState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Application name displayed on OAuth consent screen.
        /// </summary>
        [Input("applicationTitle")]
        public Input<string>? ApplicationTitle { get; set; }

        /// <summary>
        /// Output only. Identifier of the brand, in the format 'projects/{project_number}/brands/{brand_id}'. NOTE: The brand
        /// identification corresponds to the project number as only one brand per project can be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Whether the brand is only intended for usage inside the GSuite organization only.
        /// </summary>
        [Input("orgInternalOnly")]
        public Input<bool>? OrgInternalOnly { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// Support email displayed on the OAuth consent screen. Can be either a
        /// user or group email. When a user email is specified, the caller must
        /// be the user with the associated email address. When a group email is
        /// specified, the caller can be either a user or a service account which
        /// is an owner of the specified group in Cloud Identity.
        /// </summary>
        [Input("supportEmail")]
        public Input<string>? SupportEmail { get; set; }

        public BrandState()
        {
        }
    }
}
