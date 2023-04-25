Create Procedure PSetupSize
	@ProductId Int
As
	Insert Into Variant(VariationType, ProductId, [Value])
		Values('Size', @ProductId, 'P');

Drop Proc PSetupSize;