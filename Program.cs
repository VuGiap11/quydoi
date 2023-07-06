using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tigiachuyendoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int sotien;
            long rate = 23000;
            Console.WriteLine("mời người dùng nhập vào giá trị cần chuyển đổi tiền: ");
            sotien = int.Parse(Console.ReadLine());

            long vnd = sotien* rate;
            Console.WriteLine("so tien quy doi la: "+vnd);
        }
    }
}
