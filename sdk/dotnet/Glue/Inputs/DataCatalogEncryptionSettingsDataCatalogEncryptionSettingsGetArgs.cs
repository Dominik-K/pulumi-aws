// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Glue.Inputs
{

    public sealed class DataCatalogEncryptionSettingsDataCatalogEncryptionSettingsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// When connection password protection is enabled, the Data Catalog uses a customer-provided key to encrypt the password as part of CreateConnection or UpdateConnection and store it in the ENCRYPTED_PASSWORD field in the connection properties. You can enable catalog encryption or only password encryption. see Connection Password Encryption.
        /// </summary>
        [Input("connectionPasswordEncryption", required: true)]
        public Input<Inputs.DataCatalogEncryptionSettingsDataCatalogEncryptionSettingsConnectionPasswordEncryptionGetArgs> ConnectionPasswordEncryption { get; set; } = null!;

        /// <summary>
        /// Specifies the encryption-at-rest configuration for the Data Catalog. see Encryption At Rest.
        /// </summary>
        [Input("encryptionAtRest", required: true)]
        public Input<Inputs.DataCatalogEncryptionSettingsDataCatalogEncryptionSettingsEncryptionAtRestGetArgs> EncryptionAtRest { get; set; } = null!;

        public DataCatalogEncryptionSettingsDataCatalogEncryptionSettingsGetArgs()
        {
        }
    }
}
