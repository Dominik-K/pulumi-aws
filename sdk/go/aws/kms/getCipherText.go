// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package kms

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The KMS ciphertext data source allows you to encrypt plaintext into ciphertext
// by using an AWS KMS customer master key. The value returned by this data source
// changes every apply. For a stable ciphertext value, see the `kms.Ciphertext`
// resource.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"fmt"
//
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/kms"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		oauthConfig, err := kms.NewKey(ctx, "oauthConfig", &kms.KeyArgs{
// 			Description: pulumi.String("oauth config"),
// 			IsEnabled:   pulumi.Bool(true),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetCipherText(ctx *pulumi.Context, args *GetCipherTextArgs, opts ...pulumi.InvokeOption) (*GetCipherTextResult, error) {
	var rv GetCipherTextResult
	err := ctx.Invoke("aws:kms/getCipherText:getCipherText", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getCipherText.
type GetCipherTextArgs struct {
	// An optional mapping that makes up the encryption context.
	Context map[string]string `pulumi:"context"`
	// Globally unique key ID for the customer master key.
	KeyId string `pulumi:"keyId"`
	// Data to be encrypted. Note that this may show up in logs, and it will be stored in the state file.
	Plaintext string `pulumi:"plaintext"`
}

// A collection of values returned by getCipherText.
type GetCipherTextResult struct {
	// Base64 encoded ciphertext
	CiphertextBlob string            `pulumi:"ciphertextBlob"`
	Context        map[string]string `pulumi:"context"`
	// The provider-assigned unique ID for this managed resource.
	Id        string `pulumi:"id"`
	KeyId     string `pulumi:"keyId"`
	Plaintext string `pulumi:"plaintext"`
}
