using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 6.5.订单确认响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS6_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTORDCFM
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTORDCFM";
        /// <summary>
        /// 6.5.订单确认响应集合
        /// </summary>
        [XmlElement("NTORDCFMZ")]
        public List<NTORDCFMZ> List { get; set; }
    }
    /// <summary>
    /// 6.5.订单确认响应内容
    /// </summary>
    public class NTORDCFMZ
    {
        /// <summary>
        /// 商户号	C(10)
        /// </summary>
        public string MCHNBR { get; set; }
        /// <summary>
        /// 银行订单号   	C (10)
        /// </summary>
        public string SEQNBR { get; set; }
        /// <summary>
        /// 银行订单支付号	C (10)
        /// </summary>
        public string SUBSEQ { get; set; }
        /// <summary>
        /// 确认结果	C(1)	F = 失败 S = 成功
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 错误信息	Z(92)
        /// </summary>
        public string ERRDSP { get; set; }
    }
}
