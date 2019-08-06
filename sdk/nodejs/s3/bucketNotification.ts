// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Manages a S3 Bucket Notification Configuration. For additional information, see the [Configuring S3 Event Notifications section in the Amazon S3 Developer Guide](https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html).
 * 
 * > **NOTE:** S3 Buckets only support a single notification configuration. Declaring multiple `aws.s3.BucketNotification` resources to the same S3 Bucket will cause a perpetual difference in configuration.
 * 
 * ## Example Usage
 * 
 * ### Add notification configuration to SNS Topic
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const bucket = new aws.s3.Bucket("bucket", {});
 * const topic = new aws.sns.Topic("topic", {
 *     policy: pulumi.interpolate`{
 *     "Version":"2012-10-17",
 *     "Statement":[{
 *         "Effect": "Allow",
 *         "Principal": {"AWS":"*"},
 *         "Action": "SNS:Publish",
 *         "Resource": "arn:aws:sns:*:*:s3-event-notification-topic",
 *         "Condition":{
 *             "ArnLike":{"aws:SourceArn":"${bucket.arn}"}
 *         }
 *     }]
 * }
 * `,
 * });
 * const bucketNotification = new aws.s3.BucketNotification("bucketNotification", {
 *     bucket: bucket.id,
 *     topics: [{
 *         events: ["s3:ObjectCreated:*"],
 *         filterSuffix: ".log",
 *         topicArn: topic.arn,
 *     }],
 * });
 * ```
 * 
 * ### Add notification configuration to SQS Queue
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const bucket = new aws.s3.Bucket("bucket", {});
 * const queue = new aws.sqs.Queue("queue", {
 *     policy: pulumi.interpolate`{
 *   "Version": "2012-10-17",
 *   "Statement": [
 *     {
 *       "Effect": "Allow",
 *       "Principal": "*",
 *       "Action": "sqs:SendMessage",
 * 	  "Resource": "arn:aws:sqs:*:*:s3-event-notification-queue",
 *       "Condition": {
 *         "ArnEquals": { "aws:SourceArn": "${bucket.arn}" }
 *       }
 *     }
 *   ]
 * }
 * `,
 * });
 * const bucketNotification = new aws.s3.BucketNotification("bucketNotification", {
 *     bucket: bucket.id,
 *     queues: [{
 *         events: ["s3:ObjectCreated:*"],
 *         filterSuffix: ".log",
 *         queueArn: queue.arn,
 *     }],
 * });
 * ```
 * 
 * ### Add notification configuration to Lambda Function
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const iamForLambda = new aws.iam.Role("iamForLambda", {
 *     assumeRolePolicy: `{
 *   "Version": "2012-10-17",
 *   "Statement": [
 *     {
 *       "Action": "sts:AssumeRole",
 *       "Principal": {
 *         "Service": "lambda.amazonaws.com"
 *       },
 *       "Effect": "Allow"
 *     }
 *   ]
 * }
 * `,
 * });
 * const bucket = new aws.s3.Bucket("bucket", {});
 * const func = new aws.lambda.Function("func", {
 *     code: new pulumi.asset.FileArchive("your-function.zip"),
 *     handler: "exports.example",
 *     role: iamForLambda.arn,
 *     runtime: "go1.x",
 * });
 * const allowBucket = new aws.lambda.Permission("allowBucket", {
 *     action: "lambda:InvokeFunction",
 *     function: func.arn,
 *     principal: "s3.amazonaws.com",
 *     sourceArn: bucket.arn,
 * });
 * const bucketNotification = new aws.s3.BucketNotification("bucketNotification", {
 *     bucket: bucket.id,
 *     lambdaFunctions: [{
 *         events: ["s3:ObjectCreated:*"],
 *         filterPrefix: "AWSLogs/",
 *         filterSuffix: ".log",
 *         lambdaFunctionArn: func.arn,
 *     }],
 * });
 * ```
 * 
 * ### Trigger multiple Lambda functions
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const iamForLambda = new aws.iam.Role("iamForLambda", {
 *     assumeRolePolicy: `{
 *   "Version": "2012-10-17",
 *   "Statement": [
 *     {
 *       "Action": "sts:AssumeRole",
 *       "Principal": {
 *         "Service": "lambda.amazonaws.com"
 *       },
 *       "Effect": "Allow"
 *     }
 *   ]
 * }
 * `,
 * });
 * const bucket = new aws.s3.Bucket("bucket", {});
 * const func1 = new aws.lambda.Function("func1", {
 *     code: new pulumi.asset.FileArchive("your-function1.zip"),
 *     handler: "exports.example",
 *     role: iamForLambda.arn,
 *     runtime: "go1.x",
 * });
 * const func2 = new aws.lambda.Function("func2", {
 *     code: new pulumi.asset.FileArchive("your-function2.zip"),
 *     handler: "exports.example",
 *     role: iamForLambda.arn,
 * });
 * const allowBucket1 = new aws.lambda.Permission("allowBucket1", {
 *     action: "lambda:InvokeFunction",
 *     function: func1.arn,
 *     principal: "s3.amazonaws.com",
 *     sourceArn: bucket.arn,
 * });
 * const allowBucket2 = new aws.lambda.Permission("allowBucket2", {
 *     action: "lambda:InvokeFunction",
 *     function: func2.arn,
 *     principal: "s3.amazonaws.com",
 *     sourceArn: bucket.arn,
 * });
 * const bucketNotification = new aws.s3.BucketNotification("bucketNotification", {
 *     bucket: bucket.id,
 *     lambdaFunctions: [
 *         {
 *             events: ["s3:ObjectCreated:*"],
 *             filterPrefix: "AWSLogs/",
 *             filterSuffix: ".log",
 *             lambdaFunctionArn: func1.arn,
 *         },
 *         {
 *             events: ["s3:ObjectCreated:*"],
 *             filterPrefix: "OtherLogs/",
 *             filterSuffix: ".log",
 *             lambdaFunctionArn: func2.arn,
 *         },
 *     ],
 * });
 * ```
 * 
 * ### Add multiple notification configurations to SQS Queue
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const bucket = new aws.s3.Bucket("bucket", {});
 * const queue = new aws.sqs.Queue("queue", {
 *     policy: pulumi.interpolate`{
 *   "Version": "2012-10-17",
 *   "Statement": [
 *     {
 *       "Effect": "Allow",
 *       "Principal": "*",
 *       "Action": "sqs:SendMessage",
 * 	  "Resource": "arn:aws:sqs:*:*:s3-event-notification-queue",
 *       "Condition": {
 *         "ArnEquals": { "aws:SourceArn": "${bucket.arn}" }
 *       }
 *     }
 *   ]
 * }
 * `,
 * });
 * const bucketNotification = new aws.s3.BucketNotification("bucketNotification", {
 *     bucket: bucket.id,
 *     queues: [
 *         {
 *             events: ["s3:ObjectCreated:*"],
 *             filterPrefix: "images/",
 *             id: "image-upload-event",
 *             queueArn: queue.arn,
 *         },
 *         {
 *             events: ["s3:ObjectCreated:*"],
 *             filterPrefix: "videos/",
 *             id: "video-upload-event",
 *             queueArn: queue.arn,
 *         },
 *     ],
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/s3_bucket_notification.html.markdown.
 */
export class BucketNotification extends pulumi.CustomResource {
    /**
     * Get an existing BucketNotification resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: BucketNotificationState, opts?: pulumi.CustomResourceOptions): BucketNotification {
        return new BucketNotification(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws:s3/bucketNotification:BucketNotification';

    /**
     * Returns true if the given object is an instance of BucketNotification.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is BucketNotification {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === BucketNotification.__pulumiType;
    }

    /**
     * The name of the bucket to put notification configuration.
     */
    public readonly bucket!: pulumi.Output<string>;
    /**
     * Used to configure notifications to a Lambda Function (documented below).
     */
    public readonly lambdaFunctions!: pulumi.Output<{ events: string[], filterPrefix?: string, filterSuffix?: string, id: string, lambdaFunctionArn?: string }[] | undefined>;
    /**
     * The notification configuration to SQS Queue (documented below).
     */
    public readonly queues!: pulumi.Output<{ events: string[], filterPrefix?: string, filterSuffix?: string, id: string, queueArn: string }[] | undefined>;
    /**
     * The notification configuration to SNS Topic (documented below).
     */
    public readonly topics!: pulumi.Output<{ events: string[], filterPrefix?: string, filterSuffix?: string, id: string, topicArn: string }[] | undefined>;

    /**
     * Create a BucketNotification resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: BucketNotificationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: BucketNotificationArgs | BucketNotificationState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as BucketNotificationState | undefined;
            inputs["bucket"] = state ? state.bucket : undefined;
            inputs["lambdaFunctions"] = state ? state.lambdaFunctions : undefined;
            inputs["queues"] = state ? state.queues : undefined;
            inputs["topics"] = state ? state.topics : undefined;
        } else {
            const args = argsOrState as BucketNotificationArgs | undefined;
            if (!args || args.bucket === undefined) {
                throw new Error("Missing required property 'bucket'");
            }
            inputs["bucket"] = args ? args.bucket : undefined;
            inputs["lambdaFunctions"] = args ? args.lambdaFunctions : undefined;
            inputs["queues"] = args ? args.queues : undefined;
            inputs["topics"] = args ? args.topics : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(BucketNotification.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering BucketNotification resources.
 */
export interface BucketNotificationState {
    /**
     * The name of the bucket to put notification configuration.
     */
    readonly bucket?: pulumi.Input<string>;
    /**
     * Used to configure notifications to a Lambda Function (documented below).
     */
    readonly lambdaFunctions?: pulumi.Input<pulumi.Input<{ events: pulumi.Input<pulumi.Input<string>[]>, filterPrefix?: pulumi.Input<string>, filterSuffix?: pulumi.Input<string>, id?: pulumi.Input<string>, lambdaFunctionArn?: pulumi.Input<string> }>[]>;
    /**
     * The notification configuration to SQS Queue (documented below).
     */
    readonly queues?: pulumi.Input<pulumi.Input<{ events: pulumi.Input<pulumi.Input<string>[]>, filterPrefix?: pulumi.Input<string>, filterSuffix?: pulumi.Input<string>, id?: pulumi.Input<string>, queueArn: pulumi.Input<string> }>[]>;
    /**
     * The notification configuration to SNS Topic (documented below).
     */
    readonly topics?: pulumi.Input<pulumi.Input<{ events: pulumi.Input<pulumi.Input<string>[]>, filterPrefix?: pulumi.Input<string>, filterSuffix?: pulumi.Input<string>, id?: pulumi.Input<string>, topicArn: pulumi.Input<string> }>[]>;
}

/**
 * The set of arguments for constructing a BucketNotification resource.
 */
export interface BucketNotificationArgs {
    /**
     * The name of the bucket to put notification configuration.
     */
    readonly bucket: pulumi.Input<string>;
    /**
     * Used to configure notifications to a Lambda Function (documented below).
     */
    readonly lambdaFunctions?: pulumi.Input<pulumi.Input<{ events: pulumi.Input<pulumi.Input<string>[]>, filterPrefix?: pulumi.Input<string>, filterSuffix?: pulumi.Input<string>, id?: pulumi.Input<string>, lambdaFunctionArn?: pulumi.Input<string> }>[]>;
    /**
     * The notification configuration to SQS Queue (documented below).
     */
    readonly queues?: pulumi.Input<pulumi.Input<{ events: pulumi.Input<pulumi.Input<string>[]>, filterPrefix?: pulumi.Input<string>, filterSuffix?: pulumi.Input<string>, id?: pulumi.Input<string>, queueArn: pulumi.Input<string> }>[]>;
    /**
     * The notification configuration to SNS Topic (documented below).
     */
    readonly topics?: pulumi.Input<pulumi.Input<{ events: pulumi.Input<pulumi.Input<string>[]>, filterPrefix?: pulumi.Input<string>, filterSuffix?: pulumi.Input<string>, id?: pulumi.Input<string>, topicArn: pulumi.Input<string> }>[]>;
}
