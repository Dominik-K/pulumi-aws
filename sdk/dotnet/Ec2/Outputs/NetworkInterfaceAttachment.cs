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
    public sealed class NetworkInterfaceAttachment
    {
        public readonly string? AttachmentId;
        /// <summary>
        /// Integer to define the devices index.
        /// </summary>
        public readonly int DeviceIndex;
        /// <summary>
        /// ID of the instance to attach to.
        /// </summary>
        public readonly string Instance;

        [OutputConstructor]
        private NetworkInterfaceAttachment(
            string? attachmentId,

            int deviceIndex,

            string instance)
        {
            AttachmentId = attachmentId;
            DeviceIndex = deviceIndex;
            Instance = instance;
        }
    }
}
