Alter Table Brand
	Alter Column Name Nvarchar(255) Not Null;

Alter Table Brand
	Add Constraint PK_Brand Primary Key (Id);

Alter Table Brand
	Add Constraint UQ_Brand Unique (Name);