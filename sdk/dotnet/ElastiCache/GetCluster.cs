// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.ElastiCache
{
    public static class GetCluster
    {
        /// <summary>
        /// Use this data source to get information about an Elasticache Cluster
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
        ///         var myCluster = Output.Create(Aws.ElastiCache.GetCluster.InvokeAsync(new Aws.ElastiCache.GetClusterArgs
        ///         {
        ///             ClusterId = "my-cluster-id",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetClusterResult> InvokeAsync(GetClusterArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetClusterResult>("aws:elasticache/getCluster:getCluster", args ?? new GetClusterArgs(), options.WithVersion());
    }


    public sealed class GetClusterArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Group identifier.
        /// </summary>
        [Input("clusterId", required: true)]
        public string ClusterId { get; set; } = null!;

        [Input("tags")]
        private Dictionary<string, string>? _tags;

        /// <summary>
        /// The tags assigned to the resource
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, string>());
            set => _tags = value;
        }

        public GetClusterArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetClusterResult
    {
        public readonly string Arn;
        /// <summary>
        /// The Availability Zone for the cache cluster.
        /// </summary>
        public readonly string AvailabilityZone;
        /// <summary>
        /// List of node objects including `id`, `address`, `port` and `availability_zone`.
        /// Referenceable e.g. as `${data.aws_elasticache_cluster.bar.cache_nodes.0.address}`
        /// </summary>
        public readonly ImmutableArray<Outputs.GetClusterCacheNodeResult> CacheNodes;
        /// <summary>
        /// (Memcached only) The DNS name of the cache cluster without the port appended.
        /// </summary>
        public readonly string ClusterAddress;
        public readonly string ClusterId;
        /// <summary>
        /// (Memcached only) The configuration endpoint to allow host discovery.
        /// </summary>
        public readonly string ConfigurationEndpoint;
        /// <summary>
        /// Name of the cache engine.
        /// </summary>
        public readonly string Engine;
        /// <summary>
        /// Version number of the cache engine.
        /// </summary>
        public readonly string EngineVersion;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Specifies the weekly time range for when maintenance
        /// on the cache cluster is performed.
        /// </summary>
        public readonly string MaintenanceWindow;
        /// <summary>
        /// The cluster node type.
        /// </summary>
        public readonly string NodeType;
        /// <summary>
        /// An Amazon Resource Name (ARN) of an
        /// SNS topic that ElastiCache notifications get sent to.
        /// </summary>
        public readonly string NotificationTopicArn;
        /// <summary>
        /// The number of cache nodes that the cache cluster has.
        /// </summary>
        public readonly int NumCacheNodes;
        /// <summary>
        /// Name of the parameter group associated with this cache cluster.
        /// </summary>
        public readonly string ParameterGroupName;
        /// <summary>
        /// The port number on which each of the cache nodes will
        /// accept connections.
        /// </summary>
        public readonly int Port;
        /// <summary>
        /// The replication group to which this cache cluster belongs.
        /// </summary>
        public readonly string ReplicationGroupId;
        /// <summary>
        /// List VPC security groups associated with the cache cluster.
        /// </summary>
        public readonly ImmutableArray<string> SecurityGroupIds;
        /// <summary>
        /// List of security group names associated with this cache cluster.
        /// </summary>
        public readonly ImmutableArray<string> SecurityGroupNames;
        /// <summary>
        /// The number of days for which ElastiCache will
        /// retain automatic cache cluster snapshots before deleting them.
        /// </summary>
        public readonly int SnapshotRetentionLimit;
        /// <summary>
        /// The daily time range (in UTC) during which ElastiCache will
        /// begin taking a daily snapshot of the cache cluster.
        /// </summary>
        public readonly string SnapshotWindow;
        /// <summary>
        /// Name of the subnet group associated to the cache cluster.
        /// </summary>
        public readonly string SubnetGroupName;
        /// <summary>
        /// The tags assigned to the resource
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;

        [OutputConstructor]
        private GetClusterResult(
            string arn,

            string availabilityZone,

            ImmutableArray<Outputs.GetClusterCacheNodeResult> cacheNodes,

            string clusterAddress,

            string clusterId,

            string configurationEndpoint,

            string engine,

            string engineVersion,

            string id,

            string maintenanceWindow,

            string nodeType,

            string notificationTopicArn,

            int numCacheNodes,

            string parameterGroupName,

            int port,

            string replicationGroupId,

            ImmutableArray<string> securityGroupIds,

            ImmutableArray<string> securityGroupNames,

            int snapshotRetentionLimit,

            string snapshotWindow,

            string subnetGroupName,

            ImmutableDictionary<string, string> tags)
        {
            Arn = arn;
            AvailabilityZone = availabilityZone;
            CacheNodes = cacheNodes;
            ClusterAddress = clusterAddress;
            ClusterId = clusterId;
            ConfigurationEndpoint = configurationEndpoint;
            Engine = engine;
            EngineVersion = engineVersion;
            Id = id;
            MaintenanceWindow = maintenanceWindow;
            NodeType = nodeType;
            NotificationTopicArn = notificationTopicArn;
            NumCacheNodes = numCacheNodes;
            ParameterGroupName = parameterGroupName;
            Port = port;
            ReplicationGroupId = replicationGroupId;
            SecurityGroupIds = securityGroupIds;
            SecurityGroupNames = securityGroupNames;
            SnapshotRetentionLimit = snapshotRetentionLimit;
            SnapshotWindow = snapshotWindow;
            SubnetGroupName = subnetGroupName;
            Tags = tags;
        }
    }
}
