// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Batch.Inputs
{

    public sealed class ComputeEnvironmentComputeResourcesGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The allocation strategy to use for the compute resource in case not enough instances of the best fitting instance type can be allocated. Valid items are `BEST_FIT_PROGRESSIVE`, `SPOT_CAPACITY_OPTIMIZED` or `BEST_FIT`. Defaults to `BEST_FIT`. See [AWS docs](https://docs.aws.amazon.com/batch/latest/userguide/allocation-strategies.html) for details.
        /// </summary>
        [Input("allocationStrategy")]
        public Input<string>? AllocationStrategy { get; set; }

        /// <summary>
        /// Integer of minimum percentage that a Spot Instance price must be when compared with the On-Demand price for that instance type before instances are launched. For example, if your bid percentage is 20% (`20`), then the Spot price must be below 20% of the current On-Demand price for that EC2 instance. This parameter is required for SPOT compute environments.
        /// </summary>
        [Input("bidPercentage")]
        public Input<int>? BidPercentage { get; set; }

        /// <summary>
        /// The desired number of EC2 vCPUS in the compute environment.
        /// </summary>
        [Input("desiredVcpus")]
        public Input<int>? DesiredVcpus { get; set; }

        /// <summary>
        /// The EC2 key pair that is used for instances launched in the compute environment.
        /// </summary>
        [Input("ec2KeyPair")]
        public Input<string>? Ec2KeyPair { get; set; }

        /// <summary>
        /// The Amazon Machine Image (AMI) ID used for instances launched in the compute environment.
        /// </summary>
        [Input("imageId")]
        public Input<string>? ImageId { get; set; }

        /// <summary>
        /// The Amazon ECS instance role applied to Amazon EC2 instances in a compute environment.
        /// </summary>
        [Input("instanceRole", required: true)]
        public Input<string> InstanceRole { get; set; } = null!;

        [Input("instanceTypes", required: true)]
        private InputList<string>? _instanceTypes;

        /// <summary>
        /// A list of instance types that may be launched.
        /// </summary>
        public InputList<string> InstanceTypes
        {
            get => _instanceTypes ?? (_instanceTypes = new InputList<string>());
            set => _instanceTypes = value;
        }

        /// <summary>
        /// The launch template to use for your compute resources. See details below.
        /// </summary>
        [Input("launchTemplate")]
        public Input<Inputs.ComputeEnvironmentComputeResourcesLaunchTemplateGetArgs>? LaunchTemplate { get; set; }

        /// <summary>
        /// The maximum number of EC2 vCPUs that an environment can reach.
        /// </summary>
        [Input("maxVcpus", required: true)]
        public Input<int> MaxVcpus { get; set; } = null!;

        /// <summary>
        /// The minimum number of EC2 vCPUs that an environment should maintain.
        /// </summary>
        [Input("minVcpus", required: true)]
        public Input<int> MinVcpus { get; set; } = null!;

        [Input("securityGroupIds", required: true)]
        private InputList<string>? _securityGroupIds;

        /// <summary>
        /// A list of EC2 security group that are associated with instances launched in the compute environment.
        /// </summary>
        public InputList<string> SecurityGroupIds
        {
            get => _securityGroupIds ?? (_securityGroupIds = new InputList<string>());
            set => _securityGroupIds = value;
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the Amazon EC2 Spot Fleet IAM role applied to a SPOT compute environment. This parameter is required for SPOT compute environments.
        /// </summary>
        [Input("spotIamFleetRole")]
        public Input<string>? SpotIamFleetRole { get; set; }

        [Input("subnets", required: true)]
        private InputList<string>? _subnets;

        /// <summary>
        /// A list of VPC subnets into which the compute resources are launched.
        /// </summary>
        public InputList<string> Subnets
        {
            get => _subnets ?? (_subnets = new InputList<string>());
            set => _subnets = value;
        }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Key-value pair tags to be applied to resources that are launched in the compute environment.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The type of compute environment. Valid items are `EC2` or `SPOT`.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ComputeEnvironmentComputeResourcesGetArgs()
        {
        }
    }
}
