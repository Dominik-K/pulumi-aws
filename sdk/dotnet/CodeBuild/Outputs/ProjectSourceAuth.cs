// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CodeBuild.Outputs
{

    [OutputType]
    public sealed class ProjectSourceAuth
    {
        /// <summary>
        /// The resource value that applies to the specified authorization type.
        /// </summary>
        public readonly string? Resource;
        /// <summary>
        /// The authorization type to use. The only valid value is `OAUTH`
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ProjectSourceAuth(
            string? resource,

            string type)
        {
            Resource = resource;
            Type = type;
        }
    }
}
