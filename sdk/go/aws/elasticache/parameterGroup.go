// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package elasticache

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides an ElastiCache parameter group resource.
//
// > **NOTE:** Attempting to remove the `reserved-memory` parameter when `family` is set to `redis2.6` or `redis2.8` may show a perpetual difference in this provider due to an Elasticache API limitation. Leave that parameter configured with any value to workaround the issue.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/elasticache"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := elasticache.NewParameterGroup(ctx, "_default", &elasticache.ParameterGroupArgs{
// 			Family: pulumi.String("redis2.8"),
// 			Parameters: elasticache.ParameterGroupParameterArray{
// 				&elasticache.ParameterGroupParameterArgs{
// 					Name:  pulumi.String("activerehashing"),
// 					Value: pulumi.String("yes"),
// 				},
// 				&elasticache.ParameterGroupParameterArgs{
// 					Name:  pulumi.String("min-slaves-to-write"),
// 					Value: pulumi.String("2"),
// 				},
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type ParameterGroup struct {
	pulumi.CustomResourceState

	// The description of the ElastiCache parameter group. Defaults to "Managed by Pulumi".
	Description pulumi.StringOutput `pulumi:"description"`
	// The family of the ElastiCache parameter group.
	Family pulumi.StringOutput `pulumi:"family"`
	// The name of the ElastiCache parameter.
	Name pulumi.StringOutput `pulumi:"name"`
	// A list of ElastiCache parameters to apply.
	Parameters ParameterGroupParameterArrayOutput `pulumi:"parameters"`
}

// NewParameterGroup registers a new resource with the given unique name, arguments, and options.
func NewParameterGroup(ctx *pulumi.Context,
	name string, args *ParameterGroupArgs, opts ...pulumi.ResourceOption) (*ParameterGroup, error) {
	if args == nil || args.Family == nil {
		return nil, errors.New("missing required argument 'Family'")
	}
	if args == nil {
		args = &ParameterGroupArgs{}
	}
	if args.Description == nil {
		args.Description = pulumi.StringPtr("Managed by Pulumi")
	}
	var resource ParameterGroup
	err := ctx.RegisterResource("aws:elasticache/parameterGroup:ParameterGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetParameterGroup gets an existing ParameterGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetParameterGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ParameterGroupState, opts ...pulumi.ResourceOption) (*ParameterGroup, error) {
	var resource ParameterGroup
	err := ctx.ReadResource("aws:elasticache/parameterGroup:ParameterGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ParameterGroup resources.
type parameterGroupState struct {
	// The description of the ElastiCache parameter group. Defaults to "Managed by Pulumi".
	Description *string `pulumi:"description"`
	// The family of the ElastiCache parameter group.
	Family *string `pulumi:"family"`
	// The name of the ElastiCache parameter.
	Name *string `pulumi:"name"`
	// A list of ElastiCache parameters to apply.
	Parameters []ParameterGroupParameter `pulumi:"parameters"`
}

type ParameterGroupState struct {
	// The description of the ElastiCache parameter group. Defaults to "Managed by Pulumi".
	Description pulumi.StringPtrInput
	// The family of the ElastiCache parameter group.
	Family pulumi.StringPtrInput
	// The name of the ElastiCache parameter.
	Name pulumi.StringPtrInput
	// A list of ElastiCache parameters to apply.
	Parameters ParameterGroupParameterArrayInput
}

func (ParameterGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*parameterGroupState)(nil)).Elem()
}

type parameterGroupArgs struct {
	// The description of the ElastiCache parameter group. Defaults to "Managed by Pulumi".
	Description *string `pulumi:"description"`
	// The family of the ElastiCache parameter group.
	Family string `pulumi:"family"`
	// The name of the ElastiCache parameter.
	Name *string `pulumi:"name"`
	// A list of ElastiCache parameters to apply.
	Parameters []ParameterGroupParameter `pulumi:"parameters"`
}

// The set of arguments for constructing a ParameterGroup resource.
type ParameterGroupArgs struct {
	// The description of the ElastiCache parameter group. Defaults to "Managed by Pulumi".
	Description pulumi.StringPtrInput
	// The family of the ElastiCache parameter group.
	Family pulumi.StringInput
	// The name of the ElastiCache parameter.
	Name pulumi.StringPtrInput
	// A list of ElastiCache parameters to apply.
	Parameters ParameterGroupParameterArrayInput
}

func (ParameterGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*parameterGroupArgs)(nil)).Elem()
}
