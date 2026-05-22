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
    //1
    public static void GetPrimero(List<Libro> libros) 
    {
        var primero = libros.FirstOrDefault();
        Console.WriteLine("primer libro:");
        if (primero != null)
        {
            Console.WriteLine($"ID: {primero.Id} - Título: {primero.Titulo} - Precio: $ {primero.Precio:N2}");
        }
    } 
    //2
    public static void GetUltimo(List<Libro> libros)
    {
        var ultimo = libros.LastOrDefault();
        Console.WriteLine("ultimo libro:");
        if (ultimo != null)
        {
            Console.WriteLine($"ID: {ultimo.Id} - Título: {ultimo.Titulo} - Precio: $ {ultimo.Precio:N2}");
        }
    }
    //3
    public static void GetTotalPrecios(List<Libro> libros)
    {
        decimal suma = libros.Sum(l => l.Precio);
        Console.WriteLine($"la suma de los precios es: {suma:N2}");
    }
    //4
    public static void GetPromedioPrecios(List<Libro> libros, out decimal prom)
    {
        prom = libros.Average(l => l.Precio);
        Console.WriteLine($"el promedio de los precios es: {prom:N2}");
    }
    //5
    public static void GetListById(List<Libro> libros)
    {
        var libroFiltrar = libros.Where(l => l.Id > 15);
        Console.WriteLine("libros con id mayor a 15: ");
        foreach (var l in libroFiltrar)
        {
            Console.WriteLine($"ID: {l.Id} - Título: {l.Titulo} - Precio: {l.Precio:N2}");
        }
    }
    //6
    public static List<string> GetLibros(List<Libro> libros)
    {
        var cultura = CultureInfo.GetCultureInfo("es-AR");
        var libroFormateado = libros.Select(l => $"ID: {l.Id}, Titulo: {l.Titulo}, Precio {l.Precio.ToString("C2", cultura)}")
            .ToList();
        Console.WriteLine("libros formateados");
        foreach(var item in libroFormateado)
        {
            Console.WriteLine(item);
        }
        return libroFormateado;
    }
    //7
    public static void GetMayorPrecio (List<Libro> libros)
    {
        var precioMax = libros.Max(l => l.Precio);
        var libroMax = libros.FirstOrDefault(l => l.Precio ==  precioMax);
        Console.WriteLine($"El precio mas alto es:");
        if (libroMax != null)
        {
            Console.WriteLine($"ID: {libroMax.Id} - Título: {libroMax.Titulo} - Precio: $ {libroMax.Precio:N2}");
        }
    }
    //8
    public static void GetMenorPrecio (List<Libro> libros)
    {
        var precioMin = libros.Min(l => l.Precio);
        var libroMin = libros.FirstOrDefault(l => l.Precio == precioMin);
        Console.WriteLine($"El precio mas bajo es:");
        if (libroMin != null)
        {
            Console.WriteLine($"ID: {libroMin.Id} - Título: {libroMin.Titulo} - Precio: $ {libroMin.Precio:N2}");
        }
    }
    //9 
    public static void GetMayorPromedio(List<Libro> libros)
    {
        var mayorProm = libros.Where(l => l.Precio > libros.Average(l => l.Precio));
        Console.WriteLine("Los libros con precio payor al promedio:");
        foreach (var l in mayorProm)
        {
            Console.WriteLine($"ID: {l.Id} - Título: {l.Titulo} - Precio: $ {l.Precio:N2}");
        }
    }
    //10
    public static void GetDescendente(List<Libro> libros)
    {
        var libroOrdenado = libros.OrderByDescending(l => l.Titulo).ToList();
        Console.WriteLine("Ordenados de manera descendente por nombre:");
        foreach (var l in libroOrdenado)
        {
            Console.WriteLine($"ID: {l.Id} - Título: {l.Titulo} - Precio: $ {l.Precio:N2}");
        }
    }

}
