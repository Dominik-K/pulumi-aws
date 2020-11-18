// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package secretsmanager

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a resource to manage AWS Secrets Manager secret policy.
//
// ## Example Usage
// ### Basic
//
// ```go
// package main
//
// import (
// 	"fmt"
//
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/secretsmanager"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		exampleSecret, err := secretsmanager.NewSecret(ctx, "exampleSecret", nil)
// 		if err != nil {
// 			return err
// 		}
// 		_, err = secretsmanager.NewSecretPolicy(ctx, "exampleSecretPolicy", &secretsmanager.SecretPolicyArgs{
// 			SecretArn: exampleSecret.Arn,
// 			Policy: pulumi.String(fmt.Sprintf("%v%v%v%v%v%v%v%v%v%v%v%v%v%v", "{\n", "  \"Version\": \"2012-10-17\",\n", "  \"Statement\": [\n", "	{\n", "	  \"Sid\": \"EnableAllPermissions\",\n", "	  \"Effect\": \"Allow\",\n", "	  \"Principal\": {\n", "		\"AWS\": \"*\"\n", "	  },\n", "	  \"Action\": \"secretsmanager:GetSecretValue\",\n", "	  \"Resource\": \"*\"\n", "	}\n", "  ]\n", "}\n")),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type SecretPolicy struct {
	pulumi.CustomResourceState

	// Makes an optional API call to Zelkova to validate the Resource Policy to prevent broad access to your secret.
	BlockPublicPolicy pulumi.BoolPtrOutput `pulumi:"blockPublicPolicy"`
	Policy            pulumi.StringOutput  `pulumi:"policy"`
	// Secret ARN.
	SecretArn pulumi.StringOutput `pulumi:"secretArn"`
}

// NewSecretPolicy registers a new resource with the given unique name, arguments, and options.
func NewSecretPolicy(ctx *pulumi.Context,
	name string, args *SecretPolicyArgs, opts ...pulumi.ResourceOption) (*SecretPolicy, error) {
	if args == nil || args.Policy == nil {
		return nil, errors.New("missing required argument 'Policy'")
	}
	if args == nil || args.SecretArn == nil {
		return nil, errors.New("missing required argument 'SecretArn'")
	}
	if args == nil {
		args = &SecretPolicyArgs{}
	}
	var resource SecretPolicy
	err := ctx.RegisterResource("aws:secretsmanager/secretPolicy:SecretPolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSecretPolicy gets an existing SecretPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSecretPolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SecretPolicyState, opts ...pulumi.ResourceOption) (*SecretPolicy, error) {
	var resource SecretPolicy
	err := ctx.ReadResource("aws:secretsmanager/secretPolicy:SecretPolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SecretPolicy resources.
type secretPolicyState struct {
	// Makes an optional API call to Zelkova to validate the Resource Policy to prevent broad access to your secret.
	BlockPublicPolicy *bool   `pulumi:"blockPublicPolicy"`
	Policy            *string `pulumi:"policy"`
	// Secret ARN.
	SecretArn *string `pulumi:"secretArn"`
}

type SecretPolicyState struct {
	// Makes an optional API call to Zelkova to validate the Resource Policy to prevent broad access to your secret.
	BlockPublicPolicy pulumi.BoolPtrInput
	Policy            pulumi.StringPtrInput
	// Secret ARN.
	SecretArn pulumi.StringPtrInput
}

func (SecretPolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*secretPolicyState)(nil)).Elem()
}

type secretPolicyArgs struct {
	// Makes an optional API call to Zelkova to validate the Resource Policy to prevent broad access to your secret.
	BlockPublicPolicy *bool  `pulumi:"blockPublicPolicy"`
	Policy            string `pulumi:"policy"`
	// Secret ARN.
	SecretArn string `pulumi:"secretArn"`
}

// The set of arguments for constructing a SecretPolicy resource.
type SecretPolicyArgs struct {
	// Makes an optional API call to Zelkova to validate the Resource Policy to prevent broad access to your secret.
	BlockPublicPolicy pulumi.BoolPtrInput
	Policy            pulumi.StringInput
	// Secret ARN.
	SecretArn pulumi.StringInput
}

func (SecretPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*secretPolicyArgs)(nil)).Elem()
}
