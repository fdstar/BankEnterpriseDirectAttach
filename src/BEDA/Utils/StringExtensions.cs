using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEDA.Utils
{
    using System.Text.RegularExpressions;
    /// <summary>
    /// 字符串辅助类
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// 按单字节字符串向左填充长度
        /// </summary>
        /// <param name="input"></param>
        /// <param name="length"></param>
        /// <param name="paddingChar"></param>
        /// <returns></returns>
        public static string PadLeftWhileDouble(this string input, int length, char paddingChar = '\0')
        {
            var singleLength = GetSingleLength(input);
            return input.PadLeft(length - singleLength + input.Length, paddingChar);
        }
        /// <summary>
        /// 获取字符串对应的单字节长度
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int GetSingleLength(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException();
            }
            return Regex.Replace(input, @"[^\x00-\xff]", "aa").Length;//计算得到该字符串对应单字节字符串的长度
        }
        /// <summary>
        /// 按单字节字符串向右填充长度
        /// </summary>
        /// <param name="input"></param>
        /// <param name="length"></param>
        /// <param name="paddingChar"></param>
        /// <returns></returns>
        public static string PadRightWhileDouble(this string input, int length, char paddingChar = '\0')
        {
            var singleLength = GetSingleLength(input);
            return input.PadRight(length - singleLength + input.Length, paddingChar);
        }
    }
}
