ALTER TABLE Nabavlja ADD CONSTRAINT Nabavlja_Porucuje_FK FOREIGN KEY ( Porucuje_Sifra_radnika, Porucuje_Sifra_Deo ) REFERENCES Porucuje ( Komercijalista_Sifra_radnika, Deo_Sifra_Deo ) ;

