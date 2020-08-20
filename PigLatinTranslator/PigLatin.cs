// <copyright file="PigLatinTranslator.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace PigLatinTranslator
{
    using System.Text.RegularExpressions;
    using System.Linq;
    using System.Globalization;

    /// <summary>
    /// This class helps to translate from English to PigLatin.
    /// </summary>
    public static class PigLatin
    {
        private static readonly string StarterVowelPattern = "[aeiou]|xr|yt";
        private static readonly string VowelPattern = "[aeiou]";

        /// <summary>
        /// This method conducts the translation.
        /// </summary>
        /// <param name="english">The original phrase/sentence to translate.</param>
        /// <returns>A PigtLatin equivalent of the English phrase.</returns>
        public static string Translate(string english)
        {
            return string.Join(" ", Regex.Split(english, "\\s+").Select(word => TranslateWord(word)), CultureInfo.InvariantCulture); 
        }

        private static string TranslateWord(string word)
        {
            // Start with the vowel.
            var matchResult = Regex.Match(word, StarterVowelPattern);
            if (matchResult.Success && matchResult.Index == 0)
            {
                return $"{word}ay";
            }

            // Compound words
            if (word.Length == 2 && word[1] == 'y')
            {
                return $"{word[1]}{word[0]}ay";
            }

            // Consonant cluster
            matchResult = Regex.Match(word, VowelPattern);
            var firstY = word.IndexOf('y');
            int firstVowel;

            if (!matchResult.Success)
            {
                firstVowel = firstY; 
            }
            else
            {
                firstVowel = matchResult.Index;
            }

            // Special case: "qu"
            if (word[firstVowel] == 'u' && word[firstVowel - 1] == 'q')
            {
                ++firstVowel;
            }

            return $"{word.Substring(firstVowel)}{word.Substring(0, firstVowel)}ay";
        }
    }
}