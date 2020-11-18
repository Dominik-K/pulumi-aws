// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package inspector

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Inspector assessment template
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/inspector"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := inspector.NewAssessmentTemplate(ctx, "example", &inspector.AssessmentTemplateArgs{
// 			TargetArn: pulumi.Any(aws_inspector_assessment_target.Example.Arn),
// 			Duration:  pulumi.Int(3600),
// 			RulesPackageArns: pulumi.StringArray{
// 				pulumi.String("arn:aws:inspector:us-west-2:758058086616:rulespackage/0-9hgA516p"),
// 				pulumi.String("arn:aws:inspector:us-west-2:758058086616:rulespackage/0-H5hpSawc"),
// 				pulumi.String("arn:aws:inspector:us-west-2:758058086616:rulespackage/0-JJOtZiqQ"),
// 				pulumi.String("arn:aws:inspector:us-west-2:758058086616:rulespackage/0-vg5GGHSD"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type AssessmentTemplate struct {
	pulumi.CustomResourceState

	// The template assessment ARN.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// The duration of the inspector run.
	Duration pulumi.IntOutput `pulumi:"duration"`
	// The name of the assessment template.
	Name pulumi.StringOutput `pulumi:"name"`
	// The rules to be used during the run.
	RulesPackageArns pulumi.StringArrayOutput `pulumi:"rulesPackageArns"`
	// Key-value map of tags for the Inspector assessment template.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The assessment target ARN to attach the template to.
	TargetArn pulumi.StringOutput `pulumi:"targetArn"`
}

// NewAssessmentTemplate registers a new resource with the given unique name, arguments, and options.
func NewAssessmentTemplate(ctx *pulumi.Context,
	name string, args *AssessmentTemplateArgs, opts ...pulumi.ResourceOption) (*AssessmentTemplate, error) {
	if args == nil || args.Duration == nil {
		return nil, errors.New("missing required argument 'Duration'")
	}
	if args == nil || args.RulesPackageArns == nil {
		return nil, errors.New("missing required argument 'RulesPackageArns'")
	}
	if args == nil || args.TargetArn == nil {
		return nil, errors.New("missing required argument 'TargetArn'")
	}
	if args == nil {
		args = &AssessmentTemplateArgs{}
	}
	var resource AssessmentTemplate
	err := ctx.RegisterResource("aws:inspector/assessmentTemplate:AssessmentTemplate", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAssessmentTemplate gets an existing AssessmentTemplate resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAssessmentTemplate(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AssessmentTemplateState, opts ...pulumi.ResourceOption) (*AssessmentTemplate, error) {
	var resource AssessmentTemplate
	err := ctx.ReadResource("aws:inspector/assessmentTemplate:AssessmentTemplate", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AssessmentTemplate resources.
type assessmentTemplateState struct {
	// The template assessment ARN.
	Arn *string `pulumi:"arn"`
	// The duration of the inspector run.
	Duration *int `pulumi:"duration"`
	// The name of the assessment template.
	Name *string `pulumi:"name"`
	// The rules to be used during the run.
	RulesPackageArns []string `pulumi:"rulesPackageArns"`
	// Key-value map of tags for the Inspector assessment template.
	Tags map[string]string `pulumi:"tags"`
	// The assessment target ARN to attach the template to.
	TargetArn *string `pulumi:"targetArn"`
}

type AssessmentTemplateState struct {
	// The template assessment ARN.
	Arn pulumi.StringPtrInput
	// The duration of the inspector run.
	Duration pulumi.IntPtrInput
	// The name of the assessment template.
	Name pulumi.StringPtrInput
	// The rules to be used during the run.
	RulesPackageArns pulumi.StringArrayInput
	// Key-value map of tags for the Inspector assessment template.
	Tags pulumi.StringMapInput
	// The assessment target ARN to attach the template to.
	TargetArn pulumi.StringPtrInput
}

func (AssessmentTemplateState) ElementType() reflect.Type {
	return reflect.TypeOf((*assessmentTemplateState)(nil)).Elem()
}

type assessmentTemplateArgs struct {
	// The duration of the inspector run.
	Duration int `pulumi:"duration"`
	// The name of the assessment template.
	Name *string `pulumi:"name"`
	// The rules to be used during the run.
	RulesPackageArns []string `pulumi:"rulesPackageArns"`
	// Key-value map of tags for the Inspector assessment template.
	Tags map[string]string `pulumi:"tags"`
	// The assessment target ARN to attach the template to.
	TargetArn string `pulumi:"targetArn"`
}

// The set of arguments for constructing a AssessmentTemplate resource.
type AssessmentTemplateArgs struct {
	// The duration of the inspector run.
	Duration pulumi.IntInput
	// The name of the assessment template.
	Name pulumi.StringPtrInput
	// The rules to be used during the run.
	RulesPackageArns pulumi.StringArrayInput
	// Key-value map of tags for the Inspector assessment template.
	Tags pulumi.StringMapInput
	// The assessment target ARN to attach the template to.
	TargetArn pulumi.StringInput
}

func (AssessmentTemplateArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*assessmentTemplateArgs)(nil)).Elem()
}
