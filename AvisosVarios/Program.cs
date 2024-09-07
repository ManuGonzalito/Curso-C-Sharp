using AvisosVarios;

AvisosTrafico aviso1 = new AvisosTrafico();

aviso1.mostrarAviso();

AvisosTrafico aviso2 = new AvisosTrafico("Municipalidad de Rosario", "Multa por exceso de velocidad $50.000", "10/10/2024");

Console.WriteLine(aviso2.getFecha());
aviso2.mostrarAviso();
