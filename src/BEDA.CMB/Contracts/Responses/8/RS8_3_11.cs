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
    /// 8.3.11.步步为赢收益率试算响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_3_11 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQDIPRF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQDIPRF";
        /// <summary>
        /// 8.3.11.步步为赢收益率试算响应内容
        /// </summary>
        public NTQDIPRFZ1 NTQDIPRFZ1 { get; set; }
        /// <summary>
        /// 8.3.11.步步为赢收益率试算响应集合
        /// </summary>
        [XmlElement("NTQDIPRFZ2")]
        public List<NTQDIPRFZ2> List { get; set; }
    }
    /// <summary>
    /// 8.3.11.步步为赢收益率试算响应内容
    /// </summary>
    public class NTQDIPRFZ1
    {
        /// <summary>
        /// 本金	M
        /// </summary>
        public decimal RIPAMT { get; set; }
        /// <summary>
        /// 总收益	M
        /// </summary>
        public decimal PRFAMT { get; set; }
        /// <summary>
        /// 持有期平均收益率	F(5,2)
        /// </summary>
        public decimal AVERAT { get; set; }
    }
    /// <summary>
    /// 8.3.11.步步为赢收益率试算响应内容
    /// </summary>
    public class NTQDIPRFZ2
    {
        /// <summary>
        /// 开始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 开始日期	D, 对应<see cref="BEGDAT"/>
        /// </summary>
        [XmlElement("BEGDAT")]
        public string BEGDATStr
        {
            get
            {
                return this.BEGDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BEGDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 结束日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 结束日期	D, 对应<see cref="ENDDAT"/>
        /// </summary>
        [XmlElement("ENDDAT")]
        public string ENDDATStr
        {
            get
            {
                return this.ENDDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 计息周期	N(5)
        /// </summary>
        public int DATCYL { get; set; }
        /// <summary>
        /// 收益率	F(5,2)
        /// </summary>
        public decimal PRFRAT { get; set; }
        /// <summary>
        /// 收益	M
        /// </summary>
        public decimal PRFAMT { get; set; }
    }
}
