Select * From Variant
	Where VariationType = dbo.FVariationStringHelper('Color');
	
Select * From Variant
	Where VariationType = dbo.FVariationStringHelper('Size');
	
Select * From Variant order By VariationType Asc;