// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Athena.Inputs
{

    public sealed class WorkgroupConfigurationResultConfigurationEncryptionConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicates whether Amazon S3 server-side encryption with Amazon S3-managed keys (`SSE_S3`), server-side encryption with KMS-managed keys (`SSE_KMS`), or client-side encryption with KMS-managed keys (`CSE_KMS`) is used. If a query runs in a workgroup and the workgroup overrides client-side settings, then the workgroup's setting for encryption is used. It specifies whether query results must be encrypted, for all queries that run in this workgroup.
        /// </summary>
        [Input("encryptionOption")]
        public Input<string>? EncryptionOption { get; set; }

        /// <summary>
        /// For `SSE_KMS` and `CSE_KMS`, this is the KMS key Amazon Resource Name (ARN).
        /// </summary>
        [Input("kmsKeyArn")]
        public Input<string>? KmsKeyArn { get; set; }

        public WorkgroupConfigurationResultConfigurationEncryptionConfigurationArgs()
        {
        }
    }
}
