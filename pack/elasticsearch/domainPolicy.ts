// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class DomainPolicy extends lumi.NamedResource implements DomainPolicyArgs {
    public readonly accessPolicies: string;
    public readonly domainName: string;

    public static get(id: lumi.ID): DomainPolicy {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): DomainPolicy[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(name: string, args: DomainPolicyArgs) {
        super(name);
        if (lumirt.defaultIfComputed(args.accessPolicies, "") === undefined) {
            throw new Error("Property argument 'accessPolicies' is required, but was missing");
        }
        this.accessPolicies = <any>args.accessPolicies;
        if (lumirt.defaultIfComputed(args.domainName, "") === undefined) {
            throw new Error("Property argument 'domainName' is required, but was missing");
        }
        this.domainName = <any>args.domainName;
    }
}

export interface DomainPolicyArgs {
    readonly accessPolicies: string;
    readonly domainName: string;
}

