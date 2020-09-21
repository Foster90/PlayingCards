using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards
{
    class UpdatePic
    {
        public static string UpPic(string curItem)

        {
            string selCd = curItem.Substring(0, 1);
            string selCd1 = "";


            int spaces = 0;
            for (int i = 0; i < curItem.Length; i++)
            {
                if (curItem[i] == ' ')
                {
                    spaces++;
                }
                if (spaces == 2)
                {
                    selCd1 = curItem.Substring(i + 1, 1);
                    break;
                }
            }

            return selCd + selCd1;

        }
    }
}
