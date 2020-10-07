// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Aws
{
    public static class Config
    {
        private static readonly Pulumi.Config __config = new Pulumi.Config("aws");
        /// <summary>
        /// The access key for API operations. You can retrieve this from the 'Security &amp; Credentials' section of the AWS console.
        /// </summary>
        public static string? AccessKey { get; set; } = __config.Get("accessKey");

        public static ImmutableArray<string> AllowedAccountIds { get; set; } = __config.GetObject<ImmutableArray<string>>("allowedAccountIds");

        public static Pulumi.Aws.Config.Types.AssumeRole? AssumeRole { get; set; } = __config.GetObject<Pulumi.Aws.Config.Types.AssumeRole>("assumeRole");

        public static ImmutableArray<Pulumi.Aws.Config.Types.Endpoints> Endpoints { get; set; } = __config.GetObject<ImmutableArray<Pulumi.Aws.Config.Types.Endpoints>>("endpoints");

        public static ImmutableArray<string> ForbiddenAccountIds { get; set; } = __config.GetObject<ImmutableArray<string>>("forbiddenAccountIds");

        /// <summary>
        /// Configuration block with settings to ignore resource tags across all resources.
        /// </summary>
        public static Pulumi.Aws.Config.Types.IgnoreTags? IgnoreTags { get; set; } = __config.GetObject<Pulumi.Aws.Config.Types.IgnoreTags>("ignoreTags");

        /// <summary>
        /// Explicitly allow the provider to perform "insecure" SSL requests. If omitted,default value is `false`
        /// </summary>
        public static bool? Insecure { get; set; } = __config.GetBoolean("insecure");

        /// <summary>
        /// The maximum number of times an AWS API request is being executed. If the API request still fails, an error is thrown.
        /// </summary>
        public static int? MaxRetries { get; set; } = __config.GetInt32("maxRetries");

        /// <summary>
        /// The profile for API operations. If not set, the default profile created with `aws configure` will be used.
        /// </summary>
        public static string? Profile { get; set; } = __config.Get("profile") ?? Utilities.GetEnv("AWS_PROFILE");

        /// <summary>
        /// The region where AWS operations will take place. Examples are us-east-1, us-west-2, etc.
        /// </summary>
        public static string? Region { get; set; } = __config.Get("region") ?? Utilities.GetEnv("AWS_REGION", "AWS_DEFAULT_REGION");

        /// <summary>
        /// Set this to true to force the request to use path-style addressing, i.e., http://s3.amazonaws.com/BUCKET/KEY. By
        /// default, the S3 client will use virtual hosted bucket addressing when possible (http://BUCKET.s3.amazonaws.com/KEY).
        /// Specific to the Amazon S3 service.
        /// </summary>
        public static bool? S3ForcePathStyle { get; set; } = __config.GetBoolean("s3ForcePathStyle");

        /// <summary>
        /// The secret key for API operations. You can retrieve this from the 'Security &amp; Credentials' section of the AWS console.
        /// </summary>
        public static string? SecretKey { get; set; } = __config.Get("secretKey");

        /// <summary>
        /// The path to the shared credentials file. If not set this defaults to ~/.aws/credentials.
        /// </summary>
        public static string? SharedCredentialsFile { get; set; } = __config.Get("sharedCredentialsFile");

        /// <summary>
        /// Skip the credentials validation via STS API. Used for AWS API implementations that do not have STS
        /// available/implemented.
        /// </summary>
        public static bool? SkipCredentialsValidation { get; set; } = __config.GetBoolean("skipCredentialsValidation");

        /// <summary>
        /// Skip getting the supported EC2 platforms. Used by users that don't have ec2:DescribeAccountAttributes permissions.
        /// </summary>
        public static bool? SkipGetEc2Platforms { get; set; } = __config.GetBoolean("skipGetEc2Platforms");

        public static bool? SkipMetadataApiCheck { get; set; } = __config.GetBoolean("skipMetadataApiCheck");

        /// <summary>
        /// Skip static validation of region name. Used by users of alternative AWS-like APIs or users w/ access to regions that are
        /// not public (yet).
        /// </summary>
        public static bool? SkipRegionValidation { get; set; } = __config.GetBoolean("skipRegionValidation");

        /// <summary>
        /// Skip requesting the account ID. Used for AWS API implementations that do not have IAM/STS API and/or metadata API.
        /// </summary>
        public static bool? SkipRequestingAccountId { get; set; } = __config.GetBoolean("skipRequestingAccountId");

        /// <summary>
        /// session token. A session token is only required if you are using temporary security credentials.
        /// </summary>
        public static string? Token { get; set; } = __config.Get("token");

        public static class Types
        {

             public class AssumeRole
             {
                public int? DurationSeconds { get; set; }
                public string? ExternalId { get; set; } = null!;
                public string? Policy { get; set; } = null!;
                public ImmutableArray<string> PolicyArns { get; set; }
                public string? RoleArn { get; set; } = null!;
                public string? SessionName { get; set; } = null!;
                public ImmutableDictionary<string, string>? Tags { get; set; } = null!;
                public ImmutableArray<string> TransitiveTagKeys { get; set; }
            }

             public class Endpoints
             {
                public string? Accessanalyzer { get; set; } = null!;
                public string? Acm { get; set; } = null!;
                public string? Acmpca { get; set; } = null!;
                public string? Amplify { get; set; } = null!;
                public string? Apigateway { get; set; } = null!;
                public string? Applicationautoscaling { get; set; } = null!;
                public string? Applicationinsights { get; set; } = null!;
                public string? Appmesh { get; set; } = null!;
                public string? Appstream { get; set; } = null!;
                public string? Appsync { get; set; } = null!;
                public string? Athena { get; set; } = null!;
                public string? Autoscaling { get; set; } = null!;
                public string? Autoscalingplans { get; set; } = null!;
                public string? Backup { get; set; } = null!;
                public string? Batch { get; set; } = null!;
                public string? Budgets { get; set; } = null!;
                public string? Cloud9 { get; set; } = null!;
                public string? Cloudformation { get; set; } = null!;
                public string? Cloudfront { get; set; } = null!;
                public string? Cloudhsm { get; set; } = null!;
                public string? Cloudsearch { get; set; } = null!;
                public string? Cloudtrail { get; set; } = null!;
                public string? Cloudwatch { get; set; } = null!;
                public string? Cloudwatchevents { get; set; } = null!;
                public string? Cloudwatchlogs { get; set; } = null!;
                public string? Codeartifact { get; set; } = null!;
                public string? Codebuild { get; set; } = null!;
                public string? Codecommit { get; set; } = null!;
                public string? Codedeploy { get; set; } = null!;
                public string? Codepipeline { get; set; } = null!;
                public string? Cognitoidentity { get; set; } = null!;
                public string? Cognitoidp { get; set; } = null!;
                public string? Configservice { get; set; } = null!;
                public string? Cur { get; set; } = null!;
                public string? Dataexchange { get; set; } = null!;
                public string? Datapipeline { get; set; } = null!;
                public string? Datasync { get; set; } = null!;
                public string? Dax { get; set; } = null!;
                public string? Devicefarm { get; set; } = null!;
                public string? Directconnect { get; set; } = null!;
                public string? Dlm { get; set; } = null!;
                public string? Dms { get; set; } = null!;
                public string? Docdb { get; set; } = null!;
                public string? Ds { get; set; } = null!;
                public string? Dynamodb { get; set; } = null!;
                public string? Ec2 { get; set; } = null!;
                public string? Ecr { get; set; } = null!;
                public string? Ecs { get; set; } = null!;
                public string? Efs { get; set; } = null!;
                public string? Eks { get; set; } = null!;
                public string? Elasticache { get; set; } = null!;
                public string? Elasticbeanstalk { get; set; } = null!;
                public string? Elastictranscoder { get; set; } = null!;
                public string? Elb { get; set; } = null!;
                public string? Emr { get; set; } = null!;
                public string? Es { get; set; } = null!;
                public string? Firehose { get; set; } = null!;
                public string? Fms { get; set; } = null!;
                public string? Forecast { get; set; } = null!;
                public string? Fsx { get; set; } = null!;
                public string? Gamelift { get; set; } = null!;
                public string? Glacier { get; set; } = null!;
                public string? Globalaccelerator { get; set; } = null!;
                public string? Glue { get; set; } = null!;
                public string? Greengrass { get; set; } = null!;
                public string? Guardduty { get; set; } = null!;
                public string? Iam { get; set; } = null!;
                public string? Identitystore { get; set; } = null!;
                public string? Imagebuilder { get; set; } = null!;
                public string? Inspector { get; set; } = null!;
                public string? Iot { get; set; } = null!;
                public string? Iotanalytics { get; set; } = null!;
                public string? Iotevents { get; set; } = null!;
                public string? Kafka { get; set; } = null!;
                public string? Kinesis { get; set; } = null!;
                public string? Kinesisanalytics { get; set; } = null!;
                public string? Kinesisanalyticsv2 { get; set; } = null!;
                public string? Kinesisvideo { get; set; } = null!;
                public string? Kms { get; set; } = null!;
                public string? Lakeformation { get; set; } = null!;
                public string? Lambda { get; set; } = null!;
                public string? Lexmodels { get; set; } = null!;
                public string? Licensemanager { get; set; } = null!;
                public string? Lightsail { get; set; } = null!;
                public string? Macie { get; set; } = null!;
                public string? Macie2 { get; set; } = null!;
                public string? Managedblockchain { get; set; } = null!;
                public string? Marketplacecatalog { get; set; } = null!;
                public string? Mediaconnect { get; set; } = null!;
                public string? Mediaconvert { get; set; } = null!;
                public string? Medialive { get; set; } = null!;
                public string? Mediapackage { get; set; } = null!;
                public string? Mediastore { get; set; } = null!;
                public string? Mediastoredata { get; set; } = null!;
                public string? Mq { get; set; } = null!;
                public string? Neptune { get; set; } = null!;
                public string? Networkmanager { get; set; } = null!;
                public string? Opsworks { get; set; } = null!;
                public string? Organizations { get; set; } = null!;
                public string? Outposts { get; set; } = null!;
                public string? Personalize { get; set; } = null!;
                public string? Pinpoint { get; set; } = null!;
                public string? Pricing { get; set; } = null!;
                public string? Qldb { get; set; } = null!;
                public string? Quicksight { get; set; } = null!;
                public string? Ram { get; set; } = null!;
                public string? Rds { get; set; } = null!;
                public string? Redshift { get; set; } = null!;
                public string? Resourcegroups { get; set; } = null!;
                public string? Resourcegroupstaggingapi { get; set; } = null!;
                public string? Route53 { get; set; } = null!;
                public string? Route53domains { get; set; } = null!;
                public string? Route53resolver { get; set; } = null!;
                public string? S3 { get; set; } = null!;
                public string? S3control { get; set; } = null!;
                public string? Sagemaker { get; set; } = null!;
                public string? Sdb { get; set; } = null!;
                public string? Secretsmanager { get; set; } = null!;
                public string? Securityhub { get; set; } = null!;
                public string? Serverlessrepo { get; set; } = null!;
                public string? Servicecatalog { get; set; } = null!;
                public string? Servicediscovery { get; set; } = null!;
                public string? Servicequotas { get; set; } = null!;
                public string? Ses { get; set; } = null!;
                public string? Shield { get; set; } = null!;
                public string? Sns { get; set; } = null!;
                public string? Sqs { get; set; } = null!;
                public string? Ssm { get; set; } = null!;
                public string? Ssoadmin { get; set; } = null!;
                public string? Stepfunctions { get; set; } = null!;
                public string? Storagegateway { get; set; } = null!;
                public string? Sts { get; set; } = null!;
                public string? Swf { get; set; } = null!;
                public string? Synthetics { get; set; } = null!;
                public string? Transfer { get; set; } = null!;
                public string? Waf { get; set; } = null!;
                public string? Wafregional { get; set; } = null!;
                public string? Wafv2 { get; set; } = null!;
                public string? Worklink { get; set; } = null!;
                public string? Workmail { get; set; } = null!;
                public string? Workspaces { get; set; } = null!;
                public string? Xray { get; set; } = null!;
            }

             public class IgnoreTags
             {
                public ImmutableArray<string> KeyPrefixes { get; set; }
                public ImmutableArray<string> Keys { get; set; }
            }
        }
    }
}
