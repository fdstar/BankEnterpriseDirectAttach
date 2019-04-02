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
    /// 14.4.大额划拨交易综合查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS14_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKNTQRYFMT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTQRYFMT";
        /// <summary>
        /// 14.4.大额划拨交易综合查询响应集合
        /// </summary>
        [XmlElement("NTWAUGMTZ")]
        public List<NTWAUGMTZ> List { get; set; }
    }
    /// <summary>
    /// 14.4.大额划拨交易综合查询响应内容
    /// </summary>
    public class NTWAUGMTZ
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
        /// 交易类型	C(3)	PTS:母公司划拨给子公司；STP:子公司划拨给母公司
        /// </summary>
        public string TRSCOD { get; set; }
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string CRSCOD { get; set; }
        /// <summary>
        /// 子公司协议序号	C(5)
        /// </summary>
        public string CRPSEQ { get; set; }
        /// <summary>
        /// 母公司户口号	C(35)
        /// </summary>
        public string FATACC { get; set; }
        /// <summary>
        /// 母公司户口名称	Z(62)
        /// </summary>
        public string FATACN { get; set; }
        /// <summary>
        /// 子公司户口号	C(35)
        /// </summary>
        public string SUBACC { get; set; }
        /// <summary>
        /// 子公司户口名称	Z(62)
        /// </summary>
        public string SUBACN { get; set; }
        /// <summary>
        /// 划拨金额	M
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 请求状态	C(3)	A.5 业务请求状态
        /// </summary>
        public string REQSTS { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)	A.6 业务处理结果
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 是否有附件	C(1)	N:否
        /// </summary>
        public string ATHFLG { get; set; }
        /// <summary>
        /// 经办日期	C(8)
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 经办日期	C(8), 对应<see cref="OPRDAT"/>
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
        /// 期望日        	D
        /// </summary>
        public string EPTDAT { get; set; }
        /// <summary>
        /// 期望时间      	T
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
        /// 保留字段	Z(50)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
