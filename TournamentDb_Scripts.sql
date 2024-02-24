
Create database TournamentDb;

use TournamentDb
GO
create table People(
PersonId INT Primary Key Identity,
FirstName nvarchar(50) Not Null,
LastName nvarchar(50) Not Null,
EmailAddress nvarchar(50) Not Null,
PhoneNumber nvarchar(50) Not Null,
);

create table Teams(
TeamId INT Primary Key Identity,
TeamName nvarchar(50) Not Null
);
create table TeamMembers(
Id INT Primary Key Identity,
TeamId INT,
PersonId INT,
FOREIGN KEY (TeamId) REFERENCES Teams(TeamId),
FOREIGN KEY (PersonId) REFERENCES People(PersonId)
);


--EXEC sp_rename 'People.PeopleId', 'PersonId', 'COLUMN';


create Table Matchup
(
MatchupId int primary key Identity,
WinnerId int,
MatchupRound int,
Foreign key (WinnerId) references Teams(TeamId)
);

create Table MatchupEntries
(
MatchupEntryId int primary key Identity,
MatchupId int,
ParentMatchupId int,
TeamCompetingId int,
Score int,
Foreign key (MatchupId) references Matchup(MatchupId),
Foreign key (ParentMatchupId) references Matchup(MatchupId),
Foreign key (TeamCompetingId) references Teams(TeamId)
);
--EXEC sp_rename 'MatchupEntries.MatchupEntriesId', 'MatchupEntryId', 'COLUMN';

create Table Tournament
(
TournamentId int primary key Identity,
TournamentName nvarchar(100) Not Null,
EntryFee DECIMAL(18, 2),
);



create Table TournamentEntries
(
TournamentEntryId int primary key Identity,
TournamentId int,
TeamId int,
Foreign key (TournamentId) references Tournament(TournamentId),
Foreign key (TeamId) references Teams(TeamId)
);

--EXEC sp_rename 'TournamentEntries.TournamentEntriesId', 'TournamentEntryId', 'COLUMN';

create Table Prizes
(
PrizeId int primary key Identity,
PlaceNumber int,
PlaceName nvarchar(100) Not Null,
PrizeAmount DECIMAL(18, 2),
PrizePercentage float
);




create Table TournamentPrizes
(
TournamentPrizeId int primary key Identity,
TournamentId int,
PrizeId int,
Foreign key (TournamentId) references Tournament(TournamentId),
Foreign key (PrizeId) references Prizes(PrizeId)
);
Go