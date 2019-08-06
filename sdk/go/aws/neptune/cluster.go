// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package neptune

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides an Neptune Cluster Resource. A Cluster Resource defines attributes that are
// applied to the entire cluster of Neptune Cluster Instances.
// 
// Changes to a Neptune Cluster can occur when you manually change a
// parameter, such as `backupRetentionPeriod`, and are reflected in the next maintenance
// window. Because of this, this provider may report a difference in its planning
// phase because a modification has not yet taken place. You can use the
// `applyImmediately` flag to instruct the service to apply the change immediately
// (see documentation below).
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/neptune_cluster.html.markdown.
type Cluster struct {
	s *pulumi.ResourceState
}

// NewCluster registers a new resource with the given unique name, arguments, and options.
func NewCluster(ctx *pulumi.Context,
	name string, args *ClusterArgs, opts ...pulumi.ResourceOpt) (*Cluster, error) {
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["applyImmediately"] = nil
		inputs["availabilityZones"] = nil
		inputs["backupRetentionPeriod"] = nil
		inputs["clusterIdentifier"] = nil
		inputs["clusterIdentifierPrefix"] = nil
		inputs["engine"] = nil
		inputs["engineVersion"] = nil
		inputs["finalSnapshotIdentifier"] = nil
		inputs["iamDatabaseAuthenticationEnabled"] = nil
		inputs["iamRoles"] = nil
		inputs["kmsKeyArn"] = nil
		inputs["neptuneClusterParameterGroupName"] = nil
		inputs["neptuneSubnetGroupName"] = nil
		inputs["port"] = nil
		inputs["preferredBackupWindow"] = nil
		inputs["preferredMaintenanceWindow"] = nil
		inputs["replicationSourceIdentifier"] = nil
		inputs["skipFinalSnapshot"] = nil
		inputs["snapshotIdentifier"] = nil
		inputs["storageEncrypted"] = nil
		inputs["tags"] = nil
		inputs["vpcSecurityGroupIds"] = nil
	} else {
		inputs["applyImmediately"] = args.ApplyImmediately
		inputs["availabilityZones"] = args.AvailabilityZones
		inputs["backupRetentionPeriod"] = args.BackupRetentionPeriod
		inputs["clusterIdentifier"] = args.ClusterIdentifier
		inputs["clusterIdentifierPrefix"] = args.ClusterIdentifierPrefix
		inputs["engine"] = args.Engine
		inputs["engineVersion"] = args.EngineVersion
		inputs["finalSnapshotIdentifier"] = args.FinalSnapshotIdentifier
		inputs["iamDatabaseAuthenticationEnabled"] = args.IamDatabaseAuthenticationEnabled
		inputs["iamRoles"] = args.IamRoles
		inputs["kmsKeyArn"] = args.KmsKeyArn
		inputs["neptuneClusterParameterGroupName"] = args.NeptuneClusterParameterGroupName
		inputs["neptuneSubnetGroupName"] = args.NeptuneSubnetGroupName
		inputs["port"] = args.Port
		inputs["preferredBackupWindow"] = args.PreferredBackupWindow
		inputs["preferredMaintenanceWindow"] = args.PreferredMaintenanceWindow
		inputs["replicationSourceIdentifier"] = args.ReplicationSourceIdentifier
		inputs["skipFinalSnapshot"] = args.SkipFinalSnapshot
		inputs["snapshotIdentifier"] = args.SnapshotIdentifier
		inputs["storageEncrypted"] = args.StorageEncrypted
		inputs["tags"] = args.Tags
		inputs["vpcSecurityGroupIds"] = args.VpcSecurityGroupIds
	}
	inputs["arn"] = nil
	inputs["clusterMembers"] = nil
	inputs["clusterResourceId"] = nil
	inputs["endpoint"] = nil
	inputs["hostedZoneId"] = nil
	inputs["readerEndpoint"] = nil
	s, err := ctx.RegisterResource("aws:neptune/cluster:Cluster", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Cluster{s: s}, nil
}

// GetCluster gets an existing Cluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCluster(ctx *pulumi.Context,
	name string, id pulumi.ID, state *ClusterState, opts ...pulumi.ResourceOpt) (*Cluster, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["applyImmediately"] = state.ApplyImmediately
		inputs["arn"] = state.Arn
		inputs["availabilityZones"] = state.AvailabilityZones
		inputs["backupRetentionPeriod"] = state.BackupRetentionPeriod
		inputs["clusterIdentifier"] = state.ClusterIdentifier
		inputs["clusterIdentifierPrefix"] = state.ClusterIdentifierPrefix
		inputs["clusterMembers"] = state.ClusterMembers
		inputs["clusterResourceId"] = state.ClusterResourceId
		inputs["endpoint"] = state.Endpoint
		inputs["engine"] = state.Engine
		inputs["engineVersion"] = state.EngineVersion
		inputs["finalSnapshotIdentifier"] = state.FinalSnapshotIdentifier
		inputs["hostedZoneId"] = state.HostedZoneId
		inputs["iamDatabaseAuthenticationEnabled"] = state.IamDatabaseAuthenticationEnabled
		inputs["iamRoles"] = state.IamRoles
		inputs["kmsKeyArn"] = state.KmsKeyArn
		inputs["neptuneClusterParameterGroupName"] = state.NeptuneClusterParameterGroupName
		inputs["neptuneSubnetGroupName"] = state.NeptuneSubnetGroupName
		inputs["port"] = state.Port
		inputs["preferredBackupWindow"] = state.PreferredBackupWindow
		inputs["preferredMaintenanceWindow"] = state.PreferredMaintenanceWindow
		inputs["readerEndpoint"] = state.ReaderEndpoint
		inputs["replicationSourceIdentifier"] = state.ReplicationSourceIdentifier
		inputs["skipFinalSnapshot"] = state.SkipFinalSnapshot
		inputs["snapshotIdentifier"] = state.SnapshotIdentifier
		inputs["storageEncrypted"] = state.StorageEncrypted
		inputs["tags"] = state.Tags
		inputs["vpcSecurityGroupIds"] = state.VpcSecurityGroupIds
	}
	s, err := ctx.ReadResource("aws:neptune/cluster:Cluster", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Cluster{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Cluster) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Cluster) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// Specifies whether any cluster modifications are applied immediately, or during the next maintenance window. Default is `false`.
func (r *Cluster) ApplyImmediately() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["applyImmediately"])
}

// The Neptune Cluster Amazon Resource Name (ARN)
func (r *Cluster) Arn() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["arn"])
}

// A list of EC2 Availability Zones that instances in the Neptune cluster can be created in.
func (r *Cluster) AvailabilityZones() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["availabilityZones"])
}

// The days to retain backups for. Default `1`
func (r *Cluster) BackupRetentionPeriod() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["backupRetentionPeriod"])
}

// The cluster identifier. If omitted, this provider will assign a random, unique identifier.
func (r *Cluster) ClusterIdentifier() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["clusterIdentifier"])
}

// Creates a unique cluster identifier beginning with the specified prefix. Conflicts with `clusterIdentifier`.
func (r *Cluster) ClusterIdentifierPrefix() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["clusterIdentifierPrefix"])
}

// List of Neptune Instances that are a part of this cluster
func (r *Cluster) ClusterMembers() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["clusterMembers"])
}

// The Neptune Cluster Resource ID
func (r *Cluster) ClusterResourceId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["clusterResourceId"])
}

// The DNS address of the Neptune instance
func (r *Cluster) Endpoint() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["endpoint"])
}

// The name of the database engine to be used for this Neptune cluster. Defaults to `neptune`.
func (r *Cluster) Engine() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["engine"])
}

// The database engine version.
func (r *Cluster) EngineVersion() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["engineVersion"])
}

// The name of your final Neptune snapshot when this Neptune cluster is deleted. If omitted, no final snapshot will be made.
func (r *Cluster) FinalSnapshotIdentifier() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["finalSnapshotIdentifier"])
}

// The Route53 Hosted Zone ID of the endpoint
func (r *Cluster) HostedZoneId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["hostedZoneId"])
}

// Specifies whether or mappings of AWS Identity and Access Management (IAM) accounts to database accounts is enabled.
func (r *Cluster) IamDatabaseAuthenticationEnabled() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["iamDatabaseAuthenticationEnabled"])
}

// A List of ARNs for the IAM roles to associate to the Neptune Cluster.
func (r *Cluster) IamRoles() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["iamRoles"])
}

// The ARN for the KMS encryption key. When specifying `kmsKeyArn`, `storageEncrypted` needs to be set to true.
func (r *Cluster) KmsKeyArn() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["kmsKeyArn"])
}

// A cluster parameter group to associate with the cluster.
func (r *Cluster) NeptuneClusterParameterGroupName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["neptuneClusterParameterGroupName"])
}

// A Neptune subnet group to associate with this Neptune instance.
func (r *Cluster) NeptuneSubnetGroupName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["neptuneSubnetGroupName"])
}

// The port on which the Neptune accepts connections. Default is `8182`.
func (r *Cluster) Port() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["port"])
}

// The daily time range during which automated backups are created if automated backups are enabled using the BackupRetentionPeriod parameter. Time in UTC. Default: A 30-minute window selected at random from an 8-hour block of time per region. e.g. 04:00-09:00
func (r *Cluster) PreferredBackupWindow() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["preferredBackupWindow"])
}

// The weekly time range during which system maintenance can occur, in (UTC) e.g. wed:04:00-wed:04:30
func (r *Cluster) PreferredMaintenanceWindow() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["preferredMaintenanceWindow"])
}

// A read-only endpoint for the Neptune cluster, automatically load-balanced across replicas
func (r *Cluster) ReaderEndpoint() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["readerEndpoint"])
}

// ARN of a source Neptune cluster or Neptune instance if this Neptune cluster is to be created as a Read Replica.
func (r *Cluster) ReplicationSourceIdentifier() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["replicationSourceIdentifier"])
}

// Determines whether a final Neptune snapshot is created before the Neptune cluster is deleted. If true is specified, no Neptune snapshot is created. If false is specified, a Neptune snapshot is created before the Neptune cluster is deleted, using the value from `finalSnapshotIdentifier`. Default is `false`.
func (r *Cluster) SkipFinalSnapshot() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["skipFinalSnapshot"])
}

// Specifies whether or not to create this cluster from a snapshot. You can use either the name or ARN when specifying a Neptune cluster snapshot, or the ARN when specifying a Neptune snapshot.
func (r *Cluster) SnapshotIdentifier() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["snapshotIdentifier"])
}

// Specifies whether the Neptune cluster is encrypted. The default is `false` if not specified.
func (r *Cluster) StorageEncrypted() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["storageEncrypted"])
}

// A mapping of tags to assign to the Neptune cluster.
func (r *Cluster) Tags() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["tags"])
}

// List of VPC security groups to associate with the Cluster
func (r *Cluster) VpcSecurityGroupIds() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["vpcSecurityGroupIds"])
}

// Input properties used for looking up and filtering Cluster resources.
type ClusterState struct {
	// Specifies whether any cluster modifications are applied immediately, or during the next maintenance window. Default is `false`.
	ApplyImmediately interface{}
	// The Neptune Cluster Amazon Resource Name (ARN)
	Arn interface{}
	// A list of EC2 Availability Zones that instances in the Neptune cluster can be created in.
	AvailabilityZones interface{}
	// The days to retain backups for. Default `1`
	BackupRetentionPeriod interface{}
	// The cluster identifier. If omitted, this provider will assign a random, unique identifier.
	ClusterIdentifier interface{}
	// Creates a unique cluster identifier beginning with the specified prefix. Conflicts with `clusterIdentifier`.
	ClusterIdentifierPrefix interface{}
	// List of Neptune Instances that are a part of this cluster
	ClusterMembers interface{}
	// The Neptune Cluster Resource ID
	ClusterResourceId interface{}
	// The DNS address of the Neptune instance
	Endpoint interface{}
	// The name of the database engine to be used for this Neptune cluster. Defaults to `neptune`.
	Engine interface{}
	// The database engine version.
	EngineVersion interface{}
	// The name of your final Neptune snapshot when this Neptune cluster is deleted. If omitted, no final snapshot will be made.
	FinalSnapshotIdentifier interface{}
	// The Route53 Hosted Zone ID of the endpoint
	HostedZoneId interface{}
	// Specifies whether or mappings of AWS Identity and Access Management (IAM) accounts to database accounts is enabled.
	IamDatabaseAuthenticationEnabled interface{}
	// A List of ARNs for the IAM roles to associate to the Neptune Cluster.
	IamRoles interface{}
	// The ARN for the KMS encryption key. When specifying `kmsKeyArn`, `storageEncrypted` needs to be set to true.
	KmsKeyArn interface{}
	// A cluster parameter group to associate with the cluster.
	NeptuneClusterParameterGroupName interface{}
	// A Neptune subnet group to associate with this Neptune instance.
	NeptuneSubnetGroupName interface{}
	// The port on which the Neptune accepts connections. Default is `8182`.
	Port interface{}
	// The daily time range during which automated backups are created if automated backups are enabled using the BackupRetentionPeriod parameter. Time in UTC. Default: A 30-minute window selected at random from an 8-hour block of time per region. e.g. 04:00-09:00
	PreferredBackupWindow interface{}
	// The weekly time range during which system maintenance can occur, in (UTC) e.g. wed:04:00-wed:04:30
	PreferredMaintenanceWindow interface{}
	// A read-only endpoint for the Neptune cluster, automatically load-balanced across replicas
	ReaderEndpoint interface{}
	// ARN of a source Neptune cluster or Neptune instance if this Neptune cluster is to be created as a Read Replica.
	ReplicationSourceIdentifier interface{}
	// Determines whether a final Neptune snapshot is created before the Neptune cluster is deleted. If true is specified, no Neptune snapshot is created. If false is specified, a Neptune snapshot is created before the Neptune cluster is deleted, using the value from `finalSnapshotIdentifier`. Default is `false`.
	SkipFinalSnapshot interface{}
	// Specifies whether or not to create this cluster from a snapshot. You can use either the name or ARN when specifying a Neptune cluster snapshot, or the ARN when specifying a Neptune snapshot.
	SnapshotIdentifier interface{}
	// Specifies whether the Neptune cluster is encrypted. The default is `false` if not specified.
	StorageEncrypted interface{}
	// A mapping of tags to assign to the Neptune cluster.
	Tags interface{}
	// List of VPC security groups to associate with the Cluster
	VpcSecurityGroupIds interface{}
}

// The set of arguments for constructing a Cluster resource.
type ClusterArgs struct {
	// Specifies whether any cluster modifications are applied immediately, or during the next maintenance window. Default is `false`.
	ApplyImmediately interface{}
	// A list of EC2 Availability Zones that instances in the Neptune cluster can be created in.
	AvailabilityZones interface{}
	// The days to retain backups for. Default `1`
	BackupRetentionPeriod interface{}
	// The cluster identifier. If omitted, this provider will assign a random, unique identifier.
	ClusterIdentifier interface{}
	// Creates a unique cluster identifier beginning with the specified prefix. Conflicts with `clusterIdentifier`.
	ClusterIdentifierPrefix interface{}
	// The name of the database engine to be used for this Neptune cluster. Defaults to `neptune`.
	Engine interface{}
	// The database engine version.
	EngineVersion interface{}
	// The name of your final Neptune snapshot when this Neptune cluster is deleted. If omitted, no final snapshot will be made.
	FinalSnapshotIdentifier interface{}
	// Specifies whether or mappings of AWS Identity and Access Management (IAM) accounts to database accounts is enabled.
	IamDatabaseAuthenticationEnabled interface{}
	// A List of ARNs for the IAM roles to associate to the Neptune Cluster.
	IamRoles interface{}
	// The ARN for the KMS encryption key. When specifying `kmsKeyArn`, `storageEncrypted` needs to be set to true.
	KmsKeyArn interface{}
	// A cluster parameter group to associate with the cluster.
	NeptuneClusterParameterGroupName interface{}
	// A Neptune subnet group to associate with this Neptune instance.
	NeptuneSubnetGroupName interface{}
	// The port on which the Neptune accepts connections. Default is `8182`.
	Port interface{}
	// The daily time range during which automated backups are created if automated backups are enabled using the BackupRetentionPeriod parameter. Time in UTC. Default: A 30-minute window selected at random from an 8-hour block of time per region. e.g. 04:00-09:00
	PreferredBackupWindow interface{}
	// The weekly time range during which system maintenance can occur, in (UTC) e.g. wed:04:00-wed:04:30
	PreferredMaintenanceWindow interface{}
	// ARN of a source Neptune cluster or Neptune instance if this Neptune cluster is to be created as a Read Replica.
	ReplicationSourceIdentifier interface{}
	// Determines whether a final Neptune snapshot is created before the Neptune cluster is deleted. If true is specified, no Neptune snapshot is created. If false is specified, a Neptune snapshot is created before the Neptune cluster is deleted, using the value from `finalSnapshotIdentifier`. Default is `false`.
	SkipFinalSnapshot interface{}
	// Specifies whether or not to create this cluster from a snapshot. You can use either the name or ARN when specifying a Neptune cluster snapshot, or the ARN when specifying a Neptune snapshot.
	SnapshotIdentifier interface{}
	// Specifies whether the Neptune cluster is encrypted. The default is `false` if not specified.
	StorageEncrypted interface{}
	// A mapping of tags to assign to the Neptune cluster.
	Tags interface{}
	// List of VPC security groups to associate with the Cluster
	VpcSecurityGroupIds interface{}
}
