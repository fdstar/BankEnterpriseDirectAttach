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
    /// 大额查询查复历史信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBADHHQ : RsBase
    {
        /// <summary>
        /// 总笔数int
        /// </summary>
        [XmlElement("totalNum")]
        public int TotalNum { get; set; }
        /// <summary>
        /// 票据号varchar(16)
        /// </summary>
        [XmlElement("billNo")]
        public string BillNo { get; set; }
        
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<BigQueryHistory> List { get; set; }
    }
    /// <summary>
    /// 大额查询查复历史信息
    /// </summary>
    public class BigQueryHistory
    {
        /// <summary>
        /// 大额查询查复日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime QryBigDate { get; set; }
        /// <summary>
        /// 大额查询查复日期char(8)，格式YYYYMMDD, 对应<see cref="QryBigDate"/>
        /// </summary>
        [XmlElement("qryBigDate")]
        public string QryBigDateStr
        {
            get
            {
                return this.QryBigDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.QryBigDate = tmp;
                }
            }
        }
        /// <summary>
        /// 大额查询公文编号varchar(100)
        /// </summary>
        [XmlElement("qryNo")]
        public string QryNo { get; set; }
        /// <summary>
        /// 大额查复公文编号varchar(100)
        /// </summary>
        [XmlElement("resNo")]
        public string ResNo { get; set; }
        /// <summary>
        /// 查询内容varchar(512)
        /// </summary>
        [XmlElement("qryInfo")]
        public string QryInfo { get; set; }
        /// <summary>
        /// 大额查复内容varchar(512)
        /// </summary>
        [XmlElement("resInfo")]
        public string ResInfo { get; set; }
        /// <summary>
        /// 收报行行号varchar(20)
        /// </summary>
        [XmlElement("recvBankNo")]
        public string RecvBankNo { get; set; }
        /// <summary>
        /// 查复行行号varchar(20)
        /// </summary>
        [XmlElement("resBankNo")]
        public string ResBankNo { get; set; }
        /// <summary>
        /// 查询行行号varchar(20)
        /// </summary>
        [XmlElement("qryBankNo")]
        public string QryBankNo { get; set; }
        /// <summary>
        /// 查询日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime QryDate { get; set; }
        /// <summary>
        /// 查询日期char(8)，格式YYYYMMDD, 对应<see cref="QryDate"/>
        /// </summary>
        [XmlElement("qryDate")]
        public string QryDateStr
        {
            get
            {
                return this.QryDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.QryDate = tmp;
                }
            }
        }
    }
}
