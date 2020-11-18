// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.WafV2
{
    /// <summary>
    /// Creates a WAFv2 Rule Group resource.
    /// 
    /// ## Example Usage
    /// ### Simple
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var example = new Aws.WafV2.RuleGroup("example", new Aws.WafV2.RuleGroupArgs
    ///         {
    ///             Capacity = 2,
    ///             Rules = 
    ///             {
    ///                 new Aws.WafV2.Inputs.RuleGroupRuleArgs
    ///                 {
    ///                     Action = new Aws.WafV2.Inputs.RuleGroupRuleActionArgs
    ///                     {
    ///                         Allow = ,
    ///                     },
    ///                     Name = "rule-1",
    ///                     Priority = 1,
    ///                     Statement = new Aws.WafV2.Inputs.RuleGroupRuleStatementArgs
    ///                     {
    ///                         GeoMatchStatement = new Aws.WafV2.Inputs.RuleGroupRuleStatementGeoMatchStatementArgs
    ///                         {
    ///                             CountryCodes = 
    ///                             {
    ///                                 "US",
    ///                                 "NL",
    ///                             },
    ///                         },
    ///                     },
    ///                     VisibilityConfig = new Aws.WafV2.Inputs.RuleGroupRuleVisibilityConfigArgs
    ///                     {
    ///                         CloudwatchMetricsEnabled = false,
    ///                         MetricName = "friendly-rule-metric-name",
    ///                         SampledRequestsEnabled = false,
    ///                     },
    ///                 },
    ///             },
    ///             Scope = "REGIONAL",
    ///             VisibilityConfig = new Aws.WafV2.Inputs.RuleGroupVisibilityConfigArgs
    ///             {
    ///                 CloudwatchMetricsEnabled = false,
    ///                 MetricName = "friendly-metric-name",
    ///                 SampledRequestsEnabled = false,
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class RuleGroup : Pulumi.CustomResource
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) of the IP Set that this statement references.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// The web ACL capacity units (WCUs) required for this rule group. See [here](https://docs.aws.amazon.com/waf/latest/APIReference/API_CreateRuleGroup.html#API_CreateRuleGroup_RequestSyntax) for general information and [here](https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statements-list.html) for capacity specific information.
        /// </summary>
        [Output("capacity")]
        public Output<int> Capacity { get; private set; } = null!;

        /// <summary>
        /// A friendly description of the rule group.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("lockToken")]
        public Output<string> LockToken { get; private set; } = null!;

        /// <summary>
        /// A friendly name of the rule group.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The rule blocks used to identify the web requests that you want to `allow`, `block`, or `count`. See Rules below for details.
        /// </summary>
        [Output("rules")]
        public Output<ImmutableArray<Outputs.RuleGroupRule>> Rules { get; private set; } = null!;

        /// <summary>
        /// Specifies whether this is for an AWS CloudFront distribution or for a regional application. Valid values are `CLOUDFRONT` or `REGIONAL`. To work with CloudFront, you must also specify the region `us-east-1` (N. Virginia) on the AWS provider.
        /// </summary>
        [Output("scope")]
        public Output<string> Scope { get; private set; } = null!;

        /// <summary>
        /// An array of key:value pairs to associate with the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Defines and enables Amazon CloudWatch metrics and web request sample collection. See Visibility Configuration below for details.
        /// </summary>
        [Output("visibilityConfig")]
        public Output<Outputs.RuleGroupVisibilityConfig> VisibilityConfig { get; private set; } = null!;


        /// <summary>
        /// Create a RuleGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RuleGroup(string name, RuleGroupArgs args, CustomResourceOptions? options = null)
            : base("aws:wafv2/ruleGroup:RuleGroup", name, args ?? new RuleGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private RuleGroup(string name, Input<string> id, RuleGroupState? state = null, CustomResourceOptions? options = null)
            : base("aws:wafv2/ruleGroup:RuleGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing RuleGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RuleGroup Get(string name, Input<string> id, RuleGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new RuleGroup(name, id, state, options);
        }
    }

    public sealed class RuleGroupArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The web ACL capacity units (WCUs) required for this rule group. See [here](https://docs.aws.amazon.com/waf/latest/APIReference/API_CreateRuleGroup.html#API_CreateRuleGroup_RequestSyntax) for general information and [here](https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statements-list.html) for capacity specific information.
        /// </summary>
        [Input("capacity", required: true)]
        public Input<int> Capacity { get; set; } = null!;

        /// <summary>
        /// A friendly description of the rule group.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// A friendly name of the rule group.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("rules")]
        private InputList<Inputs.RuleGroupRuleArgs>? _rules;

        /// <summary>
        /// The rule blocks used to identify the web requests that you want to `allow`, `block`, or `count`. See Rules below for details.
        /// </summary>
        public InputList<Inputs.RuleGroupRuleArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.RuleGroupRuleArgs>());
            set => _rules = value;
        }

        /// <summary>
        /// Specifies whether this is for an AWS CloudFront distribution or for a regional application. Valid values are `CLOUDFRONT` or `REGIONAL`. To work with CloudFront, you must also specify the region `us-east-1` (N. Virginia) on the AWS provider.
        /// </summary>
        [Input("scope", required: true)]
        public Input<string> Scope { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// An array of key:value pairs to associate with the resource.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Defines and enables Amazon CloudWatch metrics and web request sample collection. See Visibility Configuration below for details.
        /// </summary>
        [Input("visibilityConfig", required: true)]
        public Input<Inputs.RuleGroupVisibilityConfigArgs> VisibilityConfig { get; set; } = null!;

        public RuleGroupArgs()
        {
        }
    }

    public sealed class RuleGroupState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) of the IP Set that this statement references.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// The web ACL capacity units (WCUs) required for this rule group. See [here](https://docs.aws.amazon.com/waf/latest/APIReference/API_CreateRuleGroup.html#API_CreateRuleGroup_RequestSyntax) for general information and [here](https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statements-list.html) for capacity specific information.
        /// </summary>
        [Input("capacity")]
        public Input<int>? Capacity { get; set; }

        /// <summary>
        /// A friendly description of the rule group.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("lockToken")]
        public Input<string>? LockToken { get; set; }

        /// <summary>
        /// A friendly name of the rule group.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("rules")]
        private InputList<Inputs.RuleGroupRuleGetArgs>? _rules;

        /// <summary>
        /// The rule blocks used to identify the web requests that you want to `allow`, `block`, or `count`. See Rules below for details.
        /// </summary>
        public InputList<Inputs.RuleGroupRuleGetArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.RuleGroupRuleGetArgs>());
            set => _rules = value;
        }

        /// <summary>
        /// Specifies whether this is for an AWS CloudFront distribution or for a regional application. Valid values are `CLOUDFRONT` or `REGIONAL`. To work with CloudFront, you must also specify the region `us-east-1` (N. Virginia) on the AWS provider.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// An array of key:value pairs to associate with the resource.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Defines and enables Amazon CloudWatch metrics and web request sample collection. See Visibility Configuration below for details.
        /// </summary>
        [Input("visibilityConfig")]
        public Input<Inputs.RuleGroupVisibilityConfigGetArgs>? VisibilityConfig { get; set; }

        public RuleGroupState()
        {
        }
    }
}
