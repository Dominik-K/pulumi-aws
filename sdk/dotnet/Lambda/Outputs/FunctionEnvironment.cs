// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Lambda.Outputs
{

    [OutputType]
    public sealed class FunctionEnvironment
    {
        /// <summary>
        /// A map that defines environment variables for the Lambda function.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Variables;

        [OutputConstructor]
        private FunctionEnvironment(ImmutableDictionary<string, string>? variables)
        {
            Variables = variables;
        }
    }
}
