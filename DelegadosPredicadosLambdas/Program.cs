//Creación del objeto delegando apuntando a MensajeBienvenida
ObjetoDeleagado elDelegado = new ObjetoDeleagado(MensajeBienvenida.SaludoBienvenida);

//Llamada al método delegado
elDelegado("Hola mundo");

elDelegado = new ObjetoDeleagado(MensajeDespedida.SaludoDespedida);
elDelegado("Adios mundo");


//Deficion del objeto delegado
delegate void ObjetoDeleagado(string msj);
class MensajeBienvenida
{
    public static void SaludoBienvenida(string msj){
        Console.WriteLine("Mensaje de bienvenida: {0}", msj);
    }
}

class MensajeDespedida
{
    public static void SaludoDespedida(string msj){
        Console.WriteLine("Mensaje de despedida: {0}", msj);
    }
}