// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package codepipeline

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a CodePipeline.
//
// > **NOTE on `codepipeline.Pipeline`:** - the `GITHUB_TOKEN` environment variable must be set if the GitHub provider is specified.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"fmt"
//
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/codepipeline"
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/iam"
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/kms"
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/s3"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		codepipelineBucket, err := s3.NewBucket(ctx, "codepipelineBucket", &s3.BucketArgs{
// 			Acl: pulumi.String("private"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		codepipelineRole, err := iam.NewRole(ctx, "codepipelineRole", &iam.RoleArgs{
// 			AssumeRolePolicy: pulumi.String(fmt.Sprintf("%v%v%v%v%v%v%v%v%v%v%v%v%v", "{\n", "  \"Version\": \"2012-10-17\",\n", "  \"Statement\": [\n", "    {\n", "      \"Effect\": \"Allow\",\n", "      \"Principal\": {\n", "        \"Service\": \"codepipeline.amazonaws.com\"\n", "      },\n", "      \"Action\": \"sts:AssumeRole\"\n", "    }\n", "  ]\n", "}\n", "\n")),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = iam.NewRolePolicy(ctx, "codepipelinePolicy", &iam.RolePolicyArgs{
// 			Policy: pulumi.All(codepipelineBucket.Arn, codepipelineBucket.Arn).ApplyT(func(_args []interface{}) (string, error) {
// 				codepipelineBucketArn := _args[0].(string)
// 				codepipelineBucketArn1 := _args[1].(string)
// 				return fmt.Sprintf("%v%v%v%v%v%v%v%v%v%v%v%v%v%v%v%v%v%v%v%v%v%v%v%v%v%v%v%v%v%v%v", "{\n", "  \"Version\": \"2012-10-17\",\n", "  \"Statement\": [\n", "    {\n", "      \"Effect\":\"Allow\",\n", "      \"Action\": [\n", "        \"s3:GetObject\",\n", "        \"s3:GetObjectVersion\",\n", "        \"s3:GetBucketVersioning\",\n", "        \"s3:PutObject\"\n", "      ],\n", "      \"Resource\": [\n", "        \"", codepipelineBucketArn, "\",\n", "        \"", codepipelineBucketArn1, "/*\"\n", "      ]\n", "    },\n", "    {\n", "      \"Effect\": \"Allow\",\n", "      \"Action\": [\n", "        \"codebuild:BatchGetBuilds\",\n", "        \"codebuild:StartBuild\"\n", "      ],\n", "      \"Resource\": \"*\"\n", "    }\n", "  ]\n", "}\n", "\n"), nil
// 			}).(pulumi.StringOutput),
// 			Role: codepipelineRole.ID(),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		s3kmskey, err := kms.LookupAlias(ctx, &kms.LookupAliasArgs{
// 			Name: "alias/myKmsKey",
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		_, err = codepipeline.NewPipeline(ctx, "codepipeline", &codepipeline.PipelineArgs{
// 			ArtifactStore: &codepipeline.PipelineArtifactStoreArgs{
// 				EncryptionKey: &codepipeline.PipelineArtifactStoreEncryptionKeyArgs{
// 					Id:   pulumi.String(s3kmskey.Arn),
// 					Type: pulumi.String("KMS"),
// 				},
// 				Location: codepipelineBucket.Bucket,
// 				Type:     pulumi.String("S3"),
// 			},
// 			RoleArn: codepipelineRole.Arn,
// 			Stages: codepipeline.PipelineStageArray{
// 				&codepipeline.PipelineStageArgs{
// 					Actions: codepipeline.PipelineStageActionArray{
// 						&codepipeline.PipelineStageActionArgs{
// 							Category: pulumi.String("Source"),
// 							Configuration: pulumi.StringMap{
// 								"Branch": pulumi.String("master"),
// 								"Owner":  pulumi.String("my-organization"),
// 								"Repo":   pulumi.String("test"),
// 							},
// 							Name: pulumi.String("Source"),
// 							OutputArtifacts: pulumi.StringArray{
// 								pulumi.String("source_output"),
// 							},
// 							Owner:    pulumi.String("ThirdParty"),
// 							Provider: pulumi.String("GitHub"),
// 							Version:  pulumi.String("1"),
// 						},
// 					},
// 					Name: pulumi.String("Source"),
// 				},
// 				&codepipeline.PipelineStageArgs{
// 					Actions: codepipeline.PipelineStageActionArray{
// 						&codepipeline.PipelineStageActionArgs{
// 							Category: pulumi.String("Build"),
// 							Configuration: pulumi.StringMap{
// 								"ProjectName": pulumi.String("test"),
// 							},
// 							InputArtifacts: pulumi.StringArray{
// 								pulumi.String("source_output"),
// 							},
// 							Name: pulumi.String("Build"),
// 							OutputArtifacts: pulumi.StringArray{
// 								pulumi.String("build_output"),
// 							},
// 							Owner:    pulumi.String("AWS"),
// 							Provider: pulumi.String("CodeBuild"),
// 							Version:  pulumi.String("1"),
// 						},
// 					},
// 					Name: pulumi.String("Build"),
// 				},
// 				&codepipeline.PipelineStageArgs{
// 					Actions: codepipeline.PipelineStageActionArray{
// 						&codepipeline.PipelineStageActionArgs{
// 							Category: pulumi.String("Deploy"),
// 							Configuration: pulumi.StringMap{
// 								"ActionMode":     pulumi.String("REPLACE_ON_FAILURE"),
// 								"Capabilities":   pulumi.String("CAPABILITY_AUTO_EXPAND,CAPABILITY_IAM"),
// 								"OutputFileName": pulumi.String("CreateStackOutput.json"),
// 								"StackName":      pulumi.String("MyStack"),
// 								"TemplatePath":   pulumi.String("build_output::sam-templated.yaml"),
// 							},
// 							InputArtifacts: pulumi.StringArray{
// 								pulumi.String("build_output"),
// 							},
// 							Name:     pulumi.String("Deploy"),
// 							Owner:    pulumi.String("AWS"),
// 							Provider: pulumi.String("CloudFormation"),
// 							Version:  pulumi.String("1"),
// 						},
// 					},
// 					Name: pulumi.String("Deploy"),
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
type Pipeline struct {
	pulumi.CustomResourceState

	// The codepipeline ARN.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// One or more artifactStore blocks. Artifact stores are documented below.
	ArtifactStore PipelineArtifactStoreOutput `pulumi:"artifactStore"`
	// The name of the pipeline.
	Name pulumi.StringOutput `pulumi:"name"`
	// A service role Amazon Resource Name (ARN) that grants AWS CodePipeline permission to make calls to AWS services on your behalf.
	RoleArn pulumi.StringOutput `pulumi:"roleArn"`
	// A stage block. Stages are documented below.
	Stages PipelineStageArrayOutput `pulumi:"stages"`
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
}

// NewPipeline registers a new resource with the given unique name, arguments, and options.
func NewPipeline(ctx *pulumi.Context,
	name string, args *PipelineArgs, opts ...pulumi.ResourceOption) (*Pipeline, error) {
	if args == nil || args.ArtifactStore == nil {
		return nil, errors.New("missing required argument 'ArtifactStore'")
	}
	if args == nil || args.RoleArn == nil {
		return nil, errors.New("missing required argument 'RoleArn'")
	}
	if args == nil || args.Stages == nil {
		return nil, errors.New("missing required argument 'Stages'")
	}
	if args == nil {
		args = &PipelineArgs{}
	}
	var resource Pipeline
	err := ctx.RegisterResource("aws:codepipeline/pipeline:Pipeline", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPipeline gets an existing Pipeline resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPipeline(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PipelineState, opts ...pulumi.ResourceOption) (*Pipeline, error) {
	var resource Pipeline
	err := ctx.ReadResource("aws:codepipeline/pipeline:Pipeline", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Pipeline resources.
type pipelineState struct {
	// The codepipeline ARN.
	Arn *string `pulumi:"arn"`
	// One or more artifactStore blocks. Artifact stores are documented below.
	ArtifactStore *PipelineArtifactStore `pulumi:"artifactStore"`
	// The name of the pipeline.
	Name *string `pulumi:"name"`
	// A service role Amazon Resource Name (ARN) that grants AWS CodePipeline permission to make calls to AWS services on your behalf.
	RoleArn *string `pulumi:"roleArn"`
	// A stage block. Stages are documented below.
	Stages []PipelineStage `pulumi:"stages"`
	// A map of tags to assign to the resource.
	Tags map[string]string `pulumi:"tags"`
}

type PipelineState struct {
	// The codepipeline ARN.
	Arn pulumi.StringPtrInput
	// One or more artifactStore blocks. Artifact stores are documented below.
	ArtifactStore PipelineArtifactStorePtrInput
	// The name of the pipeline.
	Name pulumi.StringPtrInput
	// A service role Amazon Resource Name (ARN) that grants AWS CodePipeline permission to make calls to AWS services on your behalf.
	RoleArn pulumi.StringPtrInput
	// A stage block. Stages are documented below.
	Stages PipelineStageArrayInput
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapInput
}

func (PipelineState) ElementType() reflect.Type {
	return reflect.TypeOf((*pipelineState)(nil)).Elem()
}

type pipelineArgs struct {
	// One or more artifactStore blocks. Artifact stores are documented below.
	ArtifactStore PipelineArtifactStore `pulumi:"artifactStore"`
	// The name of the pipeline.
	Name *string `pulumi:"name"`
	// A service role Amazon Resource Name (ARN) that grants AWS CodePipeline permission to make calls to AWS services on your behalf.
	RoleArn string `pulumi:"roleArn"`
	// A stage block. Stages are documented below.
	Stages []PipelineStage `pulumi:"stages"`
	// A map of tags to assign to the resource.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a Pipeline resource.
type PipelineArgs struct {
	// One or more artifactStore blocks. Artifact stores are documented below.
	ArtifactStore PipelineArtifactStoreInput
	// The name of the pipeline.
	Name pulumi.StringPtrInput
	// A service role Amazon Resource Name (ARN) that grants AWS CodePipeline permission to make calls to AWS services on your behalf.
	RoleArn pulumi.StringInput
	// A stage block. Stages are documented below.
	Stages PipelineStageArrayInput
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapInput
}

func (PipelineArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*pipelineArgs)(nil)).Elem()
}
