////////////////////////////////////////////////////////////////
		.NET Mail Reader - OutLook
		     Author : Vignesh

////////////////////////////////////////////////////////////////

This Source is to Read received emils from gamil.
The Account need to be Configured through Oulook Mail Client

This is a single form mail reader application that created using 
code first Entity Framework architecture and Repository Model

-----------/Used Frameworks/------------
1, Framework 4.6 is used
2, Entity Framework 6.2

------------/Lang & DB used/--------------
1, C# .net [VS 2015]
2, SQL Server 2012


This single from application contains a Get Mails button when pressed
retrieves the Unread Mails from OutLook express and Filters the sender,
Subect , Body and the attachments.The Second Button UpdateToDB updates
the Filtered Fields to the Sql Server DB with the DB Name 'EMailDB'.

The Complete source is included.
you can find the Runnable Exe under : 
ReadEMail\ReadEMail\bin\Debug\ReadEmail.exe

*Make Sure the Microsoft Outlook 14.0 com object or more included in
the Solution Reference.