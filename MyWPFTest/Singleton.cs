using MyWPFTest.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWPFTest
{
    public class Singleton
    {
        private static Singleton instance;
        public QuanannhatContext db = new QuanannhatContext();
        private Singleton()
        {
        }
        public static Singleton GetInstance()
        {
            if(instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
