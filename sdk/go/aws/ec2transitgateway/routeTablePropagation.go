// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2transitgateway

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages an EC2 Transit Gateway Route Table propagation.
type RouteTablePropagation struct {
	pulumi.CustomResourceState

	// Identifier of the resource
	ResourceId pulumi.StringOutput `pulumi:"resourceId"`
	// Type of the resource
	ResourceType pulumi.StringOutput `pulumi:"resourceType"`
	// Identifier of EC2 Transit Gateway Attachment.
	TransitGatewayAttachmentId pulumi.StringOutput `pulumi:"transitGatewayAttachmentId"`
	// Identifier of EC2 Transit Gateway Route Table.
	TransitGatewayRouteTableId pulumi.StringOutput `pulumi:"transitGatewayRouteTableId"`
}

// NewRouteTablePropagation registers a new resource with the given unique name, arguments, and options.
func NewRouteTablePropagation(ctx *pulumi.Context,
	name string, args *RouteTablePropagationArgs, opts ...pulumi.ResourceOption) (*RouteTablePropagation, error) {
	if args == nil || args.TransitGatewayAttachmentId == nil {
		return nil, errors.New("missing required argument 'TransitGatewayAttachmentId'")
	}
	if args == nil || args.TransitGatewayRouteTableId == nil {
		return nil, errors.New("missing required argument 'TransitGatewayRouteTableId'")
	}
	if args == nil {
		args = &RouteTablePropagationArgs{}
	}
	var resource RouteTablePropagation
	err := ctx.RegisterResource("aws:ec2transitgateway/routeTablePropagation:RouteTablePropagation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRouteTablePropagation gets an existing RouteTablePropagation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRouteTablePropagation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RouteTablePropagationState, opts ...pulumi.ResourceOption) (*RouteTablePropagation, error) {
	var resource RouteTablePropagation
	err := ctx.ReadResource("aws:ec2transitgateway/routeTablePropagation:RouteTablePropagation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RouteTablePropagation resources.
type routeTablePropagationState struct {
	// Identifier of the resource
	ResourceId *string `pulumi:"resourceId"`
	// Type of the resource
	ResourceType *string `pulumi:"resourceType"`
	// Identifier of EC2 Transit Gateway Attachment.
	TransitGatewayAttachmentId *string `pulumi:"transitGatewayAttachmentId"`
	// Identifier of EC2 Transit Gateway Route Table.
	TransitGatewayRouteTableId *string `pulumi:"transitGatewayRouteTableId"`
}

type RouteTablePropagationState struct {
	// Identifier of the resource
	ResourceId pulumi.StringPtrInput
	// Type of the resource
	ResourceType pulumi.StringPtrInput
	// Identifier of EC2 Transit Gateway Attachment.
	TransitGatewayAttachmentId pulumi.StringPtrInput
	// Identifier of EC2 Transit Gateway Route Table.
	TransitGatewayRouteTableId pulumi.StringPtrInput
}

func (RouteTablePropagationState) ElementType() reflect.Type {
	return reflect.TypeOf((*routeTablePropagationState)(nil)).Elem()
}

type routeTablePropagationArgs struct {
	// Identifier of EC2 Transit Gateway Attachment.
	TransitGatewayAttachmentId string `pulumi:"transitGatewayAttachmentId"`
	// Identifier of EC2 Transit Gateway Route Table.
	TransitGatewayRouteTableId string `pulumi:"transitGatewayRouteTableId"`
}

// The set of arguments for constructing a RouteTablePropagation resource.
type RouteTablePropagationArgs struct {
	// Identifier of EC2 Transit Gateway Attachment.
	TransitGatewayAttachmentId pulumi.StringInput
	// Identifier of EC2 Transit Gateway Route Table.
	TransitGatewayRouteTableId pulumi.StringInput
}

func (RouteTablePropagationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*routeTablePropagationArgs)(nil)).Elem()
}
