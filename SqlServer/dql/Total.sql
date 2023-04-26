Select Count(*) as 'Products' From Product;

Select Count(*) as 'Brands' From Brand;

Select Count(*) as 'Colors' From Variant Where VariationType = 'Color';

Select Count(*) as 'Sizes' From Variant Where VariationType = 'Size';