// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Lex.Inputs
{

    public sealed class IntentFollowUpPromptGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Prompts for information from the user. Attributes are documented under prompt.
        /// </summary>
        [Input("prompt", required: true)]
        public Input<Inputs.IntentFollowUpPromptPromptGetArgs> Prompt { get; set; } = null!;

        /// <summary>
        /// When the user answers "no" to the question defined in
        /// `confirmation_prompt`, Amazon Lex responds with this statement to acknowledge that the intent was
        /// canceled.
        /// </summary>
        [Input("rejectionStatement", required: true)]
        public Input<Inputs.IntentFollowUpPromptRejectionStatementGetArgs> RejectionStatement { get; set; } = null!;

        public IntentFollowUpPromptGetArgs()
        {
        }
    }
}
