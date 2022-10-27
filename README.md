# Onion_Subscriptions Same Description As DDD_Subscription however without CQRS Eventing.

The front-end is Pick a product to subscribe for a subscription

![SampleDomain](https://user-images.githubusercontent.com/103900072/198378841-15616f64-cfcf-4624-8a32-debc906841c0.png)


The Domain Models for the Database

![DomainModel](https://user-images.githubusercontent.com/103900072/198378953-976f41e4-a564-483b-a4d7-14f3a6cd42bc.png)


Busniss Case: We want to allow a customer to subscribe for a product, however, the product price changes depending on the money spent by the customer
if a customer spent already 500$ then he gets a discount on the subscription, and if more than 1000$ he gets a 50% discount.

The Customer can also Deactivate his subscription.

We should also query the subscription that is currently active by the user if he have one.
