// See https://aka.ms/new-console-template for more information
Caballo Babieca = new Caballo("Babieca");
Humano Juan = new Humano("Juan");
Gorila Copito = new Gorila("Copito");

Mamiferos[] almacenAnimales = new Mamiferos[3];

almacenAnimales[0] = Babieca;
almacenAnimales[1] = Juan;
almacenAnimales[2] = Copito;

for (int i = 0; i < 3; i++){
    almacenAnimales[i].pensar();
}


class Mamiferos{
    public Mamiferos(String nombre){
        nombreSerVivo = nombre;
    }
    public void respirar(){
        Console.WriteLine("Respirar");
    }

    public void cuidarCrias(){
        Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
    } 
    public void getNombre(){
        Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
    }   
    public virtual void pensar(){
        Console.WriteLine("Pensamiento básico instintivo");
    }
    private string nombreSerVivo;
}

class Caballo : Mamiferos {
    public Caballo(string nombreCaballo) : base(nombreCaballo){
    }
    public void galopar(){
        Console.WriteLine("Soy capaz de Galopar");
    }
}

class Humano : Mamiferos {
    public Humano(string nombreHumano) : base(nombreHumano){
    }
    public override void pensar(){
        Console.WriteLine("Soy capaz de Pensar ¿?");
    }
}

class Gorila : Mamiferos {
    public Gorila(string nombreGorila) : base(nombreGorila){
    }
    public override void pensar(){
        Console.WriteLine("Pensamiento instintivo avanzado");
    }
    public void trepar(){
        Console.WriteLine("Soy capaz de Trepar");
    }
}