// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a customer gateway inside a VPC. These objects can be connected to VPN gateways via VPN connections, and allow you to establish tunnels between your network and the VPC.
//
// ## Example Usage
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
// 		_, err := ec2.NewCustomerGateway(ctx, "main", &ec2.CustomerGatewayArgs{
// 			BgpAsn:    pulumi.String("65000"),
// 			IpAddress: pulumi.String("172.83.124.10"),
// 			Tags: pulumi.StringMap{
// 				"Name": pulumi.String("main-customer-gateway"),
// 			},
// 			Type: pulumi.String("ipsec.1"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type CustomerGateway struct {
	pulumi.CustomResourceState

	// The ARN of the customer gateway.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// The gateway's Border Gateway Protocol (BGP) Autonomous System Number (ASN).
	BgpAsn pulumi.StringOutput `pulumi:"bgpAsn"`
	// The IP address of the gateway's Internet-routable external interface.
	IpAddress pulumi.StringOutput `pulumi:"ipAddress"`
	// Tags to apply to the gateway.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of customer gateway. The only type AWS
	// supports at this time is "ipsec.1".
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewCustomerGateway registers a new resource with the given unique name, arguments, and options.
func NewCustomerGateway(ctx *pulumi.Context,
	name string, args *CustomerGatewayArgs, opts ...pulumi.ResourceOption) (*CustomerGateway, error) {
	if args == nil || args.BgpAsn == nil {
		return nil, errors.New("missing required argument 'BgpAsn'")
	}
	if args == nil || args.IpAddress == nil {
		return nil, errors.New("missing required argument 'IpAddress'")
	}
	if args == nil || args.Type == nil {
		return nil, errors.New("missing required argument 'Type'")
	}
	if args == nil {
		args = &CustomerGatewayArgs{}
	}
	var resource CustomerGateway
	err := ctx.RegisterResource("aws:ec2/customerGateway:CustomerGateway", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCustomerGateway gets an existing CustomerGateway resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCustomerGateway(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CustomerGatewayState, opts ...pulumi.ResourceOption) (*CustomerGateway, error) {
	var resource CustomerGateway
	err := ctx.ReadResource("aws:ec2/customerGateway:CustomerGateway", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CustomerGateway resources.
type customerGatewayState struct {
	// The ARN of the customer gateway.
	Arn *string `pulumi:"arn"`
	// The gateway's Border Gateway Protocol (BGP) Autonomous System Number (ASN).
	BgpAsn *string `pulumi:"bgpAsn"`
	// The IP address of the gateway's Internet-routable external interface.
	IpAddress *string `pulumi:"ipAddress"`
	// Tags to apply to the gateway.
	Tags map[string]string `pulumi:"tags"`
	// The type of customer gateway. The only type AWS
	// supports at this time is "ipsec.1".
	Type *string `pulumi:"type"`
}

type CustomerGatewayState struct {
	// The ARN of the customer gateway.
	Arn pulumi.StringPtrInput
	// The gateway's Border Gateway Protocol (BGP) Autonomous System Number (ASN).
	BgpAsn pulumi.StringPtrInput
	// The IP address of the gateway's Internet-routable external interface.
	IpAddress pulumi.StringPtrInput
	// Tags to apply to the gateway.
	Tags pulumi.StringMapInput
	// The type of customer gateway. The only type AWS
	// supports at this time is "ipsec.1".
	Type pulumi.StringPtrInput
}

func (CustomerGatewayState) ElementType() reflect.Type {
	return reflect.TypeOf((*customerGatewayState)(nil)).Elem()
}

type customerGatewayArgs struct {
	// The gateway's Border Gateway Protocol (BGP) Autonomous System Number (ASN).
	BgpAsn string `pulumi:"bgpAsn"`
	// The IP address of the gateway's Internet-routable external interface.
	IpAddress string `pulumi:"ipAddress"`
	// Tags to apply to the gateway.
	Tags map[string]string `pulumi:"tags"`
	// The type of customer gateway. The only type AWS
	// supports at this time is "ipsec.1".
	Type string `pulumi:"type"`
}

// The set of arguments for constructing a CustomerGateway resource.
type CustomerGatewayArgs struct {
	// The gateway's Border Gateway Protocol (BGP) Autonomous System Number (ASN).
	BgpAsn pulumi.StringInput
	// The IP address of the gateway's Internet-routable external interface.
	IpAddress pulumi.StringInput
	// Tags to apply to the gateway.
	Tags pulumi.StringMapInput
	// The type of customer gateway. The only type AWS
	// supports at this time is "ipsec.1".
	Type pulumi.StringInput
}

func (CustomerGatewayArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*customerGatewayArgs)(nil)).Elem()
}
