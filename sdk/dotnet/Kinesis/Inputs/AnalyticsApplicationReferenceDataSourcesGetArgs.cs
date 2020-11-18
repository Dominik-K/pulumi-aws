// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Kinesis.Inputs
{

    public sealed class AnalyticsApplicationReferenceDataSourcesGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ARN of the Kinesis Analytics Application.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// The S3 configuration for the reference data source. See S3 Reference below for more details.
        /// </summary>
        [Input("s3", required: true)]
        public Input<Inputs.AnalyticsApplicationReferenceDataSourcesS3GetArgs> S3 { get; set; } = null!;

        /// <summary>
        /// The Schema format of the data in the streaming source. See Source Schema below for more details.
        /// </summary>
        [Input("schema", required: true)]
        public Input<Inputs.AnalyticsApplicationReferenceDataSourcesSchemaGetArgs> Schema { get; set; } = null!;

        /// <summary>
        /// The in-application Table Name.
        /// </summary>
        [Input("tableName", required: true)]
        public Input<string> TableName { get; set; } = null!;

        public AnalyticsApplicationReferenceDataSourcesGetArgs()
        {
        }
    }
}
