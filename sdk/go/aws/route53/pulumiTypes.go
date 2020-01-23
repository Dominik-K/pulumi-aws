// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package route53

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

type RecordAlias struct {
	// Set to `true` if you want Route 53 to determine whether to respond to DNS queries using this resource record set by checking the health of the resource record set. Some resources have special requirements, see [related part of documentation](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/resource-record-sets-values.html#rrsets-values-alias-evaluate-target-health).
	EvaluateTargetHealth bool `pulumi:"evaluateTargetHealth"`
	// DNS domain name for a CloudFront distribution, S3 bucket, ELB, or another resource record set in this hosted zone.
	Name string `pulumi:"name"`
	// Hosted zone ID for a CloudFront distribution, S3 bucket, ELB, or Route 53 hosted zone. See [`resource_elb.zone_id`](https://www.terraform.io/docs/providers/aws/r/elb.html#zone_id) for example.
	ZoneId string `pulumi:"zoneId"`
}

type RecordAliasInput interface {
	pulumi.Input

	ToRecordAliasOutput() RecordAliasOutput
	ToRecordAliasOutputWithContext(context.Context) RecordAliasOutput
}

type RecordAliasArgs struct {
	// Set to `true` if you want Route 53 to determine whether to respond to DNS queries using this resource record set by checking the health of the resource record set. Some resources have special requirements, see [related part of documentation](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/resource-record-sets-values.html#rrsets-values-alias-evaluate-target-health).
	EvaluateTargetHealth pulumi.BoolInput `pulumi:"evaluateTargetHealth"`
	// DNS domain name for a CloudFront distribution, S3 bucket, ELB, or another resource record set in this hosted zone.
	Name pulumi.StringInput `pulumi:"name"`
	// Hosted zone ID for a CloudFront distribution, S3 bucket, ELB, or Route 53 hosted zone. See [`resource_elb.zone_id`](https://www.terraform.io/docs/providers/aws/r/elb.html#zone_id) for example.
	ZoneId pulumi.StringInput `pulumi:"zoneId"`
}

func (RecordAliasArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*RecordAlias)(nil)).Elem()
}

func (i RecordAliasArgs) ToRecordAliasOutput() RecordAliasOutput {
	return i.ToRecordAliasOutputWithContext(context.Background())
}

func (i RecordAliasArgs) ToRecordAliasOutputWithContext(ctx context.Context) RecordAliasOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RecordAliasOutput)
}

type RecordAliasArrayInput interface {
	pulumi.Input

	ToRecordAliasArrayOutput() RecordAliasArrayOutput
	ToRecordAliasArrayOutputWithContext(context.Context) RecordAliasArrayOutput
}

type RecordAliasArray []RecordAliasInput

func (RecordAliasArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]RecordAlias)(nil)).Elem()
}

func (i RecordAliasArray) ToRecordAliasArrayOutput() RecordAliasArrayOutput {
	return i.ToRecordAliasArrayOutputWithContext(context.Background())
}

func (i RecordAliasArray) ToRecordAliasArrayOutputWithContext(ctx context.Context) RecordAliasArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RecordAliasArrayOutput)
}

type RecordAliasOutput struct { *pulumi.OutputState }

func (RecordAliasOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*RecordAlias)(nil)).Elem()
}

func (o RecordAliasOutput) ToRecordAliasOutput() RecordAliasOutput {
	return o
}

func (o RecordAliasOutput) ToRecordAliasOutputWithContext(ctx context.Context) RecordAliasOutput {
	return o
}

// Set to `true` if you want Route 53 to determine whether to respond to DNS queries using this resource record set by checking the health of the resource record set. Some resources have special requirements, see [related part of documentation](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/resource-record-sets-values.html#rrsets-values-alias-evaluate-target-health).
func (o RecordAliasOutput) EvaluateTargetHealth() pulumi.BoolOutput {
	return o.ApplyT(func (v RecordAlias) bool { return v.EvaluateTargetHealth }).(pulumi.BoolOutput)
}

// DNS domain name for a CloudFront distribution, S3 bucket, ELB, or another resource record set in this hosted zone.
func (o RecordAliasOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func (v RecordAlias) string { return v.Name }).(pulumi.StringOutput)
}

// Hosted zone ID for a CloudFront distribution, S3 bucket, ELB, or Route 53 hosted zone. See [`resource_elb.zone_id`](https://www.terraform.io/docs/providers/aws/r/elb.html#zone_id) for example.
func (o RecordAliasOutput) ZoneId() pulumi.StringOutput {
	return o.ApplyT(func (v RecordAlias) string { return v.ZoneId }).(pulumi.StringOutput)
}

type RecordAliasArrayOutput struct { *pulumi.OutputState}

func (RecordAliasArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]RecordAlias)(nil)).Elem()
}

func (o RecordAliasArrayOutput) ToRecordAliasArrayOutput() RecordAliasArrayOutput {
	return o
}

func (o RecordAliasArrayOutput) ToRecordAliasArrayOutputWithContext(ctx context.Context) RecordAliasArrayOutput {
	return o
}

func (o RecordAliasArrayOutput) Index(i pulumi.IntInput) RecordAliasOutput {
	return pulumi.All(o, i).ApplyT(func (vs []interface{}) RecordAlias {
		return vs[0].([]RecordAlias)[vs[1].(int)]
	}).(RecordAliasOutput)
}

type RecordFailoverRoutingPolicy struct {
	// `PRIMARY` or `SECONDARY`. A `PRIMARY` record will be served if its healthcheck is passing, otherwise the `SECONDARY` will be served. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-configuring-options.html#dns-failover-failover-rrsets
	Type string `pulumi:"type"`
}

type RecordFailoverRoutingPolicyInput interface {
	pulumi.Input

	ToRecordFailoverRoutingPolicyOutput() RecordFailoverRoutingPolicyOutput
	ToRecordFailoverRoutingPolicyOutputWithContext(context.Context) RecordFailoverRoutingPolicyOutput
}

type RecordFailoverRoutingPolicyArgs struct {
	// `PRIMARY` or `SECONDARY`. A `PRIMARY` record will be served if its healthcheck is passing, otherwise the `SECONDARY` will be served. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-configuring-options.html#dns-failover-failover-rrsets
	Type pulumi.StringInput `pulumi:"type"`
}

func (RecordFailoverRoutingPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*RecordFailoverRoutingPolicy)(nil)).Elem()
}

func (i RecordFailoverRoutingPolicyArgs) ToRecordFailoverRoutingPolicyOutput() RecordFailoverRoutingPolicyOutput {
	return i.ToRecordFailoverRoutingPolicyOutputWithContext(context.Background())
}

func (i RecordFailoverRoutingPolicyArgs) ToRecordFailoverRoutingPolicyOutputWithContext(ctx context.Context) RecordFailoverRoutingPolicyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RecordFailoverRoutingPolicyOutput)
}

type RecordFailoverRoutingPolicyArrayInput interface {
	pulumi.Input

	ToRecordFailoverRoutingPolicyArrayOutput() RecordFailoverRoutingPolicyArrayOutput
	ToRecordFailoverRoutingPolicyArrayOutputWithContext(context.Context) RecordFailoverRoutingPolicyArrayOutput
}

type RecordFailoverRoutingPolicyArray []RecordFailoverRoutingPolicyInput

func (RecordFailoverRoutingPolicyArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]RecordFailoverRoutingPolicy)(nil)).Elem()
}

func (i RecordFailoverRoutingPolicyArray) ToRecordFailoverRoutingPolicyArrayOutput() RecordFailoverRoutingPolicyArrayOutput {
	return i.ToRecordFailoverRoutingPolicyArrayOutputWithContext(context.Background())
}

func (i RecordFailoverRoutingPolicyArray) ToRecordFailoverRoutingPolicyArrayOutputWithContext(ctx context.Context) RecordFailoverRoutingPolicyArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RecordFailoverRoutingPolicyArrayOutput)
}

type RecordFailoverRoutingPolicyOutput struct { *pulumi.OutputState }

func (RecordFailoverRoutingPolicyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*RecordFailoverRoutingPolicy)(nil)).Elem()
}

func (o RecordFailoverRoutingPolicyOutput) ToRecordFailoverRoutingPolicyOutput() RecordFailoverRoutingPolicyOutput {
	return o
}

func (o RecordFailoverRoutingPolicyOutput) ToRecordFailoverRoutingPolicyOutputWithContext(ctx context.Context) RecordFailoverRoutingPolicyOutput {
	return o
}

// `PRIMARY` or `SECONDARY`. A `PRIMARY` record will be served if its healthcheck is passing, otherwise the `SECONDARY` will be served. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-configuring-options.html#dns-failover-failover-rrsets
func (o RecordFailoverRoutingPolicyOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func (v RecordFailoverRoutingPolicy) string { return v.Type }).(pulumi.StringOutput)
}

type RecordFailoverRoutingPolicyArrayOutput struct { *pulumi.OutputState}

func (RecordFailoverRoutingPolicyArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]RecordFailoverRoutingPolicy)(nil)).Elem()
}

func (o RecordFailoverRoutingPolicyArrayOutput) ToRecordFailoverRoutingPolicyArrayOutput() RecordFailoverRoutingPolicyArrayOutput {
	return o
}

func (o RecordFailoverRoutingPolicyArrayOutput) ToRecordFailoverRoutingPolicyArrayOutputWithContext(ctx context.Context) RecordFailoverRoutingPolicyArrayOutput {
	return o
}

func (o RecordFailoverRoutingPolicyArrayOutput) Index(i pulumi.IntInput) RecordFailoverRoutingPolicyOutput {
	return pulumi.All(o, i).ApplyT(func (vs []interface{}) RecordFailoverRoutingPolicy {
		return vs[0].([]RecordFailoverRoutingPolicy)[vs[1].(int)]
	}).(RecordFailoverRoutingPolicyOutput)
}

type RecordGeolocationRoutingPolicy struct {
	// A two-letter continent code. See http://docs.aws.amazon.com/Route53/latest/APIReference/API_GetGeoLocation.html for code details. Either `continent` or `country` must be specified.
	Continent *string `pulumi:"continent"`
	// A two-character country code or `*` to indicate a default resource record set.
	Country *string `pulumi:"country"`
	// A subdivision code for a country.
	Subdivision *string `pulumi:"subdivision"`
}

type RecordGeolocationRoutingPolicyInput interface {
	pulumi.Input

	ToRecordGeolocationRoutingPolicyOutput() RecordGeolocationRoutingPolicyOutput
	ToRecordGeolocationRoutingPolicyOutputWithContext(context.Context) RecordGeolocationRoutingPolicyOutput
}

type RecordGeolocationRoutingPolicyArgs struct {
	// A two-letter continent code. See http://docs.aws.amazon.com/Route53/latest/APIReference/API_GetGeoLocation.html for code details. Either `continent` or `country` must be specified.
	Continent pulumi.StringPtrInput `pulumi:"continent"`
	// A two-character country code or `*` to indicate a default resource record set.
	Country pulumi.StringPtrInput `pulumi:"country"`
	// A subdivision code for a country.
	Subdivision pulumi.StringPtrInput `pulumi:"subdivision"`
}

func (RecordGeolocationRoutingPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*RecordGeolocationRoutingPolicy)(nil)).Elem()
}

func (i RecordGeolocationRoutingPolicyArgs) ToRecordGeolocationRoutingPolicyOutput() RecordGeolocationRoutingPolicyOutput {
	return i.ToRecordGeolocationRoutingPolicyOutputWithContext(context.Background())
}

func (i RecordGeolocationRoutingPolicyArgs) ToRecordGeolocationRoutingPolicyOutputWithContext(ctx context.Context) RecordGeolocationRoutingPolicyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RecordGeolocationRoutingPolicyOutput)
}

type RecordGeolocationRoutingPolicyArrayInput interface {
	pulumi.Input

	ToRecordGeolocationRoutingPolicyArrayOutput() RecordGeolocationRoutingPolicyArrayOutput
	ToRecordGeolocationRoutingPolicyArrayOutputWithContext(context.Context) RecordGeolocationRoutingPolicyArrayOutput
}

type RecordGeolocationRoutingPolicyArray []RecordGeolocationRoutingPolicyInput

func (RecordGeolocationRoutingPolicyArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]RecordGeolocationRoutingPolicy)(nil)).Elem()
}

func (i RecordGeolocationRoutingPolicyArray) ToRecordGeolocationRoutingPolicyArrayOutput() RecordGeolocationRoutingPolicyArrayOutput {
	return i.ToRecordGeolocationRoutingPolicyArrayOutputWithContext(context.Background())
}

func (i RecordGeolocationRoutingPolicyArray) ToRecordGeolocationRoutingPolicyArrayOutputWithContext(ctx context.Context) RecordGeolocationRoutingPolicyArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RecordGeolocationRoutingPolicyArrayOutput)
}

type RecordGeolocationRoutingPolicyOutput struct { *pulumi.OutputState }

func (RecordGeolocationRoutingPolicyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*RecordGeolocationRoutingPolicy)(nil)).Elem()
}

func (o RecordGeolocationRoutingPolicyOutput) ToRecordGeolocationRoutingPolicyOutput() RecordGeolocationRoutingPolicyOutput {
	return o
}

func (o RecordGeolocationRoutingPolicyOutput) ToRecordGeolocationRoutingPolicyOutputWithContext(ctx context.Context) RecordGeolocationRoutingPolicyOutput {
	return o
}

// A two-letter continent code. See http://docs.aws.amazon.com/Route53/latest/APIReference/API_GetGeoLocation.html for code details. Either `continent` or `country` must be specified.
func (o RecordGeolocationRoutingPolicyOutput) Continent() pulumi.StringPtrOutput {
	return o.ApplyT(func (v RecordGeolocationRoutingPolicy) *string { return v.Continent }).(pulumi.StringPtrOutput)
}

// A two-character country code or `*` to indicate a default resource record set.
func (o RecordGeolocationRoutingPolicyOutput) Country() pulumi.StringPtrOutput {
	return o.ApplyT(func (v RecordGeolocationRoutingPolicy) *string { return v.Country }).(pulumi.StringPtrOutput)
}

// A subdivision code for a country.
func (o RecordGeolocationRoutingPolicyOutput) Subdivision() pulumi.StringPtrOutput {
	return o.ApplyT(func (v RecordGeolocationRoutingPolicy) *string { return v.Subdivision }).(pulumi.StringPtrOutput)
}

type RecordGeolocationRoutingPolicyArrayOutput struct { *pulumi.OutputState}

func (RecordGeolocationRoutingPolicyArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]RecordGeolocationRoutingPolicy)(nil)).Elem()
}

func (o RecordGeolocationRoutingPolicyArrayOutput) ToRecordGeolocationRoutingPolicyArrayOutput() RecordGeolocationRoutingPolicyArrayOutput {
	return o
}

func (o RecordGeolocationRoutingPolicyArrayOutput) ToRecordGeolocationRoutingPolicyArrayOutputWithContext(ctx context.Context) RecordGeolocationRoutingPolicyArrayOutput {
	return o
}

func (o RecordGeolocationRoutingPolicyArrayOutput) Index(i pulumi.IntInput) RecordGeolocationRoutingPolicyOutput {
	return pulumi.All(o, i).ApplyT(func (vs []interface{}) RecordGeolocationRoutingPolicy {
		return vs[0].([]RecordGeolocationRoutingPolicy)[vs[1].(int)]
	}).(RecordGeolocationRoutingPolicyOutput)
}

type RecordLatencyRoutingPolicy struct {
	// An AWS region from which to measure latency. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-policy-latency
	Region string `pulumi:"region"`
}

type RecordLatencyRoutingPolicyInput interface {
	pulumi.Input

	ToRecordLatencyRoutingPolicyOutput() RecordLatencyRoutingPolicyOutput
	ToRecordLatencyRoutingPolicyOutputWithContext(context.Context) RecordLatencyRoutingPolicyOutput
}

type RecordLatencyRoutingPolicyArgs struct {
	// An AWS region from which to measure latency. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-policy-latency
	Region pulumi.StringInput `pulumi:"region"`
}

func (RecordLatencyRoutingPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*RecordLatencyRoutingPolicy)(nil)).Elem()
}

func (i RecordLatencyRoutingPolicyArgs) ToRecordLatencyRoutingPolicyOutput() RecordLatencyRoutingPolicyOutput {
	return i.ToRecordLatencyRoutingPolicyOutputWithContext(context.Background())
}

func (i RecordLatencyRoutingPolicyArgs) ToRecordLatencyRoutingPolicyOutputWithContext(ctx context.Context) RecordLatencyRoutingPolicyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RecordLatencyRoutingPolicyOutput)
}

type RecordLatencyRoutingPolicyArrayInput interface {
	pulumi.Input

	ToRecordLatencyRoutingPolicyArrayOutput() RecordLatencyRoutingPolicyArrayOutput
	ToRecordLatencyRoutingPolicyArrayOutputWithContext(context.Context) RecordLatencyRoutingPolicyArrayOutput
}

type RecordLatencyRoutingPolicyArray []RecordLatencyRoutingPolicyInput

func (RecordLatencyRoutingPolicyArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]RecordLatencyRoutingPolicy)(nil)).Elem()
}

func (i RecordLatencyRoutingPolicyArray) ToRecordLatencyRoutingPolicyArrayOutput() RecordLatencyRoutingPolicyArrayOutput {
	return i.ToRecordLatencyRoutingPolicyArrayOutputWithContext(context.Background())
}

func (i RecordLatencyRoutingPolicyArray) ToRecordLatencyRoutingPolicyArrayOutputWithContext(ctx context.Context) RecordLatencyRoutingPolicyArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RecordLatencyRoutingPolicyArrayOutput)
}

type RecordLatencyRoutingPolicyOutput struct { *pulumi.OutputState }

func (RecordLatencyRoutingPolicyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*RecordLatencyRoutingPolicy)(nil)).Elem()
}

func (o RecordLatencyRoutingPolicyOutput) ToRecordLatencyRoutingPolicyOutput() RecordLatencyRoutingPolicyOutput {
	return o
}

func (o RecordLatencyRoutingPolicyOutput) ToRecordLatencyRoutingPolicyOutputWithContext(ctx context.Context) RecordLatencyRoutingPolicyOutput {
	return o
}

// An AWS region from which to measure latency. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-policy-latency
func (o RecordLatencyRoutingPolicyOutput) Region() pulumi.StringOutput {
	return o.ApplyT(func (v RecordLatencyRoutingPolicy) string { return v.Region }).(pulumi.StringOutput)
}

type RecordLatencyRoutingPolicyArrayOutput struct { *pulumi.OutputState}

func (RecordLatencyRoutingPolicyArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]RecordLatencyRoutingPolicy)(nil)).Elem()
}

func (o RecordLatencyRoutingPolicyArrayOutput) ToRecordLatencyRoutingPolicyArrayOutput() RecordLatencyRoutingPolicyArrayOutput {
	return o
}

func (o RecordLatencyRoutingPolicyArrayOutput) ToRecordLatencyRoutingPolicyArrayOutputWithContext(ctx context.Context) RecordLatencyRoutingPolicyArrayOutput {
	return o
}

func (o RecordLatencyRoutingPolicyArrayOutput) Index(i pulumi.IntInput) RecordLatencyRoutingPolicyOutput {
	return pulumi.All(o, i).ApplyT(func (vs []interface{}) RecordLatencyRoutingPolicy {
		return vs[0].([]RecordLatencyRoutingPolicy)[vs[1].(int)]
	}).(RecordLatencyRoutingPolicyOutput)
}

type RecordWeightedRoutingPolicy struct {
	// A numeric value indicating the relative weight of the record. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-policy-weighted.
	Weight int `pulumi:"weight"`
}

type RecordWeightedRoutingPolicyInput interface {
	pulumi.Input

	ToRecordWeightedRoutingPolicyOutput() RecordWeightedRoutingPolicyOutput
	ToRecordWeightedRoutingPolicyOutputWithContext(context.Context) RecordWeightedRoutingPolicyOutput
}

type RecordWeightedRoutingPolicyArgs struct {
	// A numeric value indicating the relative weight of the record. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-policy-weighted.
	Weight pulumi.IntInput `pulumi:"weight"`
}

func (RecordWeightedRoutingPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*RecordWeightedRoutingPolicy)(nil)).Elem()
}

func (i RecordWeightedRoutingPolicyArgs) ToRecordWeightedRoutingPolicyOutput() RecordWeightedRoutingPolicyOutput {
	return i.ToRecordWeightedRoutingPolicyOutputWithContext(context.Background())
}

func (i RecordWeightedRoutingPolicyArgs) ToRecordWeightedRoutingPolicyOutputWithContext(ctx context.Context) RecordWeightedRoutingPolicyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RecordWeightedRoutingPolicyOutput)
}

type RecordWeightedRoutingPolicyArrayInput interface {
	pulumi.Input

	ToRecordWeightedRoutingPolicyArrayOutput() RecordWeightedRoutingPolicyArrayOutput
	ToRecordWeightedRoutingPolicyArrayOutputWithContext(context.Context) RecordWeightedRoutingPolicyArrayOutput
}

type RecordWeightedRoutingPolicyArray []RecordWeightedRoutingPolicyInput

func (RecordWeightedRoutingPolicyArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]RecordWeightedRoutingPolicy)(nil)).Elem()
}

func (i RecordWeightedRoutingPolicyArray) ToRecordWeightedRoutingPolicyArrayOutput() RecordWeightedRoutingPolicyArrayOutput {
	return i.ToRecordWeightedRoutingPolicyArrayOutputWithContext(context.Background())
}

func (i RecordWeightedRoutingPolicyArray) ToRecordWeightedRoutingPolicyArrayOutputWithContext(ctx context.Context) RecordWeightedRoutingPolicyArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RecordWeightedRoutingPolicyArrayOutput)
}

type RecordWeightedRoutingPolicyOutput struct { *pulumi.OutputState }

func (RecordWeightedRoutingPolicyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*RecordWeightedRoutingPolicy)(nil)).Elem()
}

func (o RecordWeightedRoutingPolicyOutput) ToRecordWeightedRoutingPolicyOutput() RecordWeightedRoutingPolicyOutput {
	return o
}

func (o RecordWeightedRoutingPolicyOutput) ToRecordWeightedRoutingPolicyOutputWithContext(ctx context.Context) RecordWeightedRoutingPolicyOutput {
	return o
}

// A numeric value indicating the relative weight of the record. See http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy.html#routing-policy-weighted.
func (o RecordWeightedRoutingPolicyOutput) Weight() pulumi.IntOutput {
	return o.ApplyT(func (v RecordWeightedRoutingPolicy) int { return v.Weight }).(pulumi.IntOutput)
}

type RecordWeightedRoutingPolicyArrayOutput struct { *pulumi.OutputState}

func (RecordWeightedRoutingPolicyArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]RecordWeightedRoutingPolicy)(nil)).Elem()
}

func (o RecordWeightedRoutingPolicyArrayOutput) ToRecordWeightedRoutingPolicyArrayOutput() RecordWeightedRoutingPolicyArrayOutput {
	return o
}

func (o RecordWeightedRoutingPolicyArrayOutput) ToRecordWeightedRoutingPolicyArrayOutputWithContext(ctx context.Context) RecordWeightedRoutingPolicyArrayOutput {
	return o
}

func (o RecordWeightedRoutingPolicyArrayOutput) Index(i pulumi.IntInput) RecordWeightedRoutingPolicyOutput {
	return pulumi.All(o, i).ApplyT(func (vs []interface{}) RecordWeightedRoutingPolicy {
		return vs[0].([]RecordWeightedRoutingPolicy)[vs[1].(int)]
	}).(RecordWeightedRoutingPolicyOutput)
}

type ResolverEndpointIpAddress struct {
	// The IP address in the subnet that you want to use for DNS queries.
	Ip *string `pulumi:"ip"`
	IpId *string `pulumi:"ipId"`
	// The ID of the subnet that contains the IP address.
	SubnetId string `pulumi:"subnetId"`
}

type ResolverEndpointIpAddressInput interface {
	pulumi.Input

	ToResolverEndpointIpAddressOutput() ResolverEndpointIpAddressOutput
	ToResolverEndpointIpAddressOutputWithContext(context.Context) ResolverEndpointIpAddressOutput
}

type ResolverEndpointIpAddressArgs struct {
	// The IP address in the subnet that you want to use for DNS queries.
	Ip pulumi.StringPtrInput `pulumi:"ip"`
	IpId pulumi.StringPtrInput `pulumi:"ipId"`
	// The ID of the subnet that contains the IP address.
	SubnetId pulumi.StringInput `pulumi:"subnetId"`
}

func (ResolverEndpointIpAddressArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ResolverEndpointIpAddress)(nil)).Elem()
}

func (i ResolverEndpointIpAddressArgs) ToResolverEndpointIpAddressOutput() ResolverEndpointIpAddressOutput {
	return i.ToResolverEndpointIpAddressOutputWithContext(context.Background())
}

func (i ResolverEndpointIpAddressArgs) ToResolverEndpointIpAddressOutputWithContext(ctx context.Context) ResolverEndpointIpAddressOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ResolverEndpointIpAddressOutput)
}

type ResolverEndpointIpAddressArrayInput interface {
	pulumi.Input

	ToResolverEndpointIpAddressArrayOutput() ResolverEndpointIpAddressArrayOutput
	ToResolverEndpointIpAddressArrayOutputWithContext(context.Context) ResolverEndpointIpAddressArrayOutput
}

type ResolverEndpointIpAddressArray []ResolverEndpointIpAddressInput

func (ResolverEndpointIpAddressArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ResolverEndpointIpAddress)(nil)).Elem()
}

func (i ResolverEndpointIpAddressArray) ToResolverEndpointIpAddressArrayOutput() ResolverEndpointIpAddressArrayOutput {
	return i.ToResolverEndpointIpAddressArrayOutputWithContext(context.Background())
}

func (i ResolverEndpointIpAddressArray) ToResolverEndpointIpAddressArrayOutputWithContext(ctx context.Context) ResolverEndpointIpAddressArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ResolverEndpointIpAddressArrayOutput)
}

type ResolverEndpointIpAddressOutput struct { *pulumi.OutputState }

func (ResolverEndpointIpAddressOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ResolverEndpointIpAddress)(nil)).Elem()
}

func (o ResolverEndpointIpAddressOutput) ToResolverEndpointIpAddressOutput() ResolverEndpointIpAddressOutput {
	return o
}

func (o ResolverEndpointIpAddressOutput) ToResolverEndpointIpAddressOutputWithContext(ctx context.Context) ResolverEndpointIpAddressOutput {
	return o
}

// The IP address in the subnet that you want to use for DNS queries.
func (o ResolverEndpointIpAddressOutput) Ip() pulumi.StringPtrOutput {
	return o.ApplyT(func (v ResolverEndpointIpAddress) *string { return v.Ip }).(pulumi.StringPtrOutput)
}

func (o ResolverEndpointIpAddressOutput) IpId() pulumi.StringPtrOutput {
	return o.ApplyT(func (v ResolverEndpointIpAddress) *string { return v.IpId }).(pulumi.StringPtrOutput)
}

// The ID of the subnet that contains the IP address.
func (o ResolverEndpointIpAddressOutput) SubnetId() pulumi.StringOutput {
	return o.ApplyT(func (v ResolverEndpointIpAddress) string { return v.SubnetId }).(pulumi.StringOutput)
}

type ResolverEndpointIpAddressArrayOutput struct { *pulumi.OutputState}

func (ResolverEndpointIpAddressArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ResolverEndpointIpAddress)(nil)).Elem()
}

func (o ResolverEndpointIpAddressArrayOutput) ToResolverEndpointIpAddressArrayOutput() ResolverEndpointIpAddressArrayOutput {
	return o
}

func (o ResolverEndpointIpAddressArrayOutput) ToResolverEndpointIpAddressArrayOutputWithContext(ctx context.Context) ResolverEndpointIpAddressArrayOutput {
	return o
}

func (o ResolverEndpointIpAddressArrayOutput) Index(i pulumi.IntInput) ResolverEndpointIpAddressOutput {
	return pulumi.All(o, i).ApplyT(func (vs []interface{}) ResolverEndpointIpAddress {
		return vs[0].([]ResolverEndpointIpAddress)[vs[1].(int)]
	}).(ResolverEndpointIpAddressOutput)
}

type ResolverRuleTargetIp struct {
	// One IP address that you want to forward DNS queries to. You can specify only IPv4 addresses.
	Ip string `pulumi:"ip"`
	// The port at `ip` that you want to forward DNS queries to. Default value is `53`
	Port *int `pulumi:"port"`
}

type ResolverRuleTargetIpInput interface {
	pulumi.Input

	ToResolverRuleTargetIpOutput() ResolverRuleTargetIpOutput
	ToResolverRuleTargetIpOutputWithContext(context.Context) ResolverRuleTargetIpOutput
}

type ResolverRuleTargetIpArgs struct {
	// One IP address that you want to forward DNS queries to. You can specify only IPv4 addresses.
	Ip pulumi.StringInput `pulumi:"ip"`
	// The port at `ip` that you want to forward DNS queries to. Default value is `53`
	Port pulumi.IntPtrInput `pulumi:"port"`
}

func (ResolverRuleTargetIpArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ResolverRuleTargetIp)(nil)).Elem()
}

func (i ResolverRuleTargetIpArgs) ToResolverRuleTargetIpOutput() ResolverRuleTargetIpOutput {
	return i.ToResolverRuleTargetIpOutputWithContext(context.Background())
}

func (i ResolverRuleTargetIpArgs) ToResolverRuleTargetIpOutputWithContext(ctx context.Context) ResolverRuleTargetIpOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ResolverRuleTargetIpOutput)
}

type ResolverRuleTargetIpArrayInput interface {
	pulumi.Input

	ToResolverRuleTargetIpArrayOutput() ResolverRuleTargetIpArrayOutput
	ToResolverRuleTargetIpArrayOutputWithContext(context.Context) ResolverRuleTargetIpArrayOutput
}

type ResolverRuleTargetIpArray []ResolverRuleTargetIpInput

func (ResolverRuleTargetIpArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ResolverRuleTargetIp)(nil)).Elem()
}

func (i ResolverRuleTargetIpArray) ToResolverRuleTargetIpArrayOutput() ResolverRuleTargetIpArrayOutput {
	return i.ToResolverRuleTargetIpArrayOutputWithContext(context.Background())
}

func (i ResolverRuleTargetIpArray) ToResolverRuleTargetIpArrayOutputWithContext(ctx context.Context) ResolverRuleTargetIpArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ResolverRuleTargetIpArrayOutput)
}

type ResolverRuleTargetIpOutput struct { *pulumi.OutputState }

func (ResolverRuleTargetIpOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ResolverRuleTargetIp)(nil)).Elem()
}

func (o ResolverRuleTargetIpOutput) ToResolverRuleTargetIpOutput() ResolverRuleTargetIpOutput {
	return o
}

func (o ResolverRuleTargetIpOutput) ToResolverRuleTargetIpOutputWithContext(ctx context.Context) ResolverRuleTargetIpOutput {
	return o
}

// One IP address that you want to forward DNS queries to. You can specify only IPv4 addresses.
func (o ResolverRuleTargetIpOutput) Ip() pulumi.StringOutput {
	return o.ApplyT(func (v ResolverRuleTargetIp) string { return v.Ip }).(pulumi.StringOutput)
}

// The port at `ip` that you want to forward DNS queries to. Default value is `53`
func (o ResolverRuleTargetIpOutput) Port() pulumi.IntPtrOutput {
	return o.ApplyT(func (v ResolverRuleTargetIp) *int { return v.Port }).(pulumi.IntPtrOutput)
}

type ResolverRuleTargetIpArrayOutput struct { *pulumi.OutputState}

func (ResolverRuleTargetIpArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ResolverRuleTargetIp)(nil)).Elem()
}

func (o ResolverRuleTargetIpArrayOutput) ToResolverRuleTargetIpArrayOutput() ResolverRuleTargetIpArrayOutput {
	return o
}

func (o ResolverRuleTargetIpArrayOutput) ToResolverRuleTargetIpArrayOutputWithContext(ctx context.Context) ResolverRuleTargetIpArrayOutput {
	return o
}

func (o ResolverRuleTargetIpArrayOutput) Index(i pulumi.IntInput) ResolverRuleTargetIpOutput {
	return pulumi.All(o, i).ApplyT(func (vs []interface{}) ResolverRuleTargetIp {
		return vs[0].([]ResolverRuleTargetIp)[vs[1].(int)]
	}).(ResolverRuleTargetIpOutput)
}

type ZoneVpc struct {
	// ID of the VPC to associate.
	VpcId string `pulumi:"vpcId"`
	// Region of the VPC to associate. Defaults to AWS provider region.
	VpcRegion *string `pulumi:"vpcRegion"`
}

type ZoneVpcInput interface {
	pulumi.Input

	ToZoneVpcOutput() ZoneVpcOutput
	ToZoneVpcOutputWithContext(context.Context) ZoneVpcOutput
}

type ZoneVpcArgs struct {
	// ID of the VPC to associate.
	VpcId pulumi.StringInput `pulumi:"vpcId"`
	// Region of the VPC to associate. Defaults to AWS provider region.
	VpcRegion pulumi.StringPtrInput `pulumi:"vpcRegion"`
}

func (ZoneVpcArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ZoneVpc)(nil)).Elem()
}

func (i ZoneVpcArgs) ToZoneVpcOutput() ZoneVpcOutput {
	return i.ToZoneVpcOutputWithContext(context.Background())
}

func (i ZoneVpcArgs) ToZoneVpcOutputWithContext(ctx context.Context) ZoneVpcOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ZoneVpcOutput)
}

type ZoneVpcArrayInput interface {
	pulumi.Input

	ToZoneVpcArrayOutput() ZoneVpcArrayOutput
	ToZoneVpcArrayOutputWithContext(context.Context) ZoneVpcArrayOutput
}

type ZoneVpcArray []ZoneVpcInput

func (ZoneVpcArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ZoneVpc)(nil)).Elem()
}

func (i ZoneVpcArray) ToZoneVpcArrayOutput() ZoneVpcArrayOutput {
	return i.ToZoneVpcArrayOutputWithContext(context.Background())
}

func (i ZoneVpcArray) ToZoneVpcArrayOutputWithContext(ctx context.Context) ZoneVpcArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ZoneVpcArrayOutput)
}

type ZoneVpcOutput struct { *pulumi.OutputState }

func (ZoneVpcOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ZoneVpc)(nil)).Elem()
}

func (o ZoneVpcOutput) ToZoneVpcOutput() ZoneVpcOutput {
	return o
}

func (o ZoneVpcOutput) ToZoneVpcOutputWithContext(ctx context.Context) ZoneVpcOutput {
	return o
}

// ID of the VPC to associate.
func (o ZoneVpcOutput) VpcId() pulumi.StringOutput {
	return o.ApplyT(func (v ZoneVpc) string { return v.VpcId }).(pulumi.StringOutput)
}

// Region of the VPC to associate. Defaults to AWS provider region.
func (o ZoneVpcOutput) VpcRegion() pulumi.StringPtrOutput {
	return o.ApplyT(func (v ZoneVpc) *string { return v.VpcRegion }).(pulumi.StringPtrOutput)
}

type ZoneVpcArrayOutput struct { *pulumi.OutputState}

func (ZoneVpcArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ZoneVpc)(nil)).Elem()
}

func (o ZoneVpcArrayOutput) ToZoneVpcArrayOutput() ZoneVpcArrayOutput {
	return o
}

func (o ZoneVpcArrayOutput) ToZoneVpcArrayOutputWithContext(ctx context.Context) ZoneVpcArrayOutput {
	return o
}

func (o ZoneVpcArrayOutput) Index(i pulumi.IntInput) ZoneVpcOutput {
	return pulumi.All(o, i).ApplyT(func (vs []interface{}) ZoneVpc {
		return vs[0].([]ZoneVpc)[vs[1].(int)]
	}).(ZoneVpcOutput)
}

func init() {
	pulumi.RegisterOutputType(RecordAliasOutput{})
	pulumi.RegisterOutputType(RecordAliasArrayOutput{})
	pulumi.RegisterOutputType(RecordFailoverRoutingPolicyOutput{})
	pulumi.RegisterOutputType(RecordFailoverRoutingPolicyArrayOutput{})
	pulumi.RegisterOutputType(RecordGeolocationRoutingPolicyOutput{})
	pulumi.RegisterOutputType(RecordGeolocationRoutingPolicyArrayOutput{})
	pulumi.RegisterOutputType(RecordLatencyRoutingPolicyOutput{})
	pulumi.RegisterOutputType(RecordLatencyRoutingPolicyArrayOutput{})
	pulumi.RegisterOutputType(RecordWeightedRoutingPolicyOutput{})
	pulumi.RegisterOutputType(RecordWeightedRoutingPolicyArrayOutput{})
	pulumi.RegisterOutputType(ResolverEndpointIpAddressOutput{})
	pulumi.RegisterOutputType(ResolverEndpointIpAddressArrayOutput{})
	pulumi.RegisterOutputType(ResolverRuleTargetIpOutput{})
	pulumi.RegisterOutputType(ResolverRuleTargetIpArrayOutput{})
	pulumi.RegisterOutputType(ZoneVpcOutput{})
	pulumi.RegisterOutputType(ZoneVpcArrayOutput{})
}
