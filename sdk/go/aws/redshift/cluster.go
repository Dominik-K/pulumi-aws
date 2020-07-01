// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package redshift

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Redshift Cluster Resource.
//
// > **Note:** All arguments including the username and password will be stored in the raw state as plain-text.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v2/go/aws/redshift"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := redshift.NewCluster(ctx, "_default", &redshift.ClusterArgs{
// 			ClusterIdentifier: pulumi.String("tf-redshift-cluster"),
// 			ClusterType:       pulumi.String("single-node"),
// 			DatabaseName:      pulumi.String("mydb"),
// 			MasterPassword:    pulumi.String("Mustbe8characters"),
// 			MasterUsername:    pulumi.String("foo"),
// 			NodeType:          pulumi.String("dc1.large"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type Cluster struct {
	pulumi.CustomResourceState

	// If true , major version upgrades can be applied during the maintenance window to the Amazon Redshift engine that is running on the cluster. Default is true
	AllowVersionUpgrade pulumi.BoolPtrOutput `pulumi:"allowVersionUpgrade"`
	// Amazon Resource Name (ARN) of cluster
	Arn pulumi.StringOutput `pulumi:"arn"`
	// The number of days that automated snapshots are retained. If the value is 0, automated snapshots are disabled. Even if automated snapshots are disabled, you can still create manual snapshots when you want with create-cluster-snapshot. Default is 1.
	AutomatedSnapshotRetentionPeriod pulumi.IntPtrOutput `pulumi:"automatedSnapshotRetentionPeriod"`
	// The EC2 Availability Zone (AZ) in which you want Amazon Redshift to provision the cluster. For example, if you have several EC2 instances running in a specific Availability Zone, then you might want the cluster to be provisioned in the same zone in order to decrease network latency.
	AvailabilityZone pulumi.StringOutput `pulumi:"availabilityZone"`
	// The Cluster Identifier. Must be a lower case
	// string.
	ClusterIdentifier pulumi.StringOutput `pulumi:"clusterIdentifier"`
	// The name of the parameter group to be associated with this cluster.
	ClusterParameterGroupName pulumi.StringOutput `pulumi:"clusterParameterGroupName"`
	// The public key for the cluster
	ClusterPublicKey pulumi.StringOutput `pulumi:"clusterPublicKey"`
	// The specific revision number of the database in the cluster
	ClusterRevisionNumber pulumi.StringOutput `pulumi:"clusterRevisionNumber"`
	// A list of security groups to be associated with this cluster.
	ClusterSecurityGroups pulumi.StringArrayOutput `pulumi:"clusterSecurityGroups"`
	// The name of a cluster subnet group to be associated with this cluster. If this parameter is not provided the resulting cluster will be deployed outside virtual private cloud (VPC).
	ClusterSubnetGroupName pulumi.StringOutput `pulumi:"clusterSubnetGroupName"`
	// The cluster type to use. Either `single-node` or `multi-node`.
	ClusterType pulumi.StringOutput `pulumi:"clusterType"`
	// The version of the Amazon Redshift engine software that you want to deploy on the cluster.
	// The version selected runs on all the nodes in the cluster.
	ClusterVersion pulumi.StringPtrOutput `pulumi:"clusterVersion"`
	// The name of the first database to be created when the cluster is created.
	// If you do not provide a name, Amazon Redshift will create a default database called `dev`.
	DatabaseName pulumi.StringOutput `pulumi:"databaseName"`
	// The DNS name of the cluster
	DnsName pulumi.StringOutput `pulumi:"dnsName"`
	// The Elastic IP (EIP) address for the cluster.
	ElasticIp pulumi.StringPtrOutput `pulumi:"elasticIp"`
	// If true , the data in the cluster is encrypted at rest.
	Encrypted pulumi.BoolPtrOutput `pulumi:"encrypted"`
	// The connection endpoint
	Endpoint pulumi.StringOutput `pulumi:"endpoint"`
	// If true , enhanced VPC routing is enabled.
	EnhancedVpcRouting pulumi.BoolOutput `pulumi:"enhancedVpcRouting"`
	// The identifier of the final snapshot that is to be created immediately before deleting the cluster. If this parameter is provided, `skipFinalSnapshot` must be false.
	FinalSnapshotIdentifier pulumi.StringPtrOutput `pulumi:"finalSnapshotIdentifier"`
	// A list of IAM Role ARNs to associate with the cluster. A Maximum of 10 can be associated to the cluster at any time.
	IamRoles pulumi.StringArrayOutput `pulumi:"iamRoles"`
	// The ARN for the KMS encryption key. When specifying `kmsKeyId`, `encrypted` needs to be set to true.
	KmsKeyId pulumi.StringOutput `pulumi:"kmsKeyId"`
	// Logging, documented below.
	Logging ClusterLoggingPtrOutput `pulumi:"logging"`
	// Password for the master DB user.
	// Note that this may show up in logs, and it will be stored in the state file. Password must contain at least 8 chars and
	// contain at least one uppercase letter, one lowercase letter, and one number.
	MasterPassword pulumi.StringPtrOutput `pulumi:"masterPassword"`
	// Username for the master DB user.
	MasterUsername pulumi.StringPtrOutput `pulumi:"masterUsername"`
	// The node type to be provisioned for the cluster.
	NodeType pulumi.StringOutput `pulumi:"nodeType"`
	// The number of compute nodes in the cluster. This parameter is required when the ClusterType parameter is specified as multi-node. Default is 1.
	NumberOfNodes pulumi.IntPtrOutput `pulumi:"numberOfNodes"`
	// The AWS customer account used to create or copy the snapshot. Required if you are restoring a snapshot you do not own, optional if you own the snapshot.
	OwnerAccount pulumi.StringPtrOutput `pulumi:"ownerAccount"`
	// The port number on which the cluster accepts incoming connections.
	// The cluster is accessible only via the JDBC and ODBC connection strings. Part of the connection string requires the port on which the cluster will listen for incoming connections. Default port is 5439.
	Port pulumi.IntPtrOutput `pulumi:"port"`
	// The weekly time range (in UTC) during which automated cluster maintenance can occur.
	// Format: ddd:hh24:mi-ddd:hh24:mi
	PreferredMaintenanceWindow pulumi.StringOutput `pulumi:"preferredMaintenanceWindow"`
	// If true, the cluster can be accessed from a public network. Default is `true`.
	PubliclyAccessible pulumi.BoolPtrOutput `pulumi:"publiclyAccessible"`
	// Determines whether a final snapshot of the cluster is created before Amazon Redshift deletes the cluster. If true , a final cluster snapshot is not created. If false , a final cluster snapshot is created before the cluster is deleted. Default is false.
	SkipFinalSnapshot pulumi.BoolPtrOutput `pulumi:"skipFinalSnapshot"`
	// The name of the cluster the source snapshot was created from.
	SnapshotClusterIdentifier pulumi.StringPtrOutput `pulumi:"snapshotClusterIdentifier"`
	// Configuration of automatic copy of snapshots from one region to another. Documented below.
	SnapshotCopy ClusterSnapshotCopyPtrOutput `pulumi:"snapshotCopy"`
	// The name of the snapshot from which to create the new cluster.
	SnapshotIdentifier pulumi.StringPtrOutput `pulumi:"snapshotIdentifier"`
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// A list of Virtual Private Cloud (VPC) security groups to be associated with the cluster.
	VpcSecurityGroupIds pulumi.StringArrayOutput `pulumi:"vpcSecurityGroupIds"`
}

// NewCluster registers a new resource with the given unique name, arguments, and options.
func NewCluster(ctx *pulumi.Context,
	name string, args *ClusterArgs, opts ...pulumi.ResourceOption) (*Cluster, error) {
	if args == nil || args.ClusterIdentifier == nil {
		return nil, errors.New("missing required argument 'ClusterIdentifier'")
	}
	if args == nil || args.NodeType == nil {
		return nil, errors.New("missing required argument 'NodeType'")
	}
	if args == nil {
		args = &ClusterArgs{}
	}
	var resource Cluster
	err := ctx.RegisterResource("aws:redshift/cluster:Cluster", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCluster gets an existing Cluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCluster(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ClusterState, opts ...pulumi.ResourceOption) (*Cluster, error) {
	var resource Cluster
	err := ctx.ReadResource("aws:redshift/cluster:Cluster", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Cluster resources.
type clusterState struct {
	// If true , major version upgrades can be applied during the maintenance window to the Amazon Redshift engine that is running on the cluster. Default is true
	AllowVersionUpgrade *bool `pulumi:"allowVersionUpgrade"`
	// Amazon Resource Name (ARN) of cluster
	Arn *string `pulumi:"arn"`
	// The number of days that automated snapshots are retained. If the value is 0, automated snapshots are disabled. Even if automated snapshots are disabled, you can still create manual snapshots when you want with create-cluster-snapshot. Default is 1.
	AutomatedSnapshotRetentionPeriod *int `pulumi:"automatedSnapshotRetentionPeriod"`
	// The EC2 Availability Zone (AZ) in which you want Amazon Redshift to provision the cluster. For example, if you have several EC2 instances running in a specific Availability Zone, then you might want the cluster to be provisioned in the same zone in order to decrease network latency.
	AvailabilityZone *string `pulumi:"availabilityZone"`
	// The Cluster Identifier. Must be a lower case
	// string.
	ClusterIdentifier *string `pulumi:"clusterIdentifier"`
	// The name of the parameter group to be associated with this cluster.
	ClusterParameterGroupName *string `pulumi:"clusterParameterGroupName"`
	// The public key for the cluster
	ClusterPublicKey *string `pulumi:"clusterPublicKey"`
	// The specific revision number of the database in the cluster
	ClusterRevisionNumber *string `pulumi:"clusterRevisionNumber"`
	// A list of security groups to be associated with this cluster.
	ClusterSecurityGroups []string `pulumi:"clusterSecurityGroups"`
	// The name of a cluster subnet group to be associated with this cluster. If this parameter is not provided the resulting cluster will be deployed outside virtual private cloud (VPC).
	ClusterSubnetGroupName *string `pulumi:"clusterSubnetGroupName"`
	// The cluster type to use. Either `single-node` or `multi-node`.
	ClusterType *string `pulumi:"clusterType"`
	// The version of the Amazon Redshift engine software that you want to deploy on the cluster.
	// The version selected runs on all the nodes in the cluster.
	ClusterVersion *string `pulumi:"clusterVersion"`
	// The name of the first database to be created when the cluster is created.
	// If you do not provide a name, Amazon Redshift will create a default database called `dev`.
	DatabaseName *string `pulumi:"databaseName"`
	// The DNS name of the cluster
	DnsName *string `pulumi:"dnsName"`
	// The Elastic IP (EIP) address for the cluster.
	ElasticIp *string `pulumi:"elasticIp"`
	// If true , the data in the cluster is encrypted at rest.
	Encrypted *bool `pulumi:"encrypted"`
	// The connection endpoint
	Endpoint *string `pulumi:"endpoint"`
	// If true , enhanced VPC routing is enabled.
	EnhancedVpcRouting *bool `pulumi:"enhancedVpcRouting"`
	// The identifier of the final snapshot that is to be created immediately before deleting the cluster. If this parameter is provided, `skipFinalSnapshot` must be false.
	FinalSnapshotIdentifier *string `pulumi:"finalSnapshotIdentifier"`
	// A list of IAM Role ARNs to associate with the cluster. A Maximum of 10 can be associated to the cluster at any time.
	IamRoles []string `pulumi:"iamRoles"`
	// The ARN for the KMS encryption key. When specifying `kmsKeyId`, `encrypted` needs to be set to true.
	KmsKeyId *string `pulumi:"kmsKeyId"`
	// Logging, documented below.
	Logging *ClusterLogging `pulumi:"logging"`
	// Password for the master DB user.
	// Note that this may show up in logs, and it will be stored in the state file. Password must contain at least 8 chars and
	// contain at least one uppercase letter, one lowercase letter, and one number.
	MasterPassword *string `pulumi:"masterPassword"`
	// Username for the master DB user.
	MasterUsername *string `pulumi:"masterUsername"`
	// The node type to be provisioned for the cluster.
	NodeType *string `pulumi:"nodeType"`
	// The number of compute nodes in the cluster. This parameter is required when the ClusterType parameter is specified as multi-node. Default is 1.
	NumberOfNodes *int `pulumi:"numberOfNodes"`
	// The AWS customer account used to create or copy the snapshot. Required if you are restoring a snapshot you do not own, optional if you own the snapshot.
	OwnerAccount *string `pulumi:"ownerAccount"`
	// The port number on which the cluster accepts incoming connections.
	// The cluster is accessible only via the JDBC and ODBC connection strings. Part of the connection string requires the port on which the cluster will listen for incoming connections. Default port is 5439.
	Port *int `pulumi:"port"`
	// The weekly time range (in UTC) during which automated cluster maintenance can occur.
	// Format: ddd:hh24:mi-ddd:hh24:mi
	PreferredMaintenanceWindow *string `pulumi:"preferredMaintenanceWindow"`
	// If true, the cluster can be accessed from a public network. Default is `true`.
	PubliclyAccessible *bool `pulumi:"publiclyAccessible"`
	// Determines whether a final snapshot of the cluster is created before Amazon Redshift deletes the cluster. If true , a final cluster snapshot is not created. If false , a final cluster snapshot is created before the cluster is deleted. Default is false.
	SkipFinalSnapshot *bool `pulumi:"skipFinalSnapshot"`
	// The name of the cluster the source snapshot was created from.
	SnapshotClusterIdentifier *string `pulumi:"snapshotClusterIdentifier"`
	// Configuration of automatic copy of snapshots from one region to another. Documented below.
	SnapshotCopy *ClusterSnapshotCopy `pulumi:"snapshotCopy"`
	// The name of the snapshot from which to create the new cluster.
	SnapshotIdentifier *string `pulumi:"snapshotIdentifier"`
	// A map of tags to assign to the resource.
	Tags map[string]string `pulumi:"tags"`
	// A list of Virtual Private Cloud (VPC) security groups to be associated with the cluster.
	VpcSecurityGroupIds []string `pulumi:"vpcSecurityGroupIds"`
}

type ClusterState struct {
	// If true , major version upgrades can be applied during the maintenance window to the Amazon Redshift engine that is running on the cluster. Default is true
	AllowVersionUpgrade pulumi.BoolPtrInput
	// Amazon Resource Name (ARN) of cluster
	Arn pulumi.StringPtrInput
	// The number of days that automated snapshots are retained. If the value is 0, automated snapshots are disabled. Even if automated snapshots are disabled, you can still create manual snapshots when you want with create-cluster-snapshot. Default is 1.
	AutomatedSnapshotRetentionPeriod pulumi.IntPtrInput
	// The EC2 Availability Zone (AZ) in which you want Amazon Redshift to provision the cluster. For example, if you have several EC2 instances running in a specific Availability Zone, then you might want the cluster to be provisioned in the same zone in order to decrease network latency.
	AvailabilityZone pulumi.StringPtrInput
	// The Cluster Identifier. Must be a lower case
	// string.
	ClusterIdentifier pulumi.StringPtrInput
	// The name of the parameter group to be associated with this cluster.
	ClusterParameterGroupName pulumi.StringPtrInput
	// The public key for the cluster
	ClusterPublicKey pulumi.StringPtrInput
	// The specific revision number of the database in the cluster
	ClusterRevisionNumber pulumi.StringPtrInput
	// A list of security groups to be associated with this cluster.
	ClusterSecurityGroups pulumi.StringArrayInput
	// The name of a cluster subnet group to be associated with this cluster. If this parameter is not provided the resulting cluster will be deployed outside virtual private cloud (VPC).
	ClusterSubnetGroupName pulumi.StringPtrInput
	// The cluster type to use. Either `single-node` or `multi-node`.
	ClusterType pulumi.StringPtrInput
	// The version of the Amazon Redshift engine software that you want to deploy on the cluster.
	// The version selected runs on all the nodes in the cluster.
	ClusterVersion pulumi.StringPtrInput
	// The name of the first database to be created when the cluster is created.
	// If you do not provide a name, Amazon Redshift will create a default database called `dev`.
	DatabaseName pulumi.StringPtrInput
	// The DNS name of the cluster
	DnsName pulumi.StringPtrInput
	// The Elastic IP (EIP) address for the cluster.
	ElasticIp pulumi.StringPtrInput
	// If true , the data in the cluster is encrypted at rest.
	Encrypted pulumi.BoolPtrInput
	// The connection endpoint
	Endpoint pulumi.StringPtrInput
	// If true , enhanced VPC routing is enabled.
	EnhancedVpcRouting pulumi.BoolPtrInput
	// The identifier of the final snapshot that is to be created immediately before deleting the cluster. If this parameter is provided, `skipFinalSnapshot` must be false.
	FinalSnapshotIdentifier pulumi.StringPtrInput
	// A list of IAM Role ARNs to associate with the cluster. A Maximum of 10 can be associated to the cluster at any time.
	IamRoles pulumi.StringArrayInput
	// The ARN for the KMS encryption key. When specifying `kmsKeyId`, `encrypted` needs to be set to true.
	KmsKeyId pulumi.StringPtrInput
	// Logging, documented below.
	Logging ClusterLoggingPtrInput
	// Password for the master DB user.
	// Note that this may show up in logs, and it will be stored in the state file. Password must contain at least 8 chars and
	// contain at least one uppercase letter, one lowercase letter, and one number.
	MasterPassword pulumi.StringPtrInput
	// Username for the master DB user.
	MasterUsername pulumi.StringPtrInput
	// The node type to be provisioned for the cluster.
	NodeType pulumi.StringPtrInput
	// The number of compute nodes in the cluster. This parameter is required when the ClusterType parameter is specified as multi-node. Default is 1.
	NumberOfNodes pulumi.IntPtrInput
	// The AWS customer account used to create or copy the snapshot. Required if you are restoring a snapshot you do not own, optional if you own the snapshot.
	OwnerAccount pulumi.StringPtrInput
	// The port number on which the cluster accepts incoming connections.
	// The cluster is accessible only via the JDBC and ODBC connection strings. Part of the connection string requires the port on which the cluster will listen for incoming connections. Default port is 5439.
	Port pulumi.IntPtrInput
	// The weekly time range (in UTC) during which automated cluster maintenance can occur.
	// Format: ddd:hh24:mi-ddd:hh24:mi
	PreferredMaintenanceWindow pulumi.StringPtrInput
	// If true, the cluster can be accessed from a public network. Default is `true`.
	PubliclyAccessible pulumi.BoolPtrInput
	// Determines whether a final snapshot of the cluster is created before Amazon Redshift deletes the cluster. If true , a final cluster snapshot is not created. If false , a final cluster snapshot is created before the cluster is deleted. Default is false.
	SkipFinalSnapshot pulumi.BoolPtrInput
	// The name of the cluster the source snapshot was created from.
	SnapshotClusterIdentifier pulumi.StringPtrInput
	// Configuration of automatic copy of snapshots from one region to another. Documented below.
	SnapshotCopy ClusterSnapshotCopyPtrInput
	// The name of the snapshot from which to create the new cluster.
	SnapshotIdentifier pulumi.StringPtrInput
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapInput
	// A list of Virtual Private Cloud (VPC) security groups to be associated with the cluster.
	VpcSecurityGroupIds pulumi.StringArrayInput
}

func (ClusterState) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterState)(nil)).Elem()
}

type clusterArgs struct {
	// If true , major version upgrades can be applied during the maintenance window to the Amazon Redshift engine that is running on the cluster. Default is true
	AllowVersionUpgrade *bool `pulumi:"allowVersionUpgrade"`
	// The number of days that automated snapshots are retained. If the value is 0, automated snapshots are disabled. Even if automated snapshots are disabled, you can still create manual snapshots when you want with create-cluster-snapshot. Default is 1.
	AutomatedSnapshotRetentionPeriod *int `pulumi:"automatedSnapshotRetentionPeriod"`
	// The EC2 Availability Zone (AZ) in which you want Amazon Redshift to provision the cluster. For example, if you have several EC2 instances running in a specific Availability Zone, then you might want the cluster to be provisioned in the same zone in order to decrease network latency.
	AvailabilityZone *string `pulumi:"availabilityZone"`
	// The Cluster Identifier. Must be a lower case
	// string.
	ClusterIdentifier string `pulumi:"clusterIdentifier"`
	// The name of the parameter group to be associated with this cluster.
	ClusterParameterGroupName *string `pulumi:"clusterParameterGroupName"`
	// The public key for the cluster
	ClusterPublicKey *string `pulumi:"clusterPublicKey"`
	// The specific revision number of the database in the cluster
	ClusterRevisionNumber *string `pulumi:"clusterRevisionNumber"`
	// A list of security groups to be associated with this cluster.
	ClusterSecurityGroups []string `pulumi:"clusterSecurityGroups"`
	// The name of a cluster subnet group to be associated with this cluster. If this parameter is not provided the resulting cluster will be deployed outside virtual private cloud (VPC).
	ClusterSubnetGroupName *string `pulumi:"clusterSubnetGroupName"`
	// The cluster type to use. Either `single-node` or `multi-node`.
	ClusterType *string `pulumi:"clusterType"`
	// The version of the Amazon Redshift engine software that you want to deploy on the cluster.
	// The version selected runs on all the nodes in the cluster.
	ClusterVersion *string `pulumi:"clusterVersion"`
	// The name of the first database to be created when the cluster is created.
	// If you do not provide a name, Amazon Redshift will create a default database called `dev`.
	DatabaseName *string `pulumi:"databaseName"`
	// The Elastic IP (EIP) address for the cluster.
	ElasticIp *string `pulumi:"elasticIp"`
	// If true , the data in the cluster is encrypted at rest.
	Encrypted *bool `pulumi:"encrypted"`
	// The connection endpoint
	Endpoint *string `pulumi:"endpoint"`
	// If true , enhanced VPC routing is enabled.
	EnhancedVpcRouting *bool `pulumi:"enhancedVpcRouting"`
	// The identifier of the final snapshot that is to be created immediately before deleting the cluster. If this parameter is provided, `skipFinalSnapshot` must be false.
	FinalSnapshotIdentifier *string `pulumi:"finalSnapshotIdentifier"`
	// A list of IAM Role ARNs to associate with the cluster. A Maximum of 10 can be associated to the cluster at any time.
	IamRoles []string `pulumi:"iamRoles"`
	// The ARN for the KMS encryption key. When specifying `kmsKeyId`, `encrypted` needs to be set to true.
	KmsKeyId *string `pulumi:"kmsKeyId"`
	// Logging, documented below.
	Logging *ClusterLogging `pulumi:"logging"`
	// Password for the master DB user.
	// Note that this may show up in logs, and it will be stored in the state file. Password must contain at least 8 chars and
	// contain at least one uppercase letter, one lowercase letter, and one number.
	MasterPassword *string `pulumi:"masterPassword"`
	// Username for the master DB user.
	MasterUsername *string `pulumi:"masterUsername"`
	// The node type to be provisioned for the cluster.
	NodeType string `pulumi:"nodeType"`
	// The number of compute nodes in the cluster. This parameter is required when the ClusterType parameter is specified as multi-node. Default is 1.
	NumberOfNodes *int `pulumi:"numberOfNodes"`
	// The AWS customer account used to create or copy the snapshot. Required if you are restoring a snapshot you do not own, optional if you own the snapshot.
	OwnerAccount *string `pulumi:"ownerAccount"`
	// The port number on which the cluster accepts incoming connections.
	// The cluster is accessible only via the JDBC and ODBC connection strings. Part of the connection string requires the port on which the cluster will listen for incoming connections. Default port is 5439.
	Port *int `pulumi:"port"`
	// The weekly time range (in UTC) during which automated cluster maintenance can occur.
	// Format: ddd:hh24:mi-ddd:hh24:mi
	PreferredMaintenanceWindow *string `pulumi:"preferredMaintenanceWindow"`
	// If true, the cluster can be accessed from a public network. Default is `true`.
	PubliclyAccessible *bool `pulumi:"publiclyAccessible"`
	// Determines whether a final snapshot of the cluster is created before Amazon Redshift deletes the cluster. If true , a final cluster snapshot is not created. If false , a final cluster snapshot is created before the cluster is deleted. Default is false.
	SkipFinalSnapshot *bool `pulumi:"skipFinalSnapshot"`
	// The name of the cluster the source snapshot was created from.
	SnapshotClusterIdentifier *string `pulumi:"snapshotClusterIdentifier"`
	// Configuration of automatic copy of snapshots from one region to another. Documented below.
	SnapshotCopy *ClusterSnapshotCopy `pulumi:"snapshotCopy"`
	// The name of the snapshot from which to create the new cluster.
	SnapshotIdentifier *string `pulumi:"snapshotIdentifier"`
	// A map of tags to assign to the resource.
	Tags map[string]string `pulumi:"tags"`
	// A list of Virtual Private Cloud (VPC) security groups to be associated with the cluster.
	VpcSecurityGroupIds []string `pulumi:"vpcSecurityGroupIds"`
}

// The set of arguments for constructing a Cluster resource.
type ClusterArgs struct {
	// If true , major version upgrades can be applied during the maintenance window to the Amazon Redshift engine that is running on the cluster. Default is true
	AllowVersionUpgrade pulumi.BoolPtrInput
	// The number of days that automated snapshots are retained. If the value is 0, automated snapshots are disabled. Even if automated snapshots are disabled, you can still create manual snapshots when you want with create-cluster-snapshot. Default is 1.
	AutomatedSnapshotRetentionPeriod pulumi.IntPtrInput
	// The EC2 Availability Zone (AZ) in which you want Amazon Redshift to provision the cluster. For example, if you have several EC2 instances running in a specific Availability Zone, then you might want the cluster to be provisioned in the same zone in order to decrease network latency.
	AvailabilityZone pulumi.StringPtrInput
	// The Cluster Identifier. Must be a lower case
	// string.
	ClusterIdentifier pulumi.StringInput
	// The name of the parameter group to be associated with this cluster.
	ClusterParameterGroupName pulumi.StringPtrInput
	// The public key for the cluster
	ClusterPublicKey pulumi.StringPtrInput
	// The specific revision number of the database in the cluster
	ClusterRevisionNumber pulumi.StringPtrInput
	// A list of security groups to be associated with this cluster.
	ClusterSecurityGroups pulumi.StringArrayInput
	// The name of a cluster subnet group to be associated with this cluster. If this parameter is not provided the resulting cluster will be deployed outside virtual private cloud (VPC).
	ClusterSubnetGroupName pulumi.StringPtrInput
	// The cluster type to use. Either `single-node` or `multi-node`.
	ClusterType pulumi.StringPtrInput
	// The version of the Amazon Redshift engine software that you want to deploy on the cluster.
	// The version selected runs on all the nodes in the cluster.
	ClusterVersion pulumi.StringPtrInput
	// The name of the first database to be created when the cluster is created.
	// If you do not provide a name, Amazon Redshift will create a default database called `dev`.
	DatabaseName pulumi.StringPtrInput
	// The Elastic IP (EIP) address for the cluster.
	ElasticIp pulumi.StringPtrInput
	// If true , the data in the cluster is encrypted at rest.
	Encrypted pulumi.BoolPtrInput
	// The connection endpoint
	Endpoint pulumi.StringPtrInput
	// If true , enhanced VPC routing is enabled.
	EnhancedVpcRouting pulumi.BoolPtrInput
	// The identifier of the final snapshot that is to be created immediately before deleting the cluster. If this parameter is provided, `skipFinalSnapshot` must be false.
	FinalSnapshotIdentifier pulumi.StringPtrInput
	// A list of IAM Role ARNs to associate with the cluster. A Maximum of 10 can be associated to the cluster at any time.
	IamRoles pulumi.StringArrayInput
	// The ARN for the KMS encryption key. When specifying `kmsKeyId`, `encrypted` needs to be set to true.
	KmsKeyId pulumi.StringPtrInput
	// Logging, documented below.
	Logging ClusterLoggingPtrInput
	// Password for the master DB user.
	// Note that this may show up in logs, and it will be stored in the state file. Password must contain at least 8 chars and
	// contain at least one uppercase letter, one lowercase letter, and one number.
	MasterPassword pulumi.StringPtrInput
	// Username for the master DB user.
	MasterUsername pulumi.StringPtrInput
	// The node type to be provisioned for the cluster.
	NodeType pulumi.StringInput
	// The number of compute nodes in the cluster. This parameter is required when the ClusterType parameter is specified as multi-node. Default is 1.
	NumberOfNodes pulumi.IntPtrInput
	// The AWS customer account used to create or copy the snapshot. Required if you are restoring a snapshot you do not own, optional if you own the snapshot.
	OwnerAccount pulumi.StringPtrInput
	// The port number on which the cluster accepts incoming connections.
	// The cluster is accessible only via the JDBC and ODBC connection strings. Part of the connection string requires the port on which the cluster will listen for incoming connections. Default port is 5439.
	Port pulumi.IntPtrInput
	// The weekly time range (in UTC) during which automated cluster maintenance can occur.
	// Format: ddd:hh24:mi-ddd:hh24:mi
	PreferredMaintenanceWindow pulumi.StringPtrInput
	// If true, the cluster can be accessed from a public network. Default is `true`.
	PubliclyAccessible pulumi.BoolPtrInput
	// Determines whether a final snapshot of the cluster is created before Amazon Redshift deletes the cluster. If true , a final cluster snapshot is not created. If false , a final cluster snapshot is created before the cluster is deleted. Default is false.
	SkipFinalSnapshot pulumi.BoolPtrInput
	// The name of the cluster the source snapshot was created from.
	SnapshotClusterIdentifier pulumi.StringPtrInput
	// Configuration of automatic copy of snapshots from one region to another. Documented below.
	SnapshotCopy ClusterSnapshotCopyPtrInput
	// The name of the snapshot from which to create the new cluster.
	SnapshotIdentifier pulumi.StringPtrInput
	// A map of tags to assign to the resource.
	Tags pulumi.StringMapInput
	// A list of Virtual Private Cloud (VPC) security groups to be associated with the cluster.
	VpcSecurityGroupIds pulumi.StringArrayInput
}

func (ClusterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterArgs)(nil)).Elem()
}
