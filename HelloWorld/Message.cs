using System;
using HelloWorld;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Message
    {
        protected int matin = 9;
        protected int midi = 13;
        protected int soir = 18;

        private ITime date;

        public Message(int matin, int midi, int soir)
            :this(new Time(), matin, midi, soir)
        {
        }

        internal Message(ITime date, int matin, int midi, int soir)
        {
            this.matin = matin;
            this.midi = midi;
            this.soir = soir;

            this.date = date;
        }


        //option pour les testes avec injection de dependances
        public String GetHelloMessage()
        {
            String message = "";

            // Change the message according to date and time
            // if its between friday 18h and Monday before 9h
            if (date.Date.DayOfWeek == DayOfWeek.Friday && date.Date.Hour > this.soir || date.Date.DayOfWeek == DayOfWeek.Saturday || date.Date.DayOfWeek == DayOfWeek.Sunday || date.Date.DayOfWeek == DayOfWeek.Monday && date.Date.Hour < this.matin)
            {
                message = "Bon week-end";
            }
            // if it's between 18h and 9h
            else if (date.Date.Hour >= this.soir || date.Date.Hour < this.matin)
            {
                message = "Bonsoir";
            }
            // if it's between 13h and 18h
            else if (date.Date.Hour >= this.midi)
            {
                message = "Bon après-midi";
            }
            // if it's between 9h and 13h
            else if (date.Date.Hour >= this.matin)
            {
                message = "Bonjour";
            }
            return message;
        }

        ////option pour les testes faciles
        //public String GetHelloMessage (DateTime date)
        //{
        //    String message = "";

        //    //DateTime date = DateTime.Now;
        //    // get the day of the week according to the date
        //    DayOfWeek day = date.DayOfWeek;

        //    // Change the message according to date and time
        //    // if its between friday 18h and Monday before 9h
        //    if (date.DayOfWeek == DayOfWeek.Friday && date.Hour > this.soir || date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Monday && date.Hour < this.matin)
        //    {
        //        message = "Bon week-end";
        //    }
        //    // if it's between 18h and 9h
        //    else if (date.Hour >= this.soir || date.Hour < this.matin)
        //    {
        //        message = "Bonsoir";
        //    }
        //    // if it's between 13h and 18h
        //    else if (date.Hour >= this.midi) 
        //    {
        //        message = "Bon après-midi";
        //    }
        //    // if it's between 9h and 13h
        //    else if (date.Hour >= this.matin)
        //    {
        //        message = "Bonjour";
        //    }
        //    return message;
        //}

    }
}
