// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * The ECS task definition data source allows access to details of
 * a specific AWS ECS task definition.
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/ecs_task_definition.html.markdown.
 */
export function getTaskDefinition(args: GetTaskDefinitionArgs, opts?: pulumi.InvokeOptions): Promise<GetTaskDefinitionResult> & GetTaskDefinitionResult {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    const promise: Promise<GetTaskDefinitionResult> = pulumi.runtime.invoke("aws:ecs/getTaskDefinition:getTaskDefinition", {
        "taskDefinition": args.taskDefinition,
    }, opts);

    return pulumi.utils.liftProperties(promise, opts);
}

/**
 * A collection of arguments for invoking getTaskDefinition.
 */
export interface GetTaskDefinitionArgs {
    /**
     * The family for the latest ACTIVE revision, family and revision (family:revision) for a specific revision in the family, the ARN of the task definition to access to.
     */
    readonly taskDefinition: string;
}

/**
 * A collection of values returned by getTaskDefinition.
 */
export interface GetTaskDefinitionResult {
    /**
     * The family of this task definition
     */
    readonly family: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * The Docker networking mode to use for the containers in this task.
     */
    readonly networkMode: string;
    /**
     * The revision of this task definition
     */
    readonly revision: number;
    /**
     * The status of this task definition
     */
    readonly status: string;
    readonly taskDefinition: string;
    /**
     * The ARN of the IAM role that containers in this task can assume
     */
    readonly taskRoleArn: string;
}
