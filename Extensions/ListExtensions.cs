using System.Collections.Generic;
using System.Linq;
using PolishPronunciationVariety.Model;
using static PolishPronunciationVariety.Model.GrammaticalResult;

namespace PolishPronunciationVariety.Extensions
{
    public static class ListExtensions
    {
        public static GrammaticalResult FindMatchingAndReplace(this List<Rule> rules, string text, GrammaticalCase toCaseType)
        {
            var result = new GrammaticalResult(text,toCaseType);
            var newString = string.Empty;

            
            foreach (var rule in rules)
            {
                if(rule.WordEnd.Length > text.Length) return result;

                var wordEnd = text.Substring(text.Length - rule.WordEnd.Length);
                if(rule.WordEnd.Equals(wordEnd))
                {
                    return result.Update(text.Remove (text.Length - rule.WordEnd.Length) + rule.WordEndChange,toCaseType);
                }
            }



            return result;
        }
        public static GrammaticalResult FindMatchingAndReplace(this List<RuleTwoWords> rules, string text, GrammaticalCase toCaseType)
        {
            var result = new GrammaticalResult(text,toCaseType);
            var newString = string.Empty;

            var parts = text.Split (' ');
            if (parts.Count() != 2)  return result;

            foreach (var rule in rules)
            {
                if(rule.FirstWordEnd.Length > parts[0].Length || rule.SecondWordEnd.Length > parts[1].Length) return result;
                
                var end = parts[0].Substring (parts[0].Length - rule.FirstWordEnd.Length);
                var secondEnd = parts[1].Substring (parts[1].Length - rule.SecondWordEnd.Length);
                
                if (rule.FirstWordEnd == end && rule.SecondWordEnd == secondEnd) 
                {
                    newString = parts[0].Remove (parts[0].Length - rule.FirstWordEnd.Length) + rule.FirstWordEndChange + " " + parts[1].Remove (parts[1].Length - rule.SecondWordEnd.Length) + rule.SecondWordEndChange;
                    return result.Update(newString,GrammaticalCase.Locative);
                }
            }

            return result;
        }
    }
}