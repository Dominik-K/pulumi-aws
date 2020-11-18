// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2
{
    public static class GetLocalGatewayVirtualInterfaceGroup
    {
        /// <summary>
        /// Provides details about an EC2 Local Gateway Virtual Interface Group. More information can be found in the [Outposts User Guide](https://docs.aws.amazon.com/outposts/latest/userguide/outposts-networking-components.html#routing).
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
        ///         var example = Output.Create(Aws.Ec2.GetLocalGatewayVirtualInterfaceGroup.InvokeAsync(new Aws.Ec2.GetLocalGatewayVirtualInterfaceGroupArgs
        ///         {
        ///             LocalGatewayId = data.Aws_ec2_local_gateway.Example.Id,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetLocalGatewayVirtualInterfaceGroupResult> InvokeAsync(GetLocalGatewayVirtualInterfaceGroupArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetLocalGatewayVirtualInterfaceGroupResult>("aws:ec2/getLocalGatewayVirtualInterfaceGroup:getLocalGatewayVirtualInterfaceGroup", args ?? new GetLocalGatewayVirtualInterfaceGroupArgs(), options.WithVersion());
    }


    public sealed class GetLocalGatewayVirtualInterfaceGroupArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetLocalGatewayVirtualInterfaceGroupFilterArgs>? _filters;

        /// <summary>
        /// One or more configuration blocks containing name-values filters. See the [EC2 API Reference](https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeLocalGatewayVirtualInterfaceGroups.html) for supported filters. Detailed below.
        /// </summary>
        public List<Inputs.GetLocalGatewayVirtualInterfaceGroupFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetLocalGatewayVirtualInterfaceGroupFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Identifier of EC2 Local Gateway Virtual Interface Group.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Identifier of EC2 Local Gateway.
        /// </summary>
        [Input("localGatewayId")]
        public string? LocalGatewayId { get; set; }

        [Input("tags")]
        private Dictionary<string, string>? _tags;

        /// <summary>
        /// Key-value map of resource tags, each pair of which must exactly match a pair on the desired local gateway route table.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, string>());
            set => _tags = value;
        }

        public GetLocalGatewayVirtualInterfaceGroupArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetLocalGatewayVirtualInterfaceGroupResult
    {
        public readonly ImmutableArray<Outputs.GetLocalGatewayVirtualInterfaceGroupFilterResult> Filters;
        public readonly string Id;
        public readonly string LocalGatewayId;
        /// <summary>
        /// Set of EC2 Local Gateway Virtual Interface identifiers.
        /// </summary>
        public readonly ImmutableArray<string> LocalGatewayVirtualInterfaceIds;
        public readonly ImmutableDictionary<string, string> Tags;

        [OutputConstructor]
        private GetLocalGatewayVirtualInterfaceGroupResult(
            ImmutableArray<Outputs.GetLocalGatewayVirtualInterfaceGroupFilterResult> filters,

            string id,

            string localGatewayId,

            ImmutableArray<string> localGatewayVirtualInterfaceIds,

            ImmutableDictionary<string, string> tags)
        {
            Filters = filters;
            Id = id;
            LocalGatewayId = localGatewayId;
            LocalGatewayVirtualInterfaceIds = localGatewayVirtualInterfaceIds;
            Tags = tags;
        }
    }
}