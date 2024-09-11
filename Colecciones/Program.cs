
List<int> numerosList = new List<int>(); //Declarar una coleccion del tipo List

// numeros.Add(5); //Agregar un elemento a la coleccion
// numeros.Add(7);
// numeros.Add(9);

// int[] listaNumeros = new int[] {3, 6, 8, 10, 50};

// for(int i = 0; i < 5; i++) 
// {
//     Console.WriteLine(numeros[i]);
// }

// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine(listaNumeros[i]);
// }

/* --------------------------------------------- */

// Console.WriteLine("Cuántos elementos quieres agregar?");

// int elem = Int32.Parse(Console.ReadLine());

// Console.WriteLine("Ingresa los elementos: ");

// for (int i = 0; i < elem; i++)
// {
//     numeros.Add(Int32.Parse(Console.ReadLine()));
// }

// Console.WriteLine("\nLos elementos de la lista son: ");

// for(int i = 0; i < elem; i++) 
// {
//     Console.WriteLine(numeros[i]);
// }

/* --------------------------------------------- */

Console.WriteLine("Introduce elementos en la colleccion (0 para terminar): ");

int elem = Int32.Parse(Console.ReadLine());

while (elem != 0)
{
    numerosList.Add(elem);
    elem = Int32.Parse(Console.ReadLine());
}

Console.WriteLine("\nLos elementos de la lista son: ");

foreach (int num in numerosList)
{
    Console.WriteLine(num);
}

/* -------------------- LINKEDLIST ------------------------- */

LinkedList<int> numerosLinked = new LinkedList<int>();

foreach (int num in new int[] {10, 8, 6, 4, 2, 0}){
    numerosLinked.AddLast(num);
}

numerosLinked.Remove(6);

LinkedListNode<int> nodoImportante = new LinkedListNode<int>(15);

numerosLinked.AddFirst(nodoImportante);

// foreach normal
foreach (int numero in numerosLinked){
    Console.WriteLine(numero);
}

// for con LinkedListNode
for(LinkedListNode<int> nodo = numerosLinked.First; nodo != null; nodo = nodo.Next){
    int numero = nodo.Value;
    Console.WriteLine(numero);
}

/* -------------------- QUEUE ------------------------- */

Queue<int> numerosQueue = new Queue<int>();

// Rellenando o agregando elementos a la cola
foreach (int num in new int[5] { 2, 4, 6, 8, 10 })
{
    numerosQueue.Enqueue(num);
}

// recorriendo la cola
Console.WriteLine("Recorriendo el Queue: ");
foreach (int num in numerosQueue)
{
    Console.WriteLine(num);
}

// Eliminando elementos de la cola
Console.WriteLine("Eliminando elemento...");
numerosQueue.Dequeue();
foreach (int num in numerosQueue)
{
    Console.WriteLine(num);
}


/* -------------------- STACK ------------------------- */

Stack<int> numerosStack = new Stack<int>();

foreach (int num in new int[5] { 2, 4, 6, 8, 10 })
{
    numerosStack.Push(num);
}

Console.WriteLine("Recorriendo el Stack: ");

foreach (int num in numerosStack)
{
    Console.WriteLine(num);
}

Console.WriteLine("Eliminando elemento...");

numerosStack.Pop();
foreach (int num in numerosStack)
{
    Console.WriteLine(num);
}

/* -------------------- DICTIONARY ------------------------- */

Dictionary<string, int> edades = new Dictionary<string, int>();

//Rellena el diccionario
edades.Add("Juan", 18);
edades.Add("Diana", 35);

edades["Maria"] = 25;
edades["Antonio"] = 29;

//Recorre el diccionario
foreach (KeyValuePair<string, int> persona in edades)
{
    Console.WriteLine($"Nombre: {persona.Key}, Edad: {persona.Value}");
}