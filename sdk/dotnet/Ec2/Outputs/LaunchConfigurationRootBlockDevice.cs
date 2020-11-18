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
    public sealed class LaunchConfigurationRootBlockDevice
    {
        public readonly bool? DeleteOnTermination;
        public readonly bool? Encrypted;
        public readonly int? Iops;
        public readonly int? VolumeSize;
        public readonly string? VolumeType;

        [OutputConstructor]
        private LaunchConfigurationRootBlockDevice(
            bool? deleteOnTermination,

            bool? encrypted,

            int? iops,

            int? volumeSize,

            string? volumeType)
        {
            DeleteOnTermination = deleteOnTermination;
            Encrypted = encrypted;
            Iops = iops;
            VolumeSize = volumeSize;
            VolumeType = volumeType;
        }
    }
}
