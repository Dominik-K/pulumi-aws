// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.OpsWorks.Inputs
{

    public sealed class StaticWebLayerEbsVolumeGetArgs : Pulumi.ResourceArgs
    {
        [Input("encrypted")]
        public Input<bool>? Encrypted { get; set; }

        /// <summary>
        /// For PIOPS volumes, the IOPS per disk.
        /// </summary>
        [Input("iops")]
        public Input<int>? Iops { get; set; }

        /// <summary>
        /// The path to mount the EBS volume on the layer's instances.
        /// </summary>
        [Input("mountPoint", required: true)]
        public Input<string> MountPoint { get; set; } = null!;

        /// <summary>
        /// The number of disks to use for the EBS volume.
        /// </summary>
        [Input("numberOfDisks", required: true)]
        public Input<int> NumberOfDisks { get; set; } = null!;

        /// <summary>
        /// The RAID level to use for the volume.
        /// </summary>
        [Input("raidLevel")]
        public Input<string>? RaidLevel { get; set; }

        /// <summary>
        /// The size of the volume in gigabytes.
        /// </summary>
        [Input("size", required: true)]
        public Input<int> Size { get; set; } = null!;

        /// <summary>
        /// The type of volume to create. This may be `standard` (the default), `io1` or `gp2`.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public StaticWebLayerEbsVolumeGetArgs()
        {
        }
    }
}
