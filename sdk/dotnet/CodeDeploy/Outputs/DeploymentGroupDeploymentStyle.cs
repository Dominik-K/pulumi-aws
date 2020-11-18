// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CodeDeploy.Outputs
{

    [OutputType]
    public sealed class DeploymentGroupDeploymentStyle
    {
        /// <summary>
        /// Indicates whether to route deployment traffic behind a load balancer. Valid Values are `WITH_TRAFFIC_CONTROL` or `WITHOUT_TRAFFIC_CONTROL`. Default is `WITHOUT_TRAFFIC_CONTROL`.
        /// </summary>
        public readonly string? DeploymentOption;
        /// <summary>
        /// Indicates whether to run an in-place deployment or a blue/green deployment. Valid Values are `IN_PLACE` or `BLUE_GREEN`. Default is `IN_PLACE`.
        /// </summary>
        public readonly string? DeploymentType;

        [OutputConstructor]
        private DeploymentGroupDeploymentStyle(
            string? deploymentOption,

            string? deploymentType)
        {
            DeploymentOption = deploymentOption;
            DeploymentType = deploymentType;
        }
    }
}
