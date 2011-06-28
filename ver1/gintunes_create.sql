CREATE TABLE Genre
(
      GenreID int PRIMARY KEY IDENTITY, 
      GenreName varchar (50) NOT NULL
)
INSERT INTO Genre(GenreName)
			Values ('Technical Test Metal')

CREATE TABLE YearTable
(
      YearID int PRIMARY KEY IDENTITY, 
      YearName varchar (5) NOT NULL
)
INSERT INTO YearTable(YearName)
			Values('2011')

CREATE TABLE Lable
(
      LableID int PRIMARY KEY IDENTITY, 
      LableName varchar (50) NOT NULL
)
INSERT INTO Lable(LableName)
			Values('TestMoon Records')

CREATE TABLE AlbumFormat
(
      FormatID int PRIMARY KEY IDENTITY, 
      FormatName varchar (50) NOT NULL
)
INSERT INTO AlbumFormat(FormatName)
			Values('MP3')

CREATE TABLE Artist
(
      ArtistID int PRIMARY KEY IDENTITY, 
      ArtistName varchar (50) NOT NULL,
	  GenreID int,
	  CONSTRAINT FK_GenreID FOREIGN KEY (GenreID) REFERENCES Genre(GenreID)
)
INSERT INTO Artist(ArtistName, GenreID)
			Values('Testeroth', 1)

CREATE TABLE Album
(
      AlbumID int PRIMARY KEY IDENTITY, 
      AlbumName varchar (50) NOT NULL,
	  ArtistID int,
	  YearID int,
	  LableID int,
	  FormatID int,
	  CONSTRAINT FK_ArtistID FOREIGN KEY (ArtistID) REFERENCES Artist(ArtistID),
	  CONSTRAINT FK_YearID FOREIGN KEY (YearID) REFERENCES YearTable(YearID),
	  CONSTRAINT FK_LableID FOREIGN KEY (LableID) REFERENCES Lable(LableID),
	  CONSTRAINT FK_FormatID FOREIGN KEY (FormatID) REFERENCES AlbumFormat(FormatID)
)
INSERT INTO Album(AlbumName, ArtistID, YearID, LableID, FormatID)
			Values ('Testcult Today', 1, 1, 1, 1)

CREATE TABLE TrackList
(
      TrackID int PRIMARY KEY IDENTITY, 
      TrackName varchar (50) NOT NULL,
	  AlbumID int,
	  TrackNum varchar (4) NOT NULL,
	  CONSTRAINT FK_AlbumIDTL FOREIGN KEY (AlbumID) REFERENCES Album(AlbumID)
)
INSERT INTO TrackList(TrackName, AlbumID, TrackNum)
			Values ('Test-Mantia', 1, '01')

CREATE TABLE PlayList
(
      PlayListID int PRIMARY KEY IDENTITY, 
      PlayListName varchar (50) NOT NULL,
	  AlbumID int,
	  ArtistID int,
	  TrackID int,
	  CONSTRAINT FK_PlTrackID FOREIGN KEY (TrackID) REFERENCES TrackList(TrackID),
	  CONSTRAINT FK_PlArtistID FOREIGN KEY (ArtistID) REFERENCES Artist(ArtistID),
	  CONSTRAINT FK_AlbumID FOREIGN KEY (AlbumID) REFERENCES Album(AlbumID)
)
INSERT INTO PlayList (PlayListName, AlbumID, ArtistID, TrackID)
			Values ('The Test Conjuration', 1, 1, 1)


