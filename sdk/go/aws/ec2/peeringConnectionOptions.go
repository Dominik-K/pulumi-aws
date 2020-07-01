// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a resource to manage VPC peering connection options.
//
// > **NOTE on VPC Peering Connections and VPC Peering Connection Options:** This provider provides
// both a standalone VPC Peering Connection Options and a VPC Peering Connection
// resource with `accepter` and `requester` attributes. Do not manage options for the same VPC peering
// connection in both a VPC Peering Connection resource and a VPC Peering Connection Options resource.
// Doing so will cause a conflict of options and will overwrite the options.
// Using a VPC Peering Connection Options resource decouples management of the connection options from
// management of the VPC Peering Connection and allows options to be set correctly in cross-region and
// cross-account scenarios.
//
// Basic usage:
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/ec2"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		fooVpc, err := ec2.NewVpc(ctx, "fooVpc", &ec2.VpcArgs{
// 			CidrBlock: pulumi.String("10.0.0.0/16"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		bar, err := ec2.NewVpc(ctx, "bar", &ec2.VpcArgs{
// 			CidrBlock: pulumi.String("10.1.0.0/16"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		fooVpcPeeringConnection, err := ec2.NewVpcPeeringConnection(ctx, "fooVpcPeeringConnection", &ec2.VpcPeeringConnectionArgs{
// 			AutoAccept: pulumi.Bool(true),
// 			PeerVpcId:  bar.ID(),
// 			VpcId:      fooVpc.ID(),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = ec2.NewPeeringConnectionOptions(ctx, "fooPeeringConnectionOptions", &ec2.PeeringConnectionOptionsArgs{
// 			Accepter: &ec2.PeeringConnectionOptionsAccepterArgs{
// 				AllowRemoteVpcDnsResolution: pulumi.Bool(true),
// 			},
// 			Requester: &ec2.PeeringConnectionOptionsRequesterArgs{
// 				AllowClassicLinkToRemoteVpc: pulumi.Bool(true),
// 				AllowVpcToRemoteClassicLink: pulumi.Bool(true),
// 			},
// 			VpcPeeringConnectionId: fooVpcPeeringConnection.ID(),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
//
// Basic cross-account usage:
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws"
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/ec2"
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/providers"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := providers.Newaws(ctx, "requester", nil)
// 		if err != nil {
// 			return err
// 		}
// 		_, err = providers.Newaws(ctx, "accepter", nil)
// 		if err != nil {
// 			return err
// 		}
// 		main, err := ec2.NewVpc(ctx, "main", &ec2.VpcArgs{
// 			CidrBlock:          pulumi.String("10.0.0.0/16"),
// 			EnableDnsHostnames: pulumi.Bool(true),
// 			EnableDnsSupport:   pulumi.Bool(true),
// 		}, pulumi.Provider("aws.requester"))
// 		if err != nil {
// 			return err
// 		}
// 		peerVpc, err := ec2.NewVpc(ctx, "peerVpc", &ec2.VpcArgs{
// 			CidrBlock:          pulumi.String("10.1.0.0/16"),
// 			EnableDnsHostnames: pulumi.Bool(true),
// 			EnableDnsSupport:   pulumi.Bool(true),
// 		}, pulumi.Provider("aws.accepter"))
// 		if err != nil {
// 			return err
// 		}
// 		peerCallerIdentity, err := aws.GetCallerIdentity(ctx, nil, nil)
// 		if err != nil {
// 			return err
// 		}
// 		peerVpcPeeringConnection, err := ec2.NewVpcPeeringConnection(ctx, "peerVpcPeeringConnection", &ec2.VpcPeeringConnectionArgs{
// 			AutoAccept:  pulumi.Bool(false),
// 			PeerOwnerId: pulumi.String(peerCallerIdentity.AccountId),
// 			PeerVpcId:   peerVpc.ID(),
// 			Tags: pulumi.StringMap{
// 				"Side": pulumi.String("Requester"),
// 			},
// 			VpcId: main.ID(),
// 		}, pulumi.Provider("aws.requester"))
// 		if err != nil {
// 			return err
// 		}
// 		peerVpcPeeringConnectionAccepter, err := ec2.NewVpcPeeringConnectionAccepter(ctx, "peerVpcPeeringConnectionAccepter", &ec2.VpcPeeringConnectionAccepterArgs{
// 			AutoAccept: pulumi.Bool(true),
// 			Tags: pulumi.StringMap{
// 				"Side": pulumi.String("Accepter"),
// 			},
// 			VpcPeeringConnectionId: peerVpcPeeringConnection.ID(),
// 		}, pulumi.Provider("aws.accepter"))
// 		if err != nil {
// 			return err
// 		}
// 		_, err = ec2.NewPeeringConnectionOptions(ctx, "requesterPeeringConnectionOptions", &ec2.PeeringConnectionOptionsArgs{
// 			Requester: &ec2.PeeringConnectionOptionsRequesterArgs{
// 				AllowRemoteVpcDnsResolution: pulumi.Bool(true),
// 			},
// 			VpcPeeringConnectionId: peerVpcPeeringConnectionAccepter.ID(),
// 		}, pulumi.Provider("aws.requester"))
// 		if err != nil {
// 			return err
// 		}
// 		_, err = ec2.NewPeeringConnectionOptions(ctx, "accepterPeeringConnectionOptions", &ec2.PeeringConnectionOptionsArgs{
// 			Accepter: &ec2.PeeringConnectionOptionsAccepterArgs{
// 				AllowRemoteVpcDnsResolution: pulumi.Bool(true),
// 			},
// 			VpcPeeringConnectionId: peerVpcPeeringConnectionAccepter.ID(),
// 		}, pulumi.Provider("aws.accepter"))
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type PeeringConnectionOptions struct {
	pulumi.CustomResourceState

	// An optional configuration block that allows for [VPC Peering Connection]
	// (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options to be set for the VPC that accepts
	// the peering connection (a maximum of one).
	Accepter PeeringConnectionOptionsAccepterOutput `pulumi:"accepter"`
	// A optional configuration block that allows for [VPC Peering Connection]
	// (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options to be set for the VPC that requests
	// the peering connection (a maximum of one).
	Requester PeeringConnectionOptionsRequesterOutput `pulumi:"requester"`
	// The ID of the requester VPC peering connection.
	VpcPeeringConnectionId pulumi.StringOutput `pulumi:"vpcPeeringConnectionId"`
}

// NewPeeringConnectionOptions registers a new resource with the given unique name, arguments, and options.
func NewPeeringConnectionOptions(ctx *pulumi.Context,
	name string, args *PeeringConnectionOptionsArgs, opts ...pulumi.ResourceOption) (*PeeringConnectionOptions, error) {
	if args == nil || args.VpcPeeringConnectionId == nil {
		return nil, errors.New("missing required argument 'VpcPeeringConnectionId'")
	}
	if args == nil {
		args = &PeeringConnectionOptionsArgs{}
	}
	var resource PeeringConnectionOptions
	err := ctx.RegisterResource("aws:ec2/peeringConnectionOptions:PeeringConnectionOptions", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPeeringConnectionOptions gets an existing PeeringConnectionOptions resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPeeringConnectionOptions(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PeeringConnectionOptionsState, opts ...pulumi.ResourceOption) (*PeeringConnectionOptions, error) {
	var resource PeeringConnectionOptions
	err := ctx.ReadResource("aws:ec2/peeringConnectionOptions:PeeringConnectionOptions", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PeeringConnectionOptions resources.
type peeringConnectionOptionsState struct {
	// An optional configuration block that allows for [VPC Peering Connection]
	// (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options to be set for the VPC that accepts
	// the peering connection (a maximum of one).
	Accepter *PeeringConnectionOptionsAccepter `pulumi:"accepter"`
	// A optional configuration block that allows for [VPC Peering Connection]
	// (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options to be set for the VPC that requests
	// the peering connection (a maximum of one).
	Requester *PeeringConnectionOptionsRequester `pulumi:"requester"`
	// The ID of the requester VPC peering connection.
	VpcPeeringConnectionId *string `pulumi:"vpcPeeringConnectionId"`
}

type PeeringConnectionOptionsState struct {
	// An optional configuration block that allows for [VPC Peering Connection]
	// (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options to be set for the VPC that accepts
	// the peering connection (a maximum of one).
	Accepter PeeringConnectionOptionsAccepterPtrInput
	// A optional configuration block that allows for [VPC Peering Connection]
	// (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options to be set for the VPC that requests
	// the peering connection (a maximum of one).
	Requester PeeringConnectionOptionsRequesterPtrInput
	// The ID of the requester VPC peering connection.
	VpcPeeringConnectionId pulumi.StringPtrInput
}

func (PeeringConnectionOptionsState) ElementType() reflect.Type {
	return reflect.TypeOf((*peeringConnectionOptionsState)(nil)).Elem()
}

type peeringConnectionOptionsArgs struct {
	// An optional configuration block that allows for [VPC Peering Connection]
	// (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options to be set for the VPC that accepts
	// the peering connection (a maximum of one).
	Accepter *PeeringConnectionOptionsAccepter `pulumi:"accepter"`
	// A optional configuration block that allows for [VPC Peering Connection]
	// (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options to be set for the VPC that requests
	// the peering connection (a maximum of one).
	Requester *PeeringConnectionOptionsRequester `pulumi:"requester"`
	// The ID of the requester VPC peering connection.
	VpcPeeringConnectionId string `pulumi:"vpcPeeringConnectionId"`
}

// The set of arguments for constructing a PeeringConnectionOptions resource.
type PeeringConnectionOptionsArgs struct {
	// An optional configuration block that allows for [VPC Peering Connection]
	// (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options to be set for the VPC that accepts
	// the peering connection (a maximum of one).
	Accepter PeeringConnectionOptionsAccepterPtrInput
	// A optional configuration block that allows for [VPC Peering Connection]
	// (https://docs.aws.amazon.com/vpc/latest/peering/what-is-vpc-peering.html) options to be set for the VPC that requests
	// the peering connection (a maximum of one).
	Requester PeeringConnectionOptionsRequesterPtrInput
	// The ID of the requester VPC peering connection.
	VpcPeeringConnectionId pulumi.StringInput
}

func (PeeringConnectionOptionsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*peeringConnectionOptionsArgs)(nil)).Elem()
}
