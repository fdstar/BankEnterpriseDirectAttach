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
    /// 8.6.6.组合存款协议列表查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_6_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCMAQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMAQRY";
        /// <summary>
        /// 8.6.6.组合存款协议列表查询响应集合
        /// </summary>
        [XmlElement("NTCMAQRYZ1")]
        public List<NTCMAQRYZ1> List { get; set; }
    }
    /// <summary>
    /// 8.6.6.组合存款协议列表查询响应内容
    /// </summary>
    public class NTCMAQRYZ1
    {
        /// <summary>
        /// 协议号	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 平台编号	C(10)
        /// </summary>
        public string PLTNBR { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 留存金额	M
        /// </summary>
        public decimal RSVMIN { get; set; }
        /// <summary>
        /// 起存金额	M
        /// </summary>
        public decimal OPNMIN { get; set; }
        /// <summary>
        /// 最低支取金额	M
        /// </summary>
        public decimal DRWMIN { get; set; }
        /// <summary>
        /// 存期	C(6)
        /// </summary>
        public string TERDUM { get; set; }
        /// <summary>
        /// 协议利率	F(11,7)
        /// </summary>
        public decimal INTRAT { get; set; }
        /// <summary>
        /// 自动转存标志	C(1)
        /// 1-不转存
        /// 2-本息转存
        /// 3-本金转存，利息转活期
        /// </summary>
        public string MTUPRC { get; set; }
        /// <summary>
        /// 智能定期类型	C(1)    A-基础型 B-增强型
        /// </summary>
        public string ITGTYP { get; set; }
        /// <summary>
        /// 生效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 生效日期	D, 对应<see cref="BEGDAT"/>
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
        /// 终止日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 终止日期	D, 对应<see cref="ENDDAT"/>
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
    }
}
