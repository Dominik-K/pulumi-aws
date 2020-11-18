// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Cognito.Inputs
{

    public sealed class IdentityPoolRoleAttachmentRoleMappingGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the action to be taken if either no rules match the claim value for the Rules type, or there is no cognito:preferred_role claim and there are multiple cognito:roles matches for the Token type. `Required` if you specify Token or Rules as the Type.
        /// </summary>
        [Input("ambiguousRoleResolution")]
        public Input<string>? AmbiguousRoleResolution { get; set; }

        /// <summary>
        /// A string identifying the identity provider, for example, "graph.facebook.com" or "cognito-idp.us-east-1.amazonaws.com/us-east-1_abcdefghi:app_client_id".
        /// </summary>
        [Input("identityProvider", required: true)]
        public Input<string> IdentityProvider { get; set; } = null!;

        [Input("mappingRules")]
        private InputList<Inputs.IdentityPoolRoleAttachmentRoleMappingMappingRuleGetArgs>? _mappingRules;

        /// <summary>
        /// The Rules Configuration to be used for mapping users to roles. You can specify up to 25 rules per identity provider. Rules are evaluated in order. The first one to match specifies the role.
        /// </summary>
        public InputList<Inputs.IdentityPoolRoleAttachmentRoleMappingMappingRuleGetArgs> MappingRules
        {
            get => _mappingRules ?? (_mappingRules = new InputList<Inputs.IdentityPoolRoleAttachmentRoleMappingMappingRuleGetArgs>());
            set => _mappingRules = value;
        }

        /// <summary>
        /// The role mapping type.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public IdentityPoolRoleAttachmentRoleMappingGetArgs()
        {
        }
    }
}
