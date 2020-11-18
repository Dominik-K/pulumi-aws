// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.WafV2.Outputs
{

    [OutputType]
    public sealed class WebAclVisibilityConfig
    {
        /// <summary>
        /// A boolean indicating whether the associated resource sends metrics to CloudWatch. For the list of available metrics, see [AWS WAF Metrics](https://docs.aws.amazon.com/waf/latest/developerguide/monitoring-cloudwatch.html#waf-metrics).
        /// </summary>
        public readonly bool CloudwatchMetricsEnabled;
        /// <summary>
        /// A friendly name of the CloudWatch metric. The name can contain only alphanumeric characters (A-Z, a-z, 0-9) hyphen(-) and underscore (\_), with length from one to 128 characters. It can't contain whitespace or metric names reserved for AWS WAF, for example `All` and `Default_Action`.
        /// </summary>
        public readonly string MetricName;
        /// <summary>
        /// A boolean indicating whether AWS WAF should store a sampling of the web requests that match the rules. You can view the sampled requests through the AWS WAF console.
        /// </summary>
        public readonly bool SampledRequestsEnabled;

        [OutputConstructor]
        private WebAclVisibilityConfig(
            bool cloudwatchMetricsEnabled,

            string metricName,

            bool sampledRequestsEnabled)
        {
            CloudwatchMetricsEnabled = cloudwatchMetricsEnabled;
            MetricName = metricName;
            SampledRequestsEnabled = sampledRequestsEnabled;
        }
    }
}
