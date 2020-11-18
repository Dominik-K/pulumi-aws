// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package kinesis

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Kinesis Firehose Delivery Stream resource. Amazon Kinesis Firehose is a fully managed, elastic service to easily deliver real-time data streams to destinations such as Amazon S3 and Amazon Redshift.
//
// For more details, see the [Amazon Kinesis Firehose Documentation](https://aws.amazon.com/documentation/firehose/).
//
// ## Example Usage
// ### S3 Destination
//
// ```go
// package main
//
// import (
// 	"fmt"
//
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/iam"
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/kinesis"
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/s3"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		bucket, err := s3.NewBucket(ctx, "bucket", &s3.BucketArgs{
// 			Acl: pulumi.String("private"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		firehoseRole, err := iam.NewRole(ctx, "firehoseRole", &iam.RoleArgs{
// 			AssumeRolePolicy: pulumi.String(fmt.Sprintf("%v%v%v%v%v%v%v%v%v%v%v%v%v", "{\n", "  \"Version\": \"2012-10-17\",\n", "  \"Statement\": [\n", "    {\n", "      \"Action\": \"sts:AssumeRole\",\n", "      \"Principal\": {\n", "        \"Service\": \"firehose.amazonaws.com\"\n", "      },\n", "      \"Effect\": \"Allow\",\n", "      \"Sid\": \"\"\n", "    }\n", "  ]\n", "}\n")),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = kinesis.NewFirehoseDeliveryStream(ctx, "testStream", &kinesis.FirehoseDeliveryStreamArgs{
// 			Destination: pulumi.String("s3"),
// 			S3Configuration: &kinesis.FirehoseDeliveryStreamS3ConfigurationArgs{
// 				RoleArn:   firehoseRole.Arn,
// 				BucketArn: bucket.Arn,
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
// ### Redshift Destination
//
// ```go
// package main
//
// import (
// 	"fmt"
//
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/kinesis"
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/redshift"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		testCluster, err := redshift.NewCluster(ctx, "testCluster", &redshift.ClusterArgs{
// 			ClusterIdentifier: pulumi.String("tf-redshift-cluster"),
// 			DatabaseName:      pulumi.String("test"),
// 			MasterUsername:    pulumi.String("testuser"),
// 			MasterPassword:    pulumi.String("T3stPass"),
// 			NodeType:          pulumi.String("dc1.large"),
// 			ClusterType:       pulumi.String("single-node"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = kinesis.NewFirehoseDeliveryStream(ctx, "testStream", &kinesis.FirehoseDeliveryStreamArgs{
// 			Destination: pulumi.String("redshift"),
// 			S3Configuration: &kinesis.FirehoseDeliveryStreamS3ConfigurationArgs{
// 				RoleArn:           pulumi.Any(aws_iam_role.Firehose_role.Arn),
// 				BucketArn:         pulumi.Any(aws_s3_bucket.Bucket.Arn),
// 				BufferSize:        pulumi.Int(10),
// 				BufferInterval:    pulumi.Int(400),
// 				CompressionFormat: pulumi.String("GZIP"),
// 			},
// 			RedshiftConfiguration: &kinesis.FirehoseDeliveryStreamRedshiftConfigurationArgs{
// 				RoleArn: pulumi.Any(aws_iam_role.Firehose_role.Arn),
// 				ClusterJdbcurl: pulumi.All(testCluster.Endpoint, testCluster.DatabaseName).ApplyT(func(_args []interface{}) (string, error) {
// 					endpoint := _args[0].(string)
// 					databaseName := _args[1].(string)
// 					return fmt.Sprintf("%v%v%v%v", "jdbc:redshift://", endpoint, "/", databaseName), nil
// 				}).(pulumi.StringOutput),
// 				Username:         pulumi.String("testuser"),
// 				Password:         pulumi.String("T3stPass"),
// 				DataTableName:    pulumi.String("test-table"),
// 				CopyOptions:      pulumi.String("delimiter '|'"),
// 				DataTableColumns: pulumi.String("test-col"),
// 				S3BackupMode:     pulumi.String("Enabled"),
// 				S3BackupConfiguration: &kinesis.FirehoseDeliveryStreamRedshiftConfigurationS3BackupConfigurationArgs{
// 					RoleArn:           pulumi.Any(aws_iam_role.Firehose_role.Arn),
// 					BucketArn:         pulumi.Any(aws_s3_bucket.Bucket.Arn),
// 					BufferSize:        pulumi.Int(15),
// 					BufferInterval:    pulumi.Int(300),
// 					CompressionFormat: pulumi.String("GZIP"),
// 				},
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
// ### Elasticsearch Destination
//
// ```go
// package main
//
// import (
// 	"fmt"
//
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/elasticsearch"
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/kinesis"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		testCluster, err := elasticsearch.NewDomain(ctx, "testCluster", nil)
// 		if err != nil {
// 			return err
// 		}
// 		_, err = kinesis.NewFirehoseDeliveryStream(ctx, "testStream", &kinesis.FirehoseDeliveryStreamArgs{
// 			Destination: pulumi.String("elasticsearch"),
// 			S3Configuration: &kinesis.FirehoseDeliveryStreamS3ConfigurationArgs{
// 				RoleArn:           pulumi.Any(aws_iam_role.Firehose_role.Arn),
// 				BucketArn:         pulumi.Any(aws_s3_bucket.Bucket.Arn),
// 				BufferSize:        pulumi.Int(10),
// 				BufferInterval:    pulumi.Int(400),
// 				CompressionFormat: pulumi.String("GZIP"),
// 			},
// 			ElasticsearchConfiguration: &kinesis.FirehoseDeliveryStreamElasticsearchConfigurationArgs{
// 				DomainArn: testCluster.Arn,
// 				RoleArn:   pulumi.Any(aws_iam_role.Firehose_role.Arn),
// 				IndexName: pulumi.String("test"),
// 				TypeName:  pulumi.String("test"),
// 				ProcessingConfiguration: &kinesis.FirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationArgs{
// 					Enabled: pulumi.Bool(true),
// 					Processors: kinesis.FirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessorArray{
// 						&kinesis.FirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessorArgs{
// 							Type: pulumi.String("Lambda"),
// 							Parameters: kinesis.FirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessorParameterArray{
// 								&kinesis.FirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessorParameterArgs{
// 									ParameterName:  pulumi.String("LambdaArn"),
// 									ParameterValue: pulumi.String(fmt.Sprintf("%v%v%v%v", aws_lambda_function.Lambda_processor.Arn, ":", "$", "LATEST")),
// 								},
// 							},
// 						},
// 					},
// 				},
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
// ### Splunk Destination
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/kinesis"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := kinesis.NewFirehoseDeliveryStream(ctx, "testStream", &kinesis.FirehoseDeliveryStreamArgs{
// 			Destination: pulumi.String("splunk"),
// 			S3Configuration: &kinesis.FirehoseDeliveryStreamS3ConfigurationArgs{
// 				RoleArn:           pulumi.Any(aws_iam_role.Firehose.Arn),
// 				BucketArn:         pulumi.Any(aws_s3_bucket.Bucket.Arn),
// 				BufferSize:        pulumi.Int(10),
// 				BufferInterval:    pulumi.Int(400),
// 				CompressionFormat: pulumi.String("GZIP"),
// 			},
// 			SplunkConfiguration: &kinesis.FirehoseDeliveryStreamSplunkConfigurationArgs{
// 				HecEndpoint:              pulumi.String("https://http-inputs-mydomain.splunkcloud.com:443"),
// 				HecToken:                 pulumi.String("51D4DA16-C61B-4F5F-8EC7-ED4301342A4A"),
// 				HecAcknowledgmentTimeout: pulumi.Int(600),
// 				HecEndpointType:          pulumi.String("Event"),
// 				S3BackupMode:             pulumi.String("FailedEventsOnly"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
// ### HTTP Endpoint (e.g. New Relic) Destination
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/kinesis"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := kinesis.NewFirehoseDeliveryStream(ctx, "testStream", &kinesis.FirehoseDeliveryStreamArgs{
// 			Destination: pulumi.String("http_endpoint"),
// 			S3Configuration: &kinesis.FirehoseDeliveryStreamS3ConfigurationArgs{
// 				RoleArn:           pulumi.Any(aws_iam_role.Firehose.Arn),
// 				BucketArn:         pulumi.Any(aws_s3_bucket.Bucket.Arn),
// 				BufferSize:        pulumi.Int(10),
// 				BufferInterval:    pulumi.Int(400),
// 				CompressionFormat: pulumi.String("GZIP"),
// 			},
// 			HttpEndpointConfiguration: &kinesis.FirehoseDeliveryStreamHttpEndpointConfigurationArgs{
// 				Url:               pulumi.String("https://aws-api.newrelic.com/firehose/v1"),
// 				Name:              pulumi.String("New Relic"),
// 				AccessKey:         pulumi.String("my-key"),
// 				BufferingSize:     pulumi.Int(15),
// 				BufferingInterval: pulumi.Int(600),
// 				RoleArn:           pulumi.Any(aws_iam_role.Firehose.Arn),
// 				S3BackupMode:      pulumi.String("FailedDataOnly"),
// 				RequestConfiguration: &kinesis.FirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationArgs{
// 					ContentEncoding: pulumi.String("GZIP"),
// 					CommonAttributes: kinesis.FirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationCommonAttributeArray{
// 						&kinesis.FirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationCommonAttributeArgs{
// 							Name:  pulumi.String("testname"),
// 							Value: pulumi.String("testvalue"),
// 						},
// 						&kinesis.FirehoseDeliveryStreamHttpEndpointConfigurationRequestConfigurationCommonAttributeArgs{
// 							Name:  pulumi.String("testname2"),
// 							Value: pulumi.String("testvalue2"),
// 						},
// 					},
// 				},
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type FirehoseDeliveryStream struct {
	pulumi.CustomResourceState

	// The Amazon Resource Name (ARN) specifying the Stream
	Arn pulumi.StringOutput `pulumi:"arn"`
	// This is the destination to where the data is delivered. The only options are `s3` (Deprecated, use `extendedS3` instead), `extendedS3`, `redshift`, `elasticsearch`, `splunk`, and `httpEndpoint`.
	Destination   pulumi.StringOutput `pulumi:"destination"`
	DestinationId pulumi.StringOutput `pulumi:"destinationId"`
	// Configuration options if elasticsearch is the destination. More details are given below.
	ElasticsearchConfiguration FirehoseDeliveryStreamElasticsearchConfigurationPtrOutput `pulumi:"elasticsearchConfiguration"`
	// Enhanced configuration options for the s3 destination. More details are given below.
	ExtendedS3Configuration FirehoseDeliveryStreamExtendedS3ConfigurationPtrOutput `pulumi:"extendedS3Configuration"`
	// Configuration options if httpEndpoint is the destination. requires the user to also specify a `s3Configuration` block.  More details are given below.
	HttpEndpointConfiguration FirehoseDeliveryStreamHttpEndpointConfigurationPtrOutput `pulumi:"httpEndpointConfiguration"`
	// Allows the ability to specify the kinesis stream that is used as the source of the firehose delivery stream.
	KinesisSourceConfiguration FirehoseDeliveryStreamKinesisSourceConfigurationPtrOutput `pulumi:"kinesisSourceConfiguration"`
	// A name to identify the stream. This is unique to the
	// AWS account and region the Stream is created in.
	Name pulumi.StringOutput `pulumi:"name"`
	// Configuration options if redshift is the destination.
	// Using `redshiftConfiguration` requires the user to also specify a
	// `s3Configuration` block. More details are given below.
	RedshiftConfiguration FirehoseDeliveryStreamRedshiftConfigurationPtrOutput `pulumi:"redshiftConfiguration"`
	// Required for non-S3 destinations. For S3 destination, use `extendedS3Configuration` instead. Configuration options for the s3 destination (or the intermediate bucket if the destination
	// is redshift). More details are given below.
	S3Configuration FirehoseDeliveryStreamS3ConfigurationPtrOutput `pulumi:"s3Configuration"`
	// Encrypt at rest options.
	// Server-side encryption should not be enabled when a kinesis stream is configured as the source of the firehose delivery stream.
	ServerSideEncryption FirehoseDeliveryStreamServerSideEncryptionPtrOutput `pulumi:"serverSideEncryption"`
	// Configuration options if splunk is the destination. More details are given below.
	SplunkConfiguration FirehoseDeliveryStreamSplunkConfigurationPtrOutput `pulumi:"splunkConfiguration"`
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Specifies the table version for the output data schema. Defaults to `LATEST`.
	VersionId pulumi.StringOutput `pulumi:"versionId"`
}

// NewFirehoseDeliveryStream registers a new resource with the given unique name, arguments, and options.
func NewFirehoseDeliveryStream(ctx *pulumi.Context,
	name string, args *FirehoseDeliveryStreamArgs, opts ...pulumi.ResourceOption) (*FirehoseDeliveryStream, error) {
	if args == nil || args.Destination == nil {
		return nil, errors.New("missing required argument 'Destination'")
	}
	if args == nil {
		args = &FirehoseDeliveryStreamArgs{}
	}
	var resource FirehoseDeliveryStream
	err := ctx.RegisterResource("aws:kinesis/firehoseDeliveryStream:FirehoseDeliveryStream", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetFirehoseDeliveryStream gets an existing FirehoseDeliveryStream resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetFirehoseDeliveryStream(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *FirehoseDeliveryStreamState, opts ...pulumi.ResourceOption) (*FirehoseDeliveryStream, error) {
	var resource FirehoseDeliveryStream
	err := ctx.ReadResource("aws:kinesis/firehoseDeliveryStream:FirehoseDeliveryStream", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering FirehoseDeliveryStream resources.
type firehoseDeliveryStreamState struct {
	// The Amazon Resource Name (ARN) specifying the Stream
	Arn *string `pulumi:"arn"`
	// This is the destination to where the data is delivered. The only options are `s3` (Deprecated, use `extendedS3` instead), `extendedS3`, `redshift`, `elasticsearch`, `splunk`, and `httpEndpoint`.
	Destination   *string `pulumi:"destination"`
	DestinationId *string `pulumi:"destinationId"`
	// Configuration options if elasticsearch is the destination. More details are given below.
	ElasticsearchConfiguration *FirehoseDeliveryStreamElasticsearchConfiguration `pulumi:"elasticsearchConfiguration"`
	// Enhanced configuration options for the s3 destination. More details are given below.
	ExtendedS3Configuration *FirehoseDeliveryStreamExtendedS3Configuration `pulumi:"extendedS3Configuration"`
	// Configuration options if httpEndpoint is the destination. requires the user to also specify a `s3Configuration` block.  More details are given below.
	HttpEndpointConfiguration *FirehoseDeliveryStreamHttpEndpointConfiguration `pulumi:"httpEndpointConfiguration"`
	// Allows the ability to specify the kinesis stream that is used as the source of the firehose delivery stream.
	KinesisSourceConfiguration *FirehoseDeliveryStreamKinesisSourceConfiguration `pulumi:"kinesisSourceConfiguration"`
	// A name to identify the stream. This is unique to the
	// AWS account and region the Stream is created in.
	Name *string `pulumi:"name"`
	// Configuration options if redshift is the destination.
	// Using `redshiftConfiguration` requires the user to also specify a
	// `s3Configuration` block. More details are given below.
	RedshiftConfiguration *FirehoseDeliveryStreamRedshiftConfiguration `pulumi:"redshiftConfiguration"`
	// Required for non-S3 destinations. For S3 destination, use `extendedS3Configuration` instead. Configuration options for the s3 destination (or the intermediate bucket if the destination
	// is redshift). More details are given below.
	S3Configuration *FirehoseDeliveryStreamS3Configuration `pulumi:"s3Configuration"`
	// Encrypt at rest options.
	// Server-side encryption should not be enabled when a kinesis stream is configured as the source of the firehose delivery stream.
	ServerSideEncryption *FirehoseDeliveryStreamServerSideEncryption `pulumi:"serverSideEncryption"`
	// Configuration options if splunk is the destination. More details are given below.
	SplunkConfiguration *FirehoseDeliveryStreamSplunkConfiguration `pulumi:"splunkConfiguration"`
	// A map of tags to assign to the resource.
	Tags map[string]string `pulumi:"tags"`
	// Specifies the table version for the output data schema. Defaults to `LATEST`.
	VersionId *string `pulumi:"versionId"`
}

type FirehoseDeliveryStreamState struct {
	// The Amazon Resource Name (ARN) specifying the Stream
	Arn pulumi.StringPtrInput
	// This is the destination to where the data is delivered. The only options are `s3` (Deprecated, use `extendedS3` instead), `extendedS3`, `redshift`, `elasticsearch`, `splunk`, and `httpEndpoint`.
	Destination   pulumi.StringPtrInput
	DestinationId pulumi.StringPtrInput
	// Configuration options if elasticsearch is the destination. More details are given below.
	ElasticsearchConfiguration FirehoseDeliveryStreamElasticsearchConfigurationPtrInput
	// Enhanced configuration options for the s3 destination. More details are given below.
	ExtendedS3Configuration FirehoseDeliveryStreamExtendedS3ConfigurationPtrInput
	// Configuration options if httpEndpoint is the destination. requires the user to also specify a `s3Configuration` block.  More details are given below.
	HttpEndpointConfiguration FirehoseDeliveryStreamHttpEndpointConfigurationPtrInput
	// Allows the ability to specify the kinesis stream that is used as the source of the firehose delivery stream.
	KinesisSourceConfiguration FirehoseDeliveryStreamKinesisSourceConfigurationPtrInput
	// A name to identify the stream. This is unique to the
	// AWS account and region the Stream is created in.
	Name pulumi.StringPtrInput
	// Configuration options if redshift is the destination.
	// Using `redshiftConfiguration` requires the user to also specify a
	// `s3Configuration` block. More details are given below.
	RedshiftConfiguration FirehoseDeliveryStreamRedshiftConfigurationPtrInput
	// Required for non-S3 destinations. For S3 destination, use `extendedS3Configuration` instead. Configuration options for the s3 destination (or the intermediate bucket if the destination
	// is redshift). More details are given below.
	S3Configuration FirehoseDeliveryStreamS3ConfigurationPtrInput
	// Encrypt at rest options.
	// Server-side encryption should not be enabled when a kinesis stream is configured as the source of the firehose delivery stream.
	ServerSideEncryption FirehoseDeliveryStreamServerSideEncryptionPtrInput
	// Configuration options if splunk is the destination. More details are given below.
	SplunkConfiguration FirehoseDeliveryStreamSplunkConfigurationPtrInput
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapInput
	// Specifies the table version for the output data schema. Defaults to `LATEST`.
	VersionId pulumi.StringPtrInput
}

func (FirehoseDeliveryStreamState) ElementType() reflect.Type {
	return reflect.TypeOf((*firehoseDeliveryStreamState)(nil)).Elem()
}

type firehoseDeliveryStreamArgs struct {
	// The Amazon Resource Name (ARN) specifying the Stream
	Arn *string `pulumi:"arn"`
	// This is the destination to where the data is delivered. The only options are `s3` (Deprecated, use `extendedS3` instead), `extendedS3`, `redshift`, `elasticsearch`, `splunk`, and `httpEndpoint`.
	Destination   string  `pulumi:"destination"`
	DestinationId *string `pulumi:"destinationId"`
	// Configuration options if elasticsearch is the destination. More details are given below.
	ElasticsearchConfiguration *FirehoseDeliveryStreamElasticsearchConfiguration `pulumi:"elasticsearchConfiguration"`
	// Enhanced configuration options for the s3 destination. More details are given below.
	ExtendedS3Configuration *FirehoseDeliveryStreamExtendedS3Configuration `pulumi:"extendedS3Configuration"`
	// Configuration options if httpEndpoint is the destination. requires the user to also specify a `s3Configuration` block.  More details are given below.
	HttpEndpointConfiguration *FirehoseDeliveryStreamHttpEndpointConfiguration `pulumi:"httpEndpointConfiguration"`
	// Allows the ability to specify the kinesis stream that is used as the source of the firehose delivery stream.
	KinesisSourceConfiguration *FirehoseDeliveryStreamKinesisSourceConfiguration `pulumi:"kinesisSourceConfiguration"`
	// A name to identify the stream. This is unique to the
	// AWS account and region the Stream is created in.
	Name *string `pulumi:"name"`
	// Configuration options if redshift is the destination.
	// Using `redshiftConfiguration` requires the user to also specify a
	// `s3Configuration` block. More details are given below.
	RedshiftConfiguration *FirehoseDeliveryStreamRedshiftConfiguration `pulumi:"redshiftConfiguration"`
	// Required for non-S3 destinations. For S3 destination, use `extendedS3Configuration` instead. Configuration options for the s3 destination (or the intermediate bucket if the destination
	// is redshift). More details are given below.
	S3Configuration *FirehoseDeliveryStreamS3Configuration `pulumi:"s3Configuration"`
	// Encrypt at rest options.
	// Server-side encryption should not be enabled when a kinesis stream is configured as the source of the firehose delivery stream.
	ServerSideEncryption *FirehoseDeliveryStreamServerSideEncryption `pulumi:"serverSideEncryption"`
	// Configuration options if splunk is the destination. More details are given below.
	SplunkConfiguration *FirehoseDeliveryStreamSplunkConfiguration `pulumi:"splunkConfiguration"`
	// A map of tags to assign to the resource.
	Tags map[string]string `pulumi:"tags"`
	// Specifies the table version for the output data schema. Defaults to `LATEST`.
	VersionId *string `pulumi:"versionId"`
}

// The set of arguments for constructing a FirehoseDeliveryStream resource.
type FirehoseDeliveryStreamArgs struct {
	// The Amazon Resource Name (ARN) specifying the Stream
	Arn pulumi.StringPtrInput
	// This is the destination to where the data is delivered. The only options are `s3` (Deprecated, use `extendedS3` instead), `extendedS3`, `redshift`, `elasticsearch`, `splunk`, and `httpEndpoint`.
	Destination   pulumi.StringInput
	DestinationId pulumi.StringPtrInput
	// Configuration options if elasticsearch is the destination. More details are given below.
	ElasticsearchConfiguration FirehoseDeliveryStreamElasticsearchConfigurationPtrInput
	// Enhanced configuration options for the s3 destination. More details are given below.
	ExtendedS3Configuration FirehoseDeliveryStreamExtendedS3ConfigurationPtrInput
	// Configuration options if httpEndpoint is the destination. requires the user to also specify a `s3Configuration` block.  More details are given below.
	HttpEndpointConfiguration FirehoseDeliveryStreamHttpEndpointConfigurationPtrInput
	// Allows the ability to specify the kinesis stream that is used as the source of the firehose delivery stream.
	KinesisSourceConfiguration FirehoseDeliveryStreamKinesisSourceConfigurationPtrInput
	// A name to identify the stream. This is unique to the
	// AWS account and region the Stream is created in.
	Name pulumi.StringPtrInput
	// Configuration options if redshift is the destination.
	// Using `redshiftConfiguration` requires the user to also specify a
	// `s3Configuration` block. More details are given below.
	RedshiftConfiguration FirehoseDeliveryStreamRedshiftConfigurationPtrInput
	// Required for non-S3 destinations. For S3 destination, use `extendedS3Configuration` instead. Configuration options for the s3 destination (or the intermediate bucket if the destination
	// is redshift). More details are given below.
	S3Configuration FirehoseDeliveryStreamS3ConfigurationPtrInput
	// Encrypt at rest options.
	// Server-side encryption should not be enabled when a kinesis stream is configured as the source of the firehose delivery stream.
	ServerSideEncryption FirehoseDeliveryStreamServerSideEncryptionPtrInput
	// Configuration options if splunk is the destination. More details are given below.
	SplunkConfiguration FirehoseDeliveryStreamSplunkConfigurationPtrInput
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapInput
	// Specifies the table version for the output data schema. Defaults to `LATEST`.
	VersionId pulumi.StringPtrInput
}

func (FirehoseDeliveryStreamArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*firehoseDeliveryStreamArgs)(nil)).Elem()
}
