// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2
{
    public static partial class Invokes
    {
        /// <summary>
        /// 
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/network_acls.html.markdown.
        /// </summary>
        [Obsolete("Use GetNetworkAcls.InvokeAsync() instead")]
        public static Task<GetNetworkAclsResult> GetNetworkAcls(GetNetworkAclsArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetNetworkAclsResult>("aws:ec2/getNetworkAcls:getNetworkAcls", args ?? InvokeArgs.Empty, options.WithVersion());
    }
    public static class GetNetworkAcls
    {
        /// <summary>
        /// 
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/network_acls.html.markdown.
        /// </summary>
        public static Task<GetNetworkAclsResult> InvokeAsync(GetNetworkAclsArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetNetworkAclsResult>("aws:ec2/getNetworkAcls:getNetworkAcls", args ?? InvokeArgs.Empty, options.WithVersion());
    }

    public sealed class GetNetworkAclsArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetNetworkAclsFiltersArgs>? _filters;

        /// <summary>
        /// Custom filter block as described below.
        /// </summary>
        public List<Inputs.GetNetworkAclsFiltersArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetNetworkAclsFiltersArgs>());
            set => _filters = value;
        }

        [Input("tags")]
        private Dictionary<string, object>? _tags;

        /// <summary>
        /// A mapping of tags, each pair of which must exactly match
        /// a pair on the desired network ACLs.
        /// </summary>
        public Dictionary<string, object> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, object>());
            set => _tags = value;
        }

        /// <summary>
        /// The VPC ID that you want to filter from.
        /// </summary>
        [Input("vpcId")]
        public string? VpcId { get; set; }

        public GetNetworkAclsArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetNetworkAclsResult
    {
        public readonly ImmutableArray<Outputs.GetNetworkAclsFiltersResult> Filters;
        /// <summary>
        /// A list of all the network ACL ids found. This data source will fail if none are found.
        /// </summary>
        public readonly ImmutableArray<string> Ids;
        public readonly ImmutableDictionary<string, object> Tags;
        public readonly string? VpcId;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetNetworkAclsResult(
            ImmutableArray<Outputs.GetNetworkAclsFiltersResult> filters,
            ImmutableArray<string> ids,
            ImmutableDictionary<string, object> tags,
            string? vpcId,
            string id)
        {
            Filters = filters;
            Ids = ids;
            Tags = tags;
            VpcId = vpcId;
            Id = id;
        }
    }

    namespace Inputs
    {

    public sealed class GetNetworkAclsFiltersArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the field to filter by, as defined by
        /// [the underlying AWS API](https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeNetworkAcls.html).
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        [Input("values", required: true)]
        private List<string>? _values;

        /// <summary>
        /// Set of values that are accepted for the given field.
        /// A VPC will be selected if any one of the given values matches.
        /// </summary>
        public List<string> Values
        {
            get => _values ?? (_values = new List<string>());
            set => _values = value;
        }

        public GetNetworkAclsFiltersArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class GetNetworkAclsFiltersResult
    {
        /// <summary>
        /// The name of the field to filter by, as defined by
        /// [the underlying AWS API](https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeNetworkAcls.html).
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Set of values that are accepted for the given field.
        /// A VPC will be selected if any one of the given values matches.
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private GetNetworkAclsFiltersResult(
            string name,
            ImmutableArray<string> values)
        {
            Name = name;
            Values = values;
        }
    }
    }
}
