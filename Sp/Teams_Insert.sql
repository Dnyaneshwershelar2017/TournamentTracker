CREATE PROCEDURE dbo.spTeams_Insert
	@TeamName nvarchar(50),
	@id int =0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.Teams(TeamName)
	values(@TeamName);

	select @id = Scope_Identity()
END
GO
