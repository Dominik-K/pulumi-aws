// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CloudWatch.Outputs
{

    [OutputType]
    public sealed class EventTargetRunCommandTarget
    {
        /// <summary>
        /// Can be either `tag:tag-key` or `InstanceIds`.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// If Key is `tag:tag-key`, Values is a list of tag values. If Key is `InstanceIds`, Values is a list of Amazon EC2 instance IDs.
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private EventTargetRunCommandTarget(
            string key,

            ImmutableArray<string> values)
        {
            Key = key;
            Values = values;
        }
    }
}
