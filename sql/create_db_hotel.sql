create database Hotel

go

use Hotel

CREATE TABLE tblHotelRooms (
	[Id] int not null identity(1,1) PRIMARY KEY,
	[Name] nvarchar(255) not null,
	[Quentity] int not null,
	[Price] numeric(6,2)
);
CREATE TABLE tblRoomReservations (
	[Id] int not null identity(1,1) PRIMARY KEY,
	[FullName] nvarchar(255) not null,
	[HotelRoomId] int not null,
	[Phone] nvarchar(25) not null,
	[Email] nvarchar(255) not null,
);

ALTER TABLE tblRoomReservations ADD CONSTRAINT
	FK_tblRoomReservations_HotelRoomId_tblHotelRooms_Id
	FOREIGN KEY (HotelRoomId) REFERENCES tblHotelRooms(Id)
