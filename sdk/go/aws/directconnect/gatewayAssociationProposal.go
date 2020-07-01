// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package directconnect

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages a Direct Connect Gateway Association Proposal, typically for enabling cross-account associations. For single account associations, see the `directconnect.GatewayAssociation` resource.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/directconnect"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := directconnect.NewGatewayAssociationProposal(ctx, "example", &directconnect.GatewayAssociationProposalArgs{
// 			AssociatedGatewayId:     pulumi.String(aws_vpn_gateway.Example.Id),
// 			DxGatewayId:             pulumi.String(aws_dx_gateway.Example.Id),
// 			DxGatewayOwnerAccountId: pulumi.String(aws_dx_gateway.Example.Owner_account_id),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
//
// A full example of how to create a VPN Gateway in one AWS account, create a Direct Connect Gateway in a second AWS account, and associate the VPN Gateway with the Direct Connect Gateway via the `directconnect.GatewayAssociationProposal` and `directconnect.GatewayAssociation` resources can be found in [the `./examples/dx-gateway-cross-account-vgw-association` directory within the Github Repository](https://github.com/providers/provider-aws/tree/master/examples/dx-gateway-cross-account-vgw-association).
type GatewayAssociationProposal struct {
	pulumi.CustomResourceState

	// VPC prefixes (CIDRs) to advertise to the Direct Connect gateway. Defaults to the CIDR block of the VPC associated with the Virtual Gateway. To enable drift detection, must be configured.
	AllowedPrefixes pulumi.StringArrayOutput `pulumi:"allowedPrefixes"`
	// The ID of the VGW or transit gateway with which to associate the Direct Connect gateway.
	AssociatedGatewayId pulumi.StringPtrOutput `pulumi:"associatedGatewayId"`
	// The ID of the AWS account that owns the VGW or transit gateway with which to associate the Direct Connect gateway.
	AssociatedGatewayOwnerAccountId pulumi.StringOutput `pulumi:"associatedGatewayOwnerAccountId"`
	// The type of the associated gateway, `transitGateway` or `virtualPrivateGateway`.
	AssociatedGatewayType pulumi.StringOutput `pulumi:"associatedGatewayType"`
	// Direct Connect Gateway identifier.
	DxGatewayId pulumi.StringOutput `pulumi:"dxGatewayId"`
	// AWS Account identifier of the Direct Connect Gateway's owner.
	DxGatewayOwnerAccountId pulumi.StringOutput `pulumi:"dxGatewayOwnerAccountId"`
	// *Deprecated:* Use `associatedGatewayId` instead. Virtual Gateway identifier to associate with the Direct Connect Gateway.
	//
	// Deprecated: use 'associated_gateway_id' argument instead
	VpnGatewayId pulumi.StringPtrOutput `pulumi:"vpnGatewayId"`
}

// NewGatewayAssociationProposal registers a new resource with the given unique name, arguments, and options.
func NewGatewayAssociationProposal(ctx *pulumi.Context,
	name string, args *GatewayAssociationProposalArgs, opts ...pulumi.ResourceOption) (*GatewayAssociationProposal, error) {
	if args == nil || args.DxGatewayId == nil {
		return nil, errors.New("missing required argument 'DxGatewayId'")
	}
	if args == nil || args.DxGatewayOwnerAccountId == nil {
		return nil, errors.New("missing required argument 'DxGatewayOwnerAccountId'")
	}
	if args == nil {
		args = &GatewayAssociationProposalArgs{}
	}
	var resource GatewayAssociationProposal
	err := ctx.RegisterResource("aws:directconnect/gatewayAssociationProposal:GatewayAssociationProposal", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGatewayAssociationProposal gets an existing GatewayAssociationProposal resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGatewayAssociationProposal(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GatewayAssociationProposalState, opts ...pulumi.ResourceOption) (*GatewayAssociationProposal, error) {
	var resource GatewayAssociationProposal
	err := ctx.ReadResource("aws:directconnect/gatewayAssociationProposal:GatewayAssociationProposal", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering GatewayAssociationProposal resources.
type gatewayAssociationProposalState struct {
	// VPC prefixes (CIDRs) to advertise to the Direct Connect gateway. Defaults to the CIDR block of the VPC associated with the Virtual Gateway. To enable drift detection, must be configured.
	AllowedPrefixes []string `pulumi:"allowedPrefixes"`
	// The ID of the VGW or transit gateway with which to associate the Direct Connect gateway.
	AssociatedGatewayId *string `pulumi:"associatedGatewayId"`
	// The ID of the AWS account that owns the VGW or transit gateway with which to associate the Direct Connect gateway.
	AssociatedGatewayOwnerAccountId *string `pulumi:"associatedGatewayOwnerAccountId"`
	// The type of the associated gateway, `transitGateway` or `virtualPrivateGateway`.
	AssociatedGatewayType *string `pulumi:"associatedGatewayType"`
	// Direct Connect Gateway identifier.
	DxGatewayId *string `pulumi:"dxGatewayId"`
	// AWS Account identifier of the Direct Connect Gateway's owner.
	DxGatewayOwnerAccountId *string `pulumi:"dxGatewayOwnerAccountId"`
	// *Deprecated:* Use `associatedGatewayId` instead. Virtual Gateway identifier to associate with the Direct Connect Gateway.
	//
	// Deprecated: use 'associated_gateway_id' argument instead
	VpnGatewayId *string `pulumi:"vpnGatewayId"`
}

type GatewayAssociationProposalState struct {
	// VPC prefixes (CIDRs) to advertise to the Direct Connect gateway. Defaults to the CIDR block of the VPC associated with the Virtual Gateway. To enable drift detection, must be configured.
	AllowedPrefixes pulumi.StringArrayInput
	// The ID of the VGW or transit gateway with which to associate the Direct Connect gateway.
	AssociatedGatewayId pulumi.StringPtrInput
	// The ID of the AWS account that owns the VGW or transit gateway with which to associate the Direct Connect gateway.
	AssociatedGatewayOwnerAccountId pulumi.StringPtrInput
	// The type of the associated gateway, `transitGateway` or `virtualPrivateGateway`.
	AssociatedGatewayType pulumi.StringPtrInput
	// Direct Connect Gateway identifier.
	DxGatewayId pulumi.StringPtrInput
	// AWS Account identifier of the Direct Connect Gateway's owner.
	DxGatewayOwnerAccountId pulumi.StringPtrInput
	// *Deprecated:* Use `associatedGatewayId` instead. Virtual Gateway identifier to associate with the Direct Connect Gateway.
	//
	// Deprecated: use 'associated_gateway_id' argument instead
	VpnGatewayId pulumi.StringPtrInput
}

func (GatewayAssociationProposalState) ElementType() reflect.Type {
	return reflect.TypeOf((*gatewayAssociationProposalState)(nil)).Elem()
}

type gatewayAssociationProposalArgs struct {
	// VPC prefixes (CIDRs) to advertise to the Direct Connect gateway. Defaults to the CIDR block of the VPC associated with the Virtual Gateway. To enable drift detection, must be configured.
	AllowedPrefixes []string `pulumi:"allowedPrefixes"`
	// The ID of the VGW or transit gateway with which to associate the Direct Connect gateway.
	AssociatedGatewayId *string `pulumi:"associatedGatewayId"`
	// Direct Connect Gateway identifier.
	DxGatewayId string `pulumi:"dxGatewayId"`
	// AWS Account identifier of the Direct Connect Gateway's owner.
	DxGatewayOwnerAccountId string `pulumi:"dxGatewayOwnerAccountId"`
	// *Deprecated:* Use `associatedGatewayId` instead. Virtual Gateway identifier to associate with the Direct Connect Gateway.
	//
	// Deprecated: use 'associated_gateway_id' argument instead
	VpnGatewayId *string `pulumi:"vpnGatewayId"`
}

// The set of arguments for constructing a GatewayAssociationProposal resource.
type GatewayAssociationProposalArgs struct {
	// VPC prefixes (CIDRs) to advertise to the Direct Connect gateway. Defaults to the CIDR block of the VPC associated with the Virtual Gateway. To enable drift detection, must be configured.
	AllowedPrefixes pulumi.StringArrayInput
	// The ID of the VGW or transit gateway with which to associate the Direct Connect gateway.
	AssociatedGatewayId pulumi.StringPtrInput
	// Direct Connect Gateway identifier.
	DxGatewayId pulumi.StringInput
	// AWS Account identifier of the Direct Connect Gateway's owner.
	DxGatewayOwnerAccountId pulumi.StringInput
	// *Deprecated:* Use `associatedGatewayId` instead. Virtual Gateway identifier to associate with the Direct Connect Gateway.
	//
	// Deprecated: use 'associated_gateway_id' argument instead
	VpnGatewayId pulumi.StringPtrInput
}

func (GatewayAssociationProposalArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*gatewayAssociationProposalArgs)(nil)).Elem()
}
