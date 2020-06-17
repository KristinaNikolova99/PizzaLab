# PizzaLab
 Console Application for pizza order using Factory, State and Facade design patterns.
 
 Factory pattern is implemented when selecting pizza or adding topping.
 
 Facade pattern is used when Factory add code(checks if product is available), 
 discard code(checks if topping is selected or not), if everything is okay proceeds to placeorder:
 Step 1: gets user balance
 Step 2: gets order total price
 Step 3: compares balance with total price
 Step 4: places the order
 Step 5: calculates total calories
 
 State pattern is used for adding and discarding state of order.
 Based on user input adds or discards pizza or topping.
