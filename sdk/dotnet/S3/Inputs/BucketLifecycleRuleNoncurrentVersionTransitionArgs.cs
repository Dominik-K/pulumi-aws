// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.S3.Inputs
{

    public sealed class BucketLifecycleRuleNoncurrentVersionTransitionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the number of days noncurrent object versions transition.
        /// </summary>
        [Input("days")]
        public Input<int>? Days { get; set; }

        /// <summary>
        /// Specifies the Amazon S3 storage class to which you want the noncurrent object versions to transition. Can be `ONEZONE_IA`, `STANDARD_IA`, `INTELLIGENT_TIERING`, `GLACIER`, or `DEEP_ARCHIVE`.
        /// </summary>
        [Input("storageClass", required: true)]
        public Input<string> StorageClass { get; set; } = null!;

        public BucketLifecycleRuleNoncurrentVersionTransitionArgs()
        {
        }
    }
}
