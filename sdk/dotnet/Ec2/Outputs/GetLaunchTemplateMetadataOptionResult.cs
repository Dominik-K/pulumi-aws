// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2.Outputs
{

    [OutputType]
    public sealed class GetLaunchTemplateMetadataOptionResult
    {
        /// <summary>
        /// The state of the metadata service: `enabled`, `disabled`.
        /// </summary>
        public readonly string HttpEndpoint;
        /// <summary>
        /// The desired HTTP PUT response hop limit for instance metadata requests.
        /// </summary>
        public readonly int HttpPutResponseHopLimit;
        /// <summary>
        /// If session tokens are required: `optional`, `required`.
        /// </summary>
        public readonly string HttpTokens;

        [OutputConstructor]
        private GetLaunchTemplateMetadataOptionResult(
            string httpEndpoint,

            int httpPutResponseHopLimit,

            string httpTokens)
        {
            HttpEndpoint = httpEndpoint;
            HttpPutResponseHopLimit = httpPutResponseHopLimit;
            HttpTokens = httpTokens;
        }
    }
}
