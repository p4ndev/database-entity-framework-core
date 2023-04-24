Create Procedure PSetupColor
	@ProductId Int
As
	Insert Into Variant(VariationTypeId, ProductId, [Value])
		Values(1, @ProductId, '#000000');