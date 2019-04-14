CREATE FUNCTION [dbo].[Funkcija]
(

)
RETURNS INT
AS
BEGIN
declare @return_value as decimal;
	select @return_value = count(sifra_alata)  from Alat inner join Koristi on Alat.Sifra_alata=Koristi.Alat_Sifra_alata;
	RETURN @return_value
END
