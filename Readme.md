# RiaInstantFeedbackDataSource - How to show included entity field data using a custom View


<p>This example shows how to create a new custom View that will include data from two dependent data tables.</p><br />
<p>Let's assume you need to show the Orders table content in DXGrid using the RiaInstantFeedbackDataSource. The Order entity has the CustomerID field and you may wish to display information about order's customer within the grid. For example, show the customer's name from the Customers table along with the CustomerID.</p><p><img src="https://raw.githubusercontent.com/DevExpress-Examples/riainstantfeedbackdatasource-how-to-show-included-entity-field-data-using-a-custom-view-e3951/11.2.10+/media/3ee1a1d8-7e84-4430-9e42-ce524b11dd0d.png"></p><p>The easiest way to accomplish this task is to create a new View in the database that will include data from both the Orders and Customer tables. This can be done on the server side using the following SQL script:</p>

```sql
CREATE VIEW [dbo].[CustomerOrders]<newline/>AS<newline/>SELECT OrderID, CompanyName, ContactName, OrderDate<newline/>FROM Orders<newline/>inner join Customers on Orders.CustomerID = Customers.CustomerID
```

<p> </p><p>Now, when the new View is ready, you'll need to create an ADO.Net Entity Data Model based on this custom view and create a Domain Service based on this model. The  required steps are similar to those shown in the '<a href="http://documentation.devexpress.com/#Silverlight/CustomDocument5290"><u>How to: Use DXGrid with RIA Services</u></a>' help topic. The only difference is that it is necessary to choose the new custom View in the 'Choose Your Data Base Object' data model wizard's dialog rather than Orders table.</p><p><img src="https://raw.githubusercontent.com/DevExpress-Examples/riainstantfeedbackdatasource-how-to-show-included-entity-field-data-using-a-custom-view-e3951/11.2.10+/media/edc7e0ee-5d4f-4225-8be7-56ad0d6d8da8.png"></p><p>As a result, a model with the following diagram will be created:<br />
<img src="https://raw.githubusercontent.com/DevExpress-Examples/riainstantfeedbackdatasource-how-to-show-included-entity-field-data-using-a-custom-view-e3951/11.2.10+/media/b6f7d8bd-0160-4a46-9808-b63c3cfdfa61.png"></p><p>An alternative approach is to use the extended data query and join data from two tables within the Domain Service GetCustomerOrders method. Please refer to the <a href="https://www.devexpress.com/Support/Center/p/E3952">RiaInstantFeedbackDataSource - How to show included entity field data in DXGrid using the extended data query</a> example to see this approach in action.</p><br />


<br/>


