// See https://aka.ms/new-console-template for more information
using SuperCanard;
using SuperCanard.Comportement;

//super canard => stratégie
//donnees meteo => observateur

Console.WriteLine("Hello, World!");

Colvert colvert= new Colvert();
colvert.EffectuerCancan();
colvert.EffectuerVol();

Canard proto = new PrototypeCanard();
proto.EffectuerVol();
proto.ChangerComportementVol(new PropulsionAReaction());
proto.EffectuerVol();

