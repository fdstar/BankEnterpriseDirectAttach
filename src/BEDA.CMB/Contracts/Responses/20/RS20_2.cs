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
    /// 20.2.查询授权帐号列表响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS20_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTLPALST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLPALST";
        /// <summary>
        /// 20.2.查询授权帐号列表响应集合
        /// </summary>
        [XmlElement("NTLPALSTZ1")]
        public List<NTLPALSTZ1> List { get; set; }
    }
    /// <summary>
    /// 20.2.查询授权帐号列表响应内容
    /// </summary>
    public class NTLPALSTZ1
    {
        /// <summary>
        /// 授权账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 授权账号注解	Z(62)
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 生效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? EFTDAT { get; set; }
        /// <summary>
        /// 生效日期	D, 对应<see cref="EFTDAT"/>
        /// </summary>
        [XmlElement("EFTDAT")]
        public string EFTDATStr
        {
            get
            {
                return this.EFTDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.EFTDAT = null;
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
        public DateTime? ENDDAT { get; set; }
        /// <summary>
        /// 失效日期	D, 对应<see cref="ENDDAT"/>
        /// </summary>
        [XmlElement("ENDDAT")]
        public string ENDDATStr
        {
            get
            {
                return this.ENDDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.ENDDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 状态	C(1)    A：生效
        /// </summary>
        public string STSCOD { get; set; }
    }
}
