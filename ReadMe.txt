Postman:
	a) Access Token:
			GET/POST	>	url/token
			Body		>	x-wwww-form-urlencoded
			
			Key	-	Value
			---------------------
			username	Siyam
			password	12345
			grant_type	password
	b) CRUD:
		1. GET
			GET	>	url/api/order
			Copy the Token
			Authorization	>	Type - Bearer Token	>	Token - (Paste the Token)
		2. POST
			POST	>	url/api/order
			Body	>	form-data
			
			Key		-		Value		-	Content type
			------------------------------------------------------------------------
			Order			(Insert Data)			application/json
			ImageFile(Select File)	(Upload Image)			Auto
			ImageFileName		(Give a random name)		application/json
			
			[For inserting data, sample data format is given in the Note]
		3. PUT
			PUT	>	url/api/order/id	(id = 1,2,3...etc.)
			Body	>	form-data
			
			Key		-		Value		-	Content type
			------------------------------------------------------------------------
			Order			(Update Data)			application/json
			ImageFile(Select File)	(Change Image)			Auto
			ImageFileName		(Give a random name)		application/json

			[For updating data, sample data format is given in the Note]
		4. DELETE
			DELETE	>	url/api/order/id  (id = 1,2,3...etc.)

Note: 
	For POST Method, Insert Data According to this format:
	------------------------------------------------------
    	{
        "OrderedItems": [
            {
                "ProductId": 1,
                "Quantity": 2,
                "Price": 25000.00
            },
            {
                "ProductId": 2,
                "Quantity": 2,
                "Price": 30000.00
            }
        ],
        "OrderNo": "102",
        "CustomerName": "Farha",
        "OrderDate": "2020-01-01T00:00:00",
        "IsPaid": true,
        "ImageUrl": "abc"
    	}


	For PUT Method, Insert Data According to this format:
	-----------------------------------------------------
 	{
        "OrderedItems": [
            {
                "ProductId": 1,
                "Quantity": 20,
                "Price": 150000.00
            },
            {

                "ProductId": 2,
                "Quantity": 10,
                "Price": 250000.00
            }
        ],
        "OrderId": 2,
        "OrderNo": "104",
        "CustomerName": "Afrin Jahan",
        "OrderDate": "2024-12-24T00:00:00",
        "IsPaid": true,
        "ImageUrl": "xyz"
    	}
			
			