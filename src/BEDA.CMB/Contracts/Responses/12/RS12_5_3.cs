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
    /// 12.5.3.汇出汇款综合查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_5_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKNTQRYRTA
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTQRYRTA";
        /// <summary>
        /// 12.5.3.汇出汇款综合查询响应集合 外汇汇款经办概要信息
        /// </summary>
        [XmlElement("NTRTALSTZ1")]
        public List<NTRTALSTZ1> List { get; set; }
    }
    /// <summary>
    /// 12.5.3.汇出汇款综合查询响应内容 外汇汇款经办概要信息
    /// </summary>
    public class NTRTALSTZ1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务类型	C(6)
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 汇出旧分行号	C(2)
        /// </summary>
        public string ISUBBK { get; set; }
        /// <summary>
        /// 汇款人户口	C(35)
        /// </summary>
        public string SNDEAC { get; set; }
        /// <summary>
        /// 系统内外标记	C(1)
        /// </summary>
        public string BNKFLG { get; set; }
        /// <summary>
        /// 境内外标志	C(1)
        /// </summary>
        public string CNRTAG { get; set; }
        /// <summary>
        /// 汇入行（收款人）旧分行号	C(2)
        /// </summary>
        public string RCVBBK { get; set; }
        /// <summary>
        /// 收款人户口	C(35)
        /// </summary>
        public string RCVEAC { get; set; }
        /// <summary>
        /// 收款人名称	Z(100)
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 收款人地址	Z(100)
        /// </summary>
        public string RCVADR { get; set; }
        /// <summary>
        /// 汇款货币	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 汇款金额	M
        /// </summary>
        public decimal ORTAMT { get; set; }
        /// <summary>
        /// 是否有附加信息	C(1)
        /// </summary>
        public string EXTFLG { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 请求状态	C(3)
        /// </summary>
        public string REQSTS { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 是否有附件	C(1)
        /// </summary>
        public string ATHFLG { get; set; }
        /// <summary>
        /// 经办日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 经办日期	D, 对应<see cref="OPRDAT"/>
        /// </summary>
        [XmlElement("OPRDAT")]
        public string OPRDATStr
        {
            get
            {
                return this.OPRDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 期望日期	C(8)
        /// </summary>
        public string EPTDAT { get; set; }
        /// <summary>
        /// 期望时间	C(6)
        /// </summary>
        public string EPTTIM { get; set; }
        /// <summary>
        /// 期望时间 由<see cref="EPTDAT"/>和<see cref="EPTTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? ExpectedTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.EPTDAT, this.EPTTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 业务状态	C(1)
        /// </summary>
        public string BUSSTS { get; set; }
        /// <summary>
        /// 特殊码30	Z(30)
        /// </summary>
        public string RSV30Z { get; set; }
        /// <summary>
        /// 汇款方式	C(1)
        /// O/空：原币种汇款
        /// X：结售汇汇款
        /// M：小币种汇款
        /// </summary>
        public string ORTTYP { get; set; }
        /// <summary>
        /// 到账货币	C(2)
        /// </summary>
        public string EXGCCY { get; set; }
        /// <summary>
        /// 到账金额	M
        /// </summary>
        public decimal? EXGAMT { get; set; }
    }
}
