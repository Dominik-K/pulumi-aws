// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class VpcDhcpOptionsAssociation extends lumi.NamedResource implements VpcDhcpOptionsAssociationArgs {
    public readonly dhcpOptionsId: string;
    public readonly vpcId: string;

    public static get(id: lumi.ID): VpcDhcpOptionsAssociation {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): VpcDhcpOptionsAssociation[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(name: string, args: VpcDhcpOptionsAssociationArgs) {
        super(name);
        if (lumirt.defaultIfComputed(args.dhcpOptionsId, "") === undefined) {
            throw new Error("Property argument 'dhcpOptionsId' is required, but was missing");
        }
        this.dhcpOptionsId = <any>args.dhcpOptionsId;
        if (lumirt.defaultIfComputed(args.vpcId, "") === undefined) {
            throw new Error("Property argument 'vpcId' is required, but was missing");
        }
        this.vpcId = <any>args.vpcId;
    }
}

export interface VpcDhcpOptionsAssociationArgs {
    readonly dhcpOptionsId: string;
    readonly vpcId: string;
}

