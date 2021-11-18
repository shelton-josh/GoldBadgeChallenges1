using System;
using BadgeRepo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge3.UI;

namespace Challenge3
{
    public class Program
    {
        //{key - value} = {int, "string"} key = BadgeID and value = List of Door Names
        //
        static void Main(string[] args)
        {
            ProgramUI program = new ProgramUI();
            program.Run();
        }
    }
}
