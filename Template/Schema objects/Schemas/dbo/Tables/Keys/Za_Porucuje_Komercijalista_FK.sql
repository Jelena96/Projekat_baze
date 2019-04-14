ALTER TABLE Za ADD CONSTRAINT Za_Porucuje_Komercijalista_FK FOREIGN KEY ( Porucuje_Komercijalista_Sifra_radnika, Porucuje_Deo_Sifra_Deo ) REFERENCES Porucuje ( Komercijalista_Sifra_radnika, Deo_Sifra_Deo ) ;

