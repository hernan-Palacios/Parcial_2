using System.Runtime.ConstrainedExecution;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
    /*Juego:
        Desarrollar el juego “Adivina el número” en un programa de C#. El juego es muy sencillo, consiste en 
    adivinar un número ℕ aleatorio que el sistema escoge de un determinado rango y lo guarda en
    memoria sin ser revelado. 
    Por ejemplo: El sistema escoge aleatoriamente un número entre 0 y 100, ese número NO SE PUEDE
    REVELAR ya que es el número que se adivinará, por ende, dicho número se almacenará en memoria. 
    Los participantes comenzarán en orden a jugar y se turnarán para ingresar por pantalla un número
    ℕ hasta acertar el número oculto y salir ganador.
    El juego debe tener la funcionalidad de escoger el número de participantes que jugarán: mínimo 2 y
    máximo 4 integrantes.Dependiendo de la cantidad de jugadores, el número ℕ aleatorio se generará
    en los siguientes rangos: - - -
    Si participan 2 jugadores, el número ℕ aleatorio se generará entre 0 y 50
    Si participan 3 jugadores, el número ℕ aleatorio se generará entre 0 y 100
    Si participan 4 jugadores, el número ℕ aleatorio se generará entre 0 y 200
    Cada jugador comenzará su turno intentando adivinar ese número ℕ aleatorio.El programa deberá
    mostrarle al jugador la siguiente información: - - -
    Si el número ingresado es mayor al número aleatorio, entonces mostrar por pantalla la
    palabra “MENOR” y darle la oportunidad al siguiente jugador.
    Si el número ingresado es menor al número aleatorio, entonces mostrar por pantalla la
    palabra “MAYOR” y darle la oportunidad al siguiente jugador.
    Si el número ingresado coincide con el número aleatorio, entonces mostrar por pantalla la
    palabra “¡HAS GANADO!”. Aquí ya finaliza el juego.
    El programa deberá estar en capacidad de pedir a los jugadores si desean un nuevo “tirito” para
    volver a jugar y borrar consola, de lo contrario, finalizar el programa.*/

        //Declaracion de variables
        Random numero = new Random ();

        int aleatorio1 = numero.Next(0, 50);
        int aleatorio2 = numero.Next(0, 100);
        int aleatorio3 = numero.Next(0, 200);
        int numero1 = 51;
        int numero2 = 101;
        int numero3 = 201;
        int intentos = 0;
        int jugadores;
        bool volver = true;
        string juego1;
        string juego2;
        string juego3;

        Console.WriteLine("Jugemos Adivina el número");
        Console.WriteLine("escoge: 2 Jugadores - 3 jugadores - 4 jugadores");
        jugadores = int.Parse(Console.ReadLine());
        Console.WriteLine($"haz seleccionado {jugadores} Jugadores");

        while (volver)
        {
            string siguiente;

        if ( jugadores == 2 )
        {
            Console.WriteLine("Empecemos a jugar e ingresa numeros de 0 a 50");
            while (aleatorio1 != numero1)
            {
                intentos++;
                numero1 = int.Parse(Console.ReadLine());
                if (numero1 > aleatorio1) Console.WriteLine("Es MENOR");
                if (numero1 < aleatorio1) Console.WriteLine("Es MAYOR");
                if (numero1 == aleatorio1) Console.WriteLine("¡HAS GANADO!");


                Console.WriteLine("¿Quieres un tirito mas?");
                /*Console.WriteLine("ingresa si");
                respuesta = (Console.ReadLine());
                if (respuesta == aleatorio2*/

                
            }

            
                //Console.Clear();
                //Console.WriteLine($"selecciona los jugadores {jugadores} Jugadores");
        }
        if (jugadores == 3)
        {
            Console.WriteLine("Empecemos a jugar e ingresa numeros de 0 a 100");
            while (aleatorio2 != numero2)
            {
                intentos++;
                numero2 = int.Parse(Console.ReadLine());
                if (numero2 > aleatorio2) Console.WriteLine("Es MENOR");
                if (numero2 < aleatorio2) Console.WriteLine("Es MAYOR");
                if (numero2 == aleatorio2) Console.WriteLine("¡HAS GANADO!");
                               
            }
            
            Console.WriteLine("Quieres un tirito mas");
            Console.Clear();
            Console.WriteLine($"selecciona los jugadores {jugadores} Jugadores");
        }
        if (jugadores == 4)
        {
            Console.WriteLine("Empecemos a jugar e ingresa numeros de 0 a 200");
            while (aleatorio3 != numero3)
            {
                intentos++;
                numero3 = int.Parse(Console.ReadLine());
                if (numero3 > aleatorio3) Console.WriteLine("Es MENOR");
                if (numero3 < aleatorio3) Console.WriteLine("Es MAYOR");
                if (numero3 == aleatorio3) Console.WriteLine("¡HAS GANADO!");

            }
            
            Console.WriteLine("Quieres un tirito mas");
            Console.Clear();
            Console.WriteLine($"selecciona los jugadores {jugadores} Jugadores");
        }


         siguiente = Console.ReadLine();
            if (siguiente == "n") volver = false;
        }
    }





}
