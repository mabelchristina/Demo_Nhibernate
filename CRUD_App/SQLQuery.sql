USE[DbEmployee]    
GO    

CREATE TABLE Notes
(
NotesId int primary key not null identity(1,1),  
Title Nvarchar(50),  
Description Nvarchar(50),  
Reminder datetime,
Color Nvarchar(50),
Image Nvarchar(50)
)

select * from NoteTable
insert into NoteTable (Title,Description,Reminder,Color,Image)values('To-Do','Shopping',SYSDATETIME(),'blue','my.png')


CREATE TABLE[dbo].[NoteTable](    
    [NoteID][int] IDENTITY(1, 1) NOT NULL, [Title][varchar](50) NULL, [Description][varchar](50) NULL, [Reminder][datetime] NULL, [Color][nchar](50) NULL, [Image][nchar](50) NULL,    
    CONSTRAINT[PK_NoteTable] PRIMARY KEY CLUSTERED(    
        [NoteID] ASC    
    ) WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]    
) ON[PRIMARY]    
GO   
SET ANSI_PADDING OFF    
GO  

drop table Notes


select * from NoteTable

create table Collab
(collabID int identity(10,1) NOT NULL PRIMARY KEY,
collabEmail varchar(50),
NoteID  int FOREIGN KEY REFERENCES NoteTable(NoteID))

select * from Collab


  create table UserTable
  (
   UserID int identity(1,1) NOT NULL PRIMARY KEY,
   Email varchar(50),
   password varchar(50))