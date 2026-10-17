# Studenți - bază de date

Aplicație Windows Forms pentru evidența studenților într-o bază de date SQL Server.

## Funcționalități

- afișarea studenților (număr matricol, nume, facultate, medie) într-un `DataGridView`
- inserare, actualizare și ștergere prin ADO.NET (`SqlConnection`, `SqlCommand`)
- selectarea unui student din tabel pentru editare într-un formular separat

## Tehnologii

C#, .NET Framework, Windows Forms, SQL Server LocalDB

## Rulare

1. Se atașează baza de date `StudentiDb.mdf` la LocalDB, cu numele `StudentiDb`
   (de exemplu din SQL Server Object Explorer în Visual Studio).
2. Se deschide `StudentiBazaDate.sln` și se pornește proiectul.

Aplicația se conectează la `(localdb)\MSSQLLocalDB`, baza `StudentiDb`.
