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
    private  List<Alumno> _alumnos = new List<Alumno>();
    public  void AgregarAlumno(Alumno alumno)
    {
        _alumnos.Add(alumno);
    }
    public List<Alumno> ListaAlumnos()
    {
        return _alumnos;
    }
    public Alumno BuscarPorNombre(string nombre)
    {
        return _alumnos.FirstOrDefault(a => a.Nombre == nombre);
    }
    public void EliminarAlumno(Alumno alumno)
    {
        _alumnos.Remove(alumno);
    }
    public void EliminarPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < _alumnos.Count)
        {
            _alumnos.RemoveAt(posicion);
        }
        else
        {
            Console.WriteLine("Esa posicion no es valida");
        }
    }
}
