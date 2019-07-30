// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides an API Gateway REST API.
 * 
 * ## Example Usage
 * 
 * ### Basic
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const myDemoAPI = new aws.apigateway.RestApi("MyDemoAPI", {
 *     description: "This is my API for demonstration purposes",
 * });
 * ```
 * 
 * ### Regional Endpoint Type
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const example = new aws.apigateway.RestApi("example", {
 *     endpointConfiguration: {
 *         types: "REGIONAL",
 *     },
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/api_gateway_rest_api.html.markdown.
 */
export class RestApi extends pulumi.CustomResource {
    /**
     * Get an existing RestApi resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: RestApiState, opts?: pulumi.CustomResourceOptions): RestApi {
        return new RestApi(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws:apigateway/restApi:RestApi';

    /**
     * Returns true if the given object is an instance of RestApi.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is RestApi {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === RestApi.__pulumiType;
    }

    /**
     * The source of the API key for requests. Valid values are HEADER (default) and AUTHORIZER.
     */
    public readonly apiKeySource!: pulumi.Output<string | undefined>;
    /**
     * The list of binary media types supported by the RestApi. By default, the RestApi supports only UTF-8-encoded text payloads.
     */
    public readonly binaryMediaTypes!: pulumi.Output<string[] | undefined>;
    /**
     * An OpenAPI specification that defines the set of routes and integrations to create as part of the REST API.
     */
    public readonly body!: pulumi.Output<string | undefined>;
    /**
     * The creation date of the REST API
     */
    public /*out*/ readonly createdDate!: pulumi.Output<string>;
    /**
     * The description of the REST API
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Nested argument defining API endpoint configuration including endpoint type. Defined below.
     */
    public readonly endpointConfiguration!: pulumi.Output<{ types: string }>;
    /**
     * The execution ARN part to be used in [`lambda_permission`](https://www.terraform.io/docs/providers/aws/r/lambda_permission.html)'s `source_arn`
     * when allowing API Gateway to invoke a Lambda function,
     * e.g. `arn:aws:execute-api:eu-west-2:123456789012:z4675bid1j`, which can be concatenated with allowed stage, method and resource path.
     */
    public /*out*/ readonly executionArn!: pulumi.Output<string>;
    /**
     * Minimum response size to compress for the REST API. Integer between -1 and 10485760 (10MB). Setting a value greater than -1 will enable compression, -1 disables compression (default).
     */
    public readonly minimumCompressionSize!: pulumi.Output<number | undefined>;
    /**
     * The name of the REST API
     */
    public readonly name!: pulumi.Output<string>;
    public readonly policy!: pulumi.Output<string | undefined>;
    /**
     * The resource ID of the REST API's root
     */
    public /*out*/ readonly rootResourceId!: pulumi.Output<string>;

    /**
     * Create a RestApi resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: RestApiArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: RestApiArgs | RestApiState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as RestApiState | undefined;
            inputs["apiKeySource"] = state ? state.apiKeySource : undefined;
            inputs["binaryMediaTypes"] = state ? state.binaryMediaTypes : undefined;
            inputs["body"] = state ? state.body : undefined;
            inputs["createdDate"] = state ? state.createdDate : undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["endpointConfiguration"] = state ? state.endpointConfiguration : undefined;
            inputs["executionArn"] = state ? state.executionArn : undefined;
            inputs["minimumCompressionSize"] = state ? state.minimumCompressionSize : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["policy"] = state ? state.policy : undefined;
            inputs["rootResourceId"] = state ? state.rootResourceId : undefined;
        } else {
            const args = argsOrState as RestApiArgs | undefined;
            inputs["apiKeySource"] = args ? args.apiKeySource : undefined;
            inputs["binaryMediaTypes"] = args ? args.binaryMediaTypes : undefined;
            inputs["body"] = args ? args.body : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["endpointConfiguration"] = args ? args.endpointConfiguration : undefined;
            inputs["minimumCompressionSize"] = args ? args.minimumCompressionSize : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["policy"] = args ? args.policy : undefined;
            inputs["createdDate"] = undefined /*out*/;
            inputs["executionArn"] = undefined /*out*/;
            inputs["rootResourceId"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(RestApi.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering RestApi resources.
 */
export interface RestApiState {
    /**
     * The source of the API key for requests. Valid values are HEADER (default) and AUTHORIZER.
     */
    readonly apiKeySource?: pulumi.Input<string>;
    /**
     * The list of binary media types supported by the RestApi. By default, the RestApi supports only UTF-8-encoded text payloads.
     */
    readonly binaryMediaTypes?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * An OpenAPI specification that defines the set of routes and integrations to create as part of the REST API.
     */
    readonly body?: pulumi.Input<string>;
    /**
     * The creation date of the REST API
     */
    readonly createdDate?: pulumi.Input<string>;
    /**
     * The description of the REST API
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Nested argument defining API endpoint configuration including endpoint type. Defined below.
     */
    readonly endpointConfiguration?: pulumi.Input<{ types: pulumi.Input<string> }>;
    /**
     * The execution ARN part to be used in [`lambda_permission`](https://www.terraform.io/docs/providers/aws/r/lambda_permission.html)'s `source_arn`
     * when allowing API Gateway to invoke a Lambda function,
     * e.g. `arn:aws:execute-api:eu-west-2:123456789012:z4675bid1j`, which can be concatenated with allowed stage, method and resource path.
     */
    readonly executionArn?: pulumi.Input<string>;
    /**
     * Minimum response size to compress for the REST API. Integer between -1 and 10485760 (10MB). Setting a value greater than -1 will enable compression, -1 disables compression (default).
     */
    readonly minimumCompressionSize?: pulumi.Input<number>;
    /**
     * The name of the REST API
     */
    readonly name?: pulumi.Input<string>;
    readonly policy?: pulumi.Input<string>;
    /**
     * The resource ID of the REST API's root
     */
    readonly rootResourceId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a RestApi resource.
 */
export interface RestApiArgs {
    /**
     * The source of the API key for requests. Valid values are HEADER (default) and AUTHORIZER.
     */
    readonly apiKeySource?: pulumi.Input<string>;
    /**
     * The list of binary media types supported by the RestApi. By default, the RestApi supports only UTF-8-encoded text payloads.
     */
    readonly binaryMediaTypes?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * An OpenAPI specification that defines the set of routes and integrations to create as part of the REST API.
     */
    readonly body?: pulumi.Input<string>;
    /**
     * The description of the REST API
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Nested argument defining API endpoint configuration including endpoint type. Defined below.
     */
    readonly endpointConfiguration?: pulumi.Input<{ types: pulumi.Input<string> }>;
    /**
     * Minimum response size to compress for the REST API. Integer between -1 and 10485760 (10MB). Setting a value greater than -1 will enable compression, -1 disables compression (default).
     */
    readonly minimumCompressionSize?: pulumi.Input<number>;
    /**
     * The name of the REST API
     */
    readonly name?: pulumi.Input<string>;
    readonly policy?: pulumi.Input<string>;
}
