using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> alumnos = new List<Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno);
    }

    public List<Alumno> GetAlumnos()
    {
        return alumnos;
    }

    public Alumno? BuscarAlumno(string nombre)
    {
        if (alumnos.Find(a => a.Nombre == nombre) != null)
        {
            return alumnos.Find(a => a.Nombre == nombre);
        }

        Console.WriteLine("No Existe");
        return null;
    }

    public void EliminarAlumno(Alumno alumno)
    {
        alumnos.Remove(alumno);
    }

    public void EliminarAlumnoPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < alumnos.Count)
        {
            alumnos.RemoveAt(posicion);
        }
        else
        {
            Console.WriteLine("Posición inválida.");
        }
    }
}
