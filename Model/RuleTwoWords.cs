using static PolishPronunciationVariety.Model.GrammaticalResult;

namespace PolishPronunciationVariety.Model
{
    public class RuleTwoWords
    {
        public RuleTwoWords()
        {
            
        }
        public RuleTwoWords (GrammaticalCase dealWith, string firstWordEnd, string firstWordEndChange, string secondWordEnd, string secondWordEndChange) 
        {

            this.DealWith = dealWith;
            this.FirstWordEnd = firstWordEnd;
            this.FirstWordEndChange = firstWordEndChange;
            this.SecondWordEnd = secondWordEnd;
            this.SecondWordEndChange = secondWordEndChange;

        }
        public GrammaticalCase DealWith { get; set; }
        public string FirstWordEnd { get; set; }
        public string FirstWordEndChange { get; set; }
        public string SecondWordEnd { get; set; }
        public string SecondWordEndChange { get; set; }
    }
}