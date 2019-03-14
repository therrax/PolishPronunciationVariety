using static PolishPronunciationVariety.Model.GrammaticalResult;

namespace PolishPronunciationVariety.Model {
    public class Rule 
    {
        public Rule()
        {
            
        }
        public Rule (GrammaticalCase dealWith, string wordEnd, string wordEndChange) 
        {

            this.DealWith = dealWith;
            this.WordEnd = wordEnd;
            this.WordEndChange = wordEndChange;

        }
        public GrammaticalCase DealWith { get; set; }
        public string WordEnd { get; set; }
        public string WordEndChange { get; set; }
    }
}