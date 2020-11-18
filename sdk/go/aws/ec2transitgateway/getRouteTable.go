// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2transitgateway

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Get information on an EC2 Transit Gateway Route Table.
//
// ## Example Usage
// ### By Filter
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/ec2transitgateway"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := ec2transitgateway.LookupRouteTable(ctx, &ec2transitgateway.LookupRouteTableArgs{
// 			Filters: []ec2transitgateway.GetRouteTableFilter{
// 				ec2transitgateway.GetRouteTableFilter{
// 					Name: "default-association-route-table",
// 					Values: []string{
// 						"true",
// 					},
// 				},
// 				ec2transitgateway.GetRouteTableFilter{
// 					Name: "transit-gateway-id",
// 					Values: []string{
// 						"tgw-12345678",
// 					},
// 				},
// 			},
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
// ### By Identifier
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/ec2transitgateway"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		opt0 := "tgw-rtb-12345678"
// 		_, err := ec2transitgateway.LookupRouteTable(ctx, &ec2transitgateway.LookupRouteTableArgs{
// 			Id: &opt0,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func LookupRouteTable(ctx *pulumi.Context, args *LookupRouteTableArgs, opts ...pulumi.InvokeOption) (*LookupRouteTableResult, error) {
	var rv LookupRouteTableResult
	err := ctx.Invoke("aws:ec2transitgateway/getRouteTable:getRouteTable", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getRouteTable.
type LookupRouteTableArgs struct {
	// One or more configuration blocks containing name-values filters. Detailed below.
	Filters []GetRouteTableFilter `pulumi:"filters"`
	// Identifier of the EC2 Transit Gateway Route Table.
	Id *string `pulumi:"id"`
	// Key-value tags for the EC2 Transit Gateway Route Table
	Tags map[string]string `pulumi:"tags"`
}

// A collection of values returned by getRouteTable.
type LookupRouteTableResult struct {
	// EC2 Transit Gateway Route Table Amazon Resource Name (ARN).
	Arn string `pulumi:"arn"`
	// Boolean whether this is the default association route table for the EC2 Transit Gateway
	DefaultAssociationRouteTable bool `pulumi:"defaultAssociationRouteTable"`
	// Boolean whether this is the default propagation route table for the EC2 Transit Gateway
	DefaultPropagationRouteTable bool                  `pulumi:"defaultPropagationRouteTable"`
	Filters                      []GetRouteTableFilter `pulumi:"filters"`
	// EC2 Transit Gateway Route Table identifier
	Id *string `pulumi:"id"`
	// Key-value tags for the EC2 Transit Gateway Route Table
	Tags map[string]string `pulumi:"tags"`
	// EC2 Transit Gateway identifier
	TransitGatewayId string `pulumi:"transitGatewayId"`
}
