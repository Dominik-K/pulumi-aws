// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/cloudformation_stack_set_instance.html.markdown.
 */
export class StackSetInstance extends pulumi.CustomResource {
    /**
     * Get an existing StackSetInstance resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: StackSetInstanceState, opts?: pulumi.CustomResourceOptions): StackSetInstance {
        return new StackSetInstance(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws:cloudformation/stackSetInstance:StackSetInstance';

    /**
     * Returns true if the given object is an instance of StackSetInstance.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is StackSetInstance {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === StackSetInstance.__pulumiType;
    }

    /**
     * Target AWS Account ID to create a Stack based on the Stack Set. Defaults to current account.
     */
    public readonly accountId!: pulumi.Output<string>;
    /**
     * Key-value map of input parameters to override from the Stack Set for this Instance.
     */
    public readonly parameterOverrides!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Target AWS Region to create a Stack based on the Stack Set. Defaults to current region.
     */
    public readonly region!: pulumi.Output<string>;
    public readonly retainStack!: pulumi.Output<boolean | undefined>;
    /**
     * Stack identifier
     */
    public /*out*/ readonly stackId!: pulumi.Output<string>;
    /**
     * Name of the Stack Set.
     */
    public readonly stackSetName!: pulumi.Output<string>;

    /**
     * Create a StackSetInstance resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: StackSetInstanceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: StackSetInstanceArgs | StackSetInstanceState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as StackSetInstanceState | undefined;
            inputs["accountId"] = state ? state.accountId : undefined;
            inputs["parameterOverrides"] = state ? state.parameterOverrides : undefined;
            inputs["region"] = state ? state.region : undefined;
            inputs["retainStack"] = state ? state.retainStack : undefined;
            inputs["stackId"] = state ? state.stackId : undefined;
            inputs["stackSetName"] = state ? state.stackSetName : undefined;
        } else {
            const args = argsOrState as StackSetInstanceArgs | undefined;
            if (!args || args.stackSetName === undefined) {
                throw new Error("Missing required property 'stackSetName'");
            }
            inputs["accountId"] = args ? args.accountId : undefined;
            inputs["parameterOverrides"] = args ? args.parameterOverrides : undefined;
            inputs["region"] = args ? args.region : undefined;
            inputs["retainStack"] = args ? args.retainStack : undefined;
            inputs["stackSetName"] = args ? args.stackSetName : undefined;
            inputs["stackId"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(StackSetInstance.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering StackSetInstance resources.
 */
export interface StackSetInstanceState {
    /**
     * Target AWS Account ID to create a Stack based on the Stack Set. Defaults to current account.
     */
    readonly accountId?: pulumi.Input<string>;
    /**
     * Key-value map of input parameters to override from the Stack Set for this Instance.
     */
    readonly parameterOverrides?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Target AWS Region to create a Stack based on the Stack Set. Defaults to current region.
     */
    readonly region?: pulumi.Input<string>;
    readonly retainStack?: pulumi.Input<boolean>;
    /**
     * Stack identifier
     */
    readonly stackId?: pulumi.Input<string>;
    /**
     * Name of the Stack Set.
     */
    readonly stackSetName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a StackSetInstance resource.
 */
export interface StackSetInstanceArgs {
    /**
     * Target AWS Account ID to create a Stack based on the Stack Set. Defaults to current account.
     */
    readonly accountId?: pulumi.Input<string>;
    /**
     * Key-value map of input parameters to override from the Stack Set for this Instance.
     */
    readonly parameterOverrides?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Target AWS Region to create a Stack based on the Stack Set. Defaults to current region.
     */
    readonly region?: pulumi.Input<string>;
    readonly retainStack?: pulumi.Input<boolean>;
    /**
     * Name of the Stack Set.
     */
    readonly stackSetName: pulumi.Input<string>;
}
