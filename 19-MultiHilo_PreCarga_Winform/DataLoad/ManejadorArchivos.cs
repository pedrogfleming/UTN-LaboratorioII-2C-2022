using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;

namespace DataLoad
{
    public class ManejadorArchivos
    {
        private string _titulo;
        private string _path;

        public ManejadorArchivos(string titulo)
        {
            _titulo = titulo;
            _path = GenerarRuta(_titulo);
        }

        /// <summary>
        /// Genera un path donde se puede guardar un archivo
        /// </summary>
        /// <param name="titulo">que tiene el archivo</param>
        /// <returns>path donde se encuentra el archivo</returns>
        public static string GenerarRuta(string titulo)
        {
            try
            {
                string rutaAlt = AppDomain.CurrentDomain.BaseDirectory;
                string rutaArchivo = Path.Combine(rutaAlt, titulo);
                return rutaArchivo;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo generar la ruta", ex);
            }
        }
        /// <summary>
        /// Deserealiza un archivo Json
        /// </summary>
        /// <typeparam name="T">objeto generico</typeparam>
        /// <param name="ruta">desde donde se lee el archivo</param>
        /// <returns>El objeto deserealizado</returns>
        public T DeserealizarDesdeJson<T>() where T : class
        {
            try
            {
                string objetoJson = File.ReadAllText(this._path);
                //Usamos un converter para serializar sin problema los enums
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
                {
                    Converters =
                    { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
                };
                jsonSerializerOptions.WriteIndented = true;

                T objetoDeserealizado = JsonSerializer.Deserialize<T>(objetoJson, jsonSerializerOptions);

                return objetoDeserealizado;
            }
            catch (Exception ex)
            {
                throw new SerializacionException(ex);
            }
        }
        
    }
}
