// See https://aka.ms/new-console-template for more information
Coche Mercedes = new Coche();
Avion Airbus = new Avion();

Mercedes.arrancar();
Mercedes.conducir();
Mercedes.acelerar();
Mercedes.abrirVentanas();
Mercedes.encenderRadio();
Mercedes.frenar();
Mercedes.parar();

Console.WriteLine();

Airbus.arrancar();
Airbus.conducir();
Airbus.acelerar();
Airbus.despegar();
Airbus.aterrizar();
Airbus.frenar();
Airbus.parar();

class Vehiculo{
    public void arrancar(){
        Console.WriteLine("Arrancando Motor");
    }

    public void parar(){
        Console.WriteLine("Parando Motor");
    }
    public void acelerar(){
        Console.WriteLine("Acelerando");
    }
    public void frenar(){
        Console.WriteLine("Frenando");
    }

    public virtual void conducir(){
        Console.WriteLine("Conduciendo Vehiculo");
    }
}

class Coche : Vehiculo{
    public override void conducir(){
        Console.WriteLine("Conduciendo Coche");
    }
    public void abrirVentanas(){
        Console.WriteLine("Abriendo Ventanas");
    }
    public void encenderRadio(){
        Console.WriteLine("Encendiendo Radio");
    }
}

class Avion : Vehiculo{
    public override void conducir(){
        Console.WriteLine("Conduciendo Avion");
    }
    public void despegar(){
        Console.WriteLine("Despegando");
    }
    public void aterrizar(){
        Console.WriteLine("Aterrizando");
    }
}