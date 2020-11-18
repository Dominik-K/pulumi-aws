// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.S3.Outputs
{

    [OutputType]
    public sealed class BucketLifecycleRuleTransition
    {
        /// <summary>
        /// Specifies the date after which you want the corresponding action to take effect.
        /// </summary>
        public readonly string? Date;
        /// <summary>
        /// Specifies the number of days after object creation when the specific rule action takes effect.
        /// </summary>
        public readonly int? Days;
        /// <summary>
        /// Specifies the Amazon S3 storage class to which you want the object to transition. Can be `ONEZONE_IA`, `STANDARD_IA`, `INTELLIGENT_TIERING`, `GLACIER`, or `DEEP_ARCHIVE`.
        /// </summary>
        public readonly string StorageClass;

        [OutputConstructor]
        private BucketLifecycleRuleTransition(
            string? date,

            int? days,

            string storageClass)
        {
            Date = date;
            Days = days;
            StorageClass = storageClass;
        }
    }
}
