// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Iot.Outputs
{

    [OutputType]
    public sealed class TopicRuleStepFunction
    {
        /// <summary>
        /// The prefix used to generate, along with a UUID, the unique state machine execution name.
        /// </summary>
        public readonly string? ExecutionNamePrefix;
        /// <summary>
        /// The ARN of the IAM role that grants access to start execution of the state machine.
        /// </summary>
        public readonly string RoleArn;
        /// <summary>
        /// The name of the Step Functions state machine whose execution will be started.
        /// </summary>
        public readonly string StateMachineName;

        [OutputConstructor]
        private TopicRuleStepFunction(
            string? executionNamePrefix,

            string roleArn,

            string stateMachineName)
        {
            ExecutionNamePrefix = executionNamePrefix;
            RoleArn = roleArn;
            StateMachineName = stateMachineName;
        }
    }
}
