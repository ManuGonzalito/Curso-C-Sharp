// Empleado Carlos = new Empleado(1400, 500);
// Carlos.cambiaSalario(Carlos, 100);
// Console.WriteLine(Carlos);

// public struct Empleado
// {
//     public double salarioBase, comision;
//     public Empleado(int salarioBase, int comision)
//     {
//         this.salarioBase = salarioBase;
//         this.comision = comision;
//     }
//     public override string ToString()
//     {
//         return string.Format("Salario Base: {0}, Comision: {1}", salarioBase, comision);
//     }
//     public void cambiaSalario(Empleado emp, double incremento){
//         emp.salarioBase += incremento;
//         emp.comision += incremento;
//     }
// }

//ENUMERADOS (ENUM)

// Estaciones alergia = Estaciones.Primavera;
// string laAlergia = alergia.ToString();
// Console.WriteLine(laAlergia);

// enum Estaciones { Primavera, Verano, Otoño, Invierno };

// Bonus Antonio = Bonus.bajo;
// double bonusAntonio = (double)Antonio;
// double salarioAntonio = 1500 + bonusAntonio;
// Console.WriteLine(salarioAntonio);

Empleado Luis = new Empleado(Bonus.extra, 1900.50);
Console.WriteLine($"El salario del empleado es: {Luis.getSalario()}");

class Empleado
{
    private double salario;
    private Bonus bonusEmpleado;
    public Empleado(Bonus bonusEmpleado, double salario)
    {
        this.bonusEmpleado = bonusEmpleado;
        this.salario = salario;
    }
    public double getSalario()
    {
        return salario + (double)bonusEmpleado;
    }
}
enum Bonus {bajo = 500, normal = 1000, bueno = 1500, extra = 3000};