// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Msk.Inputs
{

    public sealed class ClusterOpenMonitoringPrometheusGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configuration block for JMX Exporter. See below.
        /// </summary>
        [Input("jmxExporter")]
        public Input<Inputs.ClusterOpenMonitoringPrometheusJmxExporterGetArgs>? JmxExporter { get; set; }

        /// <summary>
        /// Configuration block for Node Exporter. See below.
        /// </summary>
        [Input("nodeExporter")]
        public Input<Inputs.ClusterOpenMonitoringPrometheusNodeExporterGetArgs>? NodeExporter { get; set; }

        public ClusterOpenMonitoringPrometheusGetArgs()
        {
        }
    }
}
