// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Budgets.Inputs
{

    public sealed class BudgetNotificationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Required) Comparison operator to use to evaluate the condition. Can be `LESS_THAN`, `EQUAL_TO` or `GREATER_THAN`.
        /// </summary>
        [Input("comparisonOperator", required: true)]
        public Input<string> ComparisonOperator { get; set; } = null!;

        /// <summary>
        /// (Required) What kind of budget value to notify on. Can be `ACTUAL` or `FORECASTED`
        /// </summary>
        [Input("notificationType", required: true)]
        public Input<string> NotificationType { get; set; } = null!;

        [Input("subscriberEmailAddresses")]
        private InputList<string>? _subscriberEmailAddresses;

        /// <summary>
        /// (Optional) E-Mail addresses to notify. Either this or `subscriber_sns_topic_arns` is required.
        /// </summary>
        public InputList<string> SubscriberEmailAddresses
        {
            get => _subscriberEmailAddresses ?? (_subscriberEmailAddresses = new InputList<string>());
            set => _subscriberEmailAddresses = value;
        }

        [Input("subscriberSnsTopicArns")]
        private InputList<string>? _subscriberSnsTopicArns;

        /// <summary>
        /// (Optional) SNS topics to notify. Either this or `subscriber_email_addresses` is required.
        /// </summary>
        public InputList<string> SubscriberSnsTopicArns
        {
            get => _subscriberSnsTopicArns ?? (_subscriberSnsTopicArns = new InputList<string>());
            set => _subscriberSnsTopicArns = value;
        }

        /// <summary>
        /// (Required) Threshold when the notification should be sent.
        /// </summary>
        [Input("threshold", required: true)]
        public Input<double> Threshold { get; set; } = null!;

        /// <summary>
        /// (Required) What kind of threshold is defined. Can be `PERCENTAGE` OR `ABSOLUTE_VALUE`.
        /// </summary>
        [Input("thresholdType", required: true)]
        public Input<string> ThresholdType { get; set; } = null!;

        public BudgetNotificationArgs()
        {
        }
    }
}
