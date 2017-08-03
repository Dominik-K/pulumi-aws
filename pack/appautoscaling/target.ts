// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class Target extends lumi.NamedResource implements TargetArgs {
    public readonly maxCapacity: number;
    public readonly minCapacity: number;
    public readonly resourceId: string;
    public readonly roleArn: string;
    public readonly scalableDimension: string;
    public readonly serviceNamespace: string;

    public static get(id: lumi.ID): Target {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): Target[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(name: string, args: TargetArgs) {
        super(name);
        if (lumirt.defaultIfComputed(args.maxCapacity, "") === undefined) {
            throw new Error("Property argument 'maxCapacity' is required, but was missing");
        }
        this.maxCapacity = <any>args.maxCapacity;
        if (lumirt.defaultIfComputed(args.minCapacity, "") === undefined) {
            throw new Error("Property argument 'minCapacity' is required, but was missing");
        }
        this.minCapacity = <any>args.minCapacity;
        if (lumirt.defaultIfComputed(args.resourceId, "") === undefined) {
            throw new Error("Property argument 'resourceId' is required, but was missing");
        }
        this.resourceId = <any>args.resourceId;
        if (lumirt.defaultIfComputed(args.roleArn, "") === undefined) {
            throw new Error("Property argument 'roleArn' is required, but was missing");
        }
        this.roleArn = <any>args.roleArn;
        if (lumirt.defaultIfComputed(args.scalableDimension, "") === undefined) {
            throw new Error("Property argument 'scalableDimension' is required, but was missing");
        }
        this.scalableDimension = <any>args.scalableDimension;
        if (lumirt.defaultIfComputed(args.serviceNamespace, "") === undefined) {
            throw new Error("Property argument 'serviceNamespace' is required, but was missing");
        }
        this.serviceNamespace = <any>args.serviceNamespace;
    }
}

export interface TargetArgs {
    readonly maxCapacity: number;
    readonly minCapacity: number;
    readonly resourceId: string;
    readonly roleArn: string;
    readonly scalableDimension: string;
    readonly serviceNamespace: string;
}

