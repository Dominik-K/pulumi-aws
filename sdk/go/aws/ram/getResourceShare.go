// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ram

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// `ram.ResourceShare` Retrieve information about a RAM Resource Share.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/ram_resource_share.html.markdown.
func LookupResourceShare(ctx *pulumi.Context, args *GetResourceShareArgs) (*GetResourceShareResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["filters"] = args.Filters
		inputs["name"] = args.Name
		inputs["resourceOwner"] = args.ResourceOwner
	}
	outputs, err := ctx.Invoke("aws:ram/getResourceShare:getResourceShare", inputs)
	if err != nil {
		return nil, err
	}
	return &GetResourceShareResult{
		Arn: outputs["arn"],
		Filters: outputs["filters"],
		Id: outputs["id"],
		Name: outputs["name"],
		ResourceOwner: outputs["resourceOwner"],
		Status: outputs["status"],
		Tags: outputs["tags"],
	}, nil
}

// A collection of arguments for invoking getResourceShare.
type GetResourceShareArgs struct {
	// A filter used to scope the list e.g. by tags. See [related docs] (https://docs.aws.amazon.com/ram/latest/APIReference/API_TagFilter.html).
	Filters interface{}
	// The name of the tag key to filter on.
	Name interface{}
	// The owner of the resource share. Valid values are SELF or OTHER-ACCOUNTS
	ResourceOwner interface{}
}

// A collection of values returned by getResourceShare.
type GetResourceShareResult struct {
	// The Amazon Resource Name (ARN) of the resource share.
	Arn interface{}
	Filters interface{}
	// The Amazon Resource Name (ARN) of the resource share.
	Id interface{}
	Name interface{}
	ResourceOwner interface{}
	// The Status of the RAM share.
	Status interface{}
	// The Tags attached to the RAM share
	Tags interface{}
}
