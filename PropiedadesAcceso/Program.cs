Empleado Lucas = new Empleado("Lucas");

// Lucas.setSalario(1900);
// Lucas.setSalario(Lucas.getSalario() + 600); 
// Console.WriteLine($"El salario del empleado es R${Lucas.getSalario()}"); 

Lucas.SALARIO = 1900;
Lucas.SALARIO += 600;
Console.WriteLine($"El salario del empleado es R${Lucas.SALARIO}");


class Empleado
{
    // Las convenciones de C# indican que los atributos privados deben comenzar con guion bajo
    private string _nombre;
    private double _salario;

    public Empleado(string nombre){
        this._nombre = nombre;
    }
    /*public void setSalario(double salario){
        if (salario < 0){
            Console.WriteLine("El salario no puede ser negativo. Se asignará 0 como salario.");
            this.salario = 0;
        }else{
            this.salario = salario;
        }
    }
    public double getSalario(){
        return salario;
    }*/
    public string getNombre(){
        return _nombre;
    }
    private double evaluarSalario(double salario){
        if (salario < 0) return 0;
        else return salario;
    }

    //Creacion de Propiedad (Property)
    // public double SALARIO{
    //     get{ return salario; }
    //     set{ salario = evaluarSalario(value); }
    // }

    //Sintaxis simplificada (lambda)
    public double SALARIO{
        get => this._salario;
        set => this._salario = evaluarSalario(value);
    }
}