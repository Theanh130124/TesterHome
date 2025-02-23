using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Anh_Lab1
{
    public class Caculation
    {
        private int a, b;
        public Caculation(int a, int b)   
        {
            this.a = a;
            this.b = b;

        }

        public int Execute(string Symbol)
        {
           int  res = 0;  
           
            switch (Symbol)
                {
                case "+":
                    res = a + b;
                    
                    break;
                case "-":
                    res = a - b;
                    break;
                case "*":
                    res = a * b;
                    break;
                case "/":
                    res = a / b;
                    break;

  

            }
            return res;



        }
        //
    }
}
