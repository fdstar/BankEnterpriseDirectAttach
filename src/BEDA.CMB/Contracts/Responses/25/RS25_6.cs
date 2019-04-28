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
    /// 25.6.还款功能业务明细响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS25_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCDTINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCDTINF";
        /// <summary>
        /// 25.6.还款功能业务明细响应集合
        /// </summary>
        [XmlElement("NTCDTINFZ1")]
        public List<NTCDTINFZ1> List { get; set; }
    }
    /// <summary>
    /// 25.6.还款功能业务明细响应内容
    /// </summary>
    public class NTCDTINFZ1
    {
        /// <summary>
        /// 分行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 贷款业务号	C(10)
        /// </summary>
        public string BUSNUM { get; set; }
        /// <summary>
        /// 经办日	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 经办日	D, 对应<see cref="OPRDAT"/>
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
        /// 期望日	D
        /// </summary>
        [XmlIgnore]
        public DateTime EPTDAT { get; set; }
        /// <summary>
        /// 期望日	D, 对应<see cref="EPTDAT"/>
        /// </summary>
        [XmlElement("EPTDAT")]
        public string EPTDATStr
        {
            get
            {
                return this.EPTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EPTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 币种	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 还款金额	M
        /// </summary>
        public decimal LONAMT { get; set; }
        /// <summary>
        /// 还款利息	M
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 请求状态	C(3)	附录A.5
        /// </summary>
        public string REQSTS { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)	附录A.6
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 结果摘要	Z(92)
        /// </summary>
        public string RTNNAR { get; set; }
        /// <summary>
        /// 保留字段	Z(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
