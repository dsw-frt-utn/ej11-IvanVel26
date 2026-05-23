using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> alumnos =
            new Dictionary<int, Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
        if (!alumnos.ContainsKey(alumno.Id))
        {
            alumnos.Add(alumno.Id, alumno);
        }
        else
        {
            Console.WriteLine("El alumno ya existe en el diccionario.");
        }
    }

    public Alumno? BuscarAlumno(int legajo)
    {
        if (alumnos.ContainsKey(legajo))
        {
            return alumnos[legajo];
        }
        else
        {
            Console.WriteLine("No existe");
            return null;
        }
    }

    public Dictionary<int, Alumno> getDiccionario()
    {
        return alumnos;
    }

    public bool EliminarAlumno(int legajo)
    {

        return alumnos.Remove(legajo);

    }
}
