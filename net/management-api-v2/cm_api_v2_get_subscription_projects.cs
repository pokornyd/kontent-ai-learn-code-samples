// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_SUBSCRIPTION_API_KEY",
    SubscriptionId = "KONTENT_AI_SUBSCRIPTION_ID",
    // Required by the SDK for client creation
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var response = await client.ListSubscriptionProjectsAsync();
