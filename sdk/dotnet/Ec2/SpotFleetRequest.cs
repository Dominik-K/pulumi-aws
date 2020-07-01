// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2
{
    /// <summary>
    /// Provides an EC2 Spot Fleet Request resource. This allows a fleet of Spot
    /// instances to be requested on the Spot market.
    /// 
    /// ## Example Usage
    /// ### Using launch specifications
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         // Request a Spot fleet
    ///         var cheapCompute = new Aws.Ec2.SpotFleetRequest("cheapCompute", new Aws.Ec2.SpotFleetRequestArgs
    ///         {
    ///             AllocationStrategy = "diversified",
    ///             IamFleetRole = "arn:aws:iam::12345678:role/spot-fleet",
    ///             LaunchSpecifications = 
    ///             {
    ///                 new Aws.Ec2.Inputs.SpotFleetRequestLaunchSpecificationArgs
    ///                 {
    ///                     Ami = "ami-1234",
    ///                     IamInstanceProfileArn = aws_iam_instance_profile.Example.Arn,
    ///                     InstanceType = "m4.10xlarge",
    ///                     PlacementTenancy = "dedicated",
    ///                     SpotPrice = "2.793",
    ///                 },
    ///                 new Aws.Ec2.Inputs.SpotFleetRequestLaunchSpecificationArgs
    ///                 {
    ///                     Ami = "ami-5678",
    ///                     AvailabilityZone = "us-west-1a",
    ///                     IamInstanceProfileArn = aws_iam_instance_profile.Example.Arn,
    ///                     InstanceType = "m4.4xlarge",
    ///                     KeyName = "my-key",
    ///                     RootBlockDevices = 
    ///                     {
    ///                         new Aws.Ec2.Inputs.SpotFleetRequestLaunchSpecificationRootBlockDeviceArgs
    ///                         {
    ///                             VolumeSize = 300,
    ///                             VolumeType = "gp2",
    ///                         },
    ///                     },
    ///                     SpotPrice = "1.117",
    ///                     SubnetId = "subnet-1234",
    ///                     Tags = 
    ///                     {
    ///                         { "Name", "spot-fleet-example" },
    ///                     },
    ///                     WeightedCapacity = "35",
    ///                 },
    ///             },
    ///             SpotPrice = "0.03",
    ///             TargetCapacity = 6,
    ///             ValidUntil = "2019-11-04T20:44:20Z",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ### Using multiple launch specifications
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var foo = new Aws.Ec2.SpotFleetRequest("foo", new Aws.Ec2.SpotFleetRequestArgs
    ///         {
    ///             IamFleetRole = "arn:aws:iam::12345678:role/spot-fleet",
    ///             LaunchSpecifications = 
    ///             {
    ///                 new Aws.Ec2.Inputs.SpotFleetRequestLaunchSpecificationArgs
    ///                 {
    ///                     Ami = "ami-d06a90b0",
    ///                     AvailabilityZone = "us-west-2a",
    ///                     InstanceType = "m1.small",
    ///                     KeyName = "my-key",
    ///                 },
    ///                 new Aws.Ec2.Inputs.SpotFleetRequestLaunchSpecificationArgs
    ///                 {
    ///                     Ami = "ami-d06a90b0",
    ///                     AvailabilityZone = "us-west-2a",
    ///                     InstanceType = "m5.large",
    ///                     KeyName = "my-key",
    ///                 },
    ///             },
    ///             SpotPrice = "0.005",
    ///             TargetCapacity = 2,
    ///             ValidUntil = "2019-11-04T20:44:20Z",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class SpotFleetRequest : Pulumi.CustomResource
    {
        /// <summary>
        /// Indicates how to allocate the target capacity across
        /// the Spot pools specified by the Spot fleet request. The default is
        /// `lowestPrice`.
        /// </summary>
        [Output("allocationStrategy")]
        public Output<string?> AllocationStrategy { get; private set; } = null!;

        [Output("clientToken")]
        public Output<string> ClientToken { get; private set; } = null!;

        /// <summary>
        /// Indicates whether running Spot
        /// instances should be terminated if the target capacity of the Spot fleet
        /// request is decreased below the current size of the Spot fleet.
        /// </summary>
        [Output("excessCapacityTerminationPolicy")]
        public Output<string?> ExcessCapacityTerminationPolicy { get; private set; } = null!;

        /// <summary>
        /// The type of fleet request. Indicates whether the Spot Fleet only requests the target
        /// capacity or also attempts to maintain it. Default is `maintain`.
        /// </summary>
        [Output("fleetType")]
        public Output<string?> FleetType { get; private set; } = null!;

        /// <summary>
        /// Grants the Spot fleet permission to terminate
        /// Spot instances on your behalf when you cancel its Spot fleet request using
        /// CancelSpotFleetRequests or when the Spot fleet request expires, if you set
        /// terminateInstancesWithExpiration.
        /// </summary>
        [Output("iamFleetRole")]
        public Output<string> IamFleetRole { get; private set; } = null!;

        /// <summary>
        /// Indicates whether a Spot
        /// instance stops or terminates when it is interrupted. Default is
        /// `terminate`.
        /// </summary>
        [Output("instanceInterruptionBehaviour")]
        public Output<string?> InstanceInterruptionBehaviour { get; private set; } = null!;

        /// <summary>
        /// The number of Spot pools across which to allocate your target Spot capacity.
        /// Valid only when `allocation_strategy` is set to `lowestPrice`. Spot Fleet selects
        /// the cheapest Spot pools and evenly allocates your target Spot capacity across
        /// the number of Spot pools that you specify.
        /// </summary>
        [Output("instancePoolsToUseCount")]
        public Output<int?> InstancePoolsToUseCount { get; private set; } = null!;

        /// <summary>
        /// Used to define the launch configuration of the
        /// spot-fleet request. Can be specified multiple times to define different bids
        /// across different markets and instance types. Conflicts with `launch_template_config`. At least one of `launch_specification` or `launch_template_config` is required.
        /// </summary>
        [Output("launchSpecifications")]
        public Output<ImmutableArray<Outputs.SpotFleetRequestLaunchSpecification>> LaunchSpecifications { get; private set; } = null!;

        /// <summary>
        /// Launch template configuration block. See Launch Template Configs below for more details. Conflicts with `launch_specification`. At least one of `launch_specification` or `launch_template_config` is required.
        /// </summary>
        [Output("launchTemplateConfigs")]
        public Output<ImmutableArray<Outputs.SpotFleetRequestLaunchTemplateConfig>> LaunchTemplateConfigs { get; private set; } = null!;

        /// <summary>
        /// A list of elastic load balancer names to add to the Spot fleet.
        /// </summary>
        [Output("loadBalancers")]
        public Output<ImmutableArray<string>> LoadBalancers { get; private set; } = null!;

        /// <summary>
        /// Indicates whether Spot fleet should replace unhealthy instances. Default `false`.
        /// </summary>
        [Output("replaceUnhealthyInstances")]
        public Output<bool?> ReplaceUnhealthyInstances { get; private set; } = null!;

        /// <summary>
        /// The maximum spot bid for this override request.
        /// </summary>
        [Output("spotPrice")]
        public Output<string?> SpotPrice { get; private set; } = null!;

        /// <summary>
        /// The state of the Spot fleet request.
        /// </summary>
        [Output("spotRequestState")]
        public Output<string> SpotRequestState { get; private set; } = null!;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The number of units to request. You can choose to set the
        /// target capacity in terms of instances or a performance characteristic that is
        /// important to your application workload, such as vCPUs, memory, or I/O.
        /// </summary>
        [Output("targetCapacity")]
        public Output<int> TargetCapacity { get; private set; } = null!;

        /// <summary>
        /// A list of `aws.alb.TargetGroup` ARNs, for use with Application Load Balancing.
        /// </summary>
        [Output("targetGroupArns")]
        public Output<ImmutableArray<string>> TargetGroupArns { get; private set; } = null!;

        /// <summary>
        /// Indicates whether running Spot
        /// instances should be terminated when the Spot fleet request expires.
        /// </summary>
        [Output("terminateInstancesWithExpiration")]
        public Output<bool?> TerminateInstancesWithExpiration { get; private set; } = null!;

        /// <summary>
        /// The start date and time of the request, in UTC [RFC3339](https://tools.ietf.org/html/rfc3339#section-5.8) format(for example, YYYY-MM-DDTHH:MM:SSZ). The default is to start fulfilling the request immediately.
        /// </summary>
        [Output("validFrom")]
        public Output<string?> ValidFrom { get; private set; } = null!;

        /// <summary>
        /// The end date and time of the request, in UTC [RFC3339](https://tools.ietf.org/html/rfc3339#section-5.8) format(for example, YYYY-MM-DDTHH:MM:SSZ). At this point, no new Spot instance requests are placed or enabled to fulfill the request. Defaults to 24 hours.
        /// </summary>
        [Output("validUntil")]
        public Output<string?> ValidUntil { get; private set; } = null!;

        /// <summary>
        /// If set, this provider will
        /// wait for the Spot Request to be fulfilled, and will throw an error if the
        /// timeout of 10m is reached.
        /// </summary>
        [Output("waitForFulfillment")]
        public Output<bool?> WaitForFulfillment { get; private set; } = null!;


        /// <summary>
        /// Create a SpotFleetRequest resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SpotFleetRequest(string name, SpotFleetRequestArgs args, CustomResourceOptions? options = null)
            : base("aws:ec2/spotFleetRequest:SpotFleetRequest", name, args ?? new SpotFleetRequestArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SpotFleetRequest(string name, Input<string> id, SpotFleetRequestState? state = null, CustomResourceOptions? options = null)
            : base("aws:ec2/spotFleetRequest:SpotFleetRequest", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing SpotFleetRequest resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SpotFleetRequest Get(string name, Input<string> id, SpotFleetRequestState? state = null, CustomResourceOptions? options = null)
        {
            return new SpotFleetRequest(name, id, state, options);
        }
    }

    public sealed class SpotFleetRequestArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicates how to allocate the target capacity across
        /// the Spot pools specified by the Spot fleet request. The default is
        /// `lowestPrice`.
        /// </summary>
        [Input("allocationStrategy")]
        public Input<string>? AllocationStrategy { get; set; }

        /// <summary>
        /// Indicates whether running Spot
        /// instances should be terminated if the target capacity of the Spot fleet
        /// request is decreased below the current size of the Spot fleet.
        /// </summary>
        [Input("excessCapacityTerminationPolicy")]
        public Input<string>? ExcessCapacityTerminationPolicy { get; set; }

        /// <summary>
        /// The type of fleet request. Indicates whether the Spot Fleet only requests the target
        /// capacity or also attempts to maintain it. Default is `maintain`.
        /// </summary>
        [Input("fleetType")]
        public Input<string>? FleetType { get; set; }

        /// <summary>
        /// Grants the Spot fleet permission to terminate
        /// Spot instances on your behalf when you cancel its Spot fleet request using
        /// CancelSpotFleetRequests or when the Spot fleet request expires, if you set
        /// terminateInstancesWithExpiration.
        /// </summary>
        [Input("iamFleetRole", required: true)]
        public Input<string> IamFleetRole { get; set; } = null!;

        /// <summary>
        /// Indicates whether a Spot
        /// instance stops or terminates when it is interrupted. Default is
        /// `terminate`.
        /// </summary>
        [Input("instanceInterruptionBehaviour")]
        public Input<string>? InstanceInterruptionBehaviour { get; set; }

        /// <summary>
        /// The number of Spot pools across which to allocate your target Spot capacity.
        /// Valid only when `allocation_strategy` is set to `lowestPrice`. Spot Fleet selects
        /// the cheapest Spot pools and evenly allocates your target Spot capacity across
        /// the number of Spot pools that you specify.
        /// </summary>
        [Input("instancePoolsToUseCount")]
        public Input<int>? InstancePoolsToUseCount { get; set; }

        [Input("launchSpecifications")]
        private InputList<Inputs.SpotFleetRequestLaunchSpecificationArgs>? _launchSpecifications;

        /// <summary>
        /// Used to define the launch configuration of the
        /// spot-fleet request. Can be specified multiple times to define different bids
        /// across different markets and instance types. Conflicts with `launch_template_config`. At least one of `launch_specification` or `launch_template_config` is required.
        /// </summary>
        public InputList<Inputs.SpotFleetRequestLaunchSpecificationArgs> LaunchSpecifications
        {
            get => _launchSpecifications ?? (_launchSpecifications = new InputList<Inputs.SpotFleetRequestLaunchSpecificationArgs>());
            set => _launchSpecifications = value;
        }

        [Input("launchTemplateConfigs")]
        private InputList<Inputs.SpotFleetRequestLaunchTemplateConfigArgs>? _launchTemplateConfigs;

        /// <summary>
        /// Launch template configuration block. See Launch Template Configs below for more details. Conflicts with `launch_specification`. At least one of `launch_specification` or `launch_template_config` is required.
        /// </summary>
        public InputList<Inputs.SpotFleetRequestLaunchTemplateConfigArgs> LaunchTemplateConfigs
        {
            get => _launchTemplateConfigs ?? (_launchTemplateConfigs = new InputList<Inputs.SpotFleetRequestLaunchTemplateConfigArgs>());
            set => _launchTemplateConfigs = value;
        }

        [Input("loadBalancers")]
        private InputList<string>? _loadBalancers;

        /// <summary>
        /// A list of elastic load balancer names to add to the Spot fleet.
        /// </summary>
        public InputList<string> LoadBalancers
        {
            get => _loadBalancers ?? (_loadBalancers = new InputList<string>());
            set => _loadBalancers = value;
        }

        /// <summary>
        /// Indicates whether Spot fleet should replace unhealthy instances. Default `false`.
        /// </summary>
        [Input("replaceUnhealthyInstances")]
        public Input<bool>? ReplaceUnhealthyInstances { get; set; }

        /// <summary>
        /// The maximum spot bid for this override request.
        /// </summary>
        [Input("spotPrice")]
        public Input<string>? SpotPrice { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The number of units to request. You can choose to set the
        /// target capacity in terms of instances or a performance characteristic that is
        /// important to your application workload, such as vCPUs, memory, or I/O.
        /// </summary>
        [Input("targetCapacity", required: true)]
        public Input<int> TargetCapacity { get; set; } = null!;

        [Input("targetGroupArns")]
        private InputList<string>? _targetGroupArns;

        /// <summary>
        /// A list of `aws.alb.TargetGroup` ARNs, for use with Application Load Balancing.
        /// </summary>
        public InputList<string> TargetGroupArns
        {
            get => _targetGroupArns ?? (_targetGroupArns = new InputList<string>());
            set => _targetGroupArns = value;
        }

        /// <summary>
        /// Indicates whether running Spot
        /// instances should be terminated when the Spot fleet request expires.
        /// </summary>
        [Input("terminateInstancesWithExpiration")]
        public Input<bool>? TerminateInstancesWithExpiration { get; set; }

        /// <summary>
        /// The start date and time of the request, in UTC [RFC3339](https://tools.ietf.org/html/rfc3339#section-5.8) format(for example, YYYY-MM-DDTHH:MM:SSZ). The default is to start fulfilling the request immediately.
        /// </summary>
        [Input("validFrom")]
        public Input<string>? ValidFrom { get; set; }

        /// <summary>
        /// The end date and time of the request, in UTC [RFC3339](https://tools.ietf.org/html/rfc3339#section-5.8) format(for example, YYYY-MM-DDTHH:MM:SSZ). At this point, no new Spot instance requests are placed or enabled to fulfill the request. Defaults to 24 hours.
        /// </summary>
        [Input("validUntil")]
        public Input<string>? ValidUntil { get; set; }

        /// <summary>
        /// If set, this provider will
        /// wait for the Spot Request to be fulfilled, and will throw an error if the
        /// timeout of 10m is reached.
        /// </summary>
        [Input("waitForFulfillment")]
        public Input<bool>? WaitForFulfillment { get; set; }

        public SpotFleetRequestArgs()
        {
        }
    }

    public sealed class SpotFleetRequestState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicates how to allocate the target capacity across
        /// the Spot pools specified by the Spot fleet request. The default is
        /// `lowestPrice`.
        /// </summary>
        [Input("allocationStrategy")]
        public Input<string>? AllocationStrategy { get; set; }

        [Input("clientToken")]
        public Input<string>? ClientToken { get; set; }

        /// <summary>
        /// Indicates whether running Spot
        /// instances should be terminated if the target capacity of the Spot fleet
        /// request is decreased below the current size of the Spot fleet.
        /// </summary>
        [Input("excessCapacityTerminationPolicy")]
        public Input<string>? ExcessCapacityTerminationPolicy { get; set; }

        /// <summary>
        /// The type of fleet request. Indicates whether the Spot Fleet only requests the target
        /// capacity or also attempts to maintain it. Default is `maintain`.
        /// </summary>
        [Input("fleetType")]
        public Input<string>? FleetType { get; set; }

        /// <summary>
        /// Grants the Spot fleet permission to terminate
        /// Spot instances on your behalf when you cancel its Spot fleet request using
        /// CancelSpotFleetRequests or when the Spot fleet request expires, if you set
        /// terminateInstancesWithExpiration.
        /// </summary>
        [Input("iamFleetRole")]
        public Input<string>? IamFleetRole { get; set; }

        /// <summary>
        /// Indicates whether a Spot
        /// instance stops or terminates when it is interrupted. Default is
        /// `terminate`.
        /// </summary>
        [Input("instanceInterruptionBehaviour")]
        public Input<string>? InstanceInterruptionBehaviour { get; set; }

        /// <summary>
        /// The number of Spot pools across which to allocate your target Spot capacity.
        /// Valid only when `allocation_strategy` is set to `lowestPrice`. Spot Fleet selects
        /// the cheapest Spot pools and evenly allocates your target Spot capacity across
        /// the number of Spot pools that you specify.
        /// </summary>
        [Input("instancePoolsToUseCount")]
        public Input<int>? InstancePoolsToUseCount { get; set; }

        [Input("launchSpecifications")]
        private InputList<Inputs.SpotFleetRequestLaunchSpecificationGetArgs>? _launchSpecifications;

        /// <summary>
        /// Used to define the launch configuration of the
        /// spot-fleet request. Can be specified multiple times to define different bids
        /// across different markets and instance types. Conflicts with `launch_template_config`. At least one of `launch_specification` or `launch_template_config` is required.
        /// </summary>
        public InputList<Inputs.SpotFleetRequestLaunchSpecificationGetArgs> LaunchSpecifications
        {
            get => _launchSpecifications ?? (_launchSpecifications = new InputList<Inputs.SpotFleetRequestLaunchSpecificationGetArgs>());
            set => _launchSpecifications = value;
        }

        [Input("launchTemplateConfigs")]
        private InputList<Inputs.SpotFleetRequestLaunchTemplateConfigGetArgs>? _launchTemplateConfigs;

        /// <summary>
        /// Launch template configuration block. See Launch Template Configs below for more details. Conflicts with `launch_specification`. At least one of `launch_specification` or `launch_template_config` is required.
        /// </summary>
        public InputList<Inputs.SpotFleetRequestLaunchTemplateConfigGetArgs> LaunchTemplateConfigs
        {
            get => _launchTemplateConfigs ?? (_launchTemplateConfigs = new InputList<Inputs.SpotFleetRequestLaunchTemplateConfigGetArgs>());
            set => _launchTemplateConfigs = value;
        }

        [Input("loadBalancers")]
        private InputList<string>? _loadBalancers;

        /// <summary>
        /// A list of elastic load balancer names to add to the Spot fleet.
        /// </summary>
        public InputList<string> LoadBalancers
        {
            get => _loadBalancers ?? (_loadBalancers = new InputList<string>());
            set => _loadBalancers = value;
        }

        /// <summary>
        /// Indicates whether Spot fleet should replace unhealthy instances. Default `false`.
        /// </summary>
        [Input("replaceUnhealthyInstances")]
        public Input<bool>? ReplaceUnhealthyInstances { get; set; }

        /// <summary>
        /// The maximum spot bid for this override request.
        /// </summary>
        [Input("spotPrice")]
        public Input<string>? SpotPrice { get; set; }

        /// <summary>
        /// The state of the Spot fleet request.
        /// </summary>
        [Input("spotRequestState")]
        public Input<string>? SpotRequestState { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The number of units to request. You can choose to set the
        /// target capacity in terms of instances or a performance characteristic that is
        /// important to your application workload, such as vCPUs, memory, or I/O.
        /// </summary>
        [Input("targetCapacity")]
        public Input<int>? TargetCapacity { get; set; }

        [Input("targetGroupArns")]
        private InputList<string>? _targetGroupArns;

        /// <summary>
        /// A list of `aws.alb.TargetGroup` ARNs, for use with Application Load Balancing.
        /// </summary>
        public InputList<string> TargetGroupArns
        {
            get => _targetGroupArns ?? (_targetGroupArns = new InputList<string>());
            set => _targetGroupArns = value;
        }

        /// <summary>
        /// Indicates whether running Spot
        /// instances should be terminated when the Spot fleet request expires.
        /// </summary>
        [Input("terminateInstancesWithExpiration")]
        public Input<bool>? TerminateInstancesWithExpiration { get; set; }

        /// <summary>
        /// The start date and time of the request, in UTC [RFC3339](https://tools.ietf.org/html/rfc3339#section-5.8) format(for example, YYYY-MM-DDTHH:MM:SSZ). The default is to start fulfilling the request immediately.
        /// </summary>
        [Input("validFrom")]
        public Input<string>? ValidFrom { get; set; }

        /// <summary>
        /// The end date and time of the request, in UTC [RFC3339](https://tools.ietf.org/html/rfc3339#section-5.8) format(for example, YYYY-MM-DDTHH:MM:SSZ). At this point, no new Spot instance requests are placed or enabled to fulfill the request. Defaults to 24 hours.
        /// </summary>
        [Input("validUntil")]
        public Input<string>? ValidUntil { get; set; }

        /// <summary>
        /// If set, this provider will
        /// wait for the Spot Request to be fulfilled, and will throw an error if the
        /// timeout of 10m is reached.
        /// </summary>
        [Input("waitForFulfillment")]
        public Input<bool>? WaitForFulfillment { get; set; }

        public SpotFleetRequestState()
        {
        }
    }
}
