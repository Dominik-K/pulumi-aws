// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Emr.Inputs
{

    public sealed class ClusterBootstrapActionGetArgs : Pulumi.ResourceArgs
    {
        [Input("args")]
        private InputList<string>? _args;

        /// <summary>
        /// List of command line arguments passed to the JAR file's main function when executed.
        /// </summary>
        public InputList<string> Args
        {
            get => _args ?? (_args = new InputList<string>());
            set => _args = value;
        }

        /// <summary>
        /// Friendly name given to the instance fleet.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Location of the script to run during a bootstrap action. Can be either a location in Amazon S3 or on a local file system
        /// </summary>
        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        public ClusterBootstrapActionGetArgs()
        {
        }
    }
}
