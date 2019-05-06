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
    /// 27.1.多级现金池账户历史余额查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS27_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTMTLHBL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMTLHBL";
        /// <summary>
        /// 27.1.多级现金池账户历史余额查询响应集合
        /// </summary>
        [XmlElement("NTMTLHBLZ1")]
        public List<NTMTLHBLZ1> List { get; set; }
    }
    /// <summary>
    /// 27.1.多级现金池账户历史余额查询响应内容
    /// </summary>
    public class NTMTLHBLZ1
    {
        /// <summary>
        /// 日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime PRCDAT { get; set; }
        /// <summary>
        /// 日期	D, 对应<see cref="PRCDAT"/>
        /// </summary>
        [XmlElement("PRCDAT")]
        public string PRCDATStr
        {
            get
            {
                return this.PRCDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PRCDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 下级账户	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 下级账户名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 上级账户	C(35)
        /// </summary>
        public string TOPEAC { get; set; }
        /// <summary>
        /// 上级账户名称	Z(200)
        /// </summary>
        public string TOPNAM { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 联机余额	F(17,2)
        /// </summary>
        public decimal ONLBAL { get; set; }
        /// <summary>
        /// 头寸编号	C(10)
        /// </summary>
        public string NMLNBR { get; set; }
        /// <summary>
        /// 头寸余额	F(17,2)
        /// </summary>
        public decimal NMLBAL { get; set; }
        /// <summary>
        /// 调整头寸余额	F(17,2)
        /// </summary>
        public decimal NMLMNT { get; set; }
        /// <summary>
        /// 内部户余额	F(17,2)
        /// </summary>
        public decimal IDABAL { get; set; }
    }
}
