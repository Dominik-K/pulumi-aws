// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CodeBuild.Inputs
{

    public sealed class ProjectEnvironmentArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ARN of the S3 bucket, path prefix and object key that contains the PEM-encoded certificate.
        /// </summary>
        [Input("certificate")]
        public Input<string>? Certificate { get; set; }

        /// <summary>
        /// Information about the compute resources the build project will use. Available values for this parameter are: `BUILD_GENERAL1_SMALL`, `BUILD_GENERAL1_MEDIUM`, `BUILD_GENERAL1_LARGE` or `BUILD_GENERAL1_2XLARGE`. `BUILD_GENERAL1_SMALL` is only valid if `type` is set to `LINUX_CONTAINER`. When `type` is set to `LINUX_GPU_CONTAINER`, `compute_type` need to be `BUILD_GENERAL1_LARGE`.
        /// </summary>
        [Input("computeType", required: true)]
        public Input<string> ComputeType { get; set; } = null!;

        [Input("environmentVariables")]
        private InputList<Inputs.ProjectEnvironmentEnvironmentVariableArgs>? _environmentVariables;

        /// <summary>
        /// A set of environment variables to make available to builds for this build project.
        /// </summary>
        public InputList<Inputs.ProjectEnvironmentEnvironmentVariableArgs> EnvironmentVariables
        {
            get => _environmentVariables ?? (_environmentVariables = new InputList<Inputs.ProjectEnvironmentEnvironmentVariableArgs>());
            set => _environmentVariables = value;
        }

        /// <summary>
        /// The Docker image to use for this build project. Valid values include [Docker images provided by CodeBuild](https://docs.aws.amazon.com/codebuild/latest/userguide/build-env-ref-available.html) (e.g `aws/codebuild/standard:2.0`), [Docker Hub images](https://hub.docker.com/) (e.g. `nginx:latest`), and full Docker repository URIs such as those for ECR (e.g. `137112412989.dkr.ecr.us-west-2.amazonaws.com/amazonlinux:latest`).
        /// </summary>
        [Input("image", required: true)]
        public Input<string> Image { get; set; } = null!;

        /// <summary>
        /// The type of credentials AWS CodeBuild uses to pull images in your build. Available values for this parameter are `CODEBUILD` or `SERVICE_ROLE`. When you use a cross-account or private registry image, you must use SERVICE_ROLE credentials. When you use an AWS CodeBuild curated image, you must use CODEBUILD credentials. Default to `CODEBUILD`
        /// </summary>
        [Input("imagePullCredentialsType")]
        public Input<string>? ImagePullCredentialsType { get; set; }

        /// <summary>
        /// If set to true, enables running the Docker daemon inside a Docker container. Defaults to `false`.
        /// </summary>
        [Input("privilegedMode")]
        public Input<bool>? PrivilegedMode { get; set; }

        /// <summary>
        /// Information about credentials for access to a private Docker registry. Registry Credential config blocks are documented below.
        /// </summary>
        [Input("registryCredential")]
        public Input<Inputs.ProjectEnvironmentRegistryCredentialArgs>? RegistryCredential { get; set; }

        /// <summary>
        /// The type of build environment to use for related builds. Available values are: `LINUX_CONTAINER`, `LINUX_GPU_CONTAINER`, `WINDOWS_CONTAINER` or `ARM_CONTAINER`.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ProjectEnvironmentArgs()
        {
        }
    }
}
