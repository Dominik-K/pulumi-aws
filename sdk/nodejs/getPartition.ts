// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as enums from "./types/enums";
import * as utilities from "./utilities";

/**
 * Use this data source to lookup current AWS partition in which this provider is working
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 *
 * const current = pulumi.output(aws.getPartition({ async: true }));
 * const s3Policy = current.apply(current => aws.iam.getPolicyDocument({
 *     statements: [{
 *         actions: ["s3:ListBucket"],
 *         resources: [`arn:${current.partition}:s3:::my-bucket`],
 *         sid: "1",
 *     }],
 * }, { async: true }));
 * ```
 */
export function getPartition(opts?: pulumi.InvokeOptions): Promise<GetPartitionResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("aws:index/getPartition:getPartition", {
    }, opts);
}

/**
 * A collection of values returned by getPartition.
 */
export interface GetPartitionResult {
    /**
     * Base DNS domain name for the current partition (e.g. `amazonaws.com` in AWS Commercial, `amazonaws.com.cn` in AWS China).
     */
    readonly dnsSuffix: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Identifier of the current partition (e.g. `aws` in AWS Commercial, `aws-cn` in AWS China).
     */
    readonly partition: string;
}
