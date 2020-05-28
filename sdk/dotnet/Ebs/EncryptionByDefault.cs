// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ebs
{
    /// <summary>
    /// Provides a resource to manage whether default EBS encryption is enabled for your AWS account in the current AWS region. To manage the default KMS key for the region, see the [`aws.ebs.DefaultKmsKey` resource](https://www.terraform.io/docs/providers/aws/r/ebs_default_kms_key.html).
    /// 
    /// &gt; **NOTE:** Removing this resource disables default EBS encryption.
    /// 
    /// ## Example Usage
    /// 
    /// 
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var example = new Aws.Ebs.EncryptionByDefault("example", new Aws.Ebs.EncryptionByDefaultArgs
    ///         {
    ///             Enabled = true,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class EncryptionByDefault : Pulumi.CustomResource
    {
        /// <summary>
        /// Whether or not default EBS encryption is enabled. Valid values are `true` or `false`. Defaults to `true`.
        /// </summary>
        [Output("enabled")]
        public Output<bool?> Enabled { get; private set; } = null!;


        /// <summary>
        /// Create a EncryptionByDefault resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public EncryptionByDefault(string name, EncryptionByDefaultArgs? args = null, CustomResourceOptions? options = null)
            : base("aws:ebs/encryptionByDefault:EncryptionByDefault", name, args ?? new EncryptionByDefaultArgs(), MakeResourceOptions(options, ""))
        {
        }

        private EncryptionByDefault(string name, Input<string> id, EncryptionByDefaultState? state = null, CustomResourceOptions? options = null)
            : base("aws:ebs/encryptionByDefault:EncryptionByDefault", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing EncryptionByDefault resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static EncryptionByDefault Get(string name, Input<string> id, EncryptionByDefaultState? state = null, CustomResourceOptions? options = null)
        {
            return new EncryptionByDefault(name, id, state, options);
        }
    }

    public sealed class EncryptionByDefaultArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether or not default EBS encryption is enabled. Valid values are `true` or `false`. Defaults to `true`.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        public EncryptionByDefaultArgs()
        {
        }
    }

    public sealed class EncryptionByDefaultState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether or not default EBS encryption is enabled. Valid values are `true` or `false`. Defaults to `true`.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        public EncryptionByDefaultState()
        {
        }
    }
}
