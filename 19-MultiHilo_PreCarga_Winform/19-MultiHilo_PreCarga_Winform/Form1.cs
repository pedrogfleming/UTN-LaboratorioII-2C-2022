using DataLoad;
using Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_MultiHilo_PreCarga_Winform
{
    public partial class Form1 : Form
    {
        private const string DATABASE = "Compañia.db";
        private const string CONNECTIONSTRING = @"Server=.\SQLEXPRESS;Database=;Trusted_Connection=True;";

        private readonly DBManager dBManager;
        public Form1()
        {
            InitializeComponent();
            DBManager dbManager = new DBManager(CONNECTIONSTRING, DATABASE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Cargar desde el json los empleados
            var manejadorJson = new ManejadorArchivos("empleados.json");
            List<Empleado> empleados = manejadorJson.DeserealizarDesdeJson<List<Empleado>>();
            dgv1.DataSource = null;
            dgv1.DataSource = empleados;
            empleados = null;
            #endregion

            #region Cargar desde la base de datos los empleados
            empleados = dBManager.ObtenerListaEmpleados();
            dgv2.DataSource = null;
            dgv2.DataSource = empleados;
            #endregion

            #region Cargar desde el csv los empleados
            string csvPath = ManejadorArchivos.GenerarRuta("empleados.csv");
            empleados = Empleado.CargarDataDesdeCsv(csvPath, ",");
            dgv3.DataSource = null;
            dgv3.DataSource = empleados;
            #endregion

            #region Cargar desde el xml los empleados

            #endregion
        }
    }
}
