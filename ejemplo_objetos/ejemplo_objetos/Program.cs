using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            carro Carro = new carro();
            moto Moto = new moto();
            camion Camion = new camion();
            tren Tren = new tren();
            avion Avion = new avion();
            triciclo Triciclo = new triciclo();

            //carro
            Carro.color = "azul";
            carro.arrancar();

            //moto
            Carro.color = "amarrilla";
            moto.girar();

            //camion
            Carro.color = "morado";
            camion.arrancar();

            //tren
            Carro.color = "negro";
            tren.avanza();

            //avion
            Carro.color = "balnco";
            avion.volar();

            //trciclo
            Carro.color = "rosa";
            triciclo.pedalear();
        }

    }
}

public class carro
{

    public int numLlantas = 4;
    public string color = "Rojo";
    public static string arrancar()
    {
        return "El carro esta andando";
    }
}
public class moto
{
    public int numLlantas = 2;
    public string color = "azul";
    public static string girar()
    {
        return "La moto esta girando";
    }
}

public class camion
{
    public int numLlantas = 4;
    public string color = "verde";
    public static string arrancar()
    {
        return "El camion esta andando";
    }
}

public class tren
{
    public int numLlantas = 0;
    public string color = "blanco";
    public static string avanza()
    {
        return "El tren esta avanzando";
    }
}

public class avion
{
    public int numLlantas = 10;
    public string color = "morado";
    public static string volar()
    {
        return "El avion esta volando";
    }
}

public class triciclo
{
    public int numLlantas = 3;
    public string color = "amarillo";
    public static string pedalear()
    {
        return "El trciclo se esta moviendo";
    }
}