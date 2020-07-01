// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package elb

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Attaches a load balancer policy to an ELB Listener.
//
// ## Example Usage
// ### Custom Policy
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/elb"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := elb.NewLoadBalancer(ctx, "wu_tang", &elb.LoadBalancerArgs{
// 			AvailabilityZones: pulumi.StringArray{
// 				pulumi.String("us-east-1a"),
// 			},
// 			Listeners: elb.LoadBalancerListenerArray{
// 				&elb.LoadBalancerListenerArgs{
// 					InstancePort:     pulumi.Int(443),
// 					InstanceProtocol: pulumi.String("http"),
// 					LbPort:           pulumi.Int(443),
// 					LbProtocol:       pulumi.String("https"),
// 					SslCertificateId: pulumi.String("arn:aws:iam::000000000000:server-certificate/wu-tang.net"),
// 				},
// 			},
// 			Tags: pulumi.StringMap{
// 				"Name": pulumi.String("wu-tang"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = elb.NewLoadBalancerPolicy(ctx, "wu_tang_ssl", &elb.LoadBalancerPolicyArgs{
// 			LoadBalancerName: wu_tang.Name,
// 			PolicyAttributes: elb.LoadBalancerPolicyPolicyAttributeArray{
// 				&elb.LoadBalancerPolicyPolicyAttributeArgs{
// 					Name:  pulumi.String("ECDHE-ECDSA-AES128-GCM-SHA256"),
// 					Value: pulumi.String("true"),
// 				},
// 				&elb.LoadBalancerPolicyPolicyAttributeArgs{
// 					Name:  pulumi.String("Protocol-TLSv1.2"),
// 					Value: pulumi.String("true"),
// 				},
// 			},
// 			PolicyName:     pulumi.String("wu-tang-ssl"),
// 			PolicyTypeName: pulumi.String("SSLNegotiationPolicyType"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = elb.NewListenerPolicy(ctx, "wu_tang_listener_policies_443", &elb.ListenerPolicyArgs{
// 			LoadBalancerName: wu_tang.Name,
// 			LoadBalancerPort: pulumi.Int(443),
// 			PolicyNames: pulumi.StringArray{
// 				wu_tang_ssl.PolicyName,
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
// This example shows how to customize the TLS settings of an HTTPS listener.
// ### AWS Predefined Security Policy
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/elb"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := elb.NewLoadBalancer(ctx, "wu_tang", &elb.LoadBalancerArgs{
// 			AvailabilityZones: pulumi.StringArray{
// 				pulumi.String("us-east-1a"),
// 			},
// 			Listeners: elb.LoadBalancerListenerArray{
// 				&elb.LoadBalancerListenerArgs{
// 					InstancePort:     pulumi.Int(443),
// 					InstanceProtocol: pulumi.String("http"),
// 					LbPort:           pulumi.Int(443),
// 					LbProtocol:       pulumi.String("https"),
// 					SslCertificateId: pulumi.String("arn:aws:iam::000000000000:server-certificate/wu-tang.net"),
// 				},
// 			},
// 			Tags: pulumi.StringMap{
// 				"Name": pulumi.String("wu-tang"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = elb.NewLoadBalancerPolicy(ctx, "wu_tang_ssl_tls_1_1", &elb.LoadBalancerPolicyArgs{
// 			LoadBalancerName: wu_tang.Name,
// 			PolicyAttributes: elb.LoadBalancerPolicyPolicyAttributeArray{
// 				&elb.LoadBalancerPolicyPolicyAttributeArgs{
// 					Name:  pulumi.String("Reference-Security-Policy"),
// 					Value: pulumi.String("ELBSecurityPolicy-TLS-1-1-2017-01"),
// 				},
// 			},
// 			PolicyName:     pulumi.String("wu-tang-ssl"),
// 			PolicyTypeName: pulumi.String("SSLNegotiationPolicyType"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = elb.NewListenerPolicy(ctx, "wu_tang_listener_policies_443", &elb.ListenerPolicyArgs{
// 			LoadBalancerName: wu_tang.Name,
// 			LoadBalancerPort: pulumi.Int(443),
// 			PolicyNames: pulumi.StringArray{
// 				wu_tang_ssl_tls_1_1.PolicyName,
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
// This example shows how to add a [Predefined Security Policy for ELBs](https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-security-policy-table.html)
type ListenerPolicy struct {
	pulumi.CustomResourceState

	// The load balancer to attach the policy to.
	LoadBalancerName pulumi.StringOutput `pulumi:"loadBalancerName"`
	// The load balancer listener port to apply the policy to.
	LoadBalancerPort pulumi.IntOutput `pulumi:"loadBalancerPort"`
	// List of Policy Names to apply to the backend server.
	PolicyNames pulumi.StringArrayOutput `pulumi:"policyNames"`
}

// NewListenerPolicy registers a new resource with the given unique name, arguments, and options.
func NewListenerPolicy(ctx *pulumi.Context,
	name string, args *ListenerPolicyArgs, opts ...pulumi.ResourceOption) (*ListenerPolicy, error) {
	if args == nil || args.LoadBalancerName == nil {
		return nil, errors.New("missing required argument 'LoadBalancerName'")
	}
	if args == nil || args.LoadBalancerPort == nil {
		return nil, errors.New("missing required argument 'LoadBalancerPort'")
	}
	if args == nil {
		args = &ListenerPolicyArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("aws:elasticloadbalancing/listenerPolicy:ListenerPolicy"),
		},
	})
	opts = append(opts, aliases)
	var resource ListenerPolicy
	err := ctx.RegisterResource("aws:elb/listenerPolicy:ListenerPolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetListenerPolicy gets an existing ListenerPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetListenerPolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ListenerPolicyState, opts ...pulumi.ResourceOption) (*ListenerPolicy, error) {
	var resource ListenerPolicy
	err := ctx.ReadResource("aws:elb/listenerPolicy:ListenerPolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ListenerPolicy resources.
type listenerPolicyState struct {
	// The load balancer to attach the policy to.
	LoadBalancerName *string `pulumi:"loadBalancerName"`
	// The load balancer listener port to apply the policy to.
	LoadBalancerPort *int `pulumi:"loadBalancerPort"`
	// List of Policy Names to apply to the backend server.
	PolicyNames []string `pulumi:"policyNames"`
}

type ListenerPolicyState struct {
	// The load balancer to attach the policy to.
	LoadBalancerName pulumi.StringPtrInput
	// The load balancer listener port to apply the policy to.
	LoadBalancerPort pulumi.IntPtrInput
	// List of Policy Names to apply to the backend server.
	PolicyNames pulumi.StringArrayInput
}

func (ListenerPolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*listenerPolicyState)(nil)).Elem()
}

type listenerPolicyArgs struct {
	// The load balancer to attach the policy to.
	LoadBalancerName string `pulumi:"loadBalancerName"`
	// The load balancer listener port to apply the policy to.
	LoadBalancerPort int `pulumi:"loadBalancerPort"`
	// List of Policy Names to apply to the backend server.
	PolicyNames []string `pulumi:"policyNames"`
}

// The set of arguments for constructing a ListenerPolicy resource.
type ListenerPolicyArgs struct {
	// The load balancer to attach the policy to.
	LoadBalancerName pulumi.StringInput
	// The load balancer listener port to apply the policy to.
	LoadBalancerPort pulumi.IntInput
	// List of Policy Names to apply to the backend server.
	PolicyNames pulumi.StringArrayInput
}

func (ListenerPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*listenerPolicyArgs)(nil)).Elem()
}
