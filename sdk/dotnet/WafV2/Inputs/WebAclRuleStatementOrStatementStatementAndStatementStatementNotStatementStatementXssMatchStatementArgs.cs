// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.WafV2.Inputs
{

    public sealed class WebAclRuleStatementOrStatementStatementAndStatementStatementNotStatementStatementXssMatchStatementArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The part of a web request that you want AWS WAF to inspect. See Field to Match below for details.
        /// </summary>
        [Input("fieldToMatch")]
        public Input<Inputs.WebAclRuleStatementOrStatementStatementAndStatementStatementNotStatementStatementXssMatchStatementFieldToMatchArgs>? FieldToMatch { get; set; }

        [Input("textTransformations", required: true)]
        private InputList<Inputs.WebAclRuleStatementOrStatementStatementAndStatementStatementNotStatementStatementXssMatchStatementTextTransformationArgs>? _textTransformations;

        /// <summary>
        /// Text transformations eliminate some of the unusual formatting that attackers use in web requests in an effort to bypass detection. See Text Transformation below for details.
        /// </summary>
        public InputList<Inputs.WebAclRuleStatementOrStatementStatementAndStatementStatementNotStatementStatementXssMatchStatementTextTransformationArgs> TextTransformations
        {
            get => _textTransformations ?? (_textTransformations = new InputList<Inputs.WebAclRuleStatementOrStatementStatementAndStatementStatementNotStatementStatementXssMatchStatementTextTransformationArgs>());
            set => _textTransformations = value;
        }

        public WebAclRuleStatementOrStatementStatementAndStatementStatementNotStatementStatementXssMatchStatementArgs()
        {
        }
    }
}
