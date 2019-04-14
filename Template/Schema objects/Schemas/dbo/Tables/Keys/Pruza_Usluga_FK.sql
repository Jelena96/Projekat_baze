ALTER TABLE Pruza ADD CONSTRAINT Pruza_Usluga_FK FOREIGN KEY ( Usluga_Sifra_usluge ) REFERENCES Usluga ( Sifra_usluge ) ON
DELETE CASCADE ;
