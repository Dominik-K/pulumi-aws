// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2.Outputs
{

    [OutputType]
    public sealed class SpotInstanceRequestRootBlockDevice
    {
        /// <summary>
        /// Whether the volume should be destroyed
        /// on instance termination (Default: `true`).
        /// </summary>
        public readonly bool? DeleteOnTermination;
        /// <summary>
        /// The name of the device to mount.
        /// </summary>
        public readonly string? DeviceName;
        /// <summary>
        /// Enable volume encryption. (Default: `false`). Must be configured to perform drift detection.
        /// </summary>
        public readonly bool? Encrypted;
        /// <summary>
        /// The amount of provisioned
        /// [IOPS](https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-io-characteristics.html).
        /// This is only valid for `volume_type` of `"io1/io2"`, and must be specified if
        /// using that type
        /// </summary>
        public readonly int? Iops;
        /// <summary>
        /// Amazon Resource Name (ARN) of the KMS Key to use when encrypting the volume. Must be configured to perform drift detection.
        /// </summary>
        public readonly string? KmsKeyId;
        public readonly string? VolumeId;
        /// <summary>
        /// The size of the volume in gibibytes (GiB).
        /// </summary>
        public readonly int? VolumeSize;
        /// <summary>
        /// The type of volume. Can be `"standard"`, `"gp2"`, `"io1"`, `"io2"`, `"sc1"`, or `"st1"`. (Default: `"gp2"`).
        /// </summary>
        public readonly string? VolumeType;

        [OutputConstructor]
        private SpotInstanceRequestRootBlockDevice(
            bool? deleteOnTermination,

            string? deviceName,

            bool? encrypted,

            int? iops,

            string? kmsKeyId,

            string? volumeId,

            int? volumeSize,

            string? volumeType)
        {
            DeleteOnTermination = deleteOnTermination;
            DeviceName = deviceName;
            Encrypted = encrypted;
            Iops = iops;
            KmsKeyId = kmsKeyId;
            VolumeId = volumeId;
            VolumeSize = volumeSize;
            VolumeType = volumeType;
        }
    }
}