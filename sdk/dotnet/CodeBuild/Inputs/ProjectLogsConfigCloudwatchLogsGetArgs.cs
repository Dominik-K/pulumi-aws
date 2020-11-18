// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CodeBuild.Inputs
{

    public sealed class ProjectLogsConfigCloudwatchLogsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The group name of the logs in CloudWatch Logs.
        /// </summary>
        [Input("groupName")]
        public Input<string>? GroupName { get; set; }

        /// <summary>
        /// Current status of logs in S3 for a build project. Valid values: `ENABLED`, `DISABLED`. Defaults to `DISABLED`.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// The stream name of the logs in CloudWatch Logs.
        /// </summary>
        [Input("streamName")]
        public Input<string>? StreamName { get; set; }

        public ProjectLogsConfigCloudwatchLogsGetArgs()
        {
        }
    }
}
