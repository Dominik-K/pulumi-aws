// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package mq

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides an MQ Configuration Resource.
//
// For more information on Amazon MQ, see [Amazon MQ documentation](https://docs.aws.amazon.com/amazon-mq/latest/developer-guide/welcome.html).
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"fmt"
//
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/mq"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := mq.NewConfiguration(ctx, "example", &mq.ConfigurationArgs{
// 			Data:          pulumi.String(fmt.Sprintf("%v%v%v%v%v%v%v%v%v", "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>\n", "<broker xmlns=\"http://activemq.apache.org/schema/core\">\n", "  <plugins>\n", "    <forcePersistencyModeBrokerPlugin persistenceFlag=\"true\"/>\n", "    <statisticsBrokerPlugin/>\n", "    <timeStampingBrokerPlugin ttlCeiling=\"86400000\" zeroExpirationOverride=\"86400000\"/>\n", "  </plugins>\n", "</broker>\n", "\n")),
// 			Description:   pulumi.String("Example Configuration"),
// 			EngineType:    pulumi.String("ActiveMQ"),
// 			EngineVersion: pulumi.String("5.15.0"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type Configuration struct {
	pulumi.CustomResourceState

	// The ARN of the configuration.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// The broker configuration in XML format.
	// See [official docs](https://docs.aws.amazon.com/amazon-mq/latest/developer-guide/amazon-mq-broker-configuration-parameters.html)
	// for supported parameters and format of the XML.
	Data pulumi.StringOutput `pulumi:"data"`
	// The description of the configuration.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The type of broker engine.
	EngineType pulumi.StringOutput `pulumi:"engineType"`
	// The version of the broker engine.
	EngineVersion pulumi.StringOutput `pulumi:"engineVersion"`
	// The latest revision of the configuration.
	LatestRevision pulumi.IntOutput `pulumi:"latestRevision"`
	// The name of the configuration
	Name pulumi.StringOutput `pulumi:"name"`
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
}

// NewConfiguration registers a new resource with the given unique name, arguments, and options.
func NewConfiguration(ctx *pulumi.Context,
	name string, args *ConfigurationArgs, opts ...pulumi.ResourceOption) (*Configuration, error) {
	if args == nil || args.Data == nil {
		return nil, errors.New("missing required argument 'Data'")
	}
	if args == nil || args.EngineType == nil {
		return nil, errors.New("missing required argument 'EngineType'")
	}
	if args == nil || args.EngineVersion == nil {
		return nil, errors.New("missing required argument 'EngineVersion'")
	}
	if args == nil {
		args = &ConfigurationArgs{}
	}
	var resource Configuration
	err := ctx.RegisterResource("aws:mq/configuration:Configuration", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetConfiguration gets an existing Configuration resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetConfiguration(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ConfigurationState, opts ...pulumi.ResourceOption) (*Configuration, error) {
	var resource Configuration
	err := ctx.ReadResource("aws:mq/configuration:Configuration", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Configuration resources.
type configurationState struct {
	// The ARN of the configuration.
	Arn *string `pulumi:"arn"`
	// The broker configuration in XML format.
	// See [official docs](https://docs.aws.amazon.com/amazon-mq/latest/developer-guide/amazon-mq-broker-configuration-parameters.html)
	// for supported parameters and format of the XML.
	Data *string `pulumi:"data"`
	// The description of the configuration.
	Description *string `pulumi:"description"`
	// The type of broker engine.
	EngineType *string `pulumi:"engineType"`
	// The version of the broker engine.
	EngineVersion *string `pulumi:"engineVersion"`
	// The latest revision of the configuration.
	LatestRevision *int `pulumi:"latestRevision"`
	// The name of the configuration
	Name *string `pulumi:"name"`
	// A map of tags to assign to the resource.
	Tags map[string]string `pulumi:"tags"`
}

type ConfigurationState struct {
	// The ARN of the configuration.
	Arn pulumi.StringPtrInput
	// The broker configuration in XML format.
	// See [official docs](https://docs.aws.amazon.com/amazon-mq/latest/developer-guide/amazon-mq-broker-configuration-parameters.html)
	// for supported parameters and format of the XML.
	Data pulumi.StringPtrInput
	// The description of the configuration.
	Description pulumi.StringPtrInput
	// The type of broker engine.
	EngineType pulumi.StringPtrInput
	// The version of the broker engine.
	EngineVersion pulumi.StringPtrInput
	// The latest revision of the configuration.
	LatestRevision pulumi.IntPtrInput
	// The name of the configuration
	Name pulumi.StringPtrInput
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapInput
}

func (ConfigurationState) ElementType() reflect.Type {
	return reflect.TypeOf((*configurationState)(nil)).Elem()
}

type configurationArgs struct {
	// The broker configuration in XML format.
	// See [official docs](https://docs.aws.amazon.com/amazon-mq/latest/developer-guide/amazon-mq-broker-configuration-parameters.html)
	// for supported parameters and format of the XML.
	Data string `pulumi:"data"`
	// The description of the configuration.
	Description *string `pulumi:"description"`
	// The type of broker engine.
	EngineType string `pulumi:"engineType"`
	// The version of the broker engine.
	EngineVersion string `pulumi:"engineVersion"`
	// The name of the configuration
	Name *string `pulumi:"name"`
	// A map of tags to assign to the resource.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a Configuration resource.
type ConfigurationArgs struct {
	// The broker configuration in XML format.
	// See [official docs](https://docs.aws.amazon.com/amazon-mq/latest/developer-guide/amazon-mq-broker-configuration-parameters.html)
	// for supported parameters and format of the XML.
	Data pulumi.StringInput
	// The description of the configuration.
	Description pulumi.StringPtrInput
	// The type of broker engine.
	EngineType pulumi.StringInput
	// The version of the broker engine.
	EngineVersion pulumi.StringInput
	// The name of the configuration
	Name pulumi.StringPtrInput
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapInput
}

func (ConfigurationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*configurationArgs)(nil)).Elem()
}
