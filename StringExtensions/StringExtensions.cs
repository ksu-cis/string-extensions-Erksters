using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ' ,'.','?', '!', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string Capitalize(this String str)
        {
            string first = str[0].ToString().ToUpper();
            return first + str.Substring(1);
        }
        public static string Decapitalize(this String str)
        {
            
                string first = str[0].ToString().ToLower();
                return first + str.Substring(1);
            
        }

        public static String Titleize(this String sentence)
        {
            string results =""; 
            string[] words =  sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<string> articles = new List<string>()
            {
                "A",
                "An",
                "The"
            };
            List<string> parts = new List<string>();
            foreach(string article in articles){
                if(article == words[0])
                {   

                    //remove first word
                    //add first word to the end of the sentence 
                    results =  (sentence.Substring(article.Length +1 ) + ", " + article);
                }
            }
            return results;
        }
    }
}

