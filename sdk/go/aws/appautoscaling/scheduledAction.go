// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package appautoscaling

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides an Application AutoScaling ScheduledAction resource.
type ScheduledAction struct {
	pulumi.CustomResourceState

	// The Amazon Resource Name (ARN) of the scheduled action.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// The date and time for the scheduled action to end. Specify the following format: 2006-01-02T15:04:05Z
	EndTime pulumi.StringPtrOutput `pulumi:"endTime"`
	// The name of the scheduled action.
	Name pulumi.StringOutput `pulumi:"name"`
	// The identifier of the resource associated with the scheduled action. Documentation can be found in the parameter at: [AWS Application Auto Scaling API Reference](https://docs.aws.amazon.com/ApplicationAutoScaling/latest/APIReference/API_PutScheduledAction.html#ApplicationAutoScaling-PutScheduledAction-request-ResourceId)
	ResourceId pulumi.StringOutput `pulumi:"resourceId"`
	// The scalable dimension. Documentation can be found in the parameter at: [AWS Application Auto Scaling API Reference](https://docs.aws.amazon.com/ApplicationAutoScaling/latest/APIReference/API_PutScheduledAction.html#ApplicationAutoScaling-PutScheduledAction-request-ScalableDimension) Example: ecs:service:DesiredCount
	ScalableDimension pulumi.StringPtrOutput `pulumi:"scalableDimension"`
	// The new minimum and maximum capacity. You can set both values or just one. See below
	ScalableTargetAction ScheduledActionScalableTargetActionPtrOutput `pulumi:"scalableTargetAction"`
	// The schedule for this action. The following formats are supported: At expressions - at(yyyy-mm-ddThh:mm:ss), Rate expressions - rate(valueunit), Cron expressions - cron(fields). In UTC. Documentation can be found in the parameter at: [AWS Application Auto Scaling API Reference](https://docs.aws.amazon.com/ApplicationAutoScaling/latest/APIReference/API_PutScheduledAction.html#ApplicationAutoScaling-PutScheduledAction-request-Schedule)
	Schedule pulumi.StringPtrOutput `pulumi:"schedule"`
	// The namespace of the AWS service. Documentation can be found in the parameter at: [AWS Application Auto Scaling API Reference](https://docs.aws.amazon.com/ApplicationAutoScaling/latest/APIReference/API_PutScheduledAction.html#ApplicationAutoScaling-PutScheduledAction-request-ServiceNamespace) Example: ecs
	ServiceNamespace pulumi.StringOutput `pulumi:"serviceNamespace"`
	// The date and time for the scheduled action to start. Specify the following format: 2006-01-02T15:04:05Z
	StartTime pulumi.StringPtrOutput `pulumi:"startTime"`
}

// NewScheduledAction registers a new resource with the given unique name, arguments, and options.
func NewScheduledAction(ctx *pulumi.Context,
	name string, args *ScheduledActionArgs, opts ...pulumi.ResourceOption) (*ScheduledAction, error) {
	if args == nil || args.ResourceId == nil {
		return nil, errors.New("missing required argument 'ResourceId'")
	}
	if args == nil || args.ServiceNamespace == nil {
		return nil, errors.New("missing required argument 'ServiceNamespace'")
	}
	if args == nil {
		args = &ScheduledActionArgs{}
	}
	var resource ScheduledAction
	err := ctx.RegisterResource("aws:appautoscaling/scheduledAction:ScheduledAction", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetScheduledAction gets an existing ScheduledAction resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetScheduledAction(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ScheduledActionState, opts ...pulumi.ResourceOption) (*ScheduledAction, error) {
	var resource ScheduledAction
	err := ctx.ReadResource("aws:appautoscaling/scheduledAction:ScheduledAction", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ScheduledAction resources.
type scheduledActionState struct {
	// The Amazon Resource Name (ARN) of the scheduled action.
	Arn *string `pulumi:"arn"`
	// The date and time for the scheduled action to end. Specify the following format: 2006-01-02T15:04:05Z
	EndTime *string `pulumi:"endTime"`
	// The name of the scheduled action.
	Name *string `pulumi:"name"`
	// The identifier of the resource associated with the scheduled action. Documentation can be found in the parameter at: [AWS Application Auto Scaling API Reference](https://docs.aws.amazon.com/ApplicationAutoScaling/latest/APIReference/API_PutScheduledAction.html#ApplicationAutoScaling-PutScheduledAction-request-ResourceId)
	ResourceId *string `pulumi:"resourceId"`
	// The scalable dimension. Documentation can be found in the parameter at: [AWS Application Auto Scaling API Reference](https://docs.aws.amazon.com/ApplicationAutoScaling/latest/APIReference/API_PutScheduledAction.html#ApplicationAutoScaling-PutScheduledAction-request-ScalableDimension) Example: ecs:service:DesiredCount
	ScalableDimension *string `pulumi:"scalableDimension"`
	// The new minimum and maximum capacity. You can set both values or just one. See below
	ScalableTargetAction *ScheduledActionScalableTargetAction `pulumi:"scalableTargetAction"`
	// The schedule for this action. The following formats are supported: At expressions - at(yyyy-mm-ddThh:mm:ss), Rate expressions - rate(valueunit), Cron expressions - cron(fields). In UTC. Documentation can be found in the parameter at: [AWS Application Auto Scaling API Reference](https://docs.aws.amazon.com/ApplicationAutoScaling/latest/APIReference/API_PutScheduledAction.html#ApplicationAutoScaling-PutScheduledAction-request-Schedule)
	Schedule *string `pulumi:"schedule"`
	// The namespace of the AWS service. Documentation can be found in the parameter at: [AWS Application Auto Scaling API Reference](https://docs.aws.amazon.com/ApplicationAutoScaling/latest/APIReference/API_PutScheduledAction.html#ApplicationAutoScaling-PutScheduledAction-request-ServiceNamespace) Example: ecs
	ServiceNamespace *string `pulumi:"serviceNamespace"`
	// The date and time for the scheduled action to start. Specify the following format: 2006-01-02T15:04:05Z
	StartTime *string `pulumi:"startTime"`
}

type ScheduledActionState struct {
	// The Amazon Resource Name (ARN) of the scheduled action.
	Arn pulumi.StringPtrInput
	// The date and time for the scheduled action to end. Specify the following format: 2006-01-02T15:04:05Z
	EndTime pulumi.StringPtrInput
	// The name of the scheduled action.
	Name pulumi.StringPtrInput
	// The identifier of the resource associated with the scheduled action. Documentation can be found in the parameter at: [AWS Application Auto Scaling API Reference](https://docs.aws.amazon.com/ApplicationAutoScaling/latest/APIReference/API_PutScheduledAction.html#ApplicationAutoScaling-PutScheduledAction-request-ResourceId)
	ResourceId pulumi.StringPtrInput
	// The scalable dimension. Documentation can be found in the parameter at: [AWS Application Auto Scaling API Reference](https://docs.aws.amazon.com/ApplicationAutoScaling/latest/APIReference/API_PutScheduledAction.html#ApplicationAutoScaling-PutScheduledAction-request-ScalableDimension) Example: ecs:service:DesiredCount
	ScalableDimension pulumi.StringPtrInput
	// The new minimum and maximum capacity. You can set both values or just one. See below
	ScalableTargetAction ScheduledActionScalableTargetActionPtrInput
	// The schedule for this action. The following formats are supported: At expressions - at(yyyy-mm-ddThh:mm:ss), Rate expressions - rate(valueunit), Cron expressions - cron(fields). In UTC. Documentation can be found in the parameter at: [AWS Application Auto Scaling API Reference](https://docs.aws.amazon.com/ApplicationAutoScaling/latest/APIReference/API_PutScheduledAction.html#ApplicationAutoScaling-PutScheduledAction-request-Schedule)
	Schedule pulumi.StringPtrInput
	// The namespace of the AWS service. Documentation can be found in the parameter at: [AWS Application Auto Scaling API Reference](https://docs.aws.amazon.com/ApplicationAutoScaling/latest/APIReference/API_PutScheduledAction.html#ApplicationAutoScaling-PutScheduledAction-request-ServiceNamespace) Example: ecs
	ServiceNamespace pulumi.StringPtrInput
	// The date and time for the scheduled action to start. Specify the following format: 2006-01-02T15:04:05Z
	StartTime pulumi.StringPtrInput
}

func (ScheduledActionState) ElementType() reflect.Type {
	return reflect.TypeOf((*scheduledActionState)(nil)).Elem()
}

type scheduledActionArgs struct {
	// The date and time for the scheduled action to end. Specify the following format: 2006-01-02T15:04:05Z
	EndTime *string `pulumi:"endTime"`
	// The name of the scheduled action.
	Name *string `pulumi:"name"`
	// The identifier of the resource associated with the scheduled action. Documentation can be found in the parameter at: [AWS Application Auto Scaling API Reference](https://docs.aws.amazon.com/ApplicationAutoScaling/latest/APIReference/API_PutScheduledAction.html#ApplicationAutoScaling-PutScheduledAction-request-ResourceId)
	ResourceId string `pulumi:"resourceId"`
	// The scalable dimension. Documentation can be found in the parameter at: [AWS Application Auto Scaling API Reference](https://docs.aws.amazon.com/ApplicationAutoScaling/latest/APIReference/API_PutScheduledAction.html#ApplicationAutoScaling-PutScheduledAction-request-ScalableDimension) Example: ecs:service:DesiredCount
	ScalableDimension *string `pulumi:"scalableDimension"`
	// The new minimum and maximum capacity. You can set both values or just one. See below
	ScalableTargetAction *ScheduledActionScalableTargetAction `pulumi:"scalableTargetAction"`
	// The schedule for this action. The following formats are supported: At expressions - at(yyyy-mm-ddThh:mm:ss), Rate expressions - rate(valueunit), Cron expressions - cron(fields). In UTC. Documentation can be found in the parameter at: [AWS Application Auto Scaling API Reference](https://docs.aws.amazon.com/ApplicationAutoScaling/latest/APIReference/API_PutScheduledAction.html#ApplicationAutoScaling-PutScheduledAction-request-Schedule)
	Schedule *string `pulumi:"schedule"`
	// The namespace of the AWS service. Documentation can be found in the parameter at: [AWS Application Auto Scaling API Reference](https://docs.aws.amazon.com/ApplicationAutoScaling/latest/APIReference/API_PutScheduledAction.html#ApplicationAutoScaling-PutScheduledAction-request-ServiceNamespace) Example: ecs
	ServiceNamespace string `pulumi:"serviceNamespace"`
	// The date and time for the scheduled action to start. Specify the following format: 2006-01-02T15:04:05Z
	StartTime *string `pulumi:"startTime"`
}

// The set of arguments for constructing a ScheduledAction resource.
type ScheduledActionArgs struct {
	// The date and time for the scheduled action to end. Specify the following format: 2006-01-02T15:04:05Z
	EndTime pulumi.StringPtrInput
	// The name of the scheduled action.
	Name pulumi.StringPtrInput
	// The identifier of the resource associated with the scheduled action. Documentation can be found in the parameter at: [AWS Application Auto Scaling API Reference](https://docs.aws.amazon.com/ApplicationAutoScaling/latest/APIReference/API_PutScheduledAction.html#ApplicationAutoScaling-PutScheduledAction-request-ResourceId)
	ResourceId pulumi.StringInput
	// The scalable dimension. Documentation can be found in the parameter at: [AWS Application Auto Scaling API Reference](https://docs.aws.amazon.com/ApplicationAutoScaling/latest/APIReference/API_PutScheduledAction.html#ApplicationAutoScaling-PutScheduledAction-request-ScalableDimension) Example: ecs:service:DesiredCount
	ScalableDimension pulumi.StringPtrInput
	// The new minimum and maximum capacity. You can set both values or just one. See below
	ScalableTargetAction ScheduledActionScalableTargetActionPtrInput
	// The schedule for this action. The following formats are supported: At expressions - at(yyyy-mm-ddThh:mm:ss), Rate expressions - rate(valueunit), Cron expressions - cron(fields). In UTC. Documentation can be found in the parameter at: [AWS Application Auto Scaling API Reference](https://docs.aws.amazon.com/ApplicationAutoScaling/latest/APIReference/API_PutScheduledAction.html#ApplicationAutoScaling-PutScheduledAction-request-Schedule)
	Schedule pulumi.StringPtrInput
	// The namespace of the AWS service. Documentation can be found in the parameter at: [AWS Application Auto Scaling API Reference](https://docs.aws.amazon.com/ApplicationAutoScaling/latest/APIReference/API_PutScheduledAction.html#ApplicationAutoScaling-PutScheduledAction-request-ServiceNamespace) Example: ecs
	ServiceNamespace pulumi.StringInput
	// The date and time for the scheduled action to start. Specify the following format: 2006-01-02T15:04:05Z
	StartTime pulumi.StringPtrInput
}

func (ScheduledActionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*scheduledActionArgs)(nil)).Elem()
}
