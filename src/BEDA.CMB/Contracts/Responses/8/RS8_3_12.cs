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
    /// 8.3.12.步步为赢收益率历史查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_3_12 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQDIPRH
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQDIPRH";
        /// <summary>
        /// 8.3.12.步步为赢收益率历史查询响应集合
        /// </summary>
        [XmlElement("NTQDIPRHZ")]
        public List<NTQDIPRHZ> List { get; set; }
    }
    /// <summary>
    /// 8.3.12.步步为赢收益率历史查询响应内容
    /// </summary>
    public class NTQDIPRHZ
    {
        /// <summary>
        /// 产品简称	Z(22)
        /// </summary>
        public string RIPSNM { get; set; }
        /// <summary>
        /// 起始天数	N(5)
        /// </summary>
        public int RNGBEG { get; set; }
        /// <summary>
        /// 结束天数	N(5)
        /// </summary>
        public int RNGEND { get; set; }
        /// <summary>
        /// 收益率	F(5,2)
        /// </summary>
        public decimal PRFRAT { get; set; }
        /// <summary>
        /// 收益率生效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime EFFDAT { get; set; }
        /// <summary>
        /// 收益率生效日期	D, 对应<see cref="EFFDAT"/>
        /// </summary>
        [XmlElement("EFFDAT")]
        public string EFFDATStr
        {
            get
            {
                return this.EFFDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EFFDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 收益率失效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 收益率失效日期	D, 对应<see cref="EXPDAT"/>
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
