Alter Table Variant 
	Alter Column VariationType Nvarchar(100) Not Null;

Alter Table Variant
	Add Constraint CHK_Variant_Type
		Check (VariationType between 'Color' and 'Size');

Alter Table Variant
	Add Constraint PK_Variant Primary Key (Id);

Alter Table Variant
	Alter Column [Value] Nvarchar(255) Not Null;

Alter Table Variant
	Alter Column ProductId Int Not Null;

Alter Table Variant
	Add Constraint FK_Variant_Product
		Foreign Key (ProductId)
			References Product(Id);
