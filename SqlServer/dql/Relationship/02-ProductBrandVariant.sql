Select * From ProductVariant;
	Select * From Brand;
	Select * From Variant;
	Select * From Product;

-- ###############################################################

Select
	Brand.Name 		as 'Brand',
	Product.Name 	as 'Product',
	dbo.FVariationIntHelper(Variant.VariationType) as 'Variant',
	Variant.[Value] as 'Value'
From
	Product
		Join Brand
			On Product.BrandId = Brand.Id
		Join ProductVariant
			On Product.Id = ProductVariant.ProductId
		Join Variant
			On ProductVariant.VariantId = Variant.Id
Order By
	Variant.VariationType
Asc;