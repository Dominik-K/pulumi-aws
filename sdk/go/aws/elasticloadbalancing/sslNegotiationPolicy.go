// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package elasticloadbalancing

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a load balancer SSL negotiation policy, which allows an ELB to control the ciphers and protocols that are supported during SSL negotiations between a client and a load balancer.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/elb"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		lb, err := elb.NewLoadBalancer(ctx, "lb", &elb.LoadBalancerArgs{
// 			AvailabilityZones: pulumi.StringArray{
// 				pulumi.String("us-east-1a"),
// 			},
// 			Listeners: elb.LoadBalancerListenerArray{
// 				&elb.LoadBalancerListenerArgs{
// 					InstancePort:     pulumi.Int(8000),
// 					InstanceProtocol: pulumi.String("https"),
// 					LbPort:           pulumi.Int(443),
// 					LbProtocol:       pulumi.String("https"),
// 					SslCertificateId: pulumi.String("arn:aws:iam::123456789012:server-certificate/certName"),
// 				},
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = elb.NewSslNegotiationPolicy(ctx, "foo", &elb.SslNegotiationPolicyArgs{
// 			LoadBalancer: lb.ID(),
// 			LbPort:       pulumi.Int(443),
// 			Attributes: elb.SslNegotiationPolicyAttributeArray{
// 				&elb.SslNegotiationPolicyAttributeArgs{
// 					Name:  pulumi.String("Protocol-TLSv1"),
// 					Value: pulumi.String("false"),
// 				},
// 				&elb.SslNegotiationPolicyAttributeArgs{
// 					Name:  pulumi.String("Protocol-TLSv1.1"),
// 					Value: pulumi.String("false"),
// 				},
// 				&elb.SslNegotiationPolicyAttributeArgs{
// 					Name:  pulumi.String("Protocol-TLSv1.2"),
// 					Value: pulumi.String("true"),
// 				},
// 				&elb.SslNegotiationPolicyAttributeArgs{
// 					Name:  pulumi.String("Server-Defined-Cipher-Order"),
// 					Value: pulumi.String("true"),
// 				},
// 				&elb.SslNegotiationPolicyAttributeArgs{
// 					Name:  pulumi.String("ECDHE-RSA-AES128-GCM-SHA256"),
// 					Value: pulumi.String("true"),
// 				},
// 				&elb.SslNegotiationPolicyAttributeArgs{
// 					Name:  pulumi.String("AES128-GCM-SHA256"),
// 					Value: pulumi.String("true"),
// 				},
// 				&elb.SslNegotiationPolicyAttributeArgs{
// 					Name:  pulumi.String("EDH-RSA-DES-CBC3-SHA"),
// 					Value: pulumi.String("false"),
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
//
// Deprecated: aws.elasticloadbalancing.SslNegotiationPolicy has been deprecated in favor of aws.elb.SslNegotiationPolicy
type SslNegotiationPolicy struct {
	pulumi.CustomResourceState

	// An SSL Negotiation policy attribute. Each has two properties:
	Attributes SslNegotiationPolicyAttributeArrayOutput `pulumi:"attributes"`
	// The load balancer port to which the policy
	// should be applied. This must be an active listener on the load
	// balancer.
	LbPort pulumi.IntOutput `pulumi:"lbPort"`
	// The load balancer to which the policy
	// should be attached.
	LoadBalancer pulumi.StringOutput `pulumi:"loadBalancer"`
	// The name of the attribute
	Name pulumi.StringOutput `pulumi:"name"`
}

// NewSslNegotiationPolicy registers a new resource with the given unique name, arguments, and options.
func NewSslNegotiationPolicy(ctx *pulumi.Context,
	name string, args *SslNegotiationPolicyArgs, opts ...pulumi.ResourceOption) (*SslNegotiationPolicy, error) {
	if args == nil || args.LbPort == nil {
		return nil, errors.New("missing required argument 'LbPort'")
	}
	if args == nil || args.LoadBalancer == nil {
		return nil, errors.New("missing required argument 'LoadBalancer'")
	}
	if args == nil {
		args = &SslNegotiationPolicyArgs{}
	}
	var resource SslNegotiationPolicy
	err := ctx.RegisterResource("aws:elasticloadbalancing/sslNegotiationPolicy:SslNegotiationPolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSslNegotiationPolicy gets an existing SslNegotiationPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSslNegotiationPolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SslNegotiationPolicyState, opts ...pulumi.ResourceOption) (*SslNegotiationPolicy, error) {
	var resource SslNegotiationPolicy
	err := ctx.ReadResource("aws:elasticloadbalancing/sslNegotiationPolicy:SslNegotiationPolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SslNegotiationPolicy resources.
type sslNegotiationPolicyState struct {
	// An SSL Negotiation policy attribute. Each has two properties:
	Attributes []SslNegotiationPolicyAttribute `pulumi:"attributes"`
	// The load balancer port to which the policy
	// should be applied. This must be an active listener on the load
	// balancer.
	LbPort *int `pulumi:"lbPort"`
	// The load balancer to which the policy
	// should be attached.
	LoadBalancer *string `pulumi:"loadBalancer"`
	// The name of the attribute
	Name *string `pulumi:"name"`
}

type SslNegotiationPolicyState struct {
	// An SSL Negotiation policy attribute. Each has two properties:
	Attributes SslNegotiationPolicyAttributeArrayInput
	// The load balancer port to which the policy
	// should be applied. This must be an active listener on the load
	// balancer.
	LbPort pulumi.IntPtrInput
	// The load balancer to which the policy
	// should be attached.
	LoadBalancer pulumi.StringPtrInput
	// The name of the attribute
	Name pulumi.StringPtrInput
}

func (SslNegotiationPolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*sslNegotiationPolicyState)(nil)).Elem()
}

type sslNegotiationPolicyArgs struct {
	// An SSL Negotiation policy attribute. Each has two properties:
	Attributes []SslNegotiationPolicyAttribute `pulumi:"attributes"`
	// The load balancer port to which the policy
	// should be applied. This must be an active listener on the load
	// balancer.
	LbPort int `pulumi:"lbPort"`
	// The load balancer to which the policy
	// should be attached.
	LoadBalancer string `pulumi:"loadBalancer"`
	// The name of the attribute
	Name *string `pulumi:"name"`
}

// The set of arguments for constructing a SslNegotiationPolicy resource.
type SslNegotiationPolicyArgs struct {
	// An SSL Negotiation policy attribute. Each has two properties:
	Attributes SslNegotiationPolicyAttributeArrayInput
	// The load balancer port to which the policy
	// should be applied. This must be an active listener on the load
	// balancer.
	LbPort pulumi.IntInput
	// The load balancer to which the policy
	// should be attached.
	LoadBalancer pulumi.StringInput
	// The name of the attribute
	Name pulumi.StringPtrInput
}

func (SslNegotiationPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*sslNegotiationPolicyArgs)(nil)).Elem()
}
