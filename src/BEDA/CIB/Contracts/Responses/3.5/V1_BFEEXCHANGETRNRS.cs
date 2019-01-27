using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.5.7银期互转响应主体
    /// </summary>
    public class V1_BFEEXCHANGETRNRS : IResponse
    {
        /// <summary>
        /// 3.5.7银期互转响应主体
        /// </summary>
        public BFEEXCHANGETRNRS BFEEXCHANGETRNRS { get; set; }
    }
    /// <summary>
    /// 3.5.7银期互转响应主体
    /// </summary>
    public class BFEEXCHANGETRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.5.7银期互转响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public BFEEXCHANGETRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.5.7银期互转响应内容
    /// </summary>
    public class BFEEXCHANGETRN_RSBODY
    {
        /// <summary>
        /// 查询账户代号，最长32位
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTNO { get; set; }
        /// <summary>
        /// 币种，2位
        /// </summary>
        [XmlElement(Order = 1)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 资金账户，最长20位
        /// </summary>
        [XmlElement(Order = 2)]
        public string FUNDACCTNO { get; set; }
        /// <summary>
        /// 期货代码
        /// </summary>
        [XmlElement(Order = 3)]
        public string FUNDBRANCHNO { get; set; }
        /// <summary>
        /// 转账金额
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal TRANSFERAMT { get; set; }
        /// <summary>
        /// 指令处理状态	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
