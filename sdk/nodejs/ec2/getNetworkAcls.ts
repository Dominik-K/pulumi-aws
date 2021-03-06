// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * ## Example Usage
 * 
 * 
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const exampleNetworkAcls = aws.ec2.getNetworkAcls({
 *     vpcId: var_vpc_id,
 * });
 * 
 * export const example = exampleNetworkAcls.ids;
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/network_acls.html.markdown.
 */
export function getNetworkAcls(args?: GetNetworkAclsArgs, opts?: pulumi.InvokeOptions): Promise<GetNetworkAclsResult> & GetNetworkAclsResult {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    const promise: Promise<GetNetworkAclsResult> = pulumi.runtime.invoke("aws:ec2/getNetworkAcls:getNetworkAcls", {
        "filters": args.filters,
        "tags": args.tags,
        "vpcId": args.vpcId,
    }, opts);

    return pulumi.utils.liftProperties(promise, opts);
}

/**
 * A collection of arguments for invoking getNetworkAcls.
 */
export interface GetNetworkAclsArgs {
    /**
     * Custom filter block as described below.
     */
    readonly filters?: inputs.ec2.GetNetworkAclsFilter[];
    /**
     * A mapping of tags, each pair of which must exactly match
     * a pair on the desired network ACLs.
     */
    readonly tags?: {[key: string]: any};
    /**
     * The VPC ID that you want to filter from.
     */
    readonly vpcId?: string;
}

/**
 * A collection of values returned by getNetworkAcls.
 */
export interface GetNetworkAclsResult {
    readonly filters?: outputs.ec2.GetNetworkAclsFilter[];
    /**
     * A list of all the network ACL ids found. This data source will fail if none are found.
     */
    readonly ids: string[];
    readonly tags: {[key: string]: any};
    readonly vpcId?: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
