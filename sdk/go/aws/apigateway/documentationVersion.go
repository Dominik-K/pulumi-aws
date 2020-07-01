// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package apigateway

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a resource to manage an API Gateway Documentation Version.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/apigateway"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		exampleRestApi, err := apigateway.NewRestApi(ctx, "exampleRestApi", nil)
// 		if err != nil {
// 			return err
// 		}
// 		_, err = apigateway.NewDocumentationVersion(ctx, "exampleDocumentationVersion", &apigateway.DocumentationVersionArgs{
// 			Description: pulumi.String("Example description"),
// 			RestApiId:   exampleRestApi.ID(),
// 			Version:     pulumi.String("example_version"),
// 		}, pulumi.DependsOn([]pulumi.Resource{
// 			"aws_api_gateway_documentation_part.example",
// 		}))
// 		if err != nil {
// 			return err
// 		}
// 		_, err = apigateway.NewDocumentationPart(ctx, "exampleDocumentationPart", &apigateway.DocumentationPartArgs{
// 			Location: &apigateway.DocumentationPartLocationArgs{
// 				Type: pulumi.String("API"),
// 			},
// 			Properties: pulumi.String("{\"description\":\"Example\"}"),
// 			RestApiId:  exampleRestApi.ID(),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type DocumentationVersion struct {
	pulumi.CustomResourceState

	// The description of the API documentation version.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The ID of the associated Rest API
	RestApiId pulumi.StringOutput `pulumi:"restApiId"`
	// The version identifier of the API documentation snapshot.
	Version pulumi.StringOutput `pulumi:"version"`
}

// NewDocumentationVersion registers a new resource with the given unique name, arguments, and options.
func NewDocumentationVersion(ctx *pulumi.Context,
	name string, args *DocumentationVersionArgs, opts ...pulumi.ResourceOption) (*DocumentationVersion, error) {
	if args == nil || args.RestApiId == nil {
		return nil, errors.New("missing required argument 'RestApiId'")
	}
	if args == nil || args.Version == nil {
		return nil, errors.New("missing required argument 'Version'")
	}
	if args == nil {
		args = &DocumentationVersionArgs{}
	}
	var resource DocumentationVersion
	err := ctx.RegisterResource("aws:apigateway/documentationVersion:DocumentationVersion", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDocumentationVersion gets an existing DocumentationVersion resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDocumentationVersion(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DocumentationVersionState, opts ...pulumi.ResourceOption) (*DocumentationVersion, error) {
	var resource DocumentationVersion
	err := ctx.ReadResource("aws:apigateway/documentationVersion:DocumentationVersion", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DocumentationVersion resources.
type documentationVersionState struct {
	// The description of the API documentation version.
	Description *string `pulumi:"description"`
	// The ID of the associated Rest API
	RestApiId *string `pulumi:"restApiId"`
	// The version identifier of the API documentation snapshot.
	Version *string `pulumi:"version"`
}

type DocumentationVersionState struct {
	// The description of the API documentation version.
	Description pulumi.StringPtrInput
	// The ID of the associated Rest API
	RestApiId pulumi.StringPtrInput
	// The version identifier of the API documentation snapshot.
	Version pulumi.StringPtrInput
}

func (DocumentationVersionState) ElementType() reflect.Type {
	return reflect.TypeOf((*documentationVersionState)(nil)).Elem()
}

type documentationVersionArgs struct {
	// The description of the API documentation version.
	Description *string `pulumi:"description"`
	// The ID of the associated Rest API
	RestApiId string `pulumi:"restApiId"`
	// The version identifier of the API documentation snapshot.
	Version string `pulumi:"version"`
}

// The set of arguments for constructing a DocumentationVersion resource.
type DocumentationVersionArgs struct {
	// The description of the API documentation version.
	Description pulumi.StringPtrInput
	// The ID of the associated Rest API
	RestApiId pulumi.StringInput
	// The version identifier of the API documentation snapshot.
	Version pulumi.StringInput
}

func (DocumentationVersionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*documentationVersionArgs)(nil)).Elem()
}
