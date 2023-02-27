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

---Inserare valori:
--Sala
INSERT INTO "SALA"
VALUES
(
	'S5_RHV',
	'Gold''s Gym Rahova',
	'Tudor Vladimirescu 22',
	's5_rhv@goldsgym.ro',
	'0749115351'
),
(
	'S6_DTR',
	'Gold''s Gym Drumul Taberei',
	'Str. Brasov 25',
	's6_dtr@goldsgym.ro',
	'0729945663'
),
(
	'S6_MLT',
	'Gold''s Gym Militari',
	'Bd. Iuliu Maniu 10',
	's6_mlt@goldsgym.ro',
	'0776100508'
),
(
	'S3_DRT',
	'Gold''s Gym Dristor',
	'Bd. Camil Ressu 23',
	's3_drt@goldsgym.ro',
	'0789209907'
),
(
	'S4_BRC',
	'Gold''s Gym Berceni',
	'Sos. Oltenitei 12',
	's4_brc@goldsgym.ro',
	'0730034677'
),
(
	'S1_PPR',
	'Gold''s Gym Pipera',
	'Calea Floreasca 246',
	's1_ppr@goldsgym.ro',
	'0785515381'
);

--Mentenanta
INSERT INTO MENTENANTA (
	ID_SALA, NUME, PRENUME, SALARIU, OCUPATIE
) VALUES
(
	'S1_PPR',
	'Dima',
	'Lucian',
	4900,
	'Manager'
),
(
	'S1_PPR',
	'Munteanu',
	'Andrei',
	2500,
	'Receptionist'
),
(
	'S1_PPR',
	'Chirita',
	'Claudia',
	2500,
	'Receptionist'
),
(
	'S1_PPR',
	'Diaconu',
	'Camelia',
	2500,
	'Receptionist'
),
(
	'S1_PPR',
	'Ionescu',
	'Ovidiu',
	3100,
	'Mecanic'
),
(
	'S1_PPR',
	'Gherban',
	'Casiana',
	1950,
	'Personal curatenie'
),
(
	'S1_PPR',
	'Dumitrescu',
	'Horia',
	1925,
	'Personal curatenie'
),
(
	'S1_PPR',
	'Diaconu',
	'Sebastian',
	2050,
	'Personal curatenie'
),
(
	'S3_DRT',
	'Slaboiu',
	'Anastasia',
	5100,
	'Manager'
),
(
	'S3_DRT',
	'Dragomir',
	'Vlad',
	2500,
	'Receptionist'
),
(
	'S3_DRT',
	'Valentina',
	'Gherghe',
	2500,
	'Receptionist'
),
(
	'S3_DRT',
	'Cristian',
	'Stefan',
	2500,
	'Receptionist'
),
(
	'S3_DRT',
	'Todica',
	'Andreea',
	3100,
	'Mecanic'
),
(
	'S3_DRT',
	'Manolache',
	'Clara',
	1950,
	'Personal curatenie'
),
(
	'S3_DRT',
	'Matei',
	'Eugen',
	1925,
	'Personal curatenie'
),
(
	'S3_DRT',
	'Dumitru',
	'Maria',
	2050,
	'Personal curatenie'
),
(
	'S4_BRC',
	'Ciobanu',
	'Alberto',
	4200,
	'Manager'
),
(
	'S4_BRC',
	'Dobre',
	'Eugen',
	2500,
	'Receptionist'
),
(
	'S4_BRC',
	'Craciun',
	'Victoria',
	2350,
	'Receptionist'
),
(
	'S4_BRC',
	'Ionescu',
	'Vlad',
	2830,
	'Receptionist'
),
(
	'S4_BRC',
	'Florea',
	'Lucian',
	3300,
	'Mecanic'
),
(
	'S4_BRC',
	'Dinescu',
	'Emanuel',
	1880,
	'Personal curatenie'
),
(
	'S4_BRC',
	'Stoica',
	'Andreea',
	2255,
	'Personal curatenie'
),
(
	'S4_BRC',
	'Stanciu',
	'Alfred',
	2150,
	'Personal curatenie'
),
(
	'S5_RHV',
	'Gherghe',
	'Otilia',
	5150,
	'Manager'
),
(
	'S5_RHV',
	'Ciobanu',
	'Victor',
	2225,
	'Receptionist'
),
(
	'S5_RHV',
	'Pavel',
	'Anastasia',
	2350,
	'Receptionist'
),
(
	'S5_RHV',
	'Toma',
	'Marius',
	2810,
	'Receptionist'
),
(
	'S5_RHV',
	'Florescu',
	'Otilia',
	3500,
	'Mecanic'
),
(
	'S5_RHV',
	'Draghici',
	'Camelia',
	2380,
	'Manager'
),
(
	'S5_RHV',
	'Calinescu',
	'Cosmin',
	2655,
	'Personal curatenie'
),
(
	'S5_RHV',
	'Dinu',
	'Eugen',
	2150,
	'Personal curatenie'
),
(
	'S6_DTR',
	'Catalin',
	'David',
	5150,
	'Manager'
),
(
	'S6_DTR',
	'Dinescu',
	'Victor',
	2725,
	'Receptionist'
),
(
	'S6_DTR',
	'Lamboiu',
	'Gabriela',
	2350,
	'Receptionist'
),
(
	'S6_DTR',
	'Pavel',
	'Alexandra',
	2810,
	'Receptionist'
),
(
	'S6_DTR',
	'Tamas',
	'Aurelian',
	3600,
	'Mecanic'
),
(
	'S6_DTR',
	'Grigorita',
	'Luminita',
	2280,
	'Manager'
),
(
	'S6_DTR',
	'Vlasceanu',
	'Nadia',
	2655,
	'Personal curatenie'
),
(
	'S6_DTR',
	'Nistor',
	'Victor',
	2150,
	'Personal curatenie'
),
(
	'S6_MLT',
	'Birsan',
	'Elisabeta',
	5350,
	'Manager'
),
(
	'S6_MLT',
	'Tamas',
	'Daniel',
	2325,
	'Receptionist'
),
(
	'S6_MLT',
	'Dobre',
	'Anton',
	2150,
	'Receptionist'
),
(
	'S6_MLT',
	'Ciobanu',
	'Pavel',
	2810,
	'Receptionist'
),
(
	'S6_MLT',
	'Stanciu',
	'David',
	3100,
	'Mecanic'
),
(
	'S6_MLT',
	'Olteanu',
	'Nicoleta',
	2380,
	'Manager'
),
(
	'S6_MLT',
	'Slaboiu',
	'Adela',
	2655,
	'Personal curatenie'
),
(
	'S6_MLT',
	'Manole',
	'Dorin',
	2150,
	'Personal curatenie'
);


INSERT INTO SUPLIMENT (BRAND, NUME, PRET)
VALUES 
(
	'Vitabolic',
	'EAA',
	9
),
(
	'MyProtein',
	'Preworkout',
	70
),
(
	'Weider',
	'BCAA',
	55
),
(
	'Vitabolic',
	'Creatina',
	45
),
(
	'BioTechUSA',
	'Proteina',
	150
),
(
	'BioTechUSA',
	'Creatina',
	35
);



INSERT INTO STOC 
VALUES
(
	1,
	'S1_PPR',
	25
),
(
	5,
	'S1_PPR',
	43
),
(
	2,
	'S3_DRT',
	45
),
(	
	4,
	'S3_DRT',
	10
),
(
	3,
	'S4_BRC',
	25
),
(
	5,	
	'S4_BRC',
	24
),
(
	6,
	'S5_RHV',
	15
),
(
	2,
	'S5_RHV',
	71
),
(
	1,
	'S6_DTR',
	29
),
(
	2,
	'S6_DTR',
	19
),
(
	3,
	'S6_MLT',
	65
),
(
	6,
	'S6_MLT',
	12
);

INSERT INTO ANTRENOR 
(ID_SALA, NUME, PRENUME, SALARIU)
VALUES
(
	'S1_PPR',
	'Palici',
	'Smaranda',
	4800
),
(
	'S1_PPR',
	'Nistor',
	'Sebastian',
	4700
),
(
	'S3_DRT',
	'Munteanu',
	'Igor',
	4950
),
(
	'S3_DRT',
	'Angelica',
	'Daria',
	4510
),
(
	'S4_BRC',
	'Iancu',
	'Paul',
	4800
),
(
	'S4_BRC',
	'Albu',
	'Iustin',
	5100
),
(
	'S5_RHV',
	'Ciorcarlan',
	'Narcisa',
	4600
),
(
	'S5_RHV',
	'Vasilica',
	'Valentina',
	4820
),
(
	'S6_MLT',
	'Tabacu',
	'Ovidiu',
	4700
),
(
	'S6_MLT',
	'Buse',
	'Bogdan',
	4550
),
(
	'S6_DTR',
	'Rusu',
	'Gabriel',
	5050
),
(
	'S6_DTR',
	'Staruiala',
	'Elisabeta',
	5010
);


INSERT INTO CLASA
VALUES
(
	'PIL_1',
	1,
	'Pilates',
	CAST('01:00:00' AS TIME(0))
),
(
	'ZM_2',
	2,
	'Zumba',
	CAST('01:30:00' AS TIME(0))
),
(
	'BB_3',
	3,
	'Bodybuilding',
	CAST('02:10:00' AS TIME(0))
),
(
	'KB_4',
	4,
	'Kickbox',
	CAST('00:45:00' AS TIME(0))
),
(
	'KJ_5',
	5,
	'KangooJumps',
	CAST('01:15:00' AS TIME(0))
),
(
	'CC_6',
	6,
	'Cycling',
	CAST('01:30:00' AS TIME(0))
),
(
	'ST_7',
	7,
	'Stretching',
	CAST('00:45:00' AS TIME(0))
),
(
	'YG_8',
	8,
	'Yoga',
	CAST('01:35:00' AS TIME(0))
),
(
	'TRX_9',
	9,
	'TRX',
	CAST('00:50:00' AS TIME(0))
),
(
	'FB_10',
	10,
	'Fitball',
	CAST('01:20:00' AS TIME(0))
),
(
	'HT_11',
	11,
	'HIIT',
	CAST('00:50:00' AS TIME(0))
),
(
	'TB_12',
	12,
	'TotalBody',
	CAST('02:00:00' AS TIME(0))
);


INSERT INTO ABONAMENT
VALUES
(
	'Bronze30',
	150,
	30,
	0,
	0,
	0
),
(
	'Bronze60',
	270,
	60,
	0,
	0,
	0
),
(
	'Silver30',
	180,
	30,
	1,
	0,
	0
),
(
	'Silver365',
	2000,
	365,
	1,
	0,
	0
),
(
	'Gold30',
	210,
	30,
	1,
	1,
	0
),
(
	'Gold60',
	380,
	60,
	1,
	1,
	0
),
(
	'Platinum30',
	250,
	30,
	1,
	1,
	1
),
(
	'Platinum90',
	650,
	90,
	1,
	1,
	1
);

INSERT INTO CLIENT
(NUME, PRENUME, EMAIL, TELEFON)
VALUES
(
	'Dobre',
	'Igor',
	'dobreigor@gmail.com',
	'0790429103'
),
(
	'Pindaru',
	'Elvira',
	'pandaruelvira@gmail.com',
	'0787591654'
),
(
	'Ciorcarlan',
	'Sonia',
	'csonia@gmail.com',
	'0792657460'
),
(
	'Manolache',
	'Corina',
	'mncorina@gmail.com',
	'0755672855'
),
(
	'Craciun',
	'Andreea',
	'crandreea@gmail.com',
	'0782662977'
),
(
	'Bratosin',
	'Andreea',
	'brandreea@gmail.com',
	'0791097925'
),
(
	'Dumitru',
	'Anastasia',
	'drtanastasia@gmail.com',
	'0773985301'
),
(
	'Gherghe',
	'Carmen',
	'ghgcarmen@gmail.com',
	'0733182151'
),
(
	'Dabija',
	'Emanuel',
	'dbemanuel@gmail.com',
	'0776246425'
),
(
	'Palici',
	'Sonia',
	'palsonia@gmail.com',
	'0741647363'
),
(
	'Popescu',
	'Sebastian',
	'ppsebi@gmail.com',
	'0715572047'
),
(
	'Gabureanu',
	'Maria',
	'gbbmaria@gmail.com',
	'0787740835'
),
(
	'Chirita',
	'Otilia',
	'chrotilia@gmail.com',
	'0719733156'
),
(
	'Birau',
	'Melania',
	'brmelania@gmail.com',
	'0728859760'
),
(
	'Draghici',
	'Dalia',
	'drgdalia@gmail.com',
	'0722893059'
),
(
	'Chirita',
	'Carla',
	'chrcarla@gmail.com',
	'0756175508'
),
(
	'Lamboiu',
	'Daria',
	'lamdaria@gmail.com',
	'0717971812'
),
(
	'Ionescu',
	'Andrei',
	'inscandrei@gmail.com',
	'0711733008'
),
(
	'Iancu',
	'Alexandru',
	'iancualex@gmail.com',
	'0725883855'
),
(
	'Birsan',
	'Nicoleta',
	'birnico@gmail.com',
	'0779937346'
),
(
	'Lamboiu',
	'Maria',
	'lammaria@gmail.com',
	'0753049227'
),
(
	'Moisescu',
	'Nicolae',
	'moisenico@gmail.com',
	'0766148606'
),
(
	'Florescu',
	'Gabriela',
	'flrgaby@gmail.com',
	'0718894369'
),
(
	'Marin',
	'Alfred',
	'malfred@gmail.com',
	'0790810459'
);

INSERT INTO TRANZACTIE (
	TIP_ABONAMENT, ID_CLIENT, DATA_INCEPUT
)
VALUES (
	'Bronze30',
	1,
	CAST('2022-02-12' AS DATE)
),
(
	'Bronze30',
	2,
	CAST('2022-03-12' AS DATE)
),
(
	'Bronze30',
	3,
	CAST('2022-02-22' AS DATE)
),
(
	'Bronze30',
	4,
	CAST('2022-01-30' AS DATE)
),
(
	'Bronze60',
	5,

	CAST('2022-05-16' AS DATE)
),
(
	'Bronze60',
	6,
	CAST('2022-04-16' AS DATE)
),
(
	'Bronze60',
	7,
	CAST('2022-09-24' AS DATE)
),
(
	'Silver30',
	8,
	CAST('2022-09-11' AS DATE)
),
(
	'Silver365',
	9,
	CAST('2022-08-12' AS DATE)
),
(
	'Gold30',
	10,
	CAST('2021-05-25' AS DATE)
),
(
	'Gold30',
	11,
	CAST('2021-04-23' AS DATE)
),
(
	'Gold60',
	12,
	CAST('2021-01-20' AS DATE)
),
(
	'Gold30',
	13,
	CAST('2021-02-01' AS DATE)
),
(
	'Gold30',
	14,
	CAST('2022-04-25' AS DATE)
),
(
	'Platinum30',
	15,
	CAST('2020-04-12' AS DATE)
),
(
	'Gold30',
	16,
	CAST('2023-01-12' AS DATE)
),
(
	'Gold60',
	17,
	CAST('2022-10-23' AS DATE)
),
(
	'Platinum90',
	18,
	CAST('2020-03-10' AS DATE)
),
(
	'Gold60',
	19,
	CAST('2022-05-25' AS DATE)
),
(
	'Silver30',
	20,
	CAST('2022-12-23' AS DATE)
),
(
	'Gold30',
	21,
	CAST('2023-05-25' AS DATE)
),
(
	'Gold30',
	22,
	CAST('2021-11-11' AS DATE)
),
(
	'Bronze60',
	23,
	CAST('2022-11-12' AS DATE)
),
(
	'Gold30',
	24,
	CAST('2022-11-11' AS DATE)
);




UPDATE CLIENT
SET ID_TRANZACTIE = 1
WHERE ID_CLIENT = 1;
UPDATE CLIENT
SET ID_TRANZACTIE = 2
WHERE ID_CLIENT = 2;
UPDATE CLIENT
SET ID_TRANZACTIE = 3
WHERE ID_CLIENT = 3;
UPDATE CLIENT
SET ID_TRANZACTIE = 4
WHERE ID_CLIENT = 4;
UPDATE CLIENT
SET ID_TRANZACTIE = 5
WHERE ID_CLIENT = 5;
UPDATE CLIENT
SET ID_TRANZACTIE = 6
WHERE ID_CLIENT = 6;
UPDATE CLIENT
SET ID_TRANZACTIE = 7
WHERE ID_CLIENT = 7;
UPDATE CLIENT
SET ID_TRANZACTIE = 8
WHERE ID_CLIENT = 8;
UPDATE CLIENT
SET ID_TRANZACTIE = 9
WHERE ID_CLIENT = 9;
UPDATE CLIENT
SET ID_TRANZACTIE = 10
WHERE ID_CLIENT = 10;
UPDATE CLIENT
SET ID_TRANZACTIE = 11
WHERE ID_CLIENT = 11;
UPDATE CLIENT
SET ID_TRANZACTIE = 12
WHERE ID_CLIENT = 12;
UPDATE CLIENT
SET ID_TRANZACTIE = 13
WHERE ID_CLIENT = 13;
UPDATE CLIENT
SET ID_TRANZACTIE = 14
WHERE ID_CLIENT = 14;
UPDATE CLIENT
SET ID_TRANZACTIE = 15
WHERE ID_CLIENT = 15;
UPDATE CLIENT
SET ID_TRANZACTIE = 16
WHERE ID_CLIENT = 16;
UPDATE CLIENT
SET ID_TRANZACTIE = 17
WHERE ID_CLIENT = 17;
UPDATE CLIENT
SET ID_TRANZACTIE = 18
WHERE ID_CLIENT = 18;
UPDATE CLIENT
SET ID_TRANZACTIE = 19
WHERE ID_CLIENT = 19;
UPDATE CLIENT
SET ID_TRANZACTIE = 20
WHERE ID_CLIENT = 20;
UPDATE CLIENT
SET ID_TRANZACTIE = 21
WHERE ID_CLIENT = 21;
UPDATE CLIENT
SET ID_TRANZACTIE = 22
WHERE ID_CLIENT = 22;
UPDATE CLIENT
SET ID_TRANZACTIE = 23
WHERE ID_CLIENT = 23;
UPDATE CLIENT
SET ID_TRANZACTIE = 24
WHERE ID_CLIENT = 24;


INSERT INTO PROGRAM
VALUES
(
	'PIL_1',
	1,
	CAST('2022-03-12 13:00:00' AS SMALLDATETIME)
),
(
	'PIL_1',
	2,
	CAST('2022-02-01 12:00:00' AS SMALLDATETIME)
),
(
	'ZM_2',
	3,
	CAST('2022-01-02 11:00:00' AS SMALLDATETIME)
),
(
	'ZM_2',
	4,
	CAST('2022-02-03 16:00:00' AS SMALLDATETIME)
),
(
	'BB_3',
	5,
	CAST('2022-03-13 13:00:00' AS SMALLDATETIME)
),
(
	'BB_3',
	6,
	CAST('2022-04-04 12:00:00' AS SMALLDATETIME)
),
(
	'KB_4',
	7,
	CAST('2022-01-12 14:00:00' AS SMALLDATETIME)
),
(
	'KB_4',
	8,
	CAST('2022-03-13 20:30:00' AS SMALLDATETIME)
),
(
	'KJ_5',
	9,
	CAST('2021-09-09 09:00:00' AS SMALLDATETIME)
),
(
	'KJ_5',
	10,
	CAST('2022-05-11 21:00:00' AS SMALLDATETIME)
),
(
	'CC_6',
	11,
	CAST('2022-06-14 20:00:00' AS SMALLDATETIME)
),
(
	'CC_6',
	12,
	CAST('2022-11-20 19:00:00' AS SMALLDATETIME)
),
(
	'ST_7',
	13,
	CAST('2022-04-15 18:00:00' AS SMALLDATETIME)
),
(
	'ST_7',
	14,
	CAST('2022-04-13 17:00:00' AS SMALLDATETIME)
),
(
	'YG_8',
	15,
	CAST('2022-10-11 16:00:00' AS SMALLDATETIME)
),
(
	'YG_8',
	16,
	CAST('2022-05-14 11:00:00' AS SMALLDATETIME)
),
(
	'TRX_9',
	17,
	CAST('2021-11-13 10:00:00' AS SMALLDATETIME)
),
(
	'TRX_9',
	18,
	CAST('2022-08-29 14:00:00' AS SMALLDATETIME)
),
(
	'FB_10',
	19,
	CAST('2021-03-15 08:00:00' AS SMALLDATETIME)
),
(
	'FB_10',
	20,
	CAST('2022-11-04 09:00:00' AS SMALLDATETIME)
),
(
	'HT_11',
	21,
	CAST('2022-12-23 14:00:00' AS SMALLDATETIME)
),
(
	'HT_11',
	22,
	CAST('2022-09-14 12:00:00' AS SMALLDATETIME)
),
(
	'TB_12',
	23,
	CAST('2022-04-17 08:00:00' AS SMALLDATETIME)
),
(
	'TB_12',
	24,
	CAST('2022-01-12 12:00:00' AS SMALLDATETIME)
);

--Creare vizualizare complexa
GO
CREATE VIEW V_MENTENANTA AS
	SELECT
		ID_SALA, AVG(SALARIU) MedieSal
	FROM 
		MENTENANTA
	GROUP BY ID_SALA;

--Creare vizualizare compusa. Se pot realiza operatii pe atributele din tabelul ANTRENOR
GO
CREATE VIEW V_SALA_ANTRENOR AS
	SELECT
		A.ID_SALA, A.ID_ANTRENOR, A.NUME, A.PRENUME, A.SALARIU, S.NUME AS NUME_SALA, S.ADRESA, S.EMAIL, S.TELEFON
	FROM ANTRENOR A
	JOIN SALA S ON S.ID_SALA = A.ID_SALA;
GO
SET IDENTITY_INSERT ANTRENOR ON;

