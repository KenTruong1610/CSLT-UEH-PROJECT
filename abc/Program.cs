using System;
using System.Text;

namespace system
{
    class menu
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            while (true)
            {
                Console.WriteLine("\t\t\t\t\t\tĐỒ ÁN: CƠ SỞ LẬP TRÌNH");
                Console.WriteLine("\t\t\t\t\t\t NHÓM: 6, LỚP: IT0001");
                Console.WriteLine("\t\t\t\t\t\t   **************");
                Console.WriteLine("Thành viên");
                Console.WriteLine("1. Nguyễn Trường Duy");
                Console.WriteLine("2. Nguyễn Ngọc Thảo Nguyên");
                Console.WriteLine("3. Trịnh Thoại Tín");
                Console.WriteLine("4. Trương Thanh Việt Tùng");
                Console.WriteLine("5. Bài tập nhóm");
                Console.Write("==> Hãy chon thành viên để xem bài của họ: ");
                string chon = Console.ReadLine();
                switch (chon)
                {
                    case "1":
                        Console.WriteLine("Đây là các bài tập của Nguyễn Trường Duy");
                        chonbaitap1();
                        break;
                    case "2":
                        Console.WriteLine("Đây là các bài tập của Nguyễn Ngọc Thảo Nguyên");
                        chonbaitap2();
                        break;
                    case "3":
                        Console.WriteLine("Đây là các bài tập của Trịnh Thoại Tín");
                        chonbaitap3();
                        break;
                    case "4":
                        Console.WriteLine("Đây là các bài tập của Trương Thanh Việt Tùng");
                        chonbaitap4();
                        break;
                    case "5":
                        Console.WriteLine("Bài tập chung của nhóm ");
                        chonbainhom();
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại. ");
                        break;
                }
                Console.WriteLine();
            }
        }
        static void chonbaitap1()
        {
            Console.WriteLine();
            Console.WriteLine("1. Bài 9 phần 1 ");
            Console.WriteLine("2. Bài 9 phần 2 ");
            Console.WriteLine("3. Bài 9 phần 3 ");
            Console.Write("==> Hãy chọn bài bạn muốn xem: ");
            string chon1 = Console.ReadLine();
            switch (chon1)
            {
                case "1":
                    Console.WriteLine("Đây là nội dung Bài 9 Phần 1 ");
                    B9P1a();
                    break;
                case "2":
                    Console.WriteLine("Đây là nội dung Bài 9 Phần 2 ");
                    B9P2a();
                    break;
                case "3":
                    Console.WriteLine("Đây là nội dung Bài 9 Phần 3 ");
                    B9P3a();
                    break;
            }
        }
        static void chonbaitap2()
        {
            Console.WriteLine();
            Console.WriteLine("1. Bài 1 Phần 1 ");
            Console.WriteLine("2. Bài 1 Phần 2 ");
            Console.WriteLine("3. Bài 1 Phần 3 ");
            Console.Write("==> Hãy chọn bài bạn muốn xem: ");
            string chon2 = Console.ReadLine();
            switch (chon2)
            {
                case "1":
                    Console.WriteLine("Đây là nội dung Bài 1 Phần 1 ");
                    B1P1();
                    break;
                case "2":
                    Console.WriteLine("Đây là nội dung Bài 1 Phần 2 ");
                    B1P2();
                    break;
                case "3":
                    Console.WriteLine("Đây là nội dung Bài 1 Phần 3 ");
                    B1P3();
                    break;
            }
        }
        static void chonbaitap3()
        {
            Console.WriteLine();
            Console.WriteLine("1. Bài 9 Phần 1  ");
            Console.WriteLine("2. Bài 9 Phần 2 ");
            Console.WriteLine("3. Bài 9 Phần 3 ");
            Console.Write("==> Hãy chọn bài bạn muốn xem: ");
            string chon3 = Console.ReadLine();
            switch (chon3)
            {
                case "1":
                    Console.WriteLine("Đây là nội dung Bài 9 Phần 1 ");
                    B9P1b();
                    break;
                case "2":
                    Console.WriteLine("Đây là nội dung Bài 9 Phần 2 ");
                    B9P2b();
                    break;
                case "3":
                    Console.WriteLine("Đây là nội dung Bài 9 Phần 3 ");
                    B9P3b();
                    break;
            }
        }
        static void chonbaitap4()
        {
            Console.WriteLine();
            Console.WriteLine("1. Bài 4 Phần 1  ");
            Console.WriteLine("2. Bài 4 Phần 2  ");
            Console.WriteLine("3. Bài 4 Phần 3  ");
            Console.Write("==> Hãy chọn bài bạn muốn xem: ");
            string chon4 = Console.ReadLine();
            switch (chon4)
            {
                case "1":
                    Console.WriteLine("Đây là nội dung Bài 4 Phần 1");
                    B4P1();
                    break;
                case "2":
                    Console.WriteLine("Đây là nội dung Bài 4 Phần 2 ");
                    B4P2();
                    break;
                case "3":
                    Console.WriteLine("Đây là nội dung Bài 4 Phần 3 ");
                    B4P3();
                    break;
            }
        }
        static void B9P1a()
        {
            Console.WriteLine("Đây là bài 9 phần 1 ");
            Console.WriteLine("Để bắt đầu tính bán kính hình cầu.");
            Console.WriteLine("Hãy bắt đầu nhập số đo của hình hộp chữ nhật");
            Console.WriteLine("Với a là chiều dài:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Với b là chiều rộng:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Với c là chiều cao:");
            double c = double.Parse(Console.ReadLine());
            double r = Math.Cbrt((3 / (4 * Math.PI)) * a * b * c);
            Console.WriteLine("Bán kính của hình cầu là: {0}", r);
            Console.ReadLine();
        }
        static void B9P2a()
        {
            Console.WriteLine("Đây là bài 9 phần 2 ");
            int[] quacan = { 1, 2, 4, 8, 16, 32, 64, 128, 256 };
            int m;
            do
            {
                // Nhập trọng lượng của vật M
                Console.Write("Nhập trọng lượng của vật M (M < 512g): ");
                m = Convert.ToInt32(Console.ReadLine());

                // Kiểm tra điều kiện M
                if (m >= 512 || m < 0)
                {
                    Console.WriteLine("Trọng lượng của vật không hợp lệ. Hãy nhập lại.");
                }
            } while (m >= 512 || m < 0);

            Tinhcacquacan(m, quacan);
            Console.ReadLine();

        }
        static void Tinhcacquacan(int m, int[] quacan)
        {
            Console.WriteLine("Để cân được vật có trọng lượng {0}g", m);
            for (int i = quacan.Length - 1; i >= 0; i--)
            {
                if (m >= quacan[i])
                {
                    Console.WriteLine("Ta sử dụng quả cân {0}g", quacan[i]);
                    m -= quacan[i];
                }
            }
        }
        static void B9P3a()
        {
            Console.Write("Hãy nhập cấp của ma trận vuông:");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            Console.WriteLine("Hãy nhập giá trị cho ma trận:");
            Nhapmatran(matrix);
            if (HasDuplicateRows(matrix))
            {
                Console.WriteLine("Có hai hàng trùng nhau");
            }
            else
            {
                Console.WriteLine("Không có hàng nào trùng nhau");
            }
            Console.ReadLine();


            static void Nhapmatran(int[,] matrix)
            {
                int row = matrix.GetLength(0);
                int column = matrix.GetLength(1);
                for (int i = 0; i < row; i++)
                {
                    Console.WriteLine($"Hãy nhập vào giá trị của hàng {i + 1} ");
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write($"Giá trị [{i}, {j}] = ");
                        matrix[i, j] = Convert.ToInt32(Console.ReadLine());

                    }
                }
            }
        }

        // Hàm kiểm tra xem có hai hàng trùng nhau không
        static bool HasDuplicateRows(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = i + 1; j < rows; j++)
                {
                    // So sánh từng phần tử trong hai hàng
                    bool duplicate = true;
                    for (int k = 0; k < cols; k++)
                    {
                        if (matrix[i, k] != matrix[j, k])
                        {
                            duplicate = false;
                            break;
                        }
                    }

                    // Nếu hai hàng giống nhau, trả về true
                    if (duplicate)
                    {
                        Console.WriteLine($"Hai hàng {i + 1} và {j + 1} trùng nhau.");
                        return true;
                    }
                }
            }

            return false;

        }


        static void B9P1b()
        {
            Console.WriteLine("Đây là Bài 9 Phần 1 ");
            Console.WriteLine();
            Console.Write("Nhập chiều dài hình hộp chữ nhật a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập chiều rộng hình hộp chữ nhật b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhập chiều cao hình hộp chữ nhật c: ");
            double c = double.Parse(Console.ReadLine());
            double r = Math.Cbrt(3 / (4 * Math.PI) * (a * b * c));
            Console.WriteLine("Bán kính hình cầu là: {0} ", r);
            Console.ReadLine();
        }
        static void B9P2b()
        {
            Console.WriteLine("Đây là Bài 9 Phần 2 ");
            Console.WriteLine();
            Console.Write("Nhập trọng lượng cần cân (M < 512): ");
            int M = int.Parse(Console.ReadLine());
            if (M > 512)
            {
                Console.WriteLine("Vượt quá trọng lượng cho phép. Hãy nhập lại (<512)");
                return;
            }
            int[] quacan = { 1, 2, 4, 16, 32, 64, 128, 256 };
            int i = quacan.Length - 1;
            do
            {
                if (M >= quacan[i])
                {
                    Console.WriteLine("Các quả cân được sử dụng là: {0}g", quacan[i]);
                    M -= quacan[i];
                }

                i--;

            } while (M > 0 && i >= 0);
        }
        static void B9P3b()
        {
            Console.WriteLine("Đây là Bài 9 Phần 3 ");
            int n = int.Parse(Console.ReadLine());
            int[,] matran = new int[n, n];
            Console.WriteLine("Nhập giá trị cho ma trận:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Ma trận [{i}][{j}] = ");
                    matran[i, j] = int.Parse(Console.ReadLine());
                }
            }
            kiemtra(matran, n);
        }
        static void kiemtra(int[,] matran, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    bool trungnhau = true;
                    for (int k = 0; k < n; k++)
                    {
                        if (matran[i, k] != matran[j, k])
                        {
                            trungnhau = false; break;
                        }
                    }
                    if (trungnhau)
                    {
                        Console.WriteLine($"Hàng {i + 1} và Hàng {j + 1} trùng nhau. ");
                        return;
                    }
                }
            }
            Console.WriteLine("Không có hai hàng nào trùng nhau. ");
        }


        static void B1P1()
        {
            Console.WriteLine("Đây là Bài 1 Phần 1 ");
            Console.Write("Nhập a1: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("Nhập b1: ");
            double b1 = double.Parse(Console.ReadLine());
            Console.Write("Nhập c1: ");
            double c1 = double.Parse(Console.ReadLine());
            Console.Write("Nhập a2: ");
            double a2 = double.Parse(Console.ReadLine());
            Console.Write("Nhập b2: ");
            double b2 = double.Parse(Console.ReadLine());
            Console.Write("Nhập c2: ");
            double c2 = double.Parse(Console.ReadLine());
            double x, y, d, dx, dy;
            // đặt
            d = a1 * b2 - a2 * b1;
            dx = c1 * b2 - c2 * b1;
            dy = a1 * c2 - a2 * c1;
            // giải
            if (d != 0)
            {
                x = dx / d;
                y = dy / d;
                Console.WriteLine("Hệ có một nghiệm: x={0}, y={1}", x, y);
            }
            else if (d == 0 && dx != 0)
            {
                Console.WriteLine("Hệ phương trình vô nghiệm");
            }
            else if (d == 0 && dx == 0)
            {
                Console.WriteLine("Hệ phương trình có vô số nghiệm");
            }
            Console.ReadLine();
        }
        static void B1P2()
        {
            Console.WriteLine("Đây là Bài 1 Phần 2 ");
            Console.Write("Nhập số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"a[{i}] = {A[i]}");
            }
            Console.Write("Nhập số nguyên X: ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("Vị trí của X trong mảng là: ");
            for (int i = 0; i < n; i++)
            {
                if (A[i] == X)
                {
                    Console.WriteLine("{0}", i); break;
                }
            }
        }
        static void B1P3()
        {
            Console.WriteLine("Đây là Bài 1 Phần 3 ");
            Console.Write("Nhập số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"a[{i}] = {A[i]}");
            }
            Console.Write("Nhập số nguyên X: ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("Vị trí của X trong mảng là: ");
            for (int i = 0; i < n; i++)
            {
                if (A[i] == X)
                {
                    Console.WriteLine("{0}", i); break;
                }
            }
        }
        static void B4P1()
        {
            Console.WriteLine("Đây là Bài 4 Phần 1 ");
            Console.Write("Nhập số a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập số b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhập số c: ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Vô nghiệm!");
                }
                else
                {
                    double delta_1 = (double)(-4 * b * c);
                    if (delta_1 < 0)
                    {
                        Console.WriteLine("Vô nghiệm!");
                    }
                    else if (delta_1 == 0)
                    {
                        Console.WriteLine("Phương trình có 1 nghiệm: x = 0");
                    }
                    else
                    {
                        double x1 = (double)(Math.Sqrt(delta_1) / (2 * b));
                        double x2 = (double)(-Math.Sqrt(delta_1) / (2 * b));

                        Console.WriteLine("Phương trình có 2 nghiệm phân biệt: ");
                        Console.WriteLine("x1 = {0}", x1);
                        Console.WriteLine("x2 = {0}", x2);
                    }
                }

            }
            else
            {
                double delta_2 = (double)(Math.Pow(b, 2) - 4 * a * c);
                if (delta_2 < 0)
                {
                    Console.WriteLine("Vô nghiệm!");
                }
                else if (delta_2 == 0)
                {
                    double y = (double)(-b / (2 * a));
                    double x = Math.Sqrt(y);
                    if (y < 0)
                    {
                        Console.WriteLine("Vô nghiệm!");
                    }
                    else
                    {
                        Console.WriteLine("Phương trình có hai nghiệm:");
                        Console.WriteLine("x1 = ", x);
                        Console.WriteLine("x2 = ", -x);
                    }
                }
                else
                {
                    double y1 = (double)((-b + Math.Sqrt(delta_2)) / (2 * a));
                    double y2 = (double)((-b - Math.Sqrt(delta_2)) / (2 * a));
                    double x1 = Math.Sqrt(y1);
                    double x2 = Math.Sqrt(y2);
                    if (y1 < 0 && y2 < 0)
                    {
                        Console.WriteLine("Vô nghiệm!");
                    }

                    else if (y1 >= 0 && y2 < 0)
                    {
                        Console.WriteLine("Phương trình có hai nghiệm: ");
                        Console.WriteLine("x1 = {0}", x1);
                        Console.WriteLine("x2 = {0}", -x1);
                    }

                    else if (y2 >= 0 && y1 < 0)
                    {
                        Console.WriteLine("Phương trình có hai nghiệm: ");
                        Console.WriteLine("x1 = {0}", x2);
                        Console.WriteLine("x2 = {0}", -x2);
                    }

                    else
                    {
                        Console.WriteLine("Phương trình có bốn nghiệm: ");
                        Console.WriteLine("x1 = {0}", x1);
                        Console.WriteLine("x2 = {0}", -x1);
                        Console.WriteLine("x3 = {0}", x2);
                        Console.WriteLine("x4 = {0}", -x2);
                    }
                }
            }
            Console.ReadKey();
        }

        static void B4P2()
        {
            Console.WriteLine("Đây là Bài 4 Phần 2 ");
            Console.Write("Nhập số hàng của ma trận: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập số cột của ma trận: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] matrix = new double[m, n];

            Console.WriteLine("Nhập các phần tử của ma trận:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("matrix[{0},{1}] = ", i, j);
                    matrix[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            double[,] transposeMatrix = new double[n, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    transposeMatrix[j, i] = matrix[i, j];
                }
            }

            Console.WriteLine("Ma trận chuyển vị:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(transposeMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void B4P3()
        {
            Console.WriteLine("Đây là Bài 4 Phần 3 ");
            Console.Write("Nhập số hàng m: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập số cột n: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            Console.WriteLine("\nNhập các phần tử của ma trận:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Nhập phần tử tại vị trí [{i},{j}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols / 2; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, cols - j - 1];
                    matrix[i, cols - j - 1] = temp;
                }
            }

            Console.WriteLine("\nMa trận sau khi hoán đổi:");
            PrintMatrix(matrix, rows, cols);
        }

        static void PrintMatrix(int[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void chonbainhom()
        {

            int n;

            while (true)
            {
                Console.Write("Nhập số lượng sinh viên: ");
                if (int.TryParse(Console.ReadLine(), out n)) // out n ở đây dùng để xác định xem dạng dữ liệu nhập vào có đúng hay không
                {
                    if (n >= 5)
                    {
                        break; // Kết thúc vòng lặp khi n đủ lớn
                    }
                    else
                    {
                        Console.WriteLine("Không hợp lệ, hãy nhập lại. Số lượng sinh viên ít nhất phải là 5.");
                    }
                }
                else
                {
                    Console.WriteLine("Không hợp lệ, hãy nhập lại. Vui lòng nhập một số nguyên.");
                }
            }

            string[,] thongtinsv = new string[n, 4];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin của sinh viên thứ {i + 1}:");
                Console.Write("Họ và tên: ");
                thongtinsv[i, 0] = Console.ReadLine();

                Console.Write("Năm sinh: ");
                thongtinsv[i, 1] = Console.ReadLine();

                Console.Write("Điểm trung bình: ");
                thongtinsv[i, 2] = Console.ReadLine();

                Console.Write("Xếp loại (Giỏi/Khá/Trung bình): ");
                thongtinsv[i, 3] = Console.ReadLine();
            }



            Sapxepthuhang(thongtinsv, n);

            Console.WriteLine("------------------------");


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nBẢNG ĐIỂM TỐT NGHIỆP");
                Console.WriteLine($"Cấp cho sinh viên {thongtinsv[i, 0]}, năm sinh {thongtinsv[i, 1]}.");
                Console.WriteLine($"Trong kì thì tốt nghiệp 2021, sinh viên trên đã đạt điểm trung bình là {thongtinsv[i, 2]}, và được xếp loại {thongtinsv[i, 3]}.");
                Console.WriteLine($"Sinh viên có thứ hạng {i + 1} trong lớp\n");
                Console.WriteLine("------------------------");
            }

        }

        static void Sapxepthuhang(string[,] data, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    double diem1 = Convert.ToDouble(data[i, 2]);
                    double diem2 = Convert.ToDouble(data[j, 2]);

                    if (diem1 < diem2)
                    {

                        for (int k = 0; k < 4; k++)
                        {
                            string temp = data[i, k];
                            data[i, k] = data[j, k];
                            data[j, k] = temp;
                        }
                    }
                }
            }
        }
    }
}

