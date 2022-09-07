namespace Entidades
{
    public class Camionero
    {
        private string nombre;
        public float[] arrayDiasKm;



        //ATRIBUTOS
        public Camionero(string camionero, float[] arrayKm)
        {
            this.nombre = camionero;
            this.arrayDiasKm = arrayKm;
        }

        //PROPIEDADES
        public string Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public float[] ArrayDiasKm
        {
            set { this.arrayDiasKm = value; }
            get { return this.arrayDiasKm; }
        }




    }

}
