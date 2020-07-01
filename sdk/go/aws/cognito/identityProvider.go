// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package cognito

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Cognito User Identity Provider resource.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/cognito"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		example, err := cognito.NewUserPool(ctx, "example", &cognito.UserPoolArgs{
// 			AutoVerifiedAttributes: pulumi.StringArray{
// 				pulumi.String("email"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = cognito.NewIdentityProvider(ctx, "exampleProvider", &cognito.IdentityProviderArgs{
// 			AttributeMapping: pulumi.StringMap{
// 				"email":    pulumi.String("email"),
// 				"username": pulumi.String("sub"),
// 			},
// 			ProviderDetails: pulumi.StringMap{
// 				"authorize_scopes": pulumi.String("email"),
// 				"client_id":        pulumi.String("your client_id"),
// 				"client_secret":    pulumi.String("your client_secret"),
// 			},
// 			ProviderName: pulumi.String("Google"),
// 			ProviderType: pulumi.String("Google"),
// 			UserPoolId:   example.ID(),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type IdentityProvider struct {
	pulumi.CustomResourceState

	// The map of attribute mapping of user pool attributes. [AttributeMapping in AWS API documentation](https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateIdentityProvider.html#CognitoUserPools-CreateIdentityProvider-request-AttributeMapping)
	AttributeMapping pulumi.StringMapOutput `pulumi:"attributeMapping"`
	// The list of identity providers.
	IdpIdentifiers pulumi.StringArrayOutput `pulumi:"idpIdentifiers"`
	// The map of identity details, such as access token
	ProviderDetails pulumi.StringMapOutput `pulumi:"providerDetails"`
	// The provider name
	ProviderName pulumi.StringOutput `pulumi:"providerName"`
	// The provider type.  [See AWS API for valid values](https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateIdentityProvider.html#CognitoUserPools-CreateIdentityProvider-request-ProviderType)
	ProviderType pulumi.StringOutput `pulumi:"providerType"`
	// The user pool id
	UserPoolId pulumi.StringOutput `pulumi:"userPoolId"`
}

// NewIdentityProvider registers a new resource with the given unique name, arguments, and options.
func NewIdentityProvider(ctx *pulumi.Context,
	name string, args *IdentityProviderArgs, opts ...pulumi.ResourceOption) (*IdentityProvider, error) {
	if args == nil || args.ProviderDetails == nil {
		return nil, errors.New("missing required argument 'ProviderDetails'")
	}
	if args == nil || args.ProviderName == nil {
		return nil, errors.New("missing required argument 'ProviderName'")
	}
	if args == nil || args.ProviderType == nil {
		return nil, errors.New("missing required argument 'ProviderType'")
	}
	if args == nil || args.UserPoolId == nil {
		return nil, errors.New("missing required argument 'UserPoolId'")
	}
	if args == nil {
		args = &IdentityProviderArgs{}
	}
	var resource IdentityProvider
	err := ctx.RegisterResource("aws:cognito/identityProvider:IdentityProvider", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIdentityProvider gets an existing IdentityProvider resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIdentityProvider(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IdentityProviderState, opts ...pulumi.ResourceOption) (*IdentityProvider, error) {
	var resource IdentityProvider
	err := ctx.ReadResource("aws:cognito/identityProvider:IdentityProvider", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering IdentityProvider resources.
type identityProviderState struct {
	// The map of attribute mapping of user pool attributes. [AttributeMapping in AWS API documentation](https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateIdentityProvider.html#CognitoUserPools-CreateIdentityProvider-request-AttributeMapping)
	AttributeMapping map[string]string `pulumi:"attributeMapping"`
	// The list of identity providers.
	IdpIdentifiers []string `pulumi:"idpIdentifiers"`
	// The map of identity details, such as access token
	ProviderDetails map[string]string `pulumi:"providerDetails"`
	// The provider name
	ProviderName *string `pulumi:"providerName"`
	// The provider type.  [See AWS API for valid values](https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateIdentityProvider.html#CognitoUserPools-CreateIdentityProvider-request-ProviderType)
	ProviderType *string `pulumi:"providerType"`
	// The user pool id
	UserPoolId *string `pulumi:"userPoolId"`
}

type IdentityProviderState struct {
	// The map of attribute mapping of user pool attributes. [AttributeMapping in AWS API documentation](https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateIdentityProvider.html#CognitoUserPools-CreateIdentityProvider-request-AttributeMapping)
	AttributeMapping pulumi.StringMapInput
	// The list of identity providers.
	IdpIdentifiers pulumi.StringArrayInput
	// The map of identity details, such as access token
	ProviderDetails pulumi.StringMapInput
	// The provider name
	ProviderName pulumi.StringPtrInput
	// The provider type.  [See AWS API for valid values](https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateIdentityProvider.html#CognitoUserPools-CreateIdentityProvider-request-ProviderType)
	ProviderType pulumi.StringPtrInput
	// The user pool id
	UserPoolId pulumi.StringPtrInput
}

func (IdentityProviderState) ElementType() reflect.Type {
	return reflect.TypeOf((*identityProviderState)(nil)).Elem()
}

type identityProviderArgs struct {
	// The map of attribute mapping of user pool attributes. [AttributeMapping in AWS API documentation](https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateIdentityProvider.html#CognitoUserPools-CreateIdentityProvider-request-AttributeMapping)
	AttributeMapping map[string]string `pulumi:"attributeMapping"`
	// The list of identity providers.
	IdpIdentifiers []string `pulumi:"idpIdentifiers"`
	// The map of identity details, such as access token
	ProviderDetails map[string]string `pulumi:"providerDetails"`
	// The provider name
	ProviderName string `pulumi:"providerName"`
	// The provider type.  [See AWS API for valid values](https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateIdentityProvider.html#CognitoUserPools-CreateIdentityProvider-request-ProviderType)
	ProviderType string `pulumi:"providerType"`
	// The user pool id
	UserPoolId string `pulumi:"userPoolId"`
}

// The set of arguments for constructing a IdentityProvider resource.
type IdentityProviderArgs struct {
	// The map of attribute mapping of user pool attributes. [AttributeMapping in AWS API documentation](https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateIdentityProvider.html#CognitoUserPools-CreateIdentityProvider-request-AttributeMapping)
	AttributeMapping pulumi.StringMapInput
	// The list of identity providers.
	IdpIdentifiers pulumi.StringArrayInput
	// The map of identity details, such as access token
	ProviderDetails pulumi.StringMapInput
	// The provider name
	ProviderName pulumi.StringInput
	// The provider type.  [See AWS API for valid values](https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateIdentityProvider.html#CognitoUserPools-CreateIdentityProvider-request-ProviderType)
	ProviderType pulumi.StringInput
	// The user pool id
	UserPoolId pulumi.StringInput
}

func (IdentityProviderArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*identityProviderArgs)(nil)).Elem()
}
