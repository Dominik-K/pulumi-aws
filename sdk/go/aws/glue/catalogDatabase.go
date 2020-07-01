// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package glue

import (
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Glue Catalog Database Resource. You can refer to the [Glue Developer Guide](http://docs.aws.amazon.com/glue/latest/dg/populate-data-catalog.html) for a full explanation of the Glue Data Catalog functionality
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/glue"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := glue.NewCatalogDatabase(ctx, "awsGlueCatalogDatabase", &glue.CatalogDatabaseArgs{
// 			Name: pulumi.String("MyCatalogDatabase"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type CatalogDatabase struct {
	pulumi.CustomResourceState

	// The ARN of the Glue Catalog Database.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// ID of the Glue Catalog to create the database in. If omitted, this defaults to the AWS Account ID.
	CatalogId pulumi.StringOutput `pulumi:"catalogId"`
	// Description of the database.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The location of the database (for example, an HDFS path).
	LocationUri pulumi.StringPtrOutput `pulumi:"locationUri"`
	// The name of the database.
	Name pulumi.StringOutput `pulumi:"name"`
	// A list of key-value pairs that define parameters and properties of the database.
	Parameters pulumi.StringMapOutput `pulumi:"parameters"`
}

// NewCatalogDatabase registers a new resource with the given unique name, arguments, and options.
func NewCatalogDatabase(ctx *pulumi.Context,
	name string, args *CatalogDatabaseArgs, opts ...pulumi.ResourceOption) (*CatalogDatabase, error) {
	if args == nil {
		args = &CatalogDatabaseArgs{}
	}
	var resource CatalogDatabase
	err := ctx.RegisterResource("aws:glue/catalogDatabase:CatalogDatabase", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCatalogDatabase gets an existing CatalogDatabase resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCatalogDatabase(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CatalogDatabaseState, opts ...pulumi.ResourceOption) (*CatalogDatabase, error) {
	var resource CatalogDatabase
	err := ctx.ReadResource("aws:glue/catalogDatabase:CatalogDatabase", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CatalogDatabase resources.
type catalogDatabaseState struct {
	// The ARN of the Glue Catalog Database.
	Arn *string `pulumi:"arn"`
	// ID of the Glue Catalog to create the database in. If omitted, this defaults to the AWS Account ID.
	CatalogId *string `pulumi:"catalogId"`
	// Description of the database.
	Description *string `pulumi:"description"`
	// The location of the database (for example, an HDFS path).
	LocationUri *string `pulumi:"locationUri"`
	// The name of the database.
	Name *string `pulumi:"name"`
	// A list of key-value pairs that define parameters and properties of the database.
	Parameters map[string]string `pulumi:"parameters"`
}

type CatalogDatabaseState struct {
	// The ARN of the Glue Catalog Database.
	Arn pulumi.StringPtrInput
	// ID of the Glue Catalog to create the database in. If omitted, this defaults to the AWS Account ID.
	CatalogId pulumi.StringPtrInput
	// Description of the database.
	Description pulumi.StringPtrInput
	// The location of the database (for example, an HDFS path).
	LocationUri pulumi.StringPtrInput
	// The name of the database.
	Name pulumi.StringPtrInput
	// A list of key-value pairs that define parameters and properties of the database.
	Parameters pulumi.StringMapInput
}

func (CatalogDatabaseState) ElementType() reflect.Type {
	return reflect.TypeOf((*catalogDatabaseState)(nil)).Elem()
}

type catalogDatabaseArgs struct {
	// ID of the Glue Catalog to create the database in. If omitted, this defaults to the AWS Account ID.
	CatalogId *string `pulumi:"catalogId"`
	// Description of the database.
	Description *string `pulumi:"description"`
	// The location of the database (for example, an HDFS path).
	LocationUri *string `pulumi:"locationUri"`
	// The name of the database.
	Name *string `pulumi:"name"`
	// A list of key-value pairs that define parameters and properties of the database.
	Parameters map[string]string `pulumi:"parameters"`
}

// The set of arguments for constructing a CatalogDatabase resource.
type CatalogDatabaseArgs struct {
	// ID of the Glue Catalog to create the database in. If omitted, this defaults to the AWS Account ID.
	CatalogId pulumi.StringPtrInput
	// Description of the database.
	Description pulumi.StringPtrInput
	// The location of the database (for example, an HDFS path).
	LocationUri pulumi.StringPtrInput
	// The name of the database.
	Name pulumi.StringPtrInput
	// A list of key-value pairs that define parameters and properties of the database.
	Parameters pulumi.StringMapInput
}

func (CatalogDatabaseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*catalogDatabaseArgs)(nil)).Elem()
}
