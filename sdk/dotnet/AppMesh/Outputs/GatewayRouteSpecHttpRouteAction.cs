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
    public sealed class GatewayRouteSpecHttpRouteAction
    {
        /// <summary>
        /// The target that traffic is routed to when a request matches the gateway route.
        /// </summary>
        public readonly Outputs.GatewayRouteSpecHttpRouteActionTarget Target;

        [OutputConstructor]
        private GatewayRouteSpecHttpRouteAction(Outputs.GatewayRouteSpecHttpRouteActionTarget target)
        {
            Target = target;
        }
    }
}
