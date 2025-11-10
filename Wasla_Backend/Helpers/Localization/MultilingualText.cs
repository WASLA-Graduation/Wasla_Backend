namespace Wasla_Backend.Helpers.Localization
{
    public class MultilingualText
    {
        public string English { get; set; } = default!;
        public string Arabic { get; set; } = default!;

        public string GetText(string language)
        {
            switch (language.ToLower())
            {
                case "arabic":
                case "ar":
                    return Arabic;
                default:
                    return English;
            }
        }
    }

}
