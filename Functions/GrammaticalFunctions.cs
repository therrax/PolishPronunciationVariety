using System.Collections.Generic;
using System.Linq;
using PolishPronunciationVariety.Builder;
using PolishPronunciationVariety.Extensions;
using PolishPronunciationVariety.Model;
using static PolishPronunciationVariety.Model.GrammaticalResult;

namespace PolishPronunciationVariety.Functions
{
    public static class GrammaticalFunctions
    {
        public static RuleBuilder RuleBuilder {get;private set;} = new RuleBuilder();
        public static GrammaticalResult ChangeCase(string text, GrammaticalCase toCaseType)
        {
            var result = new GrammaticalResult(text,toCaseType);
            var newString = string.Empty;

            
            if(string.IsNullOrEmpty(text)) return result;
            if(text.Length < 2) return result;
                
            //multiples
            if (text.Contains(' ')) 
            {
                var parts = text.Split (' ');
                //two-pronged
                if (parts.Count() == 2) 
                {   
                    
                    if(toCaseType == GrammaticalCase.Locative)
                    {
                        var rules = RuleBuilder.LocativeRulesTwoWords;
                        return rules.FindMatchingAndReplace(text,GrammaticalCase.Locative);
                    }

                }
            }
            else
            {
                if(toCaseType == GrammaticalCase.Locative)
                {
                    var rules = RuleBuilder.LocativeRules;
                    return rules.FindMatchingAndReplace(text,GrammaticalCase.Locative);
                }
            }
                
            
            return result;
        }
    }
}