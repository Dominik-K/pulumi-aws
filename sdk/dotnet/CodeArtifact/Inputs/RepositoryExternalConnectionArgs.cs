// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CodeArtifact.Inputs
{

    public sealed class RepositoryExternalConnectionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the external connection associated with a repository.
        /// </summary>
        [Input("externalConnectionName")]
        public Input<string>? ExternalConnectionName { get; set; }

        /// <summary>
        /// The package format associated with a repository's external connection.
        /// </summary>
        [Input("packageFormat")]
        public Input<string>? PackageFormat { get; set; }

        /// <summary>
        /// The status of the external connection of a repository.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        public RepositoryExternalConnectionArgs()
        {
        }
    }
}
