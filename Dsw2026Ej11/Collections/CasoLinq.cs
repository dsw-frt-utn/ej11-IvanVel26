using Dsw2026Ej11.Domain;
using System.Globalization;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    public Libro? GetPrimero(List<Libro> lista)
    {
        return lista.FirstOrDefault();
    }

    public Libro? GetUltimo(List<Libro> lista)
    {
        return lista.LastOrDefault();
    }

    public decimal GetTotalPrecios(List<Libro> lista)
    {
        return lista.Sum(l => l.Precio);
    }

    public decimal GetPromedioPrecios(List<Libro> lista)
    {
        return lista.Average(l => l.Precio);
    }

    public List<Libro> GetListById(List<Libro> lista)
    {
        return lista.Where(l => l.Id > 15).ToList();
    }

    public List<string> GetLibros(List<Libro> lista)
    {
        CultureInfo cultura = new CultureInfo("es-AR");
        return lista.Select(l => $"{l.Titulo}: {l.Precio.ToString("C2", cultura)}").ToList();
    }

    public Libro? GetMayorPrecio(List<Libro> lista)
    {
        return lista.OrderByDescending(l => l.Precio).FirstOrDefault();
    }

    public Libro? GetMenorPrecio(List<Libro> lista)
    {
        return lista.OrderBy(l => l.Precio).FirstOrDefault();
    }

    public List<Libro> GetMayorPromedio(List<Libro> lista)
    {
        decimal promedio = GetPromedioPrecios(lista);
        return lista.Where(l => l.Precio > promedio).ToList();
    }

    public List<Libro> GetOrdenadosPorTituloDescendente(List<Libro> lista)
    {
        return lista.OrderByDescending(l => l.Titulo).ToList();
    }
}
