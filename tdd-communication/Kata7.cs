using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_communication
{
    public class Kata7
    {
        public enum StartingPositions
        {
            CatMouseCheese,
            CatCheeseMouse,
            MouseCheeseCat,
            CheeseCatMouse

        }
        public static string CheeseChasers(string theChase, int catSpeed, int mouseSpeed)
        {
            int cheeseIndex = theChase.IndexOf("C");
            int catIndex = theChase.IndexOf("K");
            int mouseIndex = theChase.IndexOf("M");

            if (mouseSpeed == 0 && catSpeed == 0)
            {
                throw new ArgumentException("The cat and the mouse aren't hungry today.");
            }

            if(mouseIndex < cheeseIndex && mouseSpeed <= 0)
            {
                return "No Cheese";
            }
            if (mouseIndex > cheeseIndex && mouseSpeed >= 0)
            {
                return "No Cheese";
            }

            if (catIndex < mouseIndex && catSpeed < 0)
            {
                return "Cheese";
            }
            if (catIndex > mouseIndex && catSpeed > 0)
            {
                return "Cheese";
;           }

            StartingPositions position;

            if(catIndex < cheeseIndex && mouseIndex < cheeseIndex)
            {
                position = StartingPositions.CatMouseCheese;
            }
            else if(catIndex < cheeseIndex && mouseIndex > cheeseIndex)
            {
                position = StartingPositions.CatCheeseMouse;
            }
            else if(catIndex > cheeseIndex && mouseIndex < cheeseIndex)
            {
                position = StartingPositions.MouseCheeseCat;
            }
            else
            {
                position = StartingPositions.CheeseCatMouse;
            }

            while (!false)
            {
                mouseIndex += mouseSpeed;
                catIndex += catSpeed;

                //Cat and mouse on left
                if(position == StartingPositions.CatMouseCheese)
                {
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

                // Cat Left Mouse Right
                if(position == StartingPositions.CatCheeseMouse)
                {
                    if (catIndex >= cheeseIndex && mouseIndex <= cheeseIndex)
                    {
                        return "Cheese party!";
                    }
                    else if (catIndex >= mouseIndex)
                    {
                        return "No cheese";
                    }
                    else if (mouseIndex <= cheeseIndex)
                    {
                        return "Cheese";
                    }
                }

                // Cat Right Mouse Left
                if (position == StartingPositions.MouseCheeseCat)
                {
                    if (catIndex <= cheeseIndex && mouseIndex >= cheeseIndex)
                    {
                        return "Cheese party!";
                    }
                    else if (catIndex <= mouseIndex)
                    {
                        return "No cheese";
                    }
                    else if (mouseIndex >= cheeseIndex)
                    {
                        return "Cheese";
                    }
                }

                // Cart Right Mouse Right
                if (position == StartingPositions.CheeseCatMouse)
                {
                    if (catIndex <= cheeseIndex && mouseIndex <= cheeseIndex)
                    {
                        return "Cheese party!";
                    }
                    else if (catIndex <= mouseIndex)
                    {
                        return "No cheese";
                    }
                    else if (mouseIndex <= cheeseIndex)
                    {
                        return "Cheese";
                    }
                }

            }

        }

    }
}
