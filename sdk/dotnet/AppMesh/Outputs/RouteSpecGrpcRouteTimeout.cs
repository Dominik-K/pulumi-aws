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
    public sealed class RouteSpecGrpcRouteTimeout
    {
        /// <summary>
        /// The idle timeout. An idle timeout bounds the amount of time that a connection may be idle.
        /// </summary>
        public readonly Outputs.RouteSpecGrpcRouteTimeoutIdle? Idle;
        /// <summary>
        /// The per request timeout.
        /// </summary>
        public readonly Outputs.RouteSpecGrpcRouteTimeoutPerRequest? PerRequest;

        [OutputConstructor]
        private RouteSpecGrpcRouteTimeout(
            Outputs.RouteSpecGrpcRouteTimeoutIdle? idle,

            Outputs.RouteSpecGrpcRouteTimeoutPerRequest? perRequest)
        {
            Idle = idle;
            PerRequest = perRequest;
        }
    }
}
