// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Manages a FSx Lustre File System. See the [FSx Lustre Guide](https://docs.aws.amazon.com/fsx/latest/LustreGuide/what-is.html) for more information.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 *
 * const example = new aws.fsx.LustreFileSystem("example", {
 *     importPath: `s3://${aws_s3_bucket.example.bucket}`,
 *     storageCapacity: 1200,
 *     subnetIds: [aws_subnet.example.id],
 * });
 * ```
 */
export class LustreFileSystem extends pulumi.CustomResource {
    /**
     * Get an existing LustreFileSystem resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: LustreFileSystemState, opts?: pulumi.CustomResourceOptions): LustreFileSystem {
        return new LustreFileSystem(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws:fsx/lustreFileSystem:LustreFileSystem';

    /**
     * Returns true if the given object is an instance of LustreFileSystem.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is LustreFileSystem {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === LustreFileSystem.__pulumiType;
    }

    /**
     * Amazon Resource Name of the file system.
     */
    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * How Amazon FSx keeps your file and directory listings up to date as you add or modify objects in your linked S3 bucket. see [Auto Import Data Repo](https://docs.aws.amazon.com/fsx/latest/LustreGuide/autoimport-data-repo.html) for more details.
     */
    public readonly autoImportPolicy!: pulumi.Output<string>;
    /**
     * The number of days to retain automatic backups. Setting this to 0 disables automatic backups. You can retain automatic backups for a maximum of 35 days. only valid for `PERSISTENT_1` deployment_type.
     */
    public readonly automaticBackupRetentionDays!: pulumi.Output<number>;
    /**
     * A recurring daily time, in the format HH:MM. HH is the zero-padded hour of the day (0-23), and MM is the zero-padded minute of the hour. For example, 05:00 specifies 5 AM daily. only valid for `PERSISTENT_1` deployment_type. Requires `automaticBackupRetentionDays` to be set.
     */
    public readonly dailyAutomaticBackupStartTime!: pulumi.Output<string>;
    /**
     * - The filesystem deployment type. One of: `SCRATCH_1`, `SCRATCH_2`, `PERSISTENT_1`.
     */
    public readonly deploymentType!: pulumi.Output<string | undefined>;
    /**
     * DNS name for the file system, e.g. `fs-12345678.fsx.us-west-2.amazonaws.com`
     */
    public /*out*/ readonly dnsName!: pulumi.Output<string>;
    /**
     * - The type of drive cache used by `PERSISTENT_1` filesystems that are provisioned with `HDD` storage_type. Required for `HDD` storage_type, set to either `READ` or `NONE`.
     */
    public readonly driveCacheType!: pulumi.Output<string | undefined>;
    /**
     * S3 URI (with optional prefix) where the root of your Amazon FSx file system is exported. Can only be specified with `importPath` argument and the path must use the same Amazon S3 bucket as specified in `importPath`. Set equal to `importPath` to overwrite files on export. Defaults to `s3://{IMPORT BUCKET}/FSxLustre{CREATION TIMESTAMP}`.
     */
    public readonly exportPath!: pulumi.Output<string>;
    /**
     * S3 URI (with optional prefix) that you're using as the data repository for your FSx for Lustre file system. For example, `s3://example-bucket/optional-prefix/`.
     */
    public readonly importPath!: pulumi.Output<string | undefined>;
    /**
     * For files imported from a data repository, this value determines the stripe count and maximum amount of data per file (in MiB) stored on a single physical disk. Can only be specified with `importPath` argument. Defaults to `1024`. Minimum of `1` and maximum of `512000`.
     */
    public readonly importedFileChunkSize!: pulumi.Output<number>;
    /**
     * ARN for the KMS Key to encrypt the file system at rest, applicable for `PERSISTENT_1`. Defaults to an AWS managed KMS Key.
     */
    public readonly kmsKeyId!: pulumi.Output<string>;
    /**
     * The value to be used when mounting the filesystem.
     */
    public /*out*/ readonly mountName!: pulumi.Output<string>;
    /**
     * Set of Elastic Network Interface identifiers from which the file system is accessible. As explained in the [documentation](https://docs.aws.amazon.com/fsx/latest/LustreGuide/mounting-on-premises.html), the first network interface returned is the primary network interface.
     */
    public /*out*/ readonly networkInterfaceIds!: pulumi.Output<string[]>;
    /**
     * AWS account identifier that created the file system.
     */
    public /*out*/ readonly ownerId!: pulumi.Output<string>;
    /**
     * - Describes the amount of read and write throughput for each 1 tebibyte of storage, in MB/s/TiB, required for the `PERSISTENT_1` deployment_type. Valid values for `SSD` storageType are 50, 100, 200. Valid values for `HDD` storageType are 12, 40.
     */
    public readonly perUnitStorageThroughput!: pulumi.Output<number | undefined>;
    /**
     * A list of IDs for the security groups that apply to the specified network interfaces created for file system access. These security groups will apply to all network interfaces.
     */
    public readonly securityGroupIds!: pulumi.Output<string[] | undefined>;
    /**
     * The storage capacity (GiB) of the file system. Minimum of `1200`. Storage capacity is provisioned in increments of 3,600 GiB.
     */
    public readonly storageCapacity!: pulumi.Output<number>;
    /**
     * - The filesystem storage type. Either `SSD` or `HDD`, defaults to `SSD`. `HDD` is only supported on `PERSISTENT_1` deployment types.
     */
    public readonly storageType!: pulumi.Output<string | undefined>;
    /**
     * A list of IDs for the subnets that the file system will be accessible from. File systems currently support only one subnet. The file server is also launched in that subnet's Availability Zone.
     */
    public readonly subnetIds!: pulumi.Output<string>;
    /**
     * A map of tags to assign to the file system.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Identifier of the Virtual Private Cloud for the file system.
     */
    public /*out*/ readonly vpcId!: pulumi.Output<string>;
    /**
     * The preferred start time (in `d:HH:MM` format) to perform weekly maintenance, in the UTC time zone.
     */
    public readonly weeklyMaintenanceStartTime!: pulumi.Output<string>;

    /**
     * Create a LustreFileSystem resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LustreFileSystemArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: LustreFileSystemArgs | LustreFileSystemState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as LustreFileSystemState | undefined;
            inputs["arn"] = state ? state.arn : undefined;
            inputs["autoImportPolicy"] = state ? state.autoImportPolicy : undefined;
            inputs["automaticBackupRetentionDays"] = state ? state.automaticBackupRetentionDays : undefined;
            inputs["dailyAutomaticBackupStartTime"] = state ? state.dailyAutomaticBackupStartTime : undefined;
            inputs["deploymentType"] = state ? state.deploymentType : undefined;
            inputs["dnsName"] = state ? state.dnsName : undefined;
            inputs["driveCacheType"] = state ? state.driveCacheType : undefined;
            inputs["exportPath"] = state ? state.exportPath : undefined;
            inputs["importPath"] = state ? state.importPath : undefined;
            inputs["importedFileChunkSize"] = state ? state.importedFileChunkSize : undefined;
            inputs["kmsKeyId"] = state ? state.kmsKeyId : undefined;
            inputs["mountName"] = state ? state.mountName : undefined;
            inputs["networkInterfaceIds"] = state ? state.networkInterfaceIds : undefined;
            inputs["ownerId"] = state ? state.ownerId : undefined;
            inputs["perUnitStorageThroughput"] = state ? state.perUnitStorageThroughput : undefined;
            inputs["securityGroupIds"] = state ? state.securityGroupIds : undefined;
            inputs["storageCapacity"] = state ? state.storageCapacity : undefined;
            inputs["storageType"] = state ? state.storageType : undefined;
            inputs["subnetIds"] = state ? state.subnetIds : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["vpcId"] = state ? state.vpcId : undefined;
            inputs["weeklyMaintenanceStartTime"] = state ? state.weeklyMaintenanceStartTime : undefined;
        } else {
            const args = argsOrState as LustreFileSystemArgs | undefined;
            if (!args || args.storageCapacity === undefined) {
                throw new Error("Missing required property 'storageCapacity'");
            }
            if (!args || args.subnetIds === undefined) {
                throw new Error("Missing required property 'subnetIds'");
            }
            inputs["autoImportPolicy"] = args ? args.autoImportPolicy : undefined;
            inputs["automaticBackupRetentionDays"] = args ? args.automaticBackupRetentionDays : undefined;
            inputs["dailyAutomaticBackupStartTime"] = args ? args.dailyAutomaticBackupStartTime : undefined;
            inputs["deploymentType"] = args ? args.deploymentType : undefined;
            inputs["driveCacheType"] = args ? args.driveCacheType : undefined;
            inputs["exportPath"] = args ? args.exportPath : undefined;
            inputs["importPath"] = args ? args.importPath : undefined;
            inputs["importedFileChunkSize"] = args ? args.importedFileChunkSize : undefined;
            inputs["kmsKeyId"] = args ? args.kmsKeyId : undefined;
            inputs["perUnitStorageThroughput"] = args ? args.perUnitStorageThroughput : undefined;
            inputs["securityGroupIds"] = args ? args.securityGroupIds : undefined;
            inputs["storageCapacity"] = args ? args.storageCapacity : undefined;
            inputs["storageType"] = args ? args.storageType : undefined;
            inputs["subnetIds"] = args ? args.subnetIds : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["weeklyMaintenanceStartTime"] = args ? args.weeklyMaintenanceStartTime : undefined;
            inputs["arn"] = undefined /*out*/;
            inputs["dnsName"] = undefined /*out*/;
            inputs["mountName"] = undefined /*out*/;
            inputs["networkInterfaceIds"] = undefined /*out*/;
            inputs["ownerId"] = undefined /*out*/;
            inputs["vpcId"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(LustreFileSystem.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering LustreFileSystem resources.
 */
export interface LustreFileSystemState {
    /**
     * Amazon Resource Name of the file system.
     */
    readonly arn?: pulumi.Input<string>;
    /**
     * How Amazon FSx keeps your file and directory listings up to date as you add or modify objects in your linked S3 bucket. see [Auto Import Data Repo](https://docs.aws.amazon.com/fsx/latest/LustreGuide/autoimport-data-repo.html) for more details.
     */
    readonly autoImportPolicy?: pulumi.Input<string>;
    /**
     * The number of days to retain automatic backups. Setting this to 0 disables automatic backups. You can retain automatic backups for a maximum of 35 days. only valid for `PERSISTENT_1` deployment_type.
     */
    readonly automaticBackupRetentionDays?: pulumi.Input<number>;
    /**
     * A recurring daily time, in the format HH:MM. HH is the zero-padded hour of the day (0-23), and MM is the zero-padded minute of the hour. For example, 05:00 specifies 5 AM daily. only valid for `PERSISTENT_1` deployment_type. Requires `automaticBackupRetentionDays` to be set.
     */
    readonly dailyAutomaticBackupStartTime?: pulumi.Input<string>;
    /**
     * - The filesystem deployment type. One of: `SCRATCH_1`, `SCRATCH_2`, `PERSISTENT_1`.
     */
    readonly deploymentType?: pulumi.Input<string>;
    /**
     * DNS name for the file system, e.g. `fs-12345678.fsx.us-west-2.amazonaws.com`
     */
    readonly dnsName?: pulumi.Input<string>;
    /**
     * - The type of drive cache used by `PERSISTENT_1` filesystems that are provisioned with `HDD` storage_type. Required for `HDD` storage_type, set to either `READ` or `NONE`.
     */
    readonly driveCacheType?: pulumi.Input<string>;
    /**
     * S3 URI (with optional prefix) where the root of your Amazon FSx file system is exported. Can only be specified with `importPath` argument and the path must use the same Amazon S3 bucket as specified in `importPath`. Set equal to `importPath` to overwrite files on export. Defaults to `s3://{IMPORT BUCKET}/FSxLustre{CREATION TIMESTAMP}`.
     */
    readonly exportPath?: pulumi.Input<string>;
    /**
     * S3 URI (with optional prefix) that you're using as the data repository for your FSx for Lustre file system. For example, `s3://example-bucket/optional-prefix/`.
     */
    readonly importPath?: pulumi.Input<string>;
    /**
     * For files imported from a data repository, this value determines the stripe count and maximum amount of data per file (in MiB) stored on a single physical disk. Can only be specified with `importPath` argument. Defaults to `1024`. Minimum of `1` and maximum of `512000`.
     */
    readonly importedFileChunkSize?: pulumi.Input<number>;
    /**
     * ARN for the KMS Key to encrypt the file system at rest, applicable for `PERSISTENT_1`. Defaults to an AWS managed KMS Key.
     */
    readonly kmsKeyId?: pulumi.Input<string>;
    /**
     * The value to be used when mounting the filesystem.
     */
    readonly mountName?: pulumi.Input<string>;
    /**
     * Set of Elastic Network Interface identifiers from which the file system is accessible. As explained in the [documentation](https://docs.aws.amazon.com/fsx/latest/LustreGuide/mounting-on-premises.html), the first network interface returned is the primary network interface.
     */
    readonly networkInterfaceIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * AWS account identifier that created the file system.
     */
    readonly ownerId?: pulumi.Input<string>;
    /**
     * - Describes the amount of read and write throughput for each 1 tebibyte of storage, in MB/s/TiB, required for the `PERSISTENT_1` deployment_type. Valid values for `SSD` storageType are 50, 100, 200. Valid values for `HDD` storageType are 12, 40.
     */
    readonly perUnitStorageThroughput?: pulumi.Input<number>;
    /**
     * A list of IDs for the security groups that apply to the specified network interfaces created for file system access. These security groups will apply to all network interfaces.
     */
    readonly securityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The storage capacity (GiB) of the file system. Minimum of `1200`. Storage capacity is provisioned in increments of 3,600 GiB.
     */
    readonly storageCapacity?: pulumi.Input<number>;
    /**
     * - The filesystem storage type. Either `SSD` or `HDD`, defaults to `SSD`. `HDD` is only supported on `PERSISTENT_1` deployment types.
     */
    readonly storageType?: pulumi.Input<string>;
    /**
     * A list of IDs for the subnets that the file system will be accessible from. File systems currently support only one subnet. The file server is also launched in that subnet's Availability Zone.
     */
    readonly subnetIds?: pulumi.Input<string>;
    /**
     * A map of tags to assign to the file system.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Identifier of the Virtual Private Cloud for the file system.
     */
    readonly vpcId?: pulumi.Input<string>;
    /**
     * The preferred start time (in `d:HH:MM` format) to perform weekly maintenance, in the UTC time zone.
     */
    readonly weeklyMaintenanceStartTime?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a LustreFileSystem resource.
 */
export interface LustreFileSystemArgs {
    /**
     * How Amazon FSx keeps your file and directory listings up to date as you add or modify objects in your linked S3 bucket. see [Auto Import Data Repo](https://docs.aws.amazon.com/fsx/latest/LustreGuide/autoimport-data-repo.html) for more details.
     */
    readonly autoImportPolicy?: pulumi.Input<string>;
    /**
     * The number of days to retain automatic backups. Setting this to 0 disables automatic backups. You can retain automatic backups for a maximum of 35 days. only valid for `PERSISTENT_1` deployment_type.
     */
    readonly automaticBackupRetentionDays?: pulumi.Input<number>;
    /**
     * A recurring daily time, in the format HH:MM. HH is the zero-padded hour of the day (0-23), and MM is the zero-padded minute of the hour. For example, 05:00 specifies 5 AM daily. only valid for `PERSISTENT_1` deployment_type. Requires `automaticBackupRetentionDays` to be set.
     */
    readonly dailyAutomaticBackupStartTime?: pulumi.Input<string>;
    /**
     * - The filesystem deployment type. One of: `SCRATCH_1`, `SCRATCH_2`, `PERSISTENT_1`.
     */
    readonly deploymentType?: pulumi.Input<string>;
    /**
     * - The type of drive cache used by `PERSISTENT_1` filesystems that are provisioned with `HDD` storage_type. Required for `HDD` storage_type, set to either `READ` or `NONE`.
     */
    readonly driveCacheType?: pulumi.Input<string>;
    /**
     * S3 URI (with optional prefix) where the root of your Amazon FSx file system is exported. Can only be specified with `importPath` argument and the path must use the same Amazon S3 bucket as specified in `importPath`. Set equal to `importPath` to overwrite files on export. Defaults to `s3://{IMPORT BUCKET}/FSxLustre{CREATION TIMESTAMP}`.
     */
    readonly exportPath?: pulumi.Input<string>;
    /**
     * S3 URI (with optional prefix) that you're using as the data repository for your FSx for Lustre file system. For example, `s3://example-bucket/optional-prefix/`.
     */
    readonly importPath?: pulumi.Input<string>;
    /**
     * For files imported from a data repository, this value determines the stripe count and maximum amount of data per file (in MiB) stored on a single physical disk. Can only be specified with `importPath` argument. Defaults to `1024`. Minimum of `1` and maximum of `512000`.
     */
    readonly importedFileChunkSize?: pulumi.Input<number>;
    /**
     * ARN for the KMS Key to encrypt the file system at rest, applicable for `PERSISTENT_1`. Defaults to an AWS managed KMS Key.
     */
    readonly kmsKeyId?: pulumi.Input<string>;
    /**
     * - Describes the amount of read and write throughput for each 1 tebibyte of storage, in MB/s/TiB, required for the `PERSISTENT_1` deployment_type. Valid values for `SSD` storageType are 50, 100, 200. Valid values for `HDD` storageType are 12, 40.
     */
    readonly perUnitStorageThroughput?: pulumi.Input<number>;
    /**
     * A list of IDs for the security groups that apply to the specified network interfaces created for file system access. These security groups will apply to all network interfaces.
     */
    readonly securityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The storage capacity (GiB) of the file system. Minimum of `1200`. Storage capacity is provisioned in increments of 3,600 GiB.
     */
    readonly storageCapacity: pulumi.Input<number>;
    /**
     * - The filesystem storage type. Either `SSD` or `HDD`, defaults to `SSD`. `HDD` is only supported on `PERSISTENT_1` deployment types.
     */
    readonly storageType?: pulumi.Input<string>;
    /**
     * A list of IDs for the subnets that the file system will be accessible from. File systems currently support only one subnet. The file server is also launched in that subnet's Availability Zone.
     */
    readonly subnetIds: pulumi.Input<string>;
    /**
     * A map of tags to assign to the file system.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The preferred start time (in `d:HH:MM` format) to perform weekly maintenance, in the UTC time zone.
     */
    readonly weeklyMaintenanceStartTime?: pulumi.Input<string>;
}
