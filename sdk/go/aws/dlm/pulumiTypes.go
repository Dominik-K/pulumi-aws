// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package dlm

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

type LifecyclePolicyPolicyDetails struct {
	// A list of resource types that should be targeted by the lifecycle policy. `VOLUME` is currently the only allowed value.
	ResourceTypes []string `pulumi:"resourceTypes"`
	// See the `schedule` configuration block.
	Schedules []LifecyclePolicyPolicyDetailsSchedule `pulumi:"schedules"`
	// A mapping of tag keys and their values. Any resources that match the `resourceTypes` and are tagged with _any_ of these tags will be targeted.
	TargetTags map[string]interface{} `pulumi:"targetTags"`
}

type LifecyclePolicyPolicyDetailsInput interface {
	pulumi.Input

	ToLifecyclePolicyPolicyDetailsOutput() LifecyclePolicyPolicyDetailsOutput
	ToLifecyclePolicyPolicyDetailsOutputWithContext(context.Context) LifecyclePolicyPolicyDetailsOutput
}

type LifecyclePolicyPolicyDetailsArgs struct {
	// A list of resource types that should be targeted by the lifecycle policy. `VOLUME` is currently the only allowed value.
	ResourceTypes pulumi.StringArrayInput `pulumi:"resourceTypes"`
	// See the `schedule` configuration block.
	Schedules LifecyclePolicyPolicyDetailsScheduleArrayInput `pulumi:"schedules"`
	// A mapping of tag keys and their values. Any resources that match the `resourceTypes` and are tagged with _any_ of these tags will be targeted.
	TargetTags pulumi.MapInput `pulumi:"targetTags"`
}

func (LifecyclePolicyPolicyDetailsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LifecyclePolicyPolicyDetails)(nil)).Elem()
}

func (i LifecyclePolicyPolicyDetailsArgs) ToLifecyclePolicyPolicyDetailsOutput() LifecyclePolicyPolicyDetailsOutput {
	return i.ToLifecyclePolicyPolicyDetailsOutputWithContext(context.Background())
}

func (i LifecyclePolicyPolicyDetailsArgs) ToLifecyclePolicyPolicyDetailsOutputWithContext(ctx context.Context) LifecyclePolicyPolicyDetailsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LifecyclePolicyPolicyDetailsOutput)
}

func (i LifecyclePolicyPolicyDetailsArgs) ToLifecyclePolicyPolicyDetailsPtrOutput() LifecyclePolicyPolicyDetailsPtrOutput {
	return i.ToLifecyclePolicyPolicyDetailsPtrOutputWithContext(context.Background())
}

func (i LifecyclePolicyPolicyDetailsArgs) ToLifecyclePolicyPolicyDetailsPtrOutputWithContext(ctx context.Context) LifecyclePolicyPolicyDetailsPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LifecyclePolicyPolicyDetailsOutput).ToLifecyclePolicyPolicyDetailsPtrOutputWithContext(ctx)
}

type LifecyclePolicyPolicyDetailsPtrInput interface {
	pulumi.Input

	ToLifecyclePolicyPolicyDetailsPtrOutput() LifecyclePolicyPolicyDetailsPtrOutput
	ToLifecyclePolicyPolicyDetailsPtrOutputWithContext(context.Context) LifecyclePolicyPolicyDetailsPtrOutput
}

type lifecyclePolicyPolicyDetailsPtrType LifecyclePolicyPolicyDetailsArgs

func LifecyclePolicyPolicyDetailsPtr(v *LifecyclePolicyPolicyDetailsArgs) LifecyclePolicyPolicyDetailsPtrInput {	return (*lifecyclePolicyPolicyDetailsPtrType)(v)
}

func (*lifecyclePolicyPolicyDetailsPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**LifecyclePolicyPolicyDetails)(nil)).Elem()
}

func (i *lifecyclePolicyPolicyDetailsPtrType) ToLifecyclePolicyPolicyDetailsPtrOutput() LifecyclePolicyPolicyDetailsPtrOutput {
	return i.ToLifecyclePolicyPolicyDetailsPtrOutputWithContext(context.Background())
}

func (i *lifecyclePolicyPolicyDetailsPtrType) ToLifecyclePolicyPolicyDetailsPtrOutputWithContext(ctx context.Context) LifecyclePolicyPolicyDetailsPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LifecyclePolicyPolicyDetailsPtrOutput)
}

type LifecyclePolicyPolicyDetailsOutput struct { *pulumi.OutputState }

func (LifecyclePolicyPolicyDetailsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LifecyclePolicyPolicyDetails)(nil)).Elem()
}

func (o LifecyclePolicyPolicyDetailsOutput) ToLifecyclePolicyPolicyDetailsOutput() LifecyclePolicyPolicyDetailsOutput {
	return o
}

func (o LifecyclePolicyPolicyDetailsOutput) ToLifecyclePolicyPolicyDetailsOutputWithContext(ctx context.Context) LifecyclePolicyPolicyDetailsOutput {
	return o
}

func (o LifecyclePolicyPolicyDetailsOutput) ToLifecyclePolicyPolicyDetailsPtrOutput() LifecyclePolicyPolicyDetailsPtrOutput {
	return o.ToLifecyclePolicyPolicyDetailsPtrOutputWithContext(context.Background())
}

func (o LifecyclePolicyPolicyDetailsOutput) ToLifecyclePolicyPolicyDetailsPtrOutputWithContext(ctx context.Context) LifecyclePolicyPolicyDetailsPtrOutput {
	return o.ApplyT(func(v LifecyclePolicyPolicyDetails) *LifecyclePolicyPolicyDetails {
		return &v
	}).(LifecyclePolicyPolicyDetailsPtrOutput)
}
// A list of resource types that should be targeted by the lifecycle policy. `VOLUME` is currently the only allowed value.
func (o LifecyclePolicyPolicyDetailsOutput) ResourceTypes() pulumi.StringArrayOutput {
	return o.ApplyT(func (v LifecyclePolicyPolicyDetails) []string { return v.ResourceTypes }).(pulumi.StringArrayOutput)
}

// See the `schedule` configuration block.
func (o LifecyclePolicyPolicyDetailsOutput) Schedules() LifecyclePolicyPolicyDetailsScheduleArrayOutput {
	return o.ApplyT(func (v LifecyclePolicyPolicyDetails) []LifecyclePolicyPolicyDetailsSchedule { return v.Schedules }).(LifecyclePolicyPolicyDetailsScheduleArrayOutput)
}

// A mapping of tag keys and their values. Any resources that match the `resourceTypes` and are tagged with _any_ of these tags will be targeted.
func (o LifecyclePolicyPolicyDetailsOutput) TargetTags() pulumi.MapOutput {
	return o.ApplyT(func (v LifecyclePolicyPolicyDetails) map[string]interface{} { return v.TargetTags }).(pulumi.MapOutput)
}

type LifecyclePolicyPolicyDetailsPtrOutput struct { *pulumi.OutputState}

func (LifecyclePolicyPolicyDetailsPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**LifecyclePolicyPolicyDetails)(nil)).Elem()
}

func (o LifecyclePolicyPolicyDetailsPtrOutput) ToLifecyclePolicyPolicyDetailsPtrOutput() LifecyclePolicyPolicyDetailsPtrOutput {
	return o
}

func (o LifecyclePolicyPolicyDetailsPtrOutput) ToLifecyclePolicyPolicyDetailsPtrOutputWithContext(ctx context.Context) LifecyclePolicyPolicyDetailsPtrOutput {
	return o
}

func (o LifecyclePolicyPolicyDetailsPtrOutput) Elem() LifecyclePolicyPolicyDetailsOutput {
	return o.ApplyT(func (v *LifecyclePolicyPolicyDetails) LifecyclePolicyPolicyDetails { return *v }).(LifecyclePolicyPolicyDetailsOutput)
}

// A list of resource types that should be targeted by the lifecycle policy. `VOLUME` is currently the only allowed value.
func (o LifecyclePolicyPolicyDetailsPtrOutput) ResourceTypes() pulumi.StringArrayOutput {
	return o.ApplyT(func (v LifecyclePolicyPolicyDetails) []string { return v.ResourceTypes }).(pulumi.StringArrayOutput)
}

// See the `schedule` configuration block.
func (o LifecyclePolicyPolicyDetailsPtrOutput) Schedules() LifecyclePolicyPolicyDetailsScheduleArrayOutput {
	return o.ApplyT(func (v LifecyclePolicyPolicyDetails) []LifecyclePolicyPolicyDetailsSchedule { return v.Schedules }).(LifecyclePolicyPolicyDetailsScheduleArrayOutput)
}

// A mapping of tag keys and their values. Any resources that match the `resourceTypes` and are tagged with _any_ of these tags will be targeted.
func (o LifecyclePolicyPolicyDetailsPtrOutput) TargetTags() pulumi.MapOutput {
	return o.ApplyT(func (v LifecyclePolicyPolicyDetails) map[string]interface{} { return v.TargetTags }).(pulumi.MapOutput)
}

type LifecyclePolicyPolicyDetailsSchedule struct {
	// Copy all user-defined tags on a source volume to snapshots of the volume created by this policy.
	CopyTags *bool `pulumi:"copyTags"`
	// See the `createRule` block. Max of 1 per schedule.
	CreateRule LifecyclePolicyPolicyDetailsScheduleCreateRule `pulumi:"createRule"`
	// A name for the schedule.
	Name string `pulumi:"name"`
	// See the `retainRule` block. Max of 1 per schedule.
	RetainRule LifecyclePolicyPolicyDetailsScheduleRetainRule `pulumi:"retainRule"`
	// A mapping of tag keys and their values. DLM lifecycle policies will already tag the snapshot with the tags on the volume. This configuration adds extra tags on top of these.
	TagsToAdd map[string]interface{} `pulumi:"tagsToAdd"`
}

type LifecyclePolicyPolicyDetailsScheduleInput interface {
	pulumi.Input

	ToLifecyclePolicyPolicyDetailsScheduleOutput() LifecyclePolicyPolicyDetailsScheduleOutput
	ToLifecyclePolicyPolicyDetailsScheduleOutputWithContext(context.Context) LifecyclePolicyPolicyDetailsScheduleOutput
}

type LifecyclePolicyPolicyDetailsScheduleArgs struct {
	// Copy all user-defined tags on a source volume to snapshots of the volume created by this policy.
	CopyTags pulumi.BoolPtrInput `pulumi:"copyTags"`
	// See the `createRule` block. Max of 1 per schedule.
	CreateRule LifecyclePolicyPolicyDetailsScheduleCreateRuleInput `pulumi:"createRule"`
	// A name for the schedule.
	Name pulumi.StringInput `pulumi:"name"`
	// See the `retainRule` block. Max of 1 per schedule.
	RetainRule LifecyclePolicyPolicyDetailsScheduleRetainRuleInput `pulumi:"retainRule"`
	// A mapping of tag keys and their values. DLM lifecycle policies will already tag the snapshot with the tags on the volume. This configuration adds extra tags on top of these.
	TagsToAdd pulumi.MapInput `pulumi:"tagsToAdd"`
}

func (LifecyclePolicyPolicyDetailsScheduleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LifecyclePolicyPolicyDetailsSchedule)(nil)).Elem()
}

func (i LifecyclePolicyPolicyDetailsScheduleArgs) ToLifecyclePolicyPolicyDetailsScheduleOutput() LifecyclePolicyPolicyDetailsScheduleOutput {
	return i.ToLifecyclePolicyPolicyDetailsScheduleOutputWithContext(context.Background())
}

func (i LifecyclePolicyPolicyDetailsScheduleArgs) ToLifecyclePolicyPolicyDetailsScheduleOutputWithContext(ctx context.Context) LifecyclePolicyPolicyDetailsScheduleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LifecyclePolicyPolicyDetailsScheduleOutput)
}

type LifecyclePolicyPolicyDetailsScheduleArrayInput interface {
	pulumi.Input

	ToLifecyclePolicyPolicyDetailsScheduleArrayOutput() LifecyclePolicyPolicyDetailsScheduleArrayOutput
	ToLifecyclePolicyPolicyDetailsScheduleArrayOutputWithContext(context.Context) LifecyclePolicyPolicyDetailsScheduleArrayOutput
}

type LifecyclePolicyPolicyDetailsScheduleArray []LifecyclePolicyPolicyDetailsScheduleInput

func (LifecyclePolicyPolicyDetailsScheduleArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]LifecyclePolicyPolicyDetailsSchedule)(nil)).Elem()
}

func (i LifecyclePolicyPolicyDetailsScheduleArray) ToLifecyclePolicyPolicyDetailsScheduleArrayOutput() LifecyclePolicyPolicyDetailsScheduleArrayOutput {
	return i.ToLifecyclePolicyPolicyDetailsScheduleArrayOutputWithContext(context.Background())
}

func (i LifecyclePolicyPolicyDetailsScheduleArray) ToLifecyclePolicyPolicyDetailsScheduleArrayOutputWithContext(ctx context.Context) LifecyclePolicyPolicyDetailsScheduleArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LifecyclePolicyPolicyDetailsScheduleArrayOutput)
}

type LifecyclePolicyPolicyDetailsScheduleOutput struct { *pulumi.OutputState }

func (LifecyclePolicyPolicyDetailsScheduleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LifecyclePolicyPolicyDetailsSchedule)(nil)).Elem()
}

func (o LifecyclePolicyPolicyDetailsScheduleOutput) ToLifecyclePolicyPolicyDetailsScheduleOutput() LifecyclePolicyPolicyDetailsScheduleOutput {
	return o
}

func (o LifecyclePolicyPolicyDetailsScheduleOutput) ToLifecyclePolicyPolicyDetailsScheduleOutputWithContext(ctx context.Context) LifecyclePolicyPolicyDetailsScheduleOutput {
	return o
}

// Copy all user-defined tags on a source volume to snapshots of the volume created by this policy.
func (o LifecyclePolicyPolicyDetailsScheduleOutput) CopyTags() pulumi.BoolPtrOutput {
	return o.ApplyT(func (v LifecyclePolicyPolicyDetailsSchedule) *bool { return v.CopyTags }).(pulumi.BoolPtrOutput)
}

// See the `createRule` block. Max of 1 per schedule.
func (o LifecyclePolicyPolicyDetailsScheduleOutput) CreateRule() LifecyclePolicyPolicyDetailsScheduleCreateRuleOutput {
	return o.ApplyT(func (v LifecyclePolicyPolicyDetailsSchedule) LifecyclePolicyPolicyDetailsScheduleCreateRule { return v.CreateRule }).(LifecyclePolicyPolicyDetailsScheduleCreateRuleOutput)
}

// A name for the schedule.
func (o LifecyclePolicyPolicyDetailsScheduleOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func (v LifecyclePolicyPolicyDetailsSchedule) string { return v.Name }).(pulumi.StringOutput)
}

// See the `retainRule` block. Max of 1 per schedule.
func (o LifecyclePolicyPolicyDetailsScheduleOutput) RetainRule() LifecyclePolicyPolicyDetailsScheduleRetainRuleOutput {
	return o.ApplyT(func (v LifecyclePolicyPolicyDetailsSchedule) LifecyclePolicyPolicyDetailsScheduleRetainRule { return v.RetainRule }).(LifecyclePolicyPolicyDetailsScheduleRetainRuleOutput)
}

// A mapping of tag keys and their values. DLM lifecycle policies will already tag the snapshot with the tags on the volume. This configuration adds extra tags on top of these.
func (o LifecyclePolicyPolicyDetailsScheduleOutput) TagsToAdd() pulumi.MapOutput {
	return o.ApplyT(func (v LifecyclePolicyPolicyDetailsSchedule) map[string]interface{} { return v.TagsToAdd }).(pulumi.MapOutput)
}

type LifecyclePolicyPolicyDetailsScheduleArrayOutput struct { *pulumi.OutputState}

func (LifecyclePolicyPolicyDetailsScheduleArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]LifecyclePolicyPolicyDetailsSchedule)(nil)).Elem()
}

func (o LifecyclePolicyPolicyDetailsScheduleArrayOutput) ToLifecyclePolicyPolicyDetailsScheduleArrayOutput() LifecyclePolicyPolicyDetailsScheduleArrayOutput {
	return o
}

func (o LifecyclePolicyPolicyDetailsScheduleArrayOutput) ToLifecyclePolicyPolicyDetailsScheduleArrayOutputWithContext(ctx context.Context) LifecyclePolicyPolicyDetailsScheduleArrayOutput {
	return o
}

func (o LifecyclePolicyPolicyDetailsScheduleArrayOutput) Index(i pulumi.IntInput) LifecyclePolicyPolicyDetailsScheduleOutput {
	return pulumi.All(o, i).ApplyT(func (vs []interface{}) LifecyclePolicyPolicyDetailsSchedule {
		return vs[0].([]LifecyclePolicyPolicyDetailsSchedule)[vs[1].(int)]
	}).(LifecyclePolicyPolicyDetailsScheduleOutput)
}

type LifecyclePolicyPolicyDetailsScheduleCreateRule struct {
	// How often this lifecycle policy should be evaluated. `2`,`3`,`4`,`6`,`8`,`12` or `24` are valid values.
	Interval int `pulumi:"interval"`
	// The unit for how often the lifecycle policy should be evaluated. `HOURS` is currently the only allowed value and also the default value.
	IntervalUnit *string `pulumi:"intervalUnit"`
	// A list of times in 24 hour clock format that sets when the lifecycle policy should be evaluated. Max of 1.
	Times *string `pulumi:"times"`
}

type LifecyclePolicyPolicyDetailsScheduleCreateRuleInput interface {
	pulumi.Input

	ToLifecyclePolicyPolicyDetailsScheduleCreateRuleOutput() LifecyclePolicyPolicyDetailsScheduleCreateRuleOutput
	ToLifecyclePolicyPolicyDetailsScheduleCreateRuleOutputWithContext(context.Context) LifecyclePolicyPolicyDetailsScheduleCreateRuleOutput
}

type LifecyclePolicyPolicyDetailsScheduleCreateRuleArgs struct {
	// How often this lifecycle policy should be evaluated. `2`,`3`,`4`,`6`,`8`,`12` or `24` are valid values.
	Interval pulumi.IntInput `pulumi:"interval"`
	// The unit for how often the lifecycle policy should be evaluated. `HOURS` is currently the only allowed value and also the default value.
	IntervalUnit pulumi.StringPtrInput `pulumi:"intervalUnit"`
	// A list of times in 24 hour clock format that sets when the lifecycle policy should be evaluated. Max of 1.
	Times pulumi.StringPtrInput `pulumi:"times"`
}

func (LifecyclePolicyPolicyDetailsScheduleCreateRuleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LifecyclePolicyPolicyDetailsScheduleCreateRule)(nil)).Elem()
}

func (i LifecyclePolicyPolicyDetailsScheduleCreateRuleArgs) ToLifecyclePolicyPolicyDetailsScheduleCreateRuleOutput() LifecyclePolicyPolicyDetailsScheduleCreateRuleOutput {
	return i.ToLifecyclePolicyPolicyDetailsScheduleCreateRuleOutputWithContext(context.Background())
}

func (i LifecyclePolicyPolicyDetailsScheduleCreateRuleArgs) ToLifecyclePolicyPolicyDetailsScheduleCreateRuleOutputWithContext(ctx context.Context) LifecyclePolicyPolicyDetailsScheduleCreateRuleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LifecyclePolicyPolicyDetailsScheduleCreateRuleOutput)
}

type LifecyclePolicyPolicyDetailsScheduleCreateRuleOutput struct { *pulumi.OutputState }

func (LifecyclePolicyPolicyDetailsScheduleCreateRuleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LifecyclePolicyPolicyDetailsScheduleCreateRule)(nil)).Elem()
}

func (o LifecyclePolicyPolicyDetailsScheduleCreateRuleOutput) ToLifecyclePolicyPolicyDetailsScheduleCreateRuleOutput() LifecyclePolicyPolicyDetailsScheduleCreateRuleOutput {
	return o
}

func (o LifecyclePolicyPolicyDetailsScheduleCreateRuleOutput) ToLifecyclePolicyPolicyDetailsScheduleCreateRuleOutputWithContext(ctx context.Context) LifecyclePolicyPolicyDetailsScheduleCreateRuleOutput {
	return o
}

// How often this lifecycle policy should be evaluated. `2`,`3`,`4`,`6`,`8`,`12` or `24` are valid values.
func (o LifecyclePolicyPolicyDetailsScheduleCreateRuleOutput) Interval() pulumi.IntOutput {
	return o.ApplyT(func (v LifecyclePolicyPolicyDetailsScheduleCreateRule) int { return v.Interval }).(pulumi.IntOutput)
}

// The unit for how often the lifecycle policy should be evaluated. `HOURS` is currently the only allowed value and also the default value.
func (o LifecyclePolicyPolicyDetailsScheduleCreateRuleOutput) IntervalUnit() pulumi.StringPtrOutput {
	return o.ApplyT(func (v LifecyclePolicyPolicyDetailsScheduleCreateRule) *string { return v.IntervalUnit }).(pulumi.StringPtrOutput)
}

// A list of times in 24 hour clock format that sets when the lifecycle policy should be evaluated. Max of 1.
func (o LifecyclePolicyPolicyDetailsScheduleCreateRuleOutput) Times() pulumi.StringPtrOutput {
	return o.ApplyT(func (v LifecyclePolicyPolicyDetailsScheduleCreateRule) *string { return v.Times }).(pulumi.StringPtrOutput)
}

type LifecyclePolicyPolicyDetailsScheduleRetainRule struct {
	// How many snapshots to keep. Must be an integer between 1 and 1000.
	Count int `pulumi:"count"`
}

type LifecyclePolicyPolicyDetailsScheduleRetainRuleInput interface {
	pulumi.Input

	ToLifecyclePolicyPolicyDetailsScheduleRetainRuleOutput() LifecyclePolicyPolicyDetailsScheduleRetainRuleOutput
	ToLifecyclePolicyPolicyDetailsScheduleRetainRuleOutputWithContext(context.Context) LifecyclePolicyPolicyDetailsScheduleRetainRuleOutput
}

type LifecyclePolicyPolicyDetailsScheduleRetainRuleArgs struct {
	// How many snapshots to keep. Must be an integer between 1 and 1000.
	Count pulumi.IntInput `pulumi:"count"`
}

func (LifecyclePolicyPolicyDetailsScheduleRetainRuleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LifecyclePolicyPolicyDetailsScheduleRetainRule)(nil)).Elem()
}

func (i LifecyclePolicyPolicyDetailsScheduleRetainRuleArgs) ToLifecyclePolicyPolicyDetailsScheduleRetainRuleOutput() LifecyclePolicyPolicyDetailsScheduleRetainRuleOutput {
	return i.ToLifecyclePolicyPolicyDetailsScheduleRetainRuleOutputWithContext(context.Background())
}

func (i LifecyclePolicyPolicyDetailsScheduleRetainRuleArgs) ToLifecyclePolicyPolicyDetailsScheduleRetainRuleOutputWithContext(ctx context.Context) LifecyclePolicyPolicyDetailsScheduleRetainRuleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LifecyclePolicyPolicyDetailsScheduleRetainRuleOutput)
}

type LifecyclePolicyPolicyDetailsScheduleRetainRuleOutput struct { *pulumi.OutputState }

func (LifecyclePolicyPolicyDetailsScheduleRetainRuleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LifecyclePolicyPolicyDetailsScheduleRetainRule)(nil)).Elem()
}

func (o LifecyclePolicyPolicyDetailsScheduleRetainRuleOutput) ToLifecyclePolicyPolicyDetailsScheduleRetainRuleOutput() LifecyclePolicyPolicyDetailsScheduleRetainRuleOutput {
	return o
}

func (o LifecyclePolicyPolicyDetailsScheduleRetainRuleOutput) ToLifecyclePolicyPolicyDetailsScheduleRetainRuleOutputWithContext(ctx context.Context) LifecyclePolicyPolicyDetailsScheduleRetainRuleOutput {
	return o
}

// How many snapshots to keep. Must be an integer between 1 and 1000.
func (o LifecyclePolicyPolicyDetailsScheduleRetainRuleOutput) Count() pulumi.IntOutput {
	return o.ApplyT(func (v LifecyclePolicyPolicyDetailsScheduleRetainRule) int { return v.Count }).(pulumi.IntOutput)
}

func init() {
	pulumi.RegisterOutputType(LifecyclePolicyPolicyDetailsOutput{})
	pulumi.RegisterOutputType(LifecyclePolicyPolicyDetailsPtrOutput{})
	pulumi.RegisterOutputType(LifecyclePolicyPolicyDetailsScheduleOutput{})
	pulumi.RegisterOutputType(LifecyclePolicyPolicyDetailsScheduleArrayOutput{})
	pulumi.RegisterOutputType(LifecyclePolicyPolicyDetailsScheduleCreateRuleOutput{})
	pulumi.RegisterOutputType(LifecyclePolicyPolicyDetailsScheduleRetainRuleOutput{})
}
