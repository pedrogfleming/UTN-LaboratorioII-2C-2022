using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_ContarPalabras
{
    //Consigna: https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/colecciones/Ejercicios/I03-a-contar-palabras/
    public partial class FormContador : Form
    {
        /// <summary>
        /// Defino un diccionario de palabra y su total de ocurrencias
        /// </summary>
        private Dictionary<string, int > contadorPalabras;
        public FormContador()
        {
            InitializeComponent();
            contadorPalabras = new Dictionary<string, int>();
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            //Recorro el texto del richtextbox y voy separando(Split) las palabras entre si
            //Para despues guardarlas en una lista(convierto a to list porque Split me retorna un array)
            //Uso trim para remover los espacios al principio y al final del texto
            //Uso ToLower para que sea una busqueda case insensitive
            //Uso replace para primero normalizar el uso de comas
            //Y despues quitar las comas y remplazarlo por un espacio
            List<string> palabrasContadas = rtxPalabras.Text.Trim()
                .ToLower()
                .Replace("\n"," ")
                .Replace(", ", ",")
                .Replace(","," ")
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            //Linq nos permite usar un foreach de esta manera
            // Mas info de LINQ https://linqsamples.com/
            // Documentacion oficial de LINQ : https://docs.microsoft.com/es-es/dotnet/csharp/programming-guide/concepts/linq/
            // Video sobre LINQ https://www.youtube.com/watch?v=S5rQk1aQSAA
            palabrasContadas.ForEach(palabra =>
            {
                bool existe = contadorPalabras.ContainsKey(palabra);
                if (!existe)
                {
                    //Si no existe la palabra en mi diccionario, la agrego y le pongo 1 ocurrencia
                    contadorPalabras.Add(palabra, 1);
                }
                else
                {
                    //Si la palabra ya existe, entonces le sumo 1 al contador de ocurrencias
                    contadorPalabras[palabra]++;
                }
            });
            //Uso el stringbuilder porque es mas performante
            StringBuilder sb = new();
            sb.AppendLine($"Detalle contador de palabras(palabra/total de apariciones):");
            foreach (var item in contadorPalabras)
            {
                sb.AppendLine($"{item.Key} : {item.Value}");
            }
            MessageBox.Show(sb.ToString());
            //Limpio el diccionario para que cuando el usuario vuelva a presionar el boton calcular,
            //la cuenta arranque de cero
            contadorPalabras.Clear();
        }
    }
}
