ALTER TABLE Radi_pregled ADD CONSTRAINT Radi_pregled_Tehnicki_pregled_FK FOREIGN KEY ( Tehnicki_pregled_Sifra_usluge ) REFERENCES Tehnicki_pregled ( Sifra_usluge ) ;

