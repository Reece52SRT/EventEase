CREATE DATABASE EventEaseDB;
GO

USE EventEaseDB;
GO

CREATE TABLE Venue(
VenueId INT IDENTITY(1,1) PRIMARY KEY,
VenueName VARCHAR(75) NOT NULL,
VenueLocation VARCHAR(200) NOT NULL,
Capacity INT NOT NULL,
ImageUrl VARCHAR(250) NOT NULL
)

SELECT * FROM Venue

CREATE TABLE Event(
EventId INT IDENTITY(1,1) PRIMARY KEY,
EventName VARCHAR(75) NOT NULL,
EventDate DATE NOT NULL,
EventDescription VARCHAR(250) NOT NULL
)

SELECT * FROM Event

CREATE TABLE Booking(
BookingId INT IDENTITY(1,1) PRIMARY KEY,
BookingDate DATE NOT NULL,
VenueId INT NOT NULL,
EventId INT NOT NULL

FOREIGN KEY (VenueId) REFERENCES[Venue](VenueId),
FOREIGN KEY (EventId) REFERENCES[Event](EventId)
)

SELECT * FROM Booking

INSERT INTO Venue(VenueName, VenueLocation, Capacity, ImageUrl)
VALUES
('Moses Mabhida Stadium', 'Durban', 56000, 'https://www.globalafricanetwork.com/wp-content/uploads/2024/11/Moses-Mabhida-Stadium.jpg'),
('FNB Stadium', 'Johannesburg', 99000, 'https://lh3.googleusercontent.com/gps-cs-s/AB5caB--K22JSDh9ImmOhZEZd9b3zSflAnOJgMu5XcDrd73ViwY08_IN3jdvKSidz6mchzx979WVQns9WdJ2AhM3HwBLAjd5Bwh-4MwXjuR3wwmnRQh4xGkLCJd4ikut8W0zJi17QXE=w243-h203-n-k-no-nu ')

SELECT * FROM Venue

INSERT INTO Event(EventName, EventDescription, EventDate)
VALUES
('Top Gear Festival', 'Top Gear Festival is returning to the Moses Mabhida Stadium in the City of Durban with an incredible line-up of cars and driving talent!','2025-07-26'),
('Travis Scott','Internationally acclaimed superstar Travis Scott today announced the extension of his record-breaking CIRCUS MAXIMUS WORLD TOUR with a series of international stadium shows taking place this fall.','2025-10-11')

SELECT * FROM Event

INSERT INTO Booking(BookingDate, VenueId, EventId)
VALUES
('2025-07-26',1,1),
('2025-10-11',2,2)

SELECT * FROM Booking
