// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppMesh.Inputs
{

    public sealed class RouteSpecGrpcRouteMatchMetadataArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// If `true`, the match is on the opposite of the `match` criteria. Default is `false`.
        /// </summary>
        [Input("invert")]
        public Input<bool>? Invert { get; set; }

        /// <summary>
        /// The data to match from the request.
        /// </summary>
        [Input("match")]
        public Input<Inputs.RouteSpecGrpcRouteMatchMetadataMatchArgs>? Match { get; set; }

        /// <summary>
        /// The name of the route.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public RouteSpecGrpcRouteMatchMetadataArgs()
        {
        }
    }
}
