-- Product and brand ordered by brand name alphabetically

Select
	Brand.Name, Product.Name, Product.Description
From
	Product
		Join Brand
			On Product.BrandId = Brand.Id
Order By
	Product.Name
Asc;

-- Product and variation ordered by variation value alphabetically reversed

Select
	Variant.VariationType, Variant.[Value],
	Product.Name, Product.Description
From
	Product
		Join Variant
			On Product.Id = Variant.ProductId
Order By
	Variant.[Value]
Desc;

-- Product and Brand with no Variation ordered by product name alphabetically

Select
	Product.Id as 'PID',
	Brand.Name as 'Brand',
	Product.Name as 'Product'
From
	Product
		Join Brand
			On Product.BrandId = Brand.Id
		Left Join Variant
			On Product.Id = Variant.ProductId
Where
	Variant.VariationType Is Null
Order By
	Product.Name
Asc;