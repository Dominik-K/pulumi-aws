// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.DataSync.Inputs
{

    public sealed class S3LocationS3ConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Amazon Resource Names (ARN) of the IAM Role used to connect to the S3 Bucket.
        /// </summary>
        [Input("bucketAccessRoleArn", required: true)]
        public Input<string> BucketAccessRoleArn { get; set; } = null!;

        public S3LocationS3ConfigArgs()
        {
        }
    }
}
