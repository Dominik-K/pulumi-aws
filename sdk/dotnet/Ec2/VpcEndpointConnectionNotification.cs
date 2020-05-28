// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2
{
    /// <summary>
    /// Provides a VPC Endpoint connection notification resource.
    /// Connection notifications notify subscribers of VPC Endpoint events.
    /// 
    /// ## Example Usage
    /// 
    /// 
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var topic = new Aws.Sns.Topic("topic", new Aws.Sns.TopicArgs
    ///         {
    ///             Policy = @"{
    ///     ""Version"":""2012-10-17"",
    ///     ""Statement"":[{
    ///         ""Effect"": ""Allow"",
    ///         ""Principal"": {
    ///             ""Service"": ""vpce.amazonaws.com""
    ///         },
    ///         ""Action"": ""SNS:Publish"",
    ///         ""Resource"": ""arn:aws:sns:*:*:vpce-notification-topic""
    ///     }]
    /// }
    /// 
    /// ",
    ///         });
    ///         var fooVpcEndpointService = new Aws.Ec2.VpcEndpointService("fooVpcEndpointService", new Aws.Ec2.VpcEndpointServiceArgs
    ///         {
    ///             AcceptanceRequired = false,
    ///             NetworkLoadBalancerArns = 
    ///             {
    ///                 aws_lb.Test.Arn,
    ///             },
    ///         });
    ///         var fooVpcEndpointConnectionNotification = new Aws.Ec2.VpcEndpointConnectionNotification("fooVpcEndpointConnectionNotification", new Aws.Ec2.VpcEndpointConnectionNotificationArgs
    ///         {
    ///             ConnectionEvents = 
    ///             {
    ///                 "Accept",
    ///                 "Reject",
    ///             },
    ///             ConnectionNotificationArn = topic.Arn,
    ///             VpcEndpointServiceId = fooVpcEndpointService.Id,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class VpcEndpointConnectionNotification : Pulumi.CustomResource
    {
        /// <summary>
        /// One or more endpoint [events](https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateVpcEndpointConnectionNotification.html#API_CreateVpcEndpointConnectionNotification_RequestParameters) for which to receive notifications.
        /// </summary>
        [Output("connectionEvents")]
        public Output<ImmutableArray<string>> ConnectionEvents { get; private set; } = null!;

        /// <summary>
        /// The ARN of the SNS topic for the notifications.
        /// </summary>
        [Output("connectionNotificationArn")]
        public Output<string> ConnectionNotificationArn { get; private set; } = null!;

        /// <summary>
        /// The type of notification.
        /// </summary>
        [Output("notificationType")]
        public Output<string> NotificationType { get; private set; } = null!;

        /// <summary>
        /// The state of the notification.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// The ID of the VPC Endpoint to receive notifications for.
        /// </summary>
        [Output("vpcEndpointId")]
        public Output<string?> VpcEndpointId { get; private set; } = null!;

        /// <summary>
        /// The ID of the VPC Endpoint Service to receive notifications for.
        /// </summary>
        [Output("vpcEndpointServiceId")]
        public Output<string?> VpcEndpointServiceId { get; private set; } = null!;


        /// <summary>
        /// Create a VpcEndpointConnectionNotification resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VpcEndpointConnectionNotification(string name, VpcEndpointConnectionNotificationArgs args, CustomResourceOptions? options = null)
            : base("aws:ec2/vpcEndpointConnectionNotification:VpcEndpointConnectionNotification", name, args ?? new VpcEndpointConnectionNotificationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private VpcEndpointConnectionNotification(string name, Input<string> id, VpcEndpointConnectionNotificationState? state = null, CustomResourceOptions? options = null)
            : base("aws:ec2/vpcEndpointConnectionNotification:VpcEndpointConnectionNotification", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing VpcEndpointConnectionNotification resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VpcEndpointConnectionNotification Get(string name, Input<string> id, VpcEndpointConnectionNotificationState? state = null, CustomResourceOptions? options = null)
        {
            return new VpcEndpointConnectionNotification(name, id, state, options);
        }
    }

    public sealed class VpcEndpointConnectionNotificationArgs : Pulumi.ResourceArgs
    {
        [Input("connectionEvents", required: true)]
        private InputList<string>? _connectionEvents;

        /// <summary>
        /// One or more endpoint [events](https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateVpcEndpointConnectionNotification.html#API_CreateVpcEndpointConnectionNotification_RequestParameters) for which to receive notifications.
        /// </summary>
        public InputList<string> ConnectionEvents
        {
            get => _connectionEvents ?? (_connectionEvents = new InputList<string>());
            set => _connectionEvents = value;
        }

        /// <summary>
        /// The ARN of the SNS topic for the notifications.
        /// </summary>
        [Input("connectionNotificationArn", required: true)]
        public Input<string> ConnectionNotificationArn { get; set; } = null!;

        /// <summary>
        /// The ID of the VPC Endpoint to receive notifications for.
        /// </summary>
        [Input("vpcEndpointId")]
        public Input<string>? VpcEndpointId { get; set; }

        /// <summary>
        /// The ID of the VPC Endpoint Service to receive notifications for.
        /// </summary>
        [Input("vpcEndpointServiceId")]
        public Input<string>? VpcEndpointServiceId { get; set; }

        public VpcEndpointConnectionNotificationArgs()
        {
        }
    }

    public sealed class VpcEndpointConnectionNotificationState : Pulumi.ResourceArgs
    {
        [Input("connectionEvents")]
        private InputList<string>? _connectionEvents;

        /// <summary>
        /// One or more endpoint [events](https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateVpcEndpointConnectionNotification.html#API_CreateVpcEndpointConnectionNotification_RequestParameters) for which to receive notifications.
        /// </summary>
        public InputList<string> ConnectionEvents
        {
            get => _connectionEvents ?? (_connectionEvents = new InputList<string>());
            set => _connectionEvents = value;
        }

        /// <summary>
        /// The ARN of the SNS topic for the notifications.
        /// </summary>
        [Input("connectionNotificationArn")]
        public Input<string>? ConnectionNotificationArn { get; set; }

        /// <summary>
        /// The type of notification.
        /// </summary>
        [Input("notificationType")]
        public Input<string>? NotificationType { get; set; }

        /// <summary>
        /// The state of the notification.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// The ID of the VPC Endpoint to receive notifications for.
        /// </summary>
        [Input("vpcEndpointId")]
        public Input<string>? VpcEndpointId { get; set; }

        /// <summary>
        /// The ID of the VPC Endpoint Service to receive notifications for.
        /// </summary>
        [Input("vpcEndpointServiceId")]
        public Input<string>? VpcEndpointServiceId { get; set; }

        public VpcEndpointConnectionNotificationState()
        {
        }
    }
}
