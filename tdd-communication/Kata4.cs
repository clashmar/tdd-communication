using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_communication
{
    public class Kata4
    {
        public enum Opinion
        {
            LIKE,
            DISLIKE,
            NEUTRAL
        }

        public static Enum GetOpinion(List<Opinion> inputList)
        {
            bool liked = false;
            bool disliked = false;

            foreach (Opinion opinion in inputList)
            {
                if (opinion == Opinion.LIKE)
                {
                    liked = !liked;
                }
                else
                {
                    disliked = !disliked;
                }
            }

            if (liked == disliked)
            {
                return Opinion.NEUTRAL;
            }
            if (liked)
            {
                return Opinion.LIKE;
            }
            else
            {
                return Opinion.DISLIKE;
            }


            
        }


    }
}
