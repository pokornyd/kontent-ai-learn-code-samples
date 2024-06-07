// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { createDeliveryClient } from '@kontent-ai/delivery-sdk';
import { Article } from './models/Article';

const deliveryClient = createDeliveryClient({
  environmentId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
});

// Filters all articles to find the Spanish variant by its URL slug
const response = await deliveryClient.items<Article>()
  .type('article')
  .languageParameter('es-ES')
  .depthParameter(0)
  .equalsFilter('elements.url_pattern', 'acerda-de-nosotros')
  .toPromise();
