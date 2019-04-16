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
    /// 23.10.临时额度设置请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_10 : CMBBase<RQINFO>, IRequest<RS23_10>
    {
        /// <summary>
        /// NTCPRAUT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRAUT";
        /// <summary>
        /// 23.10.临时额度设置请求内容
        /// </summary>
        public NTCPRAUTX NTCPRAUTX { get; set; }
    }
    /// <summary>
    /// 23.10.临时额度设置请求内容
    /// </summary>
    public class NTCPRAUTX
    {
        /// <summary>
        /// 模式     	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 公司卡号        	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 分行号         	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 公司结算户     	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 临时密码       	C(6)
        /// </summary>
        public string TPWPWD { get; set; }
        /// <summary>
        /// 到期日         	D
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 到期日         	D, 对应<see cref="EXPDAT"/>
        /// </summary>
        [XmlElement("EXPDAT")]
        public string EXPDATStr
        {
            get
            {
                return this.EXPDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EXPDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 额度货币       	C(2)
        /// </summary>
        public string LMTCCY { get; set; }
        /// <summary>
        /// 临时授权额度   	M
        /// </summary>
        public decimal AUTLMT { get; set; }
        /// <summary>
        /// 期望日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? ExpectedTime { get; set; }
        /// <summary>
        /// 期望日	D
        /// </summary>
        [XmlElement("EPTDAT")]
        public string EPTDATStr
        {
            get
            {
                return this.ExpectedTime?.ToString("yyyyMMdd");
            }
            set { }
        }
        /// <summary>
        /// 期望时间	T
        /// </summary>
        [XmlElement("EPTTIM")]
        public string EPTTIMStr
        {
            get
            {
                return this.ExpectedTime?.ToString("HHmmss");
            }
            set { }
        }
        /// <summary>
        /// 对方参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 附件标志 	C(1)
        /// </summary>
        public string ATHFLG { get; set; }
    }
}
