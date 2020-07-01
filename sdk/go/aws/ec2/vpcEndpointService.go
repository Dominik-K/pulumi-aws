// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a VPC Endpoint Service resource.
// Service consumers can create an _Interface_ VPC Endpoint to connect to the service.
//
// > **NOTE on VPC Endpoint Services and VPC Endpoint Service Allowed Principals:** This provider provides
// both a standalone VPC Endpoint Service Allowed Principal resource
// and a VPC Endpoint Service resource with an `allowedPrincipals` attribute. Do not use the same principal ARN in both
// a VPC Endpoint Service resource and a VPC Endpoint Service Allowed Principal resource. Doing so will cause a conflict
// and will overwrite the association.
//
// ## Example Usage
// ### Basic
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
// 		_, err := ec2.NewVpcEndpointService(ctx, "example", &ec2.VpcEndpointServiceArgs{
// 			AcceptanceRequired: pulumi.Bool(false),
// 			NetworkLoadBalancerArns: pulumi.StringArray{
// 				pulumi.String(aws_lb.Example.Arn),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
// ### Basic w/ Tags
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
// 		_, err := ec2.NewVpcEndpointService(ctx, "example", &ec2.VpcEndpointServiceArgs{
// 			AcceptanceRequired: pulumi.Bool(false),
// 			NetworkLoadBalancerArns: pulumi.StringArray{
// 				pulumi.String(aws_lb.Example.Arn),
// 			},
// 			Tags: pulumi.StringMap{
// 				"Environment": pulumi.String("test"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type VpcEndpointService struct {
	pulumi.CustomResourceState

	// Whether or not VPC endpoint connection requests to the service must be accepted by the service owner - `true` or `false`.
	AcceptanceRequired pulumi.BoolOutput `pulumi:"acceptanceRequired"`
	// The ARNs of one or more principals allowed to discover the endpoint service.
	AllowedPrincipals pulumi.StringArrayOutput `pulumi:"allowedPrincipals"`
	// The Amazon Resource Name (ARN) of the VPC endpoint service.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// The Availability Zones in which the service is available.
	AvailabilityZones pulumi.StringArrayOutput `pulumi:"availabilityZones"`
	// The DNS names for the service.
	BaseEndpointDnsNames pulumi.StringArrayOutput `pulumi:"baseEndpointDnsNames"`
	// Whether or not the service manages its VPC endpoints - `true` or `false`.
	ManagesVpcEndpoints pulumi.BoolOutput `pulumi:"managesVpcEndpoints"`
	// The ARNs of one or more Network Load Balancers for the endpoint service.
	NetworkLoadBalancerArns pulumi.StringArrayOutput `pulumi:"networkLoadBalancerArns"`
	// The private DNS name for the service.
	PrivateDnsName pulumi.StringOutput `pulumi:"privateDnsName"`
	// The service name.
	ServiceName pulumi.StringOutput `pulumi:"serviceName"`
	// The service type, `Gateway` or `Interface`.
	ServiceType pulumi.StringOutput `pulumi:"serviceType"`
	// The state of the VPC endpoint service.
	State pulumi.StringOutput `pulumi:"state"`
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
}

// NewVpcEndpointService registers a new resource with the given unique name, arguments, and options.
func NewVpcEndpointService(ctx *pulumi.Context,
	name string, args *VpcEndpointServiceArgs, opts ...pulumi.ResourceOption) (*VpcEndpointService, error) {
	if args == nil || args.AcceptanceRequired == nil {
		return nil, errors.New("missing required argument 'AcceptanceRequired'")
	}
	if args == nil || args.NetworkLoadBalancerArns == nil {
		return nil, errors.New("missing required argument 'NetworkLoadBalancerArns'")
	}
	if args == nil {
		args = &VpcEndpointServiceArgs{}
	}
	var resource VpcEndpointService
	err := ctx.RegisterResource("aws:ec2/vpcEndpointService:VpcEndpointService", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVpcEndpointService gets an existing VpcEndpointService resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVpcEndpointService(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VpcEndpointServiceState, opts ...pulumi.ResourceOption) (*VpcEndpointService, error) {
	var resource VpcEndpointService
	err := ctx.ReadResource("aws:ec2/vpcEndpointService:VpcEndpointService", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VpcEndpointService resources.
type vpcEndpointServiceState struct {
	// Whether or not VPC endpoint connection requests to the service must be accepted by the service owner - `true` or `false`.
	AcceptanceRequired *bool `pulumi:"acceptanceRequired"`
	// The ARNs of one or more principals allowed to discover the endpoint service.
	AllowedPrincipals []string `pulumi:"allowedPrincipals"`
	// The Amazon Resource Name (ARN) of the VPC endpoint service.
	Arn *string `pulumi:"arn"`
	// The Availability Zones in which the service is available.
	AvailabilityZones []string `pulumi:"availabilityZones"`
	// The DNS names for the service.
	BaseEndpointDnsNames []string `pulumi:"baseEndpointDnsNames"`
	// Whether or not the service manages its VPC endpoints - `true` or `false`.
	ManagesVpcEndpoints *bool `pulumi:"managesVpcEndpoints"`
	// The ARNs of one or more Network Load Balancers for the endpoint service.
	NetworkLoadBalancerArns []string `pulumi:"networkLoadBalancerArns"`
	// The private DNS name for the service.
	PrivateDnsName *string `pulumi:"privateDnsName"`
	// The service name.
	ServiceName *string `pulumi:"serviceName"`
	// The service type, `Gateway` or `Interface`.
	ServiceType *string `pulumi:"serviceType"`
	// The state of the VPC endpoint service.
	State *string `pulumi:"state"`
	// A map of tags to assign to the resource.
	Tags map[string]string `pulumi:"tags"`
}

type VpcEndpointServiceState struct {
	// Whether or not VPC endpoint connection requests to the service must be accepted by the service owner - `true` or `false`.
	AcceptanceRequired pulumi.BoolPtrInput
	// The ARNs of one or more principals allowed to discover the endpoint service.
	AllowedPrincipals pulumi.StringArrayInput
	// The Amazon Resource Name (ARN) of the VPC endpoint service.
	Arn pulumi.StringPtrInput
	// The Availability Zones in which the service is available.
	AvailabilityZones pulumi.StringArrayInput
	// The DNS names for the service.
	BaseEndpointDnsNames pulumi.StringArrayInput
	// Whether or not the service manages its VPC endpoints - `true` or `false`.
	ManagesVpcEndpoints pulumi.BoolPtrInput
	// The ARNs of one or more Network Load Balancers for the endpoint service.
	NetworkLoadBalancerArns pulumi.StringArrayInput
	// The private DNS name for the service.
	PrivateDnsName pulumi.StringPtrInput
	// The service name.
	ServiceName pulumi.StringPtrInput
	// The service type, `Gateway` or `Interface`.
	ServiceType pulumi.StringPtrInput
	// The state of the VPC endpoint service.
	State pulumi.StringPtrInput
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapInput
}

func (VpcEndpointServiceState) ElementType() reflect.Type {
	return reflect.TypeOf((*vpcEndpointServiceState)(nil)).Elem()
}

type vpcEndpointServiceArgs struct {
	// Whether or not VPC endpoint connection requests to the service must be accepted by the service owner - `true` or `false`.
	AcceptanceRequired bool `pulumi:"acceptanceRequired"`
	// The ARNs of one or more principals allowed to discover the endpoint service.
	AllowedPrincipals []string `pulumi:"allowedPrincipals"`
	// The ARNs of one or more Network Load Balancers for the endpoint service.
	NetworkLoadBalancerArns []string `pulumi:"networkLoadBalancerArns"`
	// A map of tags to assign to the resource.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a VpcEndpointService resource.
type VpcEndpointServiceArgs struct {
	// Whether or not VPC endpoint connection requests to the service must be accepted by the service owner - `true` or `false`.
	AcceptanceRequired pulumi.BoolInput
	// The ARNs of one or more principals allowed to discover the endpoint service.
	AllowedPrincipals pulumi.StringArrayInput
	// The ARNs of one or more Network Load Balancers for the endpoint service.
	NetworkLoadBalancerArns pulumi.StringArrayInput
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapInput
}

func (VpcEndpointServiceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*vpcEndpointServiceArgs)(nil)).Elem()
}
