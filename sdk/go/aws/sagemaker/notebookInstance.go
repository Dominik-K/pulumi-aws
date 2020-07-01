// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package sagemaker

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Sagemaker Notebook Instance resource.
//
// ## Example Usage
//
// Basic usage:
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/sagemaker"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := sagemaker.NewNotebookInstance(ctx, "ni", &sagemaker.NotebookInstanceArgs{
// 			InstanceType: pulumi.String("ml.t2.medium"),
// 			RoleArn:      pulumi.String(aws_iam_role.Role.Arn),
// 			Tags: pulumi.StringMap{
// 				"Name": pulumi.String("foo"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type NotebookInstance struct {
	pulumi.CustomResourceState

	// The Amazon Resource Name (ARN) assigned by AWS to this notebook instance.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// Set to `Disabled` to disable internet access to notebook. Requires `securityGroups` and `subnetId` to be set. Supported values: `Enabled` (Default) or `Disabled`. If set to `Disabled`, the notebook instance will be able to access resources only in your VPC, and will not be able to connect to Amazon SageMaker training and endpoint services unless your configure a NAT Gateway in your VPC.
	DirectInternetAccess pulumi.StringPtrOutput `pulumi:"directInternetAccess"`
	// The name of ML compute instance type.
	InstanceType pulumi.StringOutput `pulumi:"instanceType"`
	// The AWS Key Management Service (AWS KMS) key that Amazon SageMaker uses to encrypt the model artifacts at rest using Amazon S3 server-side encryption.
	KmsKeyId pulumi.StringPtrOutput `pulumi:"kmsKeyId"`
	// The name of a lifecycle configuration to associate with the notebook instance.
	LifecycleConfigName pulumi.StringPtrOutput `pulumi:"lifecycleConfigName"`
	// The name of the notebook instance (must be unique).
	Name pulumi.StringOutput `pulumi:"name"`
	// The ARN of the IAM role to be used by the notebook instance which allows SageMaker to call other services on your behalf.
	RoleArn pulumi.StringOutput `pulumi:"roleArn"`
	// The associated security groups.
	SecurityGroups pulumi.StringArrayOutput `pulumi:"securityGroups"`
	// The VPC subnet ID.
	SubnetId pulumi.StringPtrOutput `pulumi:"subnetId"`
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
}

// NewNotebookInstance registers a new resource with the given unique name, arguments, and options.
func NewNotebookInstance(ctx *pulumi.Context,
	name string, args *NotebookInstanceArgs, opts ...pulumi.ResourceOption) (*NotebookInstance, error) {
	if args == nil || args.InstanceType == nil {
		return nil, errors.New("missing required argument 'InstanceType'")
	}
	if args == nil || args.RoleArn == nil {
		return nil, errors.New("missing required argument 'RoleArn'")
	}
	if args == nil {
		args = &NotebookInstanceArgs{}
	}
	var resource NotebookInstance
	err := ctx.RegisterResource("aws:sagemaker/notebookInstance:NotebookInstance", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNotebookInstance gets an existing NotebookInstance resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNotebookInstance(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NotebookInstanceState, opts ...pulumi.ResourceOption) (*NotebookInstance, error) {
	var resource NotebookInstance
	err := ctx.ReadResource("aws:sagemaker/notebookInstance:NotebookInstance", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NotebookInstance resources.
type notebookInstanceState struct {
	// The Amazon Resource Name (ARN) assigned by AWS to this notebook instance.
	Arn *string `pulumi:"arn"`
	// Set to `Disabled` to disable internet access to notebook. Requires `securityGroups` and `subnetId` to be set. Supported values: `Enabled` (Default) or `Disabled`. If set to `Disabled`, the notebook instance will be able to access resources only in your VPC, and will not be able to connect to Amazon SageMaker training and endpoint services unless your configure a NAT Gateway in your VPC.
	DirectInternetAccess *string `pulumi:"directInternetAccess"`
	// The name of ML compute instance type.
	InstanceType *string `pulumi:"instanceType"`
	// The AWS Key Management Service (AWS KMS) key that Amazon SageMaker uses to encrypt the model artifacts at rest using Amazon S3 server-side encryption.
	KmsKeyId *string `pulumi:"kmsKeyId"`
	// The name of a lifecycle configuration to associate with the notebook instance.
	LifecycleConfigName *string `pulumi:"lifecycleConfigName"`
	// The name of the notebook instance (must be unique).
	Name *string `pulumi:"name"`
	// The ARN of the IAM role to be used by the notebook instance which allows SageMaker to call other services on your behalf.
	RoleArn *string `pulumi:"roleArn"`
	// The associated security groups.
	SecurityGroups []string `pulumi:"securityGroups"`
	// The VPC subnet ID.
	SubnetId *string `pulumi:"subnetId"`
	// A map of tags to assign to the resource.
	Tags map[string]string `pulumi:"tags"`
}

type NotebookInstanceState struct {
	// The Amazon Resource Name (ARN) assigned by AWS to this notebook instance.
	Arn pulumi.StringPtrInput
	// Set to `Disabled` to disable internet access to notebook. Requires `securityGroups` and `subnetId` to be set. Supported values: `Enabled` (Default) or `Disabled`. If set to `Disabled`, the notebook instance will be able to access resources only in your VPC, and will not be able to connect to Amazon SageMaker training and endpoint services unless your configure a NAT Gateway in your VPC.
	DirectInternetAccess pulumi.StringPtrInput
	// The name of ML compute instance type.
	InstanceType pulumi.StringPtrInput
	// The AWS Key Management Service (AWS KMS) key that Amazon SageMaker uses to encrypt the model artifacts at rest using Amazon S3 server-side encryption.
	KmsKeyId pulumi.StringPtrInput
	// The name of a lifecycle configuration to associate with the notebook instance.
	LifecycleConfigName pulumi.StringPtrInput
	// The name of the notebook instance (must be unique).
	Name pulumi.StringPtrInput
	// The ARN of the IAM role to be used by the notebook instance which allows SageMaker to call other services on your behalf.
	RoleArn pulumi.StringPtrInput
	// The associated security groups.
	SecurityGroups pulumi.StringArrayInput
	// The VPC subnet ID.
	SubnetId pulumi.StringPtrInput
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapInput
}

func (NotebookInstanceState) ElementType() reflect.Type {
	return reflect.TypeOf((*notebookInstanceState)(nil)).Elem()
}

type notebookInstanceArgs struct {
	// Set to `Disabled` to disable internet access to notebook. Requires `securityGroups` and `subnetId` to be set. Supported values: `Enabled` (Default) or `Disabled`. If set to `Disabled`, the notebook instance will be able to access resources only in your VPC, and will not be able to connect to Amazon SageMaker training and endpoint services unless your configure a NAT Gateway in your VPC.
	DirectInternetAccess *string `pulumi:"directInternetAccess"`
	// The name of ML compute instance type.
	InstanceType string `pulumi:"instanceType"`
	// The AWS Key Management Service (AWS KMS) key that Amazon SageMaker uses to encrypt the model artifacts at rest using Amazon S3 server-side encryption.
	KmsKeyId *string `pulumi:"kmsKeyId"`
	// The name of a lifecycle configuration to associate with the notebook instance.
	LifecycleConfigName *string `pulumi:"lifecycleConfigName"`
	// The name of the notebook instance (must be unique).
	Name *string `pulumi:"name"`
	// The ARN of the IAM role to be used by the notebook instance which allows SageMaker to call other services on your behalf.
	RoleArn string `pulumi:"roleArn"`
	// The associated security groups.
	SecurityGroups []string `pulumi:"securityGroups"`
	// The VPC subnet ID.
	SubnetId *string `pulumi:"subnetId"`
	// A map of tags to assign to the resource.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a NotebookInstance resource.
type NotebookInstanceArgs struct {
	// Set to `Disabled` to disable internet access to notebook. Requires `securityGroups` and `subnetId` to be set. Supported values: `Enabled` (Default) or `Disabled`. If set to `Disabled`, the notebook instance will be able to access resources only in your VPC, and will not be able to connect to Amazon SageMaker training and endpoint services unless your configure a NAT Gateway in your VPC.
	DirectInternetAccess pulumi.StringPtrInput
	// The name of ML compute instance type.
	InstanceType pulumi.StringInput
	// The AWS Key Management Service (AWS KMS) key that Amazon SageMaker uses to encrypt the model artifacts at rest using Amazon S3 server-side encryption.
	KmsKeyId pulumi.StringPtrInput
	// The name of a lifecycle configuration to associate with the notebook instance.
	LifecycleConfigName pulumi.StringPtrInput
	// The name of the notebook instance (must be unique).
	Name pulumi.StringPtrInput
	// The ARN of the IAM role to be used by the notebook instance which allows SageMaker to call other services on your behalf.
	RoleArn pulumi.StringInput
	// The associated security groups.
	SecurityGroups pulumi.StringArrayInput
	// The VPC subnet ID.
	SubnetId pulumi.StringPtrInput
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapInput
}

func (NotebookInstanceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*notebookInstanceArgs)(nil)).Elem()
}
