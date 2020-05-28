// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2
{
    public static class GetLocalGateway
    {
        /// <summary>
        /// Provides details about an EC2 Local Gateway.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// The following example shows how one might accept a local gateway id as a variable.
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Aws = Pulumi.Aws;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var config = new Config();
        ///         var localGatewayId = config.RequireObject&lt;dynamic&gt;("localGatewayId");
        ///         var selected = Output.Create(Aws.Ec2.GetLocalGateway.InvokeAsync(new Aws.Ec2.GetLocalGatewayArgs
        ///         {
        ///             Id = localGatewayId,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// 
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetLocalGatewayResult> InvokeAsync(GetLocalGatewayArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetLocalGatewayResult>("aws:ec2/getLocalGateway:getLocalGateway", args ?? new GetLocalGatewayArgs(), options.WithVersion());
    }


    public sealed class GetLocalGatewayArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetLocalGatewayFilterArgs>? _filters;

        /// <summary>
        /// Custom filter block as described below.
        /// </summary>
        public List<Inputs.GetLocalGatewayFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetLocalGatewayFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// The id of the specific Local Gateway to retrieve.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The current state of the desired Local Gateway.
        /// Can be either `"pending"` or `"available"`.
        /// </summary>
        [Input("state")]
        public string? State { get; set; }

        [Input("tags")]
        private Dictionary<string, object>? _tags;

        /// <summary>
        /// A mapping of tags, each pair of which must exactly match
        /// a pair on the desired Local Gateway.
        /// </summary>
        public Dictionary<string, object> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, object>());
            set => _tags = value;
        }

        public GetLocalGatewayArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetLocalGatewayResult
    {
        public readonly ImmutableArray<Outputs.GetLocalGatewayFilterResult> Filters;
        public readonly string Id;
        /// <summary>
        /// Amazon Resource Name (ARN) of Outpost
        /// </summary>
        public readonly string OutpostArn;
        /// <summary>
        /// AWS account identifier that owns the Local Gateway.
        /// </summary>
        public readonly string OwnerId;
        /// <summary>
        /// State of the local gateway.
        /// </summary>
        public readonly string State;
        public readonly ImmutableDictionary<string, object> Tags;

        [OutputConstructor]
        private GetLocalGatewayResult(
            ImmutableArray<Outputs.GetLocalGatewayFilterResult> filters,

            string id,

            string outpostArn,

            string ownerId,

            string state,

            ImmutableDictionary<string, object> tags)
        {
            Filters = filters;
            Id = id;
            OutpostArn = outpostArn;
            OwnerId = ownerId;
            State = state;
            Tags = tags;
        }
    }
}
