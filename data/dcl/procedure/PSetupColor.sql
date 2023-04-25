Create Procedure PSetupColor
	@ProductId Int
As
	Insert Into Variant(VariationType, ProductId, [Value])
		Values('Color', @ProductId, '#000000');

Drop Proc PSetupColor;