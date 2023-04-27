Create Procedure PSetupSize
	@ProductId Int
As
	Insert Into ProductVariant(ProductId, VariantId, [Initial])
		Values(@ProductId, dbo.FSetupVariationSizeId(), 1);