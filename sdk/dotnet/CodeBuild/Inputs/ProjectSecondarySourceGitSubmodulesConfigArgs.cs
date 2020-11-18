// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CodeBuild.Inputs
{

    public sealed class ProjectSecondarySourceGitSubmodulesConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// If set to true, fetches Git submodules for the AWS CodeBuild build project.
        /// </summary>
        [Input("fetchSubmodules", required: true)]
        public Input<bool> FetchSubmodules { get; set; } = null!;

        public ProjectSecondarySourceGitSubmodulesConfigArgs()
        {
        }
    }
}
