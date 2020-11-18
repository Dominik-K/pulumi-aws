// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.ElasticSearch.Outputs
{

    [OutputType]
    public sealed class DomainClusterConfig
    {
        /// <summary>
        /// Number of dedicated master nodes in the cluster
        /// </summary>
        public readonly int? DedicatedMasterCount;
        /// <summary>
        /// Indicates whether dedicated master nodes are enabled for the cluster.
        /// </summary>
        public readonly bool? DedicatedMasterEnabled;
        /// <summary>
        /// Instance type of the dedicated master nodes in the cluster.
        /// </summary>
        public readonly string? DedicatedMasterType;
        /// <summary>
        /// Number of instances in the cluster.
        /// </summary>
        public readonly int? InstanceCount;
        /// <summary>
        /// Instance type of data nodes in the cluster.
        /// </summary>
        public readonly string? InstanceType;
        /// <summary>
        /// The number of warm nodes in the cluster. Valid values are between `2` and `150`. `warm_count` can be only and must be set when `warm_enabled` is set to `true`.
        /// </summary>
        public readonly int? WarmCount;
        /// <summary>
        /// Indicates whether to enable warm storage.
        /// </summary>
        public readonly bool? WarmEnabled;
        /// <summary>
        /// The instance type for the Elasticsearch cluster's warm nodes. Valid values are `ultrawarm1.medium.elasticsearch`, `ultrawarm1.large.elasticsearch` and `ultrawarm1.xlarge.elasticsearch`. `warm_type` can be only and must be set when `warm_enabled` is set to `true`.
        /// </summary>
        public readonly string? WarmType;
        /// <summary>
        /// Configuration block containing zone awareness settings. Documented below.
        /// </summary>
        public readonly Outputs.DomainClusterConfigZoneAwarenessConfig? ZoneAwarenessConfig;
        /// <summary>
        /// Indicates whether zone awareness is enabled, set to `true` for multi-az deployment. To enable awareness with three Availability Zones, the `availability_zone_count` within the `zone_awareness_config` must be set to `3`.
        /// </summary>
        public readonly bool? ZoneAwarenessEnabled;

        [OutputConstructor]
        private DomainClusterConfig(
            int? dedicatedMasterCount,

            bool? dedicatedMasterEnabled,

            string? dedicatedMasterType,

            int? instanceCount,

            string? instanceType,

            int? warmCount,

            bool? warmEnabled,

            string? warmType,

            Outputs.DomainClusterConfigZoneAwarenessConfig? zoneAwarenessConfig,

            bool? zoneAwarenessEnabled)
        {
            DedicatedMasterCount = dedicatedMasterCount;
            DedicatedMasterEnabled = dedicatedMasterEnabled;
            DedicatedMasterType = dedicatedMasterType;
            InstanceCount = instanceCount;
            InstanceType = instanceType;
            WarmCount = warmCount;
            WarmEnabled = warmEnabled;
            WarmType = warmType;
            ZoneAwarenessConfig = zoneAwarenessConfig;
            ZoneAwarenessEnabled = zoneAwarenessEnabled;
        }
    }
}
