using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dothimy
{
    class Program
    {  
      
        static void Main(string[] args)
        {
            int a;// chọn có chơi tiếp hay không
            do
            {
                Random ranDom = new Random();
                int soRanDom = ranDom.Next(0, 100);
                int soLanChoi = 0;
                int soNhap;
                do
                {
                    Console.OutputEncoding = Encoding.UTF8;
                    Console.WriteLine("số của chúng tôi : {0} ", soRanDom);
                    Console.WriteLine("Mời bạn chọn số ?");
                     soNhap = int.Parse(Console.ReadLine());
                 if(soNhap<0 || soNhap > 100)
                    {
                        do
                        {
                            Console.WriteLine("Mời bạn chọn lại, số bạn chọn phải thuộc từ 0--> 100");
                            Console.WriteLine("Mời bạn chọn số ?");
                            soNhap = int.Parse(Console.ReadLine());
                        } while (soNhap < 0 && soNhap > 100);
                    }
                    Console.WriteLine(" bạn chọn số : {0}", soNhap);

                    if (soRanDom == soNhap)
                    {
                        Console.WriteLine(" WoooooooW !!!!! ");
                        Console.WriteLine(" BẠN LÀ NGƯỜI CHIẾN THẮNG ");
                        break;
                    }
                    else
                    {
                        if (soNhap > soRanDom)
                        {
                            Console.WriteLine(" Rất tiếc đó chưa phải đáp án đúng ! ");
                            Console.WriteLine(" Số bạn chọn lớn hơn số của chúng tôi ");

                        }
                        else
                        {
                            Console.WriteLine(" Rất tiếc đó chưa phải đáp án đúng ! ");
                            Console.WriteLine(" Số bạn chọn nhỏ hơn số của chúng tôi ");

                        }
                        soLanChoi++;

                    }
                } while (soLanChoi != 6);

                if (soLanChoi == 6)
                {
                    Console.WriteLine(" BẠN ĐÃ THUA CUỘC ");
                }
                Console.WriteLine(" bạn có muốn tiếp tục chơi ? ");
                Console.WriteLine(" không ----->bấm 0  ");
                Console.WriteLine(" có -----> bấm 1 ");
                a = int.Parse(Console.ReadLine());
            } while (a == 1);
            Console.ReadLine();
        }
    }
}
