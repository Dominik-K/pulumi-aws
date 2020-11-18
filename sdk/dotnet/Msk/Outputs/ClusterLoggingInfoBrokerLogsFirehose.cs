// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Msk.Outputs
{

    [OutputType]
    public sealed class ClusterLoggingInfoBrokerLogsFirehose
    {
        /// <summary>
        /// Name of the Kinesis Data Firehose delivery stream to deliver logs to.
        /// </summary>
        public readonly string? DeliveryStream;
        /// <summary>
        /// Indicates whether you want to enable or disable streaming broker logs to Cloudwatch Logs.
        /// </summary>
        public readonly bool Enabled;

        [OutputConstructor]
        private ClusterLoggingInfoBrokerLogsFirehose(
            string? deliveryStream,

            bool enabled)
        {
            DeliveryStream = deliveryStream;
            Enabled = enabled;
        }
    }
}
