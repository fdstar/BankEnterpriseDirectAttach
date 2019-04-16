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
    /// 23.13.查询消费额度设置信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS23_13 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCRDINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCRDINF";
        /// <summary>
        /// 23.13.查询消费额度设置信息响应集合
        /// </summary>
        [XmlElement("NTCPLLSTZ")]
        public List<NTCPLLSTZ> List { get; set; }
    }
    /// <summary>
    /// 23.13.查询消费额度设置信息响应内容
    /// </summary>
    public class NTCPLLSTZ
    {
        /// <summary>
        /// 额度类别	C(10)
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
        /// 剩余额度	M
        /// </summary>
        public decimal RMNAMT { get; set; }
        /// <summary>
        /// 生效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime EFTDAT { get; set; }
        /// <summary>
        /// 生效日期	D, 对应<see cref="EFTDAT"/>
        /// </summary>
        [XmlElement("EFTDAT")]
        public string EFTDATStr
        {
            get
            {
                return this.EFTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EFTDAT = tmp;
                }
            }
        }
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
