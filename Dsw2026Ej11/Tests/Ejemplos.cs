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
        List<Alumno> alumnos = new List<Alumno>();
        alumnos.Add(new Alumno(1, "Bautista", 6.5));
        alumnos.Add(new Alumno(2, "Lionel", 9.5));
        alumnos.Add(new Alumno(3, "Andres", 8.2));

        Console.WriteLine("Alumnos: ");
        foreach(var alu in alumnos)
        {
            Console.WriteLine(alu);
        }

        var alumnoEncontrado = alumnos.FirstOrDefault(a => a.Nombre == "Bautista");
        if (alumnoEncontrado != null)
        {
            Console.WriteLine($"Alumno encontrado: {alumnoEncontrado}");
        }

        Console.WriteLine("Buscando alumno 'Julian'");
        var alumnoInexistente = alumnos.FirstOrDefault(a => a.Nombre == "Julian");
        if (alumnoInexistente != null)
        {
            Console.WriteLine(alumnoInexistente);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        var alumnoEliminar = alumnos.FirstOrDefault(a => a.Nombre == "Andres");
        if (alumnoEliminar != null)
        {
            alumnos.Remove(alumnoEliminar);
        }
        foreach(var alu in alumnos)
        {
            Console.WriteLine(alu);
        }

        if (alumnos.Count > 0)
        {
            alumnos.RemoveAt(0);
        }
        foreach(var alu in alumnos)
        {
            Console.WriteLine(alu);
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        Dictionary<int, Alumno> alumnosDic = new Dictionary<int, Alumno>();
        alumnosDic.Add(1, new Alumno(1, "Bautista", 6.5));
        alumnosDic.Add(2, new Alumno(2, "Lionel", 9.5));
        alumnosDic.Add(3, new Alumno(3, "Andres", 8.2));

        foreach(KeyValuePair<int, Alumno> alu in alumnosDic)
        {
            Console.WriteLine($"Legajo:{alu.Key}, Alumno: {alu.Value}");
        }

        int clave = 1;
        if (alumnosDic.TryGetValue(clave, out Alumno alumnoEncontrado))
        {
            Console.WriteLine($"alumno encontrado: {alumnoEncontrado}");
        }

        int claveInex = 50;
        if(alumnosDic.TryGetValue(claveInex, out Alumno alumnoInex))
        {
            Console.WriteLine(alumnoInex);
        }
        else
        {
            Console.WriteLine("No Existe");
        }

        int claveElim = 2;
        alumnosDic.Remove(claveElim);
        foreach(var alu in alumnosDic)
        {
            Console.WriteLine($"Legajo:{alu.Key}, Alumno: {alu.Value}");
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        List<Libro> listaLibros = Libro.CrearLista();
        CasoLinq.GetPrimero(listaLibros);
        CasoLinq.GetUltimo(listaLibros);
        CasoLinq.GetTotalPrecios(listaLibros);
        CasoLinq.GetPromedioPrecios(listaLibros, out decimal promed);
        CasoLinq.GetListById(listaLibros);
        CasoLinq.GetLibros(listaLibros);
        CasoLinq.GetMayorPrecio(listaLibros);
        CasoLinq.GetMenorPrecio(listaLibros);
        CasoLinq.GetMayorPromedio(listaLibros);
        CasoLinq.GetDescendente(listaLibros);
    }
}
