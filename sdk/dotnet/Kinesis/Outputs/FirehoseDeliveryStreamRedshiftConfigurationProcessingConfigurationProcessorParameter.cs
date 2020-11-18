// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Kinesis.Outputs
{

    [OutputType]
    public sealed class FirehoseDeliveryStreamRedshiftConfigurationProcessingConfigurationProcessorParameter
    {
        /// <summary>
        /// Parameter name. Valid Values: `LambdaArn`, `NumberOfRetries`, `RoleArn`, `BufferSizeInMBs`, `BufferIntervalInSeconds`
        /// </summary>
        public readonly string ParameterName;
        /// <summary>
        /// Parameter value. Must be between 1 and 512 length (inclusive). When providing a Lambda ARN, you should specify the resource version as well.
        /// </summary>
        public readonly string ParameterValue;

        [OutputConstructor]
        private FirehoseDeliveryStreamRedshiftConfigurationProcessingConfigurationProcessorParameter(
            string parameterName,

            string parameterValue)
        {
            ParameterName = parameterName;
            ParameterValue = parameterValue;
        }
    }
}
