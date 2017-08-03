// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class MemcachedLayer extends lumi.NamedResource implements MemcachedLayerArgs {
    public readonly allocatedMemory?: number;
    public readonly autoAssignElasticIps?: boolean;
    public readonly autoAssignPublicIps?: boolean;
    public readonly autoHealing?: boolean;
    public readonly customConfigureRecipes?: string[];
    public readonly customDeployRecipes?: string[];
    public readonly customInstanceProfileArn?: string;
    public readonly customJson?: string;
    public readonly customSecurityGroupIds?: string[];
    public readonly customSetupRecipes?: string[];
    public readonly customShutdownRecipes?: string[];
    public readonly customUndeployRecipes?: string[];
    public readonly drainElbOnShutdown?: boolean;
    public readonly ebsVolume?: { iops?: number, mountPoint: string, numberOfDisks: number, raidLevel?: string, size: number, type?: string }[];
    public readonly elasticLoadBalancer?: string;
    public /*out*/ readonly layerId: string;
    public readonly installUpdatesOnBoot?: boolean;
    public readonly instanceShutdownTimeout?: number;
    public readonly memcachedLayerName: string;
    public readonly stackId: string;
    public readonly systemPackages?: string[];
    public readonly useEbsOptimizedInstances?: boolean;

    public static get(id: lumi.ID): MemcachedLayer {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): MemcachedLayer[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(name: string, args: MemcachedLayerArgs) {
        super(name);
        this.allocatedMemory = <any>args.allocatedMemory;
        this.autoAssignElasticIps = <any>args.autoAssignElasticIps;
        this.autoAssignPublicIps = <any>args.autoAssignPublicIps;
        this.autoHealing = <any>args.autoHealing;
        this.customConfigureRecipes = <any>args.customConfigureRecipes;
        this.customDeployRecipes = <any>args.customDeployRecipes;
        this.customInstanceProfileArn = <any>args.customInstanceProfileArn;
        this.customJson = <any>args.customJson;
        this.customSecurityGroupIds = <any>args.customSecurityGroupIds;
        this.customSetupRecipes = <any>args.customSetupRecipes;
        this.customShutdownRecipes = <any>args.customShutdownRecipes;
        this.customUndeployRecipes = <any>args.customUndeployRecipes;
        this.drainElbOnShutdown = <any>args.drainElbOnShutdown;
        this.ebsVolume = <any>args.ebsVolume;
        this.elasticLoadBalancer = <any>args.elasticLoadBalancer;
        this.installUpdatesOnBoot = <any>args.installUpdatesOnBoot;
        this.instanceShutdownTimeout = <any>args.instanceShutdownTimeout;
        this.memcachedLayerName = <any>args.memcachedLayerName;
        if (lumirt.defaultIfComputed(args.stackId, "") === undefined) {
            throw new Error("Property argument 'stackId' is required, but was missing");
        }
        this.stackId = <any>args.stackId;
        this.systemPackages = <any>args.systemPackages;
        this.useEbsOptimizedInstances = <any>args.useEbsOptimizedInstances;
    }
}

export interface MemcachedLayerArgs {
    readonly allocatedMemory?: number;
    readonly autoAssignElasticIps?: boolean;
    readonly autoAssignPublicIps?: boolean;
    readonly autoHealing?: boolean;
    readonly customConfigureRecipes?: string[];
    readonly customDeployRecipes?: string[];
    readonly customInstanceProfileArn?: string;
    readonly customJson?: string;
    readonly customSecurityGroupIds?: string[];
    readonly customSetupRecipes?: string[];
    readonly customShutdownRecipes?: string[];
    readonly customUndeployRecipes?: string[];
    readonly drainElbOnShutdown?: boolean;
    readonly ebsVolume?: { iops?: number, mountPoint: string, numberOfDisks: number, raidLevel?: string, size: number, type?: string }[];
    readonly elasticLoadBalancer?: string;
    readonly installUpdatesOnBoot?: boolean;
    readonly instanceShutdownTimeout?: number;
    readonly memcachedLayerName?: string;
    readonly stackId: string;
    readonly systemPackages?: string[];
    readonly useEbsOptimizedInstances?: boolean;
}

