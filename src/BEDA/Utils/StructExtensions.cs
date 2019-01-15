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
        /// <param name="inputStr"></param>
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
    }
}
