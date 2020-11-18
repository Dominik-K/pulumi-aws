// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CloudFront.Inputs
{

    public sealed class DistributionOriginS3OriginConfigGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The [CloudFront origin access
        /// identity][5] to associate with the origin.
        /// </summary>
        [Input("originAccessIdentity", required: true)]
        public Input<string> OriginAccessIdentity { get; set; } = null!;

        public DistributionOriginS3OriginConfigGetArgs()
        {
        }
    }
}
