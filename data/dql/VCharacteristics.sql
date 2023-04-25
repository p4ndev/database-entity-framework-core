-- Product and its variation total (color and size)

Create View VCharacteristics
As
	Select 
		Count(*) as 'Total',
		VariationType as 'Name'
	From
		Variant
	Group By
		VariationType;

Select * From VCharacteristics;