using System;
using System.Collections.Generic;
using System.Text;

namespace TDD.ConsoleApp
{
    public class Salary
    {
        public string name { get; set; }
        public int manyjob { get; set; }
        public int moneyperhour { get; set; }
        public double sum { get; set; }


        public int Howmanyjob(int job)
        {

            return 0;
        }

        public int  moneyperday(int job,int moneyperhour)
        {
            var resual = job * moneyperhour;
            return resual;
        }
    }

}
