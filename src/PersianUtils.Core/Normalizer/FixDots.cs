﻿using System.Text.RegularExpressions;

namespace PersianUtils.Core.Normalizer
{
    /// <summary>
    /// Replaces three dots with ellipsis
    /// </summary>
    public static class FixDots
    {
        private static readonly Regex _matchConvertDotsToEllipsis =
            new Regex(@"\s*\.{3,}", options: RegexOptions.Compiled | RegexOptions.IgnoreCase, matchTimeout: RegexUtils.MatchTimeout);

        /// <summary>
        /// Replaces three dots with ellipsis.
        /// It converts آزمون.... to آزمون…
        /// </summary>
        /// <param name="text">Text to process</param>
        /// <returns>Processed Text</returns>
        public static string NormalizeDotsToEllipsis(this string text)
        {
            return _matchConvertDotsToEllipsis.Replace(text, @"…");
        }
    }
}