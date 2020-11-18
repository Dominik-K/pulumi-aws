// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package athena

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides an Athena database.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/athena"
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/s3"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		hogeBucket, err := s3.NewBucket(ctx, "hogeBucket", nil)
// 		if err != nil {
// 			return err
// 		}
// 		_, err = athena.NewDatabase(ctx, "hogeDatabase", &athena.DatabaseArgs{
// 			Name:   pulumi.String("database_name"),
// 			Bucket: hogeBucket.Bucket,
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type Database struct {
	pulumi.CustomResourceState

	// Name of s3 bucket to save the results of the query execution.
	Bucket pulumi.StringOutput `pulumi:"bucket"`
	// The encryption key block AWS Athena uses to decrypt the data in S3, such as an AWS Key Management Service (AWS KMS) key. An `encryptionConfiguration` block is documented below.
	EncryptionConfiguration DatabaseEncryptionConfigurationPtrOutput `pulumi:"encryptionConfiguration"`
	// A boolean that indicates all tables should be deleted from the database so that the database can be destroyed without error. The tables are *not* recoverable.
	ForceDestroy pulumi.BoolPtrOutput `pulumi:"forceDestroy"`
	// Name of the database to create.
	Name pulumi.StringOutput `pulumi:"name"`
}

// NewDatabase registers a new resource with the given unique name, arguments, and options.
func NewDatabase(ctx *pulumi.Context,
	name string, args *DatabaseArgs, opts ...pulumi.ResourceOption) (*Database, error) {
	if args == nil || args.Bucket == nil {
		return nil, errors.New("missing required argument 'Bucket'")
	}
	if args == nil {
		args = &DatabaseArgs{}
	}
	var resource Database
	err := ctx.RegisterResource("aws:athena/database:Database", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDatabase gets an existing Database resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDatabase(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DatabaseState, opts ...pulumi.ResourceOption) (*Database, error) {
	var resource Database
	err := ctx.ReadResource("aws:athena/database:Database", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Database resources.
type databaseState struct {
	// Name of s3 bucket to save the results of the query execution.
	Bucket *string `pulumi:"bucket"`
	// The encryption key block AWS Athena uses to decrypt the data in S3, such as an AWS Key Management Service (AWS KMS) key. An `encryptionConfiguration` block is documented below.
	EncryptionConfiguration *DatabaseEncryptionConfiguration `pulumi:"encryptionConfiguration"`
	// A boolean that indicates all tables should be deleted from the database so that the database can be destroyed without error. The tables are *not* recoverable.
	ForceDestroy *bool `pulumi:"forceDestroy"`
	// Name of the database to create.
	Name *string `pulumi:"name"`
}

type DatabaseState struct {
	// Name of s3 bucket to save the results of the query execution.
	Bucket pulumi.StringPtrInput
	// The encryption key block AWS Athena uses to decrypt the data in S3, such as an AWS Key Management Service (AWS KMS) key. An `encryptionConfiguration` block is documented below.
	EncryptionConfiguration DatabaseEncryptionConfigurationPtrInput
	// A boolean that indicates all tables should be deleted from the database so that the database can be destroyed without error. The tables are *not* recoverable.
	ForceDestroy pulumi.BoolPtrInput
	// Name of the database to create.
	Name pulumi.StringPtrInput
}

func (DatabaseState) ElementType() reflect.Type {
	return reflect.TypeOf((*databaseState)(nil)).Elem()
}

type databaseArgs struct {
	// Name of s3 bucket to save the results of the query execution.
	Bucket string `pulumi:"bucket"`
	// The encryption key block AWS Athena uses to decrypt the data in S3, such as an AWS Key Management Service (AWS KMS) key. An `encryptionConfiguration` block is documented below.
	EncryptionConfiguration *DatabaseEncryptionConfiguration `pulumi:"encryptionConfiguration"`
	// A boolean that indicates all tables should be deleted from the database so that the database can be destroyed without error. The tables are *not* recoverable.
	ForceDestroy *bool `pulumi:"forceDestroy"`
	// Name of the database to create.
	Name *string `pulumi:"name"`
}

// The set of arguments for constructing a Database resource.
type DatabaseArgs struct {
	// Name of s3 bucket to save the results of the query execution.
	Bucket pulumi.StringInput
	// The encryption key block AWS Athena uses to decrypt the data in S3, such as an AWS Key Management Service (AWS KMS) key. An `encryptionConfiguration` block is documented below.
	EncryptionConfiguration DatabaseEncryptionConfigurationPtrInput
	// A boolean that indicates all tables should be deleted from the database so that the database can be destroyed without error. The tables are *not* recoverable.
	ForceDestroy pulumi.BoolPtrInput
	// Name of the database to create.
	Name pulumi.StringPtrInput
}

func (DatabaseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*databaseArgs)(nil)).Elem()
}
