// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package wafv2

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Retrieves the summary of a WAFv2 Regex Pattern Set.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/wafv2"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := wafv2.LookupRegexPatternSet(ctx, &wafv2.LookupRegexPatternSetArgs{
// 			Name:  "some-regex-pattern-set",
// 			Scope: "REGIONAL",
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func LookupRegexPatternSet(ctx *pulumi.Context, args *LookupRegexPatternSetArgs, opts ...pulumi.InvokeOption) (*LookupRegexPatternSetResult, error) {
	var rv LookupRegexPatternSetResult
	err := ctx.Invoke("aws:wafv2/getRegexPatternSet:getRegexPatternSet", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getRegexPatternSet.
type LookupRegexPatternSetArgs struct {
	// The name of the WAFv2 Regex Pattern Set.
	Name string `pulumi:"name"`
	// Specifies whether this is for an AWS CloudFront distribution or for a regional application. Valid values are `CLOUDFRONT` or `REGIONAL`. To work with CloudFront, you must also specify the region `us-east-1` (N. Virginia) on the AWS provider.
	Scope string `pulumi:"scope"`
}

// A collection of values returned by getRegexPatternSet.
type LookupRegexPatternSetResult struct {
	// The Amazon Resource Name (ARN) of the entity.
	Arn string `pulumi:"arn"`
	// The description of the set that helps with identification.
	Description string `pulumi:"description"`
	// The provider-assigned unique ID for this managed resource.
	Id   string `pulumi:"id"`
	Name string `pulumi:"name"`
	// One or more blocks of regular expression patterns that AWS WAF is searching for. See Regular Expression below for details.
	RegularExpressions []GetRegexPatternSetRegularExpression `pulumi:"regularExpressions"`
	Scope              string                                `pulumi:"scope"`
}
