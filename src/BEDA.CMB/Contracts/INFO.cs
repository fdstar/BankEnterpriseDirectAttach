using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEDA.CMB.Contracts
{
    /// <summary>
    /// 请求/响应报文头信息
    /// </summary>
    public class INFO
    {
        /// <summary>
        /// 业务函数名
        /// </summary>
        public string FUNNAM { get; set; }
        /// <summary>
        /// 数据格式，只支持2：xml格式三
        /// </summary>
        public string DATTYP { get; set; } = "2";
        /// <summary>
        /// 自定义1
        /// </summary>
        public string CST001 { get; set; }
        /// <summary>
        /// 自定义2
        /// </summary>
        public string CST002 { get; set; }
        /// <summary>
        /// 自定义3
        /// </summary>
        public string CST003 { get; set; }
        /// <summary>
        /// 自定义4
        /// </summary>
        public string CST004 { get; set; }
        /// <summary>
        /// 自定义5
        /// </summary>
        public string CST005 { get; set; }
    }
}
