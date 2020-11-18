// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ssm.Inputs
{

    public sealed class AssociationOutputLocationGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The S3 bucket name.
        /// </summary>
        [Input("s3BucketName", required: true)]
        public Input<string> S3BucketName { get; set; } = null!;

        /// <summary>
        /// The S3 bucket prefix. Results stored in the root if not configured.
        /// </summary>
        [Input("s3KeyPrefix")]
        public Input<string>? S3KeyPrefix { get; set; }

        public AssociationOutputLocationGetArgs()
        {
        }
    }
}
