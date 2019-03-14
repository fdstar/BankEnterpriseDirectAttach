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
    /// 4.1.查询交易代码响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS4_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTAGTLS2
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTAGTLS2";
        /// <summary>
        /// 4.1.查询交易代码响应集合
        /// </summary>
        [XmlElement("NTAGTLS2Z")]
        public List<NTAGTLS2Z> List { get; set; }
    }
    /// <summary>
    /// 4.1.查询交易代码响应内容
    /// </summary>
    public class NTAGTLS2Z
    {
        /// <summary>
        /// 账户	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 协议号	C(6)
        /// </summary>
        public string CNVNBR { get; set; }
        /// <summary>
        /// 交易代码	C(4)
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 交易代码名称
        /// </summary>
        public string C_TRSTYP { get; set; }
        /// <summary>
        /// 币别	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
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
        /// <summary>
        /// 签约日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime SGNDAT { get; set; }
        /// <summary>
        /// 签约日期	D, 对应<see cref="SGNDAT"/>
        /// </summary>
        [XmlElement("SGNDAT")]
        public string SGNDATStr
        {
            get
            {
                return this.SGNDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SGNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 三方协议标志	C(1)
        /// </summary>
        public string CLTCNV { get; set; }
        /// <summary>
        /// 协议状态	C(1)	A有效 C关闭
        /// </summary>
        public string STSCOD { get; set; }
    }
}
