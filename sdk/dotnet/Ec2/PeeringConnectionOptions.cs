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
    /// Provides a resource to manage VPC peering connection options.
    /// 
    /// &gt; **NOTE on VPC Peering Connections and VPC Peering Connection Options:** This provider provides
    /// both a standalone VPC Peering Connection Options and a VPC Peering Connection
    /// resource with `accepter` and `requester` attributes. Do not manage options for the same VPC peering
    /// connection in both a VPC Peering Connection resource and a VPC Peering Connection Options resource.
    /// Doing so will cause a conflict of options and will overwrite the options.
    /// Using a VPC Peering Connection Options resource decouples management of the connection options from
    /// management of the VPC Peering Connection and allows options to be set correctly in cross-region and
    /// cross-account scenarios.
    /// 
    /// Basic usage:
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var fooVpc = new Aws.Ec2.Vpc("fooVpc", new Aws.Ec2.VpcArgs
    ///         {
    ///             CidrBlock = "10.0.0.0/16",
    ///         });
    ///         var bar = new Aws.Ec2.Vpc("bar", new Aws.Ec2.VpcArgs
    ///         {
    ///             CidrBlock = "10.1.0.0/16",
    ///         });
    ///         var fooVpcPeeringConnection = new Aws.Ec2.VpcPeeringConnection("fooVpcPeeringConnection", new Aws.Ec2.VpcPeeringConnectionArgs
    ///         {
    ///             AutoAccept = true,
    ///             PeerVpcId = bar.Id,
    ///             VpcId = fooVpc.Id,
    ///         });
    ///         var fooPeeringConnectionOptions = new Aws.Ec2.PeeringConnectionOptions("fooPeeringConnectionOptions", new Aws.Ec2.PeeringConnectionOptionsArgs
    ///         {
    ///             Accepter = new Aws.Ec2.Inputs.PeeringConnectionOptionsAccepterArgs
    ///             {
    ///                 AllowRemoteVpcDnsResolution = true,
    ///             },
    ///             Requester = new Aws.Ec2.Inputs.PeeringConnectionOptionsRequesterArgs
    ///             {
    ///                 AllowClassicLinkToRemoteVpc = true,
    ///                 AllowVpcToRemoteClassicLink = true,
    ///             },
    ///             VpcPeeringConnectionId = fooVpcPeeringConnection.Id,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// Basic cross-account usage:
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var requester = new Aws.Provider("requester", new Aws.ProviderArgs
    ///         {
    ///         });
    ///         var accepter = new Aws.Provider("accepter", new Aws.ProviderArgs
    ///         {
    ///         });
    ///         var main = new Aws.Ec2.Vpc("main", new Aws.Ec2.VpcArgs
    ///         {
    ///             CidrBlock = "10.0.0.0/16",
    ///             EnableDnsHostnames = true,
    ///             EnableDnsSupport = true,
    ///         });
    ///         var peerVpc = new Aws.Ec2.Vpc("peerVpc", new Aws.Ec2.VpcArgs
    ///         {
    ///             CidrBlock = "10.1.0.0/16",
    ///             EnableDnsHostnames = true,
    ///             EnableDnsSupport = true,
    ///         });
    ///         var peerCallerIdentity = Output.Create(Aws.GetCallerIdentity.InvokeAsync());
    ///         // Requester's side of the connection.
    ///         var peerVpcPeeringConnection = new Aws.Ec2.VpcPeeringConnection("peerVpcPeeringConnection", new Aws.Ec2.VpcPeeringConnectionArgs
    ///         {
    ///             AutoAccept = false,
    ///             PeerOwnerId = peerCallerIdentity.Apply(peerCallerIdentity =&gt; peerCallerIdentity.AccountId),
    ///             PeerVpcId = peerVpc.Id,
    ///             Tags = 
    ///             {
    ///                 { "Side", "Requester" },
    ///             },
    ///             VpcId = main.Id,
    ///         });
    ///         // Accepter's side of the connection.
    ///         var peerVpcPeeringConnectionAccepter = new Aws.Ec2.VpcPeeringConnectionAccepter("peerVpcPeeringConnectionAccepter", new Aws.Ec2.VpcPeeringConnectionAccepterArgs
    ///         {
    ///             AutoAccept = true,
    ///             Tags = 
    ///             {
    ///                 { "Side", "Accepter" },
    ///             },
    ///             VpcPeeringConnectionId = peerVpcPeeringConnection.Id,
    ///         });
    ///         var requesterPeeringConnectionOptions = new Aws.Ec2.PeeringConnectionOptions("requesterPeeringConnectionOptions", new Aws.Ec2.PeeringConnectionOptionsArgs
    ///         {
    ///             Requester = new Aws.Ec2.Inputs.PeeringConnectionOptionsRequesterArgs
    ///             {
    ///                 AllowRemoteVpcDnsResolution = true,
    ///             },
    ///             VpcPeeringConnectionId = peerVpcPeeringConnectionAccepter.Id,
    ///         });
    ///         var accepterPeeringConnectionOptions = new Aws.Ec2.PeeringConnectionOptions("accepterPeeringConnectionOptions", new Aws.Ec2.PeeringConnectionOptionsArgs
    ///         {
    ///             Accepter = new Aws.Ec2.Inputs.PeeringConnectionOptionsAccepterArgs
    ///             {
    ///                 AllowRemoteVpcDnsResolution = true,
    ///             },
    ///             VpcPeeringConnectionId = peerVpcPeeringConnectionAccepter.Id,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class PeeringConnectionOptions : Pulumi.CustomResource
    {
        /// <summary>
        /// An optional configuration block that allows for [VPC Peering Connection]
        /// (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options to be set for the VPC that accepts
        /// the peering connection (a maximum of one).
        /// </summary>
        [Output("accepter")]
        public Output<Outputs.PeeringConnectionOptionsAccepter> Accepter { get; private set; } = null!;

        /// <summary>
        /// A optional configuration block that allows for [VPC Peering Connection]
        /// (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options to be set for the VPC that requests
        /// the peering connection (a maximum of one).
        /// </summary>
        [Output("requester")]
        public Output<Outputs.PeeringConnectionOptionsRequester> Requester { get; private set; } = null!;

        /// <summary>
        /// The ID of the requester VPC peering connection.
        /// </summary>
        [Output("vpcPeeringConnectionId")]
        public Output<string> VpcPeeringConnectionId { get; private set; } = null!;


        /// <summary>
        /// Create a PeeringConnectionOptions resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PeeringConnectionOptions(string name, PeeringConnectionOptionsArgs args, CustomResourceOptions? options = null)
            : base("aws:ec2/peeringConnectionOptions:PeeringConnectionOptions", name, args ?? new PeeringConnectionOptionsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private PeeringConnectionOptions(string name, Input<string> id, PeeringConnectionOptionsState? state = null, CustomResourceOptions? options = null)
            : base("aws:ec2/peeringConnectionOptions:PeeringConnectionOptions", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing PeeringConnectionOptions resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PeeringConnectionOptions Get(string name, Input<string> id, PeeringConnectionOptionsState? state = null, CustomResourceOptions? options = null)
        {
            return new PeeringConnectionOptions(name, id, state, options);
        }
    }

    public sealed class PeeringConnectionOptionsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// An optional configuration block that allows for [VPC Peering Connection]
        /// (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options to be set for the VPC that accepts
        /// the peering connection (a maximum of one).
        /// </summary>
        [Input("accepter")]
        public Input<Inputs.PeeringConnectionOptionsAccepterArgs>? Accepter { get; set; }

        /// <summary>
        /// A optional configuration block that allows for [VPC Peering Connection]
        /// (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options to be set for the VPC that requests
        /// the peering connection (a maximum of one).
        /// </summary>
        [Input("requester")]
        public Input<Inputs.PeeringConnectionOptionsRequesterArgs>? Requester { get; set; }

        /// <summary>
        /// The ID of the requester VPC peering connection.
        /// </summary>
        [Input("vpcPeeringConnectionId", required: true)]
        public Input<string> VpcPeeringConnectionId { get; set; } = null!;

        public PeeringConnectionOptionsArgs()
        {
        }
    }

    public sealed class PeeringConnectionOptionsState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// An optional configuration block that allows for [VPC Peering Connection]
        /// (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options to be set for the VPC that accepts
        /// the peering connection (a maximum of one).
        /// </summary>
        [Input("accepter")]
        public Input<Inputs.PeeringConnectionOptionsAccepterGetArgs>? Accepter { get; set; }

        /// <summary>
        /// A optional configuration block that allows for [VPC Peering Connection]
        /// (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options to be set for the VPC that requests
        /// the peering connection (a maximum of one).
        /// </summary>
        [Input("requester")]
        public Input<Inputs.PeeringConnectionOptionsRequesterGetArgs>? Requester { get; set; }

        /// <summary>
        /// The ID of the requester VPC peering connection.
        /// </summary>
        [Input("vpcPeeringConnectionId")]
        public Input<string>? VpcPeeringConnectionId { get; set; }

        public PeeringConnectionOptionsState()
        {
        }
    }
}
