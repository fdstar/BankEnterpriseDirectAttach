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
    /// 23.7.批量消费额度设置请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_7 : CMBBase<RQINFO>, IRequest<RS23_7>
    {
        /// <summary>
        /// NTCPRLMM
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRLMM";
        /// <summary>
        /// 23.7.批量消费额度设置请求内容
        /// </summary>
        public NTCPRPCMX NTCPRPCMX { get; set; }
        /// <summary>
        /// 23.7.批量消费额度设置请求集合
        /// </summary>
        [XmlElement("NTPSBLSTX")]
        public List<NTPSBLSTX> NTPSBLSTXList { get; set; }
        /// <summary>
        /// 23.7.批量消费额度设置请求集合
        /// </summary>
        [XmlElement("NTCPRLMTX")]
        public List<NTCPRLMTX> NTCPRLMTXList { get; set; }
    }
    /// <summary>
    /// 23.7.批量消费额度设置请求内容
    /// </summary>
    public class NTCPRPCMX
    {
        /// <summary>
        /// 模式     	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
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
    /// <summary>
    /// 23.7.批量消费额度设置请求内容
    /// </summary>
    public class NTPSBLSTX
    {
        /// <summary>
        /// 公司卡号 	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 分行号   	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 公司结算户	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
    }
}
