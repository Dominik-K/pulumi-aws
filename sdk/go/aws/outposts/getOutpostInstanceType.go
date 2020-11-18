// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package outposts

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Information about single Outpost Instance Type.
func GetOutpostInstanceType(ctx *pulumi.Context, args *GetOutpostInstanceTypeArgs, opts ...pulumi.InvokeOption) (*GetOutpostInstanceTypeResult, error) {
	var rv GetOutpostInstanceTypeResult
	err := ctx.Invoke("aws:outposts/getOutpostInstanceType:getOutpostInstanceType", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getOutpostInstanceType.
type GetOutpostInstanceTypeArgs struct {
	// Outpost Amazon Resource Name (ARN).
	Arn string `pulumi:"arn"`
	// Desired instance type. Conflicts with `preferredInstanceTypes`.
	InstanceType *string `pulumi:"instanceType"`
	// Ordered list of preferred instance types. The first match in this list will be returned. If no preferred matches are found and the original search returned more than one result, an error is returned. Conflicts with `instanceType`.
	PreferredInstanceTypes []string `pulumi:"preferredInstanceTypes"`
}

// A collection of values returned by getOutpostInstanceType.
type GetOutpostInstanceTypeResult struct {
	Arn string `pulumi:"arn"`
	// The provider-assigned unique ID for this managed resource.
	Id                     string   `pulumi:"id"`
	InstanceType           string   `pulumi:"instanceType"`
	PreferredInstanceTypes []string `pulumi:"preferredInstanceTypes"`
}
