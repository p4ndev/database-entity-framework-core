Create Trigger TSetupVariant
	On Product
	After Insert
As
	Begin
		Set NoCount On
		
		Declare @Pid Int
		
		Select @Pid = Id From Inserted
		
		Exec PSetupColor @Pid
		
		Exec PSetupSize @Pid
				
		Set NoCount Off
	End
	
Drop Trigger TSetupVariant;