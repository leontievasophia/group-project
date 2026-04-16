using group_project.Models;

namespace group_project.Services
{
    public class HoroscopeService
    {
        private readonly Dictionary<string, (string Name, string ImagePath, List<string> Texts)> _horoscopes;

        public HoroscopeService()
        {
            _horoscopes = new Dictionary<string, (string, string, List<string>)>
            {
                ["aries"] = ("Овен", "/images/horoscope/aries.jpg", new List<string>
                {
                    "Сьогодні твій день для рішучих кроків.",
                    "Не бійся починати нове — все вийде.",
                    "Енергія сьогодні на твоєму боці."
                }),

                ["taurus"] = ("Телець", "/images/horoscope/taurus.jpg", new List<string>
                {
                    "Спокій і стабільність принесуть результат.",
                    "Зосередься на важливому.",
                    "День для гармонії і комфорту."
                }),

                ["gemini"] = ("Близнюки", "/images/horoscope/gemini.jpg", new List<string>
                {
                    "Час для спілкування і нових ідей.",
                    "Нові знайомства принесуть користь.",
                    "Будь відкритою до змін."
                }),

                ["leo"] = ("Лев", "/images/horoscope/leo.jpg", new List<string>
                {
                    "Сьогодні ти в центрі уваги.",
                    "Покажи свою силу і харизму.",
                    "Твоя впевненість приведе до успіху."
                })
            };
        }

        public HoroscopeInfo? GetHoroscope(string sign)
        {
            if (string.IsNullOrEmpty(sign))
                return null;

            sign = sign.ToLower();

            if (!_horoscopes.ContainsKey(sign))
                return null;

            var data = _horoscopes[sign];

            int index = DateTime.Now.DayOfYear % data.Texts.Count;

            return new HoroscopeInfo
            {
                SignKey = sign,
                SignName = data.Name,
                ImagePath = data.ImagePath,
                HoroscopeText = data.Texts[index]
            };
        }
    }
}
