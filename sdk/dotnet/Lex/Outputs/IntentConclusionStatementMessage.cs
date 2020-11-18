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
    public sealed class IntentConclusionStatementMessage
    {
        /// <summary>
        /// The text of the message. Must be less than or equal to 1000 characters in length.
        /// </summary>
        public readonly string Content;
        /// <summary>
        /// The content type of the message string.
        /// </summary>
        public readonly string ContentType;
        /// <summary>
        /// Identifies the message group that the message belongs to. When a group
        /// is assigned to a message, Amazon Lex returns one message from each group in the response. Must be a number between 1 and 5 (inclusive).
        /// </summary>
        public readonly int? GroupNumber;

        [OutputConstructor]
        private IntentConclusionStatementMessage(
            string content,

            string contentType,

            int? groupNumber)
        {
            Content = content;
            ContentType = contentType;
            GroupNumber = groupNumber;
        }
    }
}
