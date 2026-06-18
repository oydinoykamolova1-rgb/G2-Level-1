namespace N18_HT1;

public class QuestionBank
{
    public static readonly Dictionary<string, string> StandardQuestions = new Dictionary<string, string>
        {
            { "Avstraliyaning poytaxti qaysi shahar?",                     "Kanberra"    },
            { "Janubiy Amerikadagi eng uzun daryo qaysi?",                 "Amazon"      },
            { "Qaysi qit'a 'Pastki Qit'a' nomi bilan mashhur?",           "Avstraliya"  },
            { "Saxara cho'li qaysi qit'ada joylashgan?",                  "Afrika"      },
            { "Yevropa Alp tog'laridagi eng baland cho'qqi qaysi?",       "Mon Blan"    }
        };

    public static readonly Dictionary<string, string> EasyQuestions = new Dictionary<string, string>
        {
            { "Dunyodagi eng katta orol qaysi?",                          "Grenlandiya" },
            { "Afrikadagi eng katta ko'l qaysi?",                         "Viktoriya"   },
            { "Yer maydoni bo'yicha dunyodagi eng kichik davlat qaysi?",  "Vatikan"     }
        };

    public static readonly Dictionary<string, string> HardQuestions = new Dictionary<string, string>
        {
            { "Dunyodagi eng katta marjon rifi tizimi qaysi mamlakatda?",              "Avstraliya"      },
            { "Dunyodagi eng chuqur okean xandagi qaysi?",                             "Mariana"         },
            { "Milodiy 79-yilda Pompey shahrini ko'mib tashlagan Italiya vulqoni?",    "Vezuviy tog'i"   }
        };

    // Darajaga qarab to'g'ri pool qaytaradi
    public static Dictionary<string, string> GetPool(DifficultyLevel level)
    {
        if (level == DifficultyLevel.Easy)
            return EasyQuestions;
        if (level == DifficultyLevel.Hard)
            return HardQuestions;
        return StandardQuestions;
    }
}
