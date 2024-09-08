Empleado Carlos = new Empleado(1400, 500);
Carlos.cambiaSalario(Carlos, 100);
Console.WriteLine(Carlos);

public struct Empleado
{
    public double salarioBase, comision;
    public Empleado(int salarioBase, int comision)
    {
        this.salarioBase = salarioBase;
        this.comision = comision;
    }
    public override string ToString()
    {
        return string.Format("Salario Base: {0}, Comision: {1}", salarioBase, comision);
    }
    public void cambiaSalario(Empleado emp, double incremento){
        emp.salarioBase += incremento;
        emp.comision += incremento;
    }
}