use Hotel

SET IDENTITY_INSERT tblHotelRooms ON

INSERT INTO tblHotelRooms
		([Id], [Name], [Quentity], [Price])
	VALUES
		(1, '�����������', 8, 600),
		(2, '�����������', 8, 696),
		(3, '��������', 6, 768),
		(4, '����', 2, 1032),
		(5, '��������c', 1, 1200)

SET IDENTITY_INSERT tblHotelRooms OFF
