// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package elasticloadbalancingv2

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Target Group resource for use with Load Balancer resources.
// 
// > **Note:** `alb.TargetGroup` is known as `lb.TargetGroup`. The functionality is identical.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/lb_target_group_legacy.html.markdown.
type TargetGroup struct {
	s *pulumi.ResourceState
}

// NewTargetGroup registers a new resource with the given unique name, arguments, and options.
func NewTargetGroup(ctx *pulumi.Context,
	name string, args *TargetGroupArgs, opts ...pulumi.ResourceOpt) (*TargetGroup, error) {
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["deregistrationDelay"] = nil
		inputs["healthCheck"] = nil
		inputs["lambdaMultiValueHeadersEnabled"] = nil
		inputs["name"] = nil
		inputs["namePrefix"] = nil
		inputs["port"] = nil
		inputs["protocol"] = nil
		inputs["proxyProtocolV2"] = nil
		inputs["slowStart"] = nil
		inputs["stickiness"] = nil
		inputs["tags"] = nil
		inputs["targetType"] = nil
		inputs["vpcId"] = nil
	} else {
		inputs["deregistrationDelay"] = args.DeregistrationDelay
		inputs["healthCheck"] = args.HealthCheck
		inputs["lambdaMultiValueHeadersEnabled"] = args.LambdaMultiValueHeadersEnabled
		inputs["name"] = args.Name
		inputs["namePrefix"] = args.NamePrefix
		inputs["port"] = args.Port
		inputs["protocol"] = args.Protocol
		inputs["proxyProtocolV2"] = args.ProxyProtocolV2
		inputs["slowStart"] = args.SlowStart
		inputs["stickiness"] = args.Stickiness
		inputs["tags"] = args.Tags
		inputs["targetType"] = args.TargetType
		inputs["vpcId"] = args.VpcId
	}
	inputs["arn"] = nil
	inputs["arnSuffix"] = nil
	s, err := ctx.RegisterResource("aws:elasticloadbalancingv2/targetGroup:TargetGroup", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &TargetGroup{s: s}, nil
}

// GetTargetGroup gets an existing TargetGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTargetGroup(ctx *pulumi.Context,
	name string, id pulumi.ID, state *TargetGroupState, opts ...pulumi.ResourceOpt) (*TargetGroup, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["arn"] = state.Arn
		inputs["arnSuffix"] = state.ArnSuffix
		inputs["deregistrationDelay"] = state.DeregistrationDelay
		inputs["healthCheck"] = state.HealthCheck
		inputs["lambdaMultiValueHeadersEnabled"] = state.LambdaMultiValueHeadersEnabled
		inputs["name"] = state.Name
		inputs["namePrefix"] = state.NamePrefix
		inputs["port"] = state.Port
		inputs["protocol"] = state.Protocol
		inputs["proxyProtocolV2"] = state.ProxyProtocolV2
		inputs["slowStart"] = state.SlowStart
		inputs["stickiness"] = state.Stickiness
		inputs["tags"] = state.Tags
		inputs["targetType"] = state.TargetType
		inputs["vpcId"] = state.VpcId
	}
	s, err := ctx.ReadResource("aws:elasticloadbalancingv2/targetGroup:TargetGroup", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &TargetGroup{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *TargetGroup) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *TargetGroup) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// The ARN of the Target Group (matches `id`)
func (r *TargetGroup) Arn() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["arn"])
}

// The ARN suffix for use with CloudWatch Metrics.
func (r *TargetGroup) ArnSuffix() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["arnSuffix"])
}

// The amount time for Elastic Load Balancing to wait before changing the state of a deregistering target from draining to unused. The range is 0-3600 seconds. The default value is 300 seconds.
func (r *TargetGroup) DeregistrationDelay() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["deregistrationDelay"])
}

// A Health Check block. Health Check blocks are documented below.
func (r *TargetGroup) HealthCheck() *pulumi.Output {
	return r.s.State["healthCheck"]
}

// Boolean whether the request and response headers exchanged between the load balancer and the Lambda function include arrays of values or strings. Only applies when `targetType` is `lambda`.
func (r *TargetGroup) LambdaMultiValueHeadersEnabled() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["lambdaMultiValueHeadersEnabled"])
}

// The name of the target group. If omitted, this provider will assign a random, unique name.
func (r *TargetGroup) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// Creates a unique name beginning with the specified prefix. Conflicts with `name`. Cannot be longer than 6 characters.
func (r *TargetGroup) NamePrefix() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["namePrefix"])
}

// The port to use to connect with the target. Valid values are either ports 1-65536, or `traffic-port`. Defaults to `traffic-port`.
func (r *TargetGroup) Port() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["port"])
}

// The protocol to use to connect with the target. Defaults to `HTTP`. Not applicable when `targetType` is `lambda`.
func (r *TargetGroup) Protocol() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["protocol"])
}

// Boolean to enable / disable support for proxy protocol v2 on Network Load Balancers. See [doc](https://docs.aws.amazon.com/elasticloadbalancing/latest/network/load-balancer-target-groups.html#proxy-protocol) for more information.
func (r *TargetGroup) ProxyProtocolV2() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["proxyProtocolV2"])
}

// The amount time for targets to warm up before the load balancer sends them a full share of requests. The range is 30-900 seconds or 0 to disable. The default value is 0 seconds.
func (r *TargetGroup) SlowStart() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["slowStart"])
}

// A Stickiness block. Stickiness blocks are documented below. `stickiness` is only valid if used with Load Balancers of type `Application`
func (r *TargetGroup) Stickiness() *pulumi.Output {
	return r.s.State["stickiness"]
}

// A mapping of tags to assign to the resource.
func (r *TargetGroup) Tags() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["tags"])
}

// The type of target that you must specify when registering targets with this target group.
// The possible values are `instance` (targets are specified by instance ID) or `ip` (targets are specified by IP address) or `lambda` (targets are specified by lambda arn).
// The default is `instance`. Note that you can't specify targets for a target group using both instance IDs and IP addresses.
// If the target type is `ip`, specify IP addresses from the subnets of the virtual private cloud (VPC) for the target group,
// the RFC 1918 range (10.0.0.0/8, 172.16.0.0/12, and 192.168.0.0/16), and the RFC 6598 range (100.64.0.0/10).
// You can't specify publicly routable IP addresses.
func (r *TargetGroup) TargetType() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["targetType"])
}

// The identifier of the VPC in which to create the target group. Required when `targetType` is `instance` or `ip`. Does not apply when `targetType` is `lambda`.
func (r *TargetGroup) VpcId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["vpcId"])
}

// Input properties used for looking up and filtering TargetGroup resources.
type TargetGroupState struct {
	// The ARN of the Target Group (matches `id`)
	Arn interface{}
	// The ARN suffix for use with CloudWatch Metrics.
	ArnSuffix interface{}
	// The amount time for Elastic Load Balancing to wait before changing the state of a deregistering target from draining to unused. The range is 0-3600 seconds. The default value is 300 seconds.
	DeregistrationDelay interface{}
	// A Health Check block. Health Check blocks are documented below.
	HealthCheck interface{}
	// Boolean whether the request and response headers exchanged between the load balancer and the Lambda function include arrays of values or strings. Only applies when `targetType` is `lambda`.
	LambdaMultiValueHeadersEnabled interface{}
	// The name of the target group. If omitted, this provider will assign a random, unique name.
	Name interface{}
	// Creates a unique name beginning with the specified prefix. Conflicts with `name`. Cannot be longer than 6 characters.
	NamePrefix interface{}
	// The port to use to connect with the target. Valid values are either ports 1-65536, or `traffic-port`. Defaults to `traffic-port`.
	Port interface{}
	// The protocol to use to connect with the target. Defaults to `HTTP`. Not applicable when `targetType` is `lambda`.
	Protocol interface{}
	// Boolean to enable / disable support for proxy protocol v2 on Network Load Balancers. See [doc](https://docs.aws.amazon.com/elasticloadbalancing/latest/network/load-balancer-target-groups.html#proxy-protocol) for more information.
	ProxyProtocolV2 interface{}
	// The amount time for targets to warm up before the load balancer sends them a full share of requests. The range is 30-900 seconds or 0 to disable. The default value is 0 seconds.
	SlowStart interface{}
	// A Stickiness block. Stickiness blocks are documented below. `stickiness` is only valid if used with Load Balancers of type `Application`
	Stickiness interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
	// The type of target that you must specify when registering targets with this target group.
	// The possible values are `instance` (targets are specified by instance ID) or `ip` (targets are specified by IP address) or `lambda` (targets are specified by lambda arn).
	// The default is `instance`. Note that you can't specify targets for a target group using both instance IDs and IP addresses.
	// If the target type is `ip`, specify IP addresses from the subnets of the virtual private cloud (VPC) for the target group,
	// the RFC 1918 range (10.0.0.0/8, 172.16.0.0/12, and 192.168.0.0/16), and the RFC 6598 range (100.64.0.0/10).
	// You can't specify publicly routable IP addresses.
	TargetType interface{}
	// The identifier of the VPC in which to create the target group. Required when `targetType` is `instance` or `ip`. Does not apply when `targetType` is `lambda`.
	VpcId interface{}
}

// The set of arguments for constructing a TargetGroup resource.
type TargetGroupArgs struct {
	// The amount time for Elastic Load Balancing to wait before changing the state of a deregistering target from draining to unused. The range is 0-3600 seconds. The default value is 300 seconds.
	DeregistrationDelay interface{}
	// A Health Check block. Health Check blocks are documented below.
	HealthCheck interface{}
	// Boolean whether the request and response headers exchanged between the load balancer and the Lambda function include arrays of values or strings. Only applies when `targetType` is `lambda`.
	LambdaMultiValueHeadersEnabled interface{}
	// The name of the target group. If omitted, this provider will assign a random, unique name.
	Name interface{}
	// Creates a unique name beginning with the specified prefix. Conflicts with `name`. Cannot be longer than 6 characters.
	NamePrefix interface{}
	// The port to use to connect with the target. Valid values are either ports 1-65536, or `traffic-port`. Defaults to `traffic-port`.
	Port interface{}
	// The protocol to use to connect with the target. Defaults to `HTTP`. Not applicable when `targetType` is `lambda`.
	Protocol interface{}
	// Boolean to enable / disable support for proxy protocol v2 on Network Load Balancers. See [doc](https://docs.aws.amazon.com/elasticloadbalancing/latest/network/load-balancer-target-groups.html#proxy-protocol) for more information.
	ProxyProtocolV2 interface{}
	// The amount time for targets to warm up before the load balancer sends them a full share of requests. The range is 30-900 seconds or 0 to disable. The default value is 0 seconds.
	SlowStart interface{}
	// A Stickiness block. Stickiness blocks are documented below. `stickiness` is only valid if used with Load Balancers of type `Application`
	Stickiness interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
	// The type of target that you must specify when registering targets with this target group.
	// The possible values are `instance` (targets are specified by instance ID) or `ip` (targets are specified by IP address) or `lambda` (targets are specified by lambda arn).
	// The default is `instance`. Note that you can't specify targets for a target group using both instance IDs and IP addresses.
	// If the target type is `ip`, specify IP addresses from the subnets of the virtual private cloud (VPC) for the target group,
	// the RFC 1918 range (10.0.0.0/8, 172.16.0.0/12, and 192.168.0.0/16), and the RFC 6598 range (100.64.0.0/10).
	// You can't specify publicly routable IP addresses.
	TargetType interface{}
	// The identifier of the VPC in which to create the target group. Required when `targetType` is `instance` or `ip`. Does not apply when `targetType` is `lambda`.
	VpcId interface{}
}
