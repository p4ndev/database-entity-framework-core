Alter Table Variant 
	Alter Column VariationType Int Not Null;

Alter Table Variant
	Add Constraint CHK_Variant_Type
		Check (VariationType between 1 and 2);

Alter Table Variant
	Add Constraint PK_Variant Primary Key (Id);

Alter Table Variant
	Alter Column [Value] Nvarchar(255) Not Null;

Alter Table Variant
	Add Constraint UQ_Variant Unique ([Value]);