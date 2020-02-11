// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to get the ARN of a certificate in AWS Certificate
 * Manager (ACM), you can reference
 * it by domain without having to hard code the ARNs as input.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 *
 * // Find a RSA 4096 bit certificate
 * const example = aws.acm.getCertificate({
 *     domain: "tf.example.com",
 *     keyTypes: ["RSA_4096"],
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/acm_certificate.html.markdown.
 */
export function getCertificate(args: GetCertificateArgs, opts?: pulumi.InvokeOptions): Promise<GetCertificateResult> & GetCertificateResult {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    const promise: Promise<GetCertificateResult> = pulumi.runtime.invoke("aws:acm/getCertificate:getCertificate", {
        "domain": args.domain,
        "keyTypes": args.keyTypes,
        "mostRecent": args.mostRecent,
        "statuses": args.statuses,
        "types": args.types,
    }, opts);

    return pulumi.utils.liftProperties(promise, opts);
}

/**
 * A collection of arguments for invoking getCertificate.
 */
export interface GetCertificateArgs {
    /**
     * The domain of the certificate to look up. If no certificate is found with this name, an error will be returned.
     */
    readonly domain: string;
    /**
     * A list of key algorithms to filter certificates. By default, ACM does not return all certificate types when searching. Valid values are `RSA_1024`, `RSA_2048`, `RSA_4096`, `EC_prime256v1`, `EC_secp384r1`, and `EC_secp521r1`.
     */
    readonly keyTypes?: string[];
    /**
     * If set to true, it sorts the certificates matched by previous criteria by the NotBefore field, returning only the most recent one. If set to false, it returns an error if more than one certificate is found. Defaults to false.
     */
    readonly mostRecent?: boolean;
    /**
     * A list of statuses on which to filter the returned list. Valid values are `PENDING_VALIDATION`, `ISSUED`,
     * `INACTIVE`, `EXPIRED`, `VALIDATION_TIMED_OUT`, `REVOKED` and `FAILED`. If no value is specified, only certificates in the `ISSUED` state
     * are returned.
     */
    readonly statuses?: string[];
    /**
     * A list of types on which to filter the returned list. Valid values are `AMAZON_ISSUED` and `IMPORTED`.
     */
    readonly types?: string[];
}

/**
 * A collection of values returned by getCertificate.
 */
export interface GetCertificateResult {
    /**
     * Set to the ARN of the found certificate, suitable for referencing in other resources that support ACM certificates.
     */
    readonly arn: string;
    readonly domain: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly keyTypes?: string[];
    readonly mostRecent?: boolean;
    readonly statuses?: string[];
    readonly types?: string[];
}
