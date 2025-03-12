# Gesti-n-de-tareas-personales

using System;
using System.Collections.Generic;

namespace TaskManager
{
    class Program
    {
        static List<Task> tasks = new List<Task>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- Sistema de Gestión de Tareas ---");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Listar tareas");
                Console.WriteLine("3. Marcar tarea como completada");
                Console.WriteLine("4. Salir");
                Console.Write("Selecciona una opción: ");

                string option = Console.ReadLine();

                switch (option)
                {
