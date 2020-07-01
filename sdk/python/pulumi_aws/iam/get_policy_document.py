# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class GetPolicyDocumentResult:
    """
    A collection of values returned by getPolicyDocument.
    """
    def __init__(__self__, id=None, json=None, override_json=None, policy_id=None, source_json=None, statements=None, version=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        The provider-assigned unique ID for this managed resource.
        """
        if json and not isinstance(json, str):
            raise TypeError("Expected argument 'json' to be a str")
        __self__.json = json
        """
        The above arguments serialized as a standard JSON policy document.
        """
        if override_json and not isinstance(override_json, str):
            raise TypeError("Expected argument 'override_json' to be a str")
        __self__.override_json = override_json
        if policy_id and not isinstance(policy_id, str):
            raise TypeError("Expected argument 'policy_id' to be a str")
        __self__.policy_id = policy_id
        if source_json and not isinstance(source_json, str):
            raise TypeError("Expected argument 'source_json' to be a str")
        __self__.source_json = source_json
        if statements and not isinstance(statements, list):
            raise TypeError("Expected argument 'statements' to be a list")
        __self__.statements = statements
        if version and not isinstance(version, str):
            raise TypeError("Expected argument 'version' to be a str")
        __self__.version = version
class AwaitableGetPolicyDocumentResult(GetPolicyDocumentResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetPolicyDocumentResult(
            id=self.id,
            json=self.json,
            override_json=self.override_json,
            policy_id=self.policy_id,
            source_json=self.source_json,
            statements=self.statements,
            version=self.version)

def get_policy_document(override_json=None,policy_id=None,source_json=None,statements=None,version=None,opts=None):
    """
    Generates an IAM policy document in JSON format.

    This is a data source which can be used to construct a JSON representation of
    an IAM policy document, for use with resources which expect policy documents,
    such as the `iam.Policy` resource.

    ```python
    import pulumi
    import pulumi_aws as aws

    example_policy_document = aws.iam.get_policy_document(statements=[
        {
            "actions": [
                "s3:ListAllMyBuckets",
                "s3:GetBucketLocation",
            ],
            "resources": ["arn:aws:s3:::*"],
            "sid": "1",
        },
        {
            "actions": ["s3:ListBucket"],
            "conditions": [{
                "test": "StringLike",
                "values": [
                    "",
                    "home/",
                    "home/&{aws:username}/",
                ],
                "variable": "s3:prefix",
            }],
            "resources": [f"arn:aws:s3:::{var['s3_bucket_name']}"],
        },
        {
            "actions": ["s3:*"],
            "resources": [
                f"arn:aws:s3:::{var['s3_bucket_name']}/home/&{{aws:username}}",
                f"arn:aws:s3:::{var['s3_bucket_name']}/home/&{{aws:username}}/*",
            ],
        },
    ])
    example_policy = aws.iam.Policy("examplePolicy",
        path="/",
        policy=example_policy_document.json)
    ```

    Using this data source to generate policy documents is *optional*. It is also
    valid to use literal JSON strings within your configuration, or to use the
    `file` interpolation function to read a raw JSON policy document from a file.

    ## Context Variable Interpolation

    The IAM policy document format allows context variables to be interpolated
    into various strings within a statement. The native IAM policy document format
    uses `${...}`-style syntax that is in conflict with interpolation
    syntax, so this data source instead uses `&{...}` syntax for interpolations that
    should be processed by AWS rather than by this provider.

    ## Wildcard Principal

    In order to define wildcard principal (a.k.a. anonymous user) use `type = "*"` and
    `identifiers = ["*"]`. In that case the rendered json will contain `"Principal": "*"`.
    Note, that even though the [IAM Documentation](https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_principal.html)
    states that `"Principal": "*"` and `"Principal": {"AWS": "*"}` are equivalent,
    those principals have different behavior for IAM Role Trust Policy. Therefore
    this provider will normalize the principal field only in above-mentioned case and principals
    like `type = "AWS"` and `identifiers = ["*"]` will be rendered as `"Principal": {"AWS": "*"}`.

    ## Example with Multiple Principals

    Showing how you can use this as an assume role policy as well as showing how you can specify multiple principal blocks with different types.

    ```python
    import pulumi
    import pulumi_aws as aws

    event_stream_bucket_role_assume_role_policy = aws.iam.get_policy_document(statements=[{
        "actions": ["sts:AssumeRole"],
        "principals": [
            {
                "identifiers": ["firehose.amazonaws.com"],
                "type": "Service",
            },
            {
                "identifiers": [var["trusted_role_arn"]],
                "type": "AWS",
            },
            {
                "identifiers": [
                    f"arn:aws:iam::{var['account_id']}:saml-provider/{var['provider_name']}",
                    "cognito-identity.amazonaws.com",
                ],
                "type": "Federated",
            },
        ],
    }])
    ```

    ## Example with Source and Override

    Showing how you can use `source_json` and `override_json`

    ```python
    import pulumi
    import pulumi_aws as aws

    source = aws.iam.get_policy_document(statements=[
        {
            "actions": ["ec2:*"],
            "resources": ["*"],
        },
        {
            "actions": ["s3:*"],
            "resources": ["*"],
            "sid": "SidToOverwrite",
        },
    ])
    source_json_example = aws.iam.get_policy_document(source_json=source.json,
        statements=[{
            "actions": ["s3:*"],
            "resources": [
                "arn:aws:s3:::somebucket",
                "arn:aws:s3:::somebucket/*",
            ],
            "sid": "SidToOverwrite",
        }])
    override = aws.iam.get_policy_document(statements=[{
        "actions": ["s3:*"],
        "resources": ["*"],
        "sid": "SidToOverwrite",
    }])
    override_json_example = aws.iam.get_policy_document(override_json=override.json,
        statements=[
            {
                "actions": ["ec2:*"],
                "resources": ["*"],
            },
            {
                "actions": ["s3:*"],
                "resources": [
                    "arn:aws:s3:::somebucket",
                    "arn:aws:s3:::somebucket/*",
                ],
                "sid": "SidToOverwrite",
            },
        ])
    ```

    `data.aws_iam_policy_document.source_json_example.json` will evaluate to:

    ```python
    import pulumi
    ```

    `data.aws_iam_policy_document.override_json_example.json` will evaluate to:

    ```python
    import pulumi
    ```

    You can also combine `source_json` and `override_json` in the same document.

    ## Example without Statement

    Use without a `statement`:

    ```python
    import pulumi
    import pulumi_aws as aws

    source = aws.iam.get_policy_document(statements=[{
        "actions": ["ec2:DescribeAccountAttributes"],
        "resources": ["*"],
        "sid": "OverridePlaceholder",
    }])
    override = aws.iam.get_policy_document(statements=[{
        "actions": ["s3:GetObject"],
        "resources": ["*"],
        "sid": "OverridePlaceholder",
    }])
    politik = aws.iam.get_policy_document(override_json=override.json,
        source_json=source.json)
    ```

    `data.aws_iam_policy_document.politik.json` will evaluate to:

    ```python
    import pulumi
    ```


    :param str override_json: An IAM policy document to import and override the
           current policy document.  Statements with non-blank `sid`s in the override
           document will overwrite statements with the same `sid` in the current document.
           Statements without an `sid` cannot be overwritten.
    :param str policy_id: An ID for the policy document.
    :param str source_json: An IAM policy document to import as a base for the
           current policy document.  Statements with non-blank `sid`s in the current
           policy document will overwrite statements with the same `sid` in the source
           json.  Statements without an `sid` cannot be overwritten.
    :param list statements: A nested configuration block (described below)
           configuring one *statement* to be included in the policy document.
    :param str version: IAM policy document version. Valid values: `2008-10-17`, `2012-10-17`. Defaults to `2012-10-17`. For more information, see the [AWS IAM User Guide](https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_version.html).

    The **statements** object supports the following:

      * `actions` (`list`) - A list of actions that this statement either allows
        or denies. For example, ``["ec2:RunInstances", "s3:*"]``.
      * `conditions` (`list`) - A nested configuration block (described below)
        that defines a further, possibly-service-specific condition that constrains
        whether this statement applies.
        * `test` (`str`) - The name of the
          [IAM condition operator](https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_condition_operators.html)
          to evaluate.
        * `values` (`list`) - The values to evaluate the condition against. If multiple
          values are provided, the condition matches if at least one of them applies.
          (That is, the tests are combined with the "OR" boolean operation.)
        * `variable` (`str`) - The name of a
          [Context Variable](http://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements.html#AvailableKeys)
          to apply the condition to. Context variables may either be standard AWS
          variables starting with `aws:`, or service-specific variables prefixed with
          the service name.

      * `effect` (`str`) - Either "Allow" or "Deny", to specify whether this
        statement allows or denies the given actions. The default is "Allow".
      * `notActions` (`list`) - A list of actions that this statement does *not*
        apply to. Used to apply a policy statement to all actions *except* those
        listed.
      * `notPrincipals` (`list`) - Like `principals` except gives resources that
        the statement does *not* apply to.
        * `identifiers` (`list`) - List of identifiers for principals. When `type`
          is "AWS", these are IAM user or role ARNs.  When `type` is "Service", these are AWS Service roles e.g. `lambda.amazonaws.com`. When `type` is "Federated", these are web identity users or SAML provider ARNs.
        * `type` (`str`) - The type of principal. For AWS ARNs this is "AWS".  For AWS services (e.g. Lambda), this is "Service". For Federated access the type is "Federated".

      * `notResources` (`list`) - A list of resource ARNs that this statement
        does *not* apply to. Used to apply a policy statement to all resources
        *except* those listed.
      * `principals` (`list`) - A nested configuration block (described below)
        specifying a resource (or resource pattern) to which this statement applies.
        * `identifiers` (`list`) - List of identifiers for principals. When `type`
          is "AWS", these are IAM user or role ARNs.  When `type` is "Service", these are AWS Service roles e.g. `lambda.amazonaws.com`. When `type` is "Federated", these are web identity users or SAML provider ARNs.
        * `type` (`str`) - The type of principal. For AWS ARNs this is "AWS".  For AWS services (e.g. Lambda), this is "Service". For Federated access the type is "Federated".

      * `resources` (`list`) - A list of resource ARNs that this statement applies
        to. This is required by AWS if used for an IAM policy.
      * `sid` (`str`) - An ID for the policy statement.
    """
    __args__ = dict()


    __args__['overrideJson'] = override_json
    __args__['policyId'] = policy_id
    __args__['sourceJson'] = source_json
    __args__['statements'] = statements
    __args__['version'] = version
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('aws:iam/getPolicyDocument:getPolicyDocument', __args__, opts=opts).value

    return AwaitableGetPolicyDocumentResult(
        id=__ret__.get('id'),
        json=__ret__.get('json'),
        override_json=__ret__.get('overrideJson'),
        policy_id=__ret__.get('policyId'),
        source_json=__ret__.get('sourceJson'),
        statements=__ret__.get('statements'),
        version=__ret__.get('version'))
