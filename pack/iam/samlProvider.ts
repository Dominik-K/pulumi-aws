// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class SamlProvider extends lumi.NamedResource implements SamlProviderArgs {
    public /*out*/ readonly arn: string;
    public readonly samlProviderName: string;
    public readonly samlMetadataDocument: string;
    public /*out*/ readonly validUntil: string;

    public static get(id: lumi.ID): SamlProvider {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): SamlProvider[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(name: string, args: SamlProviderArgs) {
        super(name);
        this.samlProviderName = <any>args.samlProviderName;
        if (lumirt.defaultIfComputed(args.samlMetadataDocument, "") === undefined) {
            throw new Error("Property argument 'samlMetadataDocument' is required, but was missing");
        }
        this.samlMetadataDocument = <any>args.samlMetadataDocument;
    }
}

export interface SamlProviderArgs {
    readonly samlProviderName?: string;
    readonly samlMetadataDocument: string;
}

