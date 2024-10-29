# CustomerInvoiceExercise
     * Create a Customer class
        * Properties:
            * id (to define a customer)
            * name (public name to identify customer)
            * discount (any discount they have available on any purchase)
                * add extra code to lock value 0 - 100
        * Constructor to initialise properties
        * Override to string to output properties
     * Create a Item class
        * Properties:
            * id (to define an item)
            * name (public name to identify item)
        * Constructor to initialise properties
        * Override to string to output properties
     * Create a Invoice class
        * Properties:
            * id (to define an invoice)
            * customer (identify customer in the purchase)
            * item (identify the item the customer purchased)
            * amount (the quantity they bought of that item)
                * lock value to >= 1
        * Constructor to initialise properties
            * Extra: which parameter could be optional?
        * Override to string to output properties
     * In the main:
        * Create a customer
        * Create a item
        * Create a invoice, give it the customer & item declared above
        * Print them all to the screen and make sure it works
        * Play around with the quantity and the name of the items
