// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class Vpc extends lumi.NamedResource implements VpcArgs {
    public readonly assignGeneratedIpv6CidrBlock?: boolean;
    public readonly cidrBlock: string;
    public /*out*/ readonly defaultNetworkAclId: string;
    public /*out*/ readonly defaultRouteTableId: string;
    public /*out*/ readonly defaultSecurityGroupId: string;
    public /*out*/ readonly dhcpOptionsId: string;
    public readonly enableClassiclink: boolean;
    public readonly enableClassiclinkDnsSupport: boolean;
    public readonly enableDnsHostnames: boolean;
    public readonly enableDnsSupport?: boolean;
    public readonly instanceTenancy: string;
    public /*out*/ readonly ipv6AssociationId: string;
    public /*out*/ readonly ipv6CidrBlock: string;
    public /*out*/ readonly mainRouteTableId: string;
    public readonly tags?: {[key: string]: any};

    public static get(id: lumi.ID): Vpc {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): Vpc[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(name: string, args: VpcArgs) {
        super(name);
        this.assignGeneratedIpv6CidrBlock = <any>args.assignGeneratedIpv6CidrBlock;
        if (lumirt.defaultIfComputed(args.cidrBlock, "") === undefined) {
            throw new Error("Property argument 'cidrBlock' is required, but was missing");
        }
        this.cidrBlock = <any>args.cidrBlock;
        this.enableClassiclink = <any>args.enableClassiclink;
        this.enableClassiclinkDnsSupport = <any>args.enableClassiclinkDnsSupport;
        this.enableDnsHostnames = <any>args.enableDnsHostnames;
        this.enableDnsSupport = <any>args.enableDnsSupport;
        this.instanceTenancy = <any>args.instanceTenancy;
        this.tags = <any>args.tags;
    }
}

export interface VpcArgs {
    readonly assignGeneratedIpv6CidrBlock?: boolean;
    readonly cidrBlock: string;
    readonly enableClassiclink?: boolean;
    readonly enableClassiclinkDnsSupport?: boolean;
    readonly enableDnsHostnames?: boolean;
    readonly enableDnsSupport?: boolean;
    readonly instanceTenancy?: string;
    readonly tags?: {[key: string]: any};
}

