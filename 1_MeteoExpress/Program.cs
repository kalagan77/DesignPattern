// See https://aka.ms/new-console-template for more information



using _1_MeteoExpress;

ISujet donneesMeteo = new DonneesMeteo();
IAffichage affCond = new AffichageConditions(donneesMeteo);
//IAffichage affichageStat = new AffichageStatistiques(donneesMeteo);
donneesMeteo.SetMesures(26, 70, 1050);
donneesMeteo.SetMesures(28, 60, 900);

