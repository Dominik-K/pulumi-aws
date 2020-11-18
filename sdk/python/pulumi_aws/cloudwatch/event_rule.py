# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from .. import _utilities, _tables

__all__ = ['EventRule']


class EventRule(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 event_bus_name: Optional[pulumi.Input[str]] = None,
                 event_pattern: Optional[pulumi.Input[str]] = None,
                 is_enabled: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 name_prefix: Optional[pulumi.Input[str]] = None,
                 role_arn: Optional[pulumi.Input[str]] = None,
                 schedule_expression: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Provides an EventBridge Rule resource.

        > **Note:** EventBridge was formerly known as CloudWatch Events. The functionality is identical.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_aws as aws

        console = aws.cloudwatch.EventRule("console",
            description="Capture each AWS Console Sign In",
            event_pattern=\"\"\"{
          "detail-type": [
            "AWS Console Sign In via CloudTrail"
          ]
        }
        \"\"\")
        aws_logins = aws.sns.Topic("awsLogins")
        sns = aws.cloudwatch.EventTarget("sns",
            rule=console.name,
            arn=aws_logins.arn)
        sns_topic_policy = aws_logins.arn.apply(lambda arn: aws.iam.get_policy_document(statements=[aws.iam.GetPolicyDocumentStatementArgs(
            effect="Allow",
            actions=["SNS:Publish"],
            principals=[aws.iam.GetPolicyDocumentStatementPrincipalArgs(
                type="Service",
                identifiers=["events.amazonaws.com"],
            )],
            resources=[arn],
        )]))
        default = aws.sns.TopicPolicy("default",
            arn=aws_logins.arn,
            policy=sns_topic_policy.json)
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: The description of the rule.
        :param pulumi.Input[str] event_bus_name: The event bus to associate with this rule. If you omit this, the `default` event bus is used.
        :param pulumi.Input[str] event_pattern: The event pattern described a JSON object. At least one of `schedule_expression` or `event_pattern` is required.
               See full documentation of [Events and Event Patterns in EventBridge](https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-and-event-patterns.html) for details.
        :param pulumi.Input[bool] is_enabled: Whether the rule should be enabled (defaults to `true`).
        :param pulumi.Input[str] name: The name of the rule. If omitted, this provider will assign a random, unique name. Conflicts with `name_prefix`.
        :param pulumi.Input[str] name_prefix: Creates a unique name beginning with the specified prefix. Conflicts with `name`.
        :param pulumi.Input[str] role_arn: The Amazon Resource Name (ARN) associated with the role that is used for target invocation.
        :param pulumi.Input[str] schedule_expression: The scheduling expression.
               For example, `cron(0 20 * * ? *)` or `rate(5 minutes)`. At least one of `schedule_expression` or `event_pattern` is required. Can only be used on the default event bus.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: A map of tags to assign to the resource.
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

            __props__['description'] = description
            __props__['event_bus_name'] = event_bus_name
            __props__['event_pattern'] = event_pattern
            __props__['is_enabled'] = is_enabled
            __props__['name'] = name
            __props__['name_prefix'] = name_prefix
            __props__['role_arn'] = role_arn
            __props__['schedule_expression'] = schedule_expression
            __props__['tags'] = tags
            __props__['arn'] = None
        super(EventRule, __self__).__init__(
            'aws:cloudwatch/eventRule:EventRule',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            arn: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            event_bus_name: Optional[pulumi.Input[str]] = None,
            event_pattern: Optional[pulumi.Input[str]] = None,
            is_enabled: Optional[pulumi.Input[bool]] = None,
            name: Optional[pulumi.Input[str]] = None,
            name_prefix: Optional[pulumi.Input[str]] = None,
            role_arn: Optional[pulumi.Input[str]] = None,
            schedule_expression: Optional[pulumi.Input[str]] = None,
            tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None) -> 'EventRule':
        """
        Get an existing EventRule resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] arn: The Amazon Resource Name (ARN) of the rule.
        :param pulumi.Input[str] description: The description of the rule.
        :param pulumi.Input[str] event_bus_name: The event bus to associate with this rule. If you omit this, the `default` event bus is used.
        :param pulumi.Input[str] event_pattern: The event pattern described a JSON object. At least one of `schedule_expression` or `event_pattern` is required.
               See full documentation of [Events and Event Patterns in EventBridge](https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-and-event-patterns.html) for details.
        :param pulumi.Input[bool] is_enabled: Whether the rule should be enabled (defaults to `true`).
        :param pulumi.Input[str] name: The name of the rule. If omitted, this provider will assign a random, unique name. Conflicts with `name_prefix`.
        :param pulumi.Input[str] name_prefix: Creates a unique name beginning with the specified prefix. Conflicts with `name`.
        :param pulumi.Input[str] role_arn: The Amazon Resource Name (ARN) associated with the role that is used for target invocation.
        :param pulumi.Input[str] schedule_expression: The scheduling expression.
               For example, `cron(0 20 * * ? *)` or `rate(5 minutes)`. At least one of `schedule_expression` or `event_pattern` is required. Can only be used on the default event bus.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: A map of tags to assign to the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["arn"] = arn
        __props__["description"] = description
        __props__["event_bus_name"] = event_bus_name
        __props__["event_pattern"] = event_pattern
        __props__["is_enabled"] = is_enabled
        __props__["name"] = name
        __props__["name_prefix"] = name_prefix
        __props__["role_arn"] = role_arn
        __props__["schedule_expression"] = schedule_expression
        __props__["tags"] = tags
        return EventRule(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def arn(self) -> pulumi.Output[str]:
        """
        The Amazon Resource Name (ARN) of the rule.
        """
        return pulumi.get(self, "arn")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        The description of the rule.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="eventBusName")
    def event_bus_name(self) -> pulumi.Output[Optional[str]]:
        """
        The event bus to associate with this rule. If you omit this, the `default` event bus is used.
        """
        return pulumi.get(self, "event_bus_name")

    @property
    @pulumi.getter(name="eventPattern")
    def event_pattern(self) -> pulumi.Output[Optional[str]]:
        """
        The event pattern described a JSON object. At least one of `schedule_expression` or `event_pattern` is required.
        See full documentation of [Events and Event Patterns in EventBridge](https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-and-event-patterns.html) for details.
        """
        return pulumi.get(self, "event_pattern")

    @property
    @pulumi.getter(name="isEnabled")
    def is_enabled(self) -> pulumi.Output[Optional[bool]]:
        """
        Whether the rule should be enabled (defaults to `true`).
        """
        return pulumi.get(self, "is_enabled")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the rule. If omitted, this provider will assign a random, unique name. Conflicts with `name_prefix`.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="namePrefix")
    def name_prefix(self) -> pulumi.Output[Optional[str]]:
        """
        Creates a unique name beginning with the specified prefix. Conflicts with `name`.
        """
        return pulumi.get(self, "name_prefix")

    @property
    @pulumi.getter(name="roleArn")
    def role_arn(self) -> pulumi.Output[Optional[str]]:
        """
        The Amazon Resource Name (ARN) associated with the role that is used for target invocation.
        """
        return pulumi.get(self, "role_arn")

    @property
    @pulumi.getter(name="scheduleExpression")
    def schedule_expression(self) -> pulumi.Output[Optional[str]]:
        """
        The scheduling expression.
        For example, `cron(0 20 * * ? *)` or `rate(5 minutes)`. At least one of `schedule_expression` or `event_pattern` is required. Can only be used on the default event bus.
        """
        return pulumi.get(self, "schedule_expression")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        A map of tags to assign to the resource.
        """
        return pulumi.get(self, "tags")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

