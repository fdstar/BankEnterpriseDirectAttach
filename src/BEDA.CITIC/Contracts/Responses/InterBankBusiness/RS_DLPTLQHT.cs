using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// 查询业务协议查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLPTLQHT : RsBase
    {
        /// <summary>
        /// 总记录条数 int
        /// </summary>
        [XmlElement("totalRecords")]
        public int TotalRecords { get; set; }
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<InterBankQueryProtocol> List { get; set; }
    }
    /// <summary>
    /// 查询业务协议
    /// </summary>
    public class InterBankQueryProtocol
    {
        /// <summary>
        /// 协议编号varchar(60)
        /// </summary>
        [XmlElement("ptcID")]
        public string PtcID { get; set; }
        /// <summary>
        /// 被查询机构号varchar(20)
        /// </summary>
        [XmlElement("bqryAccBankNo")]
        public string BqryAccBankNo { get; set; }
        /// <summary>
        /// 被查询机构名称varchar(122)
        /// </summary>
        [XmlElement("bqryAccBankNm")]
        public string BqryAccBankNm { get; set; }
        /// <summary>
        /// 被查询账号varchar(32)
        /// </summary>
        [XmlElement("bqryAccNo")]
        public string BqryAccNo { get; set; }
        /// <summary>
        /// 被查询账户名称varchar(122)
        /// </summary>
        [XmlElement("bqryAccNm")]
        public string BqryAccNm { get; set; }
        /// <summary>
        /// 被查询账户类型varchar(4)
        /// </summary>
        [XmlElement("bqryAccType")]
        public string BqryAccType { get; set; }
        /// <summary>
        /// 查询机构号varchar(20)
        /// </summary>
        [XmlElement("qryAccBankNo")]
        public string QryAccBankNo { get; set; }
        /// <summary>
        /// 查询机构名称varchar(122)
        /// </summary>
        [XmlElement("qryAccBankNm")]
        public string QryAccBankNm { get; set; }
        /// <summary>
        /// 查询账号varchar(32)
        /// </summary>
        [XmlElement("qryAccNo")]
        public string QryAccNo { get; set; }
        /// <summary>
        /// 查询账户名称varchar(122)
        /// </summary>
        [XmlElement("qryAccNm")]
        public string QryAccNm { get; set; }
        /// <summary>
        /// 签约日期char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime PtcDate { get; set; }
        /// <summary>
        /// 签约日期char(8) 格式YYYYMMDD, 对应<see cref="PtcDate"/>
        /// </summary>
        [XmlElement("ptcDate")]
        public string PtcDateStr
        {
            get
            {
                return this.PtcDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PtcDate = tmp;
                }
            }
        }
        /// <summary>
        /// 协议状态 char(2) 附录4.6
        /// </summary>
        [XmlElement("ptcStt")]
        public string PtcStt { get; set; }
    }
}
