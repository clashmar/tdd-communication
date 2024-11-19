using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_communication
{
    public class Kata6
    {

        public static string CheeseChasers(string theChase, int catSpeed, int mouseSpeed)
        {
            int cheeseIndex = theChase.IndexOf("C");
            int catIndex = theChase.IndexOf("K");
            int mouseIndex = theChase.IndexOf("M");

            if (mouseSpeed <= 0 && catSpeed <= 0)
            {
                throw new ArgumentException("The cat and the mouse aren't hungry today.");
            }
            if (catIndex > mouseIndex)
            {
                throw new ArgumentException("The cat can't see the mouse.");

            }
            if (mouseIndex > cheeseIndex)
            {
                throw new ArgumentException("The cat can't find the cheese!");
            }

            while (!false)
            {
                mouseIndex += mouseSpeed;
                catIndex += catSpeed;

                if (catIndex >= cheeseIndex && mouseIndex >= cheeseIndex)
                {
                    return "Cheese party!";
                }
                else if (catIndex >= mouseIndex)
                {
                    return "No cheese";
                }
                else if (mouseIndex >= cheeseIndex)
                {
                    return "Cheese";
                }

            }

        }

    }
}
