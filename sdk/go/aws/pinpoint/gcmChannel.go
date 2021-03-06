// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package pinpoint

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Pinpoint GCM Channel resource.
//
// > **Note:** Api Key argument will be stored in the raw state as plain-text.
// [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
type GcmChannel struct {
	pulumi.CustomResourceState

	// Platform credential API key from Google.
	ApiKey pulumi.StringOutput `pulumi:"apiKey"`
	// The application ID.
	ApplicationId pulumi.StringOutput `pulumi:"applicationId"`
	// Whether the channel is enabled or disabled. Defaults to `true`.
	Enabled pulumi.BoolPtrOutput `pulumi:"enabled"`
}

// NewGcmChannel registers a new resource with the given unique name, arguments, and options.
func NewGcmChannel(ctx *pulumi.Context,
	name string, args *GcmChannelArgs, opts ...pulumi.ResourceOption) (*GcmChannel, error) {
	if args == nil || args.ApiKey == nil {
		return nil, errors.New("missing required argument 'ApiKey'")
	}
	if args == nil || args.ApplicationId == nil {
		return nil, errors.New("missing required argument 'ApplicationId'")
	}
	if args == nil {
		args = &GcmChannelArgs{}
	}
	var resource GcmChannel
	err := ctx.RegisterResource("aws:pinpoint/gcmChannel:GcmChannel", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGcmChannel gets an existing GcmChannel resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGcmChannel(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GcmChannelState, opts ...pulumi.ResourceOption) (*GcmChannel, error) {
	var resource GcmChannel
	err := ctx.ReadResource("aws:pinpoint/gcmChannel:GcmChannel", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering GcmChannel resources.
type gcmChannelState struct {
	// Platform credential API key from Google.
	ApiKey *string `pulumi:"apiKey"`
	// The application ID.
	ApplicationId *string `pulumi:"applicationId"`
	// Whether the channel is enabled or disabled. Defaults to `true`.
	Enabled *bool `pulumi:"enabled"`
}

type GcmChannelState struct {
	// Platform credential API key from Google.
	ApiKey pulumi.StringPtrInput
	// The application ID.
	ApplicationId pulumi.StringPtrInput
	// Whether the channel is enabled or disabled. Defaults to `true`.
	Enabled pulumi.BoolPtrInput
}

func (GcmChannelState) ElementType() reflect.Type {
	return reflect.TypeOf((*gcmChannelState)(nil)).Elem()
}

type gcmChannelArgs struct {
	// Platform credential API key from Google.
	ApiKey string `pulumi:"apiKey"`
	// The application ID.
	ApplicationId string `pulumi:"applicationId"`
	// Whether the channel is enabled or disabled. Defaults to `true`.
	Enabled *bool `pulumi:"enabled"`
}

// The set of arguments for constructing a GcmChannel resource.
type GcmChannelArgs struct {
	// Platform credential API key from Google.
	ApiKey pulumi.StringInput
	// The application ID.
	ApplicationId pulumi.StringInput
	// Whether the channel is enabled or disabled. Defaults to `true`.
	Enabled pulumi.BoolPtrInput
}

func (GcmChannelArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*gcmChannelArgs)(nil)).Elem()
}
