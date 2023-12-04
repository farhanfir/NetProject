create database manajement_event
use manajement_event

-- Membuat tabel Pengguna
CREATE TABLE Pengguna (
    UserID INT NOT NULL PRIMARY KEY,
    NamaPengguna VARCHAR(50)NOT NULL,
    KataSandi VARCHAR(255) NOT NULL,
    NamaLengkap VARCHAR(100)NOT NULL,
    Email VARCHAR(100)NOT NULL,
    NomorTelepon VARCHAR(15)NOT NULL
);

-- Membuat tabel Event
CREATE TABLE Event (
    EventID INT NOT NULL PRIMARY KEY,
    NamaEvent VARCHAR(100)NOT NULL,
    TanggalMulai DATE NOT NULL ,
    TanggalSelesai DATE NOT NULL ,
    Lokasi VARCHAR(100) NOT NULL ,
    Deskripsi VARCHAR(500) NOT NULL 
);

-- Membuat tabel Peserta
CREATE TABLE Peserta (
    PesertaID INT NOT NULL PRIMARY KEY,
    NamaPeserta VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    NomorTelepon VARCHAR(15)NOT NULL,
    EventID INT FOREIGN KEY REFERENCES Event(EventID)
);

-- Membuat tabel Pembicara
CREATE TABLE Pembicara (
    PembicaraID INT NOT NULL PRIMARY KEY,
    NamaPembicara VARCHAR(100) NOT NULL,
    Profesi VARCHAR(50) NOT NULL,
    Bio VARCHAR(400) NOT NULL,
    EventID INT FOREIGN KEY REFERENCES Event(EventID)
);

-- Membuat tabel Sponsor
CREATE TABLE Sponsor (
    SponsorID INT NOT NULL PRIMARY KEY,
    NamaSponsor VARCHAR(100) NOT NULL,
    Deskripsi VARCHAR(400) NOT NULL,
    EventID INT FOREIGN KEY REFERENCES Event(EventID)
);


INSERT INTO Pengguna ( UserID, NamaPengguna, KataSandi, NamaLengkap, Email, NomorTelepon)
VALUES (01, 'farhansha', 'dicoba', 'Farhan_Shadiq', 'farhan01shadiq@gmail.com', '082259871706');
