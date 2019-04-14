ALTER TABLE Radi_pregled ADD CONSTRAINT Radi_pregled_Radnik_na_tehnickom_pregledu_FK FOREIGN KEY ( Radnik_na_tehnickom_pregledu_Sifra_radnika ) REFERENCES Radnik_na_tehnickom_pregledu ( Sifra_radnika ) ;

