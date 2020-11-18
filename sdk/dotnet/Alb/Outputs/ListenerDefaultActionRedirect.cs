// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Alb.Outputs
{

    [OutputType]
    public sealed class ListenerDefaultActionRedirect
    {
        /// <summary>
        /// The hostname. This component is not percent-encoded. The hostname can contain `#{host}`. Defaults to `#{host}`.
        /// </summary>
        public readonly string? Host;
        /// <summary>
        /// The absolute path, starting with the leading "/". This component is not percent-encoded. The path can contain #{host}, #{path}, and #{port}. Defaults to `/#{path}`.
        /// </summary>
        public readonly string? Path;
        /// <summary>
        /// The port. Specify a value from `1` to `65535` or `#{port}`. Defaults to `#{port}`.
        /// </summary>
        public readonly string? Port;
        /// <summary>
        /// The protocol. Valid values are `HTTP`, `HTTPS`, or `#{protocol}`. Defaults to `#{protocol}`.
        /// </summary>
        public readonly string? Protocol;
        /// <summary>
        /// The query parameters, URL-encoded when necessary, but not percent-encoded. Do not include the leading "?". Defaults to `#{query}`.
        /// </summary>
        public readonly string? Query;
        /// <summary>
        /// The HTTP redirect code. The redirect is either permanent (`HTTP_301`) or temporary (`HTTP_302`).
        /// </summary>
        public readonly string StatusCode;

        [OutputConstructor]
        private ListenerDefaultActionRedirect(
            string? host,

            string? path,

            string? port,

            string? protocol,

            string? query,

            string statusCode)
        {
            Host = host;
            Path = path;
            Port = port;
            Protocol = protocol;
            Query = query;
            StatusCode = statusCode;
        }
    }
}
