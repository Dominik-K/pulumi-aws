// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * import * as fs from "fs";
 *
 * const example = new aws.worklink.Fleet("example", {});
 * const test = new aws.worklink.WebsiteCertificateAuthorityAssociation("test", {
 *     certificate: fs.readFileSync("certificate.pem", "utf-8"),
 *     fleetArn: aws_worklink_fleet_test.arn,
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/worklink_website_certificate_authority_association.html.markdown.
 */
export class WebsiteCertificateAuthorityAssociation extends pulumi.CustomResource {
    /**
     * Get an existing WebsiteCertificateAuthorityAssociation resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: WebsiteCertificateAuthorityAssociationState, opts?: pulumi.CustomResourceOptions): WebsiteCertificateAuthorityAssociation {
        return new WebsiteCertificateAuthorityAssociation(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws:worklink/websiteCertificateAuthorityAssociation:WebsiteCertificateAuthorityAssociation';

    /**
     * Returns true if the given object is an instance of WebsiteCertificateAuthorityAssociation.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is WebsiteCertificateAuthorityAssociation {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === WebsiteCertificateAuthorityAssociation.__pulumiType;
    }

    /**
     * The root certificate of the Certificate Authority.
     */
    public readonly certificate!: pulumi.Output<string>;
    /**
     * The certificate name to display.
     */
    public readonly displayName!: pulumi.Output<string | undefined>;
    /**
     * The ARN of the fleet.
     */
    public readonly fleetArn!: pulumi.Output<string>;
    /**
     * A unique identifier for the Certificate Authority.
     */
    public /*out*/ readonly websiteCaId!: pulumi.Output<string>;

    /**
     * Create a WebsiteCertificateAuthorityAssociation resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WebsiteCertificateAuthorityAssociationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: WebsiteCertificateAuthorityAssociationArgs | WebsiteCertificateAuthorityAssociationState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as WebsiteCertificateAuthorityAssociationState | undefined;
            inputs["certificate"] = state ? state.certificate : undefined;
            inputs["displayName"] = state ? state.displayName : undefined;
            inputs["fleetArn"] = state ? state.fleetArn : undefined;
            inputs["websiteCaId"] = state ? state.websiteCaId : undefined;
        } else {
            const args = argsOrState as WebsiteCertificateAuthorityAssociationArgs | undefined;
            if (!args || args.certificate === undefined) {
                throw new Error("Missing required property 'certificate'");
            }
            if (!args || args.fleetArn === undefined) {
                throw new Error("Missing required property 'fleetArn'");
            }
            inputs["certificate"] = args ? args.certificate : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["fleetArn"] = args ? args.fleetArn : undefined;
            inputs["websiteCaId"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(WebsiteCertificateAuthorityAssociation.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering WebsiteCertificateAuthorityAssociation resources.
 */
export interface WebsiteCertificateAuthorityAssociationState {
    /**
     * The root certificate of the Certificate Authority.
     */
    readonly certificate?: pulumi.Input<string>;
    /**
     * The certificate name to display.
     */
    readonly displayName?: pulumi.Input<string>;
    /**
     * The ARN of the fleet.
     */
    readonly fleetArn?: pulumi.Input<string>;
    /**
     * A unique identifier for the Certificate Authority.
     */
    readonly websiteCaId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a WebsiteCertificateAuthorityAssociation resource.
 */
export interface WebsiteCertificateAuthorityAssociationArgs {
    /**
     * The root certificate of the Certificate Authority.
     */
    readonly certificate: pulumi.Input<string>;
    /**
     * The certificate name to display.
     */
    readonly displayName?: pulumi.Input<string>;
    /**
     * The ARN of the fleet.
     */
    readonly fleetArn: pulumi.Input<string>;
}
