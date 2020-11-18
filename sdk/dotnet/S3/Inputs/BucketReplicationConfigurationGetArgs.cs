// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.S3.Inputs
{

    public sealed class BucketReplicationConfigurationGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ARN of the IAM role for Amazon S3 to assume when replicating the objects.
        /// </summary>
        [Input("role", required: true)]
        public Input<string> Role { get; set; } = null!;

        [Input("rules", required: true)]
        private InputList<Inputs.BucketReplicationConfigurationRuleGetArgs>? _rules;

        /// <summary>
        /// Specifies the rules managing the replication (documented below).
        /// </summary>
        public InputList<Inputs.BucketReplicationConfigurationRuleGetArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.BucketReplicationConfigurationRuleGetArgs>());
            set => _rules = value;
        }

        public BucketReplicationConfigurationGetArgs()
        {
        }
    }
}
