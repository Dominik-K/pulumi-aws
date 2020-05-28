// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.ApplicationLoadBalancing
{
    /// <summary>
    /// Provides a Target Group resource for use with Load Balancer resources.
    /// 
    /// &gt; **Note:** `aws.alb.TargetGroup` is known as `aws.lb.TargetGroup`. The functionality is identical.
    /// 
    /// ## Example Usage
    /// 
    /// ### Instance Target Group
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var main = new Aws.Ec2.Vpc("main", new Aws.Ec2.VpcArgs
    ///         {
    ///             CidrBlock = "10.0.0.0/16",
    ///         });
    ///         var test = new Aws.LB.TargetGroup("test", new Aws.LB.TargetGroupArgs
    ///         {
    ///             Port = 80,
    ///             Protocol = "HTTP",
    ///             VpcId = main.Id,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ### IP Target Group
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var main = new Aws.Ec2.Vpc("main", new Aws.Ec2.VpcArgs
    ///         {
    ///             CidrBlock = "10.0.0.0/16",
    ///         });
    ///         var ip_example = new Aws.LB.TargetGroup("ip-example", new Aws.LB.TargetGroupArgs
    ///         {
    ///             Port = 80,
    ///             Protocol = "HTTP",
    ///             TargetType = "ip",
    ///             VpcId = main.Id,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ### Lambda Target Group
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var lambda_example = new Aws.LB.TargetGroup("lambda-example", new Aws.LB.TargetGroupArgs
    ///         {
    ///             TargetType = "lambda",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    [Obsolete(@"aws.applicationloadbalancing.TargetGroup has been deprecated in favor of aws.alb.TargetGroup")]
    public partial class TargetGroup : Pulumi.CustomResource
    {
        /// <summary>
        /// The ARN of the Target Group (matches `id`)
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// The ARN suffix for use with CloudWatch Metrics.
        /// </summary>
        [Output("arnSuffix")]
        public Output<string> ArnSuffix { get; private set; } = null!;

        /// <summary>
        /// The amount time for Elastic Load Balancing to wait before changing the state of a deregistering target from draining to unused. The range is 0-3600 seconds. The default value is 300 seconds.
        /// </summary>
        [Output("deregistrationDelay")]
        public Output<int?> DeregistrationDelay { get; private set; } = null!;

        /// <summary>
        /// A Health Check block. Health Check blocks are documented below.
        /// </summary>
        [Output("healthCheck")]
        public Output<Outputs.TargetGroupHealthCheck> HealthCheck { get; private set; } = null!;

        /// <summary>
        /// Boolean whether the request and response headers exchanged between the load balancer and the Lambda function include arrays of values or strings. Only applies when `target_type` is `lambda`.
        /// </summary>
        [Output("lambdaMultiValueHeadersEnabled")]
        public Output<bool?> LambdaMultiValueHeadersEnabled { get; private set; } = null!;

        /// <summary>
        /// Determines how the load balancer selects targets when routing requests. Only applicable for Application Load Balancer Target Groups. The value is `round_robin` or `least_outstanding_requests`. The default is `round_robin`.
        /// </summary>
        [Output("loadBalancingAlgorithmType")]
        public Output<string> LoadBalancingAlgorithmType { get; private set; } = null!;

        /// <summary>
        /// The name of the target group. If omitted, this provider will assign a random, unique name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Creates a unique name beginning with the specified prefix. Conflicts with `name`. Cannot be longer than 6 characters.
        /// </summary>
        [Output("namePrefix")]
        public Output<string?> NamePrefix { get; private set; } = null!;

        /// <summary>
        /// The port on which targets receive traffic, unless overridden when registering a specific target. Required when `target_type` is `instance` or `ip`. Does not apply when `target_type` is `lambda`.
        /// </summary>
        [Output("port")]
        public Output<int?> Port { get; private set; } = null!;

        /// <summary>
        /// The protocol to use for routing traffic to the targets. Should be one of "TCP", "TLS", "UDP", "TCP_UDP", "HTTP" or "HTTPS". Required when `target_type` is `instance` or `ip`. Does not apply when `target_type` is `lambda`.
        /// </summary>
        [Output("protocol")]
        public Output<string?> Protocol { get; private set; } = null!;

        /// <summary>
        /// Boolean to enable / disable support for proxy protocol v2 on Network Load Balancers. See [doc](https://docs.aws.amazon.com/elasticloadbalancing/latest/network/load-balancer-target-groups.html#proxy-protocol) for more information.
        /// </summary>
        [Output("proxyProtocolV2")]
        public Output<bool?> ProxyProtocolV2 { get; private set; } = null!;

        /// <summary>
        /// The amount time for targets to warm up before the load balancer sends them a full share of requests. The range is 30-900 seconds or 0 to disable. The default value is 0 seconds.
        /// </summary>
        [Output("slowStart")]
        public Output<int?> SlowStart { get; private set; } = null!;

        /// <summary>
        /// A Stickiness block. Stickiness blocks are documented below. `stickiness` is only valid if used with Load Balancers of type `Application`
        /// </summary>
        [Output("stickiness")]
        public Output<Outputs.TargetGroupStickiness> Stickiness { get; private set; } = null!;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The type of target that you must specify when registering targets with this target group.
        /// The possible values are `instance` (targets are specified by instance ID) or `ip` (targets are specified by IP address) or `lambda` (targets are specified by lambda arn).
        /// The default is `instance`. Note that you can't specify targets for a target group using both instance IDs and IP addresses.
        /// If the target type is `ip`, specify IP addresses from the subnets of the virtual private cloud (VPC) for the target group,
        /// the RFC 1918 range (10.0.0.0/8, 172.16.0.0/12, and 192.168.0.0/16), and the RFC 6598 range (100.64.0.0/10).
        /// You can't specify publicly routable IP addresses.
        /// </summary>
        [Output("targetType")]
        public Output<string?> TargetType { get; private set; } = null!;

        /// <summary>
        /// The identifier of the VPC in which to create the target group. Required when `target_type` is `instance` or `ip`. Does not apply when `target_type` is `lambda`.
        /// </summary>
        [Output("vpcId")]
        public Output<string?> VpcId { get; private set; } = null!;


        /// <summary>
        /// Create a TargetGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public TargetGroup(string name, TargetGroupArgs? args = null, CustomResourceOptions? options = null)
            : base("aws:applicationloadbalancing/targetGroup:TargetGroup", name, args ?? new TargetGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private TargetGroup(string name, Input<string> id, TargetGroupState? state = null, CustomResourceOptions? options = null)
            : base("aws:applicationloadbalancing/targetGroup:TargetGroup", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing TargetGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static TargetGroup Get(string name, Input<string> id, TargetGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new TargetGroup(name, id, state, options);
        }
    }

    public sealed class TargetGroupArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The amount time for Elastic Load Balancing to wait before changing the state of a deregistering target from draining to unused. The range is 0-3600 seconds. The default value is 300 seconds.
        /// </summary>
        [Input("deregistrationDelay")]
        public Input<int>? DeregistrationDelay { get; set; }

        /// <summary>
        /// A Health Check block. Health Check blocks are documented below.
        /// </summary>
        [Input("healthCheck")]
        public Input<Inputs.TargetGroupHealthCheckArgs>? HealthCheck { get; set; }

        /// <summary>
        /// Boolean whether the request and response headers exchanged between the load balancer and the Lambda function include arrays of values or strings. Only applies when `target_type` is `lambda`.
        /// </summary>
        [Input("lambdaMultiValueHeadersEnabled")]
        public Input<bool>? LambdaMultiValueHeadersEnabled { get; set; }

        /// <summary>
        /// Determines how the load balancer selects targets when routing requests. Only applicable for Application Load Balancer Target Groups. The value is `round_robin` or `least_outstanding_requests`. The default is `round_robin`.
        /// </summary>
        [Input("loadBalancingAlgorithmType")]
        public Input<string>? LoadBalancingAlgorithmType { get; set; }

        /// <summary>
        /// The name of the target group. If omitted, this provider will assign a random, unique name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Creates a unique name beginning with the specified prefix. Conflicts with `name`. Cannot be longer than 6 characters.
        /// </summary>
        [Input("namePrefix")]
        public Input<string>? NamePrefix { get; set; }

        /// <summary>
        /// The port on which targets receive traffic, unless overridden when registering a specific target. Required when `target_type` is `instance` or `ip`. Does not apply when `target_type` is `lambda`.
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// The protocol to use for routing traffic to the targets. Should be one of "TCP", "TLS", "UDP", "TCP_UDP", "HTTP" or "HTTPS". Required when `target_type` is `instance` or `ip`. Does not apply when `target_type` is `lambda`.
        /// </summary>
        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        /// <summary>
        /// Boolean to enable / disable support for proxy protocol v2 on Network Load Balancers. See [doc](https://docs.aws.amazon.com/elasticloadbalancing/latest/network/load-balancer-target-groups.html#proxy-protocol) for more information.
        /// </summary>
        [Input("proxyProtocolV2")]
        public Input<bool>? ProxyProtocolV2 { get; set; }

        /// <summary>
        /// The amount time for targets to warm up before the load balancer sends them a full share of requests. The range is 30-900 seconds or 0 to disable. The default value is 0 seconds.
        /// </summary>
        [Input("slowStart")]
        public Input<int>? SlowStart { get; set; }

        /// <summary>
        /// A Stickiness block. Stickiness blocks are documented below. `stickiness` is only valid if used with Load Balancers of type `Application`
        /// </summary>
        [Input("stickiness")]
        public Input<Inputs.TargetGroupStickinessArgs>? Stickiness { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// The type of target that you must specify when registering targets with this target group.
        /// The possible values are `instance` (targets are specified by instance ID) or `ip` (targets are specified by IP address) or `lambda` (targets are specified by lambda arn).
        /// The default is `instance`. Note that you can't specify targets for a target group using both instance IDs and IP addresses.
        /// If the target type is `ip`, specify IP addresses from the subnets of the virtual private cloud (VPC) for the target group,
        /// the RFC 1918 range (10.0.0.0/8, 172.16.0.0/12, and 192.168.0.0/16), and the RFC 6598 range (100.64.0.0/10).
        /// You can't specify publicly routable IP addresses.
        /// </summary>
        [Input("targetType")]
        public Input<string>? TargetType { get; set; }

        /// <summary>
        /// The identifier of the VPC in which to create the target group. Required when `target_type` is `instance` or `ip`. Does not apply when `target_type` is `lambda`.
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public TargetGroupArgs()
        {
        }
    }

    public sealed class TargetGroupState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ARN of the Target Group (matches `id`)
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// The ARN suffix for use with CloudWatch Metrics.
        /// </summary>
        [Input("arnSuffix")]
        public Input<string>? ArnSuffix { get; set; }

        /// <summary>
        /// The amount time for Elastic Load Balancing to wait before changing the state of a deregistering target from draining to unused. The range is 0-3600 seconds. The default value is 300 seconds.
        /// </summary>
        [Input("deregistrationDelay")]
        public Input<int>? DeregistrationDelay { get; set; }

        /// <summary>
        /// A Health Check block. Health Check blocks are documented below.
        /// </summary>
        [Input("healthCheck")]
        public Input<Inputs.TargetGroupHealthCheckGetArgs>? HealthCheck { get; set; }

        /// <summary>
        /// Boolean whether the request and response headers exchanged between the load balancer and the Lambda function include arrays of values or strings. Only applies when `target_type` is `lambda`.
        /// </summary>
        [Input("lambdaMultiValueHeadersEnabled")]
        public Input<bool>? LambdaMultiValueHeadersEnabled { get; set; }

        /// <summary>
        /// Determines how the load balancer selects targets when routing requests. Only applicable for Application Load Balancer Target Groups. The value is `round_robin` or `least_outstanding_requests`. The default is `round_robin`.
        /// </summary>
        [Input("loadBalancingAlgorithmType")]
        public Input<string>? LoadBalancingAlgorithmType { get; set; }

        /// <summary>
        /// The name of the target group. If omitted, this provider will assign a random, unique name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Creates a unique name beginning with the specified prefix. Conflicts with `name`. Cannot be longer than 6 characters.
        /// </summary>
        [Input("namePrefix")]
        public Input<string>? NamePrefix { get; set; }

        /// <summary>
        /// The port on which targets receive traffic, unless overridden when registering a specific target. Required when `target_type` is `instance` or `ip`. Does not apply when `target_type` is `lambda`.
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// The protocol to use for routing traffic to the targets. Should be one of "TCP", "TLS", "UDP", "TCP_UDP", "HTTP" or "HTTPS". Required when `target_type` is `instance` or `ip`. Does not apply when `target_type` is `lambda`.
        /// </summary>
        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        /// <summary>
        /// Boolean to enable / disable support for proxy protocol v2 on Network Load Balancers. See [doc](https://docs.aws.amazon.com/elasticloadbalancing/latest/network/load-balancer-target-groups.html#proxy-protocol) for more information.
        /// </summary>
        [Input("proxyProtocolV2")]
        public Input<bool>? ProxyProtocolV2 { get; set; }

        /// <summary>
        /// The amount time for targets to warm up before the load balancer sends them a full share of requests. The range is 30-900 seconds or 0 to disable. The default value is 0 seconds.
        /// </summary>
        [Input("slowStart")]
        public Input<int>? SlowStart { get; set; }

        /// <summary>
        /// A Stickiness block. Stickiness blocks are documented below. `stickiness` is only valid if used with Load Balancers of type `Application`
        /// </summary>
        [Input("stickiness")]
        public Input<Inputs.TargetGroupStickinessGetArgs>? Stickiness { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// The type of target that you must specify when registering targets with this target group.
        /// The possible values are `instance` (targets are specified by instance ID) or `ip` (targets are specified by IP address) or `lambda` (targets are specified by lambda arn).
        /// The default is `instance`. Note that you can't specify targets for a target group using both instance IDs and IP addresses.
        /// If the target type is `ip`, specify IP addresses from the subnets of the virtual private cloud (VPC) for the target group,
        /// the RFC 1918 range (10.0.0.0/8, 172.16.0.0/12, and 192.168.0.0/16), and the RFC 6598 range (100.64.0.0/10).
        /// You can't specify publicly routable IP addresses.
        /// </summary>
        [Input("targetType")]
        public Input<string>? TargetType { get; set; }

        /// <summary>
        /// The identifier of the VPC in which to create the target group. Required when `target_type` is `instance` or `ip`. Does not apply when `target_type` is `lambda`.
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public TargetGroupState()
        {
        }
    }
}
