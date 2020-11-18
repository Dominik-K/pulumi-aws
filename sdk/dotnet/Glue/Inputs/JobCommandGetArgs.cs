// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Glue.Inputs
{

    public sealed class JobCommandGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the job command. Defaults to `glueetl`. Use `pythonshell` for Python Shell Job Type, `max_capacity` needs to be set if `pythonshell` is chosen.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The Python version being used to execute a Python shell job. Allowed values are 2 or 3.
        /// </summary>
        [Input("pythonVersion")]
        public Input<string>? PythonVersion { get; set; }

        /// <summary>
        /// Specifies the S3 path to a script that executes a job.
        /// </summary>
        [Input("scriptLocation", required: true)]
        public Input<string> ScriptLocation { get; set; } = null!;

        public JobCommandGetArgs()
        {
        }
    }
}
