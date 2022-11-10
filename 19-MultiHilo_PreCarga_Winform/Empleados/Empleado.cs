using System;
using System.Collections.Generic;
using System.IO;

namespace Empleados
{
    public class Empleado
    {
        public Empleado() : this(string.Empty,string.Empty)
        {
        }
        public Empleado(string nombre, string mail)
        {
            Nombre = nombre;
            Mail = mail;
        }
        public string Nombre { get; set; }


        public string Mail { get; set; }

        public static List<Empleado> CargarDataDesdeCsv(string path, string separador)
        {
            List<Empleado> empleados = new List<Empleado>();
            StreamReader archivo= new StreamReader(path);
            string linea;
            // Si el archivo no tiene encabezado, elimina la siguiente línea
            // Leer la primera línea pero descartarla porque es el encabezado
            archivo.ReadLine(); 
            while ((linea = archivo.ReadLine()) != null)
            {
                string[] fila = linea.Split(separador);
                string nombreEmpleado = fila[0];
                string mailEmpleado = fila[1];
                if(!string.IsNullOrWhiteSpace(nombreEmpleado) && !string.IsNullOrWhiteSpace(mailEmpleado))
                {
                    empleados.Add(new Empleado(nombreEmpleado, mailEmpleado));
                }
            }
            return empleados;
        }
    }
}
