// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.ApiGateway
{
    /// <summary>
    /// Provides an API Gateway Usage Plan Key.
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
    ///         var test = new Aws.ApiGateway.RestApi("test", new Aws.ApiGateway.RestApiArgs
    ///         {
    ///         });
    ///         // ...
    ///         var myusageplan = new Aws.ApiGateway.UsagePlan("myusageplan", new Aws.ApiGateway.UsagePlanArgs
    ///         {
    ///             ApiStages = 
    ///             {
    ///                 new Aws.ApiGateway.Inputs.UsagePlanApiStageArgs
    ///                 {
    ///                     ApiId = test.Id,
    ///                     Stage = aws_api_gateway_deployment.Foo.Stage_name,
    ///                 },
    ///             },
    ///         });
    ///         var mykey = new Aws.ApiGateway.ApiKey("mykey", new Aws.ApiGateway.ApiKeyArgs
    ///         {
    ///         });
    ///         var main = new Aws.ApiGateway.UsagePlanKey("main", new Aws.ApiGateway.UsagePlanKeyArgs
    ///         {
    ///             KeyId = mykey.Id,
    ///             KeyType = "API_KEY",
    ///             UsagePlanId = myusageplan.Id,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class UsagePlanKey : Pulumi.CustomResource
    {
        /// <summary>
        /// The identifier of the API key resource.
        /// </summary>
        [Output("keyId")]
        public Output<string> KeyId { get; private set; } = null!;

        /// <summary>
        /// The type of the API key resource. Currently, the valid key type is API_KEY.
        /// </summary>
        [Output("keyType")]
        public Output<string> KeyType { get; private set; } = null!;

        /// <summary>
        /// The name of a usage plan key.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The Id of the usage plan resource representing to associate the key to.
        /// </summary>
        [Output("usagePlanId")]
        public Output<string> UsagePlanId { get; private set; } = null!;

        /// <summary>
        /// The value of a usage plan key.
        /// </summary>
        [Output("value")]
        public Output<string> Value { get; private set; } = null!;


        /// <summary>
        /// Create a UsagePlanKey resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public UsagePlanKey(string name, UsagePlanKeyArgs args, CustomResourceOptions? options = null)
            : base("aws:apigateway/usagePlanKey:UsagePlanKey", name, args ?? new UsagePlanKeyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private UsagePlanKey(string name, Input<string> id, UsagePlanKeyState? state = null, CustomResourceOptions? options = null)
            : base("aws:apigateway/usagePlanKey:UsagePlanKey", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing UsagePlanKey resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static UsagePlanKey Get(string name, Input<string> id, UsagePlanKeyState? state = null, CustomResourceOptions? options = null)
        {
            return new UsagePlanKey(name, id, state, options);
        }
    }

    public sealed class UsagePlanKeyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The identifier of the API key resource.
        /// </summary>
        [Input("keyId", required: true)]
        public Input<string> KeyId { get; set; } = null!;

        /// <summary>
        /// The type of the API key resource. Currently, the valid key type is API_KEY.
        /// </summary>
        [Input("keyType", required: true)]
        public Input<string> KeyType { get; set; } = null!;

        /// <summary>
        /// The Id of the usage plan resource representing to associate the key to.
        /// </summary>
        [Input("usagePlanId", required: true)]
        public Input<string> UsagePlanId { get; set; } = null!;

        public UsagePlanKeyArgs()
        {
        }
    }

    public sealed class UsagePlanKeyState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The identifier of the API key resource.
        /// </summary>
        [Input("keyId")]
        public Input<string>? KeyId { get; set; }

        /// <summary>
        /// The type of the API key resource. Currently, the valid key type is API_KEY.
        /// </summary>
        [Input("keyType")]
        public Input<string>? KeyType { get; set; }

        /// <summary>
        /// The name of a usage plan key.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The Id of the usage plan resource representing to associate the key to.
        /// </summary>
        [Input("usagePlanId")]
        public Input<string>? UsagePlanId { get; set; }

        /// <summary>
        /// The value of a usage plan key.
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public UsagePlanKeyState()
        {
        }
    }
}