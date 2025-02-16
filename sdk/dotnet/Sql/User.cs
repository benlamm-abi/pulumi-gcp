// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Sql
{
    /// <summary>
    /// Creates a new Google SQL User on a Google SQL User Instance. For more information, see the [official documentation](https://cloud.google.com/sql/), or the [JSON API](https://cloud.google.com/sql/docs/admin-api/v1beta4/users).
    /// 
    /// ## Example Usage
    /// 
    /// Example creating a SQL User.
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Gcp = Pulumi.Gcp;
    /// using Random = Pulumi.Random;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var dbNameSuffix = new Random.RandomId("dbNameSuffix", new Random.RandomIdArgs
    ///         {
    ///             ByteLength = 4,
    ///         });
    ///         var main = new Gcp.Sql.DatabaseInstance("main", new Gcp.Sql.DatabaseInstanceArgs
    ///         {
    ///             DatabaseVersion = "MYSQL_5_7",
    ///             Settings = new Gcp.Sql.Inputs.DatabaseInstanceSettingsArgs
    ///             {
    ///                 Tier = "db-f1-micro",
    ///             },
    ///         });
    ///         var users = new Gcp.Sql.User("users", new Gcp.Sql.UserArgs
    ///         {
    ///             Instance = main.Name,
    ///             Host = "me.com",
    ///             Password = "changeme",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// Example creating a Cloud IAM User. (For MySQL, specify `cloudsql_iam_authentication`)
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Gcp = Pulumi.Gcp;
    /// using Random = Pulumi.Random;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var dbNameSuffix = new Random.RandomId("dbNameSuffix", new Random.RandomIdArgs
    ///         {
    ///             ByteLength = 4,
    ///         });
    ///         var main = new Gcp.Sql.DatabaseInstance("main", new Gcp.Sql.DatabaseInstanceArgs
    ///         {
    ///             DatabaseVersion = "POSTGRES_9_6",
    ///             Settings = new Gcp.Sql.Inputs.DatabaseInstanceSettingsArgs
    ///             {
    ///                 Tier = "db-f1-micro",
    ///                 DatabaseFlags = 
    ///                 {
    ///                     new Gcp.Sql.Inputs.DatabaseInstanceSettingsDatabaseFlagArgs
    ///                     {
    ///                         Name = "cloudsql.iam_authentication",
    ///                         Value = "on",
    ///                     },
    ///                 },
    ///             },
    ///         });
    ///         var users = new Gcp.Sql.User("users", new Gcp.Sql.UserArgs
    ///         {
    ///             Instance = main.Name,
    ///             Type = "CLOUD_IAM_USER",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// SQL users for MySQL databases can be imported using the `project`, `instance`, `host` and `name`, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import gcp:sql/user:User users my-project/main-instance/my-domain.com/me
    /// ```
    /// 
    ///  SQL users for PostgreSQL databases can be imported using the `project`, `instance` and `name`, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import gcp:sql/user:User users my-project/main-instance/me
    /// ```
    /// </summary>
    [GcpResourceType("gcp:sql/user:User")]
    public partial class User : Pulumi.CustomResource
    {
        /// <summary>
        /// The deletion policy for the user.
        /// Setting `ABANDON` allows the resource to be abandoned rather than deleted. This is useful
        /// for Postgres, where users cannot be deleted from the API if they have been granted SQL roles.
        /// </summary>
        [Output("deletionPolicy")]
        public Output<string?> DeletionPolicy { get; private set; } = null!;

        /// <summary>
        /// The host the user can connect from. This is only supported
        /// for MySQL instances. Don't set this field for PostgreSQL instances.
        /// Can be an IP address. Changing this forces a new resource to be created.
        /// </summary>
        [Output("host")]
        public Output<string> Host { get; private set; } = null!;

        /// <summary>
        /// The name of the Cloud SQL instance. Changing this
        /// forces a new resource to be created.
        /// </summary>
        [Output("instance")]
        public Output<string> Instance { get; private set; } = null!;

        /// <summary>
        /// The name of the user. Changing this forces a new resource
        /// to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The password for the user. Can be updated. For Postgres
        /// instances this is a Required field, unless type is set to either CLOUD_IAM_USER
        /// or CLOUD_IAM_SERVICE_ACCOUNT.
        /// </summary>
        [Output("password")]
        public Output<string?> Password { get; private set; } = null!;

        /// <summary>
        /// The ID of the project in which the resource belongs. If it
        /// is not provided, the provider project is used.
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// The user type. It determines the method to authenticate the
        /// user during login. The default is the database's built-in user type. Flags
        /// include "BUILT_IN", "CLOUD_IAM_USER", or "CLOUD_IAM_SERVICE_ACCOUNT".
        /// </summary>
        [Output("type")]
        public Output<string?> Type { get; private set; } = null!;


        /// <summary>
        /// Create a User resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public User(string name, UserArgs args, CustomResourceOptions? options = null)
            : base("gcp:sql/user:User", name, args ?? new UserArgs(), MakeResourceOptions(options, ""))
        {
        }

        private User(string name, Input<string> id, UserState? state = null, CustomResourceOptions? options = null)
            : base("gcp:sql/user:User", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing User resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static User Get(string name, Input<string> id, UserState? state = null, CustomResourceOptions? options = null)
        {
            return new User(name, id, state, options);
        }
    }

    public sealed class UserArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The deletion policy for the user.
        /// Setting `ABANDON` allows the resource to be abandoned rather than deleted. This is useful
        /// for Postgres, where users cannot be deleted from the API if they have been granted SQL roles.
        /// </summary>
        [Input("deletionPolicy")]
        public Input<string>? DeletionPolicy { get; set; }

        /// <summary>
        /// The host the user can connect from. This is only supported
        /// for MySQL instances. Don't set this field for PostgreSQL instances.
        /// Can be an IP address. Changing this forces a new resource to be created.
        /// </summary>
        [Input("host")]
        public Input<string>? Host { get; set; }

        /// <summary>
        /// The name of the Cloud SQL instance. Changing this
        /// forces a new resource to be created.
        /// </summary>
        [Input("instance", required: true)]
        public Input<string> Instance { get; set; } = null!;

        /// <summary>
        /// The name of the user. Changing this forces a new resource
        /// to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The password for the user. Can be updated. For Postgres
        /// instances this is a Required field, unless type is set to either CLOUD_IAM_USER
        /// or CLOUD_IAM_SERVICE_ACCOUNT.
        /// </summary>
        [Input("password")]
        public Input<string>? Password { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs. If it
        /// is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// The user type. It determines the method to authenticate the
        /// user during login. The default is the database's built-in user type. Flags
        /// include "BUILT_IN", "CLOUD_IAM_USER", or "CLOUD_IAM_SERVICE_ACCOUNT".
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public UserArgs()
        {
        }
    }

    public sealed class UserState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The deletion policy for the user.
        /// Setting `ABANDON` allows the resource to be abandoned rather than deleted. This is useful
        /// for Postgres, where users cannot be deleted from the API if they have been granted SQL roles.
        /// </summary>
        [Input("deletionPolicy")]
        public Input<string>? DeletionPolicy { get; set; }

        /// <summary>
        /// The host the user can connect from. This is only supported
        /// for MySQL instances. Don't set this field for PostgreSQL instances.
        /// Can be an IP address. Changing this forces a new resource to be created.
        /// </summary>
        [Input("host")]
        public Input<string>? Host { get; set; }

        /// <summary>
        /// The name of the Cloud SQL instance. Changing this
        /// forces a new resource to be created.
        /// </summary>
        [Input("instance")]
        public Input<string>? Instance { get; set; }

        /// <summary>
        /// The name of the user. Changing this forces a new resource
        /// to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The password for the user. Can be updated. For Postgres
        /// instances this is a Required field, unless type is set to either CLOUD_IAM_USER
        /// or CLOUD_IAM_SERVICE_ACCOUNT.
        /// </summary>
        [Input("password")]
        public Input<string>? Password { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs. If it
        /// is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// The user type. It determines the method to authenticate the
        /// user during login. The default is the database's built-in user type. Flags
        /// include "BUILT_IN", "CLOUD_IAM_USER", or "CLOUD_IAM_SERVICE_ACCOUNT".
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public UserState()
        {
        }
    }
}
