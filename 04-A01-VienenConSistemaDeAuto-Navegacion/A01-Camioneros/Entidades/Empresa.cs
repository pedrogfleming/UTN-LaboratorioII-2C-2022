﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empresa
    {
        //ATRIBUTOS
        private Camionero[] arrayConductores;//un camionero completo con nombre y los 7 km

        //CONSTRUCTOR
        /// <summary>
        /// Constructor que espera aray de conductores
        /// </summary>
        /// <param name="arrayConductores"></param>

        public Empresa(Camionero[] arrayConductores)
        {
            this.arrayConductores = arrayConductores;
        }

        //propiedad

        public Camionero[] ArrayConductores
        {
            set { arrayConductores = value; }
            get { return this.arrayConductores; }
        }

        //METODOS

        //  El conductor que hizo más km en esa semana.
        public string CalculoDeMayorkmEnLaSemana()
        {
            string ganador;
            var sumaTotal = arrayConductores.Select<Camionero,(float TotalKms, string NombreConductor)>(c => new(
                c.ArrayDiasKm.Sum(),
                c.Nombre)
            );            
            var camioneroYsuKms = sumaTotal.Where(camionero => camionero.TotalKms == sumaTotal.Max(sumatot => sumatot.TotalKms));
            ganador = camioneroYsuKms.SingleOrDefault().NombreConductor;
            #region MyRegion
            //string ganador;
            //float buffer;//porque tengo que darle un valor
            //int indiceConductorConMasKm = -1;//por que tengo qe darle un valor

            //    buffer = arrayConductores[j].ArrayDiasKm.Sum();//suma de km de un conductor

            //    if (j == 0)
            //    {
            //        indiceConductorConMasKm = j;
            //    }
            //    else
            //    {
            //        if (buffer > arrayConductores[indiceConductorConMasKm].ArrayDiasKm.Sum())
            //        {
            //            indiceConductorConMasKm = j;
            //        }
            //    }
            //}
            //ganador = RetornoConductorByIndice(indiceConductorConMasKm);//llamo a funcion que devuelve ganador
            #endregion
            return ganador;
        }
        /// <summary>
        /// Retorna string ganador a travez del indice que recibe por parametro
        /// </summary>
        /// <param name="indice"></param>
        /// <returns></returns>
        public string RetornoConductorByIndice(int indice)
        {
            string nombreCamioneroGanador;
            Camionero unCamionero = ArrayConductores[indice];//recibo un camionero completo

            nombreCamioneroGanador = unCamionero.Nombre;//busco en el camionero el nomnre

            return nombreCamioneroGanador;//retorno
        }

        /// <summary>
        /// Recibe un numero de dia a evaluar y retorna el camionero con mas km en ese dia
        /// </summary>
        /// <param name="dia"></param>
        /// <returns></returns>

        public string CalculoDeMayorkmEnDiaDeterminado(int dia)
        {
            int indiceConductorConMasKm = -1;
            string nombreCamioneroGanador;
            float buffer;
            Camionero[] arrayConductores = ArrayConductores;


            for (int j = 0; j < arrayConductores.Length; j++)
            {

                buffer = arrayConductores[j].ArrayDiasKm[dia];//suma de km de un conductor
                if (j == 0)
                {
                    indiceConductorConMasKm = j;
                }
                else
                {
                    if (buffer > arrayConductores[indiceConductorConMasKm].ArrayDiasKm[dia])
                    {
                        indiceConductorConMasKm = j;
                    }
                }
            }

            nombreCamioneroGanador = RetornoConductorByIndice(indiceConductorConMasKm);

            return nombreCamioneroGanador;//retorno
        }
    }
}