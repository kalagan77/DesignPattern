// See https://aka.ms/new-console-template for more information
using _5_Commande;

TelecommandeSimple telecommandeSimple = new TelecommandeSimple();
Lampe lampe = new Lampe();
PorteGarage porteGarage= new PorteGarage();

CommandeAllumerLampe cmdLampe = new CommandeAllumerLampe(lampe);
CommandeOuvrirPorteGarage cmdGarage = new CommandeOuvrirPorteGarage(porteGarage);

telecommandeSimple.SetCommande(cmdLampe);
telecommandeSimple.BoutonPresse();

telecommandeSimple.SetCommande(cmdGarage);
telecommandeSimple.BoutonPresse();


Console.WriteLine("Hello, World!");
