// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Workspaces.Outputs
{

    [OutputType]
    public sealed class GetDirectoryWorkspaceCreationPropertiesResult
    {
        /// <summary>
        /// The identifier of your custom security group. Should relate to the same VPC, where workspaces reside in.
        /// </summary>
        public readonly string CustomSecurityGroupId;
        /// <summary>
        /// The default organizational unit (OU) for your WorkSpace directories.
        /// </summary>
        public readonly string? DefaultOu;
        /// <summary>
        /// Indicates whether internet access is enabled for your WorkSpaces.
        /// </summary>
        public readonly bool? EnableInternetAccess;
        /// <summary>
        /// Indicates whether maintenance mode is enabled for your WorkSpaces. For more information, see [WorkSpace Maintenance](https://docs.aws.amazon.com/workspaces/latest/adminguide/workspace-maintenance.html).
        /// </summary>
        public readonly bool? EnableMaintenanceMode;
        /// <summary>
        /// Indicates whether users are local administrators of their WorkSpaces.
        /// </summary>
        public readonly bool? UserEnabledAsLocalAdministrator;

        [OutputConstructor]
        private GetDirectoryWorkspaceCreationPropertiesResult(
            string customSecurityGroupId,

            string? defaultOu,

            bool? enableInternetAccess,

            bool? enableMaintenanceMode,

            bool? userEnabledAsLocalAdministrator)
        {
            CustomSecurityGroupId = customSecurityGroupId;
            DefaultOu = defaultOu;
            EnableInternetAccess = enableInternetAccess;
            EnableMaintenanceMode = enableMaintenanceMode;
            UserEnabledAsLocalAdministrator = userEnabledAsLocalAdministrator;
        }
    }
}
