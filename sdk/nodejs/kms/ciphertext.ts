// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * The KMS ciphertext resource allows you to encrypt plaintext into ciphertext
 * by using an AWS KMS customer master key. The value returned by this resource
 * is stable across every apply. For a changing ciphertext value each apply, see
 * the [`aws.kms.Ciphertext` data source](https://www.terraform.io/docs/providers/aws/d/kms_ciphertext.html).
 *
 * > **Note:** All arguments including the plaintext be stored in the raw state as plain-text.
 * [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 *
 * const oauthConfig = new aws.kms.Key("oauthConfig", {
 *     description: "oauth config",
 *     isEnabled: true,
 * });
 * const oauth = new aws.kms.Ciphertext("oauth", {
 *     keyId: oauthConfig.keyId,
 *     plaintext: `{
 *   "clientId": "e587dbae22222f55da22",
 *   "clientSecret": "8289575d00000ace55e1815ec13673955721b8a5"
 * }
 * `,
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/kms_ciphertext.html.markdown.
 */
export class Ciphertext extends pulumi.CustomResource {
    /**
     * Get an existing Ciphertext resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CiphertextState, opts?: pulumi.CustomResourceOptions): Ciphertext {
        return new Ciphertext(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws:kms/ciphertext:Ciphertext';

    /**
     * Returns true if the given object is an instance of Ciphertext.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Ciphertext {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Ciphertext.__pulumiType;
    }

    /**
     * Base64 encoded ciphertext
     */
    public /*out*/ readonly ciphertextBlob!: pulumi.Output<string>;
    /**
     * An optional mapping that makes up the encryption context.
     */
    public readonly context!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Globally unique key ID for the customer master key.
     */
    public readonly keyId!: pulumi.Output<string>;
    /**
     * Data to be encrypted. Note that this may show up in logs, and it will be stored in the state file.
     */
    public readonly plaintext!: pulumi.Output<string>;

    /**
     * Create a Ciphertext resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CiphertextArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CiphertextArgs | CiphertextState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as CiphertextState | undefined;
            inputs["ciphertextBlob"] = state ? state.ciphertextBlob : undefined;
            inputs["context"] = state ? state.context : undefined;
            inputs["keyId"] = state ? state.keyId : undefined;
            inputs["plaintext"] = state ? state.plaintext : undefined;
        } else {
            const args = argsOrState as CiphertextArgs | undefined;
            if (!args || args.keyId === undefined) {
                throw new Error("Missing required property 'keyId'");
            }
            if (!args || args.plaintext === undefined) {
                throw new Error("Missing required property 'plaintext'");
            }
            inputs["context"] = args ? args.context : undefined;
            inputs["keyId"] = args ? args.keyId : undefined;
            inputs["plaintext"] = args ? args.plaintext : undefined;
            inputs["ciphertextBlob"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Ciphertext.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Ciphertext resources.
 */
export interface CiphertextState {
    /**
     * Base64 encoded ciphertext
     */
    readonly ciphertextBlob?: pulumi.Input<string>;
    /**
     * An optional mapping that makes up the encryption context.
     */
    readonly context?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Globally unique key ID for the customer master key.
     */
    readonly keyId?: pulumi.Input<string>;
    /**
     * Data to be encrypted. Note that this may show up in logs, and it will be stored in the state file.
     */
    readonly plaintext?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Ciphertext resource.
 */
export interface CiphertextArgs {
    /**
     * An optional mapping that makes up the encryption context.
     */
    readonly context?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Globally unique key ID for the customer master key.
     */
    readonly keyId: pulumi.Input<string>;
    /**
     * Data to be encrypted. Note that this may show up in logs, and it will be stored in the state file.
     */
    readonly plaintext: pulumi.Input<string>;
}
