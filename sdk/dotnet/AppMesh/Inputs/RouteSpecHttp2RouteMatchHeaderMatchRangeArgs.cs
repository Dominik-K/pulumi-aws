// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppMesh.Inputs
{

    public sealed class RouteSpecHttp2RouteMatchHeaderMatchRangeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The end of the range.
        /// </summary>
        [Input("end", required: true)]
        public Input<int> End { get; set; } = null!;

        /// <summary>
        /// The start of the range.
        /// </summary>
        [Input("start", required: true)]
        public Input<int> Start { get; set; } = null!;

        public RouteSpecHttp2RouteMatchHeaderMatchRangeArgs()
        {
        }
    }
}
