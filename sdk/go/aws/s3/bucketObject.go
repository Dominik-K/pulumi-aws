// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package s3

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a S3 bucket object resource.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/s3_bucket_object.html.markdown.
type BucketObject struct {
	s *pulumi.ResourceState
}

// NewBucketObject registers a new resource with the given unique name, arguments, and options.
func NewBucketObject(ctx *pulumi.Context,
	name string, args *BucketObjectArgs, opts ...pulumi.ResourceOpt) (*BucketObject, error) {
	if args == nil || args.Bucket == nil {
		return nil, errors.New("missing required argument 'Bucket'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["acl"] = nil
		inputs["bucket"] = nil
		inputs["cacheControl"] = nil
		inputs["content"] = nil
		inputs["contentBase64"] = nil
		inputs["contentDisposition"] = nil
		inputs["contentEncoding"] = nil
		inputs["contentLanguage"] = nil
		inputs["contentType"] = nil
		inputs["etag"] = nil
		inputs["key"] = nil
		inputs["kmsKeyId"] = nil
		inputs["metadata"] = nil
		inputs["serverSideEncryption"] = nil
		inputs["source"] = nil
		inputs["storageClass"] = nil
		inputs["tags"] = nil
		inputs["websiteRedirect"] = nil
	} else {
		inputs["acl"] = args.Acl
		inputs["bucket"] = args.Bucket
		inputs["cacheControl"] = args.CacheControl
		inputs["content"] = args.Content
		inputs["contentBase64"] = args.ContentBase64
		inputs["contentDisposition"] = args.ContentDisposition
		inputs["contentEncoding"] = args.ContentEncoding
		inputs["contentLanguage"] = args.ContentLanguage
		inputs["contentType"] = args.ContentType
		inputs["etag"] = args.Etag
		inputs["key"] = args.Key
		inputs["kmsKeyId"] = args.KmsKeyId
		inputs["metadata"] = args.Metadata
		inputs["serverSideEncryption"] = args.ServerSideEncryption
		inputs["source"] = args.Source
		inputs["storageClass"] = args.StorageClass
		inputs["tags"] = args.Tags
		inputs["websiteRedirect"] = args.WebsiteRedirect
	}
	inputs["versionId"] = nil
	s, err := ctx.RegisterResource("aws:s3/bucketObject:BucketObject", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &BucketObject{s: s}, nil
}

// GetBucketObject gets an existing BucketObject resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBucketObject(ctx *pulumi.Context,
	name string, id pulumi.ID, state *BucketObjectState, opts ...pulumi.ResourceOpt) (*BucketObject, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["acl"] = state.Acl
		inputs["bucket"] = state.Bucket
		inputs["cacheControl"] = state.CacheControl
		inputs["content"] = state.Content
		inputs["contentBase64"] = state.ContentBase64
		inputs["contentDisposition"] = state.ContentDisposition
		inputs["contentEncoding"] = state.ContentEncoding
		inputs["contentLanguage"] = state.ContentLanguage
		inputs["contentType"] = state.ContentType
		inputs["etag"] = state.Etag
		inputs["key"] = state.Key
		inputs["kmsKeyId"] = state.KmsKeyId
		inputs["metadata"] = state.Metadata
		inputs["serverSideEncryption"] = state.ServerSideEncryption
		inputs["source"] = state.Source
		inputs["storageClass"] = state.StorageClass
		inputs["tags"] = state.Tags
		inputs["versionId"] = state.VersionId
		inputs["websiteRedirect"] = state.WebsiteRedirect
	}
	s, err := ctx.ReadResource("aws:s3/bucketObject:BucketObject", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &BucketObject{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *BucketObject) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *BucketObject) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// The [canned ACL](https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#canned-acl) to apply. Defaults to "private".
func (r *BucketObject) Acl() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["acl"])
}

// The name of the bucket to put the file in.
func (r *BucketObject) Bucket() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["bucket"])
}

// Specifies caching behavior along the request/reply chain Read [w3c cacheControl](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.9) for further details.
func (r *BucketObject) CacheControl() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["cacheControl"])
}

// Literal string value to use as the object content, which will be uploaded as UTF-8-encoded text.
func (r *BucketObject) Content() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["content"])
}

// Base64-encoded data that will be decoded and uploaded as raw bytes for the object content. This allows safely uploading non-UTF8 binary data, but is recommended only for small content such as the result of the `gzipbase64` function with small text strings. For larger objects, use `source` to stream the content from a disk file.
func (r *BucketObject) ContentBase64() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["contentBase64"])
}

// Specifies presentational information for the object. Read [w3c contentDisposition](http://www.w3.org/Protocols/rfc2616/rfc2616-sec19.html#sec19.5.1) for further information.
func (r *BucketObject) ContentDisposition() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["contentDisposition"])
}

// Specifies what content encodings have been applied to the object and thus what decoding mechanisms must be applied to obtain the media-type referenced by the Content-Type header field. Read [w3c content encoding](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.11) for further information.
func (r *BucketObject) ContentEncoding() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["contentEncoding"])
}

// The language the content is in e.g. en-US or en-GB.
func (r *BucketObject) ContentLanguage() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["contentLanguage"])
}

// A standard MIME type describing the format of the object data, e.g. application/octet-stream. All Valid MIME Types are valid for this input.
func (r *BucketObject) ContentType() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["contentType"])
}

// Used to trigger updates. The only meaningful value is `${filemd5("path/to/file")}` (this provider 0.11.12 or later) or `${md5(file("path/to/file"))}` (this provider 0.11.11 or earlier).
// This attribute is not compatible with KMS encryption, `kmsKeyId` or `serverSideEncryption = "aws:kms"`.
func (r *BucketObject) Etag() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["etag"])
}

// The name of the object once it is in the bucket.
func (r *BucketObject) Key() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["key"])
}

// Specifies the AWS KMS Key ARN to use for object encryption.
// This value is a fully qualified **ARN** of the KMS Key. If using `kms.Key`,
// use the exported `arn` attribute:
// `kmsKeyId = "${aws_kms_key.foo.arn}"`
func (r *BucketObject) KmsKeyId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["kmsKeyId"])
}

// A mapping of keys/values to provision metadata (will be automatically prefixed by `x-amz-meta-`, note that only lowercase label are currently supported by the AWS Go API).
func (r *BucketObject) Metadata() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["metadata"])
}

// Specifies server-side encryption of the object in S3. Valid values are "`AES256`" and "`aws:kms`".
func (r *BucketObject) ServerSideEncryption() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["serverSideEncryption"])
}

// The path to a file that will be read and uploaded as raw bytes for the object content.
func (r *BucketObject) Source() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["source"])
}

// Specifies the desired [Storage Class](http://docs.aws.amazon.com/AmazonS3/latest/dev/storage-class-intro.html)
// for the object. Can be either "`STANDARD`", "`REDUCED_REDUNDANCY`", "`ONEZONE_IA`", "`INTELLIGENT_TIERING`", "`GLACIER`", "`DEEP_ARCHIVE`", or "`STANDARD_IA`". Defaults to "`STANDARD`".
func (r *BucketObject) StorageClass() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["storageClass"])
}

// A mapping of tags to assign to the object.
func (r *BucketObject) Tags() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["tags"])
}

// A unique version ID value for the object, if bucket versioning
// is enabled.
func (r *BucketObject) VersionId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["versionId"])
}

// Specifies a target URL for [website redirect](http://docs.aws.amazon.com/AmazonS3/latest/dev/how-to-page-redirect.html).
func (r *BucketObject) WebsiteRedirect() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["websiteRedirect"])
}

// Input properties used for looking up and filtering BucketObject resources.
type BucketObjectState struct {
	// The [canned ACL](https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#canned-acl) to apply. Defaults to "private".
	Acl interface{}
	// The name of the bucket to put the file in.
	Bucket interface{}
	// Specifies caching behavior along the request/reply chain Read [w3c cacheControl](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.9) for further details.
	CacheControl interface{}
	// Literal string value to use as the object content, which will be uploaded as UTF-8-encoded text.
	Content interface{}
	// Base64-encoded data that will be decoded and uploaded as raw bytes for the object content. This allows safely uploading non-UTF8 binary data, but is recommended only for small content such as the result of the `gzipbase64` function with small text strings. For larger objects, use `source` to stream the content from a disk file.
	ContentBase64 interface{}
	// Specifies presentational information for the object. Read [w3c contentDisposition](http://www.w3.org/Protocols/rfc2616/rfc2616-sec19.html#sec19.5.1) for further information.
	ContentDisposition interface{}
	// Specifies what content encodings have been applied to the object and thus what decoding mechanisms must be applied to obtain the media-type referenced by the Content-Type header field. Read [w3c content encoding](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.11) for further information.
	ContentEncoding interface{}
	// The language the content is in e.g. en-US or en-GB.
	ContentLanguage interface{}
	// A standard MIME type describing the format of the object data, e.g. application/octet-stream. All Valid MIME Types are valid for this input.
	ContentType interface{}
	// Used to trigger updates. The only meaningful value is `${filemd5("path/to/file")}` (this provider 0.11.12 or later) or `${md5(file("path/to/file"))}` (this provider 0.11.11 or earlier).
	// This attribute is not compatible with KMS encryption, `kmsKeyId` or `serverSideEncryption = "aws:kms"`.
	Etag interface{}
	// The name of the object once it is in the bucket.
	Key interface{}
	// Specifies the AWS KMS Key ARN to use for object encryption.
	// This value is a fully qualified **ARN** of the KMS Key. If using `kms.Key`,
	// use the exported `arn` attribute:
	// `kmsKeyId = "${aws_kms_key.foo.arn}"`
	KmsKeyId interface{}
	// A mapping of keys/values to provision metadata (will be automatically prefixed by `x-amz-meta-`, note that only lowercase label are currently supported by the AWS Go API).
	Metadata interface{}
	// Specifies server-side encryption of the object in S3. Valid values are "`AES256`" and "`aws:kms`".
	ServerSideEncryption interface{}
	// The path to a file that will be read and uploaded as raw bytes for the object content.
	Source interface{}
	// Specifies the desired [Storage Class](http://docs.aws.amazon.com/AmazonS3/latest/dev/storage-class-intro.html)
	// for the object. Can be either "`STANDARD`", "`REDUCED_REDUNDANCY`", "`ONEZONE_IA`", "`INTELLIGENT_TIERING`", "`GLACIER`", "`DEEP_ARCHIVE`", or "`STANDARD_IA`". Defaults to "`STANDARD`".
	StorageClass interface{}
	// A mapping of tags to assign to the object.
	Tags interface{}
	// A unique version ID value for the object, if bucket versioning
	// is enabled.
	VersionId interface{}
	// Specifies a target URL for [website redirect](http://docs.aws.amazon.com/AmazonS3/latest/dev/how-to-page-redirect.html).
	WebsiteRedirect interface{}
}

// The set of arguments for constructing a BucketObject resource.
type BucketObjectArgs struct {
	// The [canned ACL](https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#canned-acl) to apply. Defaults to "private".
	Acl interface{}
	// The name of the bucket to put the file in.
	Bucket interface{}
	// Specifies caching behavior along the request/reply chain Read [w3c cacheControl](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.9) for further details.
	CacheControl interface{}
	// Literal string value to use as the object content, which will be uploaded as UTF-8-encoded text.
	Content interface{}
	// Base64-encoded data that will be decoded and uploaded as raw bytes for the object content. This allows safely uploading non-UTF8 binary data, but is recommended only for small content such as the result of the `gzipbase64` function with small text strings. For larger objects, use `source` to stream the content from a disk file.
	ContentBase64 interface{}
	// Specifies presentational information for the object. Read [w3c contentDisposition](http://www.w3.org/Protocols/rfc2616/rfc2616-sec19.html#sec19.5.1) for further information.
	ContentDisposition interface{}
	// Specifies what content encodings have been applied to the object and thus what decoding mechanisms must be applied to obtain the media-type referenced by the Content-Type header field. Read [w3c content encoding](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.11) for further information.
	ContentEncoding interface{}
	// The language the content is in e.g. en-US or en-GB.
	ContentLanguage interface{}
	// A standard MIME type describing the format of the object data, e.g. application/octet-stream. All Valid MIME Types are valid for this input.
	ContentType interface{}
	// Used to trigger updates. The only meaningful value is `${filemd5("path/to/file")}` (this provider 0.11.12 or later) or `${md5(file("path/to/file"))}` (this provider 0.11.11 or earlier).
	// This attribute is not compatible with KMS encryption, `kmsKeyId` or `serverSideEncryption = "aws:kms"`.
	Etag interface{}
	// The name of the object once it is in the bucket.
	Key interface{}
	// Specifies the AWS KMS Key ARN to use for object encryption.
	// This value is a fully qualified **ARN** of the KMS Key. If using `kms.Key`,
	// use the exported `arn` attribute:
	// `kmsKeyId = "${aws_kms_key.foo.arn}"`
	KmsKeyId interface{}
	// A mapping of keys/values to provision metadata (will be automatically prefixed by `x-amz-meta-`, note that only lowercase label are currently supported by the AWS Go API).
	Metadata interface{}
	// Specifies server-side encryption of the object in S3. Valid values are "`AES256`" and "`aws:kms`".
	ServerSideEncryption interface{}
	// The path to a file that will be read and uploaded as raw bytes for the object content.
	Source interface{}
	// Specifies the desired [Storage Class](http://docs.aws.amazon.com/AmazonS3/latest/dev/storage-class-intro.html)
	// for the object. Can be either "`STANDARD`", "`REDUCED_REDUNDANCY`", "`ONEZONE_IA`", "`INTELLIGENT_TIERING`", "`GLACIER`", "`DEEP_ARCHIVE`", or "`STANDARD_IA`". Defaults to "`STANDARD`".
	StorageClass interface{}
	// A mapping of tags to assign to the object.
	Tags interface{}
	// Specifies a target URL for [website redirect](http://docs.aws.amazon.com/AmazonS3/latest/dev/how-to-page-redirect.html).
	WebsiteRedirect interface{}
}
