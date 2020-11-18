// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2.Inputs
{

    public sealed class LaunchTemplateTagSpecificationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The type of resource to tag. Valid values are `instance`, `volume`, `elastic-gpu` and `spot-instances-request`.
        /// </summary>
        [Input("resourceType")]
        public Input<string>? ResourceType { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public LaunchTemplateTagSpecificationArgs()
        {
        }
    }
}