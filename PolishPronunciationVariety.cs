using System;
using System.Linq;
using PolishPronunciationVariety.Functions;
using static PolishPronunciationVariety.Model.GrammaticalResult;


namespace PolishPronunciationVariety 
{
    public static class PolishPronunciationVarietyExtensions 
    {
        public static string GetLocative(this string text) 
        {          
            return GrammaticalFunctions.ChangeCase(text,GrammaticalCase.Locative).TextAfter;
        }
        public static Model.GrammaticalResult GetLocative(this string text, GrammaticalCase caseType) 
        {
            return GrammaticalFunctions.ChangeCase(text,caseType);
        }
    }
}