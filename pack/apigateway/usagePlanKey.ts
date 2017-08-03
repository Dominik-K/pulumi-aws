// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class UsagePlanKey extends lumi.NamedResource implements UsagePlanKeyArgs {
    public readonly keyId: string;
    public readonly keyType: string;
    public /*out*/ readonly usagePlanKeyName: string;
    public readonly usagePlanId: string;
    public /*out*/ readonly value: string;

    public static get(id: lumi.ID): UsagePlanKey {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): UsagePlanKey[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(name: string, args: UsagePlanKeyArgs) {
        super(name);
        if (lumirt.defaultIfComputed(args.keyId, "") === undefined) {
            throw new Error("Property argument 'keyId' is required, but was missing");
        }
        this.keyId = <any>args.keyId;
        if (lumirt.defaultIfComputed(args.keyType, "") === undefined) {
            throw new Error("Property argument 'keyType' is required, but was missing");
        }
        this.keyType = <any>args.keyType;
        if (lumirt.defaultIfComputed(args.usagePlanId, "") === undefined) {
            throw new Error("Property argument 'usagePlanId' is required, but was missing");
        }
        this.usagePlanId = <any>args.usagePlanId;
    }
}

export interface UsagePlanKeyArgs {
    readonly keyId: string;
    readonly keyType: string;
    readonly usagePlanId: string;
}

