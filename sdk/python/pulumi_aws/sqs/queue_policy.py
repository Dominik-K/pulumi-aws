# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class QueuePolicy(pulumi.CustomResource):
    policy: pulumi.Output[str]
    """
    The JSON policy for the SQS queue.
    """
    queue_url: pulumi.Output[str]
    """
    The URL of the SQS Queue to which to attach the policy
    """
    def __init__(__self__, resource_name, opts=None, policy=None, queue_url=None, __name__=None, __opts__=None):
        """
        Allows you to set a policy of an SQS Queue
        while referencing ARN of the queue within the policy.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] policy: The JSON policy for the SQS queue.
        :param pulumi.Input[str] queue_url: The URL of the SQS Queue to which to attach the policy

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/sqs_queue_policy.html.markdown.
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

        if policy is None:
            raise TypeError("Missing required property 'policy'")
        __props__['policy'] = policy

        if queue_url is None:
            raise TypeError("Missing required property 'queue_url'")
        __props__['queue_url'] = queue_url

        if opts is None:
            opts = pulumi.ResourceOptions()
        if opts.version is None:
            opts.version = utilities.get_version()
        super(QueuePolicy, __self__).__init__(
            'aws:sqs/queuePolicy:QueuePolicy',
            resource_name,
            __props__,
            opts)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

