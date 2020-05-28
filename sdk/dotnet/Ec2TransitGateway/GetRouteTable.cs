// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2TransitGateway
{
    public static class GetRouteTable
    {
        /// <summary>
        /// Get information on an EC2 Transit Gateway Route Table.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// 
        /// {{% example %}}
        /// ### By Filter
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Aws = Pulumi.Aws;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var example = Output.Create(Aws.Ec2TransitGateway.GetRouteTable.InvokeAsync(new Aws.Ec2TransitGateway.GetRouteTableArgs
        ///         {
        ///             Filters = 
        ///             {
        ///                 new Aws.Ec2TransitGateway.Inputs.GetRouteTableFilterArgs
        ///                 {
        ///                     Name = "default-association-route-table",
        ///                     Values = 
        ///                     {
        ///                         "true",
        ///                     },
        ///                 },
        ///                 new Aws.Ec2TransitGateway.Inputs.GetRouteTableFilterArgs
        ///                 {
        ///                     Name = "transit-gateway-id",
        ///                     Values = 
        ///                     {
        ///                         "tgw-12345678",
        ///                     },
        ///                 },
        ///             },
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// 
        /// {{% /example %}}
        /// {{% example %}}
        /// ### By Identifier
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Aws = Pulumi.Aws;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var example = Output.Create(Aws.Ec2TransitGateway.GetRouteTable.InvokeAsync(new Aws.Ec2TransitGateway.GetRouteTableArgs
        ///         {
        ///             Id = "tgw-rtb-12345678",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// 
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetRouteTableResult> InvokeAsync(GetRouteTableArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetRouteTableResult>("aws:ec2transitgateway/getRouteTable:getRouteTable", args ?? new GetRouteTableArgs(), options.WithVersion());
    }


    public sealed class GetRouteTableArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetRouteTableFilterArgs>? _filters;

        /// <summary>
        /// One or more configuration blocks containing name-values filters. Detailed below.
        /// </summary>
        public List<Inputs.GetRouteTableFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetRouteTableFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Identifier of the EC2 Transit Gateway Route Table.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        [Input("tags")]
        private Dictionary<string, object>? _tags;

        /// <summary>
        /// Key-value tags for the EC2 Transit Gateway Route Table
        /// </summary>
        public Dictionary<string, object> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, object>());
            set => _tags = value;
        }

        public GetRouteTableArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetRouteTableResult
    {
        /// <summary>
        /// Boolean whether this is the default association route table for the EC2 Transit Gateway
        /// </summary>
        public readonly bool DefaultAssociationRouteTable;
        /// <summary>
        /// Boolean whether this is the default propagation route table for the EC2 Transit Gateway
        /// </summary>
        public readonly bool DefaultPropagationRouteTable;
        public readonly ImmutableArray<Outputs.GetRouteTableFilterResult> Filters;
        /// <summary>
        /// EC2 Transit Gateway Route Table identifier
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Key-value tags for the EC2 Transit Gateway Route Table
        /// </summary>
        public readonly ImmutableDictionary<string, object> Tags;
        /// <summary>
        /// EC2 Transit Gateway identifier
        /// </summary>
        public readonly string TransitGatewayId;

        [OutputConstructor]
        private GetRouteTableResult(
            bool defaultAssociationRouteTable,

            bool defaultPropagationRouteTable,

            ImmutableArray<Outputs.GetRouteTableFilterResult> filters,

            string? id,

            ImmutableDictionary<string, object> tags,

            string transitGatewayId)
        {
            DefaultAssociationRouteTable = defaultAssociationRouteTable;
            DefaultPropagationRouteTable = defaultPropagationRouteTable;
            Filters = filters;
            Id = id;
            Tags = tags;
            TransitGatewayId = transitGatewayId;
        }
    }
}
