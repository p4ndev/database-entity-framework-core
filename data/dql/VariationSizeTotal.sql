-- Product and its variation total ordered by max total

Select
	Count(*) as 'Total',
	[Value] as 'Sizes',
	VariationType as 'Name'
From
	Variant
Group By
	[Value], VariationType
Having
	VariationType = 'Size';
