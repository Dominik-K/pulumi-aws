// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CloudFront.Outputs
{

    [OutputType]
    public sealed class DistributionLoggingConfig
    {
        /// <summary>
        /// The Amazon S3 bucket to store the access logs in, for
        /// example, `myawslogbucket.s3.amazonaws.com`.
        /// </summary>
        public readonly string Bucket;
        /// <summary>
        /// Specifies whether you want CloudFront to
        /// include cookies in access logs (default: `false`).
        /// </summary>
        public readonly bool? IncludeCookies;
        /// <summary>
        /// An optional string that you want CloudFront to prefix
        /// to the access log filenames for this distribution, for example, `myprefix/`.
        /// </summary>
        public readonly string? Prefix;

        [OutputConstructor]
        private DistributionLoggingConfig(
            string bucket,

            bool? includeCookies,

            string? prefix)
        {
            Bucket = bucket;
            IncludeCookies = includeCookies;
            Prefix = prefix;
        }
    }
}
