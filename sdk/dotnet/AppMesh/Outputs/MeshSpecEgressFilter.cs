// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppMesh.Outputs
{

    [OutputType]
    public sealed class MeshSpecEgressFilter
    {
        /// <summary>
        /// The egress filter type. By default, the type is `DROP_ALL`.
        /// Valid values are `ALLOW_ALL` and `DROP_ALL`.
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private MeshSpecEgressFilter(string? type)
        {
            Type = type;
        }
    }
}
