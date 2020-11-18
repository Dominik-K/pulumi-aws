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
    /// Provides a resource to manage the [default AWS VPC](http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/default-vpc.html)
    /// in the current region.
    /// 
    /// For AWS accounts created after 2013-12-04, each region comes with a Default VPC.
    /// **This is an advanced resource**, and has special caveats to be aware of when
    /// using it. Please read this document in its entirety before using this resource.
    /// 
    /// The `aws.ec2.DefaultVpc` behaves differently from normal resources, in that
    /// this provider does not _create_ this resource, but instead "adopts" it
    /// into management.
    /// 
    /// ## Example Usage
    /// 
    /// Basic usage with tags:
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var @default = new Aws.Ec2.DefaultVpc("default", new Aws.Ec2.DefaultVpcArgs
    ///         {
    ///             Tags = 
    ///             {
    ///                 { "Name", "Default VPC" },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class DefaultVpc : Pulumi.CustomResource
    {
        /// <summary>
        /// Amazon Resource Name (ARN) of VPC
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// Whether or not an Amazon-provided IPv6 CIDR
        /// block with a /56 prefix length for the VPC was assigned
        /// </summary>
        [Output("assignGeneratedIpv6CidrBlock")]
        public Output<bool> AssignGeneratedIpv6CidrBlock { get; private set; } = null!;

        /// <summary>
        /// The CIDR block of the VPC
        /// </summary>
        [Output("cidrBlock")]
        public Output<string> CidrBlock { get; private set; } = null!;

        /// <summary>
        /// The ID of the network ACL created by default on VPC creation
        /// </summary>
        [Output("defaultNetworkAclId")]
        public Output<string> DefaultNetworkAclId { get; private set; } = null!;

        /// <summary>
        /// The ID of the route table created by default on VPC creation
        /// </summary>
        [Output("defaultRouteTableId")]
        public Output<string> DefaultRouteTableId { get; private set; } = null!;

        /// <summary>
        /// The ID of the security group created by default on VPC creation
        /// </summary>
        [Output("defaultSecurityGroupId")]
        public Output<string> DefaultSecurityGroupId { get; private set; } = null!;

        [Output("dhcpOptionsId")]
        public Output<string> DhcpOptionsId { get; private set; } = null!;

        /// <summary>
        /// A boolean flag to enable/disable ClassicLink
        /// for the VPC. Only valid in regions and accounts that support EC2 Classic.
        /// See the [ClassicLink documentation](https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html) for more information. Defaults false.
        /// </summary>
        [Output("enableClassiclink")]
        public Output<bool> EnableClassiclink { get; private set; } = null!;

        [Output("enableClassiclinkDnsSupport")]
        public Output<bool> EnableClassiclinkDnsSupport { get; private set; } = null!;

        /// <summary>
        /// A boolean flag to enable/disable DNS hostnames in the VPC. Defaults false.
        /// </summary>
        [Output("enableDnsHostnames")]
        public Output<bool> EnableDnsHostnames { get; private set; } = null!;

        /// <summary>
        /// A boolean flag to enable/disable DNS support in the VPC. Defaults true.
        /// </summary>
        [Output("enableDnsSupport")]
        public Output<bool?> EnableDnsSupport { get; private set; } = null!;

        /// <summary>
        /// Tenancy of instances spin up within VPC.
        /// </summary>
        [Output("instanceTenancy")]
        public Output<string> InstanceTenancy { get; private set; } = null!;

        /// <summary>
        /// The association ID for the IPv6 CIDR block of the VPC
        /// </summary>
        [Output("ipv6AssociationId")]
        public Output<string> Ipv6AssociationId { get; private set; } = null!;

        /// <summary>
        /// The IPv6 CIDR block of the VPC
        /// </summary>
        [Output("ipv6CidrBlock")]
        public Output<string> Ipv6CidrBlock { get; private set; } = null!;

        /// <summary>
        /// The ID of the main route table associated with
        /// this VPC. Note that you can change a VPC's main route table by using an
        /// `aws.ec2.MainRouteTableAssociation`
        /// </summary>
        [Output("mainRouteTableId")]
        public Output<string> MainRouteTableId { get; private set; } = null!;

        /// <summary>
        /// The ID of the AWS account that owns the VPC.
        /// </summary>
        [Output("ownerId")]
        public Output<string> OwnerId { get; private set; } = null!;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a DefaultVpc resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DefaultVpc(string name, DefaultVpcArgs? args = null, CustomResourceOptions? options = null)
            : base("aws:ec2/defaultVpc:DefaultVpc", name, args ?? new DefaultVpcArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DefaultVpc(string name, Input<string> id, DefaultVpcState? state = null, CustomResourceOptions? options = null)
            : base("aws:ec2/defaultVpc:DefaultVpc", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing DefaultVpc resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DefaultVpc Get(string name, Input<string> id, DefaultVpcState? state = null, CustomResourceOptions? options = null)
        {
            return new DefaultVpc(name, id, state, options);
        }
    }

    public sealed class DefaultVpcArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A boolean flag to enable/disable ClassicLink
        /// for the VPC. Only valid in regions and accounts that support EC2 Classic.
        /// See the [ClassicLink documentation](https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html) for more information. Defaults false.
        /// </summary>
        [Input("enableClassiclink")]
        public Input<bool>? EnableClassiclink { get; set; }

        [Input("enableClassiclinkDnsSupport")]
        public Input<bool>? EnableClassiclinkDnsSupport { get; set; }

        /// <summary>
        /// A boolean flag to enable/disable DNS hostnames in the VPC. Defaults false.
        /// </summary>
        [Input("enableDnsHostnames")]
        public Input<bool>? EnableDnsHostnames { get; set; }

        /// <summary>
        /// A boolean flag to enable/disable DNS support in the VPC. Defaults true.
        /// </summary>
        [Input("enableDnsSupport")]
        public Input<bool>? EnableDnsSupport { get; set; }

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

        public DefaultVpcArgs()
        {
        }
    }

    public sealed class DefaultVpcState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Amazon Resource Name (ARN) of VPC
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// Whether or not an Amazon-provided IPv6 CIDR
        /// block with a /56 prefix length for the VPC was assigned
        /// </summary>
        [Input("assignGeneratedIpv6CidrBlock")]
        public Input<bool>? AssignGeneratedIpv6CidrBlock { get; set; }

        /// <summary>
        /// The CIDR block of the VPC
        /// </summary>
        [Input("cidrBlock")]
        public Input<string>? CidrBlock { get; set; }

        /// <summary>
        /// The ID of the network ACL created by default on VPC creation
        /// </summary>
        [Input("defaultNetworkAclId")]
        public Input<string>? DefaultNetworkAclId { get; set; }

        /// <summary>
        /// The ID of the route table created by default on VPC creation
        /// </summary>
        [Input("defaultRouteTableId")]
        public Input<string>? DefaultRouteTableId { get; set; }

        /// <summary>
        /// The ID of the security group created by default on VPC creation
        /// </summary>
        [Input("defaultSecurityGroupId")]
        public Input<string>? DefaultSecurityGroupId { get; set; }

        [Input("dhcpOptionsId")]
        public Input<string>? DhcpOptionsId { get; set; }

        /// <summary>
        /// A boolean flag to enable/disable ClassicLink
        /// for the VPC. Only valid in regions and accounts that support EC2 Classic.
        /// See the [ClassicLink documentation](https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html) for more information. Defaults false.
        /// </summary>
        [Input("enableClassiclink")]
        public Input<bool>? EnableClassiclink { get; set; }

        [Input("enableClassiclinkDnsSupport")]
        public Input<bool>? EnableClassiclinkDnsSupport { get; set; }

        /// <summary>
        /// A boolean flag to enable/disable DNS hostnames in the VPC. Defaults false.
        /// </summary>
        [Input("enableDnsHostnames")]
        public Input<bool>? EnableDnsHostnames { get; set; }

        /// <summary>
        /// A boolean flag to enable/disable DNS support in the VPC. Defaults true.
        /// </summary>
        [Input("enableDnsSupport")]
        public Input<bool>? EnableDnsSupport { get; set; }

        /// <summary>
        /// Tenancy of instances spin up within VPC.
        /// </summary>
        [Input("instanceTenancy")]
        public Input<string>? InstanceTenancy { get; set; }

        /// <summary>
        /// The association ID for the IPv6 CIDR block of the VPC
        /// </summary>
        [Input("ipv6AssociationId")]
        public Input<string>? Ipv6AssociationId { get; set; }

        /// <summary>
        /// The IPv6 CIDR block of the VPC
        /// </summary>
        [Input("ipv6CidrBlock")]
        public Input<string>? Ipv6CidrBlock { get; set; }

        /// <summary>
        /// The ID of the main route table associated with
        /// this VPC. Note that you can change a VPC's main route table by using an
        /// `aws.ec2.MainRouteTableAssociation`
        /// </summary>
        [Input("mainRouteTableId")]
        public Input<string>? MainRouteTableId { get; set; }

        /// <summary>
        /// The ID of the AWS account that owns the VPC.
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

        public DefaultVpcState()
        {
        }
    }
}
