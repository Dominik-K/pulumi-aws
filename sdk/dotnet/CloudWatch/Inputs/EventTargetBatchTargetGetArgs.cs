// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CloudWatch.Inputs
{

    public sealed class EventTargetBatchTargetGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The size of the array, if this is an array batch job. Valid values are integers between 2 and 10,000.
        /// </summary>
        [Input("arraySize")]
        public Input<int>? ArraySize { get; set; }

        /// <summary>
        /// The number of times to attempt to retry, if the job fails. Valid values are 1 to 10.
        /// </summary>
        [Input("jobAttempts")]
        public Input<int>? JobAttempts { get; set; }

        /// <summary>
        /// The ARN or name of the job definition to use if the event target is an AWS Batch job. This job definition must already exist.
        /// </summary>
        [Input("jobDefinition", required: true)]
        public Input<string> JobDefinition { get; set; } = null!;

        /// <summary>
        /// The name to use for this execution of the job, if the target is an AWS Batch job.
        /// </summary>
        [Input("jobName", required: true)]
        public Input<string> JobName { get; set; } = null!;

        public EventTargetBatchTargetGetArgs()
        {
        }
    }
}
