Alter Table Product
	Alter Column BrandId Int Not Null;

Alter Table Product
	Add Constraint PK_Product Primary Key (Id);

Alter Table Product
	Alter Column Name Nvarchar(255) Not Null;

Alter Table Product
	Add Constraint FK_Product_Brand
		Foreign Key (BrandId)
			References Brand (Id);