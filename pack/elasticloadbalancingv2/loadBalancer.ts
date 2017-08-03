// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class LoadBalancer extends lumi.NamedResource implements LoadBalancerArgs {
    public readonly accessLogs?: { bucket: string, enabled?: boolean, prefix?: string }[];
    public /*out*/ readonly arn: string;
    public /*out*/ readonly arnSuffix: string;
    public /*out*/ readonly dnsName: string;
    public readonly enableDeletionProtection?: boolean;
    public readonly idleTimeout?: number;
    public readonly internal: boolean;
    public readonly ipAddressType: string;
    public readonly loadBalancerName: string;
    public readonly namePrefix?: string;
    public readonly securityGroups: string[];
    public readonly subnets: string[];
    public readonly tags?: {[key: string]: any};
    public /*out*/ readonly vpcId: string;
    public /*out*/ readonly zoneId: string;

    public static get(id: lumi.ID): LoadBalancer {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): LoadBalancer[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(name: string, args: LoadBalancerArgs) {
        super(name);
        this.accessLogs = <any>args.accessLogs;
        this.enableDeletionProtection = <any>args.enableDeletionProtection;
        this.idleTimeout = <any>args.idleTimeout;
        this.internal = <any>args.internal;
        this.ipAddressType = <any>args.ipAddressType;
        this.loadBalancerName = <any>args.loadBalancerName;
        this.namePrefix = <any>args.namePrefix;
        this.securityGroups = <any>args.securityGroups;
        if (lumirt.defaultIfComputed(args.subnets, "") === undefined) {
            throw new Error("Property argument 'subnets' is required, but was missing");
        }
        this.subnets = <any>args.subnets;
        this.tags = <any>args.tags;
    }
}

export interface LoadBalancerArgs {
    readonly accessLogs?: { bucket: string, enabled?: boolean, prefix?: string }[];
    readonly enableDeletionProtection?: boolean;
    readonly idleTimeout?: number;
    readonly internal?: boolean;
    readonly ipAddressType?: string;
    readonly loadBalancerName?: string;
    readonly namePrefix?: string;
    readonly securityGroups?: string[];
    readonly subnets: string[];
    readonly tags?: {[key: string]: any};
}

