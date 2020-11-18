// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CodeDeploy
{
    /// <summary>
    /// Provides a CodeDeploy Deployment Group for a CodeDeploy Application
    /// 
    /// &gt; **NOTE on blue/green deployments:** When using `green_fleet_provisioning_option` with the `COPY_AUTO_SCALING_GROUP` action, CodeDeploy will create a new ASG with a different name. This ASG is _not_ managed by this provider and will conflict with existing configuration and state. You may want to use a different approach to managing deployments that involve multiple ASG, such as `DISCOVER_EXISTING` with separate blue and green ASG.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var exampleRole = new Aws.Iam.Role("exampleRole", new Aws.Iam.RoleArgs
    ///         {
    ///             AssumeRolePolicy = @"{
    ///   ""Version"": ""2012-10-17"",
    ///   ""Statement"": [
    ///     {
    ///       ""Sid"": """",
    ///       ""Effect"": ""Allow"",
    ///       ""Principal"": {
    ///         ""Service"": ""codedeploy.amazonaws.com""
    ///       },
    ///       ""Action"": ""sts:AssumeRole""
    ///     }
    ///   ]
    /// }
    /// ",
    ///         });
    ///         var aWSCodeDeployRole = new Aws.Iam.RolePolicyAttachment("aWSCodeDeployRole", new Aws.Iam.RolePolicyAttachmentArgs
    ///         {
    ///             PolicyArn = "arn:aws:iam::aws:policy/service-role/AWSCodeDeployRole",
    ///             Role = exampleRole.Name,
    ///         });
    ///         var exampleApplication = new Aws.CodeDeploy.Application("exampleApplication", new Aws.CodeDeploy.ApplicationArgs
    ///         {
    ///         });
    ///         var exampleTopic = new Aws.Sns.Topic("exampleTopic", new Aws.Sns.TopicArgs
    ///         {
    ///         });
    ///         var exampleDeploymentGroup = new Aws.CodeDeploy.DeploymentGroup("exampleDeploymentGroup", new Aws.CodeDeploy.DeploymentGroupArgs
    ///         {
    ///             AppName = exampleApplication.Name,
    ///             DeploymentGroupName = "example-group",
    ///             ServiceRoleArn = exampleRole.Arn,
    ///             Ec2TagSets = 
    ///             {
    ///                 new Aws.CodeDeploy.Inputs.DeploymentGroupEc2TagSetArgs
    ///                 {
    ///                     Ec2TagFilters = 
    ///                     {
    ///                         new Aws.CodeDeploy.Inputs.DeploymentGroupEc2TagSetEc2TagFilterArgs
    ///                         {
    ///                             Key = "filterkey1",
    ///                             Type = "KEY_AND_VALUE",
    ///                             Value = "filtervalue",
    ///                         },
    ///                         new Aws.CodeDeploy.Inputs.DeploymentGroupEc2TagSetEc2TagFilterArgs
    ///                         {
    ///                             Key = "filterkey2",
    ///                             Type = "KEY_AND_VALUE",
    ///                             Value = "filtervalue",
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///             TriggerConfigurations = 
    ///             {
    ///                 new Aws.CodeDeploy.Inputs.DeploymentGroupTriggerConfigurationArgs
    ///                 {
    ///                     TriggerEvents = 
    ///                     {
    ///                         "DeploymentFailure",
    ///                     },
    ///                     TriggerName = "example-trigger",
    ///                     TriggerTargetArn = exampleTopic.Arn,
    ///                 },
    ///             },
    ///             AutoRollbackConfiguration = new Aws.CodeDeploy.Inputs.DeploymentGroupAutoRollbackConfigurationArgs
    ///             {
    ///                 Enabled = true,
    ///                 Events = 
    ///                 {
    ///                     "DEPLOYMENT_FAILURE",
    ///                 },
    ///             },
    ///             AlarmConfiguration = new Aws.CodeDeploy.Inputs.DeploymentGroupAlarmConfigurationArgs
    ///             {
    ///                 Alarms = 
    ///                 {
    ///                     "my-alarm-name",
    ///                 },
    ///                 Enabled = true,
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ### Blue Green Deployments with ECS
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var exampleApplication = new Aws.CodeDeploy.Application("exampleApplication", new Aws.CodeDeploy.ApplicationArgs
    ///         {
    ///             ComputePlatform = "ECS",
    ///         });
    ///         var exampleDeploymentGroup = new Aws.CodeDeploy.DeploymentGroup("exampleDeploymentGroup", new Aws.CodeDeploy.DeploymentGroupArgs
    ///         {
    ///             AppName = exampleApplication.Name,
    ///             DeploymentConfigName = "CodeDeployDefault.ECSAllAtOnce",
    ///             DeploymentGroupName = "example",
    ///             ServiceRoleArn = aws_iam_role.Example.Arn,
    ///             AutoRollbackConfiguration = new Aws.CodeDeploy.Inputs.DeploymentGroupAutoRollbackConfigurationArgs
    ///             {
    ///                 Enabled = true,
    ///                 Events = 
    ///                 {
    ///                     "DEPLOYMENT_FAILURE",
    ///                 },
    ///             },
    ///             BlueGreenDeploymentConfig = new Aws.CodeDeploy.Inputs.DeploymentGroupBlueGreenDeploymentConfigArgs
    ///             {
    ///                 DeploymentReadyOption = new Aws.CodeDeploy.Inputs.DeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOptionArgs
    ///                 {
    ///                     ActionOnTimeout = "CONTINUE_DEPLOYMENT",
    ///                 },
    ///                 TerminateBlueInstancesOnDeploymentSuccess = new Aws.CodeDeploy.Inputs.DeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccessArgs
    ///                 {
    ///                     Action = "TERMINATE",
    ///                     TerminationWaitTimeInMinutes = 5,
    ///                 },
    ///             },
    ///             DeploymentStyle = new Aws.CodeDeploy.Inputs.DeploymentGroupDeploymentStyleArgs
    ///             {
    ///                 DeploymentOption = "WITH_TRAFFIC_CONTROL",
    ///                 DeploymentType = "BLUE_GREEN",
    ///             },
    ///             EcsService = new Aws.CodeDeploy.Inputs.DeploymentGroupEcsServiceArgs
    ///             {
    ///                 ClusterName = aws_ecs_cluster.Example.Name,
    ///                 ServiceName = aws_ecs_service.Example.Name,
    ///             },
    ///             LoadBalancerInfo = new Aws.CodeDeploy.Inputs.DeploymentGroupLoadBalancerInfoArgs
    ///             {
    ///                 TargetGroupPairInfo = new Aws.CodeDeploy.Inputs.DeploymentGroupLoadBalancerInfoTargetGroupPairInfoArgs
    ///                 {
    ///                     ProdTrafficRoute = new Aws.CodeDeploy.Inputs.DeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteArgs
    ///                     {
    ///                         ListenerArns = 
    ///                         {
    ///                             aws_lb_listener.Example.Arn,
    ///                         },
    ///                     },
    ///                     TargetGroups = 
    ///                     {
    ///                         new Aws.CodeDeploy.Inputs.DeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroupArgs
    ///                         {
    ///                             Name = aws_lb_target_group.Blue.Name,
    ///                         },
    ///                         new Aws.CodeDeploy.Inputs.DeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroupArgs
    ///                         {
    ///                             Name = aws_lb_target_group.Green.Name,
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ### Blue Green Deployments with Servers and Classic ELB
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var exampleApplication = new Aws.CodeDeploy.Application("exampleApplication", new Aws.CodeDeploy.ApplicationArgs
    ///         {
    ///         });
    ///         var exampleDeploymentGroup = new Aws.CodeDeploy.DeploymentGroup("exampleDeploymentGroup", new Aws.CodeDeploy.DeploymentGroupArgs
    ///         {
    ///             AppName = exampleApplication.Name,
    ///             DeploymentGroupName = "example-group",
    ///             ServiceRoleArn = aws_iam_role.Example.Arn,
    ///             DeploymentStyle = new Aws.CodeDeploy.Inputs.DeploymentGroupDeploymentStyleArgs
    ///             {
    ///                 DeploymentOption = "WITH_TRAFFIC_CONTROL",
    ///                 DeploymentType = "BLUE_GREEN",
    ///             },
    ///             LoadBalancerInfo = new Aws.CodeDeploy.Inputs.DeploymentGroupLoadBalancerInfoArgs
    ///             {
    ///                 ElbInfos = 
    ///                 {
    ///                     new Aws.CodeDeploy.Inputs.DeploymentGroupLoadBalancerInfoElbInfoArgs
    ///                     {
    ///                         Name = aws_elb.Example.Name,
    ///                     },
    ///                 },
    ///             },
    ///             BlueGreenDeploymentConfig = new Aws.CodeDeploy.Inputs.DeploymentGroupBlueGreenDeploymentConfigArgs
    ///             {
    ///                 DeploymentReadyOption = new Aws.CodeDeploy.Inputs.DeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOptionArgs
    ///                 {
    ///                     ActionOnTimeout = "STOP_DEPLOYMENT",
    ///                     WaitTimeInMinutes = 60,
    ///                 },
    ///                 GreenFleetProvisioningOption = new Aws.CodeDeploy.Inputs.DeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOptionArgs
    ///                 {
    ///                     Action = "DISCOVER_EXISTING",
    ///                 },
    ///                 TerminateBlueInstancesOnDeploymentSuccess = new Aws.CodeDeploy.Inputs.DeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccessArgs
    ///                 {
    ///                     Action = "KEEP_ALIVE",
    ///                 },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class DeploymentGroup : Pulumi.CustomResource
    {
        /// <summary>
        /// Configuration block of alarms associated with the deployment group (documented below).
        /// </summary>
        [Output("alarmConfiguration")]
        public Output<Outputs.DeploymentGroupAlarmConfiguration?> AlarmConfiguration { get; private set; } = null!;

        /// <summary>
        /// The name of the application.
        /// </summary>
        [Output("appName")]
        public Output<string> AppName { get; private set; } = null!;

        /// <summary>
        /// Configuration block of the automatic rollback configuration associated with the deployment group (documented below).
        /// </summary>
        [Output("autoRollbackConfiguration")]
        public Output<Outputs.DeploymentGroupAutoRollbackConfiguration?> AutoRollbackConfiguration { get; private set; } = null!;

        /// <summary>
        /// Autoscaling groups associated with the deployment group.
        /// </summary>
        [Output("autoscalingGroups")]
        public Output<ImmutableArray<string>> AutoscalingGroups { get; private set; } = null!;

        /// <summary>
        /// Configuration block of the blue/green deployment options for a deployment group (documented below).
        /// </summary>
        [Output("blueGreenDeploymentConfig")]
        public Output<Outputs.DeploymentGroupBlueGreenDeploymentConfig> BlueGreenDeploymentConfig { get; private set; } = null!;

        /// <summary>
        /// The name of the group's deployment config. The default is "CodeDeployDefault.OneAtATime".
        /// </summary>
        [Output("deploymentConfigName")]
        public Output<string?> DeploymentConfigName { get; private set; } = null!;

        /// <summary>
        /// The name of the deployment group.
        /// </summary>
        [Output("deploymentGroupName")]
        public Output<string> DeploymentGroupName { get; private set; } = null!;

        /// <summary>
        /// Configuration block of the type of deployment, either in-place or blue/green, you want to run and whether to route deployment traffic behind a load balancer (documented below).
        /// </summary>
        [Output("deploymentStyle")]
        public Output<Outputs.DeploymentGroupDeploymentStyle?> DeploymentStyle { get; private set; } = null!;

        /// <summary>
        /// Tag filters associated with the deployment group. See the AWS docs for details.
        /// </summary>
        [Output("ec2TagFilters")]
        public Output<ImmutableArray<Outputs.DeploymentGroupEc2TagFilter>> Ec2TagFilters { get; private set; } = null!;

        /// <summary>
        /// Configuration block(s) of Tag filters associated with the deployment group, which are also referred to as tag groups (documented below). See the AWS docs for details.
        /// </summary>
        [Output("ec2TagSets")]
        public Output<ImmutableArray<Outputs.DeploymentGroupEc2TagSet>> Ec2TagSets { get; private set; } = null!;

        /// <summary>
        /// Configuration block(s) of the ECS services for a deployment group (documented below).
        /// </summary>
        [Output("ecsService")]
        public Output<Outputs.DeploymentGroupEcsService?> EcsService { get; private set; } = null!;

        /// <summary>
        /// Single configuration block of the load balancer to use in a blue/green deployment (documented below).
        /// </summary>
        [Output("loadBalancerInfo")]
        public Output<Outputs.DeploymentGroupLoadBalancerInfo?> LoadBalancerInfo { get; private set; } = null!;

        /// <summary>
        /// On premise tag filters associated with the group. See the AWS docs for details.
        /// </summary>
        [Output("onPremisesInstanceTagFilters")]
        public Output<ImmutableArray<Outputs.DeploymentGroupOnPremisesInstanceTagFilter>> OnPremisesInstanceTagFilters { get; private set; } = null!;

        /// <summary>
        /// The service role ARN that allows deployments.
        /// </summary>
        [Output("serviceRoleArn")]
        public Output<string> ServiceRoleArn { get; private set; } = null!;

        /// <summary>
        /// Configuration block(s) of the triggers for the deployment group (documented below).
        /// </summary>
        [Output("triggerConfigurations")]
        public Output<ImmutableArray<Outputs.DeploymentGroupTriggerConfiguration>> TriggerConfigurations { get; private set; } = null!;


        /// <summary>
        /// Create a DeploymentGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DeploymentGroup(string name, DeploymentGroupArgs args, CustomResourceOptions? options = null)
            : base("aws:codedeploy/deploymentGroup:DeploymentGroup", name, args ?? new DeploymentGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DeploymentGroup(string name, Input<string> id, DeploymentGroupState? state = null, CustomResourceOptions? options = null)
            : base("aws:codedeploy/deploymentGroup:DeploymentGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing DeploymentGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DeploymentGroup Get(string name, Input<string> id, DeploymentGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new DeploymentGroup(name, id, state, options);
        }
    }

    public sealed class DeploymentGroupArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configuration block of alarms associated with the deployment group (documented below).
        /// </summary>
        [Input("alarmConfiguration")]
        public Input<Inputs.DeploymentGroupAlarmConfigurationArgs>? AlarmConfiguration { get; set; }

        /// <summary>
        /// The name of the application.
        /// </summary>
        [Input("appName", required: true)]
        public Input<string> AppName { get; set; } = null!;

        /// <summary>
        /// Configuration block of the automatic rollback configuration associated with the deployment group (documented below).
        /// </summary>
        [Input("autoRollbackConfiguration")]
        public Input<Inputs.DeploymentGroupAutoRollbackConfigurationArgs>? AutoRollbackConfiguration { get; set; }

        [Input("autoscalingGroups")]
        private InputList<string>? _autoscalingGroups;

        /// <summary>
        /// Autoscaling groups associated with the deployment group.
        /// </summary>
        public InputList<string> AutoscalingGroups
        {
            get => _autoscalingGroups ?? (_autoscalingGroups = new InputList<string>());
            set => _autoscalingGroups = value;
        }

        /// <summary>
        /// Configuration block of the blue/green deployment options for a deployment group (documented below).
        /// </summary>
        [Input("blueGreenDeploymentConfig")]
        public Input<Inputs.DeploymentGroupBlueGreenDeploymentConfigArgs>? BlueGreenDeploymentConfig { get; set; }

        /// <summary>
        /// The name of the group's deployment config. The default is "CodeDeployDefault.OneAtATime".
        /// </summary>
        [Input("deploymentConfigName")]
        public Input<string>? DeploymentConfigName { get; set; }

        /// <summary>
        /// The name of the deployment group.
        /// </summary>
        [Input("deploymentGroupName", required: true)]
        public Input<string> DeploymentGroupName { get; set; } = null!;

        /// <summary>
        /// Configuration block of the type of deployment, either in-place or blue/green, you want to run and whether to route deployment traffic behind a load balancer (documented below).
        /// </summary>
        [Input("deploymentStyle")]
        public Input<Inputs.DeploymentGroupDeploymentStyleArgs>? DeploymentStyle { get; set; }

        [Input("ec2TagFilters")]
        private InputList<Inputs.DeploymentGroupEc2TagFilterArgs>? _ec2TagFilters;

        /// <summary>
        /// Tag filters associated with the deployment group. See the AWS docs for details.
        /// </summary>
        public InputList<Inputs.DeploymentGroupEc2TagFilterArgs> Ec2TagFilters
        {
            get => _ec2TagFilters ?? (_ec2TagFilters = new InputList<Inputs.DeploymentGroupEc2TagFilterArgs>());
            set => _ec2TagFilters = value;
        }

        [Input("ec2TagSets")]
        private InputList<Inputs.DeploymentGroupEc2TagSetArgs>? _ec2TagSets;

        /// <summary>
        /// Configuration block(s) of Tag filters associated with the deployment group, which are also referred to as tag groups (documented below). See the AWS docs for details.
        /// </summary>
        public InputList<Inputs.DeploymentGroupEc2TagSetArgs> Ec2TagSets
        {
            get => _ec2TagSets ?? (_ec2TagSets = new InputList<Inputs.DeploymentGroupEc2TagSetArgs>());
            set => _ec2TagSets = value;
        }

        /// <summary>
        /// Configuration block(s) of the ECS services for a deployment group (documented below).
        /// </summary>
        [Input("ecsService")]
        public Input<Inputs.DeploymentGroupEcsServiceArgs>? EcsService { get; set; }

        /// <summary>
        /// Single configuration block of the load balancer to use in a blue/green deployment (documented below).
        /// </summary>
        [Input("loadBalancerInfo")]
        public Input<Inputs.DeploymentGroupLoadBalancerInfoArgs>? LoadBalancerInfo { get; set; }

        [Input("onPremisesInstanceTagFilters")]
        private InputList<Inputs.DeploymentGroupOnPremisesInstanceTagFilterArgs>? _onPremisesInstanceTagFilters;

        /// <summary>
        /// On premise tag filters associated with the group. See the AWS docs for details.
        /// </summary>
        public InputList<Inputs.DeploymentGroupOnPremisesInstanceTagFilterArgs> OnPremisesInstanceTagFilters
        {
            get => _onPremisesInstanceTagFilters ?? (_onPremisesInstanceTagFilters = new InputList<Inputs.DeploymentGroupOnPremisesInstanceTagFilterArgs>());
            set => _onPremisesInstanceTagFilters = value;
        }

        /// <summary>
        /// The service role ARN that allows deployments.
        /// </summary>
        [Input("serviceRoleArn", required: true)]
        public Input<string> ServiceRoleArn { get; set; } = null!;

        [Input("triggerConfigurations")]
        private InputList<Inputs.DeploymentGroupTriggerConfigurationArgs>? _triggerConfigurations;

        /// <summary>
        /// Configuration block(s) of the triggers for the deployment group (documented below).
        /// </summary>
        public InputList<Inputs.DeploymentGroupTriggerConfigurationArgs> TriggerConfigurations
        {
            get => _triggerConfigurations ?? (_triggerConfigurations = new InputList<Inputs.DeploymentGroupTriggerConfigurationArgs>());
            set => _triggerConfigurations = value;
        }

        public DeploymentGroupArgs()
        {
        }
    }

    public sealed class DeploymentGroupState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configuration block of alarms associated with the deployment group (documented below).
        /// </summary>
        [Input("alarmConfiguration")]
        public Input<Inputs.DeploymentGroupAlarmConfigurationGetArgs>? AlarmConfiguration { get; set; }

        /// <summary>
        /// The name of the application.
        /// </summary>
        [Input("appName")]
        public Input<string>? AppName { get; set; }

        /// <summary>
        /// Configuration block of the automatic rollback configuration associated with the deployment group (documented below).
        /// </summary>
        [Input("autoRollbackConfiguration")]
        public Input<Inputs.DeploymentGroupAutoRollbackConfigurationGetArgs>? AutoRollbackConfiguration { get; set; }

        [Input("autoscalingGroups")]
        private InputList<string>? _autoscalingGroups;

        /// <summary>
        /// Autoscaling groups associated with the deployment group.
        /// </summary>
        public InputList<string> AutoscalingGroups
        {
            get => _autoscalingGroups ?? (_autoscalingGroups = new InputList<string>());
            set => _autoscalingGroups = value;
        }

        /// <summary>
        /// Configuration block of the blue/green deployment options for a deployment group (documented below).
        /// </summary>
        [Input("blueGreenDeploymentConfig")]
        public Input<Inputs.DeploymentGroupBlueGreenDeploymentConfigGetArgs>? BlueGreenDeploymentConfig { get; set; }

        /// <summary>
        /// The name of the group's deployment config. The default is "CodeDeployDefault.OneAtATime".
        /// </summary>
        [Input("deploymentConfigName")]
        public Input<string>? DeploymentConfigName { get; set; }

        /// <summary>
        /// The name of the deployment group.
        /// </summary>
        [Input("deploymentGroupName")]
        public Input<string>? DeploymentGroupName { get; set; }

        /// <summary>
        /// Configuration block of the type of deployment, either in-place or blue/green, you want to run and whether to route deployment traffic behind a load balancer (documented below).
        /// </summary>
        [Input("deploymentStyle")]
        public Input<Inputs.DeploymentGroupDeploymentStyleGetArgs>? DeploymentStyle { get; set; }

        [Input("ec2TagFilters")]
        private InputList<Inputs.DeploymentGroupEc2TagFilterGetArgs>? _ec2TagFilters;

        /// <summary>
        /// Tag filters associated with the deployment group. See the AWS docs for details.
        /// </summary>
        public InputList<Inputs.DeploymentGroupEc2TagFilterGetArgs> Ec2TagFilters
        {
            get => _ec2TagFilters ?? (_ec2TagFilters = new InputList<Inputs.DeploymentGroupEc2TagFilterGetArgs>());
            set => _ec2TagFilters = value;
        }

        [Input("ec2TagSets")]
        private InputList<Inputs.DeploymentGroupEc2TagSetGetArgs>? _ec2TagSets;

        /// <summary>
        /// Configuration block(s) of Tag filters associated with the deployment group, which are also referred to as tag groups (documented below). See the AWS docs for details.
        /// </summary>
        public InputList<Inputs.DeploymentGroupEc2TagSetGetArgs> Ec2TagSets
        {
            get => _ec2TagSets ?? (_ec2TagSets = new InputList<Inputs.DeploymentGroupEc2TagSetGetArgs>());
            set => _ec2TagSets = value;
        }

        /// <summary>
        /// Configuration block(s) of the ECS services for a deployment group (documented below).
        /// </summary>
        [Input("ecsService")]
        public Input<Inputs.DeploymentGroupEcsServiceGetArgs>? EcsService { get; set; }

        /// <summary>
        /// Single configuration block of the load balancer to use in a blue/green deployment (documented below).
        /// </summary>
        [Input("loadBalancerInfo")]
        public Input<Inputs.DeploymentGroupLoadBalancerInfoGetArgs>? LoadBalancerInfo { get; set; }

        [Input("onPremisesInstanceTagFilters")]
        private InputList<Inputs.DeploymentGroupOnPremisesInstanceTagFilterGetArgs>? _onPremisesInstanceTagFilters;

        /// <summary>
        /// On premise tag filters associated with the group. See the AWS docs for details.
        /// </summary>
        public InputList<Inputs.DeploymentGroupOnPremisesInstanceTagFilterGetArgs> OnPremisesInstanceTagFilters
        {
            get => _onPremisesInstanceTagFilters ?? (_onPremisesInstanceTagFilters = new InputList<Inputs.DeploymentGroupOnPremisesInstanceTagFilterGetArgs>());
            set => _onPremisesInstanceTagFilters = value;
        }

        /// <summary>
        /// The service role ARN that allows deployments.
        /// </summary>
        [Input("serviceRoleArn")]
        public Input<string>? ServiceRoleArn { get; set; }

        [Input("triggerConfigurations")]
        private InputList<Inputs.DeploymentGroupTriggerConfigurationGetArgs>? _triggerConfigurations;

        /// <summary>
        /// Configuration block(s) of the triggers for the deployment group (documented below).
        /// </summary>
        public InputList<Inputs.DeploymentGroupTriggerConfigurationGetArgs> TriggerConfigurations
        {
            get => _triggerConfigurations ?? (_triggerConfigurations = new InputList<Inputs.DeploymentGroupTriggerConfigurationGetArgs>());
            set => _triggerConfigurations = value;
        }

        public DeploymentGroupState()
        {
        }
    }
}