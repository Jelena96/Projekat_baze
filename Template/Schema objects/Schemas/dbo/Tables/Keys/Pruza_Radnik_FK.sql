ALTER TABLE Pruza ADD CONSTRAINT Pruza_Radnik_FK FOREIGN KEY ( Radnik_Sifra_radnika ) REFERENCES Radnik ( Sifra_radnika ) ON
DELETE CASCADE ;
