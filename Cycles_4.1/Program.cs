// задание 3
//int.TryParse(Console.ReadLine(), out int chas);
//int ameba = 1;
//for(int i = 0; i<chas ; i+=3)
//{
//    ameba = ameba * 2;
//}
//Console.WriteLine(ameba);

//задание 5
//for (int i = 0; i <= 64; i += 4)
//{
//    Console.WriteLine("Кролики: " + i / 4 + "Гуси: " + (64 - i) / 2);
//}

//задача 6

//for (int b = 0; b <= 10; b++)
//{
//    for (int k = 0; k <= 20; k++)
//    {
//        for (int t = 0; t <= 200; t++)
//        {
//            if ((b * 10 + k * 5 + t * 0.5) == 100 && (b + k + t == 100))
//            {
//                Console.WriteLine(b);
//                Console.WriteLine(k);
//                Console.WriteLine(t);

//            }
//        }
//    }
//}

//задание 7
//for (int a = 0; a < 2; a++)
//{
//    for (int b = 0; b < 2; b++)
//    {
//        for (int c = 0; c < 2; c++)
//        {
//            if ((a + b) == (b + a))
//            {
//                Console.WriteLine("true");
//            }
//            else { Console.WriteLine("false"); }


//        }
//    }
//}

//задача 8
//int result;
//for (int x = 0; x<=15;  x++)
//{
//    result = x * x + x + 17;
//    bool sistem = true;
//    for (int y = 2; y< result; y++)
//    {
//        if (result % y == 0)
//            sistem = false;
//    }
//    if (sistem)
//        Console.WriteLine("Простое " + result);
//    else
//        Console.WriteLine("Не простое " + result);
//}

//задача 9
//int result;
//for (int x = 0; x <= 40; x++)
//{
//    result = x * x + x + 41;
//    bool sistem = true;
//    for (int y = 2; y < result; y++)
//    {
//        if (result % y == 0)
//            sistem = false;
//    }
//    if (sistem)
//        Console.WriteLine("Простое " + result);
//    else
//        Console.WriteLine("Не простое " + result);
//}

//задача 10
//int result;
//for (int x = 0; x <= 28; x++)
//{
//    result = 2 * x * x + 29;
//    bool sistem = true;
//    for (int y = 2; y < result; y++)
//    {
//        if (result % y == 0)
//            sistem = false;
//    }
//    if (sistem)
//        Console.WriteLine("Простое " + result);
//}

//задача 11
//double result;
//for (int x = 0; x <= 36; x++)
//{
//    result = (Math.Pow(2, 2 * x + 1) + 1) / 3;
//    bool sistem = true;
//    for (int y = 2; y < result; y++)
//    {
//        if (result % y == 0)
//            sistem = false;
//    }
//    if (sistem)
//        Console.WriteLine("Простое " + result);
//}

//задача 12
//double. TryParse(Console.ReadLine(), out double k);

//for(int m = 1; m <k; m++)
//{
//    for(int n = 1; n <k; n++)
//    {
//        double a = Math.Pow(m,2) - Math.Pow(n,2);
//        double b = 2 * m * n;
//        double c = Math.Pow(m, 2) + Math.Pow(n, 2);

//        if (Math.Pow(c, 2) == (Math.Pow(a, 2)) + Math.Pow(b, 2))
//        {
//            Console.WriteLine(m + " " + n + " " + a + " " + b + " " + c);
//        }
//    }
//}

//задача 13
//int.TryParse(Console.ReadLine(), out int S);

//int k10 = 0;
//int k50 = 0;
//int k100 = 0;
//int k500 = 0;
//int k1000 = 0;
//int k5000 = 0;

//for(;S >=5000;k5000 = k5000 + 1)
//{
//    S = S - 5000;
//    ;
//}
//while(S>= 1000)
//{
//    S = S - 1000;
//    k1000 = k1000 + 1;
//}
//while (S >= 500)
//{
//    S = S - 500;
//    k500 = k500 + 1;
//}
//while (S >= 100)
//{
//    S = S - 100;
//    k100 = k100 + 1;
//}
//while (S >= 50)
//{
//    S = S - 50;
//    k50 = k50 + 1;
//}
//while (S >= 10)
//{
//    S = S - 10;
//    k10 = k10 + 1;
//}

//Console.WriteLine("5000: " + k5000);
//Console.WriteLine("1000: " + k1000);
//Console.WriteLine("500: " + k500);
//Console.WriteLine("100: " + k100);
//Console.WriteLine("50: " + k50);
//Console.WriteLine("10: " + k10);

//задача 14
//double.TryParse(Console.ReadLine(), out double A);
//double.TryParse(Console.ReadLine(), out double B);
//double bSumma = 0;
//for (int m = 1; m <= 10; m++)
//{
//    bSumma += B;
//    if (B > A)
//       B = B + B / 100 * 3;
//}
//double Roditeli = bSumma - A*10;
//Console.WriteLine(Roditeli);

//задача 15
//for(int i = 1; i < 10; i++)
//{
//    for(int j = 1; j < 10; j++)
//    {
//        Console.Write(i * j + "\t");
//    }
//    Console.WriteLine();
//}
//for (int i = 1; i < 10; i++)
//{
//    for (int j = 1; j < 10; j++)
//    {
//        Console.Write(i + j + "\t");
//    }
//    Console.Write("\n");
//}

//задача 16
//int n = 16;
//for(int i = 1; i < n; i++)
//{
//    for(int j = 1; j < n; j++)
//    {
//        Console.Write((i * j) / 4 + "\t");
//    }
//    Console.Write("\n");
//}

//for (int i = 1; i < n; i++)
//{
//    for (int j = 1; j < n; j++)
//    {
//        Console.Write(((i + j)).ToString("X") + "\t");
//    }
//    Console.Write("\n");
//}

//задача 17
//int.TryParse(Console.ReadLine(), out int k);
//int summa = 0;
//for (int n = 1; n <= 4; n++)
//{
//    summa += n;
//}
//Console.WriteLine(summa);

//задание 18
//int.TryParse(Console.ReadLine(), out int k);
//int summa = 0;
//for (int n = 1; n <= 4; n++)
//{
//    if(n%k == 0)
//    {
//        summa = summa + n;
//    }
//}
//Console.WriteLine(summa);

//задание 19
//int summa = 0;
//int.TryParse(Console.ReadLine(), out int n);

//for(int i = 1; i <= n; i++)
//{
//    summa = summa + i;
//}
//int s = summa;
//Console.WriteLine(s);
//for (int i =1; i<=n; i++)
//{
//    //summa = summa + i;
//    if ((Math.Pow(i,5)+ Math.Pow(i,7)) == 2 * Math.Pow(s, 4))
//    {
//        Console.WriteLine("YES");
//    }
//    else Console.WriteLine("NO");
//}

//Никитина Алёна и Залевская Полина
