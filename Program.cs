// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Matematika o'yini");
//         Console.WriteLine("Sizdan quyidagi misollarga to'g'ri javoblar berishingiz talab qilinadi.");

//         int totalMisol = 10;
//         int togriJavoblar = 0;
//         int xatoJavoblar = 0;

//         Random random = new Random();

//         for (int i = 1; i <= totalMisol; i++)
//         {
//             int son1 = random.Next(1, 11);
//             int son2 = random.Next(1, 11);
//             int togriJavob = son1 + son2;

//             Console.Write($"Misol #{i}: {son1} + {son2} = ");
//             int foydalanuvchiJavobi;

//             if (int.TryParse(Console.ReadLine(), out foydalanuvchiJavobi))
//             {
//                 if (foydalanuvchiJavobi == togriJavob)
//                 {
//                     Console.WriteLine("To'g'ri!");
//                     togriJavoblar++;
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Noto'g'ri! To'g'ri javob {togriJavob} bo'lishi kerak.");
//                     xatoJavoblar++;
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Noto'g'ri kiritish! Butun son kiriting.");
//                 xatoJavoblar++;
//             }
//         }

//         Console.WriteLine("-----------------------------");
//         Console.WriteLine("Natijalar:");
//         Console.WriteLine($"Jami misollar soni: {totalMisol}");
//         Console.WriteLine($"To'g'ri javoblar soni: {togriJavoblar}");
//         Console.WriteLine($"Xato javoblar soni: {xatoJavoblar}");

//         Console.ReadLine();
//     }
// }

// ! 2chi vaersiya
// using System;
// using System.Threading;
// using System.Diagnostics;


// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Matematika o'yini");
//         Console.WriteLine("Sizdan quyidagi misollarga to'g'ri javoblar berishingiz talab qilinadi.");

//         int totalMisol = 10;
//         int togriJavoblar = 0;
//         int xatoJavoblar = 0;
//         TimeSpan timeLimit = TimeSpan.FromSeconds(30);

//         Random random = new Random();

//         for (int i = 1; i <= totalMisol; i++)
//         {
//             int son1 = random.Next(1, 11);
//             int son2 = random.Next(1, 11);
//             int togriJavob = 0;
//             int amal;

//             Console.WriteLine($"Misol #{i}:");
//             Console.WriteLine($"Son1: {son1}");
//             Console.WriteLine($"Son2: {son2}");
//             Console.WriteLine("Amalni tanlang:");
//             Console.WriteLine("1. Qo'shish (+)");
//             Console.WriteLine("2. Ayrish (-)");
//             Console.WriteLine("3. Ko'paytirish (*)");
//             Console.WriteLine("4. Bo'lish (/)");
//             Console.Write("Tanlovni kiriting (1, 2, 3 yoki 4): ");

//             if (!int.TryParse(Console.ReadLine(), out amal) || amal < 1 || amal > 4)
//             {
//                 Console.WriteLine("Noto'g'ri tanlov! Dasturni to'xtating.");
//                 Console.ReadLine();
//                 return;
//             }

//             switch (amal)
//             {
//                 case 1:
//                     togriJavob = son1 + son2;
//                     break;
//                 case 2:
//                     togriJavob = son1 - son2;
//                     break;
//                 case 3:
//                     togriJavob = son1 * son2;
//                     break;
//                 case 4:
//                     togriJavob = son1 / son2;
//                     break;
//             }

//             Console.Write($"Javobingizni kiriting: ");
//             int foydalanuvchiJavobi;

//             if (int.TryParse(Console.ReadLine(), out foydalanuvchiJavobi))
//             {
//                 if (foydalanuvchiJavobi == togriJavob)
//                 {
//                     Console.WriteLine("To'g'ri!");
//                     togriJavoblar++;
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Noto'g'ri! To'g'ri javob {togriJavob} bo'lishi kerak.");
//                     xatoJavoblar++;
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Noto'g'ri kiritish! Butun son kiriting.");
//                 xatoJavoblar++;
//             }

//             Console.WriteLine("-----------------------------");

//             if (DateTime.Now - Process.GetCurrentProcess().StartTime > timeLimit)
//             {
//                 Console.WriteLine("Vaqt tugadi! Dasturni to'xtating.");
//                 Console.ReadLine();
//                 return;
//             }
//         }

//         Console.WriteLine("Natijalar:");
//         Console.WriteLine($"Jami misollar soni: {totalMisol}");
//         Console.WriteLine($"To'g'ri javoblar soni: {togriJavoblar}");
//         Console.WriteLine($"Xato javoblar soni: {xatoJavoblar}");

//         Console.ReadLine();
//     }
// }
// ! 3chi versiya

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Matematika o'yini");
        Console.WriteLine("Sizdan quyidagi misollarga to'g'ri javoblar berishingiz talab qilinadi.");
        Console.WriteLine("O'yin bo'shlanganda foydalanuvchiga amal tanlash imkoniyati beriladi va shunga bog'liq 10 ta misol beriladi.");

        int totalMisol = 10;
        int togriJavoblar = 0;
        int xatoJavoblar = 0;
        Random random = new Random();

        Console.WriteLine("Amallar:");
        Console.WriteLine("1 - Qo'shish (+)");
        Console.WriteLine("2 - Ayrish (-)");
        Console.WriteLine("3 - Ko'paytirish (*)");
        Console.WriteLine("4 - Bo'lish (/)");

        Console.Write("Amalni tanlang (1-4): ");
        int amal = int.Parse(Console.ReadLine());

        for (int i = 1; i <= totalMisol; i++)
        {
            int son1 = random.Next(1, 11);
            int son2 = random.Next(1, 11);
            int togriJavob = 0;

            Console.WriteLine($"Misol #{i}:");
            Console.WriteLine($"Son1: {son1}");
            Console.WriteLine($"Son2: {son2}");
            Console.WriteLine($"Amal: {AmalNominiOlish(amal)}");

            switch (amal)
            {
                case 1:
                    togriJavob = son1 + son2;
                    break;
                case 2:
                    togriJavob = son1 - son2;
                    break;
                case 3:
                    togriJavob = son1 * son2;
                    break;
                case 4:
                    togriJavob = son1 / son2;
                    break;
            }

            Console.Write($"Javobingizni kiriting: ");
            int foydalanuvchiJavobi;

            if (int.TryParse(Console.ReadLine(), out foydalanuvchiJavobi))
            {
                if (foydalanuvchiJavobi == togriJavob)
                {
                    Console.WriteLine("To'g'ri!");
                    togriJavoblar++;
                }
                else
                {
                    Console.WriteLine($"Noto'g'ri! To'g'ri javob {togriJavob} bo'lishi kerak.");
                    xatoJavoblar++;
                }
            }
            else
            {
                Console.WriteLine("Noto'g'ri kiritish! Butun son kiriting.");
                xatoJavoblar++;
            }

            Console.WriteLine("-----------------------------");
        }

        Console.WriteLine("Natijalar:");
        Console.WriteLine($"Jami misollar soni: {totalMisol}");
        Console.WriteLine($"To'g'ri javoblar soni: {togriJavoblar}");
        Console.WriteLine($"Xato javoblar soni: {xatoJavoblar}");

        Console.ReadLine();
    }

    static string AmalNominiOlish(int amal)
    {
        switch (amal)
        {
            case 1:
                return "+";
            case 2:
                return "-";
            case 3:
                return "*";
            case 4:
                return "/";
            default:
                return "";
        }
    }
}
