// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.ApiGatewayV2.Inputs
{

    public sealed class AuthorizerJwtConfigurationGetArgs : Pulumi.ResourceArgs
    {
        [Input("audiences")]
        private InputList<string>? _audiences;

        /// <summary>
        /// A list of the intended recipients of the JWT. A valid JWT must provide an aud that matches at least one entry in this list.
        /// </summary>
        public InputList<string> Audiences
        {
            get => _audiences ?? (_audiences = new InputList<string>());
            set => _audiences = value;
        }

        /// <summary>
        /// The base domain of the identity provider that issues JSON Web Tokens, such as the `endpoint` attribute of the `aws.cognito.UserPool` resource.
        /// </summary>
        [Input("issuer")]
        public Input<string>? Issuer { get; set; }

        public AuthorizerJwtConfigurationGetArgs()
        {
        }
    }
}
