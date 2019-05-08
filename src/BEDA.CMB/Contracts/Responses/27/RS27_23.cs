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
    /// 27.23.多级现金池内部计价查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS27_23 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTMTLINT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMTLINT";
        /// <summary>
        /// 27.23.多级现金池内部计价查询响应集合
        /// </summary>
        [XmlElement("NTMTLINTZ1")]
        public List<NTMTLINTZ1> List { get; set; }
    }
    /// <summary>
    /// 27.23.多级现金池内部计价查询响应内容
    /// </summary>
    public class NTMTLINTZ1
    {
        /// <summary>
        /// 产品编号	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
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
        /// 结息开始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 结息开始日期	D, 对应<see cref="BEGDAT"/>
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
        /// 结息结束日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 结息结束日期	D, 对应<see cref="ENDDAT"/>
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
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 利息	F(17,2)
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 上存计息积数	F(17,2)
        /// </summary>
        public decimal IN1BAL { get; set; }
        /// <summary>
        /// 上存利率	F(11,7)
        /// </summary>
        public decimal IN1RAT { get; set; }
        /// <summary>
        /// 下借计息积数	F(17,2)
        /// </summary>
        public decimal IN2BAL { get; set; }
        /// <summary>
        /// 下借利率   	F(11,7)
        /// </summary>
        public decimal IN2RAT { get; set; }
        /// <summary>
        /// 分段标志   	C(1)    	Y：分段，N：不分段
        /// </summary>
        public string SUBFLG { get; set; }
        /// <summary>
        /// 备注	Z(192)
        /// </summary>
        public string RTNTXT { get; set; }
    }
}
