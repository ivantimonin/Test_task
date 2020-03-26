using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ds.test.impl;

namespace Test_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Plugins obj = new Plugins(10);//все что доступно классу
            IPlugin new_obj = new Plugins();//все что доступно интерфейсу
                        
            obj.WriteNewStar("Альфа Центавра");
            obj.WriteNewStar("а Большого Пса");
            obj.Read_all_Star();
            
            int rezult = obj.Run(1, 6);
            Console.WriteLine($"Результат равен {rezult} ");           
            Console.ReadLine();
        }
    }
}
