using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldTests.Fakes;

namespace HelloWorld.Tests
{
    [TestClass()]
    public class MessageTests
    {
        //********************************************** TEST SANS PARAMETRE ******************************************
        [TestMethod()]
        public void GetHelloMessageTest_bonjour()
        {
            FakeTime fake = new FakeTime();
            fake.DateToReturn = new DateTime(2018, 08, 21, 10, 8, 32);
            //Créer une instance de l'objet Message
            Message message = new Message(fake, 9, 13, 18);
            //Appeler la méthode que je souhaite tester
            String resultat = message.GetHelloMessage();
            //Je m'attends à avoir le résultat suivant
            StringAssert.Contains(resultat, "Bonjour");
        }

        [TestMethod()]
        public void GetHelloMessageTest_bonAprem()
        {
            FakeTime fake = new FakeTime();
            fake.DateToReturn = new DateTime(2018, 08, 21, 15, 8, 32);
            //Créer une instance de l'objet Message
            Message message = new Message(fake, 9, 13, 18);
            //Appeler la méthode que je souhaite tester
            String resultat = message.GetHelloMessage();
            //Je m'attends à avoir le résultat suivant
            StringAssert.Contains(resultat, "Bon après-midi");
        }

        [TestMethod()]
        public void GetHelloMessageTest_bonsoir()
        {
            FakeTime fake = new FakeTime();
            fake.DateToReturn = new DateTime(2018, 08, 21, 19, 8, 32);
            //Créer une instance de l'objet Message
            Message message = new Message(fake, 9, 13, 18);
            //Appeler la méthode que je souhaite tester
            String resultat = message.GetHelloMessage();
            //Je m'attends à avoir le résultat suivant
            StringAssert.Contains(resultat, "Bonsoir");
        }

        [TestMethod()]
        public void GetHelloMessageTest_bonWeekEnd()
        {
            FakeTime fake = new FakeTime();
            fake.DateToReturn = new DateTime(2018, 08, 25, 19, 8, 32);
            //Créer une instance de l'objet Message
            Message message = new Message(fake, 9, 13, 18);
            //Appeler la méthode que je souhaite tester
            String resultat = message.GetHelloMessage();
            //Je m'attends à avoir le résultat suivant
            StringAssert.Contains(resultat, "Bon week-end");
        }

        //********************************************** TEST AVEC PARAMETRE ******************************************

        //[TestMethod()]
        //public void GetHelloMessageTest_bonjour()
        //{
        //    //Créer une instance de l'objet Message
        //    Message message = new Message(9, 13, 18);
        //    //Appeler la méthode que je souhaite tester
        //    DateTime date = new DateTime(2018, 08, 21, 10, 8, 32);
        //    String resultat = message.GetHelloMessage(date);
        //    //Je m'attends à avoir le résultat suivant
        //    StringAssert.Contains(resultat, "Bonjour");
        //}

        //[TestMethod()]
        //public void GetHelloMessageTest_bonAprem()
        //{
        //    //Créer une instance de l'objet Message
        //    Message message = new Message(9, 13, 18);
        //    //Appeler la méthode que je souhaite tester
        //    DateTime date = new DateTime(2018, 08, 21, 15, 8, 32);
        //    String resultat = message.GetHelloMessage(date);
        //    //Je m'attends à avoir le résultat suivant
        //    StringAssert.Contains(resultat, "Bon après-midi");
        //}

        //[TestMethod()]
        //public void GetHelloMessageTest_bonsoir()
        //{
        //    //Créer une instance de l'objet Message
        //    Message message = new Message(9, 13, 18);
        //    //Appeler la méthode que je souhaite tester
        //    DateTime date = new DateTime(2018, 08, 21, 20, 8, 32);
        //    String resultat = message.GetHelloMessage(date);
        //    //Je m'attends à avoir le résultat suivant
        //    StringAssert.Contains(resultat, "Bonsoir");
        //}

        //[TestMethod()]
        //public void GetHelloMessageTest_bonWeekEnd()
        //{
        //    //Créer une instance de l'objet Message
        //    Message message = new Message(9, 13, 18);
        //    //Appeler la méthode que je souhaite tester
        //    DateTime date = new DateTime(2018, 08, 25, 10, 8, 32);
        //    String resultat = message.GetHelloMessage(date);
        //    //Je m'attends à avoir le résultat suivant
        //    StringAssert.Contains(resultat, "Bon week-end");
        //}
    }
}