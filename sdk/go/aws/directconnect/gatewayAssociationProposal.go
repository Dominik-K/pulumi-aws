// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package directconnect

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages a Direct Connect Gateway Association Proposal, typically for enabling cross-account associations. For single account associations, see the [`directconnect.GatewayAssociation` resource](https://www.terraform.io/docs/providers/aws/r/dx_gateway_association.html).
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/dx_gateway_association_proposal.html.markdown.
type GatewayAssociationProposal struct {
	s *pulumi.ResourceState
}

// NewGatewayAssociationProposal registers a new resource with the given unique name, arguments, and options.
func NewGatewayAssociationProposal(ctx *pulumi.Context,
	name string, args *GatewayAssociationProposalArgs, opts ...pulumi.ResourceOpt) (*GatewayAssociationProposal, error) {
	if args == nil || args.DxGatewayId == nil {
		return nil, errors.New("missing required argument 'DxGatewayId'")
	}
	if args == nil || args.DxGatewayOwnerAccountId == nil {
		return nil, errors.New("missing required argument 'DxGatewayOwnerAccountId'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["allowedPrefixes"] = nil
		inputs["associatedGatewayId"] = nil
		inputs["dxGatewayId"] = nil
		inputs["dxGatewayOwnerAccountId"] = nil
		inputs["vpnGatewayId"] = nil
	} else {
		inputs["allowedPrefixes"] = args.AllowedPrefixes
		inputs["associatedGatewayId"] = args.AssociatedGatewayId
		inputs["dxGatewayId"] = args.DxGatewayId
		inputs["dxGatewayOwnerAccountId"] = args.DxGatewayOwnerAccountId
		inputs["vpnGatewayId"] = args.VpnGatewayId
	}
	inputs["associatedGatewayOwnerAccountId"] = nil
	inputs["associatedGatewayType"] = nil
	s, err := ctx.RegisterResource("aws:directconnect/gatewayAssociationProposal:GatewayAssociationProposal", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &GatewayAssociationProposal{s: s}, nil
}

// GetGatewayAssociationProposal gets an existing GatewayAssociationProposal resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGatewayAssociationProposal(ctx *pulumi.Context,
	name string, id pulumi.ID, state *GatewayAssociationProposalState, opts ...pulumi.ResourceOpt) (*GatewayAssociationProposal, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["allowedPrefixes"] = state.AllowedPrefixes
		inputs["associatedGatewayId"] = state.AssociatedGatewayId
		inputs["associatedGatewayOwnerAccountId"] = state.AssociatedGatewayOwnerAccountId
		inputs["associatedGatewayType"] = state.AssociatedGatewayType
		inputs["dxGatewayId"] = state.DxGatewayId
		inputs["dxGatewayOwnerAccountId"] = state.DxGatewayOwnerAccountId
		inputs["vpnGatewayId"] = state.VpnGatewayId
	}
	s, err := ctx.ReadResource("aws:directconnect/gatewayAssociationProposal:GatewayAssociationProposal", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &GatewayAssociationProposal{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *GatewayAssociationProposal) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *GatewayAssociationProposal) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// VPC prefixes (CIDRs) to advertise to the Direct Connect gateway. Defaults to the CIDR block of the VPC associated with the Virtual Gateway. To enable drift detection, must be configured.
func (r *GatewayAssociationProposal) AllowedPrefixes() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["allowedPrefixes"])
}

// The ID of the VGW or transit gateway with which to associate the Direct Connect gateway.
func (r *GatewayAssociationProposal) AssociatedGatewayId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["associatedGatewayId"])
}

// The ID of the AWS account that owns the VGW or transit gateway with which to associate the Direct Connect gateway.
func (r *GatewayAssociationProposal) AssociatedGatewayOwnerAccountId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["associatedGatewayOwnerAccountId"])
}

// The type of the associated gateway, `transitGateway` or `virtualPrivateGateway`.
func (r *GatewayAssociationProposal) AssociatedGatewayType() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["associatedGatewayType"])
}

// Direct Connect Gateway identifier.
func (r *GatewayAssociationProposal) DxGatewayId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["dxGatewayId"])
}

// AWS Account identifier of the Direct Connect Gateway's owner.
func (r *GatewayAssociationProposal) DxGatewayOwnerAccountId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["dxGatewayOwnerAccountId"])
}

// *Deprecated:* Use `associatedGatewayId` instead. Virtual Gateway identifier to associate with the Direct Connect Gateway.
func (r *GatewayAssociationProposal) VpnGatewayId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["vpnGatewayId"])
}

// Input properties used for looking up and filtering GatewayAssociationProposal resources.
type GatewayAssociationProposalState struct {
	// VPC prefixes (CIDRs) to advertise to the Direct Connect gateway. Defaults to the CIDR block of the VPC associated with the Virtual Gateway. To enable drift detection, must be configured.
	AllowedPrefixes interface{}
	// The ID of the VGW or transit gateway with which to associate the Direct Connect gateway.
	AssociatedGatewayId interface{}
	// The ID of the AWS account that owns the VGW or transit gateway with which to associate the Direct Connect gateway.
	AssociatedGatewayOwnerAccountId interface{}
	// The type of the associated gateway, `transitGateway` or `virtualPrivateGateway`.
	AssociatedGatewayType interface{}
	// Direct Connect Gateway identifier.
	DxGatewayId interface{}
	// AWS Account identifier of the Direct Connect Gateway's owner.
	DxGatewayOwnerAccountId interface{}
	// *Deprecated:* Use `associatedGatewayId` instead. Virtual Gateway identifier to associate with the Direct Connect Gateway.
	VpnGatewayId interface{}
}

// The set of arguments for constructing a GatewayAssociationProposal resource.
type GatewayAssociationProposalArgs struct {
	// VPC prefixes (CIDRs) to advertise to the Direct Connect gateway. Defaults to the CIDR block of the VPC associated with the Virtual Gateway. To enable drift detection, must be configured.
	AllowedPrefixes interface{}
	// The ID of the VGW or transit gateway with which to associate the Direct Connect gateway.
	AssociatedGatewayId interface{}
	// Direct Connect Gateway identifier.
	DxGatewayId interface{}
	// AWS Account identifier of the Direct Connect Gateway's owner.
	DxGatewayOwnerAccountId interface{}
	// *Deprecated:* Use `associatedGatewayId` instead. Virtual Gateway identifier to associate with the Direct Connect Gateway.
	VpnGatewayId interface{}
}
