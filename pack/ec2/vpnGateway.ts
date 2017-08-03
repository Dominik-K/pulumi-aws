// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class VpnGateway extends lumi.NamedResource implements VpnGatewayArgs {
    public readonly availabilityZone?: string;
    public readonly tags?: {[key: string]: any};
    public readonly vpcId: string;

    public static get(id: lumi.ID): VpnGateway {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): VpnGateway[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(name: string, args: VpnGatewayArgs) {
        super(name);
        this.availabilityZone = <any>args.availabilityZone;
        this.tags = <any>args.tags;
        this.vpcId = <any>args.vpcId;
    }
}

export interface VpnGatewayArgs {
    readonly availabilityZone?: string;
    readonly tags?: {[key: string]: any};
    readonly vpcId?: string;
}

