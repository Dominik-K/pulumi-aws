// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a Direct Connect Gateway.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 *
 * const example = new aws.directconnect.Gateway("example", {
 *     amazonSideAsn: "64512",
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/dx_gateway.html.markdown.
 */
export class Gateway extends pulumi.CustomResource {
    /**
     * Get an existing Gateway resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: GatewayState, opts?: pulumi.CustomResourceOptions): Gateway {
        return new Gateway(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws:directconnect/gateway:Gateway';

    /**
     * Returns true if the given object is an instance of Gateway.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Gateway {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Gateway.__pulumiType;
    }

    /**
     * The ASN to be configured on the Amazon side of the connection. The ASN must be in the private range of 64,512 to 65,534 or 4,200,000,000 to 4,294,967,294.
     */
    public readonly amazonSideAsn!: pulumi.Output<string>;
    /**
     * The name of the connection.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * AWS Account ID of the gateway.
     */
    public /*out*/ readonly ownerAccountId!: pulumi.Output<string>;

    /**
     * Create a Gateway resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: GatewayArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: GatewayArgs | GatewayState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as GatewayState | undefined;
            inputs["amazonSideAsn"] = state ? state.amazonSideAsn : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["ownerAccountId"] = state ? state.ownerAccountId : undefined;
        } else {
            const args = argsOrState as GatewayArgs | undefined;
            if (!args || args.amazonSideAsn === undefined) {
                throw new Error("Missing required property 'amazonSideAsn'");
            }
            inputs["amazonSideAsn"] = args ? args.amazonSideAsn : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["ownerAccountId"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Gateway.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Gateway resources.
 */
export interface GatewayState {
    /**
     * The ASN to be configured on the Amazon side of the connection. The ASN must be in the private range of 64,512 to 65,534 or 4,200,000,000 to 4,294,967,294.
     */
    readonly amazonSideAsn?: pulumi.Input<string>;
    /**
     * The name of the connection.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * AWS Account ID of the gateway.
     */
    readonly ownerAccountId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Gateway resource.
 */
export interface GatewayArgs {
    /**
     * The ASN to be configured on the Amazon side of the connection. The ASN must be in the private range of 64,512 to 65,534 or 4,200,000,000 to 4,294,967,294.
     */
    readonly amazonSideAsn: pulumi.Input<string>;
    /**
     * The name of the connection.
     */
    readonly name?: pulumi.Input<string>;
}
