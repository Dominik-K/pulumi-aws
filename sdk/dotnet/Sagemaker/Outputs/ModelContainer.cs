// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Sagemaker.Outputs
{

    [OutputType]
    public sealed class ModelContainer
    {
        /// <summary>
        /// The DNS host name for the container.
        /// </summary>
        public readonly string? ContainerHostname;
        /// <summary>
        /// Environment variables for the Docker container.
        /// A list of key value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Environment;
        /// <summary>
        /// The registry path where the inference code image is stored in Amazon ECR.
        /// </summary>
        public readonly string Image;
        /// <summary>
        /// Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see [Using a Private Docker Registry for Real-Time Inference Containers](https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms-containers-inference-private.html). see Image Config.
        /// </summary>
        public readonly Outputs.ModelContainerImageConfig? ImageConfig;
        /// <summary>
        /// The container hosts value `SingleModel/MultiModel`. The default value is `SingleModel`.
        /// </summary>
        public readonly string? Mode;
        /// <summary>
        /// The URL for the S3 location where model artifacts are stored.
        /// </summary>
        public readonly string? ModelDataUrl;

        [OutputConstructor]
        private ModelContainer(
            string? containerHostname,

            ImmutableDictionary<string, string>? environment,

            string image,

            Outputs.ModelContainerImageConfig? imageConfig,

            string? mode,

            string? modelDataUrl)
        {
            ContainerHostname = containerHostname;
            Environment = environment;
            Image = image;
            ImageConfig = imageConfig;
            Mode = mode;
            ModelDataUrl = modelDataUrl;
        }
    }
}