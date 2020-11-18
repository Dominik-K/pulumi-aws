// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Elb.Inputs
{

    public sealed class LoadBalancerListenerGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The port on the instance to route to
        /// </summary>
        [Input("instancePort", required: true)]
        public Input<int> InstancePort { get; set; } = null!;

        /// <summary>
        /// The protocol to use to the instance. Valid
        /// values are `HTTP`, `HTTPS`, `TCP`, or `SSL`
        /// </summary>
        [Input("instanceProtocol", required: true)]
        public Input<string> InstanceProtocol { get; set; } = null!;

        /// <summary>
        /// The port to listen on for the load balancer
        /// </summary>
        [Input("lbPort", required: true)]
        public Input<int> LbPort { get; set; } = null!;

        /// <summary>
        /// The protocol to listen on. Valid values are `HTTP`,
        /// `HTTPS`, `TCP`, or `SSL`
        /// </summary>
        [Input("lbProtocol", required: true)]
        public Input<string> LbProtocol { get; set; } = null!;

        /// <summary>
        /// The ARN of an SSL certificate you have
        /// uploaded to AWS IAM. **Note ECDSA-specific restrictions below.  Only valid when `lb_protocol` is either HTTPS or SSL**
        /// </summary>
        [Input("sslCertificateId")]
        public Input<string>? SslCertificateId { get; set; }

        public LoadBalancerListenerGetArgs()
        {
        }
    }
}
