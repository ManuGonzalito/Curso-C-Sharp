
AlmacenObjetos<string> archivos = new AlmacenObjetos<string>(4);
archivos.Agregar("Juan");
archivos.Agregar("Elena");
archivos.Agregar("Antonio");
archivos.Agregar("Sandra");

string nombrePersona = (string)archivos.getElemento(2);
Console.WriteLine(nombrePersona);

// archivos.Agregar(new Empleado(1500));
// archivos.Agregar(new Empleado(2500));
// archivos.Agregar(new Empleado(3500));
// archivos.Agregar(new Empleado(4500));

// Empleado salarioEmpleado = (Empleado) archivos.getElemento(2);
// Console.WriteLine(salarioEmpleado.getSalario());



class AlmacenObjetos<T>
{
    private T[] datosElemento;
    private int i = 0;
    public AlmacenObjetos(int z)
    {
        datosElemento = new T[z];
    }
    public void Agregar(T obj)
    {
        datosElemento[i] = obj;
        i++;
    }
    public T getElemento(int i)
    {
        return datosElemento[i];
    }
}

class Empleado
{
    private double salario;
    public Empleado(double salario)
    {
        this.salario = salario;
    }
    public double getSalario()
    {
        return salario;
    }
}