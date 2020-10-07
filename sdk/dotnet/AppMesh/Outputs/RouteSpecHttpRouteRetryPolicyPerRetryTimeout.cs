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
    public sealed class RouteSpecHttpRouteRetryPolicyPerRetryTimeout
    {
        /// <summary>
        /// Retry unit. Valid values: `ms`, `s`.
        /// </summary>
        public readonly string Unit;
        /// <summary>
        /// Retry value.
        /// </summary>
        public readonly int Value;

        [OutputConstructor]
        private RouteSpecHttpRouteRetryPolicyPerRetryTimeout(
            string unit,

            int value)
        {
            Unit = unit;
            Value = value;
        }
    }
}
