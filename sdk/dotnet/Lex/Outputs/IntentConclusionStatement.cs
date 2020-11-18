// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Lex.Outputs
{

    [OutputType]
    public sealed class IntentConclusionStatement
    {
        /// <summary>
        /// A set of messages, each of which provides a message string and its type.
        /// You can specify the message string in plain text or in Speech Synthesis Markup Language (SSML).
        /// Attributes are documented under message. Must contain between 1 and 15 messages.
        /// </summary>
        public readonly ImmutableArray<Outputs.IntentConclusionStatementMessage> Messages;
        /// <summary>
        /// The response card. Amazon Lex will substitute session attributes and
        /// slot values into the response card. For more information, see
        /// [Example: Using a Response Card](https://docs.aws.amazon.com/lex/latest/dg/ex-resp-card.html). Must be less than or equal to 50000 characters in length.
        /// </summary>
        public readonly string? ResponseCard;

        [OutputConstructor]
        private IntentConclusionStatement(
            ImmutableArray<Outputs.IntentConclusionStatementMessage> messages,

            string? responseCard)
        {
            Messages = messages;
            ResponseCard = responseCard;
        }
    }
}
