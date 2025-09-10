// Program.cs

// 1) Startvärden att testa (ändra fritt och kör igen)
bool isVip = false;
bool hasPaidEntry = true;
int age = 19;

// 2) Reglerna:
//    - VIP: alltid ok
//    - annars: minst 20 år OCH betalat inträde
bool allowedIn = isVip || (age >= 20 && hasPaidEntry);

// 3) Utskrift enligt reglerna
if (allowedIn)
{
    Console.WriteLine("Välkommen in!");
}
else
{
    Console.WriteLine("Tyvärr, du kommer inte in.");
}
