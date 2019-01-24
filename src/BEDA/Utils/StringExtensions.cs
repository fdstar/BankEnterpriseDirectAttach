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
        /// <param name="input">字符串</param>
        /// <param name="totalWidth">要填充到的最大长度</param>
        /// <param name="paddingChar">填充字符串（单字符）</param>
        /// <param name="multibyteLength">每个非单字符实际对应几个ASC字符，默认2，即一个字符等于二个ASC字符</param>
        /// <returns></returns>
        public static string PadLeftWhileDouble(this string input, int totalWidth, char paddingChar = '\0', int multibyteLength = 2)
        {
            var singleLength = GetSingleLength(input, multibyteLength);
            return input.PadLeft(totalWidth - singleLength + input.Length, paddingChar);
        }

        /// <summary>
        /// 获取字符串对应的单字节长度
        /// </summary>
        /// <param name="input">字符串</param>
        /// <param name="multibyteLength">每个非单字符实际对应几个ASC字符，默认2，即一个字符等于二个ASC字符</param>
        /// <returns></returns>
        public static int GetSingleLength(this string input, int multibyteLength = 2)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }
            var repStr = new string(Enumerable.Repeat('a', multibyteLength).ToArray());
            return Regex.Replace(input, @"[^\x00-\xff]", repStr).Length;//计算得到该字符串对应单字节字符串的长度
        }

        /// <summary>
        /// 按单字节字符串向右填充长度
        /// </summary>
        /// <param name="input">字符串</param>
        /// <param name="totalWidth">要填充到的最大长度</param>
        /// <param name="paddingChar">填充字符串（单字符）</param>
        /// <param name="multibyteLength">每个非单字符实际对应几个ASC字符，默认2，即一个字符等于二个ASC字符</param>
        /// <returns></returns>
        public static string PadRightWhileDouble(this string input, int totalWidth, char paddingChar = '\0', int multibyteLength = 2)
        {
            var singleLength = GetSingleLength(input, multibyteLength);
            return input.PadRight(totalWidth - singleLength + input.Length, paddingChar);
        }
    }
}
