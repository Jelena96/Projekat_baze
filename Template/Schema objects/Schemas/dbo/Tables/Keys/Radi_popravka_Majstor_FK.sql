ALTER TABLE Radi_popravka ADD CONSTRAINT Radi_popravka_Majstor_FK FOREIGN KEY ( Majstor_Sifra_radnika ) REFERENCES Majstor ( Sifra_radnika ) ON
DELETE CASCADE ;
