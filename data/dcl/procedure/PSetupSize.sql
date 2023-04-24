Create Procedure PSetupSize
	@ProductId Int
As
	Insert Into Variant(VariationTypeId, ProductId, [Value])
		Values(2, @ProductId, 'P');