using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> _diccionarioAlumnos = new Dictionary<int, Alumno>();
    public void AgregarAlumno(Alumno alumno)
    {
        if (!_diccionarioAlumnos.ContainsKey(alumno.Id))
        {
            _diccionarioAlumnos.Add(alumno.Id, alumno);
        }
        else
        {
            Console.WriteLine("Ese alumno ya existe");
        }
    }
    public Alumno BuscarAlumno(int legajo)
    {
        if (_diccionarioAlumnos.TryGetValue(legajo, out Alumno alumnoEncontrado))
        {
            return alumnoEncontrado;
        }
        return null;
    }
    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return _diccionarioAlumnos;
    }
    public void EliminarAlumno(int legajo)
    {
        bool fueEliminado = _diccionarioAlumnos.Remove(legajo);
        if (!fueEliminado)
        {
            Console.WriteLine($"{legajo} no se encontro");
        }
    }
}
