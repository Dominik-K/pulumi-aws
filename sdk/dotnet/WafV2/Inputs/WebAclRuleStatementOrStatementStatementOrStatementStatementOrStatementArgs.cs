// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.WafV2.Inputs
{

    public sealed class WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementArgs : Pulumi.ResourceArgs
    {
        [Input("statements", required: true)]
        private InputList<Inputs.WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementArgs>? _statements;

        /// <summary>
        /// The statements to combine with `OR` logic. You can use any statements that can be nested. See Statement above for details.
        /// </summary>
        public InputList<Inputs.WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementArgs> Statements
        {
            get => _statements ?? (_statements = new InputList<Inputs.WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementStatementArgs>());
            set => _statements = value;
        }

        public WebAclRuleStatementOrStatementStatementOrStatementStatementOrStatementArgs()
        {
        }
    }
}
