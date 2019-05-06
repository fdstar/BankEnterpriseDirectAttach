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
    /// 27.4.查询内部户信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS27_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTINAINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTINAINF";
        /// <summary>
        /// 27.4.查询内部户信息响应集合
        /// </summary>
        [XmlElement("NTINAINFZ1")]
        public List<NTINAINFZ1> List { get; set; }
    }
    /// <summary>
    /// 27.4.查询内部户信息响应内容
    /// </summary>
    public class NTINAINFZ1
    {
        /// <summary>
        /// 内部户编号	C(10)
        /// </summary>
        public string IDANBR { get; set; }
        /// <summary>
        /// 内部户名称	Z(100)
        /// </summary>
        public string INANAM { get; set; }
        /// <summary>
        /// 户口号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 客户号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 内部户余额	F(17,2)
        /// </summary>
        public decimal INABAL { get; set; }
        /// <summary>
        /// 初始余额	F(17,2)
        /// </summary>
        public decimal INIBAL { get; set; }
        /// <summary>
        /// 内部户限额标志	C(1)
        /// </summary>
        public string LMTTAG { get; set; }
        /// <summary>
        /// C+集团账户编号	C(10)
        /// </summary>
        public string PLTNBR { get; set; }
        /// <summary>
        /// 多级现金池产品编号	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 生效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime STRDAT { get; set; }
        /// <summary>
        /// 生效日期	D, 对应<see cref="STRDAT"/>
        /// </summary>
        [XmlElement("STRDAT")]
        public string STRDATStr
        {
            get
            {
                return this.STRDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.STRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 失效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 失效日期	D, 对应<see cref="ENDDAT"/>
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
        /// 状态	C(1)
        /// </summary>
        public string STSCOD { get; set; }
    }
}
