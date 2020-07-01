// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package eks

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages an EKS Node Group, which can provision and optionally update an Auto Scaling Group of Kubernetes worker nodes compatible with EKS. Additional documentation about this functionality can be found in the [EKS User Guide](https://docs.aws.amazon.com/eks/latest/userguide/managed-node-groups.html).
//
// ## Example Usage
// ### Ignoring Changes to Desired Size
//
// You can utilize [ignoreChanges](https://www.pulumi.com/docs/intro/concepts/programming-model/#ignorechanges) create an EKS Node Group with an initial size of running instances, then ignore any changes to that count caused externally (e.g. Application Autoscaling).
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/eks"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := eks.NewNodeGroup(ctx, "example", &eks.NodeGroupArgs{
// 			ScalingConfig: &eks.NodeGroupScalingConfigArgs{
// 				DesiredSize: pulumi.Int(2),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
// ### Example IAM Role for EKS Node Group
//
// ```go
// package main
//
// import (
// 	"encoding/json"
//
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/iam"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		tmpJSON0, err := json.Marshal(map[string]interface{}{
// 			"Statement": []map[string]interface{}{
// 				map[string]interface{}{
// 					"Action": "sts:AssumeRole",
// 					"Effect": "Allow",
// 					"Principal": map[string]interface{}{
// 						"Service": "ec2.amazonaws.com",
// 					},
// 				},
// 			},
// 			"Version": "2012-10-17",
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		json0 := string(tmpJSON0)
// 		example, err := iam.NewRole(ctx, "example", &iam.RoleArgs{
// 			AssumeRolePolicy: pulumi.String(json0),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = iam.NewRolePolicyAttachment(ctx, "example_AmazonEKSWorkerNodePolicy", &iam.RolePolicyAttachmentArgs{
// 			PolicyArn: pulumi.String("arn:aws:iam::aws:policy/AmazonEKSWorkerNodePolicy"),
// 			Role:      example.Name,
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = iam.NewRolePolicyAttachment(ctx, "example_AmazonEKSCNIPolicy", &iam.RolePolicyAttachmentArgs{
// 			PolicyArn: pulumi.String("arn:aws:iam::aws:policy/AmazonEKS_CNI_Policy"),
// 			Role:      example.Name,
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = iam.NewRolePolicyAttachment(ctx, "example_AmazonEC2ContainerRegistryReadOnly", &iam.RolePolicyAttachmentArgs{
// 			PolicyArn: pulumi.String("arn:aws:iam::aws:policy/AmazonEC2ContainerRegistryReadOnly"),
// 			Role:      example.Name,
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type NodeGroup struct {
	pulumi.CustomResourceState

	// Type of Amazon Machine Image (AMI) associated with the EKS Node Group. Defaults to `AL2_x86_64`. Valid values: `AL2_x86_64`, `AL2_x86_64_GPU`. This provider will only perform drift detection if a configuration value is provided.
	AmiType pulumi.StringOutput `pulumi:"amiType"`
	// Amazon Resource Name (ARN) of the EKS Node Group.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// Name of the EKS Cluster.
	ClusterName pulumi.StringOutput `pulumi:"clusterName"`
	// Disk size in GiB for worker nodes. Defaults to `20`. This provider will only perform drift detection if a configuration value is provided.
	DiskSize pulumi.IntOutput `pulumi:"diskSize"`
	// Force version update if existing pods are unable to be drained due to a pod disruption budget issue.
	ForceUpdateVersion pulumi.BoolPtrOutput `pulumi:"forceUpdateVersion"`
	// Set of instance types associated with the EKS Node Group. Defaults to `["t3.medium"]`. This provider will only perform drift detection if a configuration value is provided. Currently, the EKS API only accepts a single value in the set.
	InstanceTypes pulumi.StringOutput `pulumi:"instanceTypes"`
	// Key-value map of Kubernetes labels. Only labels that are applied with the EKS API are managed by this argument. Other Kubernetes labels applied to the EKS Node Group will not be managed.
	Labels pulumi.StringMapOutput `pulumi:"labels"`
	// Name of the EKS Node Group.
	NodeGroupName pulumi.StringOutput `pulumi:"nodeGroupName"`
	// Amazon Resource Name (ARN) of the IAM Role that provides permissions for the EKS Node Group.
	NodeRoleArn pulumi.StringOutput `pulumi:"nodeRoleArn"`
	// AMI version of the EKS Node Group. Defaults to latest version for Kubernetes version.
	ReleaseVersion pulumi.StringOutput `pulumi:"releaseVersion"`
	// Configuration block with remote access settings. Detailed below.
	RemoteAccess NodeGroupRemoteAccessPtrOutput `pulumi:"remoteAccess"`
	// List of objects containing information about underlying resources.
	Resources NodeGroupResourceArrayOutput `pulumi:"resources"`
	// Configuration block with scaling settings. Detailed below.
	ScalingConfig NodeGroupScalingConfigOutput `pulumi:"scalingConfig"`
	// Status of the EKS Node Group.
	Status pulumi.StringOutput `pulumi:"status"`
	// Identifiers of EC2 Subnets to associate with the EKS Node Group. These subnets must have the following resource tag: `kubernetes.io/cluster/CLUSTER_NAME` (where `CLUSTER_NAME` is replaced with the name of the EKS Cluster).
	SubnetIds pulumi.StringArrayOutput `pulumi:"subnetIds"`
	// Key-value mapping of resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Kubernetes version. Defaults to EKS Cluster Kubernetes version. This provider will only perform drift detection if a configuration value is provided.
	Version pulumi.StringOutput `pulumi:"version"`
}

// NewNodeGroup registers a new resource with the given unique name, arguments, and options.
func NewNodeGroup(ctx *pulumi.Context,
	name string, args *NodeGroupArgs, opts ...pulumi.ResourceOption) (*NodeGroup, error) {
	if args == nil || args.ClusterName == nil {
		return nil, errors.New("missing required argument 'ClusterName'")
	}
	if args == nil || args.NodeRoleArn == nil {
		return nil, errors.New("missing required argument 'NodeRoleArn'")
	}
	if args == nil || args.ScalingConfig == nil {
		return nil, errors.New("missing required argument 'ScalingConfig'")
	}
	if args == nil || args.SubnetIds == nil {
		return nil, errors.New("missing required argument 'SubnetIds'")
	}
	if args == nil {
		args = &NodeGroupArgs{}
	}
	var resource NodeGroup
	err := ctx.RegisterResource("aws:eks/nodeGroup:NodeGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNodeGroup gets an existing NodeGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNodeGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NodeGroupState, opts ...pulumi.ResourceOption) (*NodeGroup, error) {
	var resource NodeGroup
	err := ctx.ReadResource("aws:eks/nodeGroup:NodeGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NodeGroup resources.
type nodeGroupState struct {
	// Type of Amazon Machine Image (AMI) associated with the EKS Node Group. Defaults to `AL2_x86_64`. Valid values: `AL2_x86_64`, `AL2_x86_64_GPU`. This provider will only perform drift detection if a configuration value is provided.
	AmiType *string `pulumi:"amiType"`
	// Amazon Resource Name (ARN) of the EKS Node Group.
	Arn *string `pulumi:"arn"`
	// Name of the EKS Cluster.
	ClusterName *string `pulumi:"clusterName"`
	// Disk size in GiB for worker nodes. Defaults to `20`. This provider will only perform drift detection if a configuration value is provided.
	DiskSize *int `pulumi:"diskSize"`
	// Force version update if existing pods are unable to be drained due to a pod disruption budget issue.
	ForceUpdateVersion *bool `pulumi:"forceUpdateVersion"`
	// Set of instance types associated with the EKS Node Group. Defaults to `["t3.medium"]`. This provider will only perform drift detection if a configuration value is provided. Currently, the EKS API only accepts a single value in the set.
	InstanceTypes *string `pulumi:"instanceTypes"`
	// Key-value map of Kubernetes labels. Only labels that are applied with the EKS API are managed by this argument. Other Kubernetes labels applied to the EKS Node Group will not be managed.
	Labels map[string]string `pulumi:"labels"`
	// Name of the EKS Node Group.
	NodeGroupName *string `pulumi:"nodeGroupName"`
	// Amazon Resource Name (ARN) of the IAM Role that provides permissions for the EKS Node Group.
	NodeRoleArn *string `pulumi:"nodeRoleArn"`
	// AMI version of the EKS Node Group. Defaults to latest version for Kubernetes version.
	ReleaseVersion *string `pulumi:"releaseVersion"`
	// Configuration block with remote access settings. Detailed below.
	RemoteAccess *NodeGroupRemoteAccess `pulumi:"remoteAccess"`
	// List of objects containing information about underlying resources.
	Resources []NodeGroupResource `pulumi:"resources"`
	// Configuration block with scaling settings. Detailed below.
	ScalingConfig *NodeGroupScalingConfig `pulumi:"scalingConfig"`
	// Status of the EKS Node Group.
	Status *string `pulumi:"status"`
	// Identifiers of EC2 Subnets to associate with the EKS Node Group. These subnets must have the following resource tag: `kubernetes.io/cluster/CLUSTER_NAME` (where `CLUSTER_NAME` is replaced with the name of the EKS Cluster).
	SubnetIds []string `pulumi:"subnetIds"`
	// Key-value mapping of resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Kubernetes version. Defaults to EKS Cluster Kubernetes version. This provider will only perform drift detection if a configuration value is provided.
	Version *string `pulumi:"version"`
}

type NodeGroupState struct {
	// Type of Amazon Machine Image (AMI) associated with the EKS Node Group. Defaults to `AL2_x86_64`. Valid values: `AL2_x86_64`, `AL2_x86_64_GPU`. This provider will only perform drift detection if a configuration value is provided.
	AmiType pulumi.StringPtrInput
	// Amazon Resource Name (ARN) of the EKS Node Group.
	Arn pulumi.StringPtrInput
	// Name of the EKS Cluster.
	ClusterName pulumi.StringPtrInput
	// Disk size in GiB for worker nodes. Defaults to `20`. This provider will only perform drift detection if a configuration value is provided.
	DiskSize pulumi.IntPtrInput
	// Force version update if existing pods are unable to be drained due to a pod disruption budget issue.
	ForceUpdateVersion pulumi.BoolPtrInput
	// Set of instance types associated with the EKS Node Group. Defaults to `["t3.medium"]`. This provider will only perform drift detection if a configuration value is provided. Currently, the EKS API only accepts a single value in the set.
	InstanceTypes pulumi.StringPtrInput
	// Key-value map of Kubernetes labels. Only labels that are applied with the EKS API are managed by this argument. Other Kubernetes labels applied to the EKS Node Group will not be managed.
	Labels pulumi.StringMapInput
	// Name of the EKS Node Group.
	NodeGroupName pulumi.StringPtrInput
	// Amazon Resource Name (ARN) of the IAM Role that provides permissions for the EKS Node Group.
	NodeRoleArn pulumi.StringPtrInput
	// AMI version of the EKS Node Group. Defaults to latest version for Kubernetes version.
	ReleaseVersion pulumi.StringPtrInput
	// Configuration block with remote access settings. Detailed below.
	RemoteAccess NodeGroupRemoteAccessPtrInput
	// List of objects containing information about underlying resources.
	Resources NodeGroupResourceArrayInput
	// Configuration block with scaling settings. Detailed below.
	ScalingConfig NodeGroupScalingConfigPtrInput
	// Status of the EKS Node Group.
	Status pulumi.StringPtrInput
	// Identifiers of EC2 Subnets to associate with the EKS Node Group. These subnets must have the following resource tag: `kubernetes.io/cluster/CLUSTER_NAME` (where `CLUSTER_NAME` is replaced with the name of the EKS Cluster).
	SubnetIds pulumi.StringArrayInput
	// Key-value mapping of resource tags.
	Tags pulumi.StringMapInput
	// Kubernetes version. Defaults to EKS Cluster Kubernetes version. This provider will only perform drift detection if a configuration value is provided.
	Version pulumi.StringPtrInput
}

func (NodeGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*nodeGroupState)(nil)).Elem()
}

type nodeGroupArgs struct {
	// Type of Amazon Machine Image (AMI) associated with the EKS Node Group. Defaults to `AL2_x86_64`. Valid values: `AL2_x86_64`, `AL2_x86_64_GPU`. This provider will only perform drift detection if a configuration value is provided.
	AmiType *string `pulumi:"amiType"`
	// Name of the EKS Cluster.
	ClusterName string `pulumi:"clusterName"`
	// Disk size in GiB for worker nodes. Defaults to `20`. This provider will only perform drift detection if a configuration value is provided.
	DiskSize *int `pulumi:"diskSize"`
	// Force version update if existing pods are unable to be drained due to a pod disruption budget issue.
	ForceUpdateVersion *bool `pulumi:"forceUpdateVersion"`
	// Set of instance types associated with the EKS Node Group. Defaults to `["t3.medium"]`. This provider will only perform drift detection if a configuration value is provided. Currently, the EKS API only accepts a single value in the set.
	InstanceTypes *string `pulumi:"instanceTypes"`
	// Key-value map of Kubernetes labels. Only labels that are applied with the EKS API are managed by this argument. Other Kubernetes labels applied to the EKS Node Group will not be managed.
	Labels map[string]string `pulumi:"labels"`
	// Name of the EKS Node Group.
	NodeGroupName *string `pulumi:"nodeGroupName"`
	// Amazon Resource Name (ARN) of the IAM Role that provides permissions for the EKS Node Group.
	NodeRoleArn string `pulumi:"nodeRoleArn"`
	// AMI version of the EKS Node Group. Defaults to latest version for Kubernetes version.
	ReleaseVersion *string `pulumi:"releaseVersion"`
	// Configuration block with remote access settings. Detailed below.
	RemoteAccess *NodeGroupRemoteAccess `pulumi:"remoteAccess"`
	// Configuration block with scaling settings. Detailed below.
	ScalingConfig NodeGroupScalingConfig `pulumi:"scalingConfig"`
	// Identifiers of EC2 Subnets to associate with the EKS Node Group. These subnets must have the following resource tag: `kubernetes.io/cluster/CLUSTER_NAME` (where `CLUSTER_NAME` is replaced with the name of the EKS Cluster).
	SubnetIds []string `pulumi:"subnetIds"`
	// Key-value mapping of resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Kubernetes version. Defaults to EKS Cluster Kubernetes version. This provider will only perform drift detection if a configuration value is provided.
	Version *string `pulumi:"version"`
}

// The set of arguments for constructing a NodeGroup resource.
type NodeGroupArgs struct {
	// Type of Amazon Machine Image (AMI) associated with the EKS Node Group. Defaults to `AL2_x86_64`. Valid values: `AL2_x86_64`, `AL2_x86_64_GPU`. This provider will only perform drift detection if a configuration value is provided.
	AmiType pulumi.StringPtrInput
	// Name of the EKS Cluster.
	ClusterName pulumi.StringInput
	// Disk size in GiB for worker nodes. Defaults to `20`. This provider will only perform drift detection if a configuration value is provided.
	DiskSize pulumi.IntPtrInput
	// Force version update if existing pods are unable to be drained due to a pod disruption budget issue.
	ForceUpdateVersion pulumi.BoolPtrInput
	// Set of instance types associated with the EKS Node Group. Defaults to `["t3.medium"]`. This provider will only perform drift detection if a configuration value is provided. Currently, the EKS API only accepts a single value in the set.
	InstanceTypes pulumi.StringPtrInput
	// Key-value map of Kubernetes labels. Only labels that are applied with the EKS API are managed by this argument. Other Kubernetes labels applied to the EKS Node Group will not be managed.
	Labels pulumi.StringMapInput
	// Name of the EKS Node Group.
	NodeGroupName pulumi.StringPtrInput
	// Amazon Resource Name (ARN) of the IAM Role that provides permissions for the EKS Node Group.
	NodeRoleArn pulumi.StringInput
	// AMI version of the EKS Node Group. Defaults to latest version for Kubernetes version.
	ReleaseVersion pulumi.StringPtrInput
	// Configuration block with remote access settings. Detailed below.
	RemoteAccess NodeGroupRemoteAccessPtrInput
	// Configuration block with scaling settings. Detailed below.
	ScalingConfig NodeGroupScalingConfigInput
	// Identifiers of EC2 Subnets to associate with the EKS Node Group. These subnets must have the following resource tag: `kubernetes.io/cluster/CLUSTER_NAME` (where `CLUSTER_NAME` is replaced with the name of the EKS Cluster).
	SubnetIds pulumi.StringArrayInput
	// Key-value mapping of resource tags.
	Tags pulumi.StringMapInput
	// Kubernetes version. Defaults to EKS Cluster Kubernetes version. This provider will only perform drift detection if a configuration value is provided.
	Version pulumi.StringPtrInput
}

func (NodeGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*nodeGroupArgs)(nil)).Elem()
}
