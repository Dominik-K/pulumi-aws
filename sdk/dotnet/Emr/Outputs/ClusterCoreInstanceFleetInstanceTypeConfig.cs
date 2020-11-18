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
    public sealed class ClusterCoreInstanceFleetInstanceTypeConfig
    {
        /// <summary>
        /// The bid price for each EC2 Spot instance type as defined by `instance_type`. Expressed in USD. If neither `bid_price` nor `bid_price_as_percentage_of_on_demand_price` is provided, `bid_price_as_percentage_of_on_demand_price` defaults to 100%.
        /// </summary>
        public readonly string? BidPrice;
        /// <summary>
        /// The bid price, as a percentage of On-Demand price, for each EC2 Spot instance as defined by `instance_type`. Expressed as a number (for example, 20 specifies 20%). If neither `bid_price` nor `bid_price_as_percentage_of_on_demand_price` is provided, `bid_price_as_percentage_of_on_demand_price` defaults to 100%.
        /// </summary>
        public readonly double? BidPriceAsPercentageOfOnDemandPrice;
        /// <summary>
        /// A configuration classification that applies when provisioning cluster instances, which can include configurations for applications and software that run on the cluster. List of `configuration` blocks.
        /// </summary>
        public readonly ImmutableArray<Outputs.ClusterCoreInstanceFleetInstanceTypeConfigConfiguration> Configurations;
        /// <summary>
        /// Configuration block(s) for EBS volumes attached to each instance in the instance group. Detailed below.
        /// </summary>
        public readonly ImmutableArray<Outputs.ClusterCoreInstanceFleetInstanceTypeConfigEbsConfig> EbsConfigs;
        /// <summary>
        /// An EC2 instance type, such as m4.xlarge.
        /// </summary>
        public readonly string InstanceType;
        /// <summary>
        /// The number of units that a provisioned instance of this type provides toward fulfilling the target capacities defined in `aws.emr.InstanceFleet`.
        /// </summary>
        public readonly int? WeightedCapacity;

        [OutputConstructor]
        private ClusterCoreInstanceFleetInstanceTypeConfig(
            string? bidPrice,

            double? bidPriceAsPercentageOfOnDemandPrice,

            ImmutableArray<Outputs.ClusterCoreInstanceFleetInstanceTypeConfigConfiguration> configurations,

            ImmutableArray<Outputs.ClusterCoreInstanceFleetInstanceTypeConfigEbsConfig> ebsConfigs,

            string instanceType,

            int? weightedCapacity)
        {
            BidPrice = bidPrice;
            BidPriceAsPercentageOfOnDemandPrice = bidPriceAsPercentageOfOnDemandPrice;
            Configurations = configurations;
            EbsConfigs = ebsConfigs;
            InstanceType = instanceType;
            WeightedCapacity = weightedCapacity;
        }
    }
}
