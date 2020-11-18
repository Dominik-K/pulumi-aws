// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CodeCommit
{
    /// <summary>
    /// Provides a CodeCommit Trigger Resource.
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
    ///         var testRepository = new Aws.CodeCommit.Repository("testRepository", new Aws.CodeCommit.RepositoryArgs
    ///         {
    ///             RepositoryName = "test",
    ///         });
    ///         var testTrigger = new Aws.CodeCommit.Trigger("testTrigger", new Aws.CodeCommit.TriggerArgs
    ///         {
    ///             RepositoryName = testRepository.RepositoryName,
    ///             Triggers = 
    ///             {
    ///                 new Aws.CodeCommit.Inputs.TriggerTriggerArgs
    ///                 {
    ///                     Name = "all",
    ///                     Events = 
    ///                     {
    ///                         "all",
    ///                     },
    ///                     DestinationArn = aws_sns_topic.Test.Arn,
    ///                 },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class Trigger : Pulumi.CustomResource
    {
        [Output("configurationId")]
        public Output<string> ConfigurationId { get; private set; } = null!;

        /// <summary>
        /// The name for the repository. This needs to be less than 100 characters.
        /// </summary>
        [Output("repositoryName")]
        public Output<string> RepositoryName { get; private set; } = null!;

        [Output("triggers")]
        public Output<ImmutableArray<Outputs.TriggerTrigger>> Triggers { get; private set; } = null!;


        /// <summary>
        /// Create a Trigger resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Trigger(string name, TriggerArgs args, CustomResourceOptions? options = null)
            : base("aws:codecommit/trigger:Trigger", name, args ?? new TriggerArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Trigger(string name, Input<string> id, TriggerState? state = null, CustomResourceOptions? options = null)
            : base("aws:codecommit/trigger:Trigger", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Trigger resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Trigger Get(string name, Input<string> id, TriggerState? state = null, CustomResourceOptions? options = null)
        {
            return new Trigger(name, id, state, options);
        }
    }

    public sealed class TriggerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name for the repository. This needs to be less than 100 characters.
        /// </summary>
        [Input("repositoryName", required: true)]
        public Input<string> RepositoryName { get; set; } = null!;

        [Input("triggers", required: true)]
        private InputList<Inputs.TriggerTriggerArgs>? _triggers;
        public InputList<Inputs.TriggerTriggerArgs> Triggers
        {
            get => _triggers ?? (_triggers = new InputList<Inputs.TriggerTriggerArgs>());
            set => _triggers = value;
        }

        public TriggerArgs()
        {
        }
    }

    public sealed class TriggerState : Pulumi.ResourceArgs
    {
        [Input("configurationId")]
        public Input<string>? ConfigurationId { get; set; }

        /// <summary>
        /// The name for the repository. This needs to be less than 100 characters.
        /// </summary>
        [Input("repositoryName")]
        public Input<string>? RepositoryName { get; set; }

        [Input("triggers")]
        private InputList<Inputs.TriggerTriggerGetArgs>? _triggers;
        public InputList<Inputs.TriggerTriggerGetArgs> Triggers
        {
            get => _triggers ?? (_triggers = new InputList<Inputs.TriggerTriggerGetArgs>());
            set => _triggers = value;
        }

        public TriggerState()
        {
        }
    }
}