Select * From ProductVariant;
	Select * From Variant;
	Select * From Product;

-- ###############################################################

Select
	Product.Name as 'Product',
	dbo.FVariationIntHelper(Variant.VariationType) as 'Variant',
	Variant.[Value] as 'Value'
From
	Product
		Join ProductVariant
			On Product.Id = ProductVariant.ProductId
		Join Variant
			On ProductVariant.VariantId = Variant.Id
Order By
	Variant.VariationType
Asc;