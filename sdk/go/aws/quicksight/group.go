// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package quicksight

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Resource for managing QuickSight Group
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/quicksight"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := quicksight.NewGroup(ctx, "example", &quicksight.GroupArgs{
// 			GroupName: pulumi.String("tf-example"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type Group struct {
	pulumi.CustomResourceState

	// Amazon Resource Name (ARN) of group
	Arn pulumi.StringOutput `pulumi:"arn"`
	// The ID for the AWS account that the group is in. Currently, you use the ID for the AWS account that contains your Amazon QuickSight account.
	AwsAccountId pulumi.StringOutput `pulumi:"awsAccountId"`
	// A description for the group.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// A name for the group.
	GroupName pulumi.StringOutput `pulumi:"groupName"`
	// The namespace. Currently, you should set this to `default`.
	Namespace pulumi.StringPtrOutput `pulumi:"namespace"`
}

// NewGroup registers a new resource with the given unique name, arguments, and options.
func NewGroup(ctx *pulumi.Context,
	name string, args *GroupArgs, opts ...pulumi.ResourceOption) (*Group, error) {
	if args == nil || args.GroupName == nil {
		return nil, errors.New("missing required argument 'GroupName'")
	}
	if args == nil {
		args = &GroupArgs{}
	}
	var resource Group
	err := ctx.RegisterResource("aws:quicksight/group:Group", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGroup gets an existing Group resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GroupState, opts ...pulumi.ResourceOption) (*Group, error) {
	var resource Group
	err := ctx.ReadResource("aws:quicksight/group:Group", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Group resources.
type groupState struct {
	// Amazon Resource Name (ARN) of group
	Arn *string `pulumi:"arn"`
	// The ID for the AWS account that the group is in. Currently, you use the ID for the AWS account that contains your Amazon QuickSight account.
	AwsAccountId *string `pulumi:"awsAccountId"`
	// A description for the group.
	Description *string `pulumi:"description"`
	// A name for the group.
	GroupName *string `pulumi:"groupName"`
	// The namespace. Currently, you should set this to `default`.
	Namespace *string `pulumi:"namespace"`
}

type GroupState struct {
	// Amazon Resource Name (ARN) of group
	Arn pulumi.StringPtrInput
	// The ID for the AWS account that the group is in. Currently, you use the ID for the AWS account that contains your Amazon QuickSight account.
	AwsAccountId pulumi.StringPtrInput
	// A description for the group.
	Description pulumi.StringPtrInput
	// A name for the group.
	GroupName pulumi.StringPtrInput
	// The namespace. Currently, you should set this to `default`.
	Namespace pulumi.StringPtrInput
}

func (GroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*groupState)(nil)).Elem()
}

type groupArgs struct {
	// The ID for the AWS account that the group is in. Currently, you use the ID for the AWS account that contains your Amazon QuickSight account.
	AwsAccountId *string `pulumi:"awsAccountId"`
	// A description for the group.
	Description *string `pulumi:"description"`
	// A name for the group.
	GroupName string `pulumi:"groupName"`
	// The namespace. Currently, you should set this to `default`.
	Namespace *string `pulumi:"namespace"`
}

// The set of arguments for constructing a Group resource.
type GroupArgs struct {
	// The ID for the AWS account that the group is in. Currently, you use the ID for the AWS account that contains your Amazon QuickSight account.
	AwsAccountId pulumi.StringPtrInput
	// A description for the group.
	Description pulumi.StringPtrInput
	// A name for the group.
	GroupName pulumi.StringInput
	// The namespace. Currently, you should set this to `default`.
	Namespace pulumi.StringPtrInput
}

func (GroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*groupArgs)(nil)).Elem()
}
