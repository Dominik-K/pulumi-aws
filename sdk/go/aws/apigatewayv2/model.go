// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package apigatewayv2

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages an Amazon API Gateway Version 2 [model](https://docs.aws.amazon.com/apigateway/latest/developerguide/models-mappings.html#models-mappings-models).
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
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/apigatewayv2"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := apigatewayv2.NewModel(ctx, "example", &apigatewayv2.ModelArgs{
// 			ApiId:       pulumi.Any(aws_apigatewayv2_api.Example.Id),
// 			ContentType: pulumi.String("application/json"),
// 			Schema:      pulumi.String(fmt.Sprintf("%v%v%v%v%v%v%v%v%v%v", "{\n", "  \"", "$", "schema\": \"http://json-schema.org/draft-04/schema#\",\n", "  \"title\": \"ExampleModel\",\n", "  \"type\": \"object\",\n", "  \"properties\": {\n", "    \"id\": { \"type\": \"string\" }\n", "  }\n", "}\n")),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type Model struct {
	pulumi.CustomResourceState

	// The API identifier.
	ApiId pulumi.StringOutput `pulumi:"apiId"`
	// The content-type for the model, for example, `application/json`.
	ContentType pulumi.StringOutput `pulumi:"contentType"`
	// The description of the model.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The name of the model. Must be alphanumeric.
	Name pulumi.StringOutput `pulumi:"name"`
	// The schema for the model. This should be a [JSON schema draft 4](https://tools.ietf.org/html/draft-zyp-json-schema-04) model.
	Schema pulumi.StringOutput `pulumi:"schema"`
}

// NewModel registers a new resource with the given unique name, arguments, and options.
func NewModel(ctx *pulumi.Context,
	name string, args *ModelArgs, opts ...pulumi.ResourceOption) (*Model, error) {
	if args == nil || args.ApiId == nil {
		return nil, errors.New("missing required argument 'ApiId'")
	}
	if args == nil || args.ContentType == nil {
		return nil, errors.New("missing required argument 'ContentType'")
	}
	if args == nil || args.Schema == nil {
		return nil, errors.New("missing required argument 'Schema'")
	}
	if args == nil {
		args = &ModelArgs{}
	}
	var resource Model
	err := ctx.RegisterResource("aws:apigatewayv2/model:Model", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetModel gets an existing Model resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetModel(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ModelState, opts ...pulumi.ResourceOption) (*Model, error) {
	var resource Model
	err := ctx.ReadResource("aws:apigatewayv2/model:Model", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Model resources.
type modelState struct {
	// The API identifier.
	ApiId *string `pulumi:"apiId"`
	// The content-type for the model, for example, `application/json`.
	ContentType *string `pulumi:"contentType"`
	// The description of the model.
	Description *string `pulumi:"description"`
	// The name of the model. Must be alphanumeric.
	Name *string `pulumi:"name"`
	// The schema for the model. This should be a [JSON schema draft 4](https://tools.ietf.org/html/draft-zyp-json-schema-04) model.
	Schema *string `pulumi:"schema"`
}

type ModelState struct {
	// The API identifier.
	ApiId pulumi.StringPtrInput
	// The content-type for the model, for example, `application/json`.
	ContentType pulumi.StringPtrInput
	// The description of the model.
	Description pulumi.StringPtrInput
	// The name of the model. Must be alphanumeric.
	Name pulumi.StringPtrInput
	// The schema for the model. This should be a [JSON schema draft 4](https://tools.ietf.org/html/draft-zyp-json-schema-04) model.
	Schema pulumi.StringPtrInput
}

func (ModelState) ElementType() reflect.Type {
	return reflect.TypeOf((*modelState)(nil)).Elem()
}

type modelArgs struct {
	// The API identifier.
	ApiId string `pulumi:"apiId"`
	// The content-type for the model, for example, `application/json`.
	ContentType string `pulumi:"contentType"`
	// The description of the model.
	Description *string `pulumi:"description"`
	// The name of the model. Must be alphanumeric.
	Name *string `pulumi:"name"`
	// The schema for the model. This should be a [JSON schema draft 4](https://tools.ietf.org/html/draft-zyp-json-schema-04) model.
	Schema string `pulumi:"schema"`
}

// The set of arguments for constructing a Model resource.
type ModelArgs struct {
	// The API identifier.
	ApiId pulumi.StringInput
	// The content-type for the model, for example, `application/json`.
	ContentType pulumi.StringInput
	// The description of the model.
	Description pulumi.StringPtrInput
	// The name of the model. Must be alphanumeric.
	Name pulumi.StringPtrInput
	// The schema for the model. This should be a [JSON schema draft 4](https://tools.ietf.org/html/draft-zyp-json-schema-04) model.
	Schema pulumi.StringInput
}

func (ModelArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*modelArgs)(nil)).Elem()
}
