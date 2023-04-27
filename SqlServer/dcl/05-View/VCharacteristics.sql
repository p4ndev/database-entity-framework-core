Create View VCharacteristics
As
	Select 
		Count(*) as 'Total',
		dbo.FVariationIntHelper(VariationType) as 'Name'
	From
		Variant
	Group By
		VariationType;