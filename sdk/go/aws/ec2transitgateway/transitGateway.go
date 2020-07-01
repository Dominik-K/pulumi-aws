// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2transitgateway

import (
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages an EC2 Transit Gateway.
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
// 		_, err := ec2transitgateway.NewTransitGateway(ctx, "example", &ec2transitgateway.TransitGatewayArgs{
// 			Description: pulumi.String("example"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type TransitGateway struct {
	pulumi.CustomResourceState

	// Private Autonomous System Number (ASN) for the Amazon side of a BGP session. The range is `64512` to `65534` for 16-bit ASNs and `4200000000` to `4294967294` for 32-bit ASNs. Default value: `64512`.
	AmazonSideAsn pulumi.IntPtrOutput `pulumi:"amazonSideAsn"`
	// EC2 Transit Gateway Amazon Resource Name (ARN)
	Arn pulumi.StringOutput `pulumi:"arn"`
	// Identifier of the default association route table
	AssociationDefaultRouteTableId pulumi.StringOutput `pulumi:"associationDefaultRouteTableId"`
	// Whether resource attachment requests are automatically accepted. Valid values: `disable`, `enable`. Default value: `disable`.
	AutoAcceptSharedAttachments pulumi.StringPtrOutput `pulumi:"autoAcceptSharedAttachments"`
	// Whether resource attachments are automatically associated with the default association route table. Valid values: `disable`, `enable`. Default value: `enable`.
	DefaultRouteTableAssociation pulumi.StringPtrOutput `pulumi:"defaultRouteTableAssociation"`
	// Whether resource attachments automatically propagate routes to the default propagation route table. Valid values: `disable`, `enable`. Default value: `enable`.
	DefaultRouteTablePropagation pulumi.StringPtrOutput `pulumi:"defaultRouteTablePropagation"`
	// Description of the EC2 Transit Gateway.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Whether DNS support is enabled. Valid values: `disable`, `enable`. Default value: `enable`.
	DnsSupport pulumi.StringPtrOutput `pulumi:"dnsSupport"`
	// Identifier of the AWS account that owns the EC2 Transit Gateway
	OwnerId pulumi.StringOutput `pulumi:"ownerId"`
	// Identifier of the default propagation route table
	PropagationDefaultRouteTableId pulumi.StringOutput `pulumi:"propagationDefaultRouteTableId"`
	// Key-value tags for the EC2 Transit Gateway.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Whether VPN Equal Cost Multipath Protocol support is enabled. Valid values: `disable`, `enable`. Default value: `enable`.
	VpnEcmpSupport pulumi.StringPtrOutput `pulumi:"vpnEcmpSupport"`
}

// NewTransitGateway registers a new resource with the given unique name, arguments, and options.
func NewTransitGateway(ctx *pulumi.Context,
	name string, args *TransitGatewayArgs, opts ...pulumi.ResourceOption) (*TransitGateway, error) {
	if args == nil {
		args = &TransitGatewayArgs{}
	}
	var resource TransitGateway
	err := ctx.RegisterResource("aws:ec2transitgateway/transitGateway:TransitGateway", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTransitGateway gets an existing TransitGateway resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTransitGateway(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TransitGatewayState, opts ...pulumi.ResourceOption) (*TransitGateway, error) {
	var resource TransitGateway
	err := ctx.ReadResource("aws:ec2transitgateway/transitGateway:TransitGateway", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TransitGateway resources.
type transitGatewayState struct {
	// Private Autonomous System Number (ASN) for the Amazon side of a BGP session. The range is `64512` to `65534` for 16-bit ASNs and `4200000000` to `4294967294` for 32-bit ASNs. Default value: `64512`.
	AmazonSideAsn *int `pulumi:"amazonSideAsn"`
	// EC2 Transit Gateway Amazon Resource Name (ARN)
	Arn *string `pulumi:"arn"`
	// Identifier of the default association route table
	AssociationDefaultRouteTableId *string `pulumi:"associationDefaultRouteTableId"`
	// Whether resource attachment requests are automatically accepted. Valid values: `disable`, `enable`. Default value: `disable`.
	AutoAcceptSharedAttachments *string `pulumi:"autoAcceptSharedAttachments"`
	// Whether resource attachments are automatically associated with the default association route table. Valid values: `disable`, `enable`. Default value: `enable`.
	DefaultRouteTableAssociation *string `pulumi:"defaultRouteTableAssociation"`
	// Whether resource attachments automatically propagate routes to the default propagation route table. Valid values: `disable`, `enable`. Default value: `enable`.
	DefaultRouteTablePropagation *string `pulumi:"defaultRouteTablePropagation"`
	// Description of the EC2 Transit Gateway.
	Description *string `pulumi:"description"`
	// Whether DNS support is enabled. Valid values: `disable`, `enable`. Default value: `enable`.
	DnsSupport *string `pulumi:"dnsSupport"`
	// Identifier of the AWS account that owns the EC2 Transit Gateway
	OwnerId *string `pulumi:"ownerId"`
	// Identifier of the default propagation route table
	PropagationDefaultRouteTableId *string `pulumi:"propagationDefaultRouteTableId"`
	// Key-value tags for the EC2 Transit Gateway.
	Tags map[string]string `pulumi:"tags"`
	// Whether VPN Equal Cost Multipath Protocol support is enabled. Valid values: `disable`, `enable`. Default value: `enable`.
	VpnEcmpSupport *string `pulumi:"vpnEcmpSupport"`
}

type TransitGatewayState struct {
	// Private Autonomous System Number (ASN) for the Amazon side of a BGP session. The range is `64512` to `65534` for 16-bit ASNs and `4200000000` to `4294967294` for 32-bit ASNs. Default value: `64512`.
	AmazonSideAsn pulumi.IntPtrInput
	// EC2 Transit Gateway Amazon Resource Name (ARN)
	Arn pulumi.StringPtrInput
	// Identifier of the default association route table
	AssociationDefaultRouteTableId pulumi.StringPtrInput
	// Whether resource attachment requests are automatically accepted. Valid values: `disable`, `enable`. Default value: `disable`.
	AutoAcceptSharedAttachments pulumi.StringPtrInput
	// Whether resource attachments are automatically associated with the default association route table. Valid values: `disable`, `enable`. Default value: `enable`.
	DefaultRouteTableAssociation pulumi.StringPtrInput
	// Whether resource attachments automatically propagate routes to the default propagation route table. Valid values: `disable`, `enable`. Default value: `enable`.
	DefaultRouteTablePropagation pulumi.StringPtrInput
	// Description of the EC2 Transit Gateway.
	Description pulumi.StringPtrInput
	// Whether DNS support is enabled. Valid values: `disable`, `enable`. Default value: `enable`.
	DnsSupport pulumi.StringPtrInput
	// Identifier of the AWS account that owns the EC2 Transit Gateway
	OwnerId pulumi.StringPtrInput
	// Identifier of the default propagation route table
	PropagationDefaultRouteTableId pulumi.StringPtrInput
	// Key-value tags for the EC2 Transit Gateway.
	Tags pulumi.StringMapInput
	// Whether VPN Equal Cost Multipath Protocol support is enabled. Valid values: `disable`, `enable`. Default value: `enable`.
	VpnEcmpSupport pulumi.StringPtrInput
}

func (TransitGatewayState) ElementType() reflect.Type {
	return reflect.TypeOf((*transitGatewayState)(nil)).Elem()
}

type transitGatewayArgs struct {
	// Private Autonomous System Number (ASN) for the Amazon side of a BGP session. The range is `64512` to `65534` for 16-bit ASNs and `4200000000` to `4294967294` for 32-bit ASNs. Default value: `64512`.
	AmazonSideAsn *int `pulumi:"amazonSideAsn"`
	// Whether resource attachment requests are automatically accepted. Valid values: `disable`, `enable`. Default value: `disable`.
	AutoAcceptSharedAttachments *string `pulumi:"autoAcceptSharedAttachments"`
	// Whether resource attachments are automatically associated with the default association route table. Valid values: `disable`, `enable`. Default value: `enable`.
	DefaultRouteTableAssociation *string `pulumi:"defaultRouteTableAssociation"`
	// Whether resource attachments automatically propagate routes to the default propagation route table. Valid values: `disable`, `enable`. Default value: `enable`.
	DefaultRouteTablePropagation *string `pulumi:"defaultRouteTablePropagation"`
	// Description of the EC2 Transit Gateway.
	Description *string `pulumi:"description"`
	// Whether DNS support is enabled. Valid values: `disable`, `enable`. Default value: `enable`.
	DnsSupport *string `pulumi:"dnsSupport"`
	// Key-value tags for the EC2 Transit Gateway.
	Tags map[string]string `pulumi:"tags"`
	// Whether VPN Equal Cost Multipath Protocol support is enabled. Valid values: `disable`, `enable`. Default value: `enable`.
	VpnEcmpSupport *string `pulumi:"vpnEcmpSupport"`
}

// The set of arguments for constructing a TransitGateway resource.
type TransitGatewayArgs struct {
	// Private Autonomous System Number (ASN) for the Amazon side of a BGP session. The range is `64512` to `65534` for 16-bit ASNs and `4200000000` to `4294967294` for 32-bit ASNs. Default value: `64512`.
	AmazonSideAsn pulumi.IntPtrInput
	// Whether resource attachment requests are automatically accepted. Valid values: `disable`, `enable`. Default value: `disable`.
	AutoAcceptSharedAttachments pulumi.StringPtrInput
	// Whether resource attachments are automatically associated with the default association route table. Valid values: `disable`, `enable`. Default value: `enable`.
	DefaultRouteTableAssociation pulumi.StringPtrInput
	// Whether resource attachments automatically propagate routes to the default propagation route table. Valid values: `disable`, `enable`. Default value: `enable`.
	DefaultRouteTablePropagation pulumi.StringPtrInput
	// Description of the EC2 Transit Gateway.
	Description pulumi.StringPtrInput
	// Whether DNS support is enabled. Valid values: `disable`, `enable`. Default value: `enable`.
	DnsSupport pulumi.StringPtrInput
	// Key-value tags for the EC2 Transit Gateway.
	Tags pulumi.StringMapInput
	// Whether VPN Equal Cost Multipath Protocol support is enabled. Valid values: `disable`, `enable`. Default value: `enable`.
	VpnEcmpSupport pulumi.StringPtrInput
}

func (TransitGatewayArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*transitGatewayArgs)(nil)).Elem()
}
