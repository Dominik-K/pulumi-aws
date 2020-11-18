// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Manages an AWS Storage Gateway Tape Pool.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 *
 * const example = new aws.storagegateway.TapePool("example", {
 *     poolName: "example",
 *     storageClass: "GLACIER",
 * });
 * ```
 */
export class TapePool extends pulumi.CustomResource {
    /**
     * Get an existing TapePool resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: TapePoolState, opts?: pulumi.CustomResourceOptions): TapePool {
        return new TapePool(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws:storagegateway/tapePool:TapePool';

    /**
     * Returns true if the given object is an instance of TapePool.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is TapePool {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === TapePool.__pulumiType;
    }

    /**
     * Volume Amazon Resource Name (ARN), e.g. `aws_storagegateway_tape_pool.example arn:aws:storagegateway:us-east-1:123456789012:tapepool/pool-12345678`.
     */
    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * The name of the new custom tape pool.
     */
    public readonly poolName!: pulumi.Output<string>;
    /**
     * Tape retention lock time is set in days. Tape retention lock can be enabled for up to 100 years (36,500 days). Default value is 0.
     */
    public readonly retentionLockTimeInDays!: pulumi.Output<number | undefined>;
    /**
     * Tape retention lock can be configured in two modes. When configured in governance mode, AWS accounts with specific IAM permissions are authorized to remove the tape retention lock from archived virtual tapes. When configured in compliance mode, the tape retention lock cannot be removed by any user, including the root AWS account. Possible values are `COMPLIANCE`, `GOVERNANCE`, and `NONE`. Default value is `NONE`.
     */
    public readonly retentionLockType!: pulumi.Output<string | undefined>;
    /**
     * The storage class that is associated with the new custom pool. When you use your backup application to eject the tape, the tape is archived directly into the storage class that corresponds to the pool. Possible values are `DEEP_ARCHIVE` or `GLACIER`.
     */
    public readonly storageClass!: pulumi.Output<string>;
    /**
     * Key-value map of resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;

    /**
     * Create a TapePool resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: TapePoolArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: TapePoolArgs | TapePoolState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as TapePoolState | undefined;
            inputs["arn"] = state ? state.arn : undefined;
            inputs["poolName"] = state ? state.poolName : undefined;
            inputs["retentionLockTimeInDays"] = state ? state.retentionLockTimeInDays : undefined;
            inputs["retentionLockType"] = state ? state.retentionLockType : undefined;
            inputs["storageClass"] = state ? state.storageClass : undefined;
            inputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as TapePoolArgs | undefined;
            if (!args || args.poolName === undefined) {
                throw new Error("Missing required property 'poolName'");
            }
            if (!args || args.storageClass === undefined) {
                throw new Error("Missing required property 'storageClass'");
            }
            inputs["poolName"] = args ? args.poolName : undefined;
            inputs["retentionLockTimeInDays"] = args ? args.retentionLockTimeInDays : undefined;
            inputs["retentionLockType"] = args ? args.retentionLockType : undefined;
            inputs["storageClass"] = args ? args.storageClass : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["arn"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(TapePool.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering TapePool resources.
 */
export interface TapePoolState {
    /**
     * Volume Amazon Resource Name (ARN), e.g. `aws_storagegateway_tape_pool.example arn:aws:storagegateway:us-east-1:123456789012:tapepool/pool-12345678`.
     */
    readonly arn?: pulumi.Input<string>;
    /**
     * The name of the new custom tape pool.
     */
    readonly poolName?: pulumi.Input<string>;
    /**
     * Tape retention lock time is set in days. Tape retention lock can be enabled for up to 100 years (36,500 days). Default value is 0.
     */
    readonly retentionLockTimeInDays?: pulumi.Input<number>;
    /**
     * Tape retention lock can be configured in two modes. When configured in governance mode, AWS accounts with specific IAM permissions are authorized to remove the tape retention lock from archived virtual tapes. When configured in compliance mode, the tape retention lock cannot be removed by any user, including the root AWS account. Possible values are `COMPLIANCE`, `GOVERNANCE`, and `NONE`. Default value is `NONE`.
     */
    readonly retentionLockType?: pulumi.Input<string>;
    /**
     * The storage class that is associated with the new custom pool. When you use your backup application to eject the tape, the tape is archived directly into the storage class that corresponds to the pool. Possible values are `DEEP_ARCHIVE` or `GLACIER`.
     */
    readonly storageClass?: pulumi.Input<string>;
    /**
     * Key-value map of resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}

/**
 * The set of arguments for constructing a TapePool resource.
 */
export interface TapePoolArgs {
    /**
     * The name of the new custom tape pool.
     */
    readonly poolName: pulumi.Input<string>;
    /**
     * Tape retention lock time is set in days. Tape retention lock can be enabled for up to 100 years (36,500 days). Default value is 0.
     */
    readonly retentionLockTimeInDays?: pulumi.Input<number>;
    /**
     * Tape retention lock can be configured in two modes. When configured in governance mode, AWS accounts with specific IAM permissions are authorized to remove the tape retention lock from archived virtual tapes. When configured in compliance mode, the tape retention lock cannot be removed by any user, including the root AWS account. Possible values are `COMPLIANCE`, `GOVERNANCE`, and `NONE`. Default value is `NONE`.
     */
    readonly retentionLockType?: pulumi.Input<string>;
    /**
     * The storage class that is associated with the new custom pool. When you use your backup application to eject the tape, the tape is archived directly into the storage class that corresponds to the pool. Possible values are `DEEP_ARCHIVE` or `GLACIER`.
     */
    readonly storageClass: pulumi.Input<string>;
    /**
     * Key-value map of resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
