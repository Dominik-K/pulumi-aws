// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.LB.Outputs
{

    [OutputType]
    public sealed class GetListenerDefaultActionAuthenticateCognitoResult
    {
        public readonly ImmutableDictionary<string, string> AuthenticationRequestExtraParams;
        public readonly string OnUnauthenticatedRequest;
        public readonly string Scope;
        public readonly string SessionCookieName;
        public readonly int SessionTimeout;
        public readonly string UserPoolArn;
        public readonly string UserPoolClientId;
        public readonly string UserPoolDomain;

        [OutputConstructor]
        private GetListenerDefaultActionAuthenticateCognitoResult(
            ImmutableDictionary<string, string> authenticationRequestExtraParams,

            string onUnauthenticatedRequest,

            string scope,

            string sessionCookieName,

            int sessionTimeout,

            string userPoolArn,

            string userPoolClientId,

            string userPoolDomain)
        {
            AuthenticationRequestExtraParams = authenticationRequestExtraParams;
            OnUnauthenticatedRequest = onUnauthenticatedRequest;
            Scope = scope;
            SessionCookieName = sessionCookieName;
            SessionTimeout = sessionTimeout;
            UserPoolArn = userPoolArn;
            UserPoolClientId = userPoolClientId;
            UserPoolDomain = userPoolDomain;
        }
    }
}
