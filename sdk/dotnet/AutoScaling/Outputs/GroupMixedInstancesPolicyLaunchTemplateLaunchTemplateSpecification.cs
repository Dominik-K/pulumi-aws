// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AutoScaling.Outputs
{

    [OutputType]
    public sealed class GroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification
    {
        /// <summary>
        /// The ID of the launch template. Conflicts with `launch_template_name`.
        /// </summary>
        public readonly string? LaunchTemplateId;
        /// <summary>
        /// The name of the launch template. Conflicts with `launch_template_id`.
        /// </summary>
        public readonly string? LaunchTemplateName;
        /// <summary>
        /// Template version. Can be version number, `$Latest`, or `$Default`. (Default: `$Default`).
        /// </summary>
        public readonly string? Version;

        [OutputConstructor]
        private GroupMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification(
            string? launchTemplateId,

            string? launchTemplateName,

            string? version)
        {
            LaunchTemplateId = launchTemplateId;
            LaunchTemplateName = launchTemplateName;
            Version = version;
        }
    }
}
