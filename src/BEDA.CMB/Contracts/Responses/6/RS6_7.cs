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
    /// 6.7.商务支付现金退款查询信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS6_7 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQRYDBK
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYDBK";
        /// <summary>
        /// 6.7.商务支付现金退款查询信息响应集合
        /// </summary>
        [XmlElement("NTQRYDBKZ")]
        public List<NTQRYDBKZ> List { get; set; }
    }
    /// <summary>
    /// 6.7.商务支付现金退款查询信息响应内容
    /// </summary>
    public class NTQRYDBKZ
    {
        /// <summary>
        /// 商户号	C(10)
        /// </summary>
        public string MCHNBR { get; set; }
        /// <summary>
        /// 对方订单号    	C(40)
        /// </summary>
        public string REFORD { get; set; }
        /// <summary>
        /// 对方订单支付号	C(10)
        /// </summary>
        public string SUBORD { get; set; }
        /// <summary>
        /// 订单号        	C(10)
        /// </summary>
        public string SEQNBR { get; set; }
        /// <summary>
        /// 订单支付号    	C(10)
        /// </summary>
        public string SUBSEQ { get; set; }
        /// <summary>
        /// 退款业务参考号   	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 退款请求状态	C(3)
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 退款金额     	M
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
        /// <summary>
        /// 退票日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime RTNDAT { get; set; }
        /// <summary>
        /// 退票日期	D, 对应<see cref="RTNDAT"/>
        /// </summary>
        [XmlElement("RTNDAT")]
        public string RTNDATStr
        {
            get
            {
                return this.RTNDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RTNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 退款请求结果	C(1)
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 结果摘要	Z(92)
        /// </summary>
        public string RTNNAR { get; set; }
        /// <summary>
        /// 付款人银行账号	C(35)
        /// </summary>
        public string PAYACC { get; set; }
        /// <summary>
        /// 付款人户名	Z(200)
        /// </summary>
        public string PAYNAM { get; set; }
        /// <summary>
        /// 付款人开户行	C(62)
        /// </summary>
        public string PAYBNK { get; set; }
        /// <summary>
        /// 收方帐户 	C(35)
        /// </summary>
        public string RCVACC { get; set; }
        /// <summary>
        /// 收方户名 	Z(200)
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 收方行名称	Z(62)
        /// </summary>
        public string RCVBNK { get; set; }
        /// <summary>
        /// 用途       	Z(62)
        /// </summary>
        public string NUSAGE { get; set; }
    }
}
