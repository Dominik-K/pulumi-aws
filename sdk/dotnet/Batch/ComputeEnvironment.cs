// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Batch
{
    /// <summary>
    /// Creates a AWS Batch compute environment. Compute environments contain the Amazon ECS container instances that are used to run containerized batch jobs.
    /// 
    /// For information about AWS Batch, see [What is AWS Batch?](http://docs.aws.amazon.com/batch/latest/userguide/what-is-batch.html) .
    /// For information about compute environment, see [Compute Environments](http://docs.aws.amazon.com/batch/latest/userguide/compute_environments.html) .
    /// 
    /// &gt; **Note:** To prevent a race condition during environment deletion, make sure to set `depends_on` to the related `aws.iam.RolePolicyAttachment`;
    /// otherwise, the policy may be destroyed too soon and the compute environment will then get stuck in the `DELETING` state, see [Troubleshooting AWS Batch](http://docs.aws.amazon.com/batch/latest/userguide/troubleshooting.html) .
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
    ///         var ecsInstanceRoleRole = new Aws.Iam.Role("ecsInstanceRoleRole", new Aws.Iam.RoleArgs
    ///         {
    ///             AssumeRolePolicy = @"{
    ///     ""Version"": ""2012-10-17"",
    ///     ""Statement"": [
    /// 	{
    /// 	    ""Action"": ""sts:AssumeRole"",
    /// 	    ""Effect"": ""Allow"",
    /// 	    ""Principal"": {
    /// 		""Service"": ""ec2.amazonaws.com""
    /// 	    }
    /// 	}
    ///     ]
    /// }
    /// 
    /// ",
    ///         });
    ///         var ecsInstanceRoleRolePolicyAttachment = new Aws.Iam.RolePolicyAttachment("ecsInstanceRoleRolePolicyAttachment", new Aws.Iam.RolePolicyAttachmentArgs
    ///         {
    ///             PolicyArn = "arn:aws:iam::aws:policy/service-role/AmazonEC2ContainerServiceforEC2Role",
    ///             Role = ecsInstanceRoleRole.Name,
    ///         });
    ///         var ecsInstanceRoleInstanceProfile = new Aws.Iam.InstanceProfile("ecsInstanceRoleInstanceProfile", new Aws.Iam.InstanceProfileArgs
    ///         {
    ///             Role = ecsInstanceRoleRole.Name,
    ///         });
    ///         var awsBatchServiceRoleRole = new Aws.Iam.Role("awsBatchServiceRoleRole", new Aws.Iam.RoleArgs
    ///         {
    ///             AssumeRolePolicy = @"{
    ///     ""Version"": ""2012-10-17"",
    ///     ""Statement"": [
    /// 	{
    /// 	    ""Action"": ""sts:AssumeRole"",
    /// 	    ""Effect"": ""Allow"",
    /// 	    ""Principal"": {
    /// 		""Service"": ""batch.amazonaws.com""
    /// 	    }
    /// 	}
    ///     ]
    /// }
    /// 
    /// ",
    ///         });
    ///         var awsBatchServiceRoleRolePolicyAttachment = new Aws.Iam.RolePolicyAttachment("awsBatchServiceRoleRolePolicyAttachment", new Aws.Iam.RolePolicyAttachmentArgs
    ///         {
    ///             PolicyArn = "arn:aws:iam::aws:policy/service-role/AWSBatchServiceRole",
    ///             Role = awsBatchServiceRoleRole.Name,
    ///         });
    ///         var sampleSecurityGroup = new Aws.Ec2.SecurityGroup("sampleSecurityGroup", new Aws.Ec2.SecurityGroupArgs
    ///         {
    ///             Egress = 
    ///             {
    ///                 new Aws.Ec2.Inputs.SecurityGroupEgressArgs
    ///                 {
    ///                     CidrBlocks = 
    ///                     {
    ///                         "0.0.0.0/0",
    ///                     },
    ///                     FromPort = 0,
    ///                     Protocol = "-1",
    ///                     ToPort = 0,
    ///                 },
    ///             },
    ///         });
    ///         var sampleVpc = new Aws.Ec2.Vpc("sampleVpc", new Aws.Ec2.VpcArgs
    ///         {
    ///             CidrBlock = "10.1.0.0/16",
    ///         });
    ///         var sampleSubnet = new Aws.Ec2.Subnet("sampleSubnet", new Aws.Ec2.SubnetArgs
    ///         {
    ///             CidrBlock = "10.1.1.0/24",
    ///             VpcId = sampleVpc.Id,
    ///         });
    ///         var sampleComputeEnvironment = new Aws.Batch.ComputeEnvironment("sampleComputeEnvironment", new Aws.Batch.ComputeEnvironmentArgs
    ///         {
    ///             ComputeEnvironmentName = "sample",
    ///             ComputeResources = new Aws.Batch.Inputs.ComputeEnvironmentComputeResourcesArgs
    ///             {
    ///                 InstanceRole = ecsInstanceRoleInstanceProfile.Arn,
    ///                 InstanceTypes = 
    ///                 {
    ///                     "c4.large",
    ///                 },
    ///                 MaxVcpus = 16,
    ///                 MinVcpus = 0,
    ///                 SecurityGroupIds = 
    ///                 {
    ///                     sampleSecurityGroup.Id,
    ///                 },
    ///                 Subnets = 
    ///                 {
    ///                     sampleSubnet.Id,
    ///                 },
    ///                 Type = "EC2",
    ///             },
    ///             ServiceRole = awsBatchServiceRoleRole.Arn,
    ///             Type = "MANAGED",
    ///         }, new CustomResourceOptions
    ///         {
    ///             DependsOn = 
    ///             {
    ///                 "aws_iam_role_policy_attachment.aws_batch_service_role",
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class ComputeEnvironment : Pulumi.CustomResource
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) of the compute environment.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// The name for your compute environment. Up to 128 letters (uppercase and lowercase), numbers, and underscores are allowed. If omitted, this provider will assign a random, unique name.
        /// </summary>
        [Output("computeEnvironmentName")]
        public Output<string> ComputeEnvironmentName { get; private set; } = null!;

        /// <summary>
        /// Creates a unique compute environment name beginning with the specified prefix. Conflicts with `compute_environment_name`.
        /// </summary>
        [Output("computeEnvironmentNamePrefix")]
        public Output<string?> ComputeEnvironmentNamePrefix { get; private set; } = null!;

        /// <summary>
        /// Details of the compute resources managed by the compute environment. This parameter is required for managed compute environments. See details below.
        /// </summary>
        [Output("computeResources")]
        public Output<Outputs.ComputeEnvironmentComputeResources?> ComputeResources { get; private set; } = null!;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the underlying Amazon ECS cluster used by the compute environment.
        /// </summary>
        [Output("ecsClusterArn")]
        public Output<string> EcsClusterArn { get; private set; } = null!;

        /// <summary>
        /// The full Amazon Resource Name (ARN) of the IAM role that allows AWS Batch to make calls to other AWS services on your behalf.
        /// </summary>
        [Output("serviceRole")]
        public Output<string> ServiceRole { get; private set; } = null!;

        /// <summary>
        /// The state of the compute environment. If the state is `ENABLED`, then the compute environment accepts jobs from a queue and can scale out automatically based on queues. Valid items are `ENABLED` or `DISABLED`. Defaults to `ENABLED`.
        /// </summary>
        [Output("state")]
        public Output<string?> State { get; private set; } = null!;

        /// <summary>
        /// The current status of the compute environment (for example, CREATING or VALID).
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// A short, human-readable string to provide additional details about the current status of the compute environment.
        /// </summary>
        [Output("statusReason")]
        public Output<string> StatusReason { get; private set; } = null!;

        /// <summary>
        /// The type of compute environment. Valid items are `EC2` or `SPOT`.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a ComputeEnvironment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ComputeEnvironment(string name, ComputeEnvironmentArgs args, CustomResourceOptions? options = null)
            : base("aws:batch/computeEnvironment:ComputeEnvironment", name, args ?? new ComputeEnvironmentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ComputeEnvironment(string name, Input<string> id, ComputeEnvironmentState? state = null, CustomResourceOptions? options = null)
            : base("aws:batch/computeEnvironment:ComputeEnvironment", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ComputeEnvironment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ComputeEnvironment Get(string name, Input<string> id, ComputeEnvironmentState? state = null, CustomResourceOptions? options = null)
        {
            return new ComputeEnvironment(name, id, state, options);
        }
    }

    public sealed class ComputeEnvironmentArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name for your compute environment. Up to 128 letters (uppercase and lowercase), numbers, and underscores are allowed. If omitted, this provider will assign a random, unique name.
        /// </summary>
        [Input("computeEnvironmentName")]
        public Input<string>? ComputeEnvironmentName { get; set; }

        /// <summary>
        /// Creates a unique compute environment name beginning with the specified prefix. Conflicts with `compute_environment_name`.
        /// </summary>
        [Input("computeEnvironmentNamePrefix")]
        public Input<string>? ComputeEnvironmentNamePrefix { get; set; }

        /// <summary>
        /// Details of the compute resources managed by the compute environment. This parameter is required for managed compute environments. See details below.
        /// </summary>
        [Input("computeResources")]
        public Input<Inputs.ComputeEnvironmentComputeResourcesArgs>? ComputeResources { get; set; }

        /// <summary>
        /// The full Amazon Resource Name (ARN) of the IAM role that allows AWS Batch to make calls to other AWS services on your behalf.
        /// </summary>
        [Input("serviceRole", required: true)]
        public Input<string> ServiceRole { get; set; } = null!;

        /// <summary>
        /// The state of the compute environment. If the state is `ENABLED`, then the compute environment accepts jobs from a queue and can scale out automatically based on queues. Valid items are `ENABLED` or `DISABLED`. Defaults to `ENABLED`.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// The type of compute environment. Valid items are `EC2` or `SPOT`.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ComputeEnvironmentArgs()
        {
        }
    }

    public sealed class ComputeEnvironmentState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) of the compute environment.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// The name for your compute environment. Up to 128 letters (uppercase and lowercase), numbers, and underscores are allowed. If omitted, this provider will assign a random, unique name.
        /// </summary>
        [Input("computeEnvironmentName")]
        public Input<string>? ComputeEnvironmentName { get; set; }

        /// <summary>
        /// Creates a unique compute environment name beginning with the specified prefix. Conflicts with `compute_environment_name`.
        /// </summary>
        [Input("computeEnvironmentNamePrefix")]
        public Input<string>? ComputeEnvironmentNamePrefix { get; set; }

        /// <summary>
        /// Details of the compute resources managed by the compute environment. This parameter is required for managed compute environments. See details below.
        /// </summary>
        [Input("computeResources")]
        public Input<Inputs.ComputeEnvironmentComputeResourcesGetArgs>? ComputeResources { get; set; }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the underlying Amazon ECS cluster used by the compute environment.
        /// </summary>
        [Input("ecsClusterArn")]
        public Input<string>? EcsClusterArn { get; set; }

        /// <summary>
        /// The full Amazon Resource Name (ARN) of the IAM role that allows AWS Batch to make calls to other AWS services on your behalf.
        /// </summary>
        [Input("serviceRole")]
        public Input<string>? ServiceRole { get; set; }

        /// <summary>
        /// The state of the compute environment. If the state is `ENABLED`, then the compute environment accepts jobs from a queue and can scale out automatically based on queues. Valid items are `ENABLED` or `DISABLED`. Defaults to `ENABLED`.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// The current status of the compute environment (for example, CREATING or VALID).
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// A short, human-readable string to provide additional details about the current status of the compute environment.
        /// </summary>
        [Input("statusReason")]
        public Input<string>? StatusReason { get; set; }

        /// <summary>
        /// The type of compute environment. Valid items are `EC2` or `SPOT`.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public ComputeEnvironmentState()
        {
        }
    }
}
