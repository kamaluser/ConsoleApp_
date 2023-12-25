using System;
using System.Threading;

namespace ConsoleApp_
{
    internal class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            // 1. Verilmiş yazıdan içində boşluqlar olmayan yeni bir yazı düzəltmək 

            #region Task1

            //Console.WriteLine("Yazini daxil et: ");
            //string text = Console.ReadLine();
            //string text2 = "";
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] != ' ')
            //        text2 += text[i];
            //}
            //Console.WriteLine(text2);

            #endregion

            // 2. Verilmiş ədədlər siyahısındaki verilmiş n ədədinin yerləşdiyi indexi tapan proqram

            #region Task2

            //Console.WriteLine("Ededler siyahisinin uzunlugunu daxil et: ");
            //int count = Convert.ToInt32(Console.ReadLine());
            //int[] nums = new int[count];
            //Console.WriteLine("Axtarilan ededi daxil et: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int result = -1;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine("Siyahidaki ededleri daxil et: ");
            //    nums[i] = Convert.ToInt32(Console.ReadLine());
            //    if (nums[i] == num)
            //    {
            //        result = i;
            //        break;
            //    }
            //}

            //if (result != -1)
            //{
            //    Console.WriteLine("Axtarılan eded " + num + " indeksi: " + result);
            //}
            //else
            //{
            //    Console.WriteLine("Axtarılan eded tapılmadı.");
            //}
            #endregion


            // 3. Verilmiş yazılar siyahısında verilmiş hərfdən neçə ədəd olduğunu tapan proqram


            #region Task3

            //Console.WriteLine("siyahidaki stringlerin sayini daxil edin: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] strings = new string[n];


            //Console.WriteLine("Axtarilan herfi daxil et: ");
            //char letter = Convert.ToChar(Console.ReadLine());
            //int count = 0;
            //for (int i = 0; i < strings.Length; i++)
            //{
            //    Console.WriteLine("stringi daxil et");
            //    strings[i] = Console.ReadLine();
            //    for (int j = 0; j < strings[i].Length; j++)
            //    {
            //        if (strings[i][j] == letter)
            //        {
            //            count++;
            //        }
            //    }
            //}
            //Console.WriteLine($"Axtarilan herfden siyahida {count} eded var");

            #endregion

            // 4. Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən proqram(Misalçün verilmiş yazı "   salam necesen?   " - dirsə yeni düzələcək string "salam necəsən?   " olmalıdır.

            #region Task4

            //Console.WriteLine("Yazini daxil et: ");
            //string yazi = Console.ReadLine();
            //int baslangicIndex = 0;
            //string yeniYazi = "";
            //for (int i = 0; i < yazi.Length; i++)
            //{
            //    if (yazi[i] != ' ')
            //    {
            //        baslangicIndex = i;
            //        break;
            //    }
            //}
            //for (int j = baslangicIndex; j < yazi.Length; j++)
            //{
            //    yeniYazi += yazi[j];
            //}
            //Console.WriteLine($"Deyisdirilmis yazi: {yeniYazi}");

            #endregion

            #region Task5

            // 5. Verilmiş 2 ədəd üzərində verilmiş simvola uyğun əməliyyat edən proqram. Simvol +,-,* və ya / olmalıdır, əks halda simvolu yenidən daxil edilməsi istənilməlidir.(Misaçün simvol * olarsa verilmiş 2 ədəd vurulacaq və nəticəsi göstəriləcək)

            #region Task5

            //Console.WriteLine("Ededleri daxil et: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //double result = 0;
            //bool check;
            //do
            //{
            //    Console.WriteLine("Emeliyyati daxil et: ");
            //    char emeliyyat = Convert.ToChar(Console.ReadLine());
            //    check = true;
            //switch (emeliyyat)
            //    {
            //        case '+':
            //            result = num1 + num2;
            //                Console.WriteLine(result);
            //                break;
            //        case '-':
            //            result = num1 - num2;
            //                Console.WriteLine(result);
            //                break;
            //        case '*':
            //            result = num1 * num2;
            //                Console.WriteLine(result);
            //                break;
            //        case '/':
            //                if (num2 != 0)
            //                {
            //                    result = num1 / num2;
            //                    Console.WriteLine(result);
            //                    break;
            //                }
            //                else { 
            //                    Console.WriteLine("0-a bolmek mumkun deyil");
            //                break;
            //                }
            //        default:
            //        check = false;
            //        Console.WriteLine("Emeliyyat duzgun deyil!");
            //        break;
            //    }
            //} while (check == false);

            #endregion
        }
    }
}
