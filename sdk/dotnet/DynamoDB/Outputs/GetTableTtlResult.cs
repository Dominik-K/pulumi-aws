// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.DynamoDB.Outputs
{

    [OutputType]
    public sealed class GetTableTtlResult
    {
        public readonly string AttributeName;
        public readonly bool Enabled;

        [OutputConstructor]
        private GetTableTtlResult(
            string attributeName,

            bool enabled)
        {
            AttributeName = attributeName;
            Enabled = enabled;
        }
    }
}
