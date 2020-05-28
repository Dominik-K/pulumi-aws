// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Iam
{
    /// <summary>
    /// Provides an IAM OpenID Connect provider.
    /// 
    /// ## Example Usage
    /// 
    /// 
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var @default = new Aws.Iam.OpenIdConnectProvider("default", new Aws.Iam.OpenIdConnectProviderArgs
    ///         {
    ///             ClientIdLists = 
    ///             {
    ///                 "266362248691-342342xasdasdasda-apps.googleusercontent.com",
    ///             },
    ///             ThumbprintLists = {},
    ///             Url = "https://accounts.google.com",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class OpenIdConnectProvider : Pulumi.CustomResource
    {
        /// <summary>
        /// The ARN assigned by AWS for this provider.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// A list of client IDs (also known as audiences). When a mobile or web app registers with an OpenID Connect provider, they establish a value that identifies the application. (This is the value that's sent as the client_id parameter on OAuth requests.)
        /// </summary>
        [Output("clientIdLists")]
        public Output<ImmutableArray<string>> ClientIdLists { get; private set; } = null!;

        /// <summary>
        /// A list of server certificate thumbprints for the OpenID Connect (OIDC) identity provider's server certificate(s). 
        /// </summary>
        [Output("thumbprintLists")]
        public Output<ImmutableArray<string>> ThumbprintLists { get; private set; } = null!;

        /// <summary>
        /// The URL of the identity provider. Corresponds to the _iss_ claim.
        /// </summary>
        [Output("url")]
        public Output<string> Url { get; private set; } = null!;


        /// <summary>
        /// Create a OpenIdConnectProvider resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public OpenIdConnectProvider(string name, OpenIdConnectProviderArgs args, CustomResourceOptions? options = null)
            : base("aws:iam/openIdConnectProvider:OpenIdConnectProvider", name, args ?? new OpenIdConnectProviderArgs(), MakeResourceOptions(options, ""))
        {
        }

        private OpenIdConnectProvider(string name, Input<string> id, OpenIdConnectProviderState? state = null, CustomResourceOptions? options = null)
            : base("aws:iam/openIdConnectProvider:OpenIdConnectProvider", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing OpenIdConnectProvider resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static OpenIdConnectProvider Get(string name, Input<string> id, OpenIdConnectProviderState? state = null, CustomResourceOptions? options = null)
        {
            return new OpenIdConnectProvider(name, id, state, options);
        }
    }

    public sealed class OpenIdConnectProviderArgs : Pulumi.ResourceArgs
    {
        [Input("clientIdLists", required: true)]
        private InputList<string>? _clientIdLists;

        /// <summary>
        /// A list of client IDs (also known as audiences). When a mobile or web app registers with an OpenID Connect provider, they establish a value that identifies the application. (This is the value that's sent as the client_id parameter on OAuth requests.)
        /// </summary>
        public InputList<string> ClientIdLists
        {
            get => _clientIdLists ?? (_clientIdLists = new InputList<string>());
            set => _clientIdLists = value;
        }

        [Input("thumbprintLists", required: true)]
        private InputList<string>? _thumbprintLists;

        /// <summary>
        /// A list of server certificate thumbprints for the OpenID Connect (OIDC) identity provider's server certificate(s). 
        /// </summary>
        public InputList<string> ThumbprintLists
        {
            get => _thumbprintLists ?? (_thumbprintLists = new InputList<string>());
            set => _thumbprintLists = value;
        }

        /// <summary>
        /// The URL of the identity provider. Corresponds to the _iss_ claim.
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public OpenIdConnectProviderArgs()
        {
        }
    }

    public sealed class OpenIdConnectProviderState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ARN assigned by AWS for this provider.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        [Input("clientIdLists")]
        private InputList<string>? _clientIdLists;

        /// <summary>
        /// A list of client IDs (also known as audiences). When a mobile or web app registers with an OpenID Connect provider, they establish a value that identifies the application. (This is the value that's sent as the client_id parameter on OAuth requests.)
        /// </summary>
        public InputList<string> ClientIdLists
        {
            get => _clientIdLists ?? (_clientIdLists = new InputList<string>());
            set => _clientIdLists = value;
        }

        [Input("thumbprintLists")]
        private InputList<string>? _thumbprintLists;

        /// <summary>
        /// A list of server certificate thumbprints for the OpenID Connect (OIDC) identity provider's server certificate(s). 
        /// </summary>
        public InputList<string> ThumbprintLists
        {
            get => _thumbprintLists ?? (_thumbprintLists = new InputList<string>());
            set => _thumbprintLists = value;
        }

        /// <summary>
        /// The URL of the identity provider. Corresponds to the _iss_ claim.
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        public OpenIdConnectProviderState()
        {
        }
    }
}
