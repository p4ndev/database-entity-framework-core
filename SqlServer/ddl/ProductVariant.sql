Alter Table ProductVariant
	Add Constraint PK_Product Primary Key (Id);
	
Alter Table ProductVariant
	Add Constraint DF_Initialization 
		Default 0 For [Initial];

Alter Table ProductVariant
	Add Constraint FK_Product_Variant
		Foreign Key (ProductId)
			References Product (Id);
			
Alter Table ProductVariant
	Add Constraint FK_Variant_Product
		Foreign Key (VariantId)
			References Variant (Id);