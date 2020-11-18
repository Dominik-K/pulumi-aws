// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package apigateway

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides an API Gateway Usage Plan Key.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/apigateway"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		test, err := apigateway.NewRestApi(ctx, "test", nil)
// 		if err != nil {
// 			return err
// 		}
// 		myusageplan, err := apigateway.NewUsagePlan(ctx, "myusageplan", &apigateway.UsagePlanArgs{
// 			ApiStages: apigateway.UsagePlanApiStageArray{
// 				&apigateway.UsagePlanApiStageArgs{
// 					ApiId: test.ID(),
// 					Stage: pulumi.Any(aws_api_gateway_deployment.Foo.Stage_name),
// 				},
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		mykey, err := apigateway.NewApiKey(ctx, "mykey", nil)
// 		if err != nil {
// 			return err
// 		}
// 		_, err = apigateway.NewUsagePlanKey(ctx, "main", &apigateway.UsagePlanKeyArgs{
// 			KeyId:       mykey.ID(),
// 			KeyType:     pulumi.String("API_KEY"),
// 			UsagePlanId: myusageplan.ID(),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type UsagePlanKey struct {
	pulumi.CustomResourceState

	// The identifier of the API key resource.
	KeyId pulumi.StringOutput `pulumi:"keyId"`
	// The type of the API key resource. Currently, the valid key type is API_KEY.
	KeyType pulumi.StringOutput `pulumi:"keyType"`
	// The name of a usage plan key.
	Name pulumi.StringOutput `pulumi:"name"`
	// The Id of the usage plan resource representing to associate the key to.
	UsagePlanId pulumi.StringOutput `pulumi:"usagePlanId"`
	// The value of a usage plan key.
	Value pulumi.StringOutput `pulumi:"value"`
}

// NewUsagePlanKey registers a new resource with the given unique name, arguments, and options.
func NewUsagePlanKey(ctx *pulumi.Context,
	name string, args *UsagePlanKeyArgs, opts ...pulumi.ResourceOption) (*UsagePlanKey, error) {
	if args == nil || args.KeyId == nil {
		return nil, errors.New("missing required argument 'KeyId'")
	}
	if args == nil || args.KeyType == nil {
		return nil, errors.New("missing required argument 'KeyType'")
	}
	if args == nil || args.UsagePlanId == nil {
		return nil, errors.New("missing required argument 'UsagePlanId'")
	}
	if args == nil {
		args = &UsagePlanKeyArgs{}
	}
	var resource UsagePlanKey
	err := ctx.RegisterResource("aws:apigateway/usagePlanKey:UsagePlanKey", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetUsagePlanKey gets an existing UsagePlanKey resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetUsagePlanKey(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *UsagePlanKeyState, opts ...pulumi.ResourceOption) (*UsagePlanKey, error) {
	var resource UsagePlanKey
	err := ctx.ReadResource("aws:apigateway/usagePlanKey:UsagePlanKey", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering UsagePlanKey resources.
type usagePlanKeyState struct {
	// The identifier of the API key resource.
	KeyId *string `pulumi:"keyId"`
	// The type of the API key resource. Currently, the valid key type is API_KEY.
	KeyType *string `pulumi:"keyType"`
	// The name of a usage plan key.
	Name *string `pulumi:"name"`
	// The Id of the usage plan resource representing to associate the key to.
	UsagePlanId *string `pulumi:"usagePlanId"`
	// The value of a usage plan key.
	Value *string `pulumi:"value"`
}

type UsagePlanKeyState struct {
	// The identifier of the API key resource.
	KeyId pulumi.StringPtrInput
	// The type of the API key resource. Currently, the valid key type is API_KEY.
	KeyType pulumi.StringPtrInput
	// The name of a usage plan key.
	Name pulumi.StringPtrInput
	// The Id of the usage plan resource representing to associate the key to.
	UsagePlanId pulumi.StringPtrInput
	// The value of a usage plan key.
	Value pulumi.StringPtrInput
}

func (UsagePlanKeyState) ElementType() reflect.Type {
	return reflect.TypeOf((*usagePlanKeyState)(nil)).Elem()
}

type usagePlanKeyArgs struct {
	// The identifier of the API key resource.
	KeyId string `pulumi:"keyId"`
	// The type of the API key resource. Currently, the valid key type is API_KEY.
	KeyType string `pulumi:"keyType"`
	// The Id of the usage plan resource representing to associate the key to.
	UsagePlanId string `pulumi:"usagePlanId"`
}

// The set of arguments for constructing a UsagePlanKey resource.
type UsagePlanKeyArgs struct {
	// The identifier of the API key resource.
	KeyId pulumi.StringInput
	// The type of the API key resource. Currently, the valid key type is API_KEY.
	KeyType pulumi.StringInput
	// The Id of the usage plan resource representing to associate the key to.
	UsagePlanId pulumi.StringInput
}

func (UsagePlanKeyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*usagePlanKeyArgs)(nil)).Elem()
}
