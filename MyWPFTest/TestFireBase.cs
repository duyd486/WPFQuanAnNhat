using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace MyWPFTest
{
    public class TestFireBase
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "q2NPp1iiXk3sb73qH44kvRpt534bGSxsF6wwWC06",
            BasePath = "https://duyd-d124f-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        public TestFireBase()
        {
            client = new FireSharp.FirebaseClient(config);
            if(client != null)
            {
                MessageBox.Show("Hello");
                Console.WriteLine("Test");
            }
            else
            {
                Console.WriteLine("Test");

                MessageBox.Show("chao");
            }
        }
    }
}
