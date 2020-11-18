// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.ElasticLoadBalancing.Outputs
{

    [OutputType]
    public sealed class SslNegotiationPolicyAttribute
    {
        /// <summary>
        /// The name of the attribute
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The value of the attribute
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private SslNegotiationPolicyAttribute(
            string name,

            string value)
        {
            Name = name;
            Value = value;
        }
    }
}
