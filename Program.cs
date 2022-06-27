using System;
using Google.Cloud.Translation.V2;

namespace EnglishToGermanTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Enter Text in English");
            text = Console.ReadLine();
            var client = TranslationClient.CreateFromApiKey("Your GOOGLE Cloud Translation API Key");
            var response = client.TranslateText(text, LanguageCodes.German, LanguageCodes.English);
            Console.WriteLine("Text in German");
            Console.WriteLine(response.TranslatedText);
        }
    }
}
