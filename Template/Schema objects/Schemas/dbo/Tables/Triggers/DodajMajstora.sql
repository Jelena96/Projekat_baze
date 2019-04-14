CREATE TRIGGER [DodajMajstora]  
   ON  [dbo].Popravka
AFTER INSERT 
AS
BEGIN
	declare @idPopravka int;
	declare @id int;

	select @idPopravka= i.Sifra_usluge from inserted i;
	select @id = max(Sifra_radnika) FROM Majstor;
		INSERT INTO Radi_popravka(Popravka_Sifra_usluge,Majstor_Sifra_radnika) VALUES (@idPopravka,@id);
END
