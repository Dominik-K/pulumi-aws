// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Rds.Outputs
{

    [OutputType]
    public sealed class ProxyAuth
    {
        /// <summary>
        /// The type of authentication that the proxy uses for connections from the proxy to the underlying database. One of `SECRETS`.
        /// </summary>
        public readonly string? AuthScheme;
        /// <summary>
        /// A user-specified description about the authentication used by a proxy to log in as a specific database user.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Whether to require or disallow AWS Identity and Access Management (IAM) authentication for connections to the proxy. One of `DISABLED`, `REQUIRED`.
        /// </summary>
        public readonly string? IamAuth;
        /// <summary>
        /// The Amazon Resource Name (ARN) representing the secret that the proxy uses to authenticate to the RDS DB instance or Aurora DB cluster. These secrets are stored within Amazon Secrets Manager.
        /// </summary>
        public readonly string? SecretArn;

        [OutputConstructor]
        private ProxyAuth(
            string? authScheme,

            string? description,

            string? iamAuth,

            string? secretArn)
        {
            AuthScheme = authScheme;
            Description = description;
            IamAuth = iamAuth;
            SecretArn = secretArn;
        }
    }
}
