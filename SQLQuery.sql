CREATE DATABASE Anakkost
ON PRIMARY (
  NAME = Anakkost,
  FILENAME = 'E:\Database\Anakkost.mdf',  
  SIZE = 10,  
  MAXSIZE = 50,  
  FILEGROWTH = 2 ) 
LOG ON (  
  NAME = Anakkost_log,  
  FILENAME = 'E:\Database\Anakkost_log.ldf',  
  SIZE = 3MB,  
  MAXSIZE = 25MB,  
  FILEGROWTH = 3MB );
  GO

  USE Anakkost

  GO

   CREATE TABLE datapengguna(
	NO_Pengguna CHAR(5) NOT NULL PRIMARY KEY,
	NamaPengguna VARCHAR(50) NOT NULL,	
	UserNama VARCHAR(15) NOT NULL,
	Password VARCHAR(50) NOT NULL

  );
  GO

  ALTER TABLE datapengguna ADD Sisasaldo NUMERIC(18,2);
  

  CREATE TABLE Keuangan(
	No CHAR(5) NOT NULL PRIMARY KEY,
	NamaBarang VARCHAR(50) NOT NULL,
	Tanggal Datetime NOT NULL,
	Harga NUMERIC(18,2) NOT NULL,
	Keterangan VARCHAR(50) NOT NULL
  );
  GO

    CREATE TABLE Jadwal(
	No CHAR(5) NOT NULL PRIMARY KEY,
	Hari VARCHAR(50) NOT NULL,
	Kegiatan VARCHAR(50) NOT NULL,
	Keterangan VARCHAR(50) NOT NULL
  );
  GO

    CREATE TABLE Catatan(
	No CHAR(5) NOT NULL PRIMARY KEY,
	Catatan VARCHAR(50) NOT NULL,

  );
  GO

    CREATE TABLE History(
	Tanggal Datetime NOT NULL PRIMARY KEY,
	Total VARCHAR(50) NOT NULL,

  );
  GO
  SELECT * FROM Keuangan 
  GO
INSERT INTO Jadwal VALUES ('1','Senin','Kuliah','Sbd');
  
 GO


 INSERT INTO datapengguna VALUES ('1','Gilang Wahyudi','Admin','Admin','100000');
  
 GO

  INSERT INTO Keuangan VALUES ('1','Rokok','12/12/2018','1000','Kehilangan');
  INSERT INTO Keuangan VALUES ('2','Rokok','12/12/2018','10000','Barang');
   INSERT INTO Keuangan VALUES ('10','Rokok','12/11/2018','10000','Barang');
  
 GO



 select COALESCE(SUM(Harga),0)from Keuangan;
 go



 select Tanggal,sum(Harga) from Keuangan group by Tanggal 
	

 go

 select NamaBarang,sum(Harga) from Keuangann group by NamaBarang;
 go

 drop table Catatan

 select * from Keuangan where Tanggal Like '%2019-01-08%'