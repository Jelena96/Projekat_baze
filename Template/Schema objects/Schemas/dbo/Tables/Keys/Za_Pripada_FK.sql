ALTER TABLE Za ADD CONSTRAINT Za_Pripada_FK FOREIGN KEY ( Pripada_Kvar_Sifra_kvara, Pripada_Auto_Sifra_auta ) REFERENCES Pripada ( Kvar_Sifra_kvara, Auto_Sifra_auta ) ;

