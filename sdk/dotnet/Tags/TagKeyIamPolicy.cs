// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Tags
{
    /// <summary>
    /// Three different resources help you manage your IAM policy for Tags TagKey. Each of these resources serves a different use case:
    /// 
    /// * `gcp.tags.TagKeyIamPolicy`: Authoritative. Sets the IAM policy for the tagkey and replaces any existing policy already attached.
    /// * `gcp.tags.TagKeyIamBinding`: Authoritative for a given role. Updates the IAM policy to grant a role to a list of members. Other roles within the IAM policy for the tagkey are preserved.
    /// * `gcp.tags.TagKeyIamMember`: Non-authoritative. Updates the IAM policy to grant a role to a new member. Other members for the role for the tagkey are preserved.
    /// 
    /// &gt; **Note:** `gcp.tags.TagKeyIamPolicy` **cannot** be used in conjunction with `gcp.tags.TagKeyIamBinding` and `gcp.tags.TagKeyIamMember` or they will fight over what your policy should be.
    /// 
    /// &gt; **Note:** `gcp.tags.TagKeyIamBinding` resources **can be** used in conjunction with `gcp.tags.TagKeyIamMember` resources **only if** they do not grant privilege to the same role.
    /// 
    /// ## google\_tags\_tag\_key\_iam\_policy
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Gcp = Pulumi.Gcp;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var admin = Output.Create(Gcp.Organizations.GetIAMPolicy.InvokeAsync(new Gcp.Organizations.GetIAMPolicyArgs
    ///         {
    ///             Bindings = 
    ///             {
    ///                 new Gcp.Organizations.Inputs.GetIAMPolicyBindingArgs
    ///                 {
    ///                     Role = "roles/viewer",
    ///                     Members = 
    ///                     {
    ///                         "user:jane@example.com",
    ///                     },
    ///                 },
    ///             },
    ///         }));
    ///         var policy = new Gcp.Tags.TagKeyIamPolicy("policy", new Gcp.Tags.TagKeyIamPolicyArgs
    ///         {
    ///             TagKey = google_tags_tag_key.Key.Name,
    ///             PolicyData = admin.Apply(admin =&gt; admin.PolicyData),
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## google\_tags\_tag\_key\_iam\_binding
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Gcp = Pulumi.Gcp;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var binding = new Gcp.Tags.TagKeyIamBinding("binding", new Gcp.Tags.TagKeyIamBindingArgs
    ///         {
    ///             TagKey = google_tags_tag_key.Key.Name,
    ///             Role = "roles/viewer",
    ///             Members = 
    ///             {
    ///                 "user:jane@example.com",
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## google\_tags\_tag\_key\_iam\_member
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Gcp = Pulumi.Gcp;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var member = new Gcp.Tags.TagKeyIamMember("member", new Gcp.Tags.TagKeyIamMemberArgs
    ///         {
    ///             TagKey = google_tags_tag_key.Key.Name,
    ///             Role = "roles/viewer",
    ///             Member = "user:jane@example.com",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// For all import syntaxes, the "resource in question" can take any of the following forms* tagKeys/{{name}} * {{name}} Any variables not passed in the import command will be taken from the provider configuration. Tags tagkey IAM resources can be imported using the resource identifiers, role, and member. IAM member imports use space-delimited identifiersthe resource in question, the role, and the member identity, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import gcp:tags/tagKeyIamPolicy:TagKeyIamPolicy editor "tagKeys/{{tag_key}} roles/viewer user:jane@example.com"
    /// ```
    /// 
    ///  IAM binding imports use space-delimited identifiersthe resource in question and the role, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import gcp:tags/tagKeyIamPolicy:TagKeyIamPolicy editor "tagKeys/{{tag_key}} roles/viewer"
    /// ```
    /// 
    ///  IAM policy imports use the identifier of the resource in question, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import gcp:tags/tagKeyIamPolicy:TagKeyIamPolicy editor tagKeys/{{tag_key}}
    /// ```
    /// 
    ///  -&gt; **Custom Roles**If you're importing a IAM resource with a custom role, make sure to use the
    /// 
    /// full name of the custom role, e.g. `[projects/my-project|organizations/my-org]/roles/my-custom-role`.
    /// </summary>
    [GcpResourceType("gcp:tags/tagKeyIamPolicy:TagKeyIamPolicy")]
    public partial class TagKeyIamPolicy : Pulumi.CustomResource
    {
        /// <summary>
        /// (Computed) The etag of the IAM policy.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// The policy data generated by
        /// a `gcp.organizations.getIAMPolicy` data source.
        /// </summary>
        [Output("policyData")]
        public Output<string> PolicyData { get; private set; } = null!;

        /// <summary>
        /// Used to find the parent resource to bind the IAM policy to
        /// </summary>
        [Output("tagKey")]
        public Output<string> TagKey { get; private set; } = null!;


        /// <summary>
        /// Create a TagKeyIamPolicy resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public TagKeyIamPolicy(string name, TagKeyIamPolicyArgs args, CustomResourceOptions? options = null)
            : base("gcp:tags/tagKeyIamPolicy:TagKeyIamPolicy", name, args ?? new TagKeyIamPolicyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private TagKeyIamPolicy(string name, Input<string> id, TagKeyIamPolicyState? state = null, CustomResourceOptions? options = null)
            : base("gcp:tags/tagKeyIamPolicy:TagKeyIamPolicy", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing TagKeyIamPolicy resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static TagKeyIamPolicy Get(string name, Input<string> id, TagKeyIamPolicyState? state = null, CustomResourceOptions? options = null)
        {
            return new TagKeyIamPolicy(name, id, state, options);
        }
    }

    public sealed class TagKeyIamPolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The policy data generated by
        /// a `gcp.organizations.getIAMPolicy` data source.
        /// </summary>
        [Input("policyData", required: true)]
        public Input<string> PolicyData { get; set; } = null!;

        /// <summary>
        /// Used to find the parent resource to bind the IAM policy to
        /// </summary>
        [Input("tagKey", required: true)]
        public Input<string> TagKey { get; set; } = null!;

        public TagKeyIamPolicyArgs()
        {
        }
    }

    public sealed class TagKeyIamPolicyState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Computed) The etag of the IAM policy.
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        /// <summary>
        /// The policy data generated by
        /// a `gcp.organizations.getIAMPolicy` data source.
        /// </summary>
        [Input("policyData")]
        public Input<string>? PolicyData { get; set; }

        /// <summary>
        /// Used to find the parent resource to bind the IAM policy to
        /// </summary>
        [Input("tagKey")]
        public Input<string>? TagKey { get; set; }

        public TagKeyIamPolicyState()
        {
        }
    }
}
