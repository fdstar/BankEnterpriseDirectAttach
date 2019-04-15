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
    /// 22.1.9.纸质汇票委托收款申请请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ22_1_9 : CMBBase<RQINFO>, IRequest<RS22_1_9>
    {
        /// <summary>
        /// NTBILRCD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBILRCD";
        /// <summary>
        /// 22.1.9.纸质汇票委托收款申请请求内容
        /// </summary>
        public NTBILRCDX1 NTBILRCDX1 { get; set; }
        /// <summary>
        /// 22.1.9.纸质汇票委托收款申请请求集合
        /// </summary>
        [XmlElement("NTBILRCDX2")]
        public List<NTBILRCDX2> List { get; set; }
    }
    /// <summary>
    /// 22.1.9.纸质汇票委托收款申请请求内容
    /// </summary>
    public class NTBILRCDX1
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 持票人账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
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
        /// 票据总张数	C(5)    检验录入票的总张数使用
        /// </summary>
        public int TOLCNT { get; set; }
        /// <summary>
        /// 票据总金额	M
        /// </summary>
        public decimal TOLAMT { get; set; }
    }
    /// <summary>
    /// 22.1.9.纸质汇票委托收款申请请求内容
    /// </summary>
    public class NTBILRCDX2
    {
        /// <summary>
        /// 序号	C(3)
        /// </summary>
        public int SQRNBR { get; set; }
        /// <summary>
        /// 票据号	C(30)
        /// </summary>
        public string BILNBR { get; set; }
        /// <summary>
        /// 票据标识号	C(20)   银行产生的系统内纸票唯一标识
        /// </summary>
        public string DPSNBR { get; set; }
        /// <summary>
        /// 票面金额	M
        /// </summary>
        public decimal BILAMT { get; set; }
        /// <summary>
        /// 票据种类	C(1)    ‘0’ 银行承兑汇票 ‘1’   商业承兑汇票
        /// </summary>
        public string BILTYP { get; set; }
    }
}
