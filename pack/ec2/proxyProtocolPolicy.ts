// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class ProxyProtocolPolicy extends lumi.NamedResource implements ProxyProtocolPolicyArgs {
    public readonly instancePorts: string[];
    public readonly loadBalancer: string;

    public static get(id: lumi.ID): ProxyProtocolPolicy {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): ProxyProtocolPolicy[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(name: string, args: ProxyProtocolPolicyArgs) {
        super(name);
        if (lumirt.defaultIfComputed(args.instancePorts, "") === undefined) {
            throw new Error("Property argument 'instancePorts' is required, but was missing");
        }
        this.instancePorts = <any>args.instancePorts;
        if (lumirt.defaultIfComputed(args.loadBalancer, "") === undefined) {
            throw new Error("Property argument 'loadBalancer' is required, but was missing");
        }
        this.loadBalancer = <any>args.loadBalancer;
    }
}

export interface ProxyProtocolPolicyArgs {
    readonly instancePorts: string[];
    readonly loadBalancer: string;
}

