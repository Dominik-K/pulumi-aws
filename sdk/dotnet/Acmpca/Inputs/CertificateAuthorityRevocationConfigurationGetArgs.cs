// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Acmpca.Inputs
{

    public sealed class CertificateAuthorityRevocationConfigurationGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Nested argument containing configuration of the certificate revocation list (CRL), if any, maintained by the certificate authority. Defined below.
        /// </summary>
        [Input("crlConfiguration")]
        public Input<Inputs.CertificateAuthorityRevocationConfigurationCrlConfigurationGetArgs>? CrlConfiguration { get; set; }

        public CertificateAuthorityRevocationConfigurationGetArgs()
        {
        }
    }
}
