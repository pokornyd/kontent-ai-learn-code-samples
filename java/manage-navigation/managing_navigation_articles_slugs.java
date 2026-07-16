// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kontent.ai.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("KONTENT_AI_ENVIRONMENT_ID");

// Registers the model class for navigation items
// Tip: Create strongly typed models according to https://kontent.ai/learn/strongly-typed-models
client.registerType(NavigationItem.class);

// Gets navigation items and their linked items
CompletionStage<NavigationItem> root = client.getItem(
    "root_navigation_item",
     NavigationItem.class,
     DeliveryParameterBuilder.params()
        .linkedItemsDepth(5)
        .build()

