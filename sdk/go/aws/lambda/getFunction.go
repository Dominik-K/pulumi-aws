// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package lambda

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides information about a Lambda Function.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/lambda"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi/config"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		cfg := config.New(ctx, "")
// 		functionName := cfg.Require("functionName")
// 		_, err := lambda.LookupFunction(ctx, &lambda.LookupFunctionArgs{
// 			FunctionName: functionName,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func LookupFunction(ctx *pulumi.Context, args *LookupFunctionArgs, opts ...pulumi.InvokeOption) (*LookupFunctionResult, error) {
	var rv LookupFunctionResult
	err := ctx.Invoke("aws:lambda/getFunction:getFunction", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getFunction.
type LookupFunctionArgs struct {
	// Name of the lambda function.
	FunctionName string `pulumi:"functionName"`
	// Alias name or version number of the lambda function. e.g. `$LATEST`, `my-alias`, or `1`
	Qualifier *string           `pulumi:"qualifier"`
	Tags      map[string]string `pulumi:"tags"`
}

// A collection of values returned by getFunction.
type LookupFunctionResult struct {
	// Unqualified (no `:QUALIFIER` or `:VERSION` suffix) Amazon Resource Name (ARN) identifying your Lambda Function. See also `qualifiedArn`.
	Arn string `pulumi:"arn"`
	// Configure the function's *dead letter queue*.
	DeadLetterConfig GetFunctionDeadLetterConfig `pulumi:"deadLetterConfig"`
	// Description of what your Lambda Function does.
	Description string `pulumi:"description"`
	// The Lambda environment's configuration settings.
	Environment GetFunctionEnvironment `pulumi:"environment"`
	// The connection settings for an Amazon EFS file system.
	FileSystemConfigs []GetFunctionFileSystemConfig `pulumi:"fileSystemConfigs"`
	FunctionName      string                        `pulumi:"functionName"`
	// The function entrypoint in your code.
	Handler string `pulumi:"handler"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The ARN to be used for invoking Lambda Function from API Gateway.
	InvokeArn string `pulumi:"invokeArn"`
	// The ARN for the KMS encryption key.
	KmsKeyArn string `pulumi:"kmsKeyArn"`
	// The date this resource was last modified.
	LastModified string `pulumi:"lastModified"`
	// A list of Lambda Layer ARNs attached to your Lambda Function.
	Layers []string `pulumi:"layers"`
	// Amount of memory in MB your Lambda Function can use at runtime.
	MemorySize int `pulumi:"memorySize"`
	// Qualified (`:QUALIFIER` or `:VERSION` suffix) Amazon Resource Name (ARN) identifying your Lambda Function. See also `arn`.
	QualifiedArn string  `pulumi:"qualifiedArn"`
	Qualifier    *string `pulumi:"qualifier"`
	// The amount of reserved concurrent executions for this lambda function or `-1` if unreserved.
	ReservedConcurrentExecutions int `pulumi:"reservedConcurrentExecutions"`
	// IAM role attached to the Lambda Function.
	Role string `pulumi:"role"`
	// The runtime environment for the Lambda function..
	Runtime string `pulumi:"runtime"`
	// Base64-encoded representation of raw SHA-256 sum of the zip file.
	SourceCodeHash string `pulumi:"sourceCodeHash"`
	// The size in bytes of the function .zip file.
	SourceCodeSize int               `pulumi:"sourceCodeSize"`
	Tags           map[string]string `pulumi:"tags"`
	// The function execution time at which Lambda should terminate the function.
	Timeout int `pulumi:"timeout"`
	// Tracing settings of the function.
	TracingConfig GetFunctionTracingConfig `pulumi:"tracingConfig"`
	// The version of the Lambda function.
	Version string `pulumi:"version"`
	// VPC configuration associated with your Lambda function.
	VpcConfig GetFunctionVpcConfig `pulumi:"vpcConfig"`
}
