# Database project

## Application interface
![ss1](https://github.com/danitns/database-project/blob/master/sdf_bd/script/1.png)
![ss2](https://github.com/danitns/database-project/blob/master/sdf_bd/script/2.png)
![ss3](https://github.com/danitns/database-project/blob/master/sdf_bd/script/3.png)

## SQL Script for database creation:
```sql
--create database SALA_DE_FITNESS;
--USE SALA_DE_FITNESS;

--Creare tabel SALA
CREATE TABLE "SALA" (
	ID_SALA VARCHAR(10),
	NUME VARCHAR(30) CONSTRAINT SALA_NUME_NN NOT NULL, 
	ADRESA VARCHAR(30) CONSTRAINT SALA_ADRESA_NN NOT NULL,
	EMAIL VARCHAR(30) CONSTRAINT SALA_EMAIL_NN NOT NULL,
	TELEFON VARCHAR(10) CONSTRAINT SALA_TEL_NN NOT NULL,
	CONSTRAINT SALA_ID_SALA_PK PRIMARY KEY(ID_SALA),
	CONSTRAINT SALA_NUME_UQ UNIQUE(ID_SALA),
	CONSTRAINT SALA_EMAIL_UQ UNIQUE(EMAIL),
	CONSTRAINT SALA_TEL_UQ UNIQUE(TELEFON)
);

--Creare tabel MENTENANTA
CREATE TABLE "MENTENANTA" (
	ID_ANGAJAT INT IDENTITY(1,1),
	ID_SALA VARCHAR(10) CONSTRAINT MNT_ID_SALA_NN NOT NULL,
	NUME VARCHAR(30) CONSTRAINT MNT_NUME_NN NOT NULL,
	PRENUME VARCHAR(30) CONSTRAINT MNT_PRENUME_NN NOT NULL,
	SALARIU INT,
	OCUPATIE VARCHAR(30),
	CONSTRAINT MNT_ID_ANGAJAT_PK PRIMARY KEY(ID_ANGAJAT),
	CONSTRAINT MNT_SAL_MIN CHECK(SALARIU > 0),
	CONSTRAINT MNT_ID_SALA_FK FOREIGN KEY(ID_SALA)
	REFERENCES "SALA"(ID_SALA)
	ON DELETE CASCADE ON UPDATE CASCADE
);

--Creare tabel SUPLIMENT
CREATE TABLE "SUPLIMENT" (
	ID_SUPLIMENT INT IDENTITY(1,1),
	BRAND VARCHAR(30),
	NUME VARCHAR(30) CONSTRAINT SUP_NUME_NN NOT NULL,
	PRET TINYINT CONSTRAINT SUP_PRET_MIN CHECK(PRET > 0),
	CONSTRAINT SUP_ID_SUP_PK PRIMARY KEY(ID_SUPLIMENT)
);

--Creare tabel STOC
CREATE TABLE "STOC" (
	ID_SUPLIMENT INT,
	ID_SALA VARCHAR(10),
	CANTITATE INT CONSTRAINT STOC_CANTITATE_MIN CHECK(CANTITATE >= 0)
	CONSTRAINT STOC_PK PRIMARY KEY(ID_SUPLIMENT, ID_SALA),
	CONSTRAINT STOC_ID_SUP_FK FOREIGN KEY(ID_SUPLIMENT)
	REFERENCES "SUPLIMENT"(ID_SUPLIMENT),
	CONSTRAINT STOC_ID_SALA_FK FOREIGN KEY(ID_SALA)
	REFERENCES "SALA"(ID_SALA)
	ON DELETE CASCADE ON UPDATE CASCADE
);

--Creare tabel ANTRENOR
CREATE TABLE "ANTRENOR" (
	ID_ANTRENOR INT IDENTITY(1,1),
	ID_SALA VARCHAR(10) CONSTRAINT ANTR_ID_SALA_NN NOT NULL,
	NUME VARCHAR(30) CONSTRAINT ANTR_NUME_NN NOT NULL,
	PRENUME VARCHAR(30) CONSTRAINT ANTR_PRENUME_NN NOT NULL,
	SALARIU INT,
	CONSTRAINT ANTR_ID_ANTR_PK PRIMARY KEY(ID_ANTRENOR),
	CONSTRAINT ANTR_SAL_MIN CHECK(SALARIU > 0),
	CONSTRAINT ANTR_ID_SALA_FK FOREIGN KEY(ID_SALA)
	REFERENCES "SALA"(ID_SALA)
	ON DELETE CASCADE ON UPDATE CASCADE
);

--Creare tabel CLASA
CREATE TABLE "CLASA" (
	ID_CLASA VARCHAR(15),
	ID_ANTRENOR INT CONSTRAINT CLS_ID_ANTR_NN NOT NULL,
	NUME VARCHAR(30),
	DURATA TIME(0),
	CONSTRAINT CLS_ID_CLS_PK PRIMARY KEY(ID_CLASA),
	CONSTRAINT CLS_DURATA_MIN CHECK(DURATA > CAST('00:00:00' AS time(0))),
	CONSTRAINT CLS_ID_ANTR_FK FOREIGN KEY(ID_ANTRENOR)
	REFERENCES "ANTRENOR"(ID_ANTRENOR)
	ON DELETE CASCADE ON UPDATE CASCADE
);

--Creare tabel ABONAMENT
CREATE TABLE "ABONAMENT" (
	TIP_ABONAMENT VARCHAR(15),
	PRET INT,
	DURATA INT,
	SAUNA BIT CONSTRAINT AB_SAUNA_NN NOT NULL,
	SPA BIT CONSTRAINT AB_SPA_NN NOT NULL,
	PISCINA BIT CONSTRAINT AB_PISCINA_NN NOT NULL,
	CONSTRAINT AB_TIP_AB_PK PRIMARY KEY(TIP_ABONAMENT),
	CONSTRAINT AB_PRET_MIN CHECK(PRET > 0),
	CONSTRAINT AB_DURATA_MIN CHECK(DURATA > 0 AND DURATA <= 365)
);

--Creare tabel CLIENT
CREATE TABLE "CLIENT" (
	ID_CLIENT INT IDENTITY(1,1),
	ID_TRANZACTIE INT,
	NUME VARCHAR(30) CONSTRAINT CL_NUME_NN NOT NULL,
	PRENUME VARCHAR(30) CONSTRAINT CL_PRENUME_NN NOT NULL,
	EMAIL VARCHAR(40),
	TELEFON VARCHAR(10) CONSTRAINT CL_TEL_NN NOT NULL,
	CONSTRAINT CL_ID_CL_PK PRIMARY KEY(ID_CLIENT),
	CONSTRAINT CL_EMAIL_UQ UNIQUE(EMAIL),
	CONSTRAINT CL_TEL_UQ UNIQUE(TELEFON),
);

--Creare tabel TRANZACTIE
CREATE TABLE "TRANZACTIE" (
	ID_TRANZACTIE INT IDENTITY(1,1),
	TIP_ABONAMENT VARCHAR(15) CONSTRAINT TR_TIP_AB_NN NOT NULL,
	ID_CLIENT INT CONSTRAINT TR_ID_CLIENT_NN NOT NULL,
	DATA_INCEPUT DATE,
	CONSTRAINT TR_ID_TR_PK PRIMARY KEY(ID_TRANZACTIE),
	CONSTRAINT TR_TIP_AB_FK FOREIGN KEY(TIP_ABONAMENT)
	REFERENCES "ABONAMENT"(TIP_ABONAMENT)
	ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT TR_ID_CLIENT_FK FOREIGN KEY(ID_CLIENT)
	REFERENCES "CLIENT"(ID_CLIENT)
	ON DELETE CASCADE ON UPDATE CASCADE
);

--Adaugare constraint pentru CLIENT
ALTER TABLE CLIENT
ADD CONSTRAINT CL_ID_TR_FK FOREIGN KEY(ID_TRANZACTIE)
REFERENCES "TRANZACTIE"(ID_TRANZACTIE);

--Creare tabel PROGRAM
CREATE TABLE "PROGRAM" (
	ID_CLASA VARCHAR(15),
	ID_CLIENT INT,
	ZI_ORA SMALLDATETIME,
	CONSTRAINT PRG_PK PRIMARY KEY(ID_CLASA, ID_CLIENT),
	CONSTRAINT PRG_ID_CLS_FK FOREIGN KEY(ID_CLASA)
	REFERENCES "CLASA"(ID_CLASA)
	ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT PRG_ID_CL_FK FOREIGN KEY(ID_CLIENT)
	REFERENCES "CLIENT"(ID_CLIENT)
);
```
