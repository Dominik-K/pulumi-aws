// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a Inspector assessment template
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 *
 * const example = new aws.inspector.AssessmentTemplate("example", {
 *     targetArn: aws_inspector_assessment_target.example.arn,
 *     duration: 3600,
 *     rulesPackageArns: [
 *         "arn:aws:inspector:us-west-2:758058086616:rulespackage/0-9hgA516p",
 *         "arn:aws:inspector:us-west-2:758058086616:rulespackage/0-H5hpSawc",
 *         "arn:aws:inspector:us-west-2:758058086616:rulespackage/0-JJOtZiqQ",
 *         "arn:aws:inspector:us-west-2:758058086616:rulespackage/0-vg5GGHSD",
 *     ],
 * });
 * ```
 */
export class AssessmentTemplate extends pulumi.CustomResource {
    /**
     * Get an existing AssessmentTemplate resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AssessmentTemplateState, opts?: pulumi.CustomResourceOptions): AssessmentTemplate {
        return new AssessmentTemplate(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws:inspector/assessmentTemplate:AssessmentTemplate';

    /**
     * Returns true if the given object is an instance of AssessmentTemplate.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AssessmentTemplate {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AssessmentTemplate.__pulumiType;
    }

    /**
     * The template assessment ARN.
     */
    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * The duration of the inspector run.
     */
    public readonly duration!: pulumi.Output<number>;
    /**
     * The name of the assessment template.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The rules to be used during the run.
     */
    public readonly rulesPackageArns!: pulumi.Output<string[]>;
    /**
     * Key-value map of tags for the Inspector assessment template.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The assessment target ARN to attach the template to.
     */
    public readonly targetArn!: pulumi.Output<string>;

    /**
     * Create a AssessmentTemplate resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AssessmentTemplateArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AssessmentTemplateArgs | AssessmentTemplateState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as AssessmentTemplateState | undefined;
            inputs["arn"] = state ? state.arn : undefined;
            inputs["duration"] = state ? state.duration : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["rulesPackageArns"] = state ? state.rulesPackageArns : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["targetArn"] = state ? state.targetArn : undefined;
        } else {
            const args = argsOrState as AssessmentTemplateArgs | undefined;
            if (!args || args.duration === undefined) {
                throw new Error("Missing required property 'duration'");
            }
            if (!args || args.rulesPackageArns === undefined) {
                throw new Error("Missing required property 'rulesPackageArns'");
            }
            if (!args || args.targetArn === undefined) {
                throw new Error("Missing required property 'targetArn'");
            }
            inputs["duration"] = args ? args.duration : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["rulesPackageArns"] = args ? args.rulesPackageArns : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["targetArn"] = args ? args.targetArn : undefined;
            inputs["arn"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(AssessmentTemplate.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AssessmentTemplate resources.
 */
export interface AssessmentTemplateState {
    /**
     * The template assessment ARN.
     */
    readonly arn?: pulumi.Input<string>;
    /**
     * The duration of the inspector run.
     */
    readonly duration?: pulumi.Input<number>;
    /**
     * The name of the assessment template.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The rules to be used during the run.
     */
    readonly rulesPackageArns?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Key-value map of tags for the Inspector assessment template.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The assessment target ARN to attach the template to.
     */
    readonly targetArn?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a AssessmentTemplate resource.
 */
export interface AssessmentTemplateArgs {
    /**
     * The duration of the inspector run.
     */
    readonly duration: pulumi.Input<number>;
    /**
     * The name of the assessment template.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The rules to be used during the run.
     */
    readonly rulesPackageArns: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Key-value map of tags for the Inspector assessment template.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The assessment target ARN to attach the template to.
     */
    readonly targetArn: pulumi.Input<string>;
}
