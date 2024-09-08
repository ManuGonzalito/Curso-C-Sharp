// See https://aka.ms/new-console-template for more information
// Caballo Babieca = new Caballo("Babieca");
// ISaltoConPatas ImiBabieca = Babieca;
Humano Juan = new Humano("Juan");
// Gorila Copito = new Gorila("Copito");
// Ballena Willy = new Ballena("Willy");

// Mamiferos[] almacenAnimales = new Mamiferos[3];

// almacenAnimales[0] = Babieca;
// almacenAnimales[1] = Juan;
// almacenAnimales[2] = Copito;

// for (int i = 0; i < 3; i++){
//     almacenAnimales[i].Pensar();
// }

// Willy.Nadar();
// Console.WriteLine("Patas utilizadas en el salto de Babieca " + ImiBabieca.NumeroPatas());

Lagartija Juancho = new Lagartija("Juancho");

Juancho.GetNombre();
Juan.GetNombre();

interface IMamiferosTerrestres{
    int NumeroPatas();
}

interface IAnimalesYDeportes{
    string TipoDeporte();
    Boolean esOlimpico();
}

interface ISaltoConPatas{
    int NumeroPatas();
}

abstract class Animales
{
    public void Respirar(){
        Console.WriteLine("Soy capaz de respirar");
    }

    public abstract void GetNombre();
}

class Lagartija : Animales
{
    String nombreReptil;
    public Lagartija(string nombre)
    {
        nombreReptil = nombre;
    }
    public override void GetNombre(){
        Console.WriteLine("El nombre del reptil es: " + nombreReptil);
    }
}

class Mamiferos : Animales{
    public Mamiferos(string nombre){
        nombreSerVivo = nombre;
    }
    public void CuidarCrias(){
        Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
    } 
    public override void GetNombre(){
        Console.WriteLine("El nombre del mamífero es: " + nombreSerVivo);
    }   
    public virtual void Pensar(){
        Console.WriteLine("Pensamiento básico instintivo");
    }
    private string nombreSerVivo;
}

class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas {
    public Caballo(string nombreCaballo) : base(nombreCaballo){
    }
    public void Galopar(){
        Console.WriteLine("Soy capaz de Galopar");
    }
    int IMamiferosTerrestres.NumeroPatas(){
        return 4;
    }
    int ISaltoConPatas.NumeroPatas(){
        return 2;
    }
    public string TipoDeporte(){
        return "Hípica";
    }
    public Boolean esOlimpico(){
        return true;
    }
}

class Humano : Mamiferos {
    public Humano(string nombreHumano) : base(nombreHumano){
    }
    public override void Pensar(){
        Console.WriteLine("Soy capaz de Pensar ¿?");
    }
}

class Gorila : Mamiferos, IMamiferosTerrestres {
    public Gorila(string nombreGorila) : base(nombreGorila){
    }
    public override void Pensar(){
        Console.WriteLine("Pensamiento instintivo avanzado");
    }
    public void Trepar(){
        Console.WriteLine("Soy capaz de Trepar");
    }

    public int NumeroPatas(){
        return 2;
    }
}

class Ballena : Mamiferos{
    public Ballena(string nombreBallena) : base(nombreBallena){
    }
    public void Nadar(){
        Console.WriteLine("Soy capaz de Nadar");
    }
}