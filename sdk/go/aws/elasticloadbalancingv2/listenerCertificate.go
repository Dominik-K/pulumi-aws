// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package elasticloadbalancingv2

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Load Balancer Listener Certificate resource.
// 
// This resource is for additional certificates and does not replace the default certificate on the listener.
// 
// ~> **Note:** `aws_alb_listener_certificate` is known as `aws_lb_listener_certificate`. The functionality is identical.
type ListenerCertificate struct {
	s *pulumi.ResourceState
}

// NewListenerCertificate registers a new resource with the given unique name, arguments, and options.
func NewListenerCertificate(ctx *pulumi.Context,
	name string, args *ListenerCertificateArgs, opts ...pulumi.ResourceOpt) (*ListenerCertificate, error) {
	if args == nil || args.CertificateArn == nil {
		return nil, errors.New("missing required argument 'CertificateArn'")
	}
	if args == nil || args.ListenerArn == nil {
		return nil, errors.New("missing required argument 'ListenerArn'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["certificateArn"] = nil
		inputs["listenerArn"] = nil
	} else {
		inputs["certificateArn"] = args.CertificateArn
		inputs["listenerArn"] = args.ListenerArn
	}
	s, err := ctx.RegisterResource("aws:elasticloadbalancingv2/listenerCertificate:ListenerCertificate", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ListenerCertificate{s: s}, nil
}

// GetListenerCertificate gets an existing ListenerCertificate resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetListenerCertificate(ctx *pulumi.Context,
	name string, id pulumi.ID, state *ListenerCertificateState, opts ...pulumi.ResourceOpt) (*ListenerCertificate, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["certificateArn"] = state.CertificateArn
		inputs["listenerArn"] = state.ListenerArn
	}
	s, err := ctx.ReadResource("aws:elasticloadbalancingv2/listenerCertificate:ListenerCertificate", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ListenerCertificate{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *ListenerCertificate) URN() *pulumi.URNOutput {
	return r.s.URN
}

// ID is this resource's unique identifier assigned by its provider.
func (r *ListenerCertificate) ID() *pulumi.IDOutput {
	return r.s.ID
}

// The ARN of the certificate to attach to the listener.
func (r *ListenerCertificate) CertificateArn() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["certificateArn"])
}

// The ARN of the listener to which to attach the certificate.
func (r *ListenerCertificate) ListenerArn() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["listenerArn"])
}

// Input properties used for looking up and filtering ListenerCertificate resources.
type ListenerCertificateState struct {
	// The ARN of the certificate to attach to the listener.
	CertificateArn interface{}
	// The ARN of the listener to which to attach the certificate.
	ListenerArn interface{}
}

// The set of arguments for constructing a ListenerCertificate resource.
type ListenerCertificateArgs struct {
	// The ARN of the certificate to attach to the listener.
	CertificateArn interface{}
	// The ARN of the listener to which to attach the certificate.
	ListenerArn interface{}
}