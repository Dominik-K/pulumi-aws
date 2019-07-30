// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/vpc_peering_connection_options.html.markdown.
 */
export class PeeringConnectionOptions extends pulumi.CustomResource {
    /**
     * Get an existing PeeringConnectionOptions resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: PeeringConnectionOptionsState, opts?: pulumi.CustomResourceOptions): PeeringConnectionOptions {
        return new PeeringConnectionOptions(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws:ec2/peeringConnectionOptions:PeeringConnectionOptions';

    /**
     * Returns true if the given object is an instance of PeeringConnectionOptions.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PeeringConnectionOptions {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PeeringConnectionOptions.__pulumiType;
    }

    /**
     * An optional configuration block that allows for [VPC Peering Connection]
     * (http://docs.aws.amazon.com/AmazonVPC/latest/PeeringGuide) options to be set for the VPC that accepts
     * the peering connection (a maximum of one).
     */
    public readonly accepter!: pulumi.Output<{ allowClassicLinkToRemoteVpc?: boolean, allowRemoteVpcDnsResolution?: boolean, allowVpcToRemoteClassicLink?: boolean }>;
    /**
     * A optional configuration block that allows for [VPC Peering Connection]
     * (http://docs.aws.amazon.com/AmazonVPC/latest/PeeringGuide) options to be set for the VPC that requests
     * the peering connection (a maximum of one).
     */
    public readonly requester!: pulumi.Output<{ allowClassicLinkToRemoteVpc?: boolean, allowRemoteVpcDnsResolution?: boolean, allowVpcToRemoteClassicLink?: boolean }>;
    /**
     * The ID of the requester VPC peering connection.
     */
    public readonly vpcPeeringConnectionId!: pulumi.Output<string>;

    /**
     * Create a PeeringConnectionOptions resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PeeringConnectionOptionsArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: PeeringConnectionOptionsArgs | PeeringConnectionOptionsState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as PeeringConnectionOptionsState | undefined;
            inputs["accepter"] = state ? state.accepter : undefined;
            inputs["requester"] = state ? state.requester : undefined;
            inputs["vpcPeeringConnectionId"] = state ? state.vpcPeeringConnectionId : undefined;
        } else {
            const args = argsOrState as PeeringConnectionOptionsArgs | undefined;
            if (!args || args.vpcPeeringConnectionId === undefined) {
                throw new Error("Missing required property 'vpcPeeringConnectionId'");
            }
            inputs["accepter"] = args ? args.accepter : undefined;
            inputs["requester"] = args ? args.requester : undefined;
            inputs["vpcPeeringConnectionId"] = args ? args.vpcPeeringConnectionId : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(PeeringConnectionOptions.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering PeeringConnectionOptions resources.
 */
export interface PeeringConnectionOptionsState {
    /**
     * An optional configuration block that allows for [VPC Peering Connection]
     * (http://docs.aws.amazon.com/AmazonVPC/latest/PeeringGuide) options to be set for the VPC that accepts
     * the peering connection (a maximum of one).
     */
    readonly accepter?: pulumi.Input<{ allowClassicLinkToRemoteVpc?: pulumi.Input<boolean>, allowRemoteVpcDnsResolution?: pulumi.Input<boolean>, allowVpcToRemoteClassicLink?: pulumi.Input<boolean> }>;
    /**
     * A optional configuration block that allows for [VPC Peering Connection]
     * (http://docs.aws.amazon.com/AmazonVPC/latest/PeeringGuide) options to be set for the VPC that requests
     * the peering connection (a maximum of one).
     */
    readonly requester?: pulumi.Input<{ allowClassicLinkToRemoteVpc?: pulumi.Input<boolean>, allowRemoteVpcDnsResolution?: pulumi.Input<boolean>, allowVpcToRemoteClassicLink?: pulumi.Input<boolean> }>;
    /**
     * The ID of the requester VPC peering connection.
     */
    readonly vpcPeeringConnectionId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a PeeringConnectionOptions resource.
 */
export interface PeeringConnectionOptionsArgs {
    /**
     * An optional configuration block that allows for [VPC Peering Connection]
     * (http://docs.aws.amazon.com/AmazonVPC/latest/PeeringGuide) options to be set for the VPC that accepts
     * the peering connection (a maximum of one).
     */
    readonly accepter?: pulumi.Input<{ allowClassicLinkToRemoteVpc?: pulumi.Input<boolean>, allowRemoteVpcDnsResolution?: pulumi.Input<boolean>, allowVpcToRemoteClassicLink?: pulumi.Input<boolean> }>;
    /**
     * A optional configuration block that allows for [VPC Peering Connection]
     * (http://docs.aws.amazon.com/AmazonVPC/latest/PeeringGuide) options to be set for the VPC that requests
     * the peering connection (a maximum of one).
     */
    readonly requester?: pulumi.Input<{ allowClassicLinkToRemoteVpc?: pulumi.Input<boolean>, allowRemoteVpcDnsResolution?: pulumi.Input<boolean>, allowVpcToRemoteClassicLink?: pulumi.Input<boolean> }>;
    /**
     * The ID of the requester VPC peering connection.
     */
    readonly vpcPeeringConnectionId: pulumi.Input<string>;
}
