// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.MediaStore
{
    /// <summary>
    /// Provides a MediaStore Container Policy.
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
    ///         var currentRegion = Output.Create(Aws.GetRegion.InvokeAsync());
    ///         var currentCallerIdentity = Output.Create(Aws.GetCallerIdentity.InvokeAsync());
    ///         var exampleContainer = new Aws.MediaStore.Container("exampleContainer", new Aws.MediaStore.ContainerArgs
    ///         {
    ///         });
    ///         var exampleContainerPolicy = new Aws.MediaStore.ContainerPolicy("exampleContainerPolicy", new Aws.MediaStore.ContainerPolicyArgs
    ///         {
    ///             ContainerName = exampleContainer.Name,
    ///             Policy = Output.Tuple(currentCallerIdentity, currentRegion, currentCallerIdentity, exampleContainer.Name).Apply(values =&gt;
    ///             {
    ///                 var currentCallerIdentity = values.Item1;
    ///                 var currentRegion = values.Item2;
    ///                 var currentCallerIdentity1 = values.Item3;
    ///                 var name = values.Item4;
    ///                 return @$"{{
    /// 	""Version"": ""2012-10-17"",
    /// 	""Statement"": [{{
    /// 		""Sid"": ""MediaStoreFullAccess"",
    /// 		""Action"": [ ""mediastore:*"" ],
    /// 		""Principal"": {{""AWS"" : ""arn:aws:iam::{currentCallerIdentity.AccountId}:root""}},
    /// 		""Effect"": ""Allow"",
    /// 		""Resource"": ""arn:aws:mediastore:{currentRegion.Name}:{currentCallerIdentity1.AccountId}:container/{name}/*"",
    /// 		""Condition"": {{
    /// 			""Bool"": {{ ""aws:SecureTransport"": ""true"" }}
    /// 		}}
    /// 	}}]
    /// }}
    /// ";
    ///             }),
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class ContainerPolicy : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the container.
        /// </summary>
        [Output("containerName")]
        public Output<string> ContainerName { get; private set; } = null!;

        /// <summary>
        /// The contents of the policy.
        /// </summary>
        [Output("policy")]
        public Output<string> Policy { get; private set; } = null!;


        /// <summary>
        /// Create a ContainerPolicy resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ContainerPolicy(string name, ContainerPolicyArgs args, CustomResourceOptions? options = null)
            : base("aws:mediastore/containerPolicy:ContainerPolicy", name, args ?? new ContainerPolicyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ContainerPolicy(string name, Input<string> id, ContainerPolicyState? state = null, CustomResourceOptions? options = null)
            : base("aws:mediastore/containerPolicy:ContainerPolicy", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ContainerPolicy resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ContainerPolicy Get(string name, Input<string> id, ContainerPolicyState? state = null, CustomResourceOptions? options = null)
        {
            return new ContainerPolicy(name, id, state, options);
        }
    }

    public sealed class ContainerPolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the container.
        /// </summary>
        [Input("containerName", required: true)]
        public Input<string> ContainerName { get; set; } = null!;

        /// <summary>
        /// The contents of the policy.
        /// </summary>
        [Input("policy", required: true)]
        public Input<string> Policy { get; set; } = null!;

        public ContainerPolicyArgs()
        {
        }
    }

    public sealed class ContainerPolicyState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the container.
        /// </summary>
        [Input("containerName")]
        public Input<string>? ContainerName { get; set; }

        /// <summary>
        /// The contents of the policy.
        /// </summary>
        [Input("policy")]
        public Input<string>? Policy { get; set; }

        public ContainerPolicyState()
        {
        }
    }
}
