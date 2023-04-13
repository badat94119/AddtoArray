using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array; // khai báo mảng
        int n, x, index;

        Console.Write("Nhập số phần tử của mảng: ");
        n = int.Parse(Console.ReadLine());

        // khởi tạo mảng với n phần tử
        array = new int[n];

        // nhập giá trị cho mảng
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Nhập giá trị cần chèn (X): ");
        x = int.Parse(Console.ReadLine());

        Console.Write("Nhập vị trí cần chèn (index): ");
        index = int.Parse(Console.ReadLine());

        // kiểm tra điều kiện index hợp lệ
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Không thể chèn phần tử vào mảng.");
        }
        else
        {
            // chèn phần tử vào mảng
            Array.Resize(ref array, array.Length + 1);
            for (int i = array.Length - 1; i > index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = x;

            Console.Write("Mảng sau khi chèn: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        Console.ReadKey();
    }
}
