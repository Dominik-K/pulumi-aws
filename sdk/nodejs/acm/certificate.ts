// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as enums from "../types/enums";
import * as utilities from "../utilities";

/**
 * The ACM certificate resource allows requesting and management of certificates
 * from the Amazon Certificate Manager.
 *
 * It deals with requesting certificates and managing their attributes and life-cycle.
 * This resource does not deal with validation of a certificate but can provide inputs
 * for other resources implementing the validation. It does not wait for a certificate to be issued.
 * Use a `aws.acm.CertificateValidation` resource for this.
 *
 * Most commonly, this resource is used together with `aws.route53.Record` and
 * `aws.acm.CertificateValidation` to request a DNS validated certificate,
 * deploy the required validation records and wait for validation to complete.
 *
 * Domain validation through E-Mail is also supported but should be avoided as it requires a manual step outside
 * of this provider.
 *
 * It's recommended to specify `createBeforeDestroy = true` in a [lifecycle](https://www.terraform.io/docs/configuration/resources.html#lifecycle) block to replace a certificate
 * which is currently in use (eg, by `aws.lb.Listener`).
 *
 * ## Example Usage
 * ### Certificate creation
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 *
 * const cert = new aws.acm.Certificate("cert", {
 *     domainName: "example.com",
 *     tags: {
 *         Environment: "test",
 *     },
 *     validationMethod: "DNS",
 * });
 * ```
 * ### Importing an existing certificate
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * import * as tls from "@pulumi/tls";
 *
 * const examplePrivateKey = new tls.PrivateKey("examplePrivateKey", {algorithm: "RSA"});
 * const exampleSelfSignedCert = new tls.SelfSignedCert("exampleSelfSignedCert", {
 *     keyAlgorithm: "RSA",
 *     privateKeyPem: examplePrivateKey.privateKeyPem,
 *     subjects: [{
 *         commonName: "example.com",
 *         organization: "ACME Examples, Inc",
 *     }],
 *     validityPeriodHours: 12,
 *     allowedUses: [
 *         "key_encipherment",
 *         "digital_signature",
 *         "server_auth",
 *     ],
 * });
 * const cert = new aws.acm.Certificate("cert", {
 *     privateKey: examplePrivateKey.privateKeyPem,
 *     certificateBody: exampleSelfSignedCert.certPem,
 * });
 * ```
 * ### Referencing domainValidationOptions With forEach Based Resources
 *
 * See the `aws.acm.CertificateValidation` resource for a full example of performing DNS validation.
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 *
 * const example: aws.route53.Record[];
 * for (const range of Object.entries(.reduce((__obj, dvo) => { ...__obj, [dvo.domainName]: {
 *     name: dvo.resourceRecordName,
 *     record: dvo.resourceRecordValue,
 *     type: dvo.resourceRecordType,
 * } })).map(([k, v]) => {key: k, value: v})) {
 *     example.push(new aws.route53.Record(`example-${range.key}`, {
 *         allowOverwrite: true,
 *         name: range.value.name,
 *         records: [range.value.record],
 *         ttl: 60,
 *         type: range.value.type,
 *         zoneId: aws_route53_zone.example.zone_id,
 *     }));
 * }
 * ```
 */
export class Certificate extends pulumi.CustomResource {
    /**
     * Get an existing Certificate resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CertificateState, opts?: pulumi.CustomResourceOptions): Certificate {
        return new Certificate(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws:acm/certificate:Certificate';

    /**
     * Returns true if the given object is an instance of Certificate.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Certificate {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Certificate.__pulumiType;
    }

    /**
     * The ARN of the certificate
     */
    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * ARN of an ACMPCA
     */
    public readonly certificateAuthorityArn!: pulumi.Output<string | undefined>;
    /**
     * The certificate's PEM-formatted public key
     */
    public readonly certificateBody!: pulumi.Output<string | undefined>;
    /**
     * The certificate's PEM-formatted chain
     * * Creating a private CA issued certificate
     */
    public readonly certificateChain!: pulumi.Output<string | undefined>;
    /**
     * A domain name for which the certificate should be issued
     */
    public readonly domainName!: pulumi.Output<string>;
    /**
     * Set of domain validation objects which can be used to complete certificate validation. Can have more than one element, e.g. if SANs are defined. Only set if `DNS`-validation was used.
     */
    public /*out*/ readonly domainValidationOptions!: pulumi.Output<outputs.acm.CertificateDomainValidationOption[]>;
    /**
     * Configuration block used to set certificate options. Detailed below.
     * * Importing an existing certificate
     */
    public readonly options!: pulumi.Output<outputs.acm.CertificateOptions | undefined>;
    /**
     * The certificate's PEM-formatted private key
     */
    public readonly privateKey!: pulumi.Output<string | undefined>;
    /**
     * Status of the certificate.
     */
    public /*out*/ readonly status!: pulumi.Output<string>;
    /**
     * Set of domains that should be SANs in the issued certificate. To remove all elements of a previously configured list, set this value equal to an empty list (`[]`) to trigger recreation.
     */
    public readonly subjectAlternativeNames!: pulumi.Output<string[]>;
    /**
     * A map of tags to assign to the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * A list of addresses that received a validation E-Mail. Only set if `EMAIL`-validation was used.
     */
    public /*out*/ readonly validationEmails!: pulumi.Output<string[]>;
    /**
     * Which method to use for validation. `DNS` or `EMAIL` are valid, `NONE` can be used for certificates that were imported into ACM and then into the provider.
     */
    public readonly validationMethod!: pulumi.Output<string>;

    /**
     * Create a Certificate resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: CertificateArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CertificateArgs | CertificateState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as CertificateState | undefined;
            inputs["arn"] = state ? state.arn : undefined;
            inputs["certificateAuthorityArn"] = state ? state.certificateAuthorityArn : undefined;
            inputs["certificateBody"] = state ? state.certificateBody : undefined;
            inputs["certificateChain"] = state ? state.certificateChain : undefined;
            inputs["domainName"] = state ? state.domainName : undefined;
            inputs["domainValidationOptions"] = state ? state.domainValidationOptions : undefined;
            inputs["options"] = state ? state.options : undefined;
            inputs["privateKey"] = state ? state.privateKey : undefined;
            inputs["status"] = state ? state.status : undefined;
            inputs["subjectAlternativeNames"] = state ? state.subjectAlternativeNames : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["validationEmails"] = state ? state.validationEmails : undefined;
            inputs["validationMethod"] = state ? state.validationMethod : undefined;
        } else {
            const args = argsOrState as CertificateArgs | undefined;
            inputs["certificateAuthorityArn"] = args ? args.certificateAuthorityArn : undefined;
            inputs["certificateBody"] = args ? args.certificateBody : undefined;
            inputs["certificateChain"] = args ? args.certificateChain : undefined;
            inputs["domainName"] = args ? args.domainName : undefined;
            inputs["options"] = args ? args.options : undefined;
            inputs["privateKey"] = args ? args.privateKey : undefined;
            inputs["subjectAlternativeNames"] = args ? args.subjectAlternativeNames : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["validationMethod"] = args ? args.validationMethod : undefined;
            inputs["arn"] = undefined /*out*/;
            inputs["domainValidationOptions"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["validationEmails"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Certificate.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Certificate resources.
 */
export interface CertificateState {
    /**
     * The ARN of the certificate
     */
    readonly arn?: pulumi.Input<string>;
    /**
     * ARN of an ACMPCA
     */
    readonly certificateAuthorityArn?: pulumi.Input<string>;
    /**
     * The certificate's PEM-formatted public key
     */
    readonly certificateBody?: pulumi.Input<string>;
    /**
     * The certificate's PEM-formatted chain
     * * Creating a private CA issued certificate
     */
    readonly certificateChain?: pulumi.Input<string>;
    /**
     * A domain name for which the certificate should be issued
     */
    readonly domainName?: pulumi.Input<string>;
    /**
     * Set of domain validation objects which can be used to complete certificate validation. Can have more than one element, e.g. if SANs are defined. Only set if `DNS`-validation was used.
     */
    readonly domainValidationOptions?: pulumi.Input<pulumi.Input<inputs.acm.CertificateDomainValidationOption>[]>;
    /**
     * Configuration block used to set certificate options. Detailed below.
     * * Importing an existing certificate
     */
    readonly options?: pulumi.Input<inputs.acm.CertificateOptions>;
    /**
     * The certificate's PEM-formatted private key
     */
    readonly privateKey?: pulumi.Input<string>;
    /**
     * Status of the certificate.
     */
    readonly status?: pulumi.Input<string>;
    /**
     * Set of domains that should be SANs in the issued certificate. To remove all elements of a previously configured list, set this value equal to an empty list (`[]`) to trigger recreation.
     */
    readonly subjectAlternativeNames?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A map of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * A list of addresses that received a validation E-Mail. Only set if `EMAIL`-validation was used.
     */
    readonly validationEmails?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Which method to use for validation. `DNS` or `EMAIL` are valid, `NONE` can be used for certificates that were imported into ACM and then into the provider.
     */
    readonly validationMethod?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Certificate resource.
 */
export interface CertificateArgs {
    /**
     * ARN of an ACMPCA
     */
    readonly certificateAuthorityArn?: pulumi.Input<string>;
    /**
     * The certificate's PEM-formatted public key
     */
    readonly certificateBody?: pulumi.Input<string>;
    /**
     * The certificate's PEM-formatted chain
     * * Creating a private CA issued certificate
     */
    readonly certificateChain?: pulumi.Input<string>;
    /**
     * A domain name for which the certificate should be issued
     */
    readonly domainName?: pulumi.Input<string>;
    /**
     * Configuration block used to set certificate options. Detailed below.
     * * Importing an existing certificate
     */
    readonly options?: pulumi.Input<inputs.acm.CertificateOptions>;
    /**
     * The certificate's PEM-formatted private key
     */
    readonly privateKey?: pulumi.Input<string>;
    /**
     * Set of domains that should be SANs in the issued certificate. To remove all elements of a previously configured list, set this value equal to an empty list (`[]`) to trigger recreation.
     */
    readonly subjectAlternativeNames?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A map of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Which method to use for validation. `DNS` or `EMAIL` are valid, `NONE` can be used for certificates that were imported into ACM and then into the provider.
     */
    readonly validationMethod?: pulumi.Input<string>;
}
