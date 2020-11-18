// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as enums from "../types/enums";
import * as utilities from "../utilities";

/**
 * Provides details about a specific Amazon Lex Bot Alias.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 *
 * const orderFlowersProd = pulumi.output(aws.lex.getBotAlias({
 *     botName: "OrderFlowers",
 *     name: "OrderFlowersProd",
 * }, { async: true }));
 * ```
 */
export function getBotAlias(args: GetBotAliasArgs, opts?: pulumi.InvokeOptions): Promise<GetBotAliasResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("aws:lex/getBotAlias:getBotAlias", {
        "botName": args.botName,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getBotAlias.
 */
export interface GetBotAliasArgs {
    /**
     * The name of the bot.
     */
    readonly botName: string;
    /**
     * The name of the bot alias. The name is case sensitive.
     */
    readonly name: string;
}

/**
 * A collection of values returned by getBotAlias.
 */
export interface GetBotAliasResult {
    /**
     * The ARN of the bot alias.
     */
    readonly arn: string;
    /**
     * The name of the bot.
     */
    readonly botName: string;
    /**
     * The version of the bot that the alias points to.
     */
    readonly botVersion: string;
    /**
     * Checksum of the bot alias.
     */
    readonly checksum: string;
    /**
     * The date that the bot alias was created.
     */
    readonly createdDate: string;
    /**
     * A description of the alias.
     */
    readonly description: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * The date that the bot alias was updated. When you create a resource, the creation date and the last updated date are the same.
     */
    readonly lastUpdatedDate: string;
    /**
     * The name of the alias. The name is not case sensitive.
     */
    readonly name: string;
}
