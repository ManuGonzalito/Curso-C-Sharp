// //Creación del objeto delegando apuntando a MensajeBienvenida
// ObjetoDeleagado elDelegado = new ObjetoDeleagado(MensajeBienvenida.SaludoBienvenida);

// //Llamada al método delegado
// elDelegado("Hola mundo");

// elDelegado = new ObjetoDeleagado(MensajeDespedida.SaludoDespedida);
// elDelegado("Adios mundo");


// //Deficion del objeto delegado
// delegate void ObjetoDeleagado(string msj);
// class MensajeBienvenida
// {
//     public static void SaludoBienvenida(string msj){
//         Console.WriteLine("Mensaje de bienvenida: {0}", msj);
//     }
// }

// class MensajeDespedida
// {
//     public static void SaludoDespedida(string msj){
//         Console.WriteLine("Mensaje de despedida: {0}", msj);
//     }
// }

/* ------------------DELEGADO PREDICADO (Predicate)--------------------------- */
// List<int> ListaNumeros = new List<int>();
// ListaNumeros.AddRange(new int[] {1,2,3,4,5,6,7,8,9,10});

// //Declaramos el delegado predicado
// Predicate<int> ElDelegadoPred = new Predicate<int>(DamePares);
// List<int> NumPares = ListaNumeros.FindAll(ElDelegadoPred);

// Console.WriteLine("Numeros pares: \n");
// foreach(int num in NumPares){
//     Console.WriteLine(num);
// }

// ElDelegadoPred = new Predicate<int>(DamePrimos);
// List<int> NumPrimos = ListaNumeros.FindAll(ElDelegadoPred);

// Console.WriteLine("\nNumeros primos: \n");
// foreach(int num in NumPrimos){
//     Console.WriteLine(num);
// }

// static bool DamePares(int num){
//     if(num % 2 == 0) return true;
//     else return false;
// }

// static bool DamePrimos(int num)
// {
//     if (num < 2) return false;
//     if (num == 2) return true;
//     if (num % 2 == 0) return false;

//     for (int i = 3; i <= Math.Sqrt(num); i += 2)
//     {
//         if (num % i == 0) return false;
//     }
//     return true;
// }

/* ------------------Predicate con Objetos--------------------------- */
// List<Personas> gente = new List<Personas>();
// Personas p1 = new Personas();
// p1.Nombre = "Juan";
// p1.Edad = 18;

// Personas p2 = new Personas();
// p2.Nombre = "Maria";
// p2.Edad = 28;

// Personas p3 = new Personas();
// p3.Nombre = "Ana";
// p3.Edad = 37;

// gente.AddRange(new Personas[] { p1, p2, p3 });

// Predicate<Personas> ElPredicado = new Predicate<Personas>(ExisteJuan);

// bool existe = gente.Exists(ElPredicado);

// if (existe) Console.WriteLine("Juan existe en la lista");
// else Console.WriteLine("Juan no existe en la lista");

// ElPredicado = new Predicate<Personas>(ExistenMayoresEdad);
// bool mayoresEdad = gente.Exists(ElPredicado);

// if (mayoresEdad) Console.WriteLine("Existen mayores de edad en la lista");
// else Console.WriteLine("No existen mayores de edad en la lista");

// static bool ExistenMayoresEdad(Personas persona)
// {
//     if (persona.Edad >= 18) return true;
//     else return false;
// }

// static bool ExisteJuan(Personas persona)
// {
//     if (persona.Nombre == "Juan") return true;
//     else return false;
// }
// class Personas
// {
//     private string? nombre;
//     private int edad;

//     public string? Nombre { get => nombre; set => nombre = value; }
//     public int Edad { get => edad; set => edad = value; }
// }

/*------------------LAMBDA EXPRESSIONS---------------------------*/
// OperacionesMatematicas operacion = new OperacionesMatematicas((num1, num2) => num1 + num2);

// Console.WriteLine(operacion(4, 7));

// funcion sin simplificar
// static int Cuadrado(int num)
// {
//     return num * num;
// }
// static int Suma(int num1, int num2){
//     return num1 + num2;
// }
// public delegate int OperacionesMatematicas(int numero1, int numero2);

Personas p1 = new Personas();
p1.Nombre = "Juan";
p1.Edad = 18;

Personas p2 = new Personas();
p2.Nombre = "Maria";
p2.Edad = 28;

ComparaPersonas comparaEdad = (persona1, persona2) => persona1 == persona2;

Console.WriteLine(comparaEdad(p1.Edad, p2.Edad));

// List<int> numeros = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
// List<int> numerosPares = numeros.FindAll(num => num % 2 == 0);  //Lambda expression

// // foreach(int num in numerosPares) Console.WriteLine(num);
// numerosPares.ForEach(num => {
//     Console.WriteLine("Numero par es: "); 
//     Console.WriteLine(num);
// });

public delegate bool ComparaPersonas(int edad1, int edad2);
class Personas
{
    private string? nombre;
    private int edad;

    public string? Nombre { get => nombre; set => nombre = value; }
    public int Edad { get => edad; set => edad = value; }
}