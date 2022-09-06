namespace Domain
{
    public class Domicilio
    {
        public string Ciudad { get; set; } = "No especificado";
        public string Calle { get; set; } = "No especificado";
        public int? Altura { get; set; }
        /// <summary>
        /// El piso al no ser un dato esencial, lo ponemos nulleable con el ?. 
        /// Si por default le asignamos 0, se puede malinterpretar que es PB cuando en realidad el cliente no especifico
        /// Por lo tanto, , si el cliente no especifica, quedará un null
        /// </summary>
        public int? Piso { get; set; } = null;
        public string Departamento { get; set; } = "No especificado";

        public Domicilio()
        {
        }
        public Domicilio(string ciudad, string calle, int altura, int? piso, string departamento)
        {
            Ciudad = ciudad;
            Calle = calle;
            Altura = altura;
            Piso = piso;
            Departamento = departamento;
        }
        public Domicilio(string ciudad, string calle, int altura):this(ciudad,calle,altura,null,"No especificado")
        {
            Ciudad = ciudad;
            Calle = calle;
            Altura = altura;
        }
    }
}
