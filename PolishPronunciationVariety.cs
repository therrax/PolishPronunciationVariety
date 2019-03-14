using System;
using System.Linq;

namespace PolishPronunciationVariety 
{
    public static class PolishPronunciationVarietyExtensions 
    {
        public static string GetCityLocative(this string city) 
        {
            if (!string.IsNullOrEmpty (city)) 
            {
                if (city.Length > 3) 
                {
                    //multiples
                    if (city.Contains(' ')) 
                    {
                        var parts = city.Split (' ');
                        //two-pronged
                        if (parts.Count() == 2) 
                        {
                            var end = parts[0].Substring (parts[0].Length - 3);
                            var secondEnd = parts[1].Substring (parts[1].Length - 3);

                            if (end == "nie" && secondEnd == "kie") 
                            {
                                return parts[0].Remove (parts[0].Length - 3) + "niu" + " " + parts[1].Remove (parts[1].Length - 3) + "kim";
                            }
                            return parts[0].Substring (parts[0].Length - 3);;
                        }
                    }
                    //one-pronged
                    else 
                    {
                        var end = city.Substring (city.Length - 4);

                        if (end == "ówka") { return city.Remove (city.Length - 4) + "ówce"; };

                        end = city.Substring (city.Length - 3);

                        if (end == "lno") { return city.Remove (city.Length - 3) + "lnie"; };
                        if (end == "ary") { return city.Remove (city.Length - 3) + "arach"; };
                        if (end == "zeg") { return city.Remove (city.Length - 3) + "zegu"; };
                        if (end == "oje") { return city.Remove (city.Length - 3) + "ojach"; };
                        if (end == "osz") { return city.Remove (city.Length - 3) + "oszu"; };
                        if (end == "ice") { return city.Remove (city.Length - 3) + "icach"; };
                        if (end == "owo") { return city.Remove (city.Length - 3) + "owie"; };
                        if (end == "awa") { return city.Remove (city.Length - 3) + "awie"; };
                        if (end == "ane") { return city.Remove (city.Length - 3) + "anem"; };
                        if (end == "cie") { return city.Remove (city.Length - 3) + "ciu"; };
                        if (end == "cin") { return city.Remove (city.Length - 3) + "cinie"; };
                        if (end == "órz") { return city.Remove (city.Length - 3) + "orzu"; };
                        if (end == "iew") { return city.Remove (city.Length - 3) + "ewie"; };
                        if (end == "zyn") { return city.Remove (city.Length - 3) + "zynie"; };
                        if (end == "yca") { return city.Remove (city.Length - 3) + "ycy"; };
                        if (end == "udz") { return city.Remove (city.Length - 3) + "udzu"; };
                        if (end == "lin") { return city.Remove (city.Length - 3) + "linie"; };

                        end = city.Substring (city.Length - 2);

                        if (end == "ty") { return city.Remove (city.Length - 2) + "tach"; };
                        if (end == "ia") { return city.Remove (city.Length - 2) + "ii"; };
                        if (end == "ań") { return city.Remove (city.Length - 2) + "aniu"; };
                        if (end == "sk") { return city.Remove (city.Length - 2) + "sku"; };
                        if (end == "cz") { return city.Remove (city.Length - 2) + "czu"; };
                        if (end == "ok") { return city.Remove (city.Length - 2) + "oku"; };
                        if (end == "ów") { return city.Remove (city.Length - 2) + "owie"; };
                        if (end == "śl") { return city.Remove (city.Length - 2) + "ślu"; };
                        if (end == "la") { return city.Remove (city.Length - 2) + "li"; };
                        if (end == "ła") { return city.Remove (city.Length - 2) + "le"; };
                        if (end == "ły") { return city.Remove (city.Length - 2) + "łach"; };
                        if (end == "ki") { return city.Remove (city.Length - 2) + "kach"; };
                        if (end == "ka") { return city.Remove (city.Length - 2) + "ce"; };
                        if (end == "na") { return city.Remove (city.Length - 2) + "nie"; };

                    }
                } 
                else 
                {
                    return city;
                }
            }

            return city;

        }
    }
}