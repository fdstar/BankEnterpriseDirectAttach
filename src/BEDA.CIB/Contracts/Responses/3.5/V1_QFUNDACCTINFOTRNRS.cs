using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.5.8银期资金查询响应主体
    /// </summary>
    public class V1_QFUNDACCTINFOTRNRS : IResponse
    {
        /// <summary>
        /// 3.5.8银期资金查询响应主体
        /// </summary>
        public QFUNDACCTINFOTRNRS QFUNDACCTINFOTRNRS { get; set; }
    }
    /// <summary>
    /// 3.5.8银期资金查询响应主体
    /// </summary>
    public class QFUNDACCTINFOTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.5.8银期资金查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public QFUNDACCTINFOTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.5.8银期资金查询响应内容
    /// </summary>
    public class QFUNDACCTINFOTRN_RSBODY
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
        /// 资金账户余额
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal FUNDAMT { get; set; }
    }
}
