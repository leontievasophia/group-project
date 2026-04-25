using group_project.Models;

namespace group_project.Services
{
    public class HoroscopeService
    {
        private readonly Dictionary<string, (string Name, string DateRange, string ImagePath, List<string> Texts)> _horoscopes;

        public HoroscopeService()
        {
            _horoscopes = new Dictionary<string, (string, string, string, List<string>)>
            {
                ["aries"] = ("Овен", "21 березня — 19 квітня", "/images/horoscope/aries.jpg", new List<string>
                {
                    "Сьогодні твій день для рішучих кроків. Не бійся починати нове — все вийде. Енергія сьогодні на твоєму боці."
                }),

                ["taurus"] = ("Телець", "20 квітня — 20 травня", "/images/horoscope/taurus.jpg", new List<string>
                {
                    "Спокій і стабільність принесуть результат. Зосередься на важливому. День для гармонії і комфорту."
                }),

                ["gemini"] = ("Близнюки", "21 травня — 20 червня", "/images/horoscope/gemini.jpg", new List<string>
                {
                    "Час для спілкування і нових ідей. Нові знайомства принесуть користь. Будь відкритою до змін."
                }),

                ["cancer"] = ("Рак", "21 червня — 22 липня", "/images/horoscope/cancer.jpg", new List<string>
                {
                    "Сьогодні варто прислухатися до себе. Твоя інтуїція допоможе прийняти правильне рішення."
                }),

                ["leo"] = ("Лев", "23 липня — 22 серпня", "/images/horoscope/leo.jpg", new List<string>
                {
                    "Сьогодні ти в центрі уваги. Покажи свою силу і харизму. Твоя впевненість приведе до успіху."
                }),

                ["virgo"] = ("Діва", "23 серпня — 22 вересня", "/images/horoscope/virgo.jpg", new List<string>
                {
                    "День підходить для порядку, планування і важливих справ. Уважність допоможе уникнути помилок."
                }),

                ["libra"] = ("Терези", "23 вересня — 22 жовтня", "/images/horoscope/libra.jpg", new List<string>
                {
                    "Гармонія сьогодні буде твоєю силою. Обирай спокій, баланс і чесну розмову."
                }),

                ["scorpio"] = ("Скорпіон", "23 жовтня — 21 листопада", "/images/horoscope/scorpio.jpg", new List<string>
                {
                    "Сьогодні ти можеш відчути сильний внутрішній поштовх. Використай його для змін на краще."
                }),

                ["sagittarius"] = ("Стрілець", "22 листопада — 21 грудня", "/images/horoscope/sagittarius.jpg", new List<string>
                {
                    "День відкриває нові можливості. Не бійся рухатися вперед і пробувати щось нове."
                }),

                ["capricorn"] = ("Козеріг", "22 грудня — 19 січня", "/images/horoscope/capricorn.jpg", new List<string>
                {
                    "Сьогодні важливо діяти послідовно. Твоя наполегливість допоможе отримати бажаний результат."
                }),

                ["aquarius"] = ("Водолій", "20 січня — 18 лютого", "/images/horoscope/aquarius.jpg", new List<string>
                {
                    "Твої ідеї сьогодні можуть надихнути інших. Довіряй своїй оригінальності."
                }),

                ["pisces"] = ("Риби", "19 лютого — 20 березня", "/images/horoscope/pisces.jpg", new List<string>
                {
                    "День сприятливий для творчості, мрій і внутрішнього спокою. Прислухайся до себе."
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
                DateRange = data.DateRange,
                ImagePath = data.ImagePath,
                HoroscopeText = data.Texts[index]
            };
        }
    }
}