using System;

namespace AvisosVarios;

public class AvisosTrafico : IAvisos
{
    public AvisosTrafico()
    {
        remitente = "Dirección General de Tráfico";
        mensaje = "Sanción por exceso de velocidad. Pague antes de 3 días y se beneficiará de una reducción del 50%"; 
        fecha = "";
    }

    public AvisosTrafico(string remitente, string mensaje, string fecha)
    {
        this.remitente = remitente;
        this.mensaje = mensaje;
        this.fecha = fecha;
    }

    public void mostrarAviso()
    {
        Console.WriteLine("Mensaje: {0} ha sido enviado por {1} el día {2}", mensaje, remitente, fecha);
    }

    public string getFecha()
    {
        return fecha;
    }

    private string remitente;
    private string mensaje;
    private string fecha;
}
