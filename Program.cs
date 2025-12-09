using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        RunApplication();
    }

    static void RunApplication()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Geometry Guru ===");
            Console.WriteLine("1. Aylana yuzasi");
            Console.WriteLine("2. To'g'ri to'rtburchak yuzasi");
            Console.WriteLine("3. Uchburchak - hisoblash va tomon oraliqlari");
            Console.WriteLine("4. Chiqish");
            Console.Write("Tanlovingiz (1-4): ");
            var choice = Console.ReadLine()?.Trim();

            switch (choice)
            {
                case "1":
                    CircleArea();
                    break;
                case "2":
                    RectangleArea();
                    break;
                case "3":
                    TriangleMenu();
                    break;
                case "4":
                    Console.WriteLine("Dasturdan chiqilyapti. Xayr!");
                    return;
                default:
                    Console.WriteLine("Noto'g'ri tanlov. Qayta urinib ko'ring.");
                    Pause();
                    break;
            }
        }
    }

    // Foydalanuvchidan double o'qish (har qanday lokalizatsiyadagi vergul/nuqta uchun moslash)
    static double ReadDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Qiymat bo'sh bo'lishi mumkin emas. Qayta kiriting.");
                continue;
            }

            // allow comma or dot as decimal separator
            input = input.Replace(',', '.');

            if (double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out double val))
            {
                return val;
            }
            Console.WriteLine("Noto'g'ri format. Iltimos son kiriting (masalan 12.5 yoki 12,5).");
        }
    }

    static void Pause()
    {
        Console.WriteLine("\nDavom etish uchun ENTER ni bosing...");
        Console.ReadLine();
    }

    static void CircleArea()
    {
        Console.Clear();
        Console.WriteLine("--- Aylana yuzasi ---");
        double r = ReadDouble("Aylana radiusini kiriting (r): ");
        if (r < 0)
        {
            Console.WriteLine("Radius manfiy bo'lishi mumkin emas.");
        }
        else
        {
            double area = Math.PI * r * r;
            Console.WriteLine($"Aylana yuzasi: {area:F4}");
        }
        Pause();
    }

    static void RectangleArea()
    {
        Console.Clear();
        Console.WriteLine("--- To'g'ri to'rtburchak yuzasi ---");
        double a = ReadDouble("Birinchi tomon (a): ");
        double b = ReadDouble("Ikkinchi tomon (b): ");
        if (a < 0 || b < 0)
        {
            Console.WriteLine("Tomon uzunligi manfiy bo'lishi mumkin emas.");
        }
        else
        {
            double area = a * b;
            Console.WriteLine($"To'g'ri to'rtburchak yuzasi: {area:F4}");
        }
        Pause();
    }

    static void TriangleMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--- Uchburchak bo'limi ---");
            Console.WriteLine("1. Uch tomon orqali (Heron formulasi)");
            Console.WriteLine("2. Asos va balandlik orqali");
            Console.WriteLine("3. Ikkita tomon berilganda uchinchi tomon oraliqlari");
            Console.WriteLine("4. Orqaga (asosiy menyu)");
            Console.Write("Tanlov (1-4): ");
            var t = Console.ReadLine()?.Trim();
            switch (t)
            {
                case "1":
                    TriangleByThreeSides();
                    break;
                case "2":
                    TriangleByBaseHeight();
                    break;
                case "3":
                    TriangleThirdSideRange();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Noto'g'ri tanlov.");
                    Pause();
                    break;
            }
        }
    }

    static void TriangleByThreeSides()
    {
        Console.Clear();
        Console.WriteLine("--- Uch tomon orqali (Heron) ---");
        double a = ReadDouble("a tomonini kiriting: ");
        double b = ReadDouble("b tomonini kiriting: ");
        double c = ReadDouble("c tomonini kiriting: ");

        if (!IsValidTriangle(a, b, c))
        {
            Console.WriteLine("Berilgan tomonlar bilan haqiqiy uchburchak hosil bo'lmaydi.");
            Console.WriteLine("Uchburchak bo'lishi uchun: har bir tomon boshqa ikkisi yig'indisidan kichik bo'lishi kerak (qattiq tengsizlik).");
        }
        else
        {
            double s = (a + b + c) / 2.0;
            double area = Math.Sqrt(Math.Max(0.0, s * (s - a) * (s - b) * (s - c)));
            Console.WriteLine($"Uchburchak yuzasi (Heron): {area:F4}");
        }
        Pause();
    }

    static void TriangleByBaseHeight()
    {
        Console.Clear();
        Console.WriteLine("--- Asos va balandlik orqali ---");
        double bas = ReadDouble("Asos (b): ");
        double h = ReadDouble("Balandlik (h): ");
        if (bas < 0 || h < 0)
        {
            Console.WriteLine("Asos yoki balandlik manfiy bo'lishi mumkin emas.");
        }
        else
        {
            double area = 0.5 * bas * h;
            Console.WriteLine($"Uchburchak yuzasi: {area:F4}");
        }
        Pause();
    }

    static void TriangleThirdSideRange()
    {
        Console.Clear();
        Console.WriteLine("--- Ikkita tomon berilganda uchinchi tomon oraliqlari ---");
        Console.WriteLine("Eslatma: uchburchak to'liq bo'lishi uchun uchinchi tomon t uchta cheklovga javob berishi kerak:");
        Console.WriteLine(" |a - b| < t < a + b   (agar teng bo'lsa, uchburchak deyarli chiziqli / degenerat bo'ladi).");

        double a = ReadDouble("Birinchi tomon (a): ");
        double b = ReadDouble("Ikkinchi tomon (b): ");

        if (a <= 0 || b <= 0)
        {
            Console.WriteLine("Tomonlar musbat bo'lishi kerak.");
            Pause();
            return;
        }

        double lower = Math.Abs(a - b);
        double upper = a + b;

        Console.WriteLine($"\nUchinchii tomon t uchun qat'iy oraliq:");
        Console.WriteLine($"  {lower:F4} < t < {upper:F4}");
        Console.WriteLine("Agar t = " + lower.ToString("F4") + " yoki t = " + upper.ToString("F4") + " bo'lsa, uchburchak degenerat (to'g'ri chiziqqa aylanadi).");

        // Ko'proq: agar foydalanuvchi misol uchun t qiymatini tekshirmoqchi bo'lsa
        Console.Write("Agar siz aniq t ni tekshirmoqchi bo'lsangiz, t kiriting yoki ENTER bilan o'ting: ");
        string? maybeT = Console.ReadLine()?.Trim();
        if (!string.IsNullOrEmpty(maybeT))
        {
            maybeT = maybeT.Replace(',', '.');
            if (double.TryParse(maybeT, NumberStyles.Float, CultureInfo.InvariantCulture, out double t))
            {
                if (t > lower && t < upper)
                    Console.WriteLine("Kiritilgan t qiymati haqiqiy (non-degenerat) uchburchak hosil qiladi.");
                else if (Math.Abs(t - lower) < 1e-12 || Math.Abs(t - upper) < 1e-12)
                    Console.WriteLine("Kiritilgan t qiymati degenerat uchburchak (uch nuqta bir chiziqda) hosil qiladi.");
                else
                    Console.WriteLine("Kiritilgan t qiymati bilan uchburchak hosil bo'lmaydi.");
            }
            else
            {
                Console.WriteLine("t qiymatini o'qishda xato.");
            }
        }

        Pause();
    }

    static bool IsValidTriangle(double a, double b, double c)
    {
        // qat'iy triangle inequality: har bir tomoni boshqa ikkisi yig'indisidan kichik bo'lishi kerak
        return a > 0 && b > 0 && c > 0
            && a < b + c
            && b < a + c
            && c < a + b;
    }
}
