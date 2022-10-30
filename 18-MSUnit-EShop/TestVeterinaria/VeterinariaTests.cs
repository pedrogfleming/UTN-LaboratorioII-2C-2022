using EShop.Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Veterinaria;

namespace TestVeterinaria
{
    [TestClass]
    public class VeterinariaTests
    {
        [TestMethod]
        public void Test_Chequear_PreCarga_Mascotas_Ok()
        {
            //Arrange: 
            var mascotas = VeterinariaManager.Pets;
            //Act:

            //Assert:
            Assert.IsTrue(mascotas.Count > 0);
        }
        [TestMethod]
        public void Test_AgregarMascota_AlaEspera_Ok()
        {
            //Arrange: 
            Mascota m = new("Panchito", 12, Guid.NewGuid());
            //Act:
            bool resultado = VeterinariaManager.AgregarMascotaALaCola(m);
            //Assert:
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void Test_AgregarMascota_ALa_Espera_Ya_Existe()
        {
            //Arrange:
            Mascota m = VeterinariaManager.Pets.Keys.FirstOrDefault();
            //Act:
            bool resultado = VeterinariaManager.AgregarMascotaALaCola(m);
            //Assert:
            //Debería retornar false y no agregarla dado que ya existe
            Assert.IsFalse(resultado);
        }


        [TestMethod]
        public void Test_AtenderMascota_Ok()
        {
            //Arrange: 
            Mascota m = VeterinariaManager.Pets.Keys.FirstOrDefault();
            //Act:
            bool resultado = VeterinariaManager.AtenderMascota(m);
            //Assert:
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void Test_AtenderMascota_YaAtendida()
        {
            //Arrange: 
            Mascota m = VeterinariaManager.Pets.Keys.FirstOrDefault(m => m.Nombre == "Michi");
            //Act:
            bool resultado = VeterinariaManager.AtenderMascota(m);
            //Assert:
            Assert.IsFalse(resultado);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Test_AtenderMascota_Inexistente_Exception()
        {
            //Arrange: 
            Mascota m = new("Coco", 12, Guid.NewGuid());
            //Act:
            bool resultado = VeterinariaManager.AtenderMascota(m);
        }
        [TestMethod]
        public void Test_Mascotas_Iguales_Ok()
        {
            //Arrange: 
            Mascota m1 = new("Lalo", 2, Guid.NewGuid());
            Mascota m2 = new("Lalo", 2, Guid.NewGuid());
            //Act:
            bool resultado = m1 == m2;
            //Assert:
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void Test_Mascotas_Distintas_Ok()
        {
            //Arrange: 
            Mascota m1 = new("Lalo", 2, Guid.NewGuid());
            Mascota m2 = new("Panchito", 3, Guid.NewGuid());
            //Act:
            bool resultado = m1 == m2;
            //Assert:
            Assert.IsFalse(resultado);
        }
    }
}
