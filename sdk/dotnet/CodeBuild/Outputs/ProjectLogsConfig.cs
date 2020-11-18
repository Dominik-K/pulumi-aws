// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CodeBuild.Outputs
{

    [OutputType]
    public sealed class ProjectLogsConfig
    {
        /// <summary>
        /// Configuration for the builds to store logs to CloudWatch
        /// </summary>
        public readonly Outputs.ProjectLogsConfigCloudwatchLogs? CloudwatchLogs;
        /// <summary>
        /// Configuration for the builds to store logs to S3.
        /// </summary>
        public readonly Outputs.ProjectLogsConfigS3Logs? S3Logs;

        [OutputConstructor]
        private ProjectLogsConfig(
            Outputs.ProjectLogsConfigCloudwatchLogs? cloudwatchLogs,

            Outputs.ProjectLogsConfigS3Logs? s3Logs)
        {
            CloudwatchLogs = cloudwatchLogs;
            S3Logs = s3Logs;
        }
    }
}
