using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCountElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] arrListStudents = new int[30];
            int length = arrListStudents.Length;
            int count = 0;
            Console.WriteLine("Enter the student's score: ");
            for (i = 0; i < length; i++)
            {
                //In ra màn hình danh sách điểm số của sinh viên
                Console.Write("Student[{0}]: ", i);
                arrListStudents[i] = Convert.ToInt32(Console.ReadLine());
                //Kiểm tra những sinh viên nào có điểm lơn hơn hoặc bằng 5 sẽ lưu vào biến đếm
                if (arrListStudents[i] >= 5)
                {
                    count++;
                }
            }
            //In ra màn hình số lượng sinh viên thi đỗ với điểm >=5
            Console.Write("\n");
            Console.WriteLine("Total number of student passed: {0} ", count);
            Console.ReadKey();
        }
    }
}
