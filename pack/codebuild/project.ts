// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class Project extends lumi.NamedResource implements ProjectArgs {
    public readonly artifacts: { location?: string, name?: string, namespaceType?: string, packaging?: string, path?: string, type: string }[];
    public readonly buildTimeout?: number;
    public readonly description: string;
    public readonly encryptionKey: string;
    public readonly environment: { computeType: string, environmentVariable: { name: string, value: string }[], image: string, privilegedMode?: boolean, type: string }[];
    public readonly projectName: string;
    public readonly serviceRole: string;
    public readonly source: { auth?: { resource?: string, type: string }[], buildspec?: string, location?: string, type: string }[];
    public readonly tags?: {[key: string]: any};

    public static get(id: lumi.ID): Project {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): Project[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(name: string, args: ProjectArgs) {
        super(name);
        if (lumirt.defaultIfComputed(args.artifacts, "") === undefined) {
            throw new Error("Property argument 'artifacts' is required, but was missing");
        }
        this.artifacts = <any>args.artifacts;
        this.buildTimeout = <any>args.buildTimeout;
        this.description = <any>args.description;
        this.encryptionKey = <any>args.encryptionKey;
        if (lumirt.defaultIfComputed(args.environment, "") === undefined) {
            throw new Error("Property argument 'environment' is required, but was missing");
        }
        this.environment = <any>args.environment;
        this.projectName = <any>args.projectName;
        this.serviceRole = <any>args.serviceRole;
        if (lumirt.defaultIfComputed(args.source, "") === undefined) {
            throw new Error("Property argument 'source' is required, but was missing");
        }
        this.source = <any>args.source;
        this.tags = <any>args.tags;
    }
}

export interface ProjectArgs {
    readonly artifacts: { location?: string, name?: string, namespaceType?: string, packaging?: string, path?: string, type: string }[];
    readonly buildTimeout?: number;
    readonly description?: string;
    readonly encryptionKey?: string;
    readonly environment: { computeType: string, environmentVariable?: { name: string, value: string }[], image: string, privilegedMode?: boolean, type: string }[];
    readonly projectName?: string;
    readonly serviceRole?: string;
    readonly source: { auth?: { resource?: string, type: string }[], buildspec?: string, location?: string, type: string }[];
    readonly tags?: {[key: string]: any};
}

