CREATE PROCEDURE dbo.spPerson_Insert
	@FirstName varchar(50),
	@LastName varchar(50),
	@EmailAddress varchar(50),
	@PhoneNumber varchar(50),
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;
	insert into dbo.People(FirstName,LastName,EmailAddress,PhoneNumber)
	Values(@FirstName, @LastName,@EmailAddress,@PhoneNumber);

	--Return current Id
	select @id = SCOPE_IDENTITY(); 
END
GO
