using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System.Collections;
using System.Timers;

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
        CasoList lista = new CasoList();
        Alumno alumno1 = new Alumno(01, "Juan", 8.5);
        Alumno alumno2 = new Alumno(02, "Maria", 9.0);
        Alumno alumno3 = new Alumno(03, "Pedro", 7.5);

        lista.AgregarAlumno(alumno1);
        lista.AgregarAlumno(alumno2);
        lista.AgregarAlumno(alumno3);

        foreach (var a in lista.GetAlumnos())
        {
            Console.WriteLine(a.ToString());
        }

        Console.WriteLine("\nBuscar por nombre un alumno que exista y mostrar por consola");
        Console.WriteLine(lista.BuscarAlumno("Juan"));

        Console.WriteLine("\nBuscar por nombre un alumno que no exista y mostrar por consola el texto \"No existe\"");
        Console.WriteLine(lista.BuscarAlumno("pepito"));

        Console.WriteLine("\nEliminar un alumno y listar por consola los alumnos");
        lista.EliminarAlumno(alumno2);
        foreach (var a in lista.GetAlumnos())
        {
            Console.WriteLine(a.ToString());
        }

        Console.WriteLine("\nEliminar el primer elemento de la lista y listar por consola los alumnos");
        lista.EliminarAlumnoPosicion(0);
        foreach (var a in lista.GetAlumnos())
        {
            Console.WriteLine(a.ToString());
        }

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

        ListarDiccionario(diccionario.GetDiccionario());

        Console.WriteLine("\nBuscar un alumno por clave y mostrar por consola");
        Console.WriteLine(diccionario.BuscarAlumno(03));

        Console.WriteLine("\nBuscar un alumno por clave, pero que no exista, y mostrar por consola el texto \"No existe\"");
        Console.WriteLine(diccionario.BuscarAlumno(05));

        Console.WriteLine("\nEliminar un alumno por clave y listar por consola los alumnos");

        diccionario.EliminarAlumno(02);

        ListarDiccionario(diccionario.GetDiccionario());
    }

    public static void ListarDiccionario(Dictionary<int, Alumno> diccionario)
    {
        foreach (var alumno in diccionario)
        {
            Console.WriteLine(alumno.ToString());
        }
    }
    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    /*
 
 * 10. 
 * En todos los casos debe aplicarse LINQ
 */
    public static void EjemploLinq()
    {
        List<Libro> libros = Libro.CrearLista();
        CasoLinq linq = new CasoLinq();

        Console.WriteLine("Obtener el primer libro (GetPrimero)");
        Console.WriteLine(linq.GetPrimero(libros)?.ToString());

        Console.WriteLine("\nObtener el último libro (GetUltimo)");
        Console.WriteLine(linq.GetUltimo(libros)?.ToString());

        Console.WriteLine("\nObtener la suma de los precios (GetTotalPrecios)");
        Console.WriteLine(linq.GetTotalPrecios(libros).ToString());

        Console.WriteLine("\nObtener el promedio de precios (GetPromedioPrecios)");
        Console.WriteLine(linq.GetPromedioPrecios(libros).ToString("F2"));

        Console.WriteLine("\nObtener la lista de libros con Id mayor a 15 (GetListById)");
        linq.GetListById(libros).ForEach(libro => Console.WriteLine(libro.ToString()));

        Console.WriteLine("\nObtener una lista de cada libro con su título y precio en formato moneda(GetLibros)");
        linq.GetLibros(libros).ForEach(libro => Console.WriteLine(libro.ToString()));

        Console.WriteLine("\nObtener el libro con el precio más alto (GetMayorPrecio))");
        Console.WriteLine(linq.GetMayorPrecio(libros)?.ToString());

        Console.WriteLine("\nObtener el libro con el precio más bajo (GetMenorPrecio)");
        Console.WriteLine(linq.GetMenorPrecio(libros)?.ToString());

        Console.WriteLine("\nObtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)");
        linq.GetMayorPromedio(libros).ForEach(libro => Console.WriteLine(libro.ToString()));

        Console.WriteLine("\nObtener los libros ordenados por título de forma descendente");
        linq.GetOrdenadosPorTituloDescendente(libros).ForEach(libro => Console.WriteLine(libro.ToString()));

    }
}
