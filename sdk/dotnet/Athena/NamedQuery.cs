// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Athena
{
    /// <summary>
    /// Provides an Athena Named Query resource.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var hogeBucket = new Aws.S3.Bucket("hogeBucket", new Aws.S3.BucketArgs
    ///         {
    ///         });
    ///         var testKey = new Aws.Kms.Key("testKey", new Aws.Kms.KeyArgs
    ///         {
    ///             DeletionWindowInDays = 7,
    ///             Description = "Athena KMS Key",
    ///         });
    ///         var testWorkgroup = new Aws.Athena.Workgroup("testWorkgroup", new Aws.Athena.WorkgroupArgs
    ///         {
    ///             Configuration = new Aws.Athena.Inputs.WorkgroupConfigurationArgs
    ///             {
    ///                 ResultConfiguration = new Aws.Athena.Inputs.WorkgroupConfigurationResultConfigurationArgs
    ///                 {
    ///                     EncryptionConfiguration = new Aws.Athena.Inputs.WorkgroupConfigurationResultConfigurationEncryptionConfigurationArgs
    ///                     {
    ///                         EncryptionOption = "SSE_KMS",
    ///                         KmsKeyArn = testKey.Arn,
    ///                     },
    ///                 },
    ///             },
    ///         });
    ///         var hogeDatabase = new Aws.Athena.Database("hogeDatabase", new Aws.Athena.DatabaseArgs
    ///         {
    ///             Name = "users",
    ///             Bucket = hogeBucket.Id,
    ///         });
    ///         var foo = new Aws.Athena.NamedQuery("foo", new Aws.Athena.NamedQueryArgs
    ///         {
    ///             Workgroup = testWorkgroup.Id,
    ///             Database = hogeDatabase.Name,
    ///             Query = hogeDatabase.Name.Apply(name =&gt; $"SELECT * FROM {name} limit 10;"),
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class NamedQuery : Pulumi.CustomResource
    {
        /// <summary>
        /// The database to which the query belongs.
        /// </summary>
        [Output("database")]
        public Output<string> Database { get; private set; } = null!;

        /// <summary>
        /// A brief explanation of the query. Maximum length of 1024.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The plain language name for the query. Maximum length of 128.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The text of the query itself. In other words, all query statements. Maximum length of 262144.
        /// </summary>
        [Output("query")]
        public Output<string> Query { get; private set; } = null!;

        /// <summary>
        /// The workgroup to which the query belongs. Defaults to `primary`
        /// </summary>
        [Output("workgroup")]
        public Output<string?> Workgroup { get; private set; } = null!;


        /// <summary>
        /// Create a NamedQuery resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NamedQuery(string name, NamedQueryArgs args, CustomResourceOptions? options = null)
            : base("aws:athena/namedQuery:NamedQuery", name, args ?? new NamedQueryArgs(), MakeResourceOptions(options, ""))
        {
        }

        private NamedQuery(string name, Input<string> id, NamedQueryState? state = null, CustomResourceOptions? options = null)
            : base("aws:athena/namedQuery:NamedQuery", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing NamedQuery resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NamedQuery Get(string name, Input<string> id, NamedQueryState? state = null, CustomResourceOptions? options = null)
        {
            return new NamedQuery(name, id, state, options);
        }
    }

    public sealed class NamedQueryArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The database to which the query belongs.
        /// </summary>
        [Input("database", required: true)]
        public Input<string> Database { get; set; } = null!;

        /// <summary>
        /// A brief explanation of the query. Maximum length of 1024.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The plain language name for the query. Maximum length of 128.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The text of the query itself. In other words, all query statements. Maximum length of 262144.
        /// </summary>
        [Input("query", required: true)]
        public Input<string> Query { get; set; } = null!;

        /// <summary>
        /// The workgroup to which the query belongs. Defaults to `primary`
        /// </summary>
        [Input("workgroup")]
        public Input<string>? Workgroup { get; set; }

        public NamedQueryArgs()
        {
        }
    }

    public sealed class NamedQueryState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The database to which the query belongs.
        /// </summary>
        [Input("database")]
        public Input<string>? Database { get; set; }

        /// <summary>
        /// A brief explanation of the query. Maximum length of 1024.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The plain language name for the query. Maximum length of 128.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The text of the query itself. In other words, all query statements. Maximum length of 262144.
        /// </summary>
        [Input("query")]
        public Input<string>? Query { get; set; }

        /// <summary>
        /// The workgroup to which the query belongs. Defaults to `primary`
        /// </summary>
        [Input("workgroup")]
        public Input<string>? Workgroup { get; set; }

        public NamedQueryState()
        {
        }
    }
}
