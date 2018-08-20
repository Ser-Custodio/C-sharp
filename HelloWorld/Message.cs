using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Message
    {
        protected int matin = 9;
        protected int midi = 13;
        protected int soir = 18;

        public String GetHelloMessage ()
        {
            String message = "";

            DateTime date = new DateTime(2018, 08, 20, 15, 10, 10);
            // get the day of the week according to the date
            DayOfWeek day = date.DayOfWeek;

            // Change the message according to date and time
            // if its between friday 18h and Monday before 9h
            if (date.DayOfWeek == DayOfWeek.Friday && date.Hour > this.soir || date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Monday && date.Hour < this.matin)
            {
                message = "Bon week-end";
            }
            // if it's between 18h and 9h
            else if (date.Hour >= this.soir || date.Hour < this.matin)
            {
                message = "Bonsoir";
            }
            // if it's between 13h and 18h
            else if (date.Hour >= this.midi)
            {
                message = "Bon après-midi";
            }
            // if it's between 9h and 13h
            else if (date.Hour >= this.matin)
            {
                message = "Bonjour";
            }
            return message;
        }
        public Message(int matin, int midi, int soir)
        {
            this.matin = matin;
            this.midi = midi;
            this.soir = soir;
        }
    }
}
