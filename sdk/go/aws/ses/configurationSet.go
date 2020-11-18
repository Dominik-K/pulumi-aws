// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ses

import (
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides an SES configuration set resource
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/ses"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := ses.NewConfigurationSet(ctx, "test", nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type ConfigurationSet struct {
	pulumi.CustomResourceState

	// The name of the configuration set
	Name pulumi.StringOutput `pulumi:"name"`
}

// NewConfigurationSet registers a new resource with the given unique name, arguments, and options.
func NewConfigurationSet(ctx *pulumi.Context,
	name string, args *ConfigurationSetArgs, opts ...pulumi.ResourceOption) (*ConfigurationSet, error) {
	if args == nil {
		args = &ConfigurationSetArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("aws:ses/confgurationSet:ConfgurationSet"),
		},
	})
	opts = append(opts, aliases)
	var resource ConfigurationSet
	err := ctx.RegisterResource("aws:ses/configurationSet:ConfigurationSet", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetConfigurationSet gets an existing ConfigurationSet resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetConfigurationSet(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ConfigurationSetState, opts ...pulumi.ResourceOption) (*ConfigurationSet, error) {
	var resource ConfigurationSet
	err := ctx.ReadResource("aws:ses/configurationSet:ConfigurationSet", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ConfigurationSet resources.
type configurationSetState struct {
	// The name of the configuration set
	Name *string `pulumi:"name"`
}

type ConfigurationSetState struct {
	// The name of the configuration set
	Name pulumi.StringPtrInput
}

func (ConfigurationSetState) ElementType() reflect.Type {
	return reflect.TypeOf((*configurationSetState)(nil)).Elem()
}

type configurationSetArgs struct {
	// The name of the configuration set
	Name *string `pulumi:"name"`
}

// The set of arguments for constructing a ConfigurationSet resource.
type ConfigurationSetArgs struct {
	// The name of the configuration set
	Name pulumi.StringPtrInput
}

func (ConfigurationSetArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*configurationSetArgs)(nil)).Elem()
}
