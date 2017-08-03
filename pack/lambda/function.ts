// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

import {ARN} from "../index";

export class Function extends lumi.NamedResource implements FunctionArgs {
    public /*out*/ readonly arn: string;
    public readonly deadLetterConfig?: { targetArn: string }[];
    public readonly description?: string;
    public readonly environment?: { variables?: {[key: string]: string} }[];
    public readonly code?: lumi.asset.Archive;
    public readonly functionName: string;
    public readonly handler: string;
    public /*out*/ readonly invokeArn: string;
    public readonly kmsKeyArn?: string;
    public /*out*/ readonly lastModified: string;
    public readonly memorySize?: number;
    public readonly publish?: boolean;
    public /*out*/ readonly qualifiedArn: string;
    public readonly role: ARN;
    public readonly runtime: string;
    public readonly s3Bucket?: string;
    public readonly s3Key?: string;
    public readonly s3ObjectVersion?: string;
    public readonly sourceCodeHash: string;
    public readonly tags?: {[key: string]: any};
    public readonly timeout?: number;
    public readonly tracingConfig: { mode: string }[];
    public /*out*/ readonly version: string;
    public readonly vpcConfig?: { securityGroupIds: string[], subnetIds: string[], vpcId: string }[];

    public static get(id: lumi.ID): Function {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): Function[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(name: string, args: FunctionArgs) {
        super(name);
        this.deadLetterConfig = <any>args.deadLetterConfig;
        this.description = <any>args.description;
        this.environment = <any>args.environment;
        this.code = <any>args.code;
        this.functionName = <any>args.functionName;
        if (lumirt.defaultIfComputed(args.handler, "") === undefined) {
            throw new Error("Property argument 'handler' is required, but was missing");
        }
        this.handler = <any>args.handler;
        this.kmsKeyArn = <any>args.kmsKeyArn;
        this.memorySize = <any>args.memorySize;
        this.publish = <any>args.publish;
        if (lumirt.defaultIfComputed(args.role, "") === undefined) {
            throw new Error("Property argument 'role' is required, but was missing");
        }
        this.role = <any>args.role;
        if (lumirt.defaultIfComputed(args.runtime, "") === undefined) {
            throw new Error("Property argument 'runtime' is required, but was missing");
        }
        this.runtime = <any>args.runtime;
        this.s3Bucket = <any>args.s3Bucket;
        this.s3Key = <any>args.s3Key;
        this.s3ObjectVersion = <any>args.s3ObjectVersion;
        this.sourceCodeHash = <any>args.sourceCodeHash;
        this.tags = <any>args.tags;
        this.timeout = <any>args.timeout;
        this.tracingConfig = <any>args.tracingConfig;
        this.vpcConfig = <any>args.vpcConfig;
    }
}

export interface FunctionArgs {
    readonly deadLetterConfig?: { targetArn: string }[];
    readonly description?: string;
    readonly environment?: { variables?: {[key: string]: string} }[];
    readonly code?: lumi.asset.Archive;
    readonly functionName?: string;
    readonly handler: string;
    readonly kmsKeyArn?: string;
    readonly memorySize?: number;
    readonly publish?: boolean;
    readonly role: ARN;
    readonly runtime: string;
    readonly s3Bucket?: string;
    readonly s3Key?: string;
    readonly s3ObjectVersion?: string;
    readonly sourceCodeHash?: string;
    readonly tags?: {[key: string]: any};
    readonly timeout?: number;
    readonly tracingConfig?: { mode: string }[];
    readonly vpcConfig?: { securityGroupIds: string[], subnetIds: string[], vpcId?: string }[];
}

