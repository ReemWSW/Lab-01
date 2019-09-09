using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            //สร้างตัวแปร Random โดยการมีสุ่มเลข 1 หลัก (0–9)
            Random r = new Random();
            int rd = r.Next(0, 10);
            Console.WriteLine($"Random number : {rd}");

            //สร้างตัวแปรชนิด integer สำหรับรับค่าจากผู้ใช้
            Console.Write("Enter number : ");
            int n = int.Parse(Console.ReadLine());

            //สร้างตัวแปร boolean โดยเก็บค่าที่ได้จากการเปรียบเทียบตัวเลขในข้อ 1 และ 2
            bool b;

            if (rd == n)
                b = true;
            else
                b = false;

            //ให้พิมพ์ค่าตัวแปร boolean ในข้อ 3 ออกทางหน้าจอ
            Console.WriteLine($"Random Equal input : {b}");


        }
    }
}
