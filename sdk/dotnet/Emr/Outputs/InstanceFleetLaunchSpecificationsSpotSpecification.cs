// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Emr.Outputs
{

    [OutputType]
    public sealed class InstanceFleetLaunchSpecificationsSpotSpecification
    {
        /// <summary>
        /// Specifies the strategy to use in launching Spot instance fleets. Currently, the only option is `capacity-optimized` (the default), which launches instances from Spot instance pools with optimal capacity for the number of instances that are launching.
        /// </summary>
        public readonly string AllocationStrategy;
        /// <summary>
        /// The defined duration for Spot instances (also known as Spot blocks) in minutes. When specified, the Spot instance does not terminate before the defined duration expires, and defined duration pricing for Spot instances applies. Valid values are 60, 120, 180, 240, 300, or 360. The duration period starts as soon as a Spot instance receives its instance ID. At the end of the duration, Amazon EC2 marks the Spot instance for termination and provides a Spot instance termination notice, which gives the instance a two-minute warning before it terminates.
        /// </summary>
        public readonly int? BlockDurationMinutes;
        /// <summary>
        /// The action to take when TargetSpotCapacity has not been fulfilled when the TimeoutDurationMinutes has expired; that is, when all Spot instances could not be provisioned within the Spot provisioning timeout. Valid values are `TERMINATE_CLUSTER` and `SWITCH_TO_ON_DEMAND`. SWITCH_TO_ON_DEMAND specifies that if no Spot instances are available, On-Demand Instances should be provisioned to fulfill any remaining Spot capacity.
        /// </summary>
        public readonly string TimeoutAction;
        /// <summary>
        /// The spot provisioning timeout period in minutes. If Spot instances are not provisioned within this time period, the TimeOutAction is taken. Minimum value is 5 and maximum value is 1440. The timeout applies only during initial provisioning, when the cluster is first created.
        /// </summary>
        public readonly int TimeoutDurationMinutes;

        [OutputConstructor]
        private InstanceFleetLaunchSpecificationsSpotSpecification(
            string allocationStrategy,

            int? blockDurationMinutes,

            string timeoutAction,

            int timeoutDurationMinutes)
        {
            AllocationStrategy = allocationStrategy;
            BlockDurationMinutes = blockDurationMinutes;
            TimeoutAction = timeoutAction;
            TimeoutDurationMinutes = timeoutDurationMinutes;
        }
    }
}
