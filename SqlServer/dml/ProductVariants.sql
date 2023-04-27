-- Colors (#000000, #0000FF)
Select * From Variant Where Id In (1, 5);
Insert Into ProductVariant (ProductId, VariantId) Values(1, 5);

-- Size (P, GG)
Select * From Variant Where Id In (2, 8);
Insert Into ProductVariant (ProductId, VariantId) Values(1, 8);

-- Product (Performance T-shirt)
Select * From Product Where Id = 1;

-- Product x Variation (Relationship)
Select * From ProductVariant Where ProductId = 1;