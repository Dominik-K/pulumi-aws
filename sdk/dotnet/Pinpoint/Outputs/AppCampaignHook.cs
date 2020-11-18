// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Pinpoint.Outputs
{

    [OutputType]
    public sealed class AppCampaignHook
    {
        /// <summary>
        /// Lambda function name or ARN to be called for delivery. Conflicts with `web_url`
        /// </summary>
        public readonly string? LambdaFunctionName;
        /// <summary>
        /// What mode Lambda should be invoked in. Valid values for this parameter are `DELIVERY`, `FILTER`.
        /// </summary>
        public readonly string? Mode;
        /// <summary>
        /// Web URL to call for hook. If the URL has authentication specified it will be added as authentication to the request. Conflicts with `lambda_function_name`
        /// </summary>
        public readonly string? WebUrl;

        [OutputConstructor]
        private AppCampaignHook(
            string? lambdaFunctionName,

            string? mode,

            string? webUrl)
        {
            LambdaFunctionName = lambdaFunctionName;
            Mode = mode;
            WebUrl = webUrl;
        }
    }
}
