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
    /// 27.25.查询内部计价余额历史信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS27_25 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTMTLBAQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMTLBAQ";
        /// <summary>
        /// 27.25.查询内部计价余额历史信息响应集合
        /// </summary>
        [XmlElement("NTMTLBAQZ1")]
        public List<NTMTLBAQZ1> List { get; set; }
    }
    /// <summary>
    /// 27.25.查询内部计价余额历史信息响应内容
    /// </summary>
    public class NTMTLBAQZ1
    {
        /// <summary>
        /// 上级账户	C(35)
        /// </summary>
        public string TOPEAC { get; set; }
        /// <summary>
        /// 上级账户名称	Z(62)
        /// </summary>
        public string TOPENM { get; set; }
        /// <summary>
        /// 下级账户	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 下级账号名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime INTDAT { get; set; }
        /// <summary>
        /// 日期	D, 对应<see cref="INTDAT"/>
        /// </summary>
        [XmlElement("INTDAT")]
        public string INTDATStr
        {
            get
            {
                return this.INTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 利率	F(11,7)
        /// </summary>
        public decimal INTVAL { get; set; }
        /// <summary>
        /// 余额类型	C(1)    	U：上存，D：下借
        /// </summary>
        public string BALTYP { get; set; }
        /// <summary>
        /// 余额	F(17,2)
        /// </summary>
        public decimal KEYBAL { get; set; }
        /// <summary>
        /// 分段标志	A(1)    Y：分段，N：不分段
        /// </summary>
        public string SUBFLG { get; set; }
        /// <summary>
        /// 当日上存金额	F(17,2)
        /// </summary>
        public decimal DBTLMT { get; set; }
        /// <summary>
        /// 当日下借金额	F(17,2)
        /// </summary>
        public decimal CRTLMT { get; set; }
        /// <summary>
        /// 当日利息	F(17,2)
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 累计利息	F(17,2)
        /// </summary>
        public decimal TTLAMT { get; set; }
    }
}
