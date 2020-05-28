// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CloudFront
{
    /// <summary>
    /// Creates an Amazon CloudFront web distribution.
    /// 
    /// For information about CloudFront distributions, see the
    /// [Amazon CloudFront Developer Guide](http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Introduction.html). For specific information about creating
    /// CloudFront web distributions, see the [POST Distribution](https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_CreateDistribution.html) page in the Amazon
    /// CloudFront API Reference.
    /// 
    /// &gt; **NOTE:** CloudFront distributions take about 15 minutes to a deployed state
    /// after creation or modification. During this time, deletes to resources will be
    /// blocked. If you need to delete a distribution that is enabled and you do not
    /// want to wait, you need to use the `retain_on_delete` flag.
    /// 
    /// ## Example Usage
    /// 
    /// 
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var bucket = new Aws.S3.Bucket("bucket", new Aws.S3.BucketArgs
    ///         {
    ///             Acl = "private",
    ///             Tags = 
    ///             {
    ///                 { "Name", "My bucket" },
    ///             },
    ///         });
    ///         var s3OriginId = "myS3Origin";
    ///         var s3Distribution = new Aws.CloudFront.Distribution("s3Distribution", new Aws.CloudFront.DistributionArgs
    ///         {
    ///             Aliases = 
    ///             {
    ///                 "mysite.example.com",
    ///                 "yoursite.example.com",
    ///             },
    ///             Comment = "Some comment",
    ///             DefaultCacheBehavior = new Aws.CloudFront.Inputs.DistributionDefaultCacheBehaviorArgs
    ///             {
    ///                 AllowedMethods = 
    ///                 {
    ///                     "DELETE",
    ///                     "GET",
    ///                     "HEAD",
    ///                     "OPTIONS",
    ///                     "PATCH",
    ///                     "POST",
    ///                     "PUT",
    ///                 },
    ///                 CachedMethods = 
    ///                 {
    ///                     "GET",
    ///                     "HEAD",
    ///                 },
    ///                 DefaultTtl = 3600,
    ///                 ForwardedValues = new Aws.CloudFront.Inputs.DistributionDefaultCacheBehaviorForwardedValuesArgs
    ///                 {
    ///                     Cookies = new Aws.CloudFront.Inputs.DistributionDefaultCacheBehaviorForwardedValuesCookiesArgs
    ///                     {
    ///                         Forward = "none",
    ///                     },
    ///                     QueryString = false,
    ///                 },
    ///                 MaxTtl = 86400,
    ///                 MinTtl = 0,
    ///                 TargetOriginId = s3OriginId,
    ///                 ViewerProtocolPolicy = "allow-all",
    ///             },
    ///             DefaultRootObject = "index.html",
    ///             Enabled = true,
    ///             IsIpv6Enabled = true,
    ///             LoggingConfig = new Aws.CloudFront.Inputs.DistributionLoggingConfigArgs
    ///             {
    ///                 Bucket = "mylogs.s3.amazonaws.com",
    ///                 IncludeCookies = false,
    ///                 Prefix = "myprefix",
    ///             },
    ///             OrderedCacheBehaviors = 
    ///             {
    ///                 new Aws.CloudFront.Inputs.DistributionOrderedCacheBehaviorArgs
    ///                 {
    ///                     AllowedMethods = 
    ///                     {
    ///                         "GET",
    ///                         "HEAD",
    ///                         "OPTIONS",
    ///                     },
    ///                     CachedMethods = 
    ///                     {
    ///                         "GET",
    ///                         "HEAD",
    ///                         "OPTIONS",
    ///                     },
    ///                     Compress = true,
    ///                     DefaultTtl = 86400,
    ///                     ForwardedValues = new Aws.CloudFront.Inputs.DistributionOrderedCacheBehaviorForwardedValuesArgs
    ///                     {
    ///                         Cookies = new Aws.CloudFront.Inputs.DistributionOrderedCacheBehaviorForwardedValuesCookiesArgs
    ///                         {
    ///                             Forward = "none",
    ///                         },
    ///                         Headers = 
    ///                         {
    ///                             "Origin",
    ///                         },
    ///                         QueryString = false,
    ///                     },
    ///                     MaxTtl = 31536000,
    ///                     MinTtl = 0,
    ///                     PathPattern = "/content/immutable/*",
    ///                     TargetOriginId = s3OriginId,
    ///                     ViewerProtocolPolicy = "redirect-to-https",
    ///                 },
    ///                 new Aws.CloudFront.Inputs.DistributionOrderedCacheBehaviorArgs
    ///                 {
    ///                     AllowedMethods = 
    ///                     {
    ///                         "GET",
    ///                         "HEAD",
    ///                         "OPTIONS",
    ///                     },
    ///                     CachedMethods = 
    ///                     {
    ///                         "GET",
    ///                         "HEAD",
    ///                     },
    ///                     Compress = true,
    ///                     DefaultTtl = 3600,
    ///                     ForwardedValues = new Aws.CloudFront.Inputs.DistributionOrderedCacheBehaviorForwardedValuesArgs
    ///                     {
    ///                         Cookies = new Aws.CloudFront.Inputs.DistributionOrderedCacheBehaviorForwardedValuesCookiesArgs
    ///                         {
    ///                             Forward = "none",
    ///                         },
    ///                         QueryString = false,
    ///                     },
    ///                     MaxTtl = 86400,
    ///                     MinTtl = 0,
    ///                     PathPattern = "/content/*",
    ///                     TargetOriginId = s3OriginId,
    ///                     ViewerProtocolPolicy = "redirect-to-https",
    ///                 },
    ///             },
    ///             Origins = 
    ///             {
    ///                 new Aws.CloudFront.Inputs.DistributionOriginArgs
    ///                 {
    ///                     DomainName = bucket.BucketRegionalDomainName,
    ///                     OriginId = s3OriginId,
    ///                     S3OriginConfig = new Aws.CloudFront.Inputs.DistributionOriginS3OriginConfigArgs
    ///                     {
    ///                         OriginAccessIdentity = "origin-access-identity/cloudfront/ABCDEFG1234567",
    ///                     },
    ///                 },
    ///             },
    ///             PriceClass = "PriceClass_200",
    ///             Restrictions = new Aws.CloudFront.Inputs.DistributionRestrictionsArgs
    ///             {
    ///                 GeoRestriction = new Aws.CloudFront.Inputs.DistributionRestrictionsGeoRestrictionArgs
    ///                 {
    ///                     Locations = 
    ///                     {
    ///                         "US",
    ///                         "CA",
    ///                         "GB",
    ///                         "DE",
    ///                     },
    ///                     RestrictionType = "whitelist",
    ///                 },
    ///             },
    ///             Tags = 
    ///             {
    ///                 { "Environment", "production" },
    ///             },
    ///             ViewerCertificate = new Aws.CloudFront.Inputs.DistributionViewerCertificateArgs
    ///             {
    ///                 CloudfrontDefaultCertificate = true,
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class Distribution : Pulumi.CustomResource
    {
        /// <summary>
        /// The key pair IDs that CloudFront is aware of for
        /// each trusted signer, if the distribution is set up to serve private content
        /// with signed URLs.
        /// </summary>
        [Output("activeTrustedSigners")]
        public Output<ImmutableDictionary<string, object>> ActiveTrustedSigners { get; private set; } = null!;

        /// <summary>
        /// Extra CNAMEs (alternate domain names), if any, for
        /// this distribution.
        /// </summary>
        [Output("aliases")]
        public Output<ImmutableArray<string>> Aliases { get; private set; } = null!;

        /// <summary>
        /// The ARN (Amazon Resource Name) for the distribution. For example: `arn:aws:cloudfront::123456789012:distribution/EDFDVBD632BHDS5`, where `123456789012` is your AWS account ID.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// Internal value used by CloudFront to allow future
        /// updates to the distribution configuration.
        /// </summary>
        [Output("callerReference")]
        public Output<string> CallerReference { get; private set; } = null!;

        /// <summary>
        /// Any comments you want to include about the
        /// distribution.
        /// </summary>
        [Output("comment")]
        public Output<string?> Comment { get; private set; } = null!;

        /// <summary>
        /// One or more custom error response elements (multiples allowed).
        /// </summary>
        [Output("customErrorResponses")]
        public Output<ImmutableArray<Outputs.DistributionCustomErrorResponse>> CustomErrorResponses { get; private set; } = null!;

        /// <summary>
        /// The default cache behavior for this distribution (maximum
        /// one).
        /// </summary>
        [Output("defaultCacheBehavior")]
        public Output<Outputs.DistributionDefaultCacheBehavior> DefaultCacheBehavior { get; private set; } = null!;

        /// <summary>
        /// The object that you want CloudFront to
        /// return (for example, index.html) when an end user requests the root URL.
        /// </summary>
        [Output("defaultRootObject")]
        public Output<string?> DefaultRootObject { get; private set; } = null!;

        /// <summary>
        /// The DNS domain name of either the S3 bucket, or
        /// web site of your custom origin.
        /// </summary>
        [Output("domainName")]
        public Output<string> DomainName { get; private set; } = null!;

        /// <summary>
        /// Whether the distribution is enabled to accept end
        /// user requests for content.
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// The current version of the distribution's information. For example:
        /// `E2QWRUHAPOMQZL`.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// The CloudFront Route 53 zone ID that can be used to
        /// route an [Alias Resource Record Set](http://docs.aws.amazon.com/Route53/latest/APIReference/CreateAliasRRSAPI.html) to. This attribute is simply an
        /// alias for the zone ID `Z2FDTNDATAQYW2`.
        /// </summary>
        [Output("hostedZoneId")]
        public Output<string> HostedZoneId { get; private set; } = null!;

        /// <summary>
        /// The maximum HTTP version to support on the
        /// distribution. Allowed values are `http1.1` and `http2`. The default is
        /// `http2`.
        /// </summary>
        [Output("httpVersion")]
        public Output<string?> HttpVersion { get; private set; } = null!;

        /// <summary>
        /// The number of invalidation batches
        /// currently in progress.
        /// </summary>
        [Output("inProgressValidationBatches")]
        public Output<int> InProgressValidationBatches { get; private set; } = null!;

        /// <summary>
        /// Whether the IPv6 is enabled for the distribution.
        /// </summary>
        [Output("isIpv6Enabled")]
        public Output<bool?> IsIpv6Enabled { get; private set; } = null!;

        /// <summary>
        /// The date and time the distribution was last modified.
        /// </summary>
        [Output("lastModifiedTime")]
        public Output<string> LastModifiedTime { get; private set; } = null!;

        /// <summary>
        /// The logging
        /// configuration that controls how logs are written
        /// to your distribution (maximum one).
        /// </summary>
        [Output("loggingConfig")]
        public Output<Outputs.DistributionLoggingConfig?> LoggingConfig { get; private set; } = null!;

        /// <summary>
        /// An ordered list of cache behaviors
        /// resource for this distribution. List from top to bottom
        /// in order of precedence. The topmost cache behavior will have precedence 0.
        /// </summary>
        [Output("orderedCacheBehaviors")]
        public Output<ImmutableArray<Outputs.DistributionOrderedCacheBehavior>> OrderedCacheBehaviors { get; private set; } = null!;

        /// <summary>
        /// One or more origin_group for this
        /// distribution (multiples allowed).
        /// </summary>
        [Output("originGroups")]
        public Output<ImmutableArray<Outputs.DistributionOriginGroup>> OriginGroups { get; private set; } = null!;

        /// <summary>
        /// One or more origins for this
        /// distribution (multiples allowed).
        /// </summary>
        [Output("origins")]
        public Output<ImmutableArray<Outputs.DistributionOrigin>> Origins { get; private set; } = null!;

        /// <summary>
        /// The price class for this distribution. One of
        /// `PriceClass_All`, `PriceClass_200`, `PriceClass_100`
        /// </summary>
        [Output("priceClass")]
        public Output<string?> PriceClass { get; private set; } = null!;

        /// <summary>
        /// The restriction
        /// configuration for this distribution (maximum one).
        /// </summary>
        [Output("restrictions")]
        public Output<Outputs.DistributionRestrictions> Restrictions { get; private set; } = null!;

        /// <summary>
        /// Disables the distribution instead of
        /// deleting it when destroying the resource. If this is set,
        /// the distribution needs to be deleted manually afterwards. Default: `false`.
        /// </summary>
        [Output("retainOnDelete")]
        public Output<bool?> RetainOnDelete { get; private set; } = null!;

        /// <summary>
        /// The current status of the distribution. `Deployed` if the
        /// distribution's information is fully propagated throughout the Amazon
        /// CloudFront system.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The SSL
        /// configuration for this distribution (maximum
        /// one).
        /// </summary>
        [Output("viewerCertificate")]
        public Output<Outputs.DistributionViewerCertificate> ViewerCertificate { get; private set; } = null!;

        /// <summary>
        /// If enabled, the resource will wait for
        /// the distribution status to change from `InProgress` to `Deployed`. Setting
        /// this to`false` will skip the process. Default: `true`.
        /// </summary>
        [Output("waitForDeployment")]
        public Output<bool?> WaitForDeployment { get; private set; } = null!;

        /// <summary>
        /// If you're using AWS WAF to filter CloudFront
        /// requests, the Id of the AWS WAF web ACL that is associated with the
        /// distribution. The WAF Web ACL must exist in the WAF Global (CloudFront)
        /// region and the credentials configuring this argument must have
        /// `waf:GetWebACL` permissions assigned.
        /// </summary>
        [Output("webAclId")]
        public Output<string?> WebAclId { get; private set; } = null!;


        /// <summary>
        /// Create a Distribution resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Distribution(string name, DistributionArgs args, CustomResourceOptions? options = null)
            : base("aws:cloudfront/distribution:Distribution", name, args ?? new DistributionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Distribution(string name, Input<string> id, DistributionState? state = null, CustomResourceOptions? options = null)
            : base("aws:cloudfront/distribution:Distribution", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Distribution resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Distribution Get(string name, Input<string> id, DistributionState? state = null, CustomResourceOptions? options = null)
        {
            return new Distribution(name, id, state, options);
        }
    }

    public sealed class DistributionArgs : Pulumi.ResourceArgs
    {
        [Input("aliases")]
        private InputList<string>? _aliases;

        /// <summary>
        /// Extra CNAMEs (alternate domain names), if any, for
        /// this distribution.
        /// </summary>
        public InputList<string> Aliases
        {
            get => _aliases ?? (_aliases = new InputList<string>());
            set => _aliases = value;
        }

        /// <summary>
        /// Any comments you want to include about the
        /// distribution.
        /// </summary>
        [Input("comment")]
        public Input<string>? Comment { get; set; }

        [Input("customErrorResponses")]
        private InputList<Inputs.DistributionCustomErrorResponseArgs>? _customErrorResponses;

        /// <summary>
        /// One or more custom error response elements (multiples allowed).
        /// </summary>
        public InputList<Inputs.DistributionCustomErrorResponseArgs> CustomErrorResponses
        {
            get => _customErrorResponses ?? (_customErrorResponses = new InputList<Inputs.DistributionCustomErrorResponseArgs>());
            set => _customErrorResponses = value;
        }

        /// <summary>
        /// The default cache behavior for this distribution (maximum
        /// one).
        /// </summary>
        [Input("defaultCacheBehavior", required: true)]
        public Input<Inputs.DistributionDefaultCacheBehaviorArgs> DefaultCacheBehavior { get; set; } = null!;

        /// <summary>
        /// The object that you want CloudFront to
        /// return (for example, index.html) when an end user requests the root URL.
        /// </summary>
        [Input("defaultRootObject")]
        public Input<string>? DefaultRootObject { get; set; }

        /// <summary>
        /// Whether the distribution is enabled to accept end
        /// user requests for content.
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// The maximum HTTP version to support on the
        /// distribution. Allowed values are `http1.1` and `http2`. The default is
        /// `http2`.
        /// </summary>
        [Input("httpVersion")]
        public Input<string>? HttpVersion { get; set; }

        /// <summary>
        /// Whether the IPv6 is enabled for the distribution.
        /// </summary>
        [Input("isIpv6Enabled")]
        public Input<bool>? IsIpv6Enabled { get; set; }

        /// <summary>
        /// The logging
        /// configuration that controls how logs are written
        /// to your distribution (maximum one).
        /// </summary>
        [Input("loggingConfig")]
        public Input<Inputs.DistributionLoggingConfigArgs>? LoggingConfig { get; set; }

        [Input("orderedCacheBehaviors")]
        private InputList<Inputs.DistributionOrderedCacheBehaviorArgs>? _orderedCacheBehaviors;

        /// <summary>
        /// An ordered list of cache behaviors
        /// resource for this distribution. List from top to bottom
        /// in order of precedence. The topmost cache behavior will have precedence 0.
        /// </summary>
        public InputList<Inputs.DistributionOrderedCacheBehaviorArgs> OrderedCacheBehaviors
        {
            get => _orderedCacheBehaviors ?? (_orderedCacheBehaviors = new InputList<Inputs.DistributionOrderedCacheBehaviorArgs>());
            set => _orderedCacheBehaviors = value;
        }

        [Input("originGroups")]
        private InputList<Inputs.DistributionOriginGroupArgs>? _originGroups;

        /// <summary>
        /// One or more origin_group for this
        /// distribution (multiples allowed).
        /// </summary>
        public InputList<Inputs.DistributionOriginGroupArgs> OriginGroups
        {
            get => _originGroups ?? (_originGroups = new InputList<Inputs.DistributionOriginGroupArgs>());
            set => _originGroups = value;
        }

        [Input("origins", required: true)]
        private InputList<Inputs.DistributionOriginArgs>? _origins;

        /// <summary>
        /// One or more origins for this
        /// distribution (multiples allowed).
        /// </summary>
        public InputList<Inputs.DistributionOriginArgs> Origins
        {
            get => _origins ?? (_origins = new InputList<Inputs.DistributionOriginArgs>());
            set => _origins = value;
        }

        /// <summary>
        /// The price class for this distribution. One of
        /// `PriceClass_All`, `PriceClass_200`, `PriceClass_100`
        /// </summary>
        [Input("priceClass")]
        public Input<string>? PriceClass { get; set; }

        /// <summary>
        /// The restriction
        /// configuration for this distribution (maximum one).
        /// </summary>
        [Input("restrictions", required: true)]
        public Input<Inputs.DistributionRestrictionsArgs> Restrictions { get; set; } = null!;

        /// <summary>
        /// Disables the distribution instead of
        /// deleting it when destroying the resource. If this is set,
        /// the distribution needs to be deleted manually afterwards. Default: `false`.
        /// </summary>
        [Input("retainOnDelete")]
        public Input<bool>? RetainOnDelete { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// The SSL
        /// configuration for this distribution (maximum
        /// one).
        /// </summary>
        [Input("viewerCertificate", required: true)]
        public Input<Inputs.DistributionViewerCertificateArgs> ViewerCertificate { get; set; } = null!;

        /// <summary>
        /// If enabled, the resource will wait for
        /// the distribution status to change from `InProgress` to `Deployed`. Setting
        /// this to`false` will skip the process. Default: `true`.
        /// </summary>
        [Input("waitForDeployment")]
        public Input<bool>? WaitForDeployment { get; set; }

        /// <summary>
        /// If you're using AWS WAF to filter CloudFront
        /// requests, the Id of the AWS WAF web ACL that is associated with the
        /// distribution. The WAF Web ACL must exist in the WAF Global (CloudFront)
        /// region and the credentials configuring this argument must have
        /// `waf:GetWebACL` permissions assigned.
        /// </summary>
        [Input("webAclId")]
        public Input<string>? WebAclId { get; set; }

        public DistributionArgs()
        {
        }
    }

    public sealed class DistributionState : Pulumi.ResourceArgs
    {
        [Input("activeTrustedSigners")]
        private InputMap<object>? _activeTrustedSigners;

        /// <summary>
        /// The key pair IDs that CloudFront is aware of for
        /// each trusted signer, if the distribution is set up to serve private content
        /// with signed URLs.
        /// </summary>
        public InputMap<object> ActiveTrustedSigners
        {
            get => _activeTrustedSigners ?? (_activeTrustedSigners = new InputMap<object>());
            set => _activeTrustedSigners = value;
        }

        [Input("aliases")]
        private InputList<string>? _aliases;

        /// <summary>
        /// Extra CNAMEs (alternate domain names), if any, for
        /// this distribution.
        /// </summary>
        public InputList<string> Aliases
        {
            get => _aliases ?? (_aliases = new InputList<string>());
            set => _aliases = value;
        }

        /// <summary>
        /// The ARN (Amazon Resource Name) for the distribution. For example: `arn:aws:cloudfront::123456789012:distribution/EDFDVBD632BHDS5`, where `123456789012` is your AWS account ID.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// Internal value used by CloudFront to allow future
        /// updates to the distribution configuration.
        /// </summary>
        [Input("callerReference")]
        public Input<string>? CallerReference { get; set; }

        /// <summary>
        /// Any comments you want to include about the
        /// distribution.
        /// </summary>
        [Input("comment")]
        public Input<string>? Comment { get; set; }

        [Input("customErrorResponses")]
        private InputList<Inputs.DistributionCustomErrorResponseGetArgs>? _customErrorResponses;

        /// <summary>
        /// One or more custom error response elements (multiples allowed).
        /// </summary>
        public InputList<Inputs.DistributionCustomErrorResponseGetArgs> CustomErrorResponses
        {
            get => _customErrorResponses ?? (_customErrorResponses = new InputList<Inputs.DistributionCustomErrorResponseGetArgs>());
            set => _customErrorResponses = value;
        }

        /// <summary>
        /// The default cache behavior for this distribution (maximum
        /// one).
        /// </summary>
        [Input("defaultCacheBehavior")]
        public Input<Inputs.DistributionDefaultCacheBehaviorGetArgs>? DefaultCacheBehavior { get; set; }

        /// <summary>
        /// The object that you want CloudFront to
        /// return (for example, index.html) when an end user requests the root URL.
        /// </summary>
        [Input("defaultRootObject")]
        public Input<string>? DefaultRootObject { get; set; }

        /// <summary>
        /// The DNS domain name of either the S3 bucket, or
        /// web site of your custom origin.
        /// </summary>
        [Input("domainName")]
        public Input<string>? DomainName { get; set; }

        /// <summary>
        /// Whether the distribution is enabled to accept end
        /// user requests for content.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The current version of the distribution's information. For example:
        /// `E2QWRUHAPOMQZL`.
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        /// <summary>
        /// The CloudFront Route 53 zone ID that can be used to
        /// route an [Alias Resource Record Set](http://docs.aws.amazon.com/Route53/latest/APIReference/CreateAliasRRSAPI.html) to. This attribute is simply an
        /// alias for the zone ID `Z2FDTNDATAQYW2`.
        /// </summary>
        [Input("hostedZoneId")]
        public Input<string>? HostedZoneId { get; set; }

        /// <summary>
        /// The maximum HTTP version to support on the
        /// distribution. Allowed values are `http1.1` and `http2`. The default is
        /// `http2`.
        /// </summary>
        [Input("httpVersion")]
        public Input<string>? HttpVersion { get; set; }

        /// <summary>
        /// The number of invalidation batches
        /// currently in progress.
        /// </summary>
        [Input("inProgressValidationBatches")]
        public Input<int>? InProgressValidationBatches { get; set; }

        /// <summary>
        /// Whether the IPv6 is enabled for the distribution.
        /// </summary>
        [Input("isIpv6Enabled")]
        public Input<bool>? IsIpv6Enabled { get; set; }

        /// <summary>
        /// The date and time the distribution was last modified.
        /// </summary>
        [Input("lastModifiedTime")]
        public Input<string>? LastModifiedTime { get; set; }

        /// <summary>
        /// The logging
        /// configuration that controls how logs are written
        /// to your distribution (maximum one).
        /// </summary>
        [Input("loggingConfig")]
        public Input<Inputs.DistributionLoggingConfigGetArgs>? LoggingConfig { get; set; }

        [Input("orderedCacheBehaviors")]
        private InputList<Inputs.DistributionOrderedCacheBehaviorGetArgs>? _orderedCacheBehaviors;

        /// <summary>
        /// An ordered list of cache behaviors
        /// resource for this distribution. List from top to bottom
        /// in order of precedence. The topmost cache behavior will have precedence 0.
        /// </summary>
        public InputList<Inputs.DistributionOrderedCacheBehaviorGetArgs> OrderedCacheBehaviors
        {
            get => _orderedCacheBehaviors ?? (_orderedCacheBehaviors = new InputList<Inputs.DistributionOrderedCacheBehaviorGetArgs>());
            set => _orderedCacheBehaviors = value;
        }

        [Input("originGroups")]
        private InputList<Inputs.DistributionOriginGroupGetArgs>? _originGroups;

        /// <summary>
        /// One or more origin_group for this
        /// distribution (multiples allowed).
        /// </summary>
        public InputList<Inputs.DistributionOriginGroupGetArgs> OriginGroups
        {
            get => _originGroups ?? (_originGroups = new InputList<Inputs.DistributionOriginGroupGetArgs>());
            set => _originGroups = value;
        }

        [Input("origins")]
        private InputList<Inputs.DistributionOriginGetArgs>? _origins;

        /// <summary>
        /// One or more origins for this
        /// distribution (multiples allowed).
        /// </summary>
        public InputList<Inputs.DistributionOriginGetArgs> Origins
        {
            get => _origins ?? (_origins = new InputList<Inputs.DistributionOriginGetArgs>());
            set => _origins = value;
        }

        /// <summary>
        /// The price class for this distribution. One of
        /// `PriceClass_All`, `PriceClass_200`, `PriceClass_100`
        /// </summary>
        [Input("priceClass")]
        public Input<string>? PriceClass { get; set; }

        /// <summary>
        /// The restriction
        /// configuration for this distribution (maximum one).
        /// </summary>
        [Input("restrictions")]
        public Input<Inputs.DistributionRestrictionsGetArgs>? Restrictions { get; set; }

        /// <summary>
        /// Disables the distribution instead of
        /// deleting it when destroying the resource. If this is set,
        /// the distribution needs to be deleted manually afterwards. Default: `false`.
        /// </summary>
        [Input("retainOnDelete")]
        public Input<bool>? RetainOnDelete { get; set; }

        /// <summary>
        /// The current status of the distribution. `Deployed` if the
        /// distribution's information is fully propagated throughout the Amazon
        /// CloudFront system.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// The SSL
        /// configuration for this distribution (maximum
        /// one).
        /// </summary>
        [Input("viewerCertificate")]
        public Input<Inputs.DistributionViewerCertificateGetArgs>? ViewerCertificate { get; set; }

        /// <summary>
        /// If enabled, the resource will wait for
        /// the distribution status to change from `InProgress` to `Deployed`. Setting
        /// this to`false` will skip the process. Default: `true`.
        /// </summary>
        [Input("waitForDeployment")]
        public Input<bool>? WaitForDeployment { get; set; }

        /// <summary>
        /// If you're using AWS WAF to filter CloudFront
        /// requests, the Id of the AWS WAF web ACL that is associated with the
        /// distribution. The WAF Web ACL must exist in the WAF Global (CloudFront)
        /// region and the credentials configuring this argument must have
        /// `waf:GetWebACL` permissions assigned.
        /// </summary>
        [Input("webAclId")]
        public Input<string>? WebAclId { get; set; }

        public DistributionState()
        {
        }
    }
}
