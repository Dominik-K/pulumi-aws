# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class BucketNotification(pulumi.CustomResource):
    bucket: pulumi.Output[str]
    """
    The name of the bucket to put notification configuration.
    """
    lambda_functions: pulumi.Output[list]
    """
    Used to configure notifications to a Lambda Function (documented below).
    """
    queues: pulumi.Output[list]
    """
    The notification configuration to SQS Queue (documented below).
    """
    topics: pulumi.Output[list]
    """
    The notification configuration to SNS Topic (documented below).
    """
    def __init__(__self__, resource_name, opts=None, bucket=None, lambda_functions=None, queues=None, topics=None, __name__=None, __opts__=None):
        """
        Manages a S3 Bucket Notification Configuration. For additional information, see the [Configuring S3 Event Notifications section in the Amazon S3 Developer Guide](https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html).
        
        > **NOTE:** S3 Buckets only support a single notification configuration. Declaring multiple `s3.BucketNotification` resources to the same S3 Bucket will cause a perpetual difference in configuration.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] bucket: The name of the bucket to put notification configuration.
        :param pulumi.Input[list] lambda_functions: Used to configure notifications to a Lambda Function (documented below).
        :param pulumi.Input[list] queues: The notification configuration to SQS Queue (documented below).
        :param pulumi.Input[list] topics: The notification configuration to SNS Topic (documented below).

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/s3_bucket_notification.html.markdown.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if not resource_name:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(resource_name, str):
            raise TypeError('Expected resource name to be a string')
        if opts and not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if bucket is None:
            raise TypeError("Missing required property 'bucket'")
        __props__['bucket'] = bucket

        __props__['lambda_functions'] = lambda_functions

        __props__['queues'] = queues

        __props__['topics'] = topics

        if opts is None:
            opts = pulumi.ResourceOptions()
        if opts.version is None:
            opts.version = utilities.get_version()
        super(BucketNotification, __self__).__init__(
            'aws:s3/bucketNotification:BucketNotification',
            resource_name,
            __props__,
            opts)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

