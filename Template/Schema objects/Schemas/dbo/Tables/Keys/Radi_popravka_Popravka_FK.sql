ALTER TABLE Radi_popravka ADD CONSTRAINT Radi_popravka_Popravka_FK FOREIGN KEY ( Popravka_Sifra_usluge ) REFERENCES Popravka ( Sifra_usluge ) ON
DELETE CASCADE ;
