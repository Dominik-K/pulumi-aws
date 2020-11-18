// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Workspaces
{
    public static class GetImage
    {
        /// <summary>
        /// Use this data source to get information about a Workspaces image.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Aws = Pulumi.Aws;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var example = Output.Create(Aws.Workspaces.GetImage.InvokeAsync(new Aws.Workspaces.GetImageArgs
        ///         {
        ///             ImageId = "wsi-ten5h0y19",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetImageResult> InvokeAsync(GetImageArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetImageResult>("aws:workspaces/getImage:getImage", args ?? new GetImageArgs(), options.WithVersion());
    }


    public sealed class GetImageArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The ID of the image.
        /// </summary>
        [Input("imageId", required: true)]
        public string ImageId { get; set; } = null!;

        public GetImageArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetImageResult
    {
        /// <summary>
        /// The description of the image.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string ImageId;
        /// <summary>
        /// The name of the image.
        /// </summary>
        public readonly string Name;
        public readonly string OperatingSystemType;
        /// <summary>
        /// Specifies whether the image is running on dedicated hardware. When Bring Your Own License (BYOL) is enabled, this value is set to DEDICATED. For more information, see [Bring Your Own Windows Desktop Images](https://docs.aws.amazon.com/workspaces/latest/adminguide/byol-windows-images.html).
        /// </summary>
        public readonly string RequiredTenancy;
        /// <summary>
        /// The status of the image.
        /// </summary>
        public readonly string State;

        [OutputConstructor]
        private GetImageResult(
            string description,

            string id,

            string imageId,

            string name,

            string operatingSystemType,

            string requiredTenancy,

            string state)
        {
            Description = description;
            Id = id;
            ImageId = imageId;
            Name = name;
            OperatingSystemType = operatingSystemType;
            RequiredTenancy = requiredTenancy;
            State = state;
        }
    }
}
