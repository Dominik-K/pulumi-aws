// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.WafV2.Outputs
{

    [OutputType]
    public sealed class WebAclRuleStatementIpSetReferenceStatementIpSetForwardedIpConfig
    {
        /// <summary>
        /// - The match status to assign to the web request if the request doesn't have a valid IP address in the specified position. Valid values include: `MATCH` or `NO_MATCH`.
        /// </summary>
        public readonly string FallbackBehavior;
        /// <summary>
        /// - The name of the HTTP header to use for the IP address.
        /// </summary>
        public readonly string HeaderName;
        /// <summary>
        /// - The position in the header to search for the IP address. Valid values include: `FIRST`, `LAST`, or `ANY`. If `ANY` is specified and the header contains more than 10 IP addresses, AWS WAFv2 inspects the last 10.
        /// </summary>
        public readonly string Position;

        [OutputConstructor]
        private WebAclRuleStatementIpSetReferenceStatementIpSetForwardedIpConfig(
            string fallbackBehavior,

            string headerName,

            string position)
        {
            FallbackBehavior = fallbackBehavior;
            HeaderName = headerName;
            Position = position;
        }
    }
}
