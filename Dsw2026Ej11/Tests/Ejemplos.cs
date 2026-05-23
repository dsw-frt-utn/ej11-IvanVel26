using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary diccionario = new CasoDictionary();
        Alumno alumno1 = new Alumno(01, "Juan", 8.5);
        Alumno alumno2 = new Alumno(02, "Maria", 9.0);
        Alumno alumno3 = new Alumno(03, "Pedro", 7.5);

        diccionario.AgregarAlumno(alumno1);
        diccionario.AgregarAlumno(alumno2);
        diccionario.AgregarAlumno(alumno3);

        ListarDiccionario(diccionario.getDiccionario());

        Console.WriteLine("\nBuscar un alumno por clave y mostrar por consola");
        Console.WriteLine(diccionario.BuscarAlumno(03));

        Console.WriteLine("\nBuscar un alumno por clave, pero que no exista, y mostrar por consola el texto \"No existe\"");
        Console.WriteLine(diccionario.BuscarAlumno(05));

        Console.WriteLine("\nEliminar un alumno por clave y listar por consola los alumnos");

        diccionario.EliminarAlumno(02);

        ListarDiccionario(diccionario.getDiccionario());
    }

    public static void ListarDiccionario(Dictionary<int, Alumno> diccionario)
    {
        foreach (var alumno in diccionario)
        {
            Console.WriteLine(alumno.ToString());
        }
    }
    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
