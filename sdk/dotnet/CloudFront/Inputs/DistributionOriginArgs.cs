// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CloudFront.Inputs
{

    public sealed class DistributionOriginArgs : Pulumi.ResourceArgs
    {
        [Input("customHeaders")]
        private InputList<Inputs.DistributionOriginCustomHeaderArgs>? _customHeaders;

        /// <summary>
        /// One or more sub-resources with `name` and
        /// `value` parameters that specify header data that will be sent to the origin
        /// (multiples allowed).
        /// </summary>
        public InputList<Inputs.DistributionOriginCustomHeaderArgs> CustomHeaders
        {
            get => _customHeaders ?? (_customHeaders = new InputList<Inputs.DistributionOriginCustomHeaderArgs>());
            set => _customHeaders = value;
        }

        /// <summary>
        /// The CloudFront custom
        /// origin configuration information. If an S3
        /// origin is required, use `s3_origin_config` instead.
        /// </summary>
        [Input("customOriginConfig")]
        public Input<Inputs.DistributionOriginCustomOriginConfigArgs>? CustomOriginConfig { get; set; }

        /// <summary>
        /// The DNS domain name of either the S3 bucket, or
        /// web site of your custom origin.
        /// </summary>
        [Input("domainName", required: true)]
        public Input<string> DomainName { get; set; } = null!;

        /// <summary>
        /// The unique identifier of the member origin
        /// </summary>
        [Input("originId", required: true)]
        public Input<string> OriginId { get; set; } = null!;

        /// <summary>
        /// An optional element that causes CloudFront to
        /// request your content from a directory in your Amazon S3 bucket or your
        /// custom origin.
        /// </summary>
        [Input("originPath")]
        public Input<string>? OriginPath { get; set; }

        /// <summary>
        /// The CloudFront S3 origin
        /// configuration information. If a custom origin is required, use
        /// `custom_origin_config` instead.
        /// </summary>
        [Input("s3OriginConfig")]
        public Input<Inputs.DistributionOriginS3OriginConfigArgs>? S3OriginConfig { get; set; }

        public DistributionOriginArgs()
        {
        }
    }
}
