// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class Preset extends lumi.NamedResource implements PresetArgs {
    public /*out*/ readonly arn: string;
    public readonly audio?: { audioPackingMode?: string, bitRate?: string, channels?: string, codec?: string, sampleRate?: string }[];
    public readonly audioCodecOptions?: { bitDepth?: string, bitOrder?: string, profile?: string, signed?: string }[];
    public readonly container: string;
    public readonly description?: string;
    public readonly presetName: string;
    public readonly thumbnails?: { aspectRatio?: string, format?: string, interval?: string, maxHeight?: string, maxWidth?: string, paddingPolicy?: string, resolution?: string, sizingPolicy?: string }[];
    public readonly type: string;
    public readonly video?: { aspectRatio?: string, bitRate?: string, codec?: string, displayAspectRatio?: string, fixedGop?: string, frameRate?: string, keyframesMaxDist?: string, maxFrameRate?: string, maxHeight?: string, maxWidth?: string, paddingPolicy?: string, resolution?: string, sizingPolicy?: string }[];
    public readonly videoCodecOptions?: {[key: string]: any};
    public readonly videoWatermarks?: { horizontalAlign?: string, horizontalOffset?: string, id?: string, maxHeight?: string, maxWidth?: string, opacity?: string, sizingPolicy?: string, target?: string, verticalAlign?: string, verticalOffset?: string }[];

    public static get(id: lumi.ID): Preset {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): Preset[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(name: string, args: PresetArgs) {
        super(name);
        this.audio = <any>args.audio;
        this.audioCodecOptions = <any>args.audioCodecOptions;
        if (lumirt.defaultIfComputed(args.container, "") === undefined) {
            throw new Error("Property argument 'container' is required, but was missing");
        }
        this.container = <any>args.container;
        this.description = <any>args.description;
        this.presetName = <any>args.presetName;
        this.thumbnails = <any>args.thumbnails;
        this.type = <any>args.type;
        this.video = <any>args.video;
        this.videoCodecOptions = <any>args.videoCodecOptions;
        this.videoWatermarks = <any>args.videoWatermarks;
    }
}

export interface PresetArgs {
    readonly audio?: { audioPackingMode?: string, bitRate?: string, channels?: string, codec?: string, sampleRate?: string }[];
    readonly audioCodecOptions?: { bitDepth?: string, bitOrder?: string, profile?: string, signed?: string }[];
    readonly container: string;
    readonly description?: string;
    readonly presetName?: string;
    readonly thumbnails?: { aspectRatio?: string, format?: string, interval?: string, maxHeight?: string, maxWidth?: string, paddingPolicy?: string, resolution?: string, sizingPolicy?: string }[];
    readonly type?: string;
    readonly video?: { aspectRatio?: string, bitRate?: string, codec?: string, displayAspectRatio?: string, fixedGop?: string, frameRate?: string, keyframesMaxDist?: string, maxFrameRate?: string, maxHeight?: string, maxWidth?: string, paddingPolicy?: string, resolution?: string, sizingPolicy?: string }[];
    readonly videoCodecOptions?: {[key: string]: any};
    readonly videoWatermarks?: { horizontalAlign?: string, horizontalOffset?: string, id?: string, maxHeight?: string, maxWidth?: string, opacity?: string, sizingPolicy?: string, target?: string, verticalAlign?: string, verticalOffset?: string }[];
}

