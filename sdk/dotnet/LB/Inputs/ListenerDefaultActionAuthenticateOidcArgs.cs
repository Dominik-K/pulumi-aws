// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.LB.Inputs
{

    public sealed class ListenerDefaultActionAuthenticateOidcArgs : Pulumi.ResourceArgs
    {
        [Input("authenticationRequestExtraParams")]
        private InputMap<string>? _authenticationRequestExtraParams;

        /// <summary>
        /// The query parameters to include in the redirect request to the authorization endpoint. Max: 10.
        /// </summary>
        public InputMap<string> AuthenticationRequestExtraParams
        {
            get => _authenticationRequestExtraParams ?? (_authenticationRequestExtraParams = new InputMap<string>());
            set => _authenticationRequestExtraParams = value;
        }

        /// <summary>
        /// The authorization endpoint of the IdP.
        /// </summary>
        [Input("authorizationEndpoint", required: true)]
        public Input<string> AuthorizationEndpoint { get; set; } = null!;

        /// <summary>
        /// The OAuth 2.0 client identifier.
        /// </summary>
        [Input("clientId", required: true)]
        public Input<string> ClientId { get; set; } = null!;

        /// <summary>
        /// The OAuth 2.0 client secret.
        /// </summary>
        [Input("clientSecret", required: true)]
        public Input<string> ClientSecret { get; set; } = null!;

        /// <summary>
        /// The OIDC issuer identifier of the IdP.
        /// </summary>
        [Input("issuer", required: true)]
        public Input<string> Issuer { get; set; } = null!;

        /// <summary>
        /// The behavior if the user is not authenticated. Valid values: `deny`, `allow` and `authenticate`
        /// </summary>
        [Input("onUnauthenticatedRequest")]
        public Input<string>? OnUnauthenticatedRequest { get; set; }

        /// <summary>
        /// The set of user claims to be requested from the IdP.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// The name of the cookie used to maintain session information.
        /// </summary>
        [Input("sessionCookieName")]
        public Input<string>? SessionCookieName { get; set; }

        /// <summary>
        /// The maximum duration of the authentication session, in seconds.
        /// </summary>
        [Input("sessionTimeout")]
        public Input<int>? SessionTimeout { get; set; }

        /// <summary>
        /// The token endpoint of the IdP.
        /// </summary>
        [Input("tokenEndpoint", required: true)]
        public Input<string> TokenEndpoint { get; set; } = null!;

        /// <summary>
        /// The user info endpoint of the IdP.
        /// </summary>
        [Input("userInfoEndpoint", required: true)]
        public Input<string> UserInfoEndpoint { get; set; } = null!;

        public ListenerDefaultActionAuthenticateOidcArgs()
        {
        }
    }
}
