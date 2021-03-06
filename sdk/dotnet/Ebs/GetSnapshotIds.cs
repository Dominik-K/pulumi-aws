// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ebs
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to get a list of EBS Snapshot IDs matching the specified
        /// criteria.
        /// 
        /// 
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/ebs_snapshot_ids.html.markdown.
        /// </summary>
        [Obsolete("Use GetSnapshotIds.InvokeAsync() instead")]
        public static Task<GetSnapshotIdsResult> GetSnapshotIds(GetSnapshotIdsArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSnapshotIdsResult>("aws:ebs/getSnapshotIds:getSnapshotIds", args ?? InvokeArgs.Empty, options.WithVersion());
    }
    public static class GetSnapshotIds
    {
        /// <summary>
        /// Use this data source to get a list of EBS Snapshot IDs matching the specified
        /// criteria.
        /// 
        /// 
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/ebs_snapshot_ids.html.markdown.
        /// </summary>
        public static Task<GetSnapshotIdsResult> InvokeAsync(GetSnapshotIdsArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSnapshotIdsResult>("aws:ebs/getSnapshotIds:getSnapshotIds", args ?? InvokeArgs.Empty, options.WithVersion());
    }

    public sealed class GetSnapshotIdsArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetSnapshotIdsFiltersArgs>? _filters;

        /// <summary>
        /// One or more name/value pairs to filter off of. There are
        /// several valid keys, for a full reference, check out
        /// [describe-volumes in the AWS CLI reference][1].
        /// </summary>
        public List<Inputs.GetSnapshotIdsFiltersArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetSnapshotIdsFiltersArgs>());
            set => _filters = value;
        }

        [Input("owners")]
        private List<string>? _owners;

        /// <summary>
        /// Returns the snapshots owned by the specified owner id. Multiple owners can be specified.
        /// </summary>
        public List<string> Owners
        {
            get => _owners ?? (_owners = new List<string>());
            set => _owners = value;
        }

        [Input("restorableByUserIds")]
        private List<string>? _restorableByUserIds;

        /// <summary>
        /// One or more AWS accounts IDs that can create volumes from the snapshot.
        /// </summary>
        public List<string> RestorableByUserIds
        {
            get => _restorableByUserIds ?? (_restorableByUserIds = new List<string>());
            set => _restorableByUserIds = value;
        }

        public GetSnapshotIdsArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetSnapshotIdsResult
    {
        public readonly ImmutableArray<Outputs.GetSnapshotIdsFiltersResult> Filters;
        public readonly ImmutableArray<string> Ids;
        public readonly ImmutableArray<string> Owners;
        public readonly ImmutableArray<string> RestorableByUserIds;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetSnapshotIdsResult(
            ImmutableArray<Outputs.GetSnapshotIdsFiltersResult> filters,
            ImmutableArray<string> ids,
            ImmutableArray<string> owners,
            ImmutableArray<string> restorableByUserIds,
            string id)
        {
            Filters = filters;
            Ids = ids;
            Owners = owners;
            RestorableByUserIds = restorableByUserIds;
            Id = id;
        }
    }

    namespace Inputs
    {

    public sealed class GetSnapshotIdsFiltersArgs : Pulumi.InvokeArgs
    {
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        [Input("values", required: true)]
        private List<string>? _values;
        public List<string> Values
        {
            get => _values ?? (_values = new List<string>());
            set => _values = value;
        }

        public GetSnapshotIdsFiltersArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class GetSnapshotIdsFiltersResult
    {
        public readonly string Name;
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private GetSnapshotIdsFiltersResult(
            string name,
            ImmutableArray<string> values)
        {
            Name = name;
            Values = values;
        }
    }
    }
}
