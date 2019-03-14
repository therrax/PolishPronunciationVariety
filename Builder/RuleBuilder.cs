using System.Collections.Generic;
using PolishPronunciationVariety.Model;
using static PolishPronunciationVariety.Model.GrammaticalResult;

namespace PolishPronunciationVariety.Builder
{
    public class RuleBuilder
    {
        public RuleBuilder()
        {
            BuildLocativeRules();
            BuildLocativeRulesTwoWords();
        }

        public List<Rule> LocativeRules { get; set; } = new List<Rule>();
        public List<RuleTwoWords> LocativeRulesTwoWords { get; set; } = new List<RuleTwoWords>();

        private void BuildLocativeRulesTwoWords()
        {
            LocativeRulesTwoWords.AddRange
            (
                new List<RuleTwoWords>()
                {
                    new RuleTwoWords(GrammaticalCase.Locative,"nie","niu","kie","kim")
                }
            );
        }
        private void BuildLocativeRules()
        {
            LocativeRules.AddRange
            ( 
                new List<Rule>()
                {
                    new Rule(GrammaticalCase.Locative,"ówka","ówce"),

                    new Rule(GrammaticalCase.Locative,"wek","wku"),
                    new Rule(GrammaticalCase.Locative,"any","anach"),
                    new Rule(GrammaticalCase.Locative,"lno","lnie"),
                    new Rule(GrammaticalCase.Locative,"ary","arach"),
                    new Rule(GrammaticalCase.Locative,"zeg","zegu"),
                    new Rule(GrammaticalCase.Locative,"ała","łej"),
                    new Rule(GrammaticalCase.Locative,"oje","ojach"),
                    new Rule(GrammaticalCase.Locative,"osz","oszu"),
                    new Rule(GrammaticalCase.Locative,"ice","icach"),
                    new Rule(GrammaticalCase.Locative,"owo","owie"),
                    new Rule(GrammaticalCase.Locative,"opy","opach"),
                    new Rule(GrammaticalCase.Locative,"awa","awie"),
                    new Rule(GrammaticalCase.Locative,"ane","anem"),
                    new Rule(GrammaticalCase.Locative,"cie","ciu"),
                    new Rule(GrammaticalCase.Locative,"cin","cinie"),
                    new Rule(GrammaticalCase.Locative,"ław","ławiu"),
                    new Rule(GrammaticalCase.Locative,"órz","orzu"),
                    new Rule(GrammaticalCase.Locative,"iew","ewie"),
                    new Rule(GrammaticalCase.Locative,"zyn","zynie"),
                    new Rule(GrammaticalCase.Locative,"nie","niu"),
                    new Rule(GrammaticalCase.Locative,"yca","ycy"),
                    new Rule(GrammaticalCase.Locative,"udz","udzu"),
                    new Rule(GrammaticalCase.Locative,"lin","linie"),
                    new Rule(GrammaticalCase.Locative,"ica","icy"),
                    new Rule(GrammaticalCase.Locative,"iec","cu"),
                    new Rule(GrammaticalCase.Locative,"zek","zku"),
                    new Rule(GrammaticalCase.Locative,"zka","zce"),
                    new Rule(GrammaticalCase.Locative,"pot","pocie"),
                    new Rule(GrammaticalCase.Locative,"ądz","ądzu"),
                    new Rule(GrammaticalCase.Locative,"ald","aldzie"),
                    new Rule(GrammaticalCase.Locative,"ost","oście"),
                    new Rule(GrammaticalCase.Locative,"rze","rzu"),
                    new Rule(GrammaticalCase.Locative,"sze","szu"),

                    new Rule(GrammaticalCase.Locative,"ty","tach"),
                    new Rule(GrammaticalCase.Locative,"uń","uniu"),
                    new Rule(GrammaticalCase.Locative,"ia","ii"),
                    new Rule(GrammaticalCase.Locative,"ań","aniu"),
                    new Rule(GrammaticalCase.Locative,"in","inie"),
                    new Rule(GrammaticalCase.Locative,"sk","sku"),
                    new Rule(GrammaticalCase.Locative,"cz","czu"),
                    new Rule(GrammaticalCase.Locative,"ok","oku"),
                    new Rule(GrammaticalCase.Locative,"ów","owie"),
                    new Rule(GrammaticalCase.Locative,"śl","ślu"),
                    new Rule(GrammaticalCase.Locative,"la","li"),
                    new Rule(GrammaticalCase.Locative,"ła","le"),
                    new Rule(GrammaticalCase.Locative,"ły","łach"),
                    new Rule(GrammaticalCase.Locative,"ki","kach"),
                    new Rule(GrammaticalCase.Locative,"ka","ce"),
                    new Rule(GrammaticalCase.Locative,"na","nie"),
                    new Rule(GrammaticalCase.Locative,"yń","yniu"),
                    new Rule(GrammaticalCase.Locative,"wo","wie")
                }
            );
        }
        
    }
}