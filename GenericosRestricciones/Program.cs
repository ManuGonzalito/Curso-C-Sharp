AlmacenEmpleados<Director> empleados = new AlmacenEmpleados<Director>(3);
empleados.Agregar(new Director(4500));
empleados.Agregar(new Director(1500));
empleados.Agregar(new Director(2500));

class AlmacenEmpleados<T> where T: IParaEmpleados
{
    private int i = 0;
    private T[] datosEmpleados;
    public AlmacenEmpleados(int z)
    {
        datosEmpleados = new T[z];
    }
    public void Agregar(T obj)
    {
        datosEmpleados[i] = obj;
        i++;
    }
    public T getEmpleado(int i)
    {
        return datosEmpleados[i];
    }
}    

class Director : IParaEmpleados
{
    private double salario;
    public Director(double salario)
    {
        this.salario = salario;
    }
    public double getSalario()
    {
        return salario;
    }
}
class Secretaria : IParaEmpleados
{
    private double salario;
    public Secretaria(double salario)
    {
        this.salario = salario;
    }
    public double getSalario()
    {
        return salario;
    }
}
class Electricista : IParaEmpleados
{
    private double salario;
    public Electricista(double salario)
    {
        this.salario = salario;
    }
    public double getSalario()
    {
        return salario;
    }
}
class Estudiante
{
    private double edad;
    public Estudiante(double edad)
    {
        this.edad = edad;
    }
    public double getEdad()
    {
        return edad;
    }
}
interface IParaEmpleados
{
    double getSalario();
}
