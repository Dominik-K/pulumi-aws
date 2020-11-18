// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.WafV2.Inputs
{

    public sealed class WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A logical rule statement used to combine other rule statements with AND logic. See AND Statement below for details.
        /// </summary>
        [Input("andStatement")]
        public Input<Inputs.WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementAndStatementGetArgs>? AndStatement { get; set; }

        /// <summary>
        /// A rule statement that defines a string match search for AWS WAF to apply to web requests. See Byte Match Statement below for details.
        /// </summary>
        [Input("byteMatchStatement")]
        public Input<Inputs.WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementByteMatchStatementGetArgs>? ByteMatchStatement { get; set; }

        /// <summary>
        /// A rule statement used to identify web requests based on country of origin. See GEO Match Statement below for details.
        /// </summary>
        [Input("geoMatchStatement")]
        public Input<Inputs.WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementGeoMatchStatementGetArgs>? GeoMatchStatement { get; set; }

        /// <summary>
        /// A rule statement used to detect web requests coming from particular IP addresses or address ranges. See IP Set Reference Statement below for details.
        /// </summary>
        [Input("ipSetReferenceStatement")]
        public Input<Inputs.WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementIpSetReferenceStatementGetArgs>? IpSetReferenceStatement { get; set; }

        /// <summary>
        /// A logical rule statement used to negate the results of another rule statement. See NOT Statement below for details.
        /// </summary>
        [Input("notStatement")]
        public Input<Inputs.WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementNotStatementGetArgs>? NotStatement { get; set; }

        /// <summary>
        /// A logical rule statement used to combine other rule statements with OR logic. See OR Statement below for details.
        /// </summary>
        [Input("orStatement")]
        public Input<Inputs.WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementOrStatementGetArgs>? OrStatement { get; set; }

        /// <summary>
        /// A rule statement used to search web request components for matches with regular expressions. See Regex Pattern Set Reference Statement below for details.
        /// </summary>
        [Input("regexPatternSetReferenceStatement")]
        public Input<Inputs.WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementRegexPatternSetReferenceStatementGetArgs>? RegexPatternSetReferenceStatement { get; set; }

        /// <summary>
        /// A rule statement that compares a number of bytes against the size of a request component, using a comparison operator, such as greater than (&gt;) or less than (&lt;). See Size Constraint Statement below for more details.
        /// </summary>
        [Input("sizeConstraintStatement")]
        public Input<Inputs.WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementSizeConstraintStatementGetArgs>? SizeConstraintStatement { get; set; }

        /// <summary>
        /// An SQL injection match condition identifies the part of web requests, such as the URI or the query string, that you want AWS WAF to inspect. See SQL Injection Match Statement below for details.
        /// </summary>
        [Input("sqliMatchStatement")]
        public Input<Inputs.WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementSqliMatchStatementGetArgs>? SqliMatchStatement { get; set; }

        /// <summary>
        /// A rule statement that defines a cross-site scripting (XSS) match search for AWS WAF to apply to web requests. See XSS Match Statement below for details.
        /// </summary>
        [Input("xssMatchStatement")]
        public Input<Inputs.WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementXssMatchStatementGetArgs>? XssMatchStatement { get; set; }

        public WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementGetArgs()
        {
        }
    }
}
