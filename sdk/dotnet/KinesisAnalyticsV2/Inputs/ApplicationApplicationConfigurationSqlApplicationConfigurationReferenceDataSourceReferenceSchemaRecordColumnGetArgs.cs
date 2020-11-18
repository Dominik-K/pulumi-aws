// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.KinesisAnalyticsV2.Inputs
{

    public sealed class ApplicationApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordColumnGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A reference to the data element in the streaming input or the reference data source.
        /// </summary>
        [Input("mapping")]
        public Input<string>? Mapping { get; set; }

        /// <summary>
        /// The name of the column that is created in the in-application input stream or reference table.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The type of column created in the in-application input stream or reference table.
        /// </summary>
        [Input("sqlType", required: true)]
        public Input<string> SqlType { get; set; } = null!;

        public ApplicationApplicationConfigurationSqlApplicationConfigurationReferenceDataSourceReferenceSchemaRecordColumnGetArgs()
        {
        }
    }
}
