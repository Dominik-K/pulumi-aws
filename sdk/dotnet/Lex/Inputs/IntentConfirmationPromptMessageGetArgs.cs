// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Lex.Inputs
{

    public sealed class IntentConfirmationPromptMessageGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The text of the message.
        /// </summary>
        [Input("content", required: true)]
        public Input<string> Content { get; set; } = null!;

        /// <summary>
        /// The content type of the message string.
        /// </summary>
        [Input("contentType", required: true)]
        public Input<string> ContentType { get; set; } = null!;

        /// <summary>
        /// Identifies the message group that the message belongs to. When a group
        /// is assigned to a message, Amazon Lex returns one message from each group in the response.
        /// </summary>
        [Input("groupNumber")]
        public Input<int>? GroupNumber { get; set; }

        public IntentConfirmationPromptMessageGetArgs()
        {
        }
    }
}
