// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class SpotDatafeedSubscription extends lumi.NamedResource implements SpotDatafeedSubscriptionArgs {
    public readonly bucket: string;
    public readonly prefix?: string;

    public static get(id: lumi.ID): SpotDatafeedSubscription {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): SpotDatafeedSubscription[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(name: string, args: SpotDatafeedSubscriptionArgs) {
        super(name);
        if (lumirt.defaultIfComputed(args.bucket, "") === undefined) {
            throw new Error("Property argument 'bucket' is required, but was missing");
        }
        this.bucket = <any>args.bucket;
        this.prefix = <any>args.prefix;
    }
}

export interface SpotDatafeedSubscriptionArgs {
    readonly bucket: string;
    readonly prefix?: string;
}

