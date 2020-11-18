// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.WafV2.Inputs
{

    public sealed class WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementByteMatchStatementGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The part of a web request that you want AWS WAF to inspect. See Field to Match below for details.
        /// </summary>
        [Input("fieldToMatch")]
        public Input<Inputs.WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementByteMatchStatementFieldToMatchGetArgs>? FieldToMatch { get; set; }

        /// <summary>
        /// The area within the portion of a web request that you want AWS WAF to search for `search_string`. Valid values include the following: `EXACTLY`, `STARTS_WITH`, `ENDS_WITH`, `CONTAINS`, `CONTAINS_WORD`. See the AWS [documentation](https://docs.aws.amazon.com/waf/latest/APIReference/API_ByteMatchStatement.html) for more information.
        /// </summary>
        [Input("positionalConstraint", required: true)]
        public Input<string> PositionalConstraint { get; set; } = null!;

        /// <summary>
        /// A string value that you want AWS WAF to search for. AWS WAF searches only in the part of web requests that you designate for inspection in `field_to_match`. The maximum length of the value is 50 bytes.
        /// </summary>
        [Input("searchString", required: true)]
        public Input<string> SearchString { get; set; } = null!;

        [Input("textTransformations", required: true)]
        private InputList<Inputs.WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementByteMatchStatementTextTransformationGetArgs>? _textTransformations;

        /// <summary>
        /// Text transformations eliminate some of the unusual formatting that attackers use in web requests in an effort to bypass detection. See Text Transformation below for details.
        /// </summary>
        public InputList<Inputs.WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementByteMatchStatementTextTransformationGetArgs> TextTransformations
        {
            get => _textTransformations ?? (_textTransformations = new InputList<Inputs.WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementByteMatchStatementTextTransformationGetArgs>());
            set => _textTransformations = value;
        }

        public WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementByteMatchStatementGetArgs()
        {
        }
    }
}
