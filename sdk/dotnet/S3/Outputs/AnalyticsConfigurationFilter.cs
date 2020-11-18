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
    public sealed class AnalyticsConfigurationFilter
    {
        /// <summary>
        /// Object prefix for filtering.
        /// </summary>
        public readonly string? Prefix;
        /// <summary>
        /// Set of object tags for filtering.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;

        [OutputConstructor]
        private AnalyticsConfigurationFilter(
            string? prefix,

            ImmutableDictionary<string, string>? tags)
        {
            Prefix = prefix;
            Tags = tags;
        }
    }
}
