// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class PatchGroup extends lumi.NamedResource implements PatchGroupArgs {
    public readonly baselineId: string;
    public readonly patchGroup: string;

    public static get(id: lumi.ID): PatchGroup {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): PatchGroup[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(name: string, args: PatchGroupArgs) {
        super(name);
        if (lumirt.defaultIfComputed(args.baselineId, "") === undefined) {
            throw new Error("Property argument 'baselineId' is required, but was missing");
        }
        this.baselineId = <any>args.baselineId;
        if (lumirt.defaultIfComputed(args.patchGroup, "") === undefined) {
            throw new Error("Property argument 'patchGroup' is required, but was missing");
        }
        this.patchGroup = <any>args.patchGroup;
    }
}

export interface PatchGroupArgs {
    readonly baselineId: string;
    readonly patchGroup: string;
}

