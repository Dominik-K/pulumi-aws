// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package cloudwatch

import (
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a CloudWatch Event Rule resource.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"fmt"
//
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/cloudwatch"
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/iam"
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/sns"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		console, err := cloudwatch.NewEventRule(ctx, "console", &cloudwatch.EventRuleArgs{
// 			Description:  pulumi.String("Capture each AWS Console Sign In"),
// 			EventPattern: pulumi.String(fmt.Sprintf("%v%v%v%v%v%v", "{\n", "  \"detail-type\": [\n", "    \"AWS Console Sign In via CloudTrail\"\n", "  ]\n", "}\n", "\n")),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		awsLogins, err := sns.NewTopic(ctx, "awsLogins", nil)
// 		if err != nil {
// 			return err
// 		}
// 		_, err = cloudwatch.NewEventTarget(ctx, "sns", &cloudwatch.EventTargetArgs{
// 			Arn:  awsLogins.Arn,
// 			Rule: console.Name,
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = sns.NewTopicPolicy(ctx, "_default", &sns.TopicPolicyArgs{
// 			Arn: awsLogins.Arn,
// 			Policy: snsTopicPolicy.ApplyT(func(snsTopicPolicy iam.GetPolicyDocumentResult) (string, error) {
// 				return snsTopicPolicy.Json, nil
// 			}).(pulumi.StringOutput),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type EventRule struct {
	pulumi.CustomResourceState

	// The Amazon Resource Name (ARN) of the rule.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// The description of the rule.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Event pattern
	// described a JSON object.
	// See full documentation of [CloudWatch Events and Event Patterns](http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/CloudWatchEventsandEventPatterns.html) for details.
	EventPattern pulumi.StringPtrOutput `pulumi:"eventPattern"`
	// Whether the rule should be enabled (defaults to `true`).
	IsEnabled pulumi.BoolPtrOutput `pulumi:"isEnabled"`
	// The rule's name. By default generated by this provider.
	Name pulumi.StringOutput `pulumi:"name"`
	// The rule's name. Conflicts with `name`.
	NamePrefix pulumi.StringPtrOutput `pulumi:"namePrefix"`
	// The Amazon Resource Name (ARN) associated with the role that is used for target invocation.
	RoleArn pulumi.StringPtrOutput `pulumi:"roleArn"`
	// The scheduling expression.
	// For example, `cron(0 20 * * ? *)` or `rate(5 minutes)`.
	ScheduleExpression pulumi.StringPtrOutput `pulumi:"scheduleExpression"`
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
}

// NewEventRule registers a new resource with the given unique name, arguments, and options.
func NewEventRule(ctx *pulumi.Context,
	name string, args *EventRuleArgs, opts ...pulumi.ResourceOption) (*EventRule, error) {
	if args == nil {
		args = &EventRuleArgs{}
	}
	var resource EventRule
	err := ctx.RegisterResource("aws:cloudwatch/eventRule:EventRule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetEventRule gets an existing EventRule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEventRule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *EventRuleState, opts ...pulumi.ResourceOption) (*EventRule, error) {
	var resource EventRule
	err := ctx.ReadResource("aws:cloudwatch/eventRule:EventRule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering EventRule resources.
type eventRuleState struct {
	// The Amazon Resource Name (ARN) of the rule.
	Arn *string `pulumi:"arn"`
	// The description of the rule.
	Description *string `pulumi:"description"`
	// Event pattern
	// described a JSON object.
	// See full documentation of [CloudWatch Events and Event Patterns](http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/CloudWatchEventsandEventPatterns.html) for details.
	EventPattern *string `pulumi:"eventPattern"`
	// Whether the rule should be enabled (defaults to `true`).
	IsEnabled *bool `pulumi:"isEnabled"`
	// The rule's name. By default generated by this provider.
	Name *string `pulumi:"name"`
	// The rule's name. Conflicts with `name`.
	NamePrefix *string `pulumi:"namePrefix"`
	// The Amazon Resource Name (ARN) associated with the role that is used for target invocation.
	RoleArn *string `pulumi:"roleArn"`
	// The scheduling expression.
	// For example, `cron(0 20 * * ? *)` or `rate(5 minutes)`.
	ScheduleExpression *string `pulumi:"scheduleExpression"`
	// A map of tags to assign to the resource.
	Tags map[string]string `pulumi:"tags"`
}

type EventRuleState struct {
	// The Amazon Resource Name (ARN) of the rule.
	Arn pulumi.StringPtrInput
	// The description of the rule.
	Description pulumi.StringPtrInput
	// Event pattern
	// described a JSON object.
	// See full documentation of [CloudWatch Events and Event Patterns](http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/CloudWatchEventsandEventPatterns.html) for details.
	EventPattern pulumi.StringPtrInput
	// Whether the rule should be enabled (defaults to `true`).
	IsEnabled pulumi.BoolPtrInput
	// The rule's name. By default generated by this provider.
	Name pulumi.StringPtrInput
	// The rule's name. Conflicts with `name`.
	NamePrefix pulumi.StringPtrInput
	// The Amazon Resource Name (ARN) associated with the role that is used for target invocation.
	RoleArn pulumi.StringPtrInput
	// The scheduling expression.
	// For example, `cron(0 20 * * ? *)` or `rate(5 minutes)`.
	ScheduleExpression pulumi.StringPtrInput
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapInput
}

func (EventRuleState) ElementType() reflect.Type {
	return reflect.TypeOf((*eventRuleState)(nil)).Elem()
}

type eventRuleArgs struct {
	// The description of the rule.
	Description *string `pulumi:"description"`
	// Event pattern
	// described a JSON object.
	// See full documentation of [CloudWatch Events and Event Patterns](http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/CloudWatchEventsandEventPatterns.html) for details.
	EventPattern *string `pulumi:"eventPattern"`
	// Whether the rule should be enabled (defaults to `true`).
	IsEnabled *bool `pulumi:"isEnabled"`
	// The rule's name. By default generated by this provider.
	Name *string `pulumi:"name"`
	// The rule's name. Conflicts with `name`.
	NamePrefix *string `pulumi:"namePrefix"`
	// The Amazon Resource Name (ARN) associated with the role that is used for target invocation.
	RoleArn *string `pulumi:"roleArn"`
	// The scheduling expression.
	// For example, `cron(0 20 * * ? *)` or `rate(5 minutes)`.
	ScheduleExpression *string `pulumi:"scheduleExpression"`
	// A map of tags to assign to the resource.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a EventRule resource.
type EventRuleArgs struct {
	// The description of the rule.
	Description pulumi.StringPtrInput
	// Event pattern
	// described a JSON object.
	// See full documentation of [CloudWatch Events and Event Patterns](http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/CloudWatchEventsandEventPatterns.html) for details.
	EventPattern pulumi.StringPtrInput
	// Whether the rule should be enabled (defaults to `true`).
	IsEnabled pulumi.BoolPtrInput
	// The rule's name. By default generated by this provider.
	Name pulumi.StringPtrInput
	// The rule's name. Conflicts with `name`.
	NamePrefix pulumi.StringPtrInput
	// The Amazon Resource Name (ARN) associated with the role that is used for target invocation.
	RoleArn pulumi.StringPtrInput
	// The scheduling expression.
	// For example, `cron(0 20 * * ? *)` or `rate(5 minutes)`.
	ScheduleExpression pulumi.StringPtrInput
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapInput
}

func (EventRuleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*eventRuleArgs)(nil)).Elem()
}
