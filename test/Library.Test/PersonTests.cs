using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void IdInvalida() // Cambiá el nombre para indicar qué estás probando
        {
            // Configuracion del estado
            string expectedName = "Sebastian Fripp";
            string expectedId = null;
            string testId = "4.989.466-6";
            string testName = "Sebastian Fripp";

            // Prueba el comportamiento que quiero probar
            Person person = new Person(testName, testId);

            // Comprobacion del resultado
            Assert.AreEqual(expectedName, person.Name);
            Assert.AreEqual(expectedId, person.ID);
        }

        [Test]
        public void NombreInvalido()
        {
            // Configuracion del estado
            string expectedName = null;
            string expectedId = "4.989.466-8";
            string testId = "4.989.466-8";
            string testName = "";

            // Prueba el comportamiento que quiero probar
            Person person = new Person(testName, testId);

            // Comprobacion del resultado
            Assert.AreEqual(expectedName, person.Name);
            Assert.AreEqual(expectedId, person.ID);
        }

        [Test]
        public void DatosInvalidos()
        {
            // Configuracion del estado
            string expectedName = null;
            string expectedId = null;
            string testId = "4.989.466-6";
            string testName = "";

            // Prueba el comportamiento que quiero probar
            Person person = new Person(testName, testId);

            // Comprobacion del resultado
            Assert.AreEqual(expectedName, person.Name);
            Assert.AreEqual(expectedId, person.ID);
        }
    }
}