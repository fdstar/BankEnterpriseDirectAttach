using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEDA.Utils
{
    /// <summary>
    /// 值类型辅助类
    /// </summary>
    public static class StructExtensions
    {
        /// <summary>
        /// 尝试将字符串转化成值类型数据，如果转换失败则返回null
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inputStr">输入字符串</param>
        /// <returns></returns>
        public static T? TryConvert<T>(this string inputStr)
            where T : struct
        {
            try
            {
                return (T)Convert.ChangeType(inputStr, typeof(T));
            }
            catch { }
            return null;
        }
        /// <summary>
        /// 尝试将转化结果赋值到output上
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inputStr">输入字符串</param>
        /// <param name="output">转换结果，如果转换失败则返回default值</param>
        /// <returns>转换成功与否</returns>
        public static bool TryParse<T>(this string inputStr, out T output)
            where T : struct
        {
            output = default(T);
            var tmp = inputStr.TryConvert<T>();
            if (tmp.HasValue)
            {
                output = tmp.Value;
                return true;
            }
            return false;
        }
        /// <summary>
        /// 尝试将字符串进行转换，如果转化成功，则将值赋给refT
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inputStr">输入字符串</param>
        /// <param name="refT"></param>
        public static void TrySet<T>(this string inputStr, ref T refT)
            where T : struct
        {
            var tmp = inputStr.TryConvert<T>();
            if (tmp.HasValue)
            {
                refT = tmp.Value;
            }
        }
    }
}
