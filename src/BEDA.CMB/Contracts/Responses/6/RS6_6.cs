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
    /// 6.6.商务支付退款功能响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS6_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTB2BDBK
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTB2BDBK";
        /// <summary>
        /// 6.6.商务支付退款功能响应内容
        /// </summary>
        public NTB2BDBKZ1 NTB2BDBKZ1 { get; set; }
    }
    /// <summary>
    /// 6.6.商务支付退款功能响应内容
    /// </summary>
    public class NTB2BDBKZ1
    {
        /// <summary>
        /// 对方订单号   	C(40)   原商户订单号
        /// </summary>
        public string REFORD { get; set; }
        /// <summary>
        /// 对方订单支付号	C(10)   原商户订单支付号
        /// </summary>
        public string SUBORD { get; set; }
        /// <summary>
        /// 订单号       	C(10)   	原银行订单号
        /// </summary>
        public string SEQNBR { get; set; }
        /// <summary>
        /// 订单支付号   	C(10)   原银行订单支付号
        /// </summary>
        public string SUBSEQ { get; set; }
        /// <summary>
        /// 退款流水号   	C(20)
        /// </summary>
        public string RFNSEQ { get; set; }
        /// <summary>
        /// 对方参考号   	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 退款请求状态 	C(3)    经办成功返回’NTE’
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 退款请求结果 	C(1)    经办成功固定返回空白
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 退款金额     	M   	经办成功，与原订单交易金额一致
        /// </summary>
        public decimal RFNAMT { get; set; }
        /// <summary>
        /// 退款经办日期 	D
        /// </summary>
        public string RFNDAT { get; set; }
        /// <summary>
        /// 退款经办时间	T
        /// </summary>
        public string RFNTIM { get; set; }
        /// <summary>
        /// 退款经办时间 由<see cref="RFNDAT"/>和<see cref="RFNTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? RefundTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.RFNDAT, this.RFNTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
    }
}
