using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 13.2.终止支付限额协议请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ13_2 : CMBBase<RQINFO>, IRequest<RS13_2>
    {
        /// <summary>
        /// SDKNTLMTCNL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTLMTCNL";
        /// <summary>
        /// 13.2.终止支付限额协议请求内容
        /// </summary>
        public NTLMTCNLX NTLMTCNLX { get; set; }
    }
    /// <summary>
    /// 13.2.终止支付限额协议请求内容
    /// </summary>
    public class NTLMTCNLX
    {
        /// <summary>
        /// 母公司账号	C(35)
        /// </summary>
        public string FATACC { get; set; }
        /// <summary>
        /// 母公司账号分行号	C(2)	A.1 招行分行
        /// </summary>
        public string FATBBK { get; set; }
        /// <summary>
        /// 子公司账号	C(35)
        /// </summary>
        public string SUBACC { get; set; }
        /// <summary>
        /// 子公司账号分行号	C(2)	A.1 招行分行
        /// </summary>
        public string SUBBBK { get; set; }
        /// <summary>
        /// 协议生效日期	C(8)
        /// </summary>
        [XmlIgnore]
        public DateTime STRDAT { get; set; }
        /// <summary>
        /// 协议生效日期	C(8), 对应<see cref="STRDAT"/>
        /// </summary>
        [XmlElement("STRDAT")]
        public string STRDATStr
        {
            get
            {
                return this.STRDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.STRDAT = tmp;
                }
            }
        }
    }
}
