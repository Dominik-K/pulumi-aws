// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.S3.Inputs
{

    public sealed class AnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestinationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The account ID that owns the destination bucket.
        /// </summary>
        [Input("bucketAccountId")]
        public Input<string>? BucketAccountId { get; set; }

        /// <summary>
        /// The ARN of the destination bucket.
        /// </summary>
        [Input("bucketArn", required: true)]
        public Input<string> BucketArn { get; set; } = null!;

        /// <summary>
        /// The output format of exported analytics data. Allowed values: `CSV`. Default value: `CSV`.
        /// </summary>
        [Input("format")]
        public Input<string>? Format { get; set; }

        /// <summary>
        /// Object prefix for filtering.
        /// </summary>
        [Input("prefix")]
        public Input<string>? Prefix { get; set; }

        public AnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestinationArgs()
        {
        }
    }
}
