using System;
using System.Text;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          // string a1a= Question1A("ABCDE");
           //string a1b = Question1B("ABCDE ABCDE ABCD ABCD");
            //Int32 a2 = Question2(15);
        }
        static string Question1A(string str)
        {
            char[] ret=str.ToCharArray();
            for (int i = 0; i < str.Length/2; i++)
            {
                char tmp = ret[i];
                ret[i] = ret[str.Length - 1-i];
                ret[str.Length - 1 - i] = tmp;
            }
            return new string(ret);
        }
        static string Question1B(string str)
        {
            StringBuilder ret=new StringBuilder();
            string[] strs = str.Split(' ');
            for (int i = 0; i < strs.Length; i++)
            {
                ret.Append(Question1A(strs[i]));
                if (i< strs.Length-1)
                ret.Append(" ");
            }
            return ret.ToString();
        }
        static Int32 Question2(Int32 input)
        {
            Int32 ret = 0;
            for (int i = 1; i <= input; i++)
            {
                if (i%3==0 )
                {
                    if (i % 5 == 0)
                        ret++;
                    continue;
                }
                if (i % 5 == 0)
                {
                    if (i % 3 == 0)
                        ret++;
                    continue;
                }
                ret++;
            }
            return ret;
        }
        static void Question3()
        {
            /*
             * 因為題目已明確指出這三袋都是錯的
             * 如果標示混和抽出來是鉛筆，標示混和的就是鉛筆，然後標示原子筆的就必然是混和的，標示鉛筆的就是原子筆，要不然就會違背三袋都是錯的假設
             *如果標示混和抽出來是原子筆，標示混和的就是原子筆，然後標示鉛筆的就必然是混和的，標示原子筆的就是鉛筆，要不然就會違背三袋都是錯的假設
             */
        }
        static void Question4()
        {
            /*
             * 問題在於900元的餐點根本就不存在，真實存在的750的特價餐點
             * 因此三個人共付了810之後，三個會拿到一張810的發票，誤以為這個餐點是810，但這個餐點成本只有750元
             * 所以服務員賺到了810-750=60元
             * 810+60=870這個式子根本不存在意義，因此這個餐點的成本不是870也不是900，是750
             * 810-60=750就有意義了，收了810，減掉員工A走的60元，750就是員工要敲進收銀台的錢
             */
        }
    }
}
