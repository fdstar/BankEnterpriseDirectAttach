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
    /// 10.16.现金流查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS10_16 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKNTCCSINQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTCCSINQ";
        /// <summary>
        /// 10.16.现金流查询响应集合
        /// </summary>
        [XmlElement("NTCCSINQZ1")]
        public List<NTCCSINQZ1> NTCCSINQZ1List { get; set; }
        /// <summary>
        /// 10.16.现金流查询响应集合
        /// </summary>
        [XmlElement("NTCCSINQZ2")]
        public List<NTCCSINQZ2> NTCCSINQZ2List { get; set; }
    }
    /// <summary>
    /// 10.16.现金流查询响应内容
    /// </summary>
    public class NTCCSINQZ1
    {
        /// <summary>
        /// 交易日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime TRSDAT { get; set; }
        /// <summary>
        /// 交易日期	D, 对应<see cref="TRSDAT"/>
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
        /// 流入金额	M
        /// </summary>
        public decimal INPAMT { get; set; }
        /// <summary>
        /// 流出金额	M	
        /// </summary>
        public decimal OUPAMT { get; set; }
        /// <summary>
        /// 净额	M
        /// </summary>
        public decimal CLRAMT { get; set; }
        /// <summary>
        /// 保留字段	C(100)
        /// </summary>
        public string SPL100 { get; set; }
    }
    /// <summary>
    /// 10.16.现金流查询响应内容
    /// </summary>
    public class NTCCSINQZ2
    {
        /// <summary>
        /// 交易日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime TRSDAT { get; set; }
        /// <summary>
        /// 交易日期	D, 对应<see cref="TRSDAT"/>
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
        /// 余额	M
        /// </summary>
        public decimal BALAMT { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
