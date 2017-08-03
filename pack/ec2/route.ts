// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class Route extends lumi.NamedResource implements RouteArgs {
    public readonly destinationCidrBlock?: string;
    public readonly destinationIpv6CidrBlock?: string;
    public /*out*/ readonly destinationPrefixListId: string;
    public readonly egressOnlyGatewayId: string;
    public readonly gatewayId: string;
    public readonly instanceId: string;
    public /*out*/ readonly instanceOwnerId: string;
    public readonly natGatewayId: string;
    public readonly networkInterfaceId: string;
    public /*out*/ readonly origin: string;
    public readonly routeTableId: string;
    public /*out*/ readonly state: string;
    public readonly vpcPeeringConnectionId?: string;

    public static get(id: lumi.ID): Route {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): Route[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(name: string, args: RouteArgs) {
        super(name);
        this.destinationCidrBlock = <any>args.destinationCidrBlock;
        this.destinationIpv6CidrBlock = <any>args.destinationIpv6CidrBlock;
        this.egressOnlyGatewayId = <any>args.egressOnlyGatewayId;
        this.gatewayId = <any>args.gatewayId;
        this.instanceId = <any>args.instanceId;
        this.natGatewayId = <any>args.natGatewayId;
        this.networkInterfaceId = <any>args.networkInterfaceId;
        if (lumirt.defaultIfComputed(args.routeTableId, "") === undefined) {
            throw new Error("Property argument 'routeTableId' is required, but was missing");
        }
        this.routeTableId = <any>args.routeTableId;
        this.vpcPeeringConnectionId = <any>args.vpcPeeringConnectionId;
    }
}

export interface RouteArgs {
    readonly destinationCidrBlock?: string;
    readonly destinationIpv6CidrBlock?: string;
    readonly egressOnlyGatewayId?: string;
    readonly gatewayId?: string;
    readonly instanceId?: string;
    readonly natGatewayId?: string;
    readonly networkInterfaceId?: string;
    readonly routeTableId: string;
    readonly vpcPeeringConnectionId?: string;
}

