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
    /// 10.14.委托贷款历史查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS10_14 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKNTALNHST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTALNHST";
        /// <summary>
        /// 10.14.委托贷款历史查询响应集合
        /// </summary>
        [XmlElement("NTALNHSTZ")]
        public List<NTALNHSTZ> List { get; set; }
    }
    /// <summary>
    /// 10.14.委托贷款历史查询响应内容
    /// </summary>
    public class NTALNHSTZ
    {
        /// <summary>
        /// 日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime TRSDAT { get; set; }
        /// <summary>
        /// 日期	D, 对应<see cref="TRSDAT"/>
        /// </summary>
        [XmlElement("TRSDAT")]
        public string TRSDATStr
        {
            get
            {
                return this.TRSDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 发放委贷	M
        /// </summary>
        public decimal PRDALN { get; set; }
        /// <summary>
        /// 归还委贷	M
        /// </summary>
        public decimal RTNALN { get; set; }
        /// <summary>
        /// 上存余额	M
        /// </summary>
        public decimal PRDAMT { get; set; }
        /// <summary>
        /// 委托借款	M
        /// </summary>
        public decimal ALNLND { get; set; }
        /// <summary>
        /// 委托还款	M
        /// </summary>
        public decimal ALNPYO { get; set; }
        /// <summary>
        /// 下借余额	M
        /// </summary>
        public decimal LNDAMT { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
