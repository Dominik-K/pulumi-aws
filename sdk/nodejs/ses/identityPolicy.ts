// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Manages a SES Identity Policy. More information about SES Sending Authorization Policies can be found in the [SES Developer Guide](https://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization-policies.html).
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 *
 * const exampleDomainIdentity = new aws.ses.DomainIdentity("example", {
 *     domain: "example.com",
 * });
 * const examplePolicyDocument = exampleDomainIdentity.arn.apply(arn => aws.iam.getPolicyDocument({
 *     statements: [{
 *         actions: [
 *             "SES:SendEmail",
 *             "SES:SendRawEmail",
 *         ],
 *         principals: [{
 *             identifiers: ["*"],
 *             type: "AWS",
 *         }],
 *         resources: [arn],
 *     }],
 * }));
 * const exampleIdentityPolicy = new aws.ses.IdentityPolicy("example", {
 *     identity: exampleDomainIdentity.arn,
 *     policy: examplePolicyDocument.json,
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/ses_identity_policy.html.markdown.
 */
export class IdentityPolicy extends pulumi.CustomResource {
    /**
     * Get an existing IdentityPolicy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: IdentityPolicyState, opts?: pulumi.CustomResourceOptions): IdentityPolicy {
        return new IdentityPolicy(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws:ses/identityPolicy:IdentityPolicy';

    /**
     * Returns true if the given object is an instance of IdentityPolicy.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is IdentityPolicy {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === IdentityPolicy.__pulumiType;
    }

    /**
     * Name or Amazon Resource Name (ARN) of the SES Identity.
     */
    public readonly identity!: pulumi.Output<string>;
    /**
     * Name of the policy.
     */
    public readonly name!: pulumi.Output<string>;
    public readonly policy!: pulumi.Output<string>;

    /**
     * Create a IdentityPolicy resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: IdentityPolicyArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: IdentityPolicyArgs | IdentityPolicyState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as IdentityPolicyState | undefined;
            inputs["identity"] = state ? state.identity : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["policy"] = state ? state.policy : undefined;
        } else {
            const args = argsOrState as IdentityPolicyArgs | undefined;
            if (!args || args.identity === undefined) {
                throw new Error("Missing required property 'identity'");
            }
            if (!args || args.policy === undefined) {
                throw new Error("Missing required property 'policy'");
            }
            inputs["identity"] = args ? args.identity : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["policy"] = args ? args.policy : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(IdentityPolicy.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering IdentityPolicy resources.
 */
export interface IdentityPolicyState {
    /**
     * Name or Amazon Resource Name (ARN) of the SES Identity.
     */
    readonly identity?: pulumi.Input<string>;
    /**
     * Name of the policy.
     */
    readonly name?: pulumi.Input<string>;
    readonly policy?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a IdentityPolicy resource.
 */
export interface IdentityPolicyArgs {
    /**
     * Name or Amazon Resource Name (ARN) of the SES Identity.
     */
    readonly identity: pulumi.Input<string>;
    /**
     * Name of the policy.
     */
    readonly name?: pulumi.Input<string>;
    readonly policy: pulumi.Input<string>;
}
