ALTER TABLE Koristi ADD CONSTRAINT Koristi_Popravlja_FK FOREIGN KEY ( Popravlja_Sifra_kvara, Popravlja_Sifra_radnika ) REFERENCES Popravlja ( Kvar_Sifra_kvara, Majstor_Sifra_radnika ) ;

