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
    /// 23.6.消费额度设置请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_6 : CMBBase<RQINFO>, IRequest<RS23_6>
    {
        /// <summary>
        /// NTCPRLMS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRLMS";
        /// <summary>
        /// 23.6.消费额度设置请求内容
        /// </summary>
        public NTCPRCRDX NTCPRCRDX { get; set; }
        /// <summary>
        /// 23.6.消费额度设置请求集合
        /// </summary>
        [XmlElement("NTCPRLMTX")]
        public List<NTCPRLMTX> List { get; set; }
    }
    /// <summary>
    /// 23.6.消费额度设置请求内容
    /// </summary>
    public class NTCPRCRDX
    {
        /// <summary>
        /// 模式     	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
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
    /// 23.6.消费额度设置请求内容
    /// </summary>
    public class NTCPRLMTX
    {
        /// <summary>
        /// 额度类别	C(10)   必输，且必需是下列的一种：
        /// CPRLMTDY每日消费额度 
        /// CPRLMTHF每半年消费额度
        /// CPRLMTMH每月消费额度  
        /// CPRLMTON一次性消费额度
        /// CPRLMTQR每季度消费额度
        /// CPRLMTTN每旬消费额度  
        /// CPRLMTWK每周消费额度  
        /// CPRLMTYR每年消费额度
        /// </summary>
        public string PIPCOD { get; set; }
        /// <summary>
        /// 折算货币	C(2)
        /// </summary>
        public string LMTCCY { get; set; }
        /// <summary>
        /// 额度金额	M
        /// </summary>
        public decimal LMTAMT { get; set; }
        /// <summary>
        /// 失效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 失效日期	D, 对应<see cref="EXPDAT"/>
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
    }
}
