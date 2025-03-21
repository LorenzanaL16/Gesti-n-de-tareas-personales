//Gesti-n-de-tareas-personales

using System; public class Tarea { public int Id { get; set; } public string Titulo { get; set; } public string Descripcion { get; set; } public DateTime Fecha { get; set; } public bool Completada { get; set; }

 public override string ToString()
{
    return $"ID: {Id}, Título: {Titulo}, Fecha: {Fecha.ToShortDateString()}, Completada: {Completada}";
}
}

using System; using System.Collections.Generic;

namespace TaskManager { private List tareas = new List();

public void AgregarTarea(Tarea tarea)
{
    tareas.Add(tarea);
    Console.WriteLine("¡Tarea agregada con éxito!");
}

 public void ListarTareas()
{
    Console.WriteLine("\n--- Lista de Tareas ---");
    foreach (var tarea in tareas)
    {
        Console.WriteLine(tarea.ToString());
    }
}

public void CompletarTarea(int id)
{
    var tarea = tareas.Find(t => t.Id == id);
    if (tarea != null)
    {
        tarea.Completada = true;
        Console.WriteLine($"¡Tarea con ID {id} marcada como completada!");
    }
    else
    {
        Console.WriteLine($"No se encontró una tarea con ID {id}.");
    }
}

public void EliminarTarea(int id)
{
    var tarea = tareas.Find(t => t.Id == id);
    if (tarea != null)
    {
        tareas.Remove(tarea);
        Console.WriteLine($"¡Tarea con ID {id} eliminada!");
    }
    else
    {
        Console.WriteLine($"No se encontró una tarea con ID {id}.");
    }
}

using System;
class Program
{
    static void Main(string[] args)
    {   
     static List<Task> tasks = new List<Task>();
     int option;

     do
     {
            Console.WriteLine("\n--- Sistema de Gestión de Tareas ---");
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2. Listar tareas");
            Console.WriteLine("3. Completar Tarea");
            console.WriteLine("4. Eliminar Tarea");
            Console.WriteLine("5. Salir");
            Console.Write("Selecciona una opción: ");
            option = int.Parse(Console.Read());

            switch (option)
            {
            case 1:
                 var nuevaTarea = new Tarea
                {
                    Id = DateTime.Now.Millisecond, // Generador simple para ID
                    Titulo = LeerDato("Título"),
                    Descripcion = LeerDato("Descripción"),
                    Fecha = DateTime.Parse(LeerDato("Fecha (yyyy-MM-dd)")),
                    Completada = false
                    };
                    Console.WriteLine.AgregarTarea(nuevaTarea);
                    break;

            case 2: 
                    console.Write("\n--- Lista de Tareas ---");
                    break;
                    }

            case 3:
                     var idCompletar = int.Parse(LeerDato("ID de la tarea a completar"));
                console.Write.CompletarTarea(idCompletar);
                break;

            case 4:
                var idEliminar = int.Parse(LeerDato("ID de la tarea a eliminar"));
                repositorio.EliminarTarea(idEliminar);
                break;

            case 5:
                Console.WriteLine("¡Gracias por usar el sistema!");
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    } while (opcion != 5);
}

static string LeerDato(string mensaje)
{
    Console.Write($"{mensaje}: ");
    return Console.ReadLine();
}
}