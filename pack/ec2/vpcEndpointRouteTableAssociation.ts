// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class VpcEndpointRouteTableAssociation extends lumi.NamedResource implements VpcEndpointRouteTableAssociationArgs {
    public readonly routeTableId: string;
    public readonly vpcEndpointId: string;

    public static get(id: lumi.ID): VpcEndpointRouteTableAssociation {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): VpcEndpointRouteTableAssociation[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(name: string, args: VpcEndpointRouteTableAssociationArgs) {
        super(name);
        if (lumirt.defaultIfComputed(args.routeTableId, "") === undefined) {
            throw new Error("Property argument 'routeTableId' is required, but was missing");
        }
        this.routeTableId = <any>args.routeTableId;
        if (lumirt.defaultIfComputed(args.vpcEndpointId, "") === undefined) {
            throw new Error("Property argument 'vpcEndpointId' is required, but was missing");
        }
        this.vpcEndpointId = <any>args.vpcEndpointId;
    }
}

export interface VpcEndpointRouteTableAssociationArgs {
    readonly routeTableId: string;
    readonly vpcEndpointId: string;
}

