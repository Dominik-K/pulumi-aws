// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2
{
    /// <summary>
    /// Provides a resource to create a VPC Internet Gateway.
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
    ///         var gw = new Aws.Ec2.InternetGateway("gw", new Aws.Ec2.InternetGatewayArgs
    ///         {
    ///             VpcId = aws_vpc.Main.Id,
    ///             Tags = 
    ///             {
    ///                 { "Name", "main" },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class InternetGateway : Pulumi.CustomResource
    {
        /// <summary>
        /// The ARN of the Internet Gateway.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// The ID of the AWS account that owns the internet gateway.
        /// </summary>
        [Output("ownerId")]
        public Output<string> OwnerId { get; private set; } = null!;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The VPC ID to create in.
        /// </summary>
        [Output("vpcId")]
        public Output<string?> VpcId { get; private set; } = null!;


        /// <summary>
        /// Create a InternetGateway resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public InternetGateway(string name, InternetGatewayArgs? args = null, CustomResourceOptions? options = null)
            : base("aws:ec2/internetGateway:InternetGateway", name, args ?? new InternetGatewayArgs(), MakeResourceOptions(options, ""))
        {
        }

        private InternetGateway(string name, Input<string> id, InternetGatewayState? state = null, CustomResourceOptions? options = null)
            : base("aws:ec2/internetGateway:InternetGateway", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing InternetGateway resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static InternetGateway Get(string name, Input<string> id, InternetGatewayState? state = null, CustomResourceOptions? options = null)
        {
            return new InternetGateway(name, id, state, options);
        }
    }

    public sealed class InternetGatewayArgs : Pulumi.ResourceArgs
    {
        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The VPC ID to create in.
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public InternetGatewayArgs()
        {
        }
    }

    public sealed class InternetGatewayState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ARN of the Internet Gateway.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// The ID of the AWS account that owns the internet gateway.
        /// </summary>
        [Input("ownerId")]
        public Input<string>? OwnerId { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The VPC ID to create in.
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public InternetGatewayState()
        {
        }
    }
}
