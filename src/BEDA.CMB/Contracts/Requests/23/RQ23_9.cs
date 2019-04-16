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
    /// 23.9.批量POS额度设置请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_9 : CMBBase<RQINFO>, IRequest<RS23_9>
    {
        /// <summary>
        /// NTPCHDLM
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTPCHDLM";
        /// <summary>
        /// 23.9.批量POS额度设置请求内容
        /// </summary>
        public NTPCHDLMX NTPCHDLMX { get; set; }
        /// <summary>
        /// 23.9.批量POS额度设置请求集合
        /// </summary>
        [XmlElement("NTPSBLSTX")]
        public List<NTPSBLSTX> List { get; set; }
    }
    /// <summary>
    /// 23.9.批量POS额度设置请求内容
    /// </summary>
    public class NTPCHDLMX
    {
        /// <summary>
        /// 模式     	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 折算货币   	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 每次消费限额	M
        /// </summary>
        public decimal TIMAMT { get; set; }
        /// <summary>
        /// 每日消费限额	M
        /// </summary>
        public decimal DAYAMT { get; set; }
        /// <summary>
        /// 摘要内容   	Z(42)
        /// </summary>
        public string TRXTXT { get; set; }
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
