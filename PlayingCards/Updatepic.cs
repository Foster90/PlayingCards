using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards
{
    class Updatepic
    {

        public static string UpPic(string curItem)

        {

            string selcd = curItem.Substring(0, 1);
            string selcd1 = "";


            int spaces1 = 0;
            for (int i = 0; i < curItem.Length; i++)
            {
                if (curItem[i] == ' ')
                {
                    spaces1++;
                }
                if (spaces1 == 2)
                {
                    selcd1 = curItem.Substring(i + 1, 1);
                    break;
                }
            }

            return selcd + selcd1;

        }


    }
}
