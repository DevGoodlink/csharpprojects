using Microsoft.VisualStudio.TestTools.UnitTesting;
using testUnitaire.Models;
using Moq;
using System.Web;
using System.Web.Routing;
using testUnitaire;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void factorielle_avecvaleur0_retourne1()
        {
            Assert.AreEqual(1, MathHelper.factoriel(0));

        }

        [TestMethod]
        public void ObtenirLaMeteoDuJour_AvecUnBouchon_RetourneSoleil()
        {
            Meteo m = new Meteo
            {
                Temperature = 25,
                Temps = Temps.Soleil
            };
            IDal dal = new Dal();
            //Meteo m = dal.ObtenirLaMeteoDuJour();
            Assert.AreEqual(25, m.Temperature);
            Assert.AreEqual(Temps.Soleil, m.Temps);
        }

        [TestMethod]
        public void ObtenirLaMeteoDuJour1_AvecUnBouchon_RetourneSoleil()
        {
            Meteo fausseMeteo = new Meteo
            {
                Temperature = 25,
                Temps = Temps.Soleil
            };
            Mock<IDal> mock = new Mock<IDal>();

            mock.Setup(dal => dal.ObtenirLaMeteoDuJour()).Returns(fausseMeteo);
            IDal fausseDal = mock.Object;
            Meteo m = fausseDal.ObtenirLaMeteoDuJour();
            Assert.AreEqual(25, m.Temperature);
            Assert.AreEqual(Temps.Soleil, m.Temps);

        }
        [TestMethod]
        public void Routes_PageHomeIndex2_RetourneControleurHomeEtMethodeIndexEtParam2()
        {
            Mock<HttpContextBase> mockContexte = new Mock<HttpContextBase>();
            mockContexte.Setup(c => c.Request.AppRelativeCurrentExecutionFilePath).Returns("~/Home/Index/2");
            RouteCollection routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);
            RouteData routeData = routes.GetRouteData(mockContexte.Object);

            Assert.AreEqual("Home", routeData.Values["controller"]);
            Assert.AreEqual("Index", routeData.Values["Index"]);
            Assert.AreEqual("2", routeData.Values["2"]);

        }
    }
}
