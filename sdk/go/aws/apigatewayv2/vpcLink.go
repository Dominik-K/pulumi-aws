// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package apigatewayv2

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages an Amazon API Gateway Version 2 VPC Link.
//
// > **Note:** Amazon API Gateway Version 2 VPC Links enable private integrations that connect HTTP APIs to private resources in a VPC.
// To enable private integration for REST APIs, use the `Amazon API Gateway Version 1 VPC Link` resource.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/apigatewayv2"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := apigatewayv2.NewVpcLink(ctx, "example", &apigatewayv2.VpcLinkArgs{
// 			SecurityGroupIds: pulumi.StringArray{
// 				pulumi.String(data.Aws_security_group.Example.Id),
// 			},
// 			SubnetIds: data.Aws_subnet_ids.Example.Ids,
// 			Tags: pulumi.StringMap{
// 				"Usage": pulumi.String("example"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type VpcLink struct {
	pulumi.CustomResourceState

	// The VPC Link ARN.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// The name of the VPC Link.
	Name pulumi.StringOutput `pulumi:"name"`
	// Security group IDs for the VPC Link.
	SecurityGroupIds pulumi.StringArrayOutput `pulumi:"securityGroupIds"`
	// Subnet IDs for the VPC Link.
	SubnetIds pulumi.StringArrayOutput `pulumi:"subnetIds"`
	// A map of tags to assign to the VPC Link.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
}

// NewVpcLink registers a new resource with the given unique name, arguments, and options.
func NewVpcLink(ctx *pulumi.Context,
	name string, args *VpcLinkArgs, opts ...pulumi.ResourceOption) (*VpcLink, error) {
	if args == nil || args.SecurityGroupIds == nil {
		return nil, errors.New("missing required argument 'SecurityGroupIds'")
	}
	if args == nil || args.SubnetIds == nil {
		return nil, errors.New("missing required argument 'SubnetIds'")
	}
	if args == nil {
		args = &VpcLinkArgs{}
	}
	var resource VpcLink
	err := ctx.RegisterResource("aws:apigatewayv2/vpcLink:VpcLink", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVpcLink gets an existing VpcLink resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVpcLink(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VpcLinkState, opts ...pulumi.ResourceOption) (*VpcLink, error) {
	var resource VpcLink
	err := ctx.ReadResource("aws:apigatewayv2/vpcLink:VpcLink", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VpcLink resources.
type vpcLinkState struct {
	// The VPC Link ARN.
	Arn *string `pulumi:"arn"`
	// The name of the VPC Link.
	Name *string `pulumi:"name"`
	// Security group IDs for the VPC Link.
	SecurityGroupIds []string `pulumi:"securityGroupIds"`
	// Subnet IDs for the VPC Link.
	SubnetIds []string `pulumi:"subnetIds"`
	// A map of tags to assign to the VPC Link.
	Tags map[string]string `pulumi:"tags"`
}

type VpcLinkState struct {
	// The VPC Link ARN.
	Arn pulumi.StringPtrInput
	// The name of the VPC Link.
	Name pulumi.StringPtrInput
	// Security group IDs for the VPC Link.
	SecurityGroupIds pulumi.StringArrayInput
	// Subnet IDs for the VPC Link.
	SubnetIds pulumi.StringArrayInput
	// A map of tags to assign to the VPC Link.
	Tags pulumi.StringMapInput
}

func (VpcLinkState) ElementType() reflect.Type {
	return reflect.TypeOf((*vpcLinkState)(nil)).Elem()
}

type vpcLinkArgs struct {
	// The name of the VPC Link.
	Name *string `pulumi:"name"`
	// Security group IDs for the VPC Link.
	SecurityGroupIds []string `pulumi:"securityGroupIds"`
	// Subnet IDs for the VPC Link.
	SubnetIds []string `pulumi:"subnetIds"`
	// A map of tags to assign to the VPC Link.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a VpcLink resource.
type VpcLinkArgs struct {
	// The name of the VPC Link.
	Name pulumi.StringPtrInput
	// Security group IDs for the VPC Link.
	SecurityGroupIds pulumi.StringArrayInput
	// Subnet IDs for the VPC Link.
	SubnetIds pulumi.StringArrayInput
	// A map of tags to assign to the VPC Link.
	Tags pulumi.StringMapInput
}

func (VpcLinkArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*vpcLinkArgs)(nil)).Elem()
}
