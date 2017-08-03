// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class Group extends lumi.NamedResource implements GroupArgs {
    public /*out*/ readonly arn: string;
    public readonly availabilityZones: string[];
    public readonly defaultCooldown: number;
    public readonly desiredCapacity: number;
    public readonly enabledMetrics?: string[];
    public readonly forceDelete?: boolean;
    public readonly healthCheckGracePeriod?: number;
    public readonly healthCheckType: string;
    public readonly initialLifecycleHook?: { defaultResult: string, heartbeatTimeout?: number, lifecycleTransition: string, name: string, notificationMetadata?: string, notificationTargetArn?: string, roleArn?: string }[];
    public readonly launchConfiguration: string;
    public readonly loadBalancers: string[];
    public readonly maxSize: number;
    public readonly metricsGranularity?: string;
    public readonly minElbCapacity?: number;
    public readonly minSize: number;
    public readonly groupName: string;
    public readonly namePrefix?: string;
    public readonly placementGroup?: string;
    public readonly protectFromScaleIn?: boolean;
    public readonly suspendedProcesses?: string[];
    public readonly tag?: { key: string, propagateAtLaunch: boolean, value: string }[];
    public readonly tags?: {[key: string]: any}[];
    public readonly targetGroupArns: string[];
    public readonly terminationPolicies?: string[];
    public readonly vpcZoneIdentifier: string[];
    public readonly waitForCapacityTimeout?: string;
    public readonly waitForElbCapacity?: number;

    public static get(id: lumi.ID): Group {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): Group[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(name: string, args: GroupArgs) {
        super(name);
        this.availabilityZones = <any>args.availabilityZones;
        this.defaultCooldown = <any>args.defaultCooldown;
        this.desiredCapacity = <any>args.desiredCapacity;
        this.enabledMetrics = <any>args.enabledMetrics;
        this.forceDelete = <any>args.forceDelete;
        this.healthCheckGracePeriod = <any>args.healthCheckGracePeriod;
        this.healthCheckType = <any>args.healthCheckType;
        this.initialLifecycleHook = <any>args.initialLifecycleHook;
        if (lumirt.defaultIfComputed(args.launchConfiguration, "") === undefined) {
            throw new Error("Property argument 'launchConfiguration' is required, but was missing");
        }
        this.launchConfiguration = <any>args.launchConfiguration;
        this.loadBalancers = <any>args.loadBalancers;
        if (lumirt.defaultIfComputed(args.maxSize, "") === undefined) {
            throw new Error("Property argument 'maxSize' is required, but was missing");
        }
        this.maxSize = <any>args.maxSize;
        this.metricsGranularity = <any>args.metricsGranularity;
        this.minElbCapacity = <any>args.minElbCapacity;
        if (lumirt.defaultIfComputed(args.minSize, "") === undefined) {
            throw new Error("Property argument 'minSize' is required, but was missing");
        }
        this.minSize = <any>args.minSize;
        this.groupName = <any>args.groupName;
        this.namePrefix = <any>args.namePrefix;
        this.placementGroup = <any>args.placementGroup;
        this.protectFromScaleIn = <any>args.protectFromScaleIn;
        this.suspendedProcesses = <any>args.suspendedProcesses;
        this.tag = <any>args.tag;
        this.tags = <any>args.tags;
        this.targetGroupArns = <any>args.targetGroupArns;
        this.terminationPolicies = <any>args.terminationPolicies;
        this.vpcZoneIdentifier = <any>args.vpcZoneIdentifier;
        this.waitForCapacityTimeout = <any>args.waitForCapacityTimeout;
        this.waitForElbCapacity = <any>args.waitForElbCapacity;
    }
}

export interface GroupArgs {
    readonly availabilityZones?: string[];
    readonly defaultCooldown?: number;
    readonly desiredCapacity?: number;
    readonly enabledMetrics?: string[];
    readonly forceDelete?: boolean;
    readonly healthCheckGracePeriod?: number;
    readonly healthCheckType?: string;
    readonly initialLifecycleHook?: { defaultResult?: string, heartbeatTimeout?: number, lifecycleTransition: string, name: string, notificationMetadata?: string, notificationTargetArn?: string, roleArn?: string }[];
    readonly launchConfiguration: string;
    readonly loadBalancers?: string[];
    readonly maxSize: number;
    readonly metricsGranularity?: string;
    readonly minElbCapacity?: number;
    readonly minSize: number;
    readonly groupName?: string;
    readonly namePrefix?: string;
    readonly placementGroup?: string;
    readonly protectFromScaleIn?: boolean;
    readonly suspendedProcesses?: string[];
    readonly tag?: { key: string, propagateAtLaunch: boolean, value: string }[];
    readonly tags?: {[key: string]: any}[];
    readonly targetGroupArns?: string[];
    readonly terminationPolicies?: string[];
    readonly vpcZoneIdentifier?: string[];
    readonly waitForCapacityTimeout?: string;
    readonly waitForElbCapacity?: number;
}

