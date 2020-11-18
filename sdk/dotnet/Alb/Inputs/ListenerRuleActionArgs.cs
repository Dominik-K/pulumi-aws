// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Alb.Inputs
{

    public sealed class ListenerRuleActionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Information for creating an authenticate action using Cognito. Required if `type` is `authenticate-cognito`.
        /// </summary>
        [Input("authenticateCognito")]
        public Input<Inputs.ListenerRuleActionAuthenticateCognitoArgs>? AuthenticateCognito { get; set; }

        /// <summary>
        /// Information for creating an authenticate action using OIDC. Required if `type` is `authenticate-oidc`.
        /// </summary>
        [Input("authenticateOidc")]
        public Input<Inputs.ListenerRuleActionAuthenticateOidcArgs>? AuthenticateOidc { get; set; }

        /// <summary>
        /// Information for creating an action that returns a custom HTTP response. Required if `type` is `fixed-response`.
        /// </summary>
        [Input("fixedResponse")]
        public Input<Inputs.ListenerRuleActionFixedResponseArgs>? FixedResponse { get; set; }

        /// <summary>
        /// Information for creating an action that distributes requests among one or more target groups. Specify only if `type` is `forward`. If you specify both `forward` block and `target_group_arn` attribute, you can specify only one target group using `forward` and it must be the same target group specified in `target_group_arn`.
        /// </summary>
        [Input("forward")]
        public Input<Inputs.ListenerRuleActionForwardArgs>? Forward { get; set; }

        [Input("order")]
        public Input<int>? Order { get; set; }

        /// <summary>
        /// Information for creating a redirect action. Required if `type` is `redirect`.
        /// </summary>
        [Input("redirect")]
        public Input<Inputs.ListenerRuleActionRedirectArgs>? Redirect { get; set; }

        /// <summary>
        /// The ARN of the Target Group to which to route traffic. Specify only if `type` is `forward` and you want to route to a single target group. To route to one or more target groups, use a `forward` block instead.
        /// </summary>
        [Input("targetGroupArn")]
        public Input<string>? TargetGroupArn { get; set; }

        /// <summary>
        /// The type of routing action. Valid values are `forward`, `redirect`, `fixed-response`, `authenticate-cognito` and `authenticate-oidc`.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ListenerRuleActionArgs()
        {
        }
    }
}
