// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class Table extends lumi.NamedResource implements TableArgs {
    public /*out*/ readonly arn: string;
    public readonly attribute: { name: string, type: string }[];
    public readonly globalSecondaryIndex?: { hashKey: string, name: string, nonKeyAttributes?: string[], projectionType: string, rangeKey?: string, readCapacity: number, writeCapacity: number }[];
    public readonly hashKey: string;
    public readonly localSecondaryIndex?: { name: string, nonKeyAttributes?: string[], projectionType: string, rangeKey: string }[];
    public readonly tableName: string;
    public readonly rangeKey?: string;
    public readonly readCapacity: number;
    public /*out*/ readonly streamArn: string;
    public readonly streamEnabled: boolean;
    public /*out*/ readonly streamLabel: string;
    public readonly streamViewType: string;
    public readonly tags?: {[key: string]: any};
    public readonly ttl?: { attributeName: string, enabled: boolean }[];
    public readonly writeCapacity: number;

    public static get(id: lumi.ID): Table {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): Table[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(name: string, args: TableArgs) {
        super(name);
        if (lumirt.defaultIfComputed(args.attribute, "") === undefined) {
            throw new Error("Property argument 'attribute' is required, but was missing");
        }
        this.attribute = <any>args.attribute;
        this.globalSecondaryIndex = <any>args.globalSecondaryIndex;
        if (lumirt.defaultIfComputed(args.hashKey, "") === undefined) {
            throw new Error("Property argument 'hashKey' is required, but was missing");
        }
        this.hashKey = <any>args.hashKey;
        this.localSecondaryIndex = <any>args.localSecondaryIndex;
        this.tableName = <any>args.tableName;
        this.rangeKey = <any>args.rangeKey;
        if (lumirt.defaultIfComputed(args.readCapacity, "") === undefined) {
            throw new Error("Property argument 'readCapacity' is required, but was missing");
        }
        this.readCapacity = <any>args.readCapacity;
        this.streamEnabled = <any>args.streamEnabled;
        this.streamViewType = <any>args.streamViewType;
        this.tags = <any>args.tags;
        this.ttl = <any>args.ttl;
        if (lumirt.defaultIfComputed(args.writeCapacity, "") === undefined) {
            throw new Error("Property argument 'writeCapacity' is required, but was missing");
        }
        this.writeCapacity = <any>args.writeCapacity;
    }
}

export interface TableArgs {
    readonly attribute: { name: string, type: string }[];
    readonly globalSecondaryIndex?: { hashKey: string, name: string, nonKeyAttributes?: string[], projectionType: string, rangeKey?: string, readCapacity: number, writeCapacity: number }[];
    readonly hashKey: string;
    readonly localSecondaryIndex?: { name: string, nonKeyAttributes?: string[], projectionType: string, rangeKey: string }[];
    readonly tableName?: string;
    readonly rangeKey?: string;
    readonly readCapacity: number;
    readonly streamEnabled?: boolean;
    readonly streamViewType?: string;
    readonly tags?: {[key: string]: any};
    readonly ttl?: { attributeName: string, enabled: boolean }[];
    readonly writeCapacity: number;
}

