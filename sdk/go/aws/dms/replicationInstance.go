// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package dms

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a DMS (Data Migration Service) replication instance resource. DMS replication instances can be created, updated, deleted, and imported.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/dms"
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/iam"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		dmsAssumeRole, err := iam.GetPolicyDocument(ctx, &iam.GetPolicyDocumentArgs{
// 			Statements: []iam.GetPolicyDocumentStatement{
// 				iam.GetPolicyDocumentStatement{
// 					Actions: []string{
// 						"sts:AssumeRole",
// 					},
// 					Principals: []iam.GetPolicyDocumentStatementPrincipal{
// 						iam.GetPolicyDocumentStatementPrincipal{
// 							Identifiers: []string{
// 								"dms.amazonaws.com",
// 							},
// 							Type: "Service",
// 						},
// 					},
// 				},
// 			},
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		_, err = iam.NewRole(ctx, "dms_access_for_endpoint", &iam.RoleArgs{
// 			AssumeRolePolicy: pulumi.String(dmsAssumeRole.Json),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = iam.NewRolePolicyAttachment(ctx, "dms_access_for_endpoint_AmazonDMSRedshiftS3Role", &iam.RolePolicyAttachmentArgs{
// 			PolicyArn: pulumi.String("arn:aws:iam::aws:policy/service-role/AmazonDMSRedshiftS3Role"),
// 			Role:      dms_access_for_endpoint.Name,
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = iam.NewRole(ctx, "dms_cloudwatch_logs_role", &iam.RoleArgs{
// 			AssumeRolePolicy: pulumi.String(dmsAssumeRole.Json),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = iam.NewRolePolicyAttachment(ctx, "dms_cloudwatch_logs_role_AmazonDMSCloudWatchLogsRole", &iam.RolePolicyAttachmentArgs{
// 			PolicyArn: pulumi.String("arn:aws:iam::aws:policy/service-role/AmazonDMSCloudWatchLogsRole"),
// 			Role:      dms_cloudwatch_logs_role.Name,
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = iam.NewRole(ctx, "dms_vpc_role", &iam.RoleArgs{
// 			AssumeRolePolicy: pulumi.String(dmsAssumeRole.Json),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = iam.NewRolePolicyAttachment(ctx, "dms_vpc_role_AmazonDMSVPCManagementRole", &iam.RolePolicyAttachmentArgs{
// 			PolicyArn: pulumi.String("arn:aws:iam::aws:policy/service-role/AmazonDMSVPCManagementRole"),
// 			Role:      dms_vpc_role.Name,
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = dms.NewReplicationInstance(ctx, "test", &dms.ReplicationInstanceArgs{
// 			AllocatedStorage:           pulumi.Int(20),
// 			ApplyImmediately:           pulumi.Bool(true),
// 			AutoMinorVersionUpgrade:    pulumi.Bool(true),
// 			AvailabilityZone:           pulumi.String("us-west-2c"),
// 			EngineVersion:              pulumi.String("3.1.4"),
// 			KmsKeyArn:                  pulumi.String("arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012"),
// 			MultiAz:                    pulumi.Bool(false),
// 			PreferredMaintenanceWindow: pulumi.String("sun:10:30-sun:14:30"),
// 			PubliclyAccessible:         pulumi.Bool(true),
// 			ReplicationInstanceClass:   pulumi.String("dms.t2.micro"),
// 			ReplicationInstanceId:      pulumi.String("test-dms-replication-instance-tf"),
// 			ReplicationSubnetGroupId:   pulumi.String(aws_dms_replication_subnet_group.Test - dms - replication - subnet - group - tf.Id),
// 			Tags: pulumi.StringMap{
// 				"Name": pulumi.String("test"),
// 			},
// 			VpcSecurityGroupIds: pulumi.StringArray{
// 				pulumi.String("sg-12345678"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type ReplicationInstance struct {
	pulumi.CustomResourceState

	// The amount of storage (in gigabytes) to be initially allocated for the replication instance.
	AllocatedStorage pulumi.IntOutput `pulumi:"allocatedStorage"`
	// Indicates whether the changes should be applied immediately or during the next maintenance window. Only used when updating an existing resource.
	ApplyImmediately pulumi.BoolPtrOutput `pulumi:"applyImmediately"`
	// Indicates that minor engine upgrades will be applied automatically to the replication instance during the maintenance window.
	AutoMinorVersionUpgrade pulumi.BoolOutput `pulumi:"autoMinorVersionUpgrade"`
	// The EC2 Availability Zone that the replication instance will be created in.
	AvailabilityZone pulumi.StringOutput `pulumi:"availabilityZone"`
	// The engine version number of the replication instance.
	EngineVersion pulumi.StringOutput `pulumi:"engineVersion"`
	// The Amazon Resource Name (ARN) for the KMS key that will be used to encrypt the connection parameters. If you do not specify a value for `kmsKeyArn`, then AWS DMS will use your default encryption key. AWS KMS creates the default encryption key for your AWS account. Your AWS account has a different default encryption key for each AWS region.
	KmsKeyArn pulumi.StringOutput `pulumi:"kmsKeyArn"`
	// Specifies if the replication instance is a multi-az deployment. You cannot set the `availabilityZone` parameter if the `multiAz` parameter is set to `true`.
	MultiAz pulumi.BoolOutput `pulumi:"multiAz"`
	// The weekly time range during which system maintenance can occur, in Universal Coordinated Time (UTC).
	PreferredMaintenanceWindow pulumi.StringOutput `pulumi:"preferredMaintenanceWindow"`
	// Specifies the accessibility options for the replication instance. A value of true represents an instance with a public IP address. A value of false represents an instance with a private IP address.
	PubliclyAccessible pulumi.BoolOutput `pulumi:"publiclyAccessible"`
	// The Amazon Resource Name (ARN) of the replication instance.
	ReplicationInstanceArn pulumi.StringOutput `pulumi:"replicationInstanceArn"`
	// The compute and memory capacity of the replication instance as specified by the replication instance class. Can be one of `dms.t2.micro | dms.t2.small | dms.t2.medium | dms.t2.large | dms.c4.large | dms.c4.xlarge | dms.c4.2xlarge | dms.c4.4xlarge`
	ReplicationInstanceClass pulumi.StringOutput `pulumi:"replicationInstanceClass"`
	// The replication instance identifier. This parameter is stored as a lowercase string.
	ReplicationInstanceId pulumi.StringOutput `pulumi:"replicationInstanceId"`
	// A list of the private IP addresses of the replication instance.
	ReplicationInstancePrivateIps pulumi.StringArrayOutput `pulumi:"replicationInstancePrivateIps"`
	// A list of the public IP addresses of the replication instance.
	ReplicationInstancePublicIps pulumi.StringArrayOutput `pulumi:"replicationInstancePublicIps"`
	// A subnet group to associate with the replication instance.
	ReplicationSubnetGroupId pulumi.StringOutput `pulumi:"replicationSubnetGroupId"`
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// A list of VPC security group IDs to be used with the replication instance. The VPC security groups must work with the VPC containing the replication instance.
	VpcSecurityGroupIds pulumi.StringArrayOutput `pulumi:"vpcSecurityGroupIds"`
}

// NewReplicationInstance registers a new resource with the given unique name, arguments, and options.
func NewReplicationInstance(ctx *pulumi.Context,
	name string, args *ReplicationInstanceArgs, opts ...pulumi.ResourceOption) (*ReplicationInstance, error) {
	if args == nil || args.ReplicationInstanceClass == nil {
		return nil, errors.New("missing required argument 'ReplicationInstanceClass'")
	}
	if args == nil || args.ReplicationInstanceId == nil {
		return nil, errors.New("missing required argument 'ReplicationInstanceId'")
	}
	if args == nil {
		args = &ReplicationInstanceArgs{}
	}
	var resource ReplicationInstance
	err := ctx.RegisterResource("aws:dms/replicationInstance:ReplicationInstance", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetReplicationInstance gets an existing ReplicationInstance resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetReplicationInstance(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ReplicationInstanceState, opts ...pulumi.ResourceOption) (*ReplicationInstance, error) {
	var resource ReplicationInstance
	err := ctx.ReadResource("aws:dms/replicationInstance:ReplicationInstance", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ReplicationInstance resources.
type replicationInstanceState struct {
	// The amount of storage (in gigabytes) to be initially allocated for the replication instance.
	AllocatedStorage *int `pulumi:"allocatedStorage"`
	// Indicates whether the changes should be applied immediately or during the next maintenance window. Only used when updating an existing resource.
	ApplyImmediately *bool `pulumi:"applyImmediately"`
	// Indicates that minor engine upgrades will be applied automatically to the replication instance during the maintenance window.
	AutoMinorVersionUpgrade *bool `pulumi:"autoMinorVersionUpgrade"`
	// The EC2 Availability Zone that the replication instance will be created in.
	AvailabilityZone *string `pulumi:"availabilityZone"`
	// The engine version number of the replication instance.
	EngineVersion *string `pulumi:"engineVersion"`
	// The Amazon Resource Name (ARN) for the KMS key that will be used to encrypt the connection parameters. If you do not specify a value for `kmsKeyArn`, then AWS DMS will use your default encryption key. AWS KMS creates the default encryption key for your AWS account. Your AWS account has a different default encryption key for each AWS region.
	KmsKeyArn *string `pulumi:"kmsKeyArn"`
	// Specifies if the replication instance is a multi-az deployment. You cannot set the `availabilityZone` parameter if the `multiAz` parameter is set to `true`.
	MultiAz *bool `pulumi:"multiAz"`
	// The weekly time range during which system maintenance can occur, in Universal Coordinated Time (UTC).
	PreferredMaintenanceWindow *string `pulumi:"preferredMaintenanceWindow"`
	// Specifies the accessibility options for the replication instance. A value of true represents an instance with a public IP address. A value of false represents an instance with a private IP address.
	PubliclyAccessible *bool `pulumi:"publiclyAccessible"`
	// The Amazon Resource Name (ARN) of the replication instance.
	ReplicationInstanceArn *string `pulumi:"replicationInstanceArn"`
	// The compute and memory capacity of the replication instance as specified by the replication instance class. Can be one of `dms.t2.micro | dms.t2.small | dms.t2.medium | dms.t2.large | dms.c4.large | dms.c4.xlarge | dms.c4.2xlarge | dms.c4.4xlarge`
	ReplicationInstanceClass *string `pulumi:"replicationInstanceClass"`
	// The replication instance identifier. This parameter is stored as a lowercase string.
	ReplicationInstanceId *string `pulumi:"replicationInstanceId"`
	// A list of the private IP addresses of the replication instance.
	ReplicationInstancePrivateIps []string `pulumi:"replicationInstancePrivateIps"`
	// A list of the public IP addresses of the replication instance.
	ReplicationInstancePublicIps []string `pulumi:"replicationInstancePublicIps"`
	// A subnet group to associate with the replication instance.
	ReplicationSubnetGroupId *string `pulumi:"replicationSubnetGroupId"`
	// A map of tags to assign to the resource.
	Tags map[string]string `pulumi:"tags"`
	// A list of VPC security group IDs to be used with the replication instance. The VPC security groups must work with the VPC containing the replication instance.
	VpcSecurityGroupIds []string `pulumi:"vpcSecurityGroupIds"`
}

type ReplicationInstanceState struct {
	// The amount of storage (in gigabytes) to be initially allocated for the replication instance.
	AllocatedStorage pulumi.IntPtrInput
	// Indicates whether the changes should be applied immediately or during the next maintenance window. Only used when updating an existing resource.
	ApplyImmediately pulumi.BoolPtrInput
	// Indicates that minor engine upgrades will be applied automatically to the replication instance during the maintenance window.
	AutoMinorVersionUpgrade pulumi.BoolPtrInput
	// The EC2 Availability Zone that the replication instance will be created in.
	AvailabilityZone pulumi.StringPtrInput
	// The engine version number of the replication instance.
	EngineVersion pulumi.StringPtrInput
	// The Amazon Resource Name (ARN) for the KMS key that will be used to encrypt the connection parameters. If you do not specify a value for `kmsKeyArn`, then AWS DMS will use your default encryption key. AWS KMS creates the default encryption key for your AWS account. Your AWS account has a different default encryption key for each AWS region.
	KmsKeyArn pulumi.StringPtrInput
	// Specifies if the replication instance is a multi-az deployment. You cannot set the `availabilityZone` parameter if the `multiAz` parameter is set to `true`.
	MultiAz pulumi.BoolPtrInput
	// The weekly time range during which system maintenance can occur, in Universal Coordinated Time (UTC).
	PreferredMaintenanceWindow pulumi.StringPtrInput
	// Specifies the accessibility options for the replication instance. A value of true represents an instance with a public IP address. A value of false represents an instance with a private IP address.
	PubliclyAccessible pulumi.BoolPtrInput
	// The Amazon Resource Name (ARN) of the replication instance.
	ReplicationInstanceArn pulumi.StringPtrInput
	// The compute and memory capacity of the replication instance as specified by the replication instance class. Can be one of `dms.t2.micro | dms.t2.small | dms.t2.medium | dms.t2.large | dms.c4.large | dms.c4.xlarge | dms.c4.2xlarge | dms.c4.4xlarge`
	ReplicationInstanceClass pulumi.StringPtrInput
	// The replication instance identifier. This parameter is stored as a lowercase string.
	ReplicationInstanceId pulumi.StringPtrInput
	// A list of the private IP addresses of the replication instance.
	ReplicationInstancePrivateIps pulumi.StringArrayInput
	// A list of the public IP addresses of the replication instance.
	ReplicationInstancePublicIps pulumi.StringArrayInput
	// A subnet group to associate with the replication instance.
	ReplicationSubnetGroupId pulumi.StringPtrInput
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapInput
	// A list of VPC security group IDs to be used with the replication instance. The VPC security groups must work with the VPC containing the replication instance.
	VpcSecurityGroupIds pulumi.StringArrayInput
}

func (ReplicationInstanceState) ElementType() reflect.Type {
	return reflect.TypeOf((*replicationInstanceState)(nil)).Elem()
}

type replicationInstanceArgs struct {
	// The amount of storage (in gigabytes) to be initially allocated for the replication instance.
	AllocatedStorage *int `pulumi:"allocatedStorage"`
	// Indicates whether the changes should be applied immediately or during the next maintenance window. Only used when updating an existing resource.
	ApplyImmediately *bool `pulumi:"applyImmediately"`
	// Indicates that minor engine upgrades will be applied automatically to the replication instance during the maintenance window.
	AutoMinorVersionUpgrade *bool `pulumi:"autoMinorVersionUpgrade"`
	// The EC2 Availability Zone that the replication instance will be created in.
	AvailabilityZone *string `pulumi:"availabilityZone"`
	// The engine version number of the replication instance.
	EngineVersion *string `pulumi:"engineVersion"`
	// The Amazon Resource Name (ARN) for the KMS key that will be used to encrypt the connection parameters. If you do not specify a value for `kmsKeyArn`, then AWS DMS will use your default encryption key. AWS KMS creates the default encryption key for your AWS account. Your AWS account has a different default encryption key for each AWS region.
	KmsKeyArn *string `pulumi:"kmsKeyArn"`
	// Specifies if the replication instance is a multi-az deployment. You cannot set the `availabilityZone` parameter if the `multiAz` parameter is set to `true`.
	MultiAz *bool `pulumi:"multiAz"`
	// The weekly time range during which system maintenance can occur, in Universal Coordinated Time (UTC).
	PreferredMaintenanceWindow *string `pulumi:"preferredMaintenanceWindow"`
	// Specifies the accessibility options for the replication instance. A value of true represents an instance with a public IP address. A value of false represents an instance with a private IP address.
	PubliclyAccessible *bool `pulumi:"publiclyAccessible"`
	// The compute and memory capacity of the replication instance as specified by the replication instance class. Can be one of `dms.t2.micro | dms.t2.small | dms.t2.medium | dms.t2.large | dms.c4.large | dms.c4.xlarge | dms.c4.2xlarge | dms.c4.4xlarge`
	ReplicationInstanceClass string `pulumi:"replicationInstanceClass"`
	// The replication instance identifier. This parameter is stored as a lowercase string.
	ReplicationInstanceId string `pulumi:"replicationInstanceId"`
	// A subnet group to associate with the replication instance.
	ReplicationSubnetGroupId *string `pulumi:"replicationSubnetGroupId"`
	// A map of tags to assign to the resource.
	Tags map[string]string `pulumi:"tags"`
	// A list of VPC security group IDs to be used with the replication instance. The VPC security groups must work with the VPC containing the replication instance.
	VpcSecurityGroupIds []string `pulumi:"vpcSecurityGroupIds"`
}

// The set of arguments for constructing a ReplicationInstance resource.
type ReplicationInstanceArgs struct {
	// The amount of storage (in gigabytes) to be initially allocated for the replication instance.
	AllocatedStorage pulumi.IntPtrInput
	// Indicates whether the changes should be applied immediately or during the next maintenance window. Only used when updating an existing resource.
	ApplyImmediately pulumi.BoolPtrInput
	// Indicates that minor engine upgrades will be applied automatically to the replication instance during the maintenance window.
	AutoMinorVersionUpgrade pulumi.BoolPtrInput
	// The EC2 Availability Zone that the replication instance will be created in.
	AvailabilityZone pulumi.StringPtrInput
	// The engine version number of the replication instance.
	EngineVersion pulumi.StringPtrInput
	// The Amazon Resource Name (ARN) for the KMS key that will be used to encrypt the connection parameters. If you do not specify a value for `kmsKeyArn`, then AWS DMS will use your default encryption key. AWS KMS creates the default encryption key for your AWS account. Your AWS account has a different default encryption key for each AWS region.
	KmsKeyArn pulumi.StringPtrInput
	// Specifies if the replication instance is a multi-az deployment. You cannot set the `availabilityZone` parameter if the `multiAz` parameter is set to `true`.
	MultiAz pulumi.BoolPtrInput
	// The weekly time range during which system maintenance can occur, in Universal Coordinated Time (UTC).
	PreferredMaintenanceWindow pulumi.StringPtrInput
	// Specifies the accessibility options for the replication instance. A value of true represents an instance with a public IP address. A value of false represents an instance with a private IP address.
	PubliclyAccessible pulumi.BoolPtrInput
	// The compute and memory capacity of the replication instance as specified by the replication instance class. Can be one of `dms.t2.micro | dms.t2.small | dms.t2.medium | dms.t2.large | dms.c4.large | dms.c4.xlarge | dms.c4.2xlarge | dms.c4.4xlarge`
	ReplicationInstanceClass pulumi.StringInput
	// The replication instance identifier. This parameter is stored as a lowercase string.
	ReplicationInstanceId pulumi.StringInput
	// A subnet group to associate with the replication instance.
	ReplicationSubnetGroupId pulumi.StringPtrInput
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapInput
	// A list of VPC security group IDs to be used with the replication instance. The VPC security groups must work with the VPC containing the replication instance.
	VpcSecurityGroupIds pulumi.StringArrayInput
}

func (ReplicationInstanceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*replicationInstanceArgs)(nil)).Elem()
}
