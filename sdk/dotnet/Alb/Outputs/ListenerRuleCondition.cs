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
    public sealed class ListenerRuleCondition
    {
        /// <summary>
        /// The type of condition. Valid values are `host-header` or `path-pattern`. Must also set `values`.
        /// </summary>
        public readonly string? Field;
        /// <summary>
        /// Contains a single `values` item which is a list of host header patterns to match. The maximum size of each pattern is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). Only one pattern needs to match for the condition to be satisfied.
        /// </summary>
        public readonly Outputs.ListenerRuleConditionHostHeader? HostHeader;
        /// <summary>
        /// HTTP headers to match. HTTP Header block fields documented below.
        /// </summary>
        public readonly Outputs.ListenerRuleConditionHttpHeader? HttpHeader;
        /// <summary>
        /// Contains a single `values` item which is a list of HTTP request methods or verbs to match. Maximum size is 40 characters. Only allowed characters are A-Z, hyphen (-) and underscore (\_). Comparison is case sensitive. Wildcards are not supported. Only one needs to match for the condition to be satisfied. AWS recommends that GET and HEAD requests are routed in the same way because the response to a HEAD request may be cached.
        /// </summary>
        public readonly Outputs.ListenerRuleConditionHttpRequestMethod? HttpRequestMethod;
        /// <summary>
        /// Contains a single `values` item which is a list of path patterns to match against the request URL. Maximum size of each pattern is 128 characters. Comparison is case sensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). Only one pattern needs to match for the condition to be satisfied. Path pattern is compared only to the path of the URL, not to its query string. To compare against the query string, use a `query_string` condition.
        /// </summary>
        public readonly Outputs.ListenerRuleConditionPathPattern? PathPattern;
        /// <summary>
        /// Query strings to match. Query String block fields documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.ListenerRuleConditionQueryString> QueryStrings;
        /// <summary>
        /// Contains a single `values` item which is a list of source IP CIDR notations to match. You can use both IPv4 and IPv6 addresses. Wildcards are not supported. Condition is satisfied if the source IP address of the request matches one of the CIDR blocks. Condition is not satisfied by the addresses in the `X-Forwarded-For` header, use `http_header` condition instead.
        /// </summary>
        public readonly Outputs.ListenerRuleConditionSourceIp? SourceIp;
        /// <summary>
        /// List of exactly one pattern to match. Required when `field` is set.
        /// </summary>
        public readonly string? Values;

        [OutputConstructor]
        private ListenerRuleCondition(
            string? field,

            Outputs.ListenerRuleConditionHostHeader? hostHeader,

            Outputs.ListenerRuleConditionHttpHeader? httpHeader,

            Outputs.ListenerRuleConditionHttpRequestMethod? httpRequestMethod,

            Outputs.ListenerRuleConditionPathPattern? pathPattern,

            ImmutableArray<Outputs.ListenerRuleConditionQueryString> queryStrings,

            Outputs.ListenerRuleConditionSourceIp? sourceIp,

            string? values)
        {
            Field = field;
            HostHeader = hostHeader;
            HttpHeader = httpHeader;
            HttpRequestMethod = httpRequestMethod;
            PathPattern = pathPattern;
            QueryStrings = queryStrings;
            SourceIp = sourceIp;
            Values = values;
        }
    }
}
