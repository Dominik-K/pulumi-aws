// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class LogMetricFilter extends lumi.NamedResource implements LogMetricFilterArgs {
    public readonly logGroupName: string;
    public readonly metricTransformation: { name: string, namespace: string, value: string }[];
    public readonly logMetricFilterName: string;
    public readonly pattern: string;

    public static get(id: lumi.ID): LogMetricFilter {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): LogMetricFilter[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(name: string, args: LogMetricFilterArgs) {
        super(name);
        if (lumirt.defaultIfComputed(args.logGroupName, "") === undefined) {
            throw new Error("Property argument 'logGroupName' is required, but was missing");
        }
        this.logGroupName = <any>args.logGroupName;
        if (lumirt.defaultIfComputed(args.metricTransformation, "") === undefined) {
            throw new Error("Property argument 'metricTransformation' is required, but was missing");
        }
        this.metricTransformation = <any>args.metricTransformation;
        this.logMetricFilterName = <any>args.logMetricFilterName;
        if (lumirt.defaultIfComputed(args.pattern, "") === undefined) {
            throw new Error("Property argument 'pattern' is required, but was missing");
        }
        this.pattern = <any>args.pattern;
    }
}

export interface LogMetricFilterArgs {
    readonly logGroupName: string;
    readonly metricTransformation: { name: string, namespace: string, value: string }[];
    readonly logMetricFilterName?: string;
    readonly pattern: string;
}

