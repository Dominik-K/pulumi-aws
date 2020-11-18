// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package storagegateway

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages an AWS Storage Gateway Tape Pool.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/storagegateway"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := storagegateway.NewTapePool(ctx, "example", &storagegateway.TapePoolArgs{
// 			PoolName:     pulumi.String("example"),
// 			StorageClass: pulumi.String("GLACIER"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type TapePool struct {
	pulumi.CustomResourceState

	// Volume Amazon Resource Name (ARN), e.g. `aws_storagegateway_tape_pool.example arn:aws:storagegateway:us-east-1:123456789012:tapepool/pool-12345678`.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// The name of the new custom tape pool.
	PoolName pulumi.StringOutput `pulumi:"poolName"`
	// Tape retention lock time is set in days. Tape retention lock can be enabled for up to 100 years (36,500 days). Default value is 0.
	RetentionLockTimeInDays pulumi.IntPtrOutput `pulumi:"retentionLockTimeInDays"`
	// Tape retention lock can be configured in two modes. When configured in governance mode, AWS accounts with specific IAM permissions are authorized to remove the tape retention lock from archived virtual tapes. When configured in compliance mode, the tape retention lock cannot be removed by any user, including the root AWS account. Possible values are `COMPLIANCE`, `GOVERNANCE`, and `NONE`. Default value is `NONE`.
	RetentionLockType pulumi.StringPtrOutput `pulumi:"retentionLockType"`
	// The storage class that is associated with the new custom pool. When you use your backup application to eject the tape, the tape is archived directly into the storage class that corresponds to the pool. Possible values are `DEEP_ARCHIVE` or `GLACIER`.
	StorageClass pulumi.StringOutput `pulumi:"storageClass"`
	// Key-value map of resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
}

// NewTapePool registers a new resource with the given unique name, arguments, and options.
func NewTapePool(ctx *pulumi.Context,
	name string, args *TapePoolArgs, opts ...pulumi.ResourceOption) (*TapePool, error) {
	if args == nil || args.PoolName == nil {
		return nil, errors.New("missing required argument 'PoolName'")
	}
	if args == nil || args.StorageClass == nil {
		return nil, errors.New("missing required argument 'StorageClass'")
	}
	if args == nil {
		args = &TapePoolArgs{}
	}
	var resource TapePool
	err := ctx.RegisterResource("aws:storagegateway/tapePool:TapePool", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTapePool gets an existing TapePool resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTapePool(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TapePoolState, opts ...pulumi.ResourceOption) (*TapePool, error) {
	var resource TapePool
	err := ctx.ReadResource("aws:storagegateway/tapePool:TapePool", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TapePool resources.
type tapePoolState struct {
	// Volume Amazon Resource Name (ARN), e.g. `aws_storagegateway_tape_pool.example arn:aws:storagegateway:us-east-1:123456789012:tapepool/pool-12345678`.
	Arn *string `pulumi:"arn"`
	// The name of the new custom tape pool.
	PoolName *string `pulumi:"poolName"`
	// Tape retention lock time is set in days. Tape retention lock can be enabled for up to 100 years (36,500 days). Default value is 0.
	RetentionLockTimeInDays *int `pulumi:"retentionLockTimeInDays"`
	// Tape retention lock can be configured in two modes. When configured in governance mode, AWS accounts with specific IAM permissions are authorized to remove the tape retention lock from archived virtual tapes. When configured in compliance mode, the tape retention lock cannot be removed by any user, including the root AWS account. Possible values are `COMPLIANCE`, `GOVERNANCE`, and `NONE`. Default value is `NONE`.
	RetentionLockType *string `pulumi:"retentionLockType"`
	// The storage class that is associated with the new custom pool. When you use your backup application to eject the tape, the tape is archived directly into the storage class that corresponds to the pool. Possible values are `DEEP_ARCHIVE` or `GLACIER`.
	StorageClass *string `pulumi:"storageClass"`
	// Key-value map of resource tags
	Tags map[string]string `pulumi:"tags"`
}

type TapePoolState struct {
	// Volume Amazon Resource Name (ARN), e.g. `aws_storagegateway_tape_pool.example arn:aws:storagegateway:us-east-1:123456789012:tapepool/pool-12345678`.
	Arn pulumi.StringPtrInput
	// The name of the new custom tape pool.
	PoolName pulumi.StringPtrInput
	// Tape retention lock time is set in days. Tape retention lock can be enabled for up to 100 years (36,500 days). Default value is 0.
	RetentionLockTimeInDays pulumi.IntPtrInput
	// Tape retention lock can be configured in two modes. When configured in governance mode, AWS accounts with specific IAM permissions are authorized to remove the tape retention lock from archived virtual tapes. When configured in compliance mode, the tape retention lock cannot be removed by any user, including the root AWS account. Possible values are `COMPLIANCE`, `GOVERNANCE`, and `NONE`. Default value is `NONE`.
	RetentionLockType pulumi.StringPtrInput
	// The storage class that is associated with the new custom pool. When you use your backup application to eject the tape, the tape is archived directly into the storage class that corresponds to the pool. Possible values are `DEEP_ARCHIVE` or `GLACIER`.
	StorageClass pulumi.StringPtrInput
	// Key-value map of resource tags
	Tags pulumi.StringMapInput
}

func (TapePoolState) ElementType() reflect.Type {
	return reflect.TypeOf((*tapePoolState)(nil)).Elem()
}

type tapePoolArgs struct {
	// The name of the new custom tape pool.
	PoolName string `pulumi:"poolName"`
	// Tape retention lock time is set in days. Tape retention lock can be enabled for up to 100 years (36,500 days). Default value is 0.
	RetentionLockTimeInDays *int `pulumi:"retentionLockTimeInDays"`
	// Tape retention lock can be configured in two modes. When configured in governance mode, AWS accounts with specific IAM permissions are authorized to remove the tape retention lock from archived virtual tapes. When configured in compliance mode, the tape retention lock cannot be removed by any user, including the root AWS account. Possible values are `COMPLIANCE`, `GOVERNANCE`, and `NONE`. Default value is `NONE`.
	RetentionLockType *string `pulumi:"retentionLockType"`
	// The storage class that is associated with the new custom pool. When you use your backup application to eject the tape, the tape is archived directly into the storage class that corresponds to the pool. Possible values are `DEEP_ARCHIVE` or `GLACIER`.
	StorageClass string `pulumi:"storageClass"`
	// Key-value map of resource tags
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a TapePool resource.
type TapePoolArgs struct {
	// The name of the new custom tape pool.
	PoolName pulumi.StringInput
	// Tape retention lock time is set in days. Tape retention lock can be enabled for up to 100 years (36,500 days). Default value is 0.
	RetentionLockTimeInDays pulumi.IntPtrInput
	// Tape retention lock can be configured in two modes. When configured in governance mode, AWS accounts with specific IAM permissions are authorized to remove the tape retention lock from archived virtual tapes. When configured in compliance mode, the tape retention lock cannot be removed by any user, including the root AWS account. Possible values are `COMPLIANCE`, `GOVERNANCE`, and `NONE`. Default value is `NONE`.
	RetentionLockType pulumi.StringPtrInput
	// The storage class that is associated with the new custom pool. When you use your backup application to eject the tape, the tape is archived directly into the storage class that corresponds to the pool. Possible values are `DEEP_ARCHIVE` or `GLACIER`.
	StorageClass pulumi.StringInput
	// Key-value map of resource tags
	Tags pulumi.StringMapInput
}

func (TapePoolArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*tapePoolArgs)(nil)).Elem()
}
