// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.WafV2.Inputs
{

    public sealed class WebAclRuleStatementAndStatementStatementNotStatementGetArgs : Pulumi.ResourceArgs
    {
        [Input("statements", required: true)]
        private InputList<Inputs.WebAclRuleStatementAndStatementStatementNotStatementStatementGetArgs>? _statements;

        /// <summary>
        /// The statement to negate. You can use any statement that can be nested. See Statement above for details.
        /// </summary>
        public InputList<Inputs.WebAclRuleStatementAndStatementStatementNotStatementStatementGetArgs> Statements
        {
            get => _statements ?? (_statements = new InputList<Inputs.WebAclRuleStatementAndStatementStatementNotStatementStatementGetArgs>());
            set => _statements = value;
        }

        public WebAclRuleStatementAndStatementStatementNotStatementGetArgs()
        {
        }
    }
}
