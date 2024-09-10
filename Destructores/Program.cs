using System.IO;
ManejoArchivos miArchivo = new ManejoArchivos();
miArchivo.mensaje();

class ManejoArchivos
{
    StreamReader archivo;
    int contador = 0;
    string? linea;
    
    public ManejoArchivos()
    {
        archivo = new StreamReader("./text.txt");
        
        while ((linea = archivo.ReadLine()) != null){
            Console.WriteLine(linea);
            contador ++;
        }
    }
    public void mensaje(){
        Console.WriteLine("El archivo tiene " + contador + " lineas");
    }
    ~ManejoArchivos(){
        archivo.Close();
    }
}