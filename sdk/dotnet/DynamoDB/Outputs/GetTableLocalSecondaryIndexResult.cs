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
    public sealed class GetTableLocalSecondaryIndexResult
    {
        /// <summary>
        /// The name of the DynamoDB table.
        /// </summary>
        public readonly string Name;
        public readonly ImmutableArray<string> NonKeyAttributes;
        public readonly string ProjectionType;
        public readonly string RangeKey;

        [OutputConstructor]
        private GetTableLocalSecondaryIndexResult(
            string name,

            ImmutableArray<string> nonKeyAttributes,

            string projectionType,

            string rangeKey)
        {
            Name = name;
            NonKeyAttributes = nonKeyAttributes;
            ProjectionType = projectionType;
            RangeKey = rangeKey;
        }
    }
}
