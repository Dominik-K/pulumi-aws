// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class ListenerRule extends lumi.NamedResource implements ListenerRuleArgs {
    public readonly action: { targetGroupArn: string, type: string }[];
    public /*out*/ readonly arn: string;
    public readonly condition: { field?: string, values?: string[] }[];
    public readonly listenerArn: string;
    public readonly priority: number;

    public static get(id: lumi.ID): ListenerRule {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): ListenerRule[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(name: string, args: ListenerRuleArgs) {
        super(name);
        if (lumirt.defaultIfComputed(args.action, "") === undefined) {
            throw new Error("Property argument 'action' is required, but was missing");
        }
        this.action = <any>args.action;
        if (lumirt.defaultIfComputed(args.condition, "") === undefined) {
            throw new Error("Property argument 'condition' is required, but was missing");
        }
        this.condition = <any>args.condition;
        if (lumirt.defaultIfComputed(args.listenerArn, "") === undefined) {
            throw new Error("Property argument 'listenerArn' is required, but was missing");
        }
        this.listenerArn = <any>args.listenerArn;
        if (lumirt.defaultIfComputed(args.priority, "") === undefined) {
            throw new Error("Property argument 'priority' is required, but was missing");
        }
        this.priority = <any>args.priority;
    }
}

export interface ListenerRuleArgs {
    readonly action: { targetGroupArn: string, type: string }[];
    readonly condition: { field?: string, values?: string[] }[];
    readonly listenerArn: string;
    readonly priority: number;
}

