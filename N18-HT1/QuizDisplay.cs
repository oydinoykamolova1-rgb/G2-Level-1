namespace N18_HT1;

public static class QuizDisplay
{
    // ===================== BANNER =====================

    public static void PrintBanner()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("╔══════════════════════════════════════════════════╗");
        Console.WriteLine("║        ADAPTIVE GEOGRAPHY QUIZ                   ║");
        Console.WriteLine("║     Dinamik qiyinlik darajasi bilan test         ║");
        Console.WriteLine("╚══════════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("  Qoidalar:");
        Console.WriteLine("  • 2 ta ketma-ket XATO    --> savol OSONLASHADI");
        Console.WriteLine("  • 2 ta ketma-ket TO'G'RI --> savol QIYINLASHADI");
        Console.WriteLine();
    }

    // ===================== SAVOL SARLAVHASI =====================

    public static void PrintQuestionHeader(int current, int total, DifficultyLevel level)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\n  --------------------------------------------------");
        Console.ResetColor();

        Console.Write("  Savol #{0}/{1}  ", current, total);
        PrintLevelBadge(level);
        Console.WriteLine();
    }

    // ===================== DARAJA BADGE =====================

    public static void PrintLevelBadge(DifficultyLevel level)
    {
        if (level == DifficultyLevel.Easy)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[OSON]");
        }
        else if (level == DifficultyLevel.Hard)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[QIYIN]");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[STANDART]");
        }
        Console.ResetColor();
    }

    // ===================== DARAJA O'ZGARISHI =====================

    public static void PrintLevelChange(DifficultyLevel newLevel)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        if (newLevel == DifficultyLevel.Easy)
            Console.WriteLine("  [v] Daraja pasaydi --> OSON savollar");
        else if (newLevel == DifficultyLevel.Hard)
            Console.WriteLine("  [^] Daraja ko'tarildi --> QIYIN savollar");
        else
            Console.WriteLine("  [~] Daraja o'zgardi --> STANDART savollar");
        Console.ResetColor();
    }

    // ===================== JAVOB NATIJASI =====================

    public static void PrintAnswerResult(bool isCorrect, string correctAnswer)
    {
        if (isCorrect)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  [+] To'g'ri javob!\n");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  [-] Noto'g'ri! To'g'ri javob: " + correctAnswer + "\n");
        }
        Console.ResetColor();
    }

    // ===================== JORIY PROGRESS =====================

    public static void PrintProgress(int correct, int answered)
    {
        int percent = answered > 0 ? (correct * 100 / answered) : 0;
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("  Joriy natija: {0}/{1}  ({2}%)", correct, answered, percent);
        Console.ResetColor();
    }

    // ===================== YAKUNIY NATIJA =====================

    public static void PrintFinalResults(int correct, int total)
    {
        double percent = total > 0 ? (double)correct / total * 100.0 : 0;

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\n  ==================================================");
        Console.WriteLine("                 YAKUNIY NATIJA");
        Console.WriteLine("  ==================================================");
        Console.ResetColor();

        Console.WriteLine("  To'g'ri javoblar : {0} / {1}", correct, total);
        Console.WriteLine("  Foiz             : {0}%", percent.ToString("F1"));

        string grade;
        if (percent >= 80)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            grade = "Ajoyib! Siz geografiyani yaxshi bilasiz!";
        }
        else if (percent >= 50)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            grade = "Yaxshi! Biroz mashq qiling.";
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            grade = "Ko'proq o'qish kerak. Harakat qiling!";
        }

        Console.WriteLine("\n  " + grade);
        Console.ResetColor();
        Console.WriteLine("\n  ==================================================\n");
    }
}
