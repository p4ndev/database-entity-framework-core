Create Procedure PSetupColor
	@ProductId Int
As
	Insert Into ProductVariant(ProductId, VariantId, [Initial])
		Values(@ProductId, dbo.FSetupVariationColorId(), 1);