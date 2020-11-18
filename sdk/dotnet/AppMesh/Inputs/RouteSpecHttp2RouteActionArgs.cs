// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppMesh.Inputs
{

    public sealed class RouteSpecHttp2RouteActionArgs : Pulumi.ResourceArgs
    {
        [Input("weightedTargets", required: true)]
        private InputList<Inputs.RouteSpecHttp2RouteActionWeightedTargetArgs>? _weightedTargets;

        /// <summary>
        /// The targets that traffic is routed to when a request matches the route.
        /// You can specify one or more targets and their relative weights with which to distribute traffic.
        /// </summary>
        public InputList<Inputs.RouteSpecHttp2RouteActionWeightedTargetArgs> WeightedTargets
        {
            get => _weightedTargets ?? (_weightedTargets = new InputList<Inputs.RouteSpecHttp2RouteActionWeightedTargetArgs>());
            set => _weightedTargets = value;
        }

        public RouteSpecHttp2RouteActionArgs()
        {
        }
    }
}
