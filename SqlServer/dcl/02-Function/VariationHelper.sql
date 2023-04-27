Create Function FVariationIntHelper(@Id Int)
	Returns Nvarchar(100)
	With Execute As Caller
As
	Begin
		Declare @Temp Nvarchar(100)
		If(@Id = 1)
			Set @Temp = 'Color';
		Else If(@Id = 2)
			Set @Temp = 'Size';
		Return(@Temp);
	End

Create Function FVariationStringHelper(@Name Nvarchar(100))
	Returns Int
	With Execute As Caller
As
	Begin
		Declare @Temp Int
		If(@Name = 'Color')
			Set @Temp = 1;
		Else If(@Name = 'Size')
			Set @Temp = 2;
		Return(@Temp);
	End