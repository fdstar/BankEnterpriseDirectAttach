using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.6.1虚拟主账户签约解约响应主体
    /// </summary>
    public class V1_VSASIGNTRNRS : IResponse
    {
        /// <summary>
        /// 3.6.1虚拟主账户签约解约响应主体
        /// </summary>
        public VSASIGNTRNRS VSASIGNTRNRS { get; set; }
    }
    /// <summary>
    /// 3.6.1虚拟主账户签约解约响应主体
    /// </summary>
    public class VSASIGNTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.6.1虚拟主账户签约解约响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public VSASIGNTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.6.1虚拟主账户签约解约响应内容
    /// </summary>
    public class VSASIGNTRN_RSBODY
    {
        /// <summary>
        /// 18位主账户
        /// </summary>
        [XmlElement(Order = 0)]
        public string MAINACCT { get; set; }
        /// <summary>
        /// 账户名称	非必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTNAME { get; set; }
        /// <summary>
        /// Y-签约 N-解约
        /// </summary>
        [XmlElement(Order = 2)]
        public string SIGNFLG { get; set; }
        /// <summary>
        /// 操作结果，SUCC成功、FAIL失败
        /// </summary>
        [XmlElement(Order = 3)]
        public string RESULT { get; set; }
        /// <summary>
        /// 处理结果信息
        /// </summary>
        [XmlElement(Order = 4)]
        public string MSG { get; set; }
        /// <summary>
        /// 处理结果是否为成功，对应<see cref="RESULT"/>，SUCC时返回true
        /// </summary>
        [XmlIgnore]
        public bool IsSuccess
        {
            get { return "SUCC".Equals(this.RESULT, StringComparison.OrdinalIgnoreCase); }
        }
    }
}
