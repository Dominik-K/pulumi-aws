// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.WafV2.Inputs
{

    public sealed class WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementIpSetReferenceStatementArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) of the IP Set that this statement references.
        /// </summary>
        [Input("arn", required: true)]
        public Input<string> Arn { get; set; } = null!;

        /// <summary>
        /// The configuration for inspecting IP addresses in an HTTP header that you specify, instead of using the IP address that's reported by the web request origin. See IPSet Forwarded IP Config below for more details.
        /// </summary>
        [Input("ipSetForwardedIpConfig")]
        public Input<Inputs.WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementIpSetReferenceStatementIpSetForwardedIpConfigArgs>? IpSetForwardedIpConfig { get; set; }

        public WebAclRuleStatementNotStatementStatementNotStatementStatementAndStatementStatementIpSetReferenceStatementArgs()
        {
        }
    }
}
