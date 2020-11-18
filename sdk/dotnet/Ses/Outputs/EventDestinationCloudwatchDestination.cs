// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ses.Outputs
{

    [OutputType]
    public sealed class EventDestinationCloudwatchDestination
    {
        /// <summary>
        /// The default value for the event
        /// </summary>
        public readonly string DefaultValue;
        /// <summary>
        /// The name for the dimension
        /// </summary>
        public readonly string DimensionName;
        /// <summary>
        /// The source for the value. It can be either `"messageTag"` or `"emailHeader"`
        /// </summary>
        public readonly string ValueSource;

        [OutputConstructor]
        private EventDestinationCloudwatchDestination(
            string defaultValue,

            string dimensionName,

            string valueSource)
        {
            DefaultValue = defaultValue;
            DimensionName = dimensionName;
            ValueSource = valueSource;
        }
    }
}
