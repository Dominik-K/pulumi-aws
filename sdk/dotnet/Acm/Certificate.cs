// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Acm
{
    /// <summary>
    /// The ACM certificate resource allows requesting and management of certificates
    /// from the Amazon Certificate Manager.
    /// 
    /// It deals with requesting certificates and managing their attributes and life-cycle.
    /// This resource does not deal with validation of a certificate but can provide inputs
    /// for other resources implementing the validation. It does not wait for a certificate to be issued.
    /// Use a `aws.acm.CertificateValidation` resource for this.
    /// 
    /// Most commonly, this resource is used together with `aws.route53.Record` and
    /// `aws.acm.CertificateValidation` to request a DNS validated certificate,
    /// deploy the required validation records and wait for validation to complete.
    /// 
    /// Domain validation through E-Mail is also supported but should be avoided as it requires a manual step outside
    /// of this provider.
    /// 
    /// It's recommended to specify `create_before_destroy = true` in a [lifecycle](https://www.terraform.io/docs/configuration/resources.html#lifecycle) block to replace a certificate
    /// which is currently in use (eg, by `aws.lb.Listener`).
    /// 
    /// ## Example Usage
    /// ### Certificate creation
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var cert = new Aws.Acm.Certificate("cert", new Aws.Acm.CertificateArgs
    ///         {
    ///             DomainName = "example.com",
    ///             Tags = 
    ///             {
    ///                 { "Environment", "test" },
    ///             },
    ///             ValidationMethod = "DNS",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ### Importing an existing certificate
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// using Tls = Pulumi.Tls;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var examplePrivateKey = new Tls.PrivateKey("examplePrivateKey", new Tls.PrivateKeyArgs
    ///         {
    ///             Algorithm = "RSA",
    ///         });
    ///         var exampleSelfSignedCert = new Tls.SelfSignedCert("exampleSelfSignedCert", new Tls.SelfSignedCertArgs
    ///         {
    ///             AllowedUses = 
    ///             {
    ///                 "key_encipherment",
    ///                 "digital_signature",
    ///                 "server_auth",
    ///             },
    ///             KeyAlgorithm = "RSA",
    ///             PrivateKeyPem = examplePrivateKey.PrivateKeyPem,
    ///             Subjects = 
    ///             {
    ///                 new Tls.Inputs.SelfSignedCertSubjectArgs
    ///                 {
    ///                     CommonName = "example.com",
    ///                     Organization = "ACME Examples, Inc",
    ///                 },
    ///             },
    ///             ValidityPeriodHours = 12,
    ///         });
    ///         var cert = new Aws.Acm.Certificate("cert", new Aws.Acm.CertificateArgs
    ///         {
    ///             CertificateBody = exampleSelfSignedCert.CertPem,
    ///             PrivateKey = examplePrivateKey.PrivateKeyPem,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class Certificate : Pulumi.CustomResource
    {
        /// <summary>
        /// The ARN of the certificate
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// ARN of an ACMPCA
        /// </summary>
        [Output("certificateAuthorityArn")]
        public Output<string?> CertificateAuthorityArn { get; private set; } = null!;

        /// <summary>
        /// The certificate's PEM-formatted public key
        /// </summary>
        [Output("certificateBody")]
        public Output<string?> CertificateBody { get; private set; } = null!;

        /// <summary>
        /// The certificate's PEM-formatted chain
        /// * Creating a private CA issued certificate
        /// </summary>
        [Output("certificateChain")]
        public Output<string?> CertificateChain { get; private set; } = null!;

        /// <summary>
        /// A domain name for which the certificate should be issued
        /// </summary>
        [Output("domainName")]
        public Output<string> DomainName { get; private set; } = null!;

        /// <summary>
        /// A list of attributes to feed into other resources to complete certificate validation. Can have more than one element, e.g. if SANs are defined. Only set if `DNS`-validation was used.
        /// </summary>
        [Output("domainValidationOptions")]
        public Output<ImmutableArray<Outputs.CertificateDomainValidationOption>> DomainValidationOptions { get; private set; } = null!;

        /// <summary>
        /// Configuration block used to set certificate options. Detailed below.
        /// * Importing an existing certificate
        /// </summary>
        [Output("options")]
        public Output<Outputs.CertificateOptions?> Options { get; private set; } = null!;

        /// <summary>
        /// The certificate's PEM-formatted private key
        /// </summary>
        [Output("privateKey")]
        public Output<string?> PrivateKey { get; private set; } = null!;

        /// <summary>
        /// Status of the certificate.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// A list of domains that should be SANs in the issued certificate. To remove all elements of a previously configured list, set this value equal to an empty list (`[]`) to trigger recreation.
        /// </summary>
        [Output("subjectAlternativeNames")]
        public Output<ImmutableArray<string>> SubjectAlternativeNames { get; private set; } = null!;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// A list of addresses that received a validation E-Mail. Only set if `EMAIL`-validation was used.
        /// </summary>
        [Output("validationEmails")]
        public Output<ImmutableArray<string>> ValidationEmails { get; private set; } = null!;

        /// <summary>
        /// Which method to use for validation. `DNS` or `EMAIL` are valid, `NONE` can be used for certificates that were imported into ACM and then into the provider.
        /// </summary>
        [Output("validationMethod")]
        public Output<string> ValidationMethod { get; private set; } = null!;


        /// <summary>
        /// Create a Certificate resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Certificate(string name, CertificateArgs? args = null, CustomResourceOptions? options = null)
            : base("aws:acm/certificate:Certificate", name, args ?? new CertificateArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Certificate(string name, Input<string> id, CertificateState? state = null, CustomResourceOptions? options = null)
            : base("aws:acm/certificate:Certificate", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Certificate resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Certificate Get(string name, Input<string> id, CertificateState? state = null, CustomResourceOptions? options = null)
        {
            return new Certificate(name, id, state, options);
        }
    }

    public sealed class CertificateArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ARN of an ACMPCA
        /// </summary>
        [Input("certificateAuthorityArn")]
        public Input<string>? CertificateAuthorityArn { get; set; }

        /// <summary>
        /// The certificate's PEM-formatted public key
        /// </summary>
        [Input("certificateBody")]
        public Input<string>? CertificateBody { get; set; }

        /// <summary>
        /// The certificate's PEM-formatted chain
        /// * Creating a private CA issued certificate
        /// </summary>
        [Input("certificateChain")]
        public Input<string>? CertificateChain { get; set; }

        /// <summary>
        /// A domain name for which the certificate should be issued
        /// </summary>
        [Input("domainName")]
        public Input<string>? DomainName { get; set; }

        /// <summary>
        /// Configuration block used to set certificate options. Detailed below.
        /// * Importing an existing certificate
        /// </summary>
        [Input("options")]
        public Input<Inputs.CertificateOptionsArgs>? Options { get; set; }

        /// <summary>
        /// The certificate's PEM-formatted private key
        /// </summary>
        [Input("privateKey")]
        public Input<string>? PrivateKey { get; set; }

        [Input("subjectAlternativeNames")]
        private InputList<string>? _subjectAlternativeNames;

        /// <summary>
        /// A list of domains that should be SANs in the issued certificate. To remove all elements of a previously configured list, set this value equal to an empty list (`[]`) to trigger recreation.
        /// </summary>
        public InputList<string> SubjectAlternativeNames
        {
            get => _subjectAlternativeNames ?? (_subjectAlternativeNames = new InputList<string>());
            set => _subjectAlternativeNames = value;
        }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Which method to use for validation. `DNS` or `EMAIL` are valid, `NONE` can be used for certificates that were imported into ACM and then into the provider.
        /// </summary>
        [Input("validationMethod")]
        public Input<string>? ValidationMethod { get; set; }

        public CertificateArgs()
        {
        }
    }

    public sealed class CertificateState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ARN of the certificate
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// ARN of an ACMPCA
        /// </summary>
        [Input("certificateAuthorityArn")]
        public Input<string>? CertificateAuthorityArn { get; set; }

        /// <summary>
        /// The certificate's PEM-formatted public key
        /// </summary>
        [Input("certificateBody")]
        public Input<string>? CertificateBody { get; set; }

        /// <summary>
        /// The certificate's PEM-formatted chain
        /// * Creating a private CA issued certificate
        /// </summary>
        [Input("certificateChain")]
        public Input<string>? CertificateChain { get; set; }

        /// <summary>
        /// A domain name for which the certificate should be issued
        /// </summary>
        [Input("domainName")]
        public Input<string>? DomainName { get; set; }

        [Input("domainValidationOptions")]
        private InputList<Inputs.CertificateDomainValidationOptionGetArgs>? _domainValidationOptions;

        /// <summary>
        /// A list of attributes to feed into other resources to complete certificate validation. Can have more than one element, e.g. if SANs are defined. Only set if `DNS`-validation was used.
        /// </summary>
        public InputList<Inputs.CertificateDomainValidationOptionGetArgs> DomainValidationOptions
        {
            get => _domainValidationOptions ?? (_domainValidationOptions = new InputList<Inputs.CertificateDomainValidationOptionGetArgs>());
            set => _domainValidationOptions = value;
        }

        /// <summary>
        /// Configuration block used to set certificate options. Detailed below.
        /// * Importing an existing certificate
        /// </summary>
        [Input("options")]
        public Input<Inputs.CertificateOptionsGetArgs>? Options { get; set; }

        /// <summary>
        /// The certificate's PEM-formatted private key
        /// </summary>
        [Input("privateKey")]
        public Input<string>? PrivateKey { get; set; }

        /// <summary>
        /// Status of the certificate.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("subjectAlternativeNames")]
        private InputList<string>? _subjectAlternativeNames;

        /// <summary>
        /// A list of domains that should be SANs in the issued certificate. To remove all elements of a previously configured list, set this value equal to an empty list (`[]`) to trigger recreation.
        /// </summary>
        public InputList<string> SubjectAlternativeNames
        {
            get => _subjectAlternativeNames ?? (_subjectAlternativeNames = new InputList<string>());
            set => _subjectAlternativeNames = value;
        }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        [Input("validationEmails")]
        private InputList<string>? _validationEmails;

        /// <summary>
        /// A list of addresses that received a validation E-Mail. Only set if `EMAIL`-validation was used.
        /// </summary>
        public InputList<string> ValidationEmails
        {
            get => _validationEmails ?? (_validationEmails = new InputList<string>());
            set => _validationEmails = value;
        }

        /// <summary>
        /// Which method to use for validation. `DNS` or `EMAIL` are valid, `NONE` can be used for certificates that were imported into ACM and then into the provider.
        /// </summary>
        [Input("validationMethod")]
        public Input<string>? ValidationMethod { get; set; }

        public CertificateState()
        {
        }
    }
}
