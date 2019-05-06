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
    /// 27.6.自动划拨协议查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS27_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCSTLST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCSTLST";
        /// <summary>
        /// 27.6.自动划拨协议查询响应集合
        /// </summary>
        [XmlElement("NTCSTLSTZ1")]
        public List<NTCSTLSTZ1> List { get; set; }
    }
    /// <summary>
    /// 27.6.自动划拨协议查询响应内容
    /// </summary>
    public class NTCSTLSTZ1
    {
        /// <summary>
        /// 产品编号	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 划拨关系编号	C(5)
        /// </summary>
        public string RLTNBR { get; set; }
        /// <summary>
        /// 协议类型	C(1)
        /// A ：实时资金归集
        /// B ：实时资金补足
        /// C ：定期资金归集
        /// D ：定期资金补足
        /// </summary>
        public string CSTTYP { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 户口号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 客户号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 对方户口分行号	C(2)
        /// </summary>
        public string OBJBBK { get; set; }
        /// <summary>
        /// 对方户口号	C(35)
        /// </summary>
        public string OBJEAC { get; set; }
        /// <summary>
        /// 对方户口名称	Z(200)
        /// </summary>
        public string OBJNAM { get; set; }
        /// <summary>
        /// 对方客户号	C(10)
        /// </summary>
        public string OBJCLT { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string CSTNBR { get; set; }
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
        /// 签订日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime SUBDAT { get; set; }
        /// <summary>
        /// 签订日期	D, 对应<see cref="SUBDAT"/>
        /// </summary>
        [XmlElement("SUBDAT")]
        public string SUBDATStr
        {
            get
            {
                return this.SUBDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SUBDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 临时暂停开始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? SPDSDT { get; set; }
        /// <summary>
        /// 临时暂停开始日期	D, 对应<see cref="SPDSDT"/>
        /// </summary>
        [XmlElement("SPDSDT")]
        public string SPDSDTStr
        {
            get
            {
                return this.SPDSDT?.ToString("yyyyMMdd");
            }
            set
            {
                this.SPDSDT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SPDSDT = tmp;
                }
            }
        }
        /// <summary>
        /// 临时暂停终止日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? SPDEDT { get; set; }
        /// <summary>
        /// 临时暂停终止日期	D, 对应<see cref="SPDEDT"/>
        /// </summary>
        [XmlElement("SPDEDT")]
        public string SPDEDTStr
        {
            get
            {
                return this.SPDEDT?.ToString("yyyyMMdd");
            }
            set
            {
                this.SPDEDT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SPDEDT = tmp;
                }
            }
        }
        /// <summary>
        /// 备注	Z(50)
        /// </summary>
        public string CSTREM { get; set; }
        /// <summary>
        /// 协议状态	C(1)    	A：有效；B暂停
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 划拨模式	C(1)
        /// 协议类型为A：1、全额上划2、取整上划  
        /// 协议类型为B：1、全额补足       
        /// 协议类型为C：1 、留底上划 2 、定额上划 3 、按比例上划 4 、划整留余       
        /// 协议类型为D：1 、目标余额 2 、名义额度比例下拨 3 、按母户联机余额比例下拨
        /// </summary>
        public string TSFMOD { get; set; }
    }
}
