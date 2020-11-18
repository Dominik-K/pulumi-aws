// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Kinesis
{
    public static class GetStream
    {
        /// <summary>
        /// Use this data source to get information about a Kinesis Stream for use in other
        /// resources.
        /// 
        /// For more details, see the [Amazon Kinesis Documentation](https://aws.amazon.com/documentation/kinesis/).
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
        ///         var stream = Output.Create(Aws.Kinesis.GetStream.InvokeAsync(new Aws.Kinesis.GetStreamArgs
        ///         {
        ///             Name = "stream-name",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetStreamResult> InvokeAsync(GetStreamArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetStreamResult>("aws:kinesis/getStream:getStream", args ?? new GetStreamArgs(), options.WithVersion());
    }


    public sealed class GetStreamArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Kinesis Stream.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        [Input("tags")]
        private Dictionary<string, string>? _tags;

        /// <summary>
        /// A map of tags to assigned to the stream.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, string>());
            set => _tags = value;
        }

        public GetStreamArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetStreamResult
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) of the Kinesis Stream (same as id).
        /// </summary>
        public readonly string Arn;
        /// <summary>
        /// The list of shard ids in the CLOSED state. See [Shard State](https://docs.aws.amazon.com/streams/latest/dev/kinesis-using-sdk-java-after-resharding.html#kinesis-using-sdk-java-resharding-data-routing) for more.
        /// </summary>
        public readonly ImmutableArray<string> ClosedShards;
        /// <summary>
        /// The approximate UNIX timestamp that the stream was created.
        /// </summary>
        public readonly int CreationTimestamp;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the Kinesis Stream.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The list of shard ids in the OPEN state. See [Shard State](https://docs.aws.amazon.com/streams/latest/dev/kinesis-using-sdk-java-after-resharding.html#kinesis-using-sdk-java-resharding-data-routing) for more.
        /// </summary>
        public readonly ImmutableArray<string> OpenShards;
        /// <summary>
        /// Length of time (in hours) data records are accessible after they are added to the stream.
        /// </summary>
        public readonly int RetentionPeriod;
        /// <summary>
        /// A list of shard-level CloudWatch metrics which are enabled for the stream. See [Monitoring with CloudWatch](https://docs.aws.amazon.com/streams/latest/dev/monitoring-with-cloudwatch.html) for more.
        /// </summary>
        public readonly ImmutableArray<string> ShardLevelMetrics;
        /// <summary>
        /// The current status of the stream. The stream status is one of CREATING, DELETING, ACTIVE, or UPDATING.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// A map of tags to assigned to the stream.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;

        [OutputConstructor]
        private GetStreamResult(
            string arn,

            ImmutableArray<string> closedShards,

            int creationTimestamp,

            string id,

            string name,

            ImmutableArray<string> openShards,

            int retentionPeriod,

            ImmutableArray<string> shardLevelMetrics,

            string status,

            ImmutableDictionary<string, string> tags)
        {
            Arn = arn;
            ClosedShards = closedShards;
            CreationTimestamp = creationTimestamp;
            Id = id;
            Name = name;
            OpenShards = openShards;
            RetentionPeriod = retentionPeriod;
            ShardLevelMetrics = shardLevelMetrics;
            Status = status;
            Tags = tags;
        }
    }
}
