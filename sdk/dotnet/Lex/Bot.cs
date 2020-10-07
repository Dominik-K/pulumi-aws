// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Lex
{
    /// <summary>
    /// Provides an Amazon Lex Bot resource. For more information see
    /// [Amazon Lex: How It Works](https://docs.aws.amazon.com/lex/latest/dg/how-it-works.html)
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var orderFlowersBot = new Aws.Lex.Bot("orderFlowersBot", new Aws.Lex.BotArgs
    ///         {
    ///             AbortStatement = new Aws.Lex.Inputs.BotAbortStatementArgs
    ///             {
    ///                 Messages = 
    ///                 {
    ///                     new Aws.Lex.Inputs.BotAbortStatementMessageArgs
    ///                     {
    ///                         Content = "Sorry, I am not able to assist at this time",
    ///                         ContentType = "PlainText",
    ///                     },
    ///                 },
    ///             },
    ///             ChildDirected = false,
    ///             ClarificationPrompt = new Aws.Lex.Inputs.BotClarificationPromptArgs
    ///             {
    ///                 MaxAttempts = 2,
    ///                 Messages = 
    ///                 {
    ///                     new Aws.Lex.Inputs.BotClarificationPromptMessageArgs
    ///                     {
    ///                         Content = "I didn't understand you, what would you like to do?",
    ///                         ContentType = "PlainText",
    ///                     },
    ///                 },
    ///             },
    ///             CreateVersion = false,
    ///             Description = "Bot to order flowers on the behalf of a user",
    ///             IdleSessionTtlInSeconds = 600,
    ///             Intents = 
    ///             {
    ///                 new Aws.Lex.Inputs.BotIntentArgs
    ///                 {
    ///                     IntentName = "OrderFlowers",
    ///                     IntentVersion = "1",
    ///                 },
    ///             },
    ///             Locale = "en-US",
    ///             ProcessBehavior = "BUILD",
    ///             VoiceId = "Salli",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class Bot : Pulumi.CustomResource
    {
        /// <summary>
        /// The message that Amazon Lex uses to abort a conversation. Attributes are documented under statement.
        /// </summary>
        [Output("abortStatement")]
        public Output<Outputs.BotAbortStatement> AbortStatement { get; private set; } = null!;

        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// Checksum identifying the version of the bot that was created. The checksum is not
        /// included as an argument because the resource will add it automatically when updating the bot.
        /// </summary>
        [Output("checksum")]
        public Output<string> Checksum { get; private set; } = null!;

        /// <summary>
        /// By specifying true, you confirm that your use of Amazon Lex is related to a website, program, or other application that is directed or targeted, in whole or in part, to children under age 13 and subject to COPPA. For more information see the [Amazon Lex FAQ](https://aws.amazon.com/lex/faqs#data-security) and the [Amazon Lex PutBot API Docs](https://docs.aws.amazon.com/lex/latest/dg/API_PutBot.html#lex-PutBot-request-childDirected).
        /// </summary>
        [Output("childDirected")]
        public Output<bool> ChildDirected { get; private set; } = null!;

        /// <summary>
        /// The message that Amazon Lex uses when it doesn't understand the user's request. Attributes are documented under prompt.
        /// </summary>
        [Output("clarificationPrompt")]
        public Output<Outputs.BotClarificationPrompt?> ClarificationPrompt { get; private set; } = null!;

        /// <summary>
        /// Determines if a new bot version is created when the initial resource is created and on each update. Defaults to `false`.
        /// </summary>
        [Output("createVersion")]
        public Output<bool?> CreateVersion { get; private set; } = null!;

        /// <summary>
        /// The date when the bot version was created.
        /// </summary>
        [Output("createdDate")]
        public Output<string> CreatedDate { get; private set; } = null!;

        /// <summary>
        /// A description of the bot.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// When set to true user utterances are sent to Amazon Comprehend for sentiment analysis. If you don't specify detectSentiment, the default is `false`.
        /// </summary>
        [Output("detectSentiment")]
        public Output<bool?> DetectSentiment { get; private set; } = null!;

        /// <summary>
        /// Set to `true` to enable access to natural language understanding improvements. When you set the `enable_model_improvements` parameter to true you can use the `nlu_intent_confidence_threshold` parameter to configure confidence scores. For more information, see [Confidence Scores](https://docs.aws.amazon.com/lex/latest/dg/confidence-scores.html). You can only set the `enable_model_improvements` parameter in certain Regions. If you set the parameter to true, your bot has access to accuracy improvements. For more information see the [Amazon Lex Bot PutBot API Docs](https://docs.aws.amazon.com/lex/latest/dg/API_PutBot.html#lex-PutBot-request-enableModelImprovements).
        /// </summary>
        [Output("enableModelImprovements")]
        public Output<bool?> EnableModelImprovements { get; private set; } = null!;

        /// <summary>
        /// If status is FAILED, Amazon Lex provides the reason that it failed to build the bot.
        /// </summary>
        [Output("failureReason")]
        public Output<string> FailureReason { get; private set; } = null!;

        /// <summary>
        /// The maximum time in seconds that Amazon Lex retains the data gathered in a conversation. Default is `300`.
        /// </summary>
        [Output("idleSessionTtlInSeconds")]
        public Output<int?> IdleSessionTtlInSeconds { get; private set; } = null!;

        /// <summary>
        /// A set of Intent objects. Each intent represents a command that a user can express. Attributes are documented under intent.
        /// </summary>
        [Output("intents")]
        public Output<ImmutableArray<Outputs.BotIntent>> Intents { get; private set; } = null!;

        /// <summary>
        /// The date when the $LATEST version of this bot was updated.
        /// </summary>
        [Output("lastUpdatedDate")]
        public Output<string> LastUpdatedDate { get; private set; } = null!;

        /// <summary>
        /// Specifies the target locale for the bot. Any intent used in the bot must be compatible with the locale of the bot. For available locales, see [Amazon Lex Bot PutBot API Docs](https://docs.aws.amazon.com/lex/latest/dg/API_PutBot.html#lex-PutBot-request-locale). Default is `en-US`.
        /// </summary>
        [Output("locale")]
        public Output<string?> Locale { get; private set; } = null!;

        /// <summary>
        /// The name of the bot that you want to create, case sensitive.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Determines the threshold where Amazon Lex will insert the AMAZON.FallbackIntent, AMAZON.KendraSearchIntent, or both when returning alternative intents in a PostContent or PostText response. AMAZON.FallbackIntent and AMAZON.KendraSearchIntent are only inserted if they are configured for the bot. For more information see [Amazon Lex Bot PutBot API Docs](https://docs.aws.amazon.com/lex/latest/dg/API_PutBot.html#lex-PutBot-request-nluIntentConfidenceThreshold) This value requires `enable_model_improvements` to be set to `true` and the default is `0`.
        /// </summary>
        [Output("nluIntentConfidenceThreshold")]
        public Output<double?> NluIntentConfidenceThreshold { get; private set; } = null!;

        /// <summary>
        /// If you set the `process_behavior` element to `BUILD`, Amazon Lex builds the bot so that it can be run. If you set the element to `SAVE` Amazon Lex saves the bot, but doesn't build it. Default is `SAVE`.
        /// </summary>
        [Output("processBehavior")]
        public Output<string?> ProcessBehavior { get; private set; } = null!;

        /// <summary>
        /// When you send a request to create or update a bot, Amazon Lex sets the status response
        /// element to BUILDING. After Amazon Lex builds the bot, it sets status to READY. If Amazon Lex can't
        /// build the bot, it sets status to FAILED. Amazon Lex returns the reason for the failure in the
        /// failure_reason response element.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// The version of the bot.
        /// </summary>
        [Output("version")]
        public Output<string> Version { get; private set; } = null!;

        /// <summary>
        /// The Amazon Polly voice ID that you want Amazon Lex to use for voice interactions with the user. The locale configured for the voice must match the locale of the bot. For more information, see [Available Voices](http://docs.aws.amazon.com/polly/latest/dg/voicelist.html) in the Amazon Polly Developer Guide.
        /// </summary>
        [Output("voiceId")]
        public Output<string> VoiceId { get; private set; } = null!;


        /// <summary>
        /// Create a Bot resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Bot(string name, BotArgs args, CustomResourceOptions? options = null)
            : base("aws:lex/bot:Bot", name, args ?? new BotArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Bot(string name, Input<string> id, BotState? state = null, CustomResourceOptions? options = null)
            : base("aws:lex/bot:Bot", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Bot resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Bot Get(string name, Input<string> id, BotState? state = null, CustomResourceOptions? options = null)
        {
            return new Bot(name, id, state, options);
        }
    }

    public sealed class BotArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The message that Amazon Lex uses to abort a conversation. Attributes are documented under statement.
        /// </summary>
        [Input("abortStatement", required: true)]
        public Input<Inputs.BotAbortStatementArgs> AbortStatement { get; set; } = null!;

        /// <summary>
        /// By specifying true, you confirm that your use of Amazon Lex is related to a website, program, or other application that is directed or targeted, in whole or in part, to children under age 13 and subject to COPPA. For more information see the [Amazon Lex FAQ](https://aws.amazon.com/lex/faqs#data-security) and the [Amazon Lex PutBot API Docs](https://docs.aws.amazon.com/lex/latest/dg/API_PutBot.html#lex-PutBot-request-childDirected).
        /// </summary>
        [Input("childDirected", required: true)]
        public Input<bool> ChildDirected { get; set; } = null!;

        /// <summary>
        /// The message that Amazon Lex uses when it doesn't understand the user's request. Attributes are documented under prompt.
        /// </summary>
        [Input("clarificationPrompt")]
        public Input<Inputs.BotClarificationPromptArgs>? ClarificationPrompt { get; set; }

        /// <summary>
        /// Determines if a new bot version is created when the initial resource is created and on each update. Defaults to `false`.
        /// </summary>
        [Input("createVersion")]
        public Input<bool>? CreateVersion { get; set; }

        /// <summary>
        /// A description of the bot.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// When set to true user utterances are sent to Amazon Comprehend for sentiment analysis. If you don't specify detectSentiment, the default is `false`.
        /// </summary>
        [Input("detectSentiment")]
        public Input<bool>? DetectSentiment { get; set; }

        /// <summary>
        /// Set to `true` to enable access to natural language understanding improvements. When you set the `enable_model_improvements` parameter to true you can use the `nlu_intent_confidence_threshold` parameter to configure confidence scores. For more information, see [Confidence Scores](https://docs.aws.amazon.com/lex/latest/dg/confidence-scores.html). You can only set the `enable_model_improvements` parameter in certain Regions. If you set the parameter to true, your bot has access to accuracy improvements. For more information see the [Amazon Lex Bot PutBot API Docs](https://docs.aws.amazon.com/lex/latest/dg/API_PutBot.html#lex-PutBot-request-enableModelImprovements).
        /// </summary>
        [Input("enableModelImprovements")]
        public Input<bool>? EnableModelImprovements { get; set; }

        /// <summary>
        /// The maximum time in seconds that Amazon Lex retains the data gathered in a conversation. Default is `300`.
        /// </summary>
        [Input("idleSessionTtlInSeconds")]
        public Input<int>? IdleSessionTtlInSeconds { get; set; }

        [Input("intents", required: true)]
        private InputList<Inputs.BotIntentArgs>? _intents;

        /// <summary>
        /// A set of Intent objects. Each intent represents a command that a user can express. Attributes are documented under intent.
        /// </summary>
        public InputList<Inputs.BotIntentArgs> Intents
        {
            get => _intents ?? (_intents = new InputList<Inputs.BotIntentArgs>());
            set => _intents = value;
        }

        /// <summary>
        /// Specifies the target locale for the bot. Any intent used in the bot must be compatible with the locale of the bot. For available locales, see [Amazon Lex Bot PutBot API Docs](https://docs.aws.amazon.com/lex/latest/dg/API_PutBot.html#lex-PutBot-request-locale). Default is `en-US`.
        /// </summary>
        [Input("locale")]
        public Input<string>? Locale { get; set; }

        /// <summary>
        /// The name of the bot that you want to create, case sensitive.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Determines the threshold where Amazon Lex will insert the AMAZON.FallbackIntent, AMAZON.KendraSearchIntent, or both when returning alternative intents in a PostContent or PostText response. AMAZON.FallbackIntent and AMAZON.KendraSearchIntent are only inserted if they are configured for the bot. For more information see [Amazon Lex Bot PutBot API Docs](https://docs.aws.amazon.com/lex/latest/dg/API_PutBot.html#lex-PutBot-request-nluIntentConfidenceThreshold) This value requires `enable_model_improvements` to be set to `true` and the default is `0`.
        /// </summary>
        [Input("nluIntentConfidenceThreshold")]
        public Input<double>? NluIntentConfidenceThreshold { get; set; }

        /// <summary>
        /// If you set the `process_behavior` element to `BUILD`, Amazon Lex builds the bot so that it can be run. If you set the element to `SAVE` Amazon Lex saves the bot, but doesn't build it. Default is `SAVE`.
        /// </summary>
        [Input("processBehavior")]
        public Input<string>? ProcessBehavior { get; set; }

        /// <summary>
        /// The Amazon Polly voice ID that you want Amazon Lex to use for voice interactions with the user. The locale configured for the voice must match the locale of the bot. For more information, see [Available Voices](http://docs.aws.amazon.com/polly/latest/dg/voicelist.html) in the Amazon Polly Developer Guide.
        /// </summary>
        [Input("voiceId")]
        public Input<string>? VoiceId { get; set; }

        public BotArgs()
        {
        }
    }

    public sealed class BotState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The message that Amazon Lex uses to abort a conversation. Attributes are documented under statement.
        /// </summary>
        [Input("abortStatement")]
        public Input<Inputs.BotAbortStatementGetArgs>? AbortStatement { get; set; }

        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// Checksum identifying the version of the bot that was created. The checksum is not
        /// included as an argument because the resource will add it automatically when updating the bot.
        /// </summary>
        [Input("checksum")]
        public Input<string>? Checksum { get; set; }

        /// <summary>
        /// By specifying true, you confirm that your use of Amazon Lex is related to a website, program, or other application that is directed or targeted, in whole or in part, to children under age 13 and subject to COPPA. For more information see the [Amazon Lex FAQ](https://aws.amazon.com/lex/faqs#data-security) and the [Amazon Lex PutBot API Docs](https://docs.aws.amazon.com/lex/latest/dg/API_PutBot.html#lex-PutBot-request-childDirected).
        /// </summary>
        [Input("childDirected")]
        public Input<bool>? ChildDirected { get; set; }

        /// <summary>
        /// The message that Amazon Lex uses when it doesn't understand the user's request. Attributes are documented under prompt.
        /// </summary>
        [Input("clarificationPrompt")]
        public Input<Inputs.BotClarificationPromptGetArgs>? ClarificationPrompt { get; set; }

        /// <summary>
        /// Determines if a new bot version is created when the initial resource is created and on each update. Defaults to `false`.
        /// </summary>
        [Input("createVersion")]
        public Input<bool>? CreateVersion { get; set; }

        /// <summary>
        /// The date when the bot version was created.
        /// </summary>
        [Input("createdDate")]
        public Input<string>? CreatedDate { get; set; }

        /// <summary>
        /// A description of the bot.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// When set to true user utterances are sent to Amazon Comprehend for sentiment analysis. If you don't specify detectSentiment, the default is `false`.
        /// </summary>
        [Input("detectSentiment")]
        public Input<bool>? DetectSentiment { get; set; }

        /// <summary>
        /// Set to `true` to enable access to natural language understanding improvements. When you set the `enable_model_improvements` parameter to true you can use the `nlu_intent_confidence_threshold` parameter to configure confidence scores. For more information, see [Confidence Scores](https://docs.aws.amazon.com/lex/latest/dg/confidence-scores.html). You can only set the `enable_model_improvements` parameter in certain Regions. If you set the parameter to true, your bot has access to accuracy improvements. For more information see the [Amazon Lex Bot PutBot API Docs](https://docs.aws.amazon.com/lex/latest/dg/API_PutBot.html#lex-PutBot-request-enableModelImprovements).
        /// </summary>
        [Input("enableModelImprovements")]
        public Input<bool>? EnableModelImprovements { get; set; }

        /// <summary>
        /// If status is FAILED, Amazon Lex provides the reason that it failed to build the bot.
        /// </summary>
        [Input("failureReason")]
        public Input<string>? FailureReason { get; set; }

        /// <summary>
        /// The maximum time in seconds that Amazon Lex retains the data gathered in a conversation. Default is `300`.
        /// </summary>
        [Input("idleSessionTtlInSeconds")]
        public Input<int>? IdleSessionTtlInSeconds { get; set; }

        [Input("intents")]
        private InputList<Inputs.BotIntentGetArgs>? _intents;

        /// <summary>
        /// A set of Intent objects. Each intent represents a command that a user can express. Attributes are documented under intent.
        /// </summary>
        public InputList<Inputs.BotIntentGetArgs> Intents
        {
            get => _intents ?? (_intents = new InputList<Inputs.BotIntentGetArgs>());
            set => _intents = value;
        }

        /// <summary>
        /// The date when the $LATEST version of this bot was updated.
        /// </summary>
        [Input("lastUpdatedDate")]
        public Input<string>? LastUpdatedDate { get; set; }

        /// <summary>
        /// Specifies the target locale for the bot. Any intent used in the bot must be compatible with the locale of the bot. For available locales, see [Amazon Lex Bot PutBot API Docs](https://docs.aws.amazon.com/lex/latest/dg/API_PutBot.html#lex-PutBot-request-locale). Default is `en-US`.
        /// </summary>
        [Input("locale")]
        public Input<string>? Locale { get; set; }

        /// <summary>
        /// The name of the bot that you want to create, case sensitive.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Determines the threshold where Amazon Lex will insert the AMAZON.FallbackIntent, AMAZON.KendraSearchIntent, or both when returning alternative intents in a PostContent or PostText response. AMAZON.FallbackIntent and AMAZON.KendraSearchIntent are only inserted if they are configured for the bot. For more information see [Amazon Lex Bot PutBot API Docs](https://docs.aws.amazon.com/lex/latest/dg/API_PutBot.html#lex-PutBot-request-nluIntentConfidenceThreshold) This value requires `enable_model_improvements` to be set to `true` and the default is `0`.
        /// </summary>
        [Input("nluIntentConfidenceThreshold")]
        public Input<double>? NluIntentConfidenceThreshold { get; set; }

        /// <summary>
        /// If you set the `process_behavior` element to `BUILD`, Amazon Lex builds the bot so that it can be run. If you set the element to `SAVE` Amazon Lex saves the bot, but doesn't build it. Default is `SAVE`.
        /// </summary>
        [Input("processBehavior")]
        public Input<string>? ProcessBehavior { get; set; }

        /// <summary>
        /// When you send a request to create or update a bot, Amazon Lex sets the status response
        /// element to BUILDING. After Amazon Lex builds the bot, it sets status to READY. If Amazon Lex can't
        /// build the bot, it sets status to FAILED. Amazon Lex returns the reason for the failure in the
        /// failure_reason response element.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// The version of the bot.
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        /// <summary>
        /// The Amazon Polly voice ID that you want Amazon Lex to use for voice interactions with the user. The locale configured for the voice must match the locale of the bot. For more information, see [Available Voices](http://docs.aws.amazon.com/polly/latest/dg/voicelist.html) in the Amazon Polly Developer Guide.
        /// </summary>
        [Input("voiceId")]
        public Input<string>? VoiceId { get; set; }

        public BotState()
        {
        }
    }
}
