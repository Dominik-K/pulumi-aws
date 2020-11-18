// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Alb.Outputs
{

    [OutputType]
    public sealed class GetListenerDefaultActionAuthenticateOidcResult
    {
        public readonly ImmutableDictionary<string, string> AuthenticationRequestExtraParams;
        public readonly string AuthorizationEndpoint;
        public readonly string ClientId;
        public readonly string ClientSecret;
        public readonly string Issuer;
        public readonly string OnUnauthenticatedRequest;
        public readonly string Scope;
        public readonly string SessionCookieName;
        public readonly int SessionTimeout;
        public readonly string TokenEndpoint;
        public readonly string UserInfoEndpoint;

        [OutputConstructor]
        private GetListenerDefaultActionAuthenticateOidcResult(
            ImmutableDictionary<string, string> authenticationRequestExtraParams,

            string authorizationEndpoint,

            string clientId,

            string clientSecret,

            string issuer,

            string onUnauthenticatedRequest,

            string scope,

            string sessionCookieName,

            int sessionTimeout,

            string tokenEndpoint,

            string userInfoEndpoint)
        {
            AuthenticationRequestExtraParams = authenticationRequestExtraParams;
            AuthorizationEndpoint = authorizationEndpoint;
            ClientId = clientId;
            ClientSecret = clientSecret;
            Issuer = issuer;
            OnUnauthenticatedRequest = onUnauthenticatedRequest;
            Scope = scope;
            SessionCookieName = sessionCookieName;
            SessionTimeout = sessionTimeout;
            TokenEndpoint = tokenEndpoint;
            UserInfoEndpoint = userInfoEndpoint;
        }
    }
}
