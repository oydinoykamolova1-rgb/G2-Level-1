using N18_HT1;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// UI: Bannerni chiqar
QuizDisplay.PrintBanner();

// Savol sonini so'ra
Console.Write("Nechta savol ishlashni xohlaysiz? (minimum 3): ");
int totalQuestions;
if (!int.TryParse(Console.ReadLine(), out totalQuestions) || totalQuestions < 3)
{
    totalQuestions = 5;
    Console.WriteLine("Standart: 5 savol tanlanadi.");
}

Console.WriteLine("\nTest boshlanmoqda... Omad!\n");

// Dvigatel (mantiq) obyektini yaratamiz
QuizEngine engine = new QuizEngine();

// ===================== ASOSIY TEST SIKLI =====================
for (int i = 1; i <= totalQuestions; i++)
{
    // 1. Joriy darajaga mos savol ol
    string question, answer;
    engine.GetNextQuestion(out question, out answer);

    // 2. Savol sarlavhasini chiqar (raqam + daraja badge)
    QuizDisplay.PrintQuestionHeader(i, totalQuestions, engine.CurrentLevel);
    Console.WriteLine("\n  " + question + "\n");

    // 3. Foydalanuvchi javobini ol
    Console.Write("  Javobingiz: ");
    string userInput = (Console.ReadLine() ?? "").Trim();

    // 4. Javobni tekshir
    bool isCorrect = engine.CheckAnswer(userInput, answer);

    // 5. Holatni yangilash — daraja o'zgardimi?
    bool levelChanged = engine.UpdateState(isCorrect);

    // 6. Daraja o'zgargan bo'lsa xabardor qil (yangi darajani ko'rsat)
    if (levelChanged)
        QuizDisplay.PrintLevelChange(engine.CurrentLevel);

    // 7. Javob natijasini chiqar
    QuizDisplay.PrintAnswerResult(isCorrect, answer);

    // 8. Joriy progressni chiqar
    QuizDisplay.PrintProgress(engine.TotalCorrect, engine.TotalAnswered);
}

// ===================== YAKUNIY NATIJA =====================
QuizDisplay.PrintFinalResults(engine.TotalCorrect, totalQuestions);