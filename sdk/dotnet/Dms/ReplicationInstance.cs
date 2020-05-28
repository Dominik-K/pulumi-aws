// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Dms
{
    /// <summary>
    /// Provides a DMS (Data Migration Service) replication instance resource. DMS replication instances can be created, updated, deleted, and imported.
    /// 
    /// ## Example Usage
    /// 
    /// 
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var dmsAssumeRole = Output.Create(Aws.Iam.GetPolicyDocument.InvokeAsync(new Aws.Iam.GetPolicyDocumentArgs
    ///         {
    ///             Statements = 
    ///             {
    ///                 new Aws.Iam.Inputs.GetPolicyDocumentStatementArgs
    ///                 {
    ///                     Actions = 
    ///                     {
    ///                         "sts:AssumeRole",
    ///                     },
    ///                     Principals = 
    ///                     {
    ///                         new Aws.Iam.Inputs.GetPolicyDocumentStatementPrincipalArgs
    ///                         {
    ///                             Identifiers = 
    ///                             {
    ///                                 "dms.amazonaws.com",
    ///                             },
    ///                             Type = "Service",
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///         }));
    ///         var dms_access_for_endpoint = new Aws.Iam.Role("dms-access-for-endpoint", new Aws.Iam.RoleArgs
    ///         {
    ///             AssumeRolePolicy = dmsAssumeRole.Apply(dmsAssumeRole =&gt; dmsAssumeRole.Json),
    ///         });
    ///         var dms_access_for_endpoint_AmazonDMSRedshiftS3Role = new Aws.Iam.RolePolicyAttachment("dms-access-for-endpoint-AmazonDMSRedshiftS3Role", new Aws.Iam.RolePolicyAttachmentArgs
    ///         {
    ///             PolicyArn = "arn:aws:iam::aws:policy/service-role/AmazonDMSRedshiftS3Role",
    ///             Role = dms_access_for_endpoint.Name,
    ///         });
    ///         var dms_cloudwatch_logs_role = new Aws.Iam.Role("dms-cloudwatch-logs-role", new Aws.Iam.RoleArgs
    ///         {
    ///             AssumeRolePolicy = dmsAssumeRole.Apply(dmsAssumeRole =&gt; dmsAssumeRole.Json),
    ///         });
    ///         var dms_cloudwatch_logs_role_AmazonDMSCloudWatchLogsRole = new Aws.Iam.RolePolicyAttachment("dms-cloudwatch-logs-role-AmazonDMSCloudWatchLogsRole", new Aws.Iam.RolePolicyAttachmentArgs
    ///         {
    ///             PolicyArn = "arn:aws:iam::aws:policy/service-role/AmazonDMSCloudWatchLogsRole",
    ///             Role = dms_cloudwatch_logs_role.Name,
    ///         });
    ///         var dms_vpc_role = new Aws.Iam.Role("dms-vpc-role", new Aws.Iam.RoleArgs
    ///         {
    ///             AssumeRolePolicy = dmsAssumeRole.Apply(dmsAssumeRole =&gt; dmsAssumeRole.Json),
    ///         });
    ///         var dms_vpc_role_AmazonDMSVPCManagementRole = new Aws.Iam.RolePolicyAttachment("dms-vpc-role-AmazonDMSVPCManagementRole", new Aws.Iam.RolePolicyAttachmentArgs
    ///         {
    ///             PolicyArn = "arn:aws:iam::aws:policy/service-role/AmazonDMSVPCManagementRole",
    ///             Role = dms_vpc_role.Name,
    ///         });
    ///         // Create a new replication instance
    ///         var test = new Aws.Dms.ReplicationInstance("test", new Aws.Dms.ReplicationInstanceArgs
    ///         {
    ///             AllocatedStorage = 20,
    ///             ApplyImmediately = true,
    ///             AutoMinorVersionUpgrade = true,
    ///             AvailabilityZone = "us-west-2c",
    ///             EngineVersion = "3.1.4",
    ///             KmsKeyArn = "arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012",
    ///             MultiAz = false,
    ///             PreferredMaintenanceWindow = "sun:10:30-sun:14:30",
    ///             PubliclyAccessible = true,
    ///             ReplicationInstanceClass = "dms.t2.micro",
    ///             ReplicationInstanceId = "test-dms-replication-instance-tf",
    ///             ReplicationSubnetGroupId = aws_dms_replication_subnet_group.Test_dms_replication_subnet_group_tf.Id,
    ///             Tags = 
    ///             {
    ///                 { "Name", "test" },
    ///             },
    ///             VpcSecurityGroupIds = 
    ///             {
    ///                 "sg-12345678",
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class ReplicationInstance : Pulumi.CustomResource
    {
        /// <summary>
        /// The amount of storage (in gigabytes) to be initially allocated for the replication instance.
        /// </summary>
        [Output("allocatedStorage")]
        public Output<int> AllocatedStorage { get; private set; } = null!;

        /// <summary>
        /// Indicates whether the changes should be applied immediately or during the next maintenance window. Only used when updating an existing resource.
        /// </summary>
        [Output("applyImmediately")]
        public Output<bool?> ApplyImmediately { get; private set; } = null!;

        /// <summary>
        /// Indicates that minor engine upgrades will be applied automatically to the replication instance during the maintenance window.
        /// </summary>
        [Output("autoMinorVersionUpgrade")]
        public Output<bool> AutoMinorVersionUpgrade { get; private set; } = null!;

        /// <summary>
        /// The EC2 Availability Zone that the replication instance will be created in.
        /// </summary>
        [Output("availabilityZone")]
        public Output<string> AvailabilityZone { get; private set; } = null!;

        /// <summary>
        /// The engine version number of the replication instance.
        /// </summary>
        [Output("engineVersion")]
        public Output<string> EngineVersion { get; private set; } = null!;

        /// <summary>
        /// The Amazon Resource Name (ARN) for the KMS key that will be used to encrypt the connection parameters. If you do not specify a value for `kms_key_arn`, then AWS DMS will use your default encryption key. AWS KMS creates the default encryption key for your AWS account. Your AWS account has a different default encryption key for each AWS region.
        /// </summary>
        [Output("kmsKeyArn")]
        public Output<string> KmsKeyArn { get; private set; } = null!;

        /// <summary>
        /// Specifies if the replication instance is a multi-az deployment. You cannot set the `availability_zone` parameter if the `multi_az` parameter is set to `true`.
        /// </summary>
        [Output("multiAz")]
        public Output<bool> MultiAz { get; private set; } = null!;

        /// <summary>
        /// The weekly time range during which system maintenance can occur, in Universal Coordinated Time (UTC).
        /// </summary>
        [Output("preferredMaintenanceWindow")]
        public Output<string> PreferredMaintenanceWindow { get; private set; } = null!;

        /// <summary>
        /// Specifies the accessibility options for the replication instance. A value of true represents an instance with a public IP address. A value of false represents an instance with a private IP address.
        /// </summary>
        [Output("publiclyAccessible")]
        public Output<bool> PubliclyAccessible { get; private set; } = null!;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the replication instance.
        /// </summary>
        [Output("replicationInstanceArn")]
        public Output<string> ReplicationInstanceArn { get; private set; } = null!;

        /// <summary>
        /// The compute and memory capacity of the replication instance as specified by the replication instance class. Can be one of `dms.t2.micro | dms.t2.small | dms.t2.medium | dms.t2.large | dms.c4.large | dms.c4.xlarge | dms.c4.2xlarge | dms.c4.4xlarge`
        /// </summary>
        [Output("replicationInstanceClass")]
        public Output<string> ReplicationInstanceClass { get; private set; } = null!;

        /// <summary>
        /// The replication instance identifier. This parameter is stored as a lowercase string.
        /// </summary>
        [Output("replicationInstanceId")]
        public Output<string> ReplicationInstanceId { get; private set; } = null!;

        /// <summary>
        /// A list of the private IP addresses of the replication instance.
        /// </summary>
        [Output("replicationInstancePrivateIps")]
        public Output<ImmutableArray<string>> ReplicationInstancePrivateIps { get; private set; } = null!;

        /// <summary>
        /// A list of the public IP addresses of the replication instance.
        /// </summary>
        [Output("replicationInstancePublicIps")]
        public Output<ImmutableArray<string>> ReplicationInstancePublicIps { get; private set; } = null!;

        /// <summary>
        /// A subnet group to associate with the replication instance.
        /// </summary>
        [Output("replicationSubnetGroupId")]
        public Output<string> ReplicationSubnetGroupId { get; private set; } = null!;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;

        /// <summary>
        /// A list of VPC security group IDs to be used with the replication instance. The VPC security groups must work with the VPC containing the replication instance.
        /// </summary>
        [Output("vpcSecurityGroupIds")]
        public Output<ImmutableArray<string>> VpcSecurityGroupIds { get; private set; } = null!;


        /// <summary>
        /// Create a ReplicationInstance resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ReplicationInstance(string name, ReplicationInstanceArgs args, CustomResourceOptions? options = null)
            : base("aws:dms/replicationInstance:ReplicationInstance", name, args ?? new ReplicationInstanceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ReplicationInstance(string name, Input<string> id, ReplicationInstanceState? state = null, CustomResourceOptions? options = null)
            : base("aws:dms/replicationInstance:ReplicationInstance", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ReplicationInstance resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ReplicationInstance Get(string name, Input<string> id, ReplicationInstanceState? state = null, CustomResourceOptions? options = null)
        {
            return new ReplicationInstance(name, id, state, options);
        }
    }

    public sealed class ReplicationInstanceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The amount of storage (in gigabytes) to be initially allocated for the replication instance.
        /// </summary>
        [Input("allocatedStorage")]
        public Input<int>? AllocatedStorage { get; set; }

        /// <summary>
        /// Indicates whether the changes should be applied immediately or during the next maintenance window. Only used when updating an existing resource.
        /// </summary>
        [Input("applyImmediately")]
        public Input<bool>? ApplyImmediately { get; set; }

        /// <summary>
        /// Indicates that minor engine upgrades will be applied automatically to the replication instance during the maintenance window.
        /// </summary>
        [Input("autoMinorVersionUpgrade")]
        public Input<bool>? AutoMinorVersionUpgrade { get; set; }

        /// <summary>
        /// The EC2 Availability Zone that the replication instance will be created in.
        /// </summary>
        [Input("availabilityZone")]
        public Input<string>? AvailabilityZone { get; set; }

        /// <summary>
        /// The engine version number of the replication instance.
        /// </summary>
        [Input("engineVersion")]
        public Input<string>? EngineVersion { get; set; }

        /// <summary>
        /// The Amazon Resource Name (ARN) for the KMS key that will be used to encrypt the connection parameters. If you do not specify a value for `kms_key_arn`, then AWS DMS will use your default encryption key. AWS KMS creates the default encryption key for your AWS account. Your AWS account has a different default encryption key for each AWS region.
        /// </summary>
        [Input("kmsKeyArn")]
        public Input<string>? KmsKeyArn { get; set; }

        /// <summary>
        /// Specifies if the replication instance is a multi-az deployment. You cannot set the `availability_zone` parameter if the `multi_az` parameter is set to `true`.
        /// </summary>
        [Input("multiAz")]
        public Input<bool>? MultiAz { get; set; }

        /// <summary>
        /// The weekly time range during which system maintenance can occur, in Universal Coordinated Time (UTC).
        /// </summary>
        [Input("preferredMaintenanceWindow")]
        public Input<string>? PreferredMaintenanceWindow { get; set; }

        /// <summary>
        /// Specifies the accessibility options for the replication instance. A value of true represents an instance with a public IP address. A value of false represents an instance with a private IP address.
        /// </summary>
        [Input("publiclyAccessible")]
        public Input<bool>? PubliclyAccessible { get; set; }

        /// <summary>
        /// The compute and memory capacity of the replication instance as specified by the replication instance class. Can be one of `dms.t2.micro | dms.t2.small | dms.t2.medium | dms.t2.large | dms.c4.large | dms.c4.xlarge | dms.c4.2xlarge | dms.c4.4xlarge`
        /// </summary>
        [Input("replicationInstanceClass", required: true)]
        public Input<string> ReplicationInstanceClass { get; set; } = null!;

        /// <summary>
        /// The replication instance identifier. This parameter is stored as a lowercase string.
        /// </summary>
        [Input("replicationInstanceId", required: true)]
        public Input<string> ReplicationInstanceId { get; set; } = null!;

        /// <summary>
        /// A subnet group to associate with the replication instance.
        /// </summary>
        [Input("replicationSubnetGroupId")]
        public Input<string>? ReplicationSubnetGroupId { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        [Input("vpcSecurityGroupIds")]
        private InputList<string>? _vpcSecurityGroupIds;

        /// <summary>
        /// A list of VPC security group IDs to be used with the replication instance. The VPC security groups must work with the VPC containing the replication instance.
        /// </summary>
        public InputList<string> VpcSecurityGroupIds
        {
            get => _vpcSecurityGroupIds ?? (_vpcSecurityGroupIds = new InputList<string>());
            set => _vpcSecurityGroupIds = value;
        }

        public ReplicationInstanceArgs()
        {
        }
    }

    public sealed class ReplicationInstanceState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The amount of storage (in gigabytes) to be initially allocated for the replication instance.
        /// </summary>
        [Input("allocatedStorage")]
        public Input<int>? AllocatedStorage { get; set; }

        /// <summary>
        /// Indicates whether the changes should be applied immediately or during the next maintenance window. Only used when updating an existing resource.
        /// </summary>
        [Input("applyImmediately")]
        public Input<bool>? ApplyImmediately { get; set; }

        /// <summary>
        /// Indicates that minor engine upgrades will be applied automatically to the replication instance during the maintenance window.
        /// </summary>
        [Input("autoMinorVersionUpgrade")]
        public Input<bool>? AutoMinorVersionUpgrade { get; set; }

        /// <summary>
        /// The EC2 Availability Zone that the replication instance will be created in.
        /// </summary>
        [Input("availabilityZone")]
        public Input<string>? AvailabilityZone { get; set; }

        /// <summary>
        /// The engine version number of the replication instance.
        /// </summary>
        [Input("engineVersion")]
        public Input<string>? EngineVersion { get; set; }

        /// <summary>
        /// The Amazon Resource Name (ARN) for the KMS key that will be used to encrypt the connection parameters. If you do not specify a value for `kms_key_arn`, then AWS DMS will use your default encryption key. AWS KMS creates the default encryption key for your AWS account. Your AWS account has a different default encryption key for each AWS region.
        /// </summary>
        [Input("kmsKeyArn")]
        public Input<string>? KmsKeyArn { get; set; }

        /// <summary>
        /// Specifies if the replication instance is a multi-az deployment. You cannot set the `availability_zone` parameter if the `multi_az` parameter is set to `true`.
        /// </summary>
        [Input("multiAz")]
        public Input<bool>? MultiAz { get; set; }

        /// <summary>
        /// The weekly time range during which system maintenance can occur, in Universal Coordinated Time (UTC).
        /// </summary>
        [Input("preferredMaintenanceWindow")]
        public Input<string>? PreferredMaintenanceWindow { get; set; }

        /// <summary>
        /// Specifies the accessibility options for the replication instance. A value of true represents an instance with a public IP address. A value of false represents an instance with a private IP address.
        /// </summary>
        [Input("publiclyAccessible")]
        public Input<bool>? PubliclyAccessible { get; set; }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the replication instance.
        /// </summary>
        [Input("replicationInstanceArn")]
        public Input<string>? ReplicationInstanceArn { get; set; }

        /// <summary>
        /// The compute and memory capacity of the replication instance as specified by the replication instance class. Can be one of `dms.t2.micro | dms.t2.small | dms.t2.medium | dms.t2.large | dms.c4.large | dms.c4.xlarge | dms.c4.2xlarge | dms.c4.4xlarge`
        /// </summary>
        [Input("replicationInstanceClass")]
        public Input<string>? ReplicationInstanceClass { get; set; }

        /// <summary>
        /// The replication instance identifier. This parameter is stored as a lowercase string.
        /// </summary>
        [Input("replicationInstanceId")]
        public Input<string>? ReplicationInstanceId { get; set; }

        [Input("replicationInstancePrivateIps")]
        private InputList<string>? _replicationInstancePrivateIps;

        /// <summary>
        /// A list of the private IP addresses of the replication instance.
        /// </summary>
        public InputList<string> ReplicationInstancePrivateIps
        {
            get => _replicationInstancePrivateIps ?? (_replicationInstancePrivateIps = new InputList<string>());
            set => _replicationInstancePrivateIps = value;
        }

        [Input("replicationInstancePublicIps")]
        private InputList<string>? _replicationInstancePublicIps;

        /// <summary>
        /// A list of the public IP addresses of the replication instance.
        /// </summary>
        public InputList<string> ReplicationInstancePublicIps
        {
            get => _replicationInstancePublicIps ?? (_replicationInstancePublicIps = new InputList<string>());
            set => _replicationInstancePublicIps = value;
        }

        /// <summary>
        /// A subnet group to associate with the replication instance.
        /// </summary>
        [Input("replicationSubnetGroupId")]
        public Input<string>? ReplicationSubnetGroupId { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        [Input("vpcSecurityGroupIds")]
        private InputList<string>? _vpcSecurityGroupIds;

        /// <summary>
        /// A list of VPC security group IDs to be used with the replication instance. The VPC security groups must work with the VPC containing the replication instance.
        /// </summary>
        public InputList<string> VpcSecurityGroupIds
        {
            get => _vpcSecurityGroupIds ?? (_vpcSecurityGroupIds = new InputList<string>());
            set => _vpcSecurityGroupIds = value;
        }

        public ReplicationInstanceState()
        {
        }
    }
}
