// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Kms.Inputs
{

    public sealed class GrantConstraintGetArgs : Pulumi.ResourceArgs
    {
        [Input("encryptionContextEquals")]
        private InputMap<string>? _encryptionContextEquals;

        /// <summary>
        /// A list of key-value pairs that must match the encryption context in subsequent cryptographic operation requests. The grant allows the operation only when the encryption context in the request is the same as the encryption context specified in this constraint. Conflicts with `encryption_context_subset`.
        /// </summary>
        public InputMap<string> EncryptionContextEquals
        {
            get => _encryptionContextEquals ?? (_encryptionContextEquals = new InputMap<string>());
            set => _encryptionContextEquals = value;
        }

        [Input("encryptionContextSubset")]
        private InputMap<string>? _encryptionContextSubset;

        /// <summary>
        /// A list of key-value pairs that must be included in the encryption context of subsequent cryptographic operation requests. The grant allows the cryptographic operation only when the encryption context in the request includes the key-value pairs specified in this constraint, although it can include additional key-value pairs. Conflicts with `encryption_context_equals`.
        /// </summary>
        public InputMap<string> EncryptionContextSubset
        {
            get => _encryptionContextSubset ?? (_encryptionContextSubset = new InputMap<string>());
            set => _encryptionContextSubset = value;
        }

        public GrantConstraintGetArgs()
        {
        }
    }
}
