# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from .. import _utilities, _tables
from . import outputs
from ._inputs import *

__all__ = ['Trail']


class Trail(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cloud_watch_logs_group_arn: Optional[pulumi.Input[str]] = None,
                 cloud_watch_logs_role_arn: Optional[pulumi.Input[str]] = None,
                 enable_log_file_validation: Optional[pulumi.Input[bool]] = None,
                 enable_logging: Optional[pulumi.Input[bool]] = None,
                 event_selectors: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TrailEventSelectorArgs']]]]] = None,
                 include_global_service_events: Optional[pulumi.Input[bool]] = None,
                 insight_selectors: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TrailInsightSelectorArgs']]]]] = None,
                 is_multi_region_trail: Optional[pulumi.Input[bool]] = None,
                 is_organization_trail: Optional[pulumi.Input[bool]] = None,
                 kms_key_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 s3_bucket_name: Optional[pulumi.Input[str]] = None,
                 s3_key_prefix: Optional[pulumi.Input[str]] = None,
                 sns_topic_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Provides a CloudTrail resource.

        > *NOTE:* For a multi-region trail, this resource must be in the home region of the trail.

        > *NOTE:* For an organization trail, this resource must be in the master account of the organization.

        ## Example Usage
        ### Basic

        Enable CloudTrail to capture all compatible management events in region.
        For capturing events from services like IAM, `include_global_service_events` must be enabled.

        ```python
        import pulumi
        import pulumi_aws as aws

        current = aws.get_caller_identity()
        foo = aws.s3.Bucket("foo",
            force_destroy=True,
            policy=f\"\"\"{{
            "Version": "2012-10-17",
            "Statement": [
                {{
                    "Sid": "AWSCloudTrailAclCheck",
                    "Effect": "Allow",
                    "Principal": {{
                      "Service": "cloudtrail.amazonaws.com"
                    }},
                    "Action": "s3:GetBucketAcl",
                    "Resource": "arn:aws:s3:::tf-test-trail"
                }},
                {{
                    "Sid": "AWSCloudTrailWrite",
                    "Effect": "Allow",
                    "Principal": {{
                      "Service": "cloudtrail.amazonaws.com"
                    }},
                    "Action": "s3:PutObject",
                    "Resource": "arn:aws:s3:::tf-test-trail/prefix/AWSLogs/{current.account_id}/*",
                    "Condition": {{
                        "StringEquals": {{
                            "s3:x-amz-acl": "bucket-owner-full-control"
                        }}
                    }}
                }}
            ]
        }}
        \"\"\")
        foobar = aws.cloudtrail.Trail("foobar",
            s3_bucket_name=foo.id,
            s3_key_prefix="prefix",
            include_global_service_events=False)
        ```
        ### Data Event Logging

        CloudTrail can log [Data Events](https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-data-events-with-cloudtrail.html) for certain services such as S3 bucket objects and Lambda function invocations. Additional information about data event configuration can be found in the [CloudTrail API DataResource documentation](https://docs.aws.amazon.com/awscloudtrail/latest/APIReference/API_DataResource.html).
        ### Logging All Lambda Function Invocations

        ```python
        import pulumi
        import pulumi_aws as aws

        example = aws.cloudtrail.Trail("example", event_selectors=[aws.cloudtrail.TrailEventSelectorArgs(
            data_resources=[aws.cloudtrail.TrailEventSelectorDataResourceArgs(
                type="AWS::Lambda::Function",
                values=["arn:aws:lambda"],
            )],
            include_management_events=True,
            read_write_type="All",
        )])
        ```
        ### Logging All S3 Bucket Object Events

        ```python
        import pulumi
        import pulumi_aws as aws

        example = aws.cloudtrail.Trail("example", event_selectors=[aws.cloudtrail.TrailEventSelectorArgs(
            data_resources=[aws.cloudtrail.TrailEventSelectorDataResourceArgs(
                type="AWS::S3::Object",
                values=["arn:aws:s3:::"],
            )],
            include_management_events=True,
            read_write_type="All",
        )])
        ```
        ### Logging Individual S3 Bucket Events

        ```python
        import pulumi
        import pulumi_aws as aws

        important_bucket = aws.s3.get_bucket(bucket="important-bucket")
        example = aws.cloudtrail.Trail("example", event_selectors=[aws.cloudtrail.TrailEventSelectorArgs(
            data_resources=[aws.cloudtrail.TrailEventSelectorDataResourceArgs(
                type="AWS::S3::Object",
                values=[f"{important_bucket.arn}/"],
            )],
            include_management_events=True,
            read_write_type="All",
        )])
        ```
        ### Sending Events to CloudWatch Logs

        ```python
        import pulumi
        import pulumi_aws as aws

        example_log_group = aws.cloudwatch.LogGroup("exampleLogGroup")
        example_trail = aws.cloudtrail.Trail("exampleTrail", cloud_watch_logs_group_arn=example_log_group.arn.apply(lambda arn: f"{arn}:*"))
        # CloudTrail requires the Log Stream wildcard
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cloud_watch_logs_group_arn: Specifies a log group name using an Amazon Resource Name (ARN),
               that represents the log group to which CloudTrail logs will be delivered. Note that CloudTrail requires the Log Stream wildcard.
        :param pulumi.Input[str] cloud_watch_logs_role_arn: Specifies the role for the CloudWatch Logs
               endpoint to assume to write to a user’s log group.
        :param pulumi.Input[bool] enable_log_file_validation: Specifies whether log file integrity validation is enabled.
               Defaults to `false`.
        :param pulumi.Input[bool] enable_logging: Enables logging for the trail. Defaults to `true`.
               Setting this to `false` will pause logging.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TrailEventSelectorArgs']]]] event_selectors: Specifies an event selector for enabling data event logging. Fields documented below. Please note the [CloudTrail limits](https://docs.aws.amazon.com/awscloudtrail/latest/userguide/WhatIsCloudTrail-Limits.html) when configuring these.
        :param pulumi.Input[bool] include_global_service_events: Specifies whether the trail is publishing events
               from global services such as IAM to the log files. Defaults to `true`.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TrailInsightSelectorArgs']]]] insight_selectors: Specifies an insight selector for identifying unusual operational activity. Fields documented below.
        :param pulumi.Input[bool] is_multi_region_trail: Specifies whether the trail is created in the current
               region or in all regions. Defaults to `false`.
        :param pulumi.Input[bool] is_organization_trail: Specifies whether the trail is an AWS Organizations trail. Organization trails log events for the master account and all member accounts. Can only be created in the organization master account. Defaults to `false`.
        :param pulumi.Input[str] kms_key_id: Specifies the KMS key ARN to use to encrypt the logs delivered by CloudTrail.
        :param pulumi.Input[str] name: Specifies the name of the trail.
        :param pulumi.Input[str] s3_bucket_name: Specifies the name of the S3 bucket designated for publishing log files.
        :param pulumi.Input[str] s3_key_prefix: Specifies the S3 key prefix that follows
               the name of the bucket you have designated for log file delivery.
        :param pulumi.Input[str] sns_topic_name: Specifies the name of the Amazon SNS topic
               defined for notification of log file delivery.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: A map of tags to assign to the trail
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['cloud_watch_logs_group_arn'] = cloud_watch_logs_group_arn
            __props__['cloud_watch_logs_role_arn'] = cloud_watch_logs_role_arn
            __props__['enable_log_file_validation'] = enable_log_file_validation
            __props__['enable_logging'] = enable_logging
            __props__['event_selectors'] = event_selectors
            __props__['include_global_service_events'] = include_global_service_events
            __props__['insight_selectors'] = insight_selectors
            __props__['is_multi_region_trail'] = is_multi_region_trail
            __props__['is_organization_trail'] = is_organization_trail
            __props__['kms_key_id'] = kms_key_id
            __props__['name'] = name
            if s3_bucket_name is None:
                raise TypeError("Missing required property 's3_bucket_name'")
            __props__['s3_bucket_name'] = s3_bucket_name
            __props__['s3_key_prefix'] = s3_key_prefix
            __props__['sns_topic_name'] = sns_topic_name
            __props__['tags'] = tags
            __props__['arn'] = None
            __props__['home_region'] = None
        super(Trail, __self__).__init__(
            'aws:cloudtrail/trail:Trail',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            arn: Optional[pulumi.Input[str]] = None,
            cloud_watch_logs_group_arn: Optional[pulumi.Input[str]] = None,
            cloud_watch_logs_role_arn: Optional[pulumi.Input[str]] = None,
            enable_log_file_validation: Optional[pulumi.Input[bool]] = None,
            enable_logging: Optional[pulumi.Input[bool]] = None,
            event_selectors: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TrailEventSelectorArgs']]]]] = None,
            home_region: Optional[pulumi.Input[str]] = None,
            include_global_service_events: Optional[pulumi.Input[bool]] = None,
            insight_selectors: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TrailInsightSelectorArgs']]]]] = None,
            is_multi_region_trail: Optional[pulumi.Input[bool]] = None,
            is_organization_trail: Optional[pulumi.Input[bool]] = None,
            kms_key_id: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            s3_bucket_name: Optional[pulumi.Input[str]] = None,
            s3_key_prefix: Optional[pulumi.Input[str]] = None,
            sns_topic_name: Optional[pulumi.Input[str]] = None,
            tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None) -> 'Trail':
        """
        Get an existing Trail resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] arn: The Amazon Resource Name of the trail.
        :param pulumi.Input[str] cloud_watch_logs_group_arn: Specifies a log group name using an Amazon Resource Name (ARN),
               that represents the log group to which CloudTrail logs will be delivered. Note that CloudTrail requires the Log Stream wildcard.
        :param pulumi.Input[str] cloud_watch_logs_role_arn: Specifies the role for the CloudWatch Logs
               endpoint to assume to write to a user’s log group.
        :param pulumi.Input[bool] enable_log_file_validation: Specifies whether log file integrity validation is enabled.
               Defaults to `false`.
        :param pulumi.Input[bool] enable_logging: Enables logging for the trail. Defaults to `true`.
               Setting this to `false` will pause logging.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TrailEventSelectorArgs']]]] event_selectors: Specifies an event selector for enabling data event logging. Fields documented below. Please note the [CloudTrail limits](https://docs.aws.amazon.com/awscloudtrail/latest/userguide/WhatIsCloudTrail-Limits.html) when configuring these.
        :param pulumi.Input[str] home_region: The region in which the trail was created.
        :param pulumi.Input[bool] include_global_service_events: Specifies whether the trail is publishing events
               from global services such as IAM to the log files. Defaults to `true`.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TrailInsightSelectorArgs']]]] insight_selectors: Specifies an insight selector for identifying unusual operational activity. Fields documented below.
        :param pulumi.Input[bool] is_multi_region_trail: Specifies whether the trail is created in the current
               region or in all regions. Defaults to `false`.
        :param pulumi.Input[bool] is_organization_trail: Specifies whether the trail is an AWS Organizations trail. Organization trails log events for the master account and all member accounts. Can only be created in the organization master account. Defaults to `false`.
        :param pulumi.Input[str] kms_key_id: Specifies the KMS key ARN to use to encrypt the logs delivered by CloudTrail.
        :param pulumi.Input[str] name: Specifies the name of the trail.
        :param pulumi.Input[str] s3_bucket_name: Specifies the name of the S3 bucket designated for publishing log files.
        :param pulumi.Input[str] s3_key_prefix: Specifies the S3 key prefix that follows
               the name of the bucket you have designated for log file delivery.
        :param pulumi.Input[str] sns_topic_name: Specifies the name of the Amazon SNS topic
               defined for notification of log file delivery.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: A map of tags to assign to the trail
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["arn"] = arn
        __props__["cloud_watch_logs_group_arn"] = cloud_watch_logs_group_arn
        __props__["cloud_watch_logs_role_arn"] = cloud_watch_logs_role_arn
        __props__["enable_log_file_validation"] = enable_log_file_validation
        __props__["enable_logging"] = enable_logging
        __props__["event_selectors"] = event_selectors
        __props__["home_region"] = home_region
        __props__["include_global_service_events"] = include_global_service_events
        __props__["insight_selectors"] = insight_selectors
        __props__["is_multi_region_trail"] = is_multi_region_trail
        __props__["is_organization_trail"] = is_organization_trail
        __props__["kms_key_id"] = kms_key_id
        __props__["name"] = name
        __props__["s3_bucket_name"] = s3_bucket_name
        __props__["s3_key_prefix"] = s3_key_prefix
        __props__["sns_topic_name"] = sns_topic_name
        __props__["tags"] = tags
        return Trail(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def arn(self) -> pulumi.Output[str]:
        """
        The Amazon Resource Name of the trail.
        """
        return pulumi.get(self, "arn")

    @property
    @pulumi.getter(name="cloudWatchLogsGroupArn")
    def cloud_watch_logs_group_arn(self) -> pulumi.Output[Optional[str]]:
        """
        Specifies a log group name using an Amazon Resource Name (ARN),
        that represents the log group to which CloudTrail logs will be delivered. Note that CloudTrail requires the Log Stream wildcard.
        """
        return pulumi.get(self, "cloud_watch_logs_group_arn")

    @property
    @pulumi.getter(name="cloudWatchLogsRoleArn")
    def cloud_watch_logs_role_arn(self) -> pulumi.Output[Optional[str]]:
        """
        Specifies the role for the CloudWatch Logs
        endpoint to assume to write to a user’s log group.
        """
        return pulumi.get(self, "cloud_watch_logs_role_arn")

    @property
    @pulumi.getter(name="enableLogFileValidation")
    def enable_log_file_validation(self) -> pulumi.Output[Optional[bool]]:
        """
        Specifies whether log file integrity validation is enabled.
        Defaults to `false`.
        """
        return pulumi.get(self, "enable_log_file_validation")

    @property
    @pulumi.getter(name="enableLogging")
    def enable_logging(self) -> pulumi.Output[Optional[bool]]:
        """
        Enables logging for the trail. Defaults to `true`.
        Setting this to `false` will pause logging.
        """
        return pulumi.get(self, "enable_logging")

    @property
    @pulumi.getter(name="eventSelectors")
    def event_selectors(self) -> pulumi.Output[Optional[Sequence['outputs.TrailEventSelector']]]:
        """
        Specifies an event selector for enabling data event logging. Fields documented below. Please note the [CloudTrail limits](https://docs.aws.amazon.com/awscloudtrail/latest/userguide/WhatIsCloudTrail-Limits.html) when configuring these.
        """
        return pulumi.get(self, "event_selectors")

    @property
    @pulumi.getter(name="homeRegion")
    def home_region(self) -> pulumi.Output[str]:
        """
        The region in which the trail was created.
        """
        return pulumi.get(self, "home_region")

    @property
    @pulumi.getter(name="includeGlobalServiceEvents")
    def include_global_service_events(self) -> pulumi.Output[Optional[bool]]:
        """
        Specifies whether the trail is publishing events
        from global services such as IAM to the log files. Defaults to `true`.
        """
        return pulumi.get(self, "include_global_service_events")

    @property
    @pulumi.getter(name="insightSelectors")
    def insight_selectors(self) -> pulumi.Output[Optional[Sequence['outputs.TrailInsightSelector']]]:
        """
        Specifies an insight selector for identifying unusual operational activity. Fields documented below.
        """
        return pulumi.get(self, "insight_selectors")

    @property
    @pulumi.getter(name="isMultiRegionTrail")
    def is_multi_region_trail(self) -> pulumi.Output[Optional[bool]]:
        """
        Specifies whether the trail is created in the current
        region or in all regions. Defaults to `false`.
        """
        return pulumi.get(self, "is_multi_region_trail")

    @property
    @pulumi.getter(name="isOrganizationTrail")
    def is_organization_trail(self) -> pulumi.Output[Optional[bool]]:
        """
        Specifies whether the trail is an AWS Organizations trail. Organization trails log events for the master account and all member accounts. Can only be created in the organization master account. Defaults to `false`.
        """
        return pulumi.get(self, "is_organization_trail")

    @property
    @pulumi.getter(name="kmsKeyId")
    def kms_key_id(self) -> pulumi.Output[Optional[str]]:
        """
        Specifies the KMS key ARN to use to encrypt the logs delivered by CloudTrail.
        """
        return pulumi.get(self, "kms_key_id")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Specifies the name of the trail.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="s3BucketName")
    def s3_bucket_name(self) -> pulumi.Output[str]:
        """
        Specifies the name of the S3 bucket designated for publishing log files.
        """
        return pulumi.get(self, "s3_bucket_name")

    @property
    @pulumi.getter(name="s3KeyPrefix")
    def s3_key_prefix(self) -> pulumi.Output[Optional[str]]:
        """
        Specifies the S3 key prefix that follows
        the name of the bucket you have designated for log file delivery.
        """
        return pulumi.get(self, "s3_key_prefix")

    @property
    @pulumi.getter(name="snsTopicName")
    def sns_topic_name(self) -> pulumi.Output[Optional[str]]:
        """
        Specifies the name of the Amazon SNS topic
        defined for notification of log file delivery.
        """
        return pulumi.get(self, "sns_topic_name")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        A map of tags to assign to the trail
        """
        return pulumi.get(self, "tags")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

