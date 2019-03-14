
namespace PolishPronunciationVariety.Model
{
    public class GrammaticalResult
    {
        public GrammaticalResult()
        {
        }

        public GrammaticalResult(string text, GrammaticalCase inputCase)
        {
            Text = text;
            TextAfter = text;
            InputCase = inputCase;
            OutputCase = inputCase;

        }
        public string Text { get; set; }
        public bool IsUpdated {get;set;} = false;
        public GrammaticalCase InputCase {get;set;}
        public string TextAfter { get; set; }
        public GrammaticalCase OutputCase {get;set;}
        public GrammaticalResult Update(string textAfter, GrammaticalCase outputCase)
        {
            TextAfter = textAfter;
            OutputCase = outputCase;
            return this;
        }
        public enum GrammaticalCase {
            
            //Mianownik
            Nominative = 0,

            //Dopełniacz
            Genitive = 1,

            //Celownik
            Dative = 2,

            //Biernik
            Accusative = 3,

            //Nadrzędnik
            Instrumental = 4,

            //Miejscownik
            Locative = 5,

            //Wołacz
            Vocative = 6


        }
    }
}