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
    /// 10.3.现金池账户额度历史查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS10_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKNTCACHST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTCACHST";
        /// <summary>
        /// 10.3.现金池账户额度历史查询响应集合
        /// </summary>
        [XmlElement("NTAUBLSTZ")]
        public List<NTAUBLSTZ> List { get; set; }
    }
    /// <summary>
    /// 10.3.现金池账户额度历史查询响应内容
    /// </summary>
    public class NTAUBLSTZ
    {
        /// <summary>
        /// 额度日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime LMTDAT { get; set; }
        /// <summary>
        /// 额度日期	D, 对应<see cref="LMTDAT"/>
        /// </summary>
        [XmlElement("LMTDAT")]
        public string LMTDATStr
        {
            get
            {
                return this.LMTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.LMTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 上划额度	F(17,2)
        /// </summary>
        public decimal DBTLMT { get; set; }
        /// <summary>
        /// 下划额度	F(17,2)
        /// </summary>
        public decimal CDTLMT { get; set; }
        /// <summary>
        /// 轧差额度	F(17,2)
        /// </summary>
        public decimal STLLMT { get; set; }
        /// <summary>
        /// 额度余额	M
        /// </summary>
        public decimal LMTAMT { get; set; }
        /// <summary>
        /// 保留字段	C(100)
        /// </summary>
        public string SPL100 { get; set; }
    }
}
