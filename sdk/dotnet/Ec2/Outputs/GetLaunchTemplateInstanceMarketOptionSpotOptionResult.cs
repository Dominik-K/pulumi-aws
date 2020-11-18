// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2.Outputs
{

    [OutputType]
    public sealed class GetLaunchTemplateInstanceMarketOptionSpotOptionResult
    {
        public readonly int BlockDurationMinutes;
        public readonly string InstanceInterruptionBehavior;
        public readonly string MaxPrice;
        public readonly string SpotInstanceType;
        public readonly string ValidUntil;

        [OutputConstructor]
        private GetLaunchTemplateInstanceMarketOptionSpotOptionResult(
            int blockDurationMinutes,

            string instanceInterruptionBehavior,

            string maxPrice,

            string spotInstanceType,

            string validUntil)
        {
            BlockDurationMinutes = blockDurationMinutes;
            InstanceInterruptionBehavior = instanceInterruptionBehavior;
            MaxPrice = maxPrice;
            SpotInstanceType = spotInstanceType;
            ValidUntil = validUntil;
        }
    }
}
