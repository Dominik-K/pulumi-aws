// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2
{
    public static class GetCoipPool
    {
        /// <summary>
        /// Provides details about a specific EC2 Customer-Owned IP Pool.
        /// 
        /// This data source can prove useful when a module accepts a coip pool id as
        /// an input variable and needs to, for example, determine the CIDR block of that
        /// COIP Pool.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// The following example returns a specific coip pool ID
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
        ///         var coipPoolId = config.RequireObject&lt;dynamic&gt;("coipPoolId");
        ///         var selected = Output.Create(Aws.Ec2.GetCoipPool.InvokeAsync(new Aws.Ec2.GetCoipPoolArgs
        ///         {
        ///             Id = coipPoolId,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// 
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetCoipPoolResult> InvokeAsync(GetCoipPoolArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetCoipPoolResult>("aws:ec2/getCoipPool:getCoipPool", args ?? new GetCoipPoolArgs(), options.WithVersion());
    }


    public sealed class GetCoipPoolArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetCoipPoolFilterArgs>? _filters;
        public List<Inputs.GetCoipPoolFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetCoipPoolFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Local Gateway Route Table Id assigned to desired COIP Pool
        /// </summary>
        [Input("localGatewayRouteTableId")]
        public string? LocalGatewayRouteTableId { get; set; }

        /// <summary>
        /// The id of the specific COIP Pool to retrieve.
        /// </summary>
        [Input("poolId")]
        public string? PoolId { get; set; }

        [Input("tags")]
        private Dictionary<string, object>? _tags;

        /// <summary>
        /// A mapping of tags, each pair of which must exactly match
        /// a pair on the desired COIP Pool.
        /// </summary>
        public Dictionary<string, object> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, object>());
            set => _tags = value;
        }

        public GetCoipPoolArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetCoipPoolResult
    {
        public readonly ImmutableArray<Outputs.GetCoipPoolFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string LocalGatewayRouteTableId;
        /// <summary>
        /// Set of CIDR blocks in pool
        /// </summary>
        public readonly ImmutableArray<string> PoolCidrs;
        public readonly string PoolId;
        public readonly ImmutableDictionary<string, object> Tags;

        [OutputConstructor]
        private GetCoipPoolResult(
            ImmutableArray<Outputs.GetCoipPoolFilterResult> filters,

            string id,

            string localGatewayRouteTableId,

            ImmutableArray<string> poolCidrs,

            string poolId,

            ImmutableDictionary<string, object> tags)
        {
            Filters = filters;
            Id = id;
            LocalGatewayRouteTableId = localGatewayRouteTableId;
            PoolCidrs = poolCidrs;
            PoolId = poolId;
            Tags = tags;
        }
    }
}
