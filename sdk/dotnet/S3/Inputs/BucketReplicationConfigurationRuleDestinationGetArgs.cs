// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.S3.Inputs
{

    public sealed class BucketReplicationConfigurationRuleDestinationGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the overrides to use for object owners on replication. Must be used in conjunction with `account_id` owner override configuration.
        /// </summary>
        [Input("accessControlTranslation")]
        public Input<Inputs.BucketReplicationConfigurationRuleDestinationAccessControlTranslationGetArgs>? AccessControlTranslation { get; set; }

        /// <summary>
        /// The Account ID to use for overriding the object owner on replication. Must be used in conjunction with `access_control_translation` override configuration.
        /// </summary>
        [Input("accountId")]
        public Input<string>? AccountId { get; set; }

        /// <summary>
        /// The ARN of the S3 bucket where you want Amazon S3 to store replicas of the object identified by the rule.
        /// </summary>
        [Input("bucket", required: true)]
        public Input<string> Bucket { get; set; } = null!;

        /// <summary>
        /// Destination KMS encryption key ARN for SSE-KMS replication. Must be used in conjunction with
        /// `sse_kms_encrypted_objects` source selection criteria.
        /// </summary>
        [Input("replicaKmsKeyId")]
        public Input<string>? ReplicaKmsKeyId { get; set; }

        /// <summary>
        /// The class of storage used to store the object. Can be `STANDARD`, `REDUCED_REDUNDANCY`, `STANDARD_IA`, `ONEZONE_IA`, `INTELLIGENT_TIERING`, `GLACIER`, or `DEEP_ARCHIVE`.
        /// </summary>
        [Input("storageClass")]
        public Input<string>? StorageClass { get; set; }

        public BucketReplicationConfigurationRuleDestinationGetArgs()
        {
        }
    }
}
