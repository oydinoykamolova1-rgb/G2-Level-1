namespace N18_HT1;

public class QuizEngine
{
    // ===================== XUSUSIY MAYDONLAR =====================


    private DifficultyLevel _currentLevel;
    private int _consecutiveCorrect;
    private int _consecutiveWrong;
    private int _totalAnswered;
    private int _totalCorrect;
    private readonly Random _rng;

    // ===================== XUSUSIYATLAR (Properties) =====================

    public DifficultyLevel CurrentLevel { get { return _currentLevel; } }
    public int TotalAnswered { get { return _totalAnswered; } }
    public int TotalCorrect { get { return _totalCorrect; } }

    // ===================== KONSTRUKTOR =====================

    public QuizEngine()
    {
        _currentLevel = DifficultyLevel.Standart;
        _consecutiveCorrect = 0;
        _consecutiveWrong = 0;
        _totalAnswered = 0;
        _totalCorrect = 0;
        _rng = new Random();
    }

    // ===================== SAVOL TANLASH =====================

    // Joriy darajaga mos savolni qaytaradi
    public void GetNextQuestion(out string question, out string answer)
    {
        Dictionary<string, string> pool = QuestionBank.GetPool(_currentLevel);

        // Pool bo'sh bo'lsa standartga qayt (ehtiyot sharti)
        if (pool == null || pool.Count == 0)
            pool = QuestionBank.StandardQuestions;

        int index = _rng.Next(pool.Count);
        var entry = pool.ElementAt(index);
        question = entry.Key;
        answer = entry.Value;
    }

    // ===================== JAVOBNI TEKSHIRISH =====================

    // Katta-kichik harfga sezgir emas, qisman moslikni qabul qiladi
    public bool CheckAnswer(string userInput, string correctAnswer)
    {
        if (string.IsNullOrWhiteSpace(userInput))
            return false;

        return userInput.IndexOf(correctAnswer, StringComparison.OrdinalIgnoreCase) >= 0
            || correctAnswer.IndexOf(userInput, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    // ===================== HOLAT YANGILASH =====================

    // Javob natijasiga qarab statistika va darajani yangilaydi.
    // Daraja o'zgargan bo'lsa true qaytaradi (UI uchun)
    public bool UpdateState(bool isCorrect)
    {
        _totalAnswered++;
        bool levelChanged = false;

        if (isCorrect)
        {
            _totalCorrect++;
            _consecutiveCorrect++;
            _consecutiveWrong = 0;

            // 2 ta ketma-ket to'g'ri → daraja ko'tariladi
            if (_consecutiveCorrect >= 2 && _currentLevel != DifficultyLevel.Hard)
            {
                _currentLevel = (_currentLevel == DifficultyLevel.Easy)
                    ? DifficultyLevel.Standart
                    : DifficultyLevel.Hard;

                _consecutiveCorrect = 0;
                levelChanged = true;
            }
        }
        else
        {
            _consecutiveWrong++;
            _consecutiveCorrect = 0;

            // 2 ta ketma-ket xato → daraja tushadi
            if (_consecutiveWrong >= 2 && _currentLevel != DifficultyLevel.Easy)
            {
                _currentLevel = (_currentLevel == DifficultyLevel.Hard)
                    ? DifficultyLevel.Standart
                    : DifficultyLevel.Easy;

                _consecutiveWrong = 0;
                levelChanged = true;
            }
        }

        return levelChanged;
    }

    // ===================== STATISTIKA =====================

    public int GetScorePercent()
    {
        return _totalAnswered > 0
            ? (_totalCorrect * 100 / _totalAnswered)
            : 0;
    }

    public double GetScorePercentDouble(int total)
    {
        return total > 0
            ? (double)_totalCorrect / total * 100.0
            : 0.0;
    }
}
