using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLesson
{
    class Woman:Person
    {
        public string Gender;

        public Woman()
        {
            Console.WriteLine("I am WOMANNNNNN");
        }
        public override string FullInfo()
        {
            return $"{base.FullInfo()} , Cinsi: {Gender}";
        }
    }
}
