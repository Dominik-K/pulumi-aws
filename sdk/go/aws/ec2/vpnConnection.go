// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages an EC2 VPN connection. These objects can be connected to customer gateways, and allow you to establish tunnels between your network and Amazon.
//
// > **Note:** All arguments including `tunnel1PresharedKey` and `tunnel2PresharedKey` will be stored in the raw state as plain-text.
//
// > **Note:** The CIDR blocks in the arguments `tunnel1InsideCidr` and `tunnel2InsideCidr` must have a prefix of /30 and be a part of a specific range.
// [Read more about this in the AWS documentation](https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_VpnTunnelOptionsSpecification.html).
//
// ## Example Usage
// ### EC2 Transit Gateway
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/ec2"
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/ec2transitgateway"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		exampleTransitGateway, err := ec2transitgateway.NewTransitGateway(ctx, "exampleTransitGateway", nil)
// 		if err != nil {
// 			return err
// 		}
// 		exampleCustomerGateway, err := ec2.NewCustomerGateway(ctx, "exampleCustomerGateway", &ec2.CustomerGatewayArgs{
// 			BgpAsn:    pulumi.String("65000"),
// 			IpAddress: pulumi.String("172.0.0.1"),
// 			Type:      pulumi.String("ipsec.1"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = ec2.NewVpnConnection(ctx, "exampleVpnConnection", &ec2.VpnConnectionArgs{
// 			CustomerGatewayId: exampleCustomerGateway.ID(),
// 			TransitGatewayId:  exampleTransitGateway.ID(),
// 			Type:              exampleCustomerGateway.Type,
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
// ### Virtual Private Gateway
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/ec2"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		vpc, err := ec2.NewVpc(ctx, "vpc", &ec2.VpcArgs{
// 			CidrBlock: pulumi.String("10.0.0.0/16"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		vpnGateway, err := ec2.NewVpnGateway(ctx, "vpnGateway", &ec2.VpnGatewayArgs{
// 			VpcId: vpc.ID(),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		customerGateway, err := ec2.NewCustomerGateway(ctx, "customerGateway", &ec2.CustomerGatewayArgs{
// 			BgpAsn:    pulumi.String("65000"),
// 			IpAddress: pulumi.String("172.0.0.1"),
// 			Type:      pulumi.String("ipsec.1"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = ec2.NewVpnConnection(ctx, "main", &ec2.VpnConnectionArgs{
// 			VpnGatewayId:      vpnGateway.ID(),
// 			CustomerGatewayId: customerGateway.ID(),
// 			Type:              pulumi.String("ipsec.1"),
// 			StaticRoutesOnly:  pulumi.Bool(true),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type VpnConnection struct {
	pulumi.CustomResourceState

	// Amazon Resource Name (ARN) of the VPN Connection.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// The configuration information for the VPN connection's customer gateway (in the native XML format).
	CustomerGatewayConfiguration pulumi.StringOutput `pulumi:"customerGatewayConfiguration"`
	// The ID of the customer gateway.
	CustomerGatewayId pulumi.StringOutput               `pulumi:"customerGatewayId"`
	Routes            VpnConnectionRouteTypeArrayOutput `pulumi:"routes"`
	// Whether the VPN connection uses static routes exclusively. Static routes must be used for devices that don't support BGP.
	StaticRoutesOnly pulumi.BoolOutput `pulumi:"staticRoutesOnly"`
	// Tags to apply to the connection.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// When associated with an EC2 Transit Gateway (`transitGatewayId` argument), the attachment ID.
	TransitGatewayAttachmentId pulumi.StringOutput `pulumi:"transitGatewayAttachmentId"`
	// The ID of the EC2 Transit Gateway.
	TransitGatewayId pulumi.StringPtrOutput `pulumi:"transitGatewayId"`
	// The public IP address of the first VPN tunnel.
	Tunnel1Address pulumi.StringOutput `pulumi:"tunnel1Address"`
	// The bgp asn number of the first VPN tunnel.
	Tunnel1BgpAsn pulumi.StringOutput `pulumi:"tunnel1BgpAsn"`
	// The bgp holdtime of the first VPN tunnel.
	Tunnel1BgpHoldtime pulumi.IntOutput `pulumi:"tunnel1BgpHoldtime"`
	// The RFC 6890 link-local address of the first VPN tunnel (Customer Gateway Side).
	Tunnel1CgwInsideAddress pulumi.StringOutput `pulumi:"tunnel1CgwInsideAddress"`
	// The CIDR block of the inside IP addresses for the first VPN tunnel.
	Tunnel1InsideCidr pulumi.StringOutput `pulumi:"tunnel1InsideCidr"`
	// The preshared key of the first VPN tunnel.
	Tunnel1PresharedKey pulumi.StringOutput `pulumi:"tunnel1PresharedKey"`
	// The RFC 6890 link-local address of the first VPN tunnel (VPN Gateway Side).
	Tunnel1VgwInsideAddress pulumi.StringOutput `pulumi:"tunnel1VgwInsideAddress"`
	// The public IP address of the second VPN tunnel.
	Tunnel2Address pulumi.StringOutput `pulumi:"tunnel2Address"`
	// The bgp asn number of the second VPN tunnel.
	Tunnel2BgpAsn pulumi.StringOutput `pulumi:"tunnel2BgpAsn"`
	// The bgp holdtime of the second VPN tunnel.
	Tunnel2BgpHoldtime pulumi.IntOutput `pulumi:"tunnel2BgpHoldtime"`
	// The RFC 6890 link-local address of the second VPN tunnel (Customer Gateway Side).
	Tunnel2CgwInsideAddress pulumi.StringOutput `pulumi:"tunnel2CgwInsideAddress"`
	// The CIDR block of the inside IP addresses for the second VPN tunnel.
	Tunnel2InsideCidr pulumi.StringOutput `pulumi:"tunnel2InsideCidr"`
	// The preshared key of the second VPN tunnel.
	Tunnel2PresharedKey pulumi.StringOutput `pulumi:"tunnel2PresharedKey"`
	// The RFC 6890 link-local address of the second VPN tunnel (VPN Gateway Side).
	Tunnel2VgwInsideAddress pulumi.StringOutput `pulumi:"tunnel2VgwInsideAddress"`
	// The type of VPN connection. The only type AWS supports at this time is "ipsec.1".
	Type           pulumi.StringOutput                  `pulumi:"type"`
	VgwTelemetries VpnConnectionVgwTelemetryArrayOutput `pulumi:"vgwTelemetries"`
	// The ID of the Virtual Private Gateway.
	VpnGatewayId pulumi.StringPtrOutput `pulumi:"vpnGatewayId"`
}

// NewVpnConnection registers a new resource with the given unique name, arguments, and options.
func NewVpnConnection(ctx *pulumi.Context,
	name string, args *VpnConnectionArgs, opts ...pulumi.ResourceOption) (*VpnConnection, error) {
	if args == nil || args.CustomerGatewayId == nil {
		return nil, errors.New("missing required argument 'CustomerGatewayId'")
	}
	if args == nil || args.Type == nil {
		return nil, errors.New("missing required argument 'Type'")
	}
	if args == nil {
		args = &VpnConnectionArgs{}
	}
	var resource VpnConnection
	err := ctx.RegisterResource("aws:ec2/vpnConnection:VpnConnection", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVpnConnection gets an existing VpnConnection resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVpnConnection(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VpnConnectionState, opts ...pulumi.ResourceOption) (*VpnConnection, error) {
	var resource VpnConnection
	err := ctx.ReadResource("aws:ec2/vpnConnection:VpnConnection", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VpnConnection resources.
type vpnConnectionState struct {
	// Amazon Resource Name (ARN) of the VPN Connection.
	Arn *string `pulumi:"arn"`
	// The configuration information for the VPN connection's customer gateway (in the native XML format).
	CustomerGatewayConfiguration *string `pulumi:"customerGatewayConfiguration"`
	// The ID of the customer gateway.
	CustomerGatewayId *string                  `pulumi:"customerGatewayId"`
	Routes            []VpnConnectionRouteType `pulumi:"routes"`
	// Whether the VPN connection uses static routes exclusively. Static routes must be used for devices that don't support BGP.
	StaticRoutesOnly *bool `pulumi:"staticRoutesOnly"`
	// Tags to apply to the connection.
	Tags map[string]string `pulumi:"tags"`
	// When associated with an EC2 Transit Gateway (`transitGatewayId` argument), the attachment ID.
	TransitGatewayAttachmentId *string `pulumi:"transitGatewayAttachmentId"`
	// The ID of the EC2 Transit Gateway.
	TransitGatewayId *string `pulumi:"transitGatewayId"`
	// The public IP address of the first VPN tunnel.
	Tunnel1Address *string `pulumi:"tunnel1Address"`
	// The bgp asn number of the first VPN tunnel.
	Tunnel1BgpAsn *string `pulumi:"tunnel1BgpAsn"`
	// The bgp holdtime of the first VPN tunnel.
	Tunnel1BgpHoldtime *int `pulumi:"tunnel1BgpHoldtime"`
	// The RFC 6890 link-local address of the first VPN tunnel (Customer Gateway Side).
	Tunnel1CgwInsideAddress *string `pulumi:"tunnel1CgwInsideAddress"`
	// The CIDR block of the inside IP addresses for the first VPN tunnel.
	Tunnel1InsideCidr *string `pulumi:"tunnel1InsideCidr"`
	// The preshared key of the first VPN tunnel.
	Tunnel1PresharedKey *string `pulumi:"tunnel1PresharedKey"`
	// The RFC 6890 link-local address of the first VPN tunnel (VPN Gateway Side).
	Tunnel1VgwInsideAddress *string `pulumi:"tunnel1VgwInsideAddress"`
	// The public IP address of the second VPN tunnel.
	Tunnel2Address *string `pulumi:"tunnel2Address"`
	// The bgp asn number of the second VPN tunnel.
	Tunnel2BgpAsn *string `pulumi:"tunnel2BgpAsn"`
	// The bgp holdtime of the second VPN tunnel.
	Tunnel2BgpHoldtime *int `pulumi:"tunnel2BgpHoldtime"`
	// The RFC 6890 link-local address of the second VPN tunnel (Customer Gateway Side).
	Tunnel2CgwInsideAddress *string `pulumi:"tunnel2CgwInsideAddress"`
	// The CIDR block of the inside IP addresses for the second VPN tunnel.
	Tunnel2InsideCidr *string `pulumi:"tunnel2InsideCidr"`
	// The preshared key of the second VPN tunnel.
	Tunnel2PresharedKey *string `pulumi:"tunnel2PresharedKey"`
	// The RFC 6890 link-local address of the second VPN tunnel (VPN Gateway Side).
	Tunnel2VgwInsideAddress *string `pulumi:"tunnel2VgwInsideAddress"`
	// The type of VPN connection. The only type AWS supports at this time is "ipsec.1".
	Type           *string                     `pulumi:"type"`
	VgwTelemetries []VpnConnectionVgwTelemetry `pulumi:"vgwTelemetries"`
	// The ID of the Virtual Private Gateway.
	VpnGatewayId *string `pulumi:"vpnGatewayId"`
}

type VpnConnectionState struct {
	// Amazon Resource Name (ARN) of the VPN Connection.
	Arn pulumi.StringPtrInput
	// The configuration information for the VPN connection's customer gateway (in the native XML format).
	CustomerGatewayConfiguration pulumi.StringPtrInput
	// The ID of the customer gateway.
	CustomerGatewayId pulumi.StringPtrInput
	Routes            VpnConnectionRouteTypeArrayInput
	// Whether the VPN connection uses static routes exclusively. Static routes must be used for devices that don't support BGP.
	StaticRoutesOnly pulumi.BoolPtrInput
	// Tags to apply to the connection.
	Tags pulumi.StringMapInput
	// When associated with an EC2 Transit Gateway (`transitGatewayId` argument), the attachment ID.
	TransitGatewayAttachmentId pulumi.StringPtrInput
	// The ID of the EC2 Transit Gateway.
	TransitGatewayId pulumi.StringPtrInput
	// The public IP address of the first VPN tunnel.
	Tunnel1Address pulumi.StringPtrInput
	// The bgp asn number of the first VPN tunnel.
	Tunnel1BgpAsn pulumi.StringPtrInput
	// The bgp holdtime of the first VPN tunnel.
	Tunnel1BgpHoldtime pulumi.IntPtrInput
	// The RFC 6890 link-local address of the first VPN tunnel (Customer Gateway Side).
	Tunnel1CgwInsideAddress pulumi.StringPtrInput
	// The CIDR block of the inside IP addresses for the first VPN tunnel.
	Tunnel1InsideCidr pulumi.StringPtrInput
	// The preshared key of the first VPN tunnel.
	Tunnel1PresharedKey pulumi.StringPtrInput
	// The RFC 6890 link-local address of the first VPN tunnel (VPN Gateway Side).
	Tunnel1VgwInsideAddress pulumi.StringPtrInput
	// The public IP address of the second VPN tunnel.
	Tunnel2Address pulumi.StringPtrInput
	// The bgp asn number of the second VPN tunnel.
	Tunnel2BgpAsn pulumi.StringPtrInput
	// The bgp holdtime of the second VPN tunnel.
	Tunnel2BgpHoldtime pulumi.IntPtrInput
	// The RFC 6890 link-local address of the second VPN tunnel (Customer Gateway Side).
	Tunnel2CgwInsideAddress pulumi.StringPtrInput
	// The CIDR block of the inside IP addresses for the second VPN tunnel.
	Tunnel2InsideCidr pulumi.StringPtrInput
	// The preshared key of the second VPN tunnel.
	Tunnel2PresharedKey pulumi.StringPtrInput
	// The RFC 6890 link-local address of the second VPN tunnel (VPN Gateway Side).
	Tunnel2VgwInsideAddress pulumi.StringPtrInput
	// The type of VPN connection. The only type AWS supports at this time is "ipsec.1".
	Type           pulumi.StringPtrInput
	VgwTelemetries VpnConnectionVgwTelemetryArrayInput
	// The ID of the Virtual Private Gateway.
	VpnGatewayId pulumi.StringPtrInput
}

func (VpnConnectionState) ElementType() reflect.Type {
	return reflect.TypeOf((*vpnConnectionState)(nil)).Elem()
}

type vpnConnectionArgs struct {
	// The ID of the customer gateway.
	CustomerGatewayId string `pulumi:"customerGatewayId"`
	// Whether the VPN connection uses static routes exclusively. Static routes must be used for devices that don't support BGP.
	StaticRoutesOnly *bool `pulumi:"staticRoutesOnly"`
	// Tags to apply to the connection.
	Tags map[string]string `pulumi:"tags"`
	// The ID of the EC2 Transit Gateway.
	TransitGatewayId *string `pulumi:"transitGatewayId"`
	// The CIDR block of the inside IP addresses for the first VPN tunnel.
	Tunnel1InsideCidr *string `pulumi:"tunnel1InsideCidr"`
	// The preshared key of the first VPN tunnel.
	Tunnel1PresharedKey *string `pulumi:"tunnel1PresharedKey"`
	// The CIDR block of the inside IP addresses for the second VPN tunnel.
	Tunnel2InsideCidr *string `pulumi:"tunnel2InsideCidr"`
	// The preshared key of the second VPN tunnel.
	Tunnel2PresharedKey *string `pulumi:"tunnel2PresharedKey"`
	// The type of VPN connection. The only type AWS supports at this time is "ipsec.1".
	Type string `pulumi:"type"`
	// The ID of the Virtual Private Gateway.
	VpnGatewayId *string `pulumi:"vpnGatewayId"`
}

// The set of arguments for constructing a VpnConnection resource.
type VpnConnectionArgs struct {
	// The ID of the customer gateway.
	CustomerGatewayId pulumi.StringInput
	// Whether the VPN connection uses static routes exclusively. Static routes must be used for devices that don't support BGP.
	StaticRoutesOnly pulumi.BoolPtrInput
	// Tags to apply to the connection.
	Tags pulumi.StringMapInput
	// The ID of the EC2 Transit Gateway.
	TransitGatewayId pulumi.StringPtrInput
	// The CIDR block of the inside IP addresses for the first VPN tunnel.
	Tunnel1InsideCidr pulumi.StringPtrInput
	// The preshared key of the first VPN tunnel.
	Tunnel1PresharedKey pulumi.StringPtrInput
	// The CIDR block of the inside IP addresses for the second VPN tunnel.
	Tunnel2InsideCidr pulumi.StringPtrInput
	// The preshared key of the second VPN tunnel.
	Tunnel2PresharedKey pulumi.StringPtrInput
	// The type of VPN connection. The only type AWS supports at this time is "ipsec.1".
	Type pulumi.StringInput
	// The ID of the Virtual Private Gateway.
	VpnGatewayId pulumi.StringPtrInput
}

func (VpnConnectionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*vpnConnectionArgs)(nil)).Elem()
}
