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
    public sealed class GatewayRouteSpecHttpRouteActionTargetVirtualService
    {
        /// <summary>
        /// The name of the virtual service that traffic is routed to.
        /// </summary>
        public readonly string VirtualServiceName;

        [OutputConstructor]
        private GatewayRouteSpecHttpRouteActionTargetVirtualService(string virtualServiceName)
        {
            VirtualServiceName = virtualServiceName;
        }
    }
}
