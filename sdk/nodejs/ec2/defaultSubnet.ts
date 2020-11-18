// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to manage a [default AWS VPC subnet](http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/default-vpc.html#default-vpc-basics)
 * in the current region.
 *
 * The `aws.ec2.DefaultSubnet` behaves differently from normal resources, in that
 * this provider does not _create_ this resource, but instead "adopts" it
 * into management.
 *
 * ## Example Usage
 *
 * Basic usage with tags:
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 *
 * const defaultAz1 = new aws.ec2.DefaultSubnet("default_az1", {
 *     availabilityZone: "us-west-2a",
 *     tags: {
 *         Name: "Default subnet for us-west-2a",
 *     },
 * });
 * ```
 */
export class DefaultSubnet extends pulumi.CustomResource {
    /**
     * Get an existing DefaultSubnet resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DefaultSubnetState, opts?: pulumi.CustomResourceOptions): DefaultSubnet {
        return new DefaultSubnet(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws:ec2/defaultSubnet:DefaultSubnet';

    /**
     * Returns true if the given object is an instance of DefaultSubnet.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DefaultSubnet {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DefaultSubnet.__pulumiType;
    }

    public /*out*/ readonly arn!: pulumi.Output<string>;
    public /*out*/ readonly assignIpv6AddressOnCreation!: pulumi.Output<boolean>;
    public readonly availabilityZone!: pulumi.Output<string>;
    public /*out*/ readonly availabilityZoneId!: pulumi.Output<string>;
    /**
     * The CIDR block for the subnet.
     */
    public /*out*/ readonly cidrBlock!: pulumi.Output<string>;
    /**
     * The IPv6 CIDR block.
     */
    public /*out*/ readonly ipv6CidrBlock!: pulumi.Output<string>;
    public /*out*/ readonly ipv6CidrBlockAssociationId!: pulumi.Output<string>;
    /**
     * Specify true to indicate
     * that instances launched into the subnet should be assigned
     * a public IP address.
     */
    public readonly mapPublicIpOnLaunch!: pulumi.Output<boolean>;
    public readonly outpostArn!: pulumi.Output<string | undefined>;
    /**
     * The ID of the AWS account that owns the subnet.
     */
    public /*out*/ readonly ownerId!: pulumi.Output<string>;
    /**
     * A map of tags to assign to the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The VPC ID.
     */
    public /*out*/ readonly vpcId!: pulumi.Output<string>;

    /**
     * Create a DefaultSubnet resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DefaultSubnetArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DefaultSubnetArgs | DefaultSubnetState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as DefaultSubnetState | undefined;
            inputs["arn"] = state ? state.arn : undefined;
            inputs["assignIpv6AddressOnCreation"] = state ? state.assignIpv6AddressOnCreation : undefined;
            inputs["availabilityZone"] = state ? state.availabilityZone : undefined;
            inputs["availabilityZoneId"] = state ? state.availabilityZoneId : undefined;
            inputs["cidrBlock"] = state ? state.cidrBlock : undefined;
            inputs["ipv6CidrBlock"] = state ? state.ipv6CidrBlock : undefined;
            inputs["ipv6CidrBlockAssociationId"] = state ? state.ipv6CidrBlockAssociationId : undefined;
            inputs["mapPublicIpOnLaunch"] = state ? state.mapPublicIpOnLaunch : undefined;
            inputs["outpostArn"] = state ? state.outpostArn : undefined;
            inputs["ownerId"] = state ? state.ownerId : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["vpcId"] = state ? state.vpcId : undefined;
        } else {
            const args = argsOrState as DefaultSubnetArgs | undefined;
            if (!args || args.availabilityZone === undefined) {
                throw new Error("Missing required property 'availabilityZone'");
            }
            inputs["availabilityZone"] = args ? args.availabilityZone : undefined;
            inputs["mapPublicIpOnLaunch"] = args ? args.mapPublicIpOnLaunch : undefined;
            inputs["outpostArn"] = args ? args.outpostArn : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["arn"] = undefined /*out*/;
            inputs["assignIpv6AddressOnCreation"] = undefined /*out*/;
            inputs["availabilityZoneId"] = undefined /*out*/;
            inputs["cidrBlock"] = undefined /*out*/;
            inputs["ipv6CidrBlock"] = undefined /*out*/;
            inputs["ipv6CidrBlockAssociationId"] = undefined /*out*/;
            inputs["ownerId"] = undefined /*out*/;
            inputs["vpcId"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(DefaultSubnet.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DefaultSubnet resources.
 */
export interface DefaultSubnetState {
    readonly arn?: pulumi.Input<string>;
    readonly assignIpv6AddressOnCreation?: pulumi.Input<boolean>;
    readonly availabilityZone?: pulumi.Input<string>;
    readonly availabilityZoneId?: pulumi.Input<string>;
    /**
     * The CIDR block for the subnet.
     */
    readonly cidrBlock?: pulumi.Input<string>;
    /**
     * The IPv6 CIDR block.
     */
    readonly ipv6CidrBlock?: pulumi.Input<string>;
    readonly ipv6CidrBlockAssociationId?: pulumi.Input<string>;
    /**
     * Specify true to indicate
     * that instances launched into the subnet should be assigned
     * a public IP address.
     */
    readonly mapPublicIpOnLaunch?: pulumi.Input<boolean>;
    readonly outpostArn?: pulumi.Input<string>;
    /**
     * The ID of the AWS account that owns the subnet.
     */
    readonly ownerId?: pulumi.Input<string>;
    /**
     * A map of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The VPC ID.
     */
    readonly vpcId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a DefaultSubnet resource.
 */
export interface DefaultSubnetArgs {
    readonly availabilityZone: pulumi.Input<string>;
    /**
     * Specify true to indicate
     * that instances launched into the subnet should be assigned
     * a public IP address.
     */
    readonly mapPublicIpOnLaunch?: pulumi.Input<boolean>;
    readonly outpostArn?: pulumi.Input<string>;
    /**
     * A map of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
