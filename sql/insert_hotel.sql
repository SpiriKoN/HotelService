use Hotel

SET IDENTITY_INSERT tblHotelRooms ON

INSERT INTO tblHotelRooms
		([Id], [Name], [Quentity], [Price])
	VALUES
		(1, 'Одноместный', 8, 600),
		(2, 'Двухместный', 8, 696),
		(3, 'Полулюкс', 6, 768),
		(4, 'Люкс', 2, 1032),
		(5, 'СуперЛюкc', 1, 1200)

SET IDENTITY_INSERT tblHotelRooms OFF
