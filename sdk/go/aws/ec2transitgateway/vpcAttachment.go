// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2transitgateway

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages an EC2 Transit Gateway VPC Attachment. For examples of custom route table association and propagation, see the EC2 Transit Gateway Networking Examples Guide.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/ec2transitgateway"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := ec2transitgateway.NewVpcAttachment(ctx, "example", &ec2transitgateway.VpcAttachmentArgs{
// 			SubnetIds: pulumi.StringArray{
// 				pulumi.String(aws_subnet.Example.Id),
// 			},
// 			TransitGatewayId: pulumi.String(aws_ec2_transit_gateway.Example.Id),
// 			VpcId:            pulumi.String(aws_vpc.Example.Id),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
//
// A full example of how to create a Transit Gateway in one AWS account, share it with a second AWS account, and attach a VPC in the second account to the Transit Gateway via the `ec2transitgateway.VpcAttachment` and `ec2transitgateway.VpcAttachmentAccepter` resources can be found in [the `./examples/transit-gateway-cross-account-vpc-attachment` directory within the Github Repository](https://github.com/providers/provider-aws/tree/master/examples/transit-gateway-cross-account-vpc-attachment).
type VpcAttachment struct {
	pulumi.CustomResourceState

	// Whether DNS support is enabled. Valid values: `disable`, `enable`. Default value: `enable`.
	DnsSupport pulumi.StringPtrOutput `pulumi:"dnsSupport"`
	// Whether IPv6 support is enabled. Valid values: `disable`, `enable`. Default value: `disable`.
	Ipv6Support pulumi.StringPtrOutput `pulumi:"ipv6Support"`
	// Identifiers of EC2 Subnets.
	SubnetIds pulumi.StringArrayOutput `pulumi:"subnetIds"`
	// Key-value tags for the EC2 Transit Gateway VPC Attachment.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Boolean whether the VPC Attachment should be associated with the EC2 Transit Gateway association default route table. This cannot be configured or perform drift detection with Resource Access Manager shared EC2 Transit Gateways. Default value: `true`.
	TransitGatewayDefaultRouteTableAssociation pulumi.BoolPtrOutput `pulumi:"transitGatewayDefaultRouteTableAssociation"`
	// Boolean whether the VPC Attachment should propagate routes with the EC2 Transit Gateway propagation default route table. This cannot be configured or perform drift detection with Resource Access Manager shared EC2 Transit Gateways. Default value: `true`.
	TransitGatewayDefaultRouteTablePropagation pulumi.BoolPtrOutput `pulumi:"transitGatewayDefaultRouteTablePropagation"`
	// Identifier of EC2 Transit Gateway.
	TransitGatewayId pulumi.StringOutput `pulumi:"transitGatewayId"`
	// Identifier of EC2 VPC.
	VpcId pulumi.StringOutput `pulumi:"vpcId"`
	// Identifier of the AWS account that owns the EC2 VPC.
	VpcOwnerId pulumi.StringOutput `pulumi:"vpcOwnerId"`
}

// NewVpcAttachment registers a new resource with the given unique name, arguments, and options.
func NewVpcAttachment(ctx *pulumi.Context,
	name string, args *VpcAttachmentArgs, opts ...pulumi.ResourceOption) (*VpcAttachment, error) {
	if args == nil || args.SubnetIds == nil {
		return nil, errors.New("missing required argument 'SubnetIds'")
	}
	if args == nil || args.TransitGatewayId == nil {
		return nil, errors.New("missing required argument 'TransitGatewayId'")
	}
	if args == nil || args.VpcId == nil {
		return nil, errors.New("missing required argument 'VpcId'")
	}
	if args == nil {
		args = &VpcAttachmentArgs{}
	}
	var resource VpcAttachment
	err := ctx.RegisterResource("aws:ec2transitgateway/vpcAttachment:VpcAttachment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVpcAttachment gets an existing VpcAttachment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVpcAttachment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VpcAttachmentState, opts ...pulumi.ResourceOption) (*VpcAttachment, error) {
	var resource VpcAttachment
	err := ctx.ReadResource("aws:ec2transitgateway/vpcAttachment:VpcAttachment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VpcAttachment resources.
type vpcAttachmentState struct {
	// Whether DNS support is enabled. Valid values: `disable`, `enable`. Default value: `enable`.
	DnsSupport *string `pulumi:"dnsSupport"`
	// Whether IPv6 support is enabled. Valid values: `disable`, `enable`. Default value: `disable`.
	Ipv6Support *string `pulumi:"ipv6Support"`
	// Identifiers of EC2 Subnets.
	SubnetIds []string `pulumi:"subnetIds"`
	// Key-value tags for the EC2 Transit Gateway VPC Attachment.
	Tags map[string]string `pulumi:"tags"`
	// Boolean whether the VPC Attachment should be associated with the EC2 Transit Gateway association default route table. This cannot be configured or perform drift detection with Resource Access Manager shared EC2 Transit Gateways. Default value: `true`.
	TransitGatewayDefaultRouteTableAssociation *bool `pulumi:"transitGatewayDefaultRouteTableAssociation"`
	// Boolean whether the VPC Attachment should propagate routes with the EC2 Transit Gateway propagation default route table. This cannot be configured or perform drift detection with Resource Access Manager shared EC2 Transit Gateways. Default value: `true`.
	TransitGatewayDefaultRouteTablePropagation *bool `pulumi:"transitGatewayDefaultRouteTablePropagation"`
	// Identifier of EC2 Transit Gateway.
	TransitGatewayId *string `pulumi:"transitGatewayId"`
	// Identifier of EC2 VPC.
	VpcId *string `pulumi:"vpcId"`
	// Identifier of the AWS account that owns the EC2 VPC.
	VpcOwnerId *string `pulumi:"vpcOwnerId"`
}

type VpcAttachmentState struct {
	// Whether DNS support is enabled. Valid values: `disable`, `enable`. Default value: `enable`.
	DnsSupport pulumi.StringPtrInput
	// Whether IPv6 support is enabled. Valid values: `disable`, `enable`. Default value: `disable`.
	Ipv6Support pulumi.StringPtrInput
	// Identifiers of EC2 Subnets.
	SubnetIds pulumi.StringArrayInput
	// Key-value tags for the EC2 Transit Gateway VPC Attachment.
	Tags pulumi.StringMapInput
	// Boolean whether the VPC Attachment should be associated with the EC2 Transit Gateway association default route table. This cannot be configured or perform drift detection with Resource Access Manager shared EC2 Transit Gateways. Default value: `true`.
	TransitGatewayDefaultRouteTableAssociation pulumi.BoolPtrInput
	// Boolean whether the VPC Attachment should propagate routes with the EC2 Transit Gateway propagation default route table. This cannot be configured or perform drift detection with Resource Access Manager shared EC2 Transit Gateways. Default value: `true`.
	TransitGatewayDefaultRouteTablePropagation pulumi.BoolPtrInput
	// Identifier of EC2 Transit Gateway.
	TransitGatewayId pulumi.StringPtrInput
	// Identifier of EC2 VPC.
	VpcId pulumi.StringPtrInput
	// Identifier of the AWS account that owns the EC2 VPC.
	VpcOwnerId pulumi.StringPtrInput
}

func (VpcAttachmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*vpcAttachmentState)(nil)).Elem()
}

type vpcAttachmentArgs struct {
	// Whether DNS support is enabled. Valid values: `disable`, `enable`. Default value: `enable`.
	DnsSupport *string `pulumi:"dnsSupport"`
	// Whether IPv6 support is enabled. Valid values: `disable`, `enable`. Default value: `disable`.
	Ipv6Support *string `pulumi:"ipv6Support"`
	// Identifiers of EC2 Subnets.
	SubnetIds []string `pulumi:"subnetIds"`
	// Key-value tags for the EC2 Transit Gateway VPC Attachment.
	Tags map[string]string `pulumi:"tags"`
	// Boolean whether the VPC Attachment should be associated with the EC2 Transit Gateway association default route table. This cannot be configured or perform drift detection with Resource Access Manager shared EC2 Transit Gateways. Default value: `true`.
	TransitGatewayDefaultRouteTableAssociation *bool `pulumi:"transitGatewayDefaultRouteTableAssociation"`
	// Boolean whether the VPC Attachment should propagate routes with the EC2 Transit Gateway propagation default route table. This cannot be configured or perform drift detection with Resource Access Manager shared EC2 Transit Gateways. Default value: `true`.
	TransitGatewayDefaultRouteTablePropagation *bool `pulumi:"transitGatewayDefaultRouteTablePropagation"`
	// Identifier of EC2 Transit Gateway.
	TransitGatewayId string `pulumi:"transitGatewayId"`
	// Identifier of EC2 VPC.
	VpcId string `pulumi:"vpcId"`
}

// The set of arguments for constructing a VpcAttachment resource.
type VpcAttachmentArgs struct {
	// Whether DNS support is enabled. Valid values: `disable`, `enable`. Default value: `enable`.
	DnsSupport pulumi.StringPtrInput
	// Whether IPv6 support is enabled. Valid values: `disable`, `enable`. Default value: `disable`.
	Ipv6Support pulumi.StringPtrInput
	// Identifiers of EC2 Subnets.
	SubnetIds pulumi.StringArrayInput
	// Key-value tags for the EC2 Transit Gateway VPC Attachment.
	Tags pulumi.StringMapInput
	// Boolean whether the VPC Attachment should be associated with the EC2 Transit Gateway association default route table. This cannot be configured or perform drift detection with Resource Access Manager shared EC2 Transit Gateways. Default value: `true`.
	TransitGatewayDefaultRouteTableAssociation pulumi.BoolPtrInput
	// Boolean whether the VPC Attachment should propagate routes with the EC2 Transit Gateway propagation default route table. This cannot be configured or perform drift detection with Resource Access Manager shared EC2 Transit Gateways. Default value: `true`.
	TransitGatewayDefaultRouteTablePropagation pulumi.BoolPtrInput
	// Identifier of EC2 Transit Gateway.
	TransitGatewayId pulumi.StringInput
	// Identifier of EC2 VPC.
	VpcId pulumi.StringInput
}

func (VpcAttachmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*vpcAttachmentArgs)(nil)).Elem()
}
