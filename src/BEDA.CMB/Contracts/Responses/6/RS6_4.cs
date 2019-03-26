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
    /// 6.4.商户确认查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS6_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTMIQWOD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMIQWOD";
        /// <summary>
        /// 6.4.商户确认查询响应集合
        /// </summary>
        [XmlElement("NTMIQWODZ")]
        public List<NTMIQWODZ> List { get; set; }
    }
    /// <summary>
    /// 6.4.商户确认查询响应内容
    /// </summary>
    public class NTMIQWODZ
    {
        /// <summary>
        /// 商户编号	C(10)
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
        /// 币种	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 订单金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 结算金额	M
        /// </summary>
        public decimal ENDAMT { get; set; }
        /// <summary>
        /// 对方商户号	C(10)
        /// </summary>
        public string REFMCH { get; set; }
        /// <summary>
        /// 商户订单号	C(40)
        /// </summary>
        public string REFORD { get; set; }
        /// <summary>
        /// 商户订单支付号	C(10)
        /// </summary>
        public string SUBORD { get; set; }
        /// <summary>
        /// 请求状态	C(3)	WCF=等待商户确认
        /// </summary>
        public string ORDSTA { get; set; }
        /// <summary>
        /// 付方分行号	C(2)
        /// </summary>
        public string PAYBBK { get; set; }
        /// <summary>
        /// 付方帐户	C(35)
        /// </summary>
        public string PAYACC { get; set; }
        /// <summary>
        /// 付方账户名	Z(62)
        /// </summary>
        public string PAYNAM { get; set; }
    }
}
