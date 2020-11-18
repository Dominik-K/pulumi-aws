// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a DMS (Data Migration Service) replication instance resource. DMS replication instances can be created, updated, deleted, and imported.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 *
 * const dmsAssumeRole = aws.iam.getPolicyDocument({
 *     statements: [{
 *         actions: ["sts:AssumeRole"],
 *         principals: [{
 *             identifiers: ["dms.amazonaws.com"],
 *             type: "Service",
 *         }],
 *     }],
 * });
 * const dms_access_for_endpoint = new aws.iam.Role("dms-access-for-endpoint", {assumeRolePolicy: dmsAssumeRole.then(dmsAssumeRole => dmsAssumeRole.json)});
 * const dms_access_for_endpoint_AmazonDMSRedshiftS3Role = new aws.iam.RolePolicyAttachment("dms-access-for-endpoint-AmazonDMSRedshiftS3Role", {
 *     policyArn: "arn:aws:iam::aws:policy/service-role/AmazonDMSRedshiftS3Role",
 *     role: dms_access_for_endpoint.name,
 * });
 * const dms_cloudwatch_logs_role = new aws.iam.Role("dms-cloudwatch-logs-role", {assumeRolePolicy: dmsAssumeRole.then(dmsAssumeRole => dmsAssumeRole.json)});
 * const dms_cloudwatch_logs_role_AmazonDMSCloudWatchLogsRole = new aws.iam.RolePolicyAttachment("dms-cloudwatch-logs-role-AmazonDMSCloudWatchLogsRole", {
 *     policyArn: "arn:aws:iam::aws:policy/service-role/AmazonDMSCloudWatchLogsRole",
 *     role: dms_cloudwatch_logs_role.name,
 * });
 * const dms_vpc_role = new aws.iam.Role("dms-vpc-role", {assumeRolePolicy: dmsAssumeRole.then(dmsAssumeRole => dmsAssumeRole.json)});
 * const dms_vpc_role_AmazonDMSVPCManagementRole = new aws.iam.RolePolicyAttachment("dms-vpc-role-AmazonDMSVPCManagementRole", {
 *     policyArn: "arn:aws:iam::aws:policy/service-role/AmazonDMSVPCManagementRole",
 *     role: dms_vpc_role.name,
 * });
 * // Create a new replication instance
 * const test = new aws.dms.ReplicationInstance("test", {
 *     allocatedStorage: 20,
 *     applyImmediately: true,
 *     autoMinorVersionUpgrade: true,
 *     availabilityZone: "us-west-2c",
 *     engineVersion: "3.1.4",
 *     kmsKeyArn: "arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012",
 *     multiAz: false,
 *     preferredMaintenanceWindow: "sun:10:30-sun:14:30",
 *     publiclyAccessible: true,
 *     replicationInstanceClass: "dms.t2.micro",
 *     replicationInstanceId: "test-dms-replication-instance-tf",
 *     replicationSubnetGroupId: aws_dms_replication_subnet_group["test-dms-replication-subnet-group-tf"].id,
 *     tags: {
 *         Name: "test",
 *     },
 *     vpcSecurityGroupIds: ["sg-12345678"],
 * });
 * ```
 */
export class ReplicationInstance extends pulumi.CustomResource {
    /**
     * Get an existing ReplicationInstance resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ReplicationInstanceState, opts?: pulumi.CustomResourceOptions): ReplicationInstance {
        return new ReplicationInstance(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws:dms/replicationInstance:ReplicationInstance';

    /**
     * Returns true if the given object is an instance of ReplicationInstance.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ReplicationInstance {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ReplicationInstance.__pulumiType;
    }

    /**
     * The amount of storage (in gigabytes) to be initially allocated for the replication instance.
     */
    public readonly allocatedStorage!: pulumi.Output<number>;
    /**
     * Indicates that major version upgrades are allowed.
     */
    public readonly allowMajorVersionUpgrade!: pulumi.Output<boolean | undefined>;
    /**
     * Indicates whether the changes should be applied immediately or during the next maintenance window. Only used when updating an existing resource.
     */
    public readonly applyImmediately!: pulumi.Output<boolean | undefined>;
    /**
     * Indicates that minor engine upgrades will be applied automatically to the replication instance during the maintenance window.
     */
    public readonly autoMinorVersionUpgrade!: pulumi.Output<boolean>;
    /**
     * The EC2 Availability Zone that the replication instance will be created in.
     */
    public readonly availabilityZone!: pulumi.Output<string>;
    /**
     * The engine version number of the replication instance.
     */
    public readonly engineVersion!: pulumi.Output<string>;
    /**
     * The Amazon Resource Name (ARN) for the KMS key that will be used to encrypt the connection parameters. If you do not specify a value for `kmsKeyArn`, then AWS DMS will use your default encryption key. AWS KMS creates the default encryption key for your AWS account. Your AWS account has a different default encryption key for each AWS region.
     */
    public readonly kmsKeyArn!: pulumi.Output<string>;
    /**
     * Specifies if the replication instance is a multi-az deployment. You cannot set the `availabilityZone` parameter if the `multiAz` parameter is set to `true`.
     */
    public readonly multiAz!: pulumi.Output<boolean>;
    /**
     * The weekly time range during which system maintenance can occur, in Universal Coordinated Time (UTC).
     */
    public readonly preferredMaintenanceWindow!: pulumi.Output<string>;
    /**
     * Specifies the accessibility options for the replication instance. A value of true represents an instance with a public IP address. A value of false represents an instance with a private IP address.
     */
    public readonly publiclyAccessible!: pulumi.Output<boolean>;
    /**
     * The Amazon Resource Name (ARN) of the replication instance.
     */
    public /*out*/ readonly replicationInstanceArn!: pulumi.Output<string>;
    /**
     * The compute and memory capacity of the replication instance as specified by the replication instance class. Can be one of `dms.t2.micro | dms.t2.small | dms.t2.medium | dms.t2.large | dms.c4.large | dms.c4.xlarge | dms.c4.2xlarge | dms.c4.4xlarge`
     */
    public readonly replicationInstanceClass!: pulumi.Output<string>;
    /**
     * The replication instance identifier. This parameter is stored as a lowercase string.
     */
    public readonly replicationInstanceId!: pulumi.Output<string>;
    /**
     * A list of the private IP addresses of the replication instance.
     */
    public /*out*/ readonly replicationInstancePrivateIps!: pulumi.Output<string[]>;
    /**
     * A list of the public IP addresses of the replication instance.
     */
    public /*out*/ readonly replicationInstancePublicIps!: pulumi.Output<string[]>;
    /**
     * A subnet group to associate with the replication instance.
     */
    public readonly replicationSubnetGroupId!: pulumi.Output<string>;
    /**
     * A map of tags to assign to the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * A list of VPC security group IDs to be used with the replication instance. The VPC security groups must work with the VPC containing the replication instance.
     */
    public readonly vpcSecurityGroupIds!: pulumi.Output<string[]>;

    /**
     * Create a ReplicationInstance resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ReplicationInstanceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ReplicationInstanceArgs | ReplicationInstanceState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as ReplicationInstanceState | undefined;
            inputs["allocatedStorage"] = state ? state.allocatedStorage : undefined;
            inputs["allowMajorVersionUpgrade"] = state ? state.allowMajorVersionUpgrade : undefined;
            inputs["applyImmediately"] = state ? state.applyImmediately : undefined;
            inputs["autoMinorVersionUpgrade"] = state ? state.autoMinorVersionUpgrade : undefined;
            inputs["availabilityZone"] = state ? state.availabilityZone : undefined;
            inputs["engineVersion"] = state ? state.engineVersion : undefined;
            inputs["kmsKeyArn"] = state ? state.kmsKeyArn : undefined;
            inputs["multiAz"] = state ? state.multiAz : undefined;
            inputs["preferredMaintenanceWindow"] = state ? state.preferredMaintenanceWindow : undefined;
            inputs["publiclyAccessible"] = state ? state.publiclyAccessible : undefined;
            inputs["replicationInstanceArn"] = state ? state.replicationInstanceArn : undefined;
            inputs["replicationInstanceClass"] = state ? state.replicationInstanceClass : undefined;
            inputs["replicationInstanceId"] = state ? state.replicationInstanceId : undefined;
            inputs["replicationInstancePrivateIps"] = state ? state.replicationInstancePrivateIps : undefined;
            inputs["replicationInstancePublicIps"] = state ? state.replicationInstancePublicIps : undefined;
            inputs["replicationSubnetGroupId"] = state ? state.replicationSubnetGroupId : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["vpcSecurityGroupIds"] = state ? state.vpcSecurityGroupIds : undefined;
        } else {
            const args = argsOrState as ReplicationInstanceArgs | undefined;
            if (!args || args.replicationInstanceClass === undefined) {
                throw new Error("Missing required property 'replicationInstanceClass'");
            }
            if (!args || args.replicationInstanceId === undefined) {
                throw new Error("Missing required property 'replicationInstanceId'");
            }
            inputs["allocatedStorage"] = args ? args.allocatedStorage : undefined;
            inputs["allowMajorVersionUpgrade"] = args ? args.allowMajorVersionUpgrade : undefined;
            inputs["applyImmediately"] = args ? args.applyImmediately : undefined;
            inputs["autoMinorVersionUpgrade"] = args ? args.autoMinorVersionUpgrade : undefined;
            inputs["availabilityZone"] = args ? args.availabilityZone : undefined;
            inputs["engineVersion"] = args ? args.engineVersion : undefined;
            inputs["kmsKeyArn"] = args ? args.kmsKeyArn : undefined;
            inputs["multiAz"] = args ? args.multiAz : undefined;
            inputs["preferredMaintenanceWindow"] = args ? args.preferredMaintenanceWindow : undefined;
            inputs["publiclyAccessible"] = args ? args.publiclyAccessible : undefined;
            inputs["replicationInstanceClass"] = args ? args.replicationInstanceClass : undefined;
            inputs["replicationInstanceId"] = args ? args.replicationInstanceId : undefined;
            inputs["replicationSubnetGroupId"] = args ? args.replicationSubnetGroupId : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["vpcSecurityGroupIds"] = args ? args.vpcSecurityGroupIds : undefined;
            inputs["replicationInstanceArn"] = undefined /*out*/;
            inputs["replicationInstancePrivateIps"] = undefined /*out*/;
            inputs["replicationInstancePublicIps"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(ReplicationInstance.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ReplicationInstance resources.
 */
export interface ReplicationInstanceState {
    /**
     * The amount of storage (in gigabytes) to be initially allocated for the replication instance.
     */
    readonly allocatedStorage?: pulumi.Input<number>;
    /**
     * Indicates that major version upgrades are allowed.
     */
    readonly allowMajorVersionUpgrade?: pulumi.Input<boolean>;
    /**
     * Indicates whether the changes should be applied immediately or during the next maintenance window. Only used when updating an existing resource.
     */
    readonly applyImmediately?: pulumi.Input<boolean>;
    /**
     * Indicates that minor engine upgrades will be applied automatically to the replication instance during the maintenance window.
     */
    readonly autoMinorVersionUpgrade?: pulumi.Input<boolean>;
    /**
     * The EC2 Availability Zone that the replication instance will be created in.
     */
    readonly availabilityZone?: pulumi.Input<string>;
    /**
     * The engine version number of the replication instance.
     */
    readonly engineVersion?: pulumi.Input<string>;
    /**
     * The Amazon Resource Name (ARN) for the KMS key that will be used to encrypt the connection parameters. If you do not specify a value for `kmsKeyArn`, then AWS DMS will use your default encryption key. AWS KMS creates the default encryption key for your AWS account. Your AWS account has a different default encryption key for each AWS region.
     */
    readonly kmsKeyArn?: pulumi.Input<string>;
    /**
     * Specifies if the replication instance is a multi-az deployment. You cannot set the `availabilityZone` parameter if the `multiAz` parameter is set to `true`.
     */
    readonly multiAz?: pulumi.Input<boolean>;
    /**
     * The weekly time range during which system maintenance can occur, in Universal Coordinated Time (UTC).
     */
    readonly preferredMaintenanceWindow?: pulumi.Input<string>;
    /**
     * Specifies the accessibility options for the replication instance. A value of true represents an instance with a public IP address. A value of false represents an instance with a private IP address.
     */
    readonly publiclyAccessible?: pulumi.Input<boolean>;
    /**
     * The Amazon Resource Name (ARN) of the replication instance.
     */
    readonly replicationInstanceArn?: pulumi.Input<string>;
    /**
     * The compute and memory capacity of the replication instance as specified by the replication instance class. Can be one of `dms.t2.micro | dms.t2.small | dms.t2.medium | dms.t2.large | dms.c4.large | dms.c4.xlarge | dms.c4.2xlarge | dms.c4.4xlarge`
     */
    readonly replicationInstanceClass?: pulumi.Input<string>;
    /**
     * The replication instance identifier. This parameter is stored as a lowercase string.
     */
    readonly replicationInstanceId?: pulumi.Input<string>;
    /**
     * A list of the private IP addresses of the replication instance.
     */
    readonly replicationInstancePrivateIps?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A list of the public IP addresses of the replication instance.
     */
    readonly replicationInstancePublicIps?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A subnet group to associate with the replication instance.
     */
    readonly replicationSubnetGroupId?: pulumi.Input<string>;
    /**
     * A map of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * A list of VPC security group IDs to be used with the replication instance. The VPC security groups must work with the VPC containing the replication instance.
     */
    readonly vpcSecurityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * The set of arguments for constructing a ReplicationInstance resource.
 */
export interface ReplicationInstanceArgs {
    /**
     * The amount of storage (in gigabytes) to be initially allocated for the replication instance.
     */
    readonly allocatedStorage?: pulumi.Input<number>;
    /**
     * Indicates that major version upgrades are allowed.
     */
    readonly allowMajorVersionUpgrade?: pulumi.Input<boolean>;
    /**
     * Indicates whether the changes should be applied immediately or during the next maintenance window. Only used when updating an existing resource.
     */
    readonly applyImmediately?: pulumi.Input<boolean>;
    /**
     * Indicates that minor engine upgrades will be applied automatically to the replication instance during the maintenance window.
     */
    readonly autoMinorVersionUpgrade?: pulumi.Input<boolean>;
    /**
     * The EC2 Availability Zone that the replication instance will be created in.
     */
    readonly availabilityZone?: pulumi.Input<string>;
    /**
     * The engine version number of the replication instance.
     */
    readonly engineVersion?: pulumi.Input<string>;
    /**
     * The Amazon Resource Name (ARN) for the KMS key that will be used to encrypt the connection parameters. If you do not specify a value for `kmsKeyArn`, then AWS DMS will use your default encryption key. AWS KMS creates the default encryption key for your AWS account. Your AWS account has a different default encryption key for each AWS region.
     */
    readonly kmsKeyArn?: pulumi.Input<string>;
    /**
     * Specifies if the replication instance is a multi-az deployment. You cannot set the `availabilityZone` parameter if the `multiAz` parameter is set to `true`.
     */
    readonly multiAz?: pulumi.Input<boolean>;
    /**
     * The weekly time range during which system maintenance can occur, in Universal Coordinated Time (UTC).
     */
    readonly preferredMaintenanceWindow?: pulumi.Input<string>;
    /**
     * Specifies the accessibility options for the replication instance. A value of true represents an instance with a public IP address. A value of false represents an instance with a private IP address.
     */
    readonly publiclyAccessible?: pulumi.Input<boolean>;
    /**
     * The compute and memory capacity of the replication instance as specified by the replication instance class. Can be one of `dms.t2.micro | dms.t2.small | dms.t2.medium | dms.t2.large | dms.c4.large | dms.c4.xlarge | dms.c4.2xlarge | dms.c4.4xlarge`
     */
    readonly replicationInstanceClass: pulumi.Input<string>;
    /**
     * The replication instance identifier. This parameter is stored as a lowercase string.
     */
    readonly replicationInstanceId: pulumi.Input<string>;
    /**
     * A subnet group to associate with the replication instance.
     */
    readonly replicationSubnetGroupId?: pulumi.Input<string>;
    /**
     * A map of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * A list of VPC security group IDs to be used with the replication instance. The VPC security groups must work with the VPC containing the replication instance.
     */
    readonly vpcSecurityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
}
