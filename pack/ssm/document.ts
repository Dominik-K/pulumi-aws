// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class Document extends lumi.NamedResource implements DocumentArgs {
    public /*out*/ readonly arn: string;
    public readonly content: string;
    public /*out*/ readonly createdDate: string;
    public /*out*/ readonly defaultVersion: string;
    public /*out*/ readonly description: string;
    public readonly documentType: string;
    public /*out*/ readonly hash: string;
    public /*out*/ readonly hashType: string;
    public /*out*/ readonly latestVersion: string;
    public readonly documentName: string;
    public /*out*/ readonly owner: string;
    public /*out*/ readonly parameter: { defaultValue?: string, description?: string, name?: string, type?: string }[];
    public readonly permissions?: {[key: string]: { accountIds: string, type: string }};
    public /*out*/ readonly platformTypes: string[];
    public /*out*/ readonly schemaVersion: string;
    public /*out*/ readonly status: string;

    public static get(id: lumi.ID): Document {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): Document[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(name: string, args: DocumentArgs) {
        super(name);
        if (lumirt.defaultIfComputed(args.content, "") === undefined) {
            throw new Error("Property argument 'content' is required, but was missing");
        }
        this.content = <any>args.content;
        if (lumirt.defaultIfComputed(args.documentType, "") === undefined) {
            throw new Error("Property argument 'documentType' is required, but was missing");
        }
        this.documentType = <any>args.documentType;
        this.documentName = <any>args.documentName;
        this.permissions = <any>args.permissions;
    }
}

export interface DocumentArgs {
    readonly content: string;
    readonly documentType: string;
    readonly documentName?: string;
    readonly permissions?: {[key: string]: { accountIds: string, type: string }};
}

