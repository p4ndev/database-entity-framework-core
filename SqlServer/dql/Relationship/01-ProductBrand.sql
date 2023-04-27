Select * From Brand;
Select * From Product;

-- ###############################################################

Select
	Brand.Id as 'BrandId', 		Brand.Name as 'Brand',
	Product.Id as 'ProductId', 	Product.Name as 'Product'
From
	Product
		Join Brand
			On Product.BrandId = Brand.Id
Order By
	Product.Name
Asc;