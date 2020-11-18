// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Cfg.Outputs
{

    [OutputType]
    public sealed class DeliveryChannelSnapshotDeliveryProperties
    {
        /// <summary>
        /// - The frequency with which AWS Config recurringly delivers configuration snapshots.
        /// e.g. `One_Hour` or `Three_Hours`.
        /// Valid values are listed [here](https://docs.aws.amazon.com/config/latest/APIReference/API_ConfigSnapshotDeliveryProperties.html#API_ConfigSnapshotDeliveryProperties_Contents).
        /// </summary>
        public readonly string? DeliveryFrequency;

        [OutputConstructor]
        private DeliveryChannelSnapshotDeliveryProperties(string? deliveryFrequency)
        {
            DeliveryFrequency = deliveryFrequency;
        }
    }
}
