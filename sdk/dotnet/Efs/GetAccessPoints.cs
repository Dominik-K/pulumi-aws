// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Efs
{
    public static class GetAccessPoints
    {
        /// <summary>
        /// Provides information about multiple Elastic File System (EFS) Access Points.
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
        ///         var test = Output.Create(Aws.Efs.GetAccessPoints.InvokeAsync(new Aws.Efs.GetAccessPointsArgs
        ///         {
        ///             FileSystemId = "fs-12345678",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetAccessPointsResult> InvokeAsync(GetAccessPointsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAccessPointsResult>("aws:efs/getAccessPoints:getAccessPoints", args ?? new GetAccessPointsArgs(), options.WithVersion());
    }


    public sealed class GetAccessPointsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// EFS File System identifier.
        /// </summary>
        [Input("fileSystemId", required: true)]
        public string FileSystemId { get; set; } = null!;

        public GetAccessPointsArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetAccessPointsResult
    {
        /// <summary>
        /// Set of Amazon Resource Names (ARNs).
        /// </summary>
        public readonly ImmutableArray<string> Arns;
        public readonly string FileSystemId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Set of identifiers.
        /// </summary>
        public readonly ImmutableArray<string> Ids;

        [OutputConstructor]
        private GetAccessPointsResult(
            ImmutableArray<string> arns,

            string fileSystemId,

            string id,

            ImmutableArray<string> ids)
        {
            Arns = arns;
            FileSystemId = fileSystemId;
            Id = id;
            Ids = ids;
        }
    }
}
