using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.11.4贵金属交易实物提货申请响应主体
    /// </summary>
    public class V1_PMDLVRYAPPLYTRNRS : IResponse
    {
        /// <summary>
        /// 3.11.4贵金属交易实物提货申请响应主体
        /// </summary>
        public PMDLVRYAPPLYTRNRS PMDLVRYAPPLYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.11.4贵金属交易实物提货申请响应主体
    /// </summary>
    public class PMDLVRYAPPLYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.11.4贵金属交易实物提货申请响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public PMDLVRYAPPLYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.11.4贵金属交易实物提货申请响应内容
    /// </summary>
    public class PMDLVRYAPPLYTRN_RSBODY : BANKACCT
    {
        /// <summary>
        /// 提货重量，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal PICKCNT { get; set; }
        /// <summary>
        /// 品种代码
        /// 201 AU99.99       
        /// 202 AU99.95       
        /// 203 PT99.95       
        /// 207 AU100g
        /// </summary>
        [XmlElement(Order = 6)]
        public string PRODNO { get; set; }
        /// <summary>
        /// 指令处理状态
        /// </summary>
        [XmlElement(Order = 10)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
