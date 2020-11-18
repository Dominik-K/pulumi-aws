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
    public sealed class RouteSpecHttp2RouteMatch
    {
        /// <summary>
        /// The client request headers to match on.
        /// </summary>
        public readonly ImmutableArray<Outputs.RouteSpecHttp2RouteMatchHeader> Headers;
        /// <summary>
        /// The client request header method to match on. Valid values: `GET`, `HEAD`, `POST`, `PUT`, `DELETE`, `CONNECT`, `OPTIONS`, `TRACE`, `PATCH`.
        /// </summary>
        public readonly string? Method;
        /// <summary>
        /// The value sent by the client must begin with the specified characters.
        /// This parameter must always start with /, which by itself matches all requests to the virtual router service name.
        /// </summary>
        public readonly string Prefix;
        /// <summary>
        /// The client request header scheme to match on. Valid values: `http`, `https`.
        /// </summary>
        public readonly string? Scheme;

        [OutputConstructor]
        private RouteSpecHttp2RouteMatch(
            ImmutableArray<Outputs.RouteSpecHttp2RouteMatchHeader> headers,

            string? method,

            string prefix,

            string? scheme)
        {
            Headers = headers;
            Method = method;
            Prefix = prefix;
            Scheme = scheme;
        }
    }
}
