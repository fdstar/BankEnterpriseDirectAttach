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
    /// 移库通知响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLCDTWNQ : RsBase
    {
        /// <summary>
        /// 经办行 varchar(100)
        /// </summary>
        [XmlElement("operOrg")]
        public string OperOrg { get; set; }
        /// <summary>
        /// 监管企业名称 varchar(122)
        /// </summary>
        [XmlElement("spventnm")]
        public string Spventnm { get; set; }
        /// <summary>
        /// 移库申请日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime MwapyDate { get; set; }
        /// <summary>
        /// 移库申请日期char(8)，格式YYYYMMDD, 对应<see cref="MwapyDate"/>
        /// </summary>
        [XmlElement("mwapyDate")]
        public string MwapyDateStr
        {
            get
            {
                return this.MwapyDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.MwapyDate = tmp;
                }
            }
        }
        /// <summary>
        /// 借款企业名称 varchar(122)
        /// </summary>
        [XmlElement("lonentNm")]
        public string LonentNm { get; set; }
        /// <summary>
        /// 移库通知编号 varchar(20)
        /// </summary>
        [XmlElement("mwntcNo")]
        public string MwntcNo { get; set; }
        /// <summary>
        /// 通知日期 char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime NtcDate { get; set; }
        /// <summary>
        /// 通知日期 char(8)，格式YYYYMMDD, 对应<see cref="NtcDate"/>
        /// </summary>
        [XmlElement("ntcDate")]
        public string NtcDateStr
        {
            get
            {
                return this.NtcDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.NtcDate = tmp;
                }
            }
        }
        /// <summary>
        /// 属性1 varchar(30) ，按约定返回
        /// </summary>
        [XmlElement("field1")]
        public string Field1 { get; set; }
        /// <summary>
        /// 属性2 varchar(60) ，按约定返回
        /// </summary>
        [XmlElement("field2")]
        public string Field2 { get; set; }
        /// <summary>
        /// 属性3 varchar(100) ，按约定返回
        /// </summary>
        [XmlElement("field3")]
        public string Field3 { get; set; }
        /// <summary>
        /// 总记录数 integer
        /// </summary>
        [XmlElement("totnum")]
        public int Totnum { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<MovingInfo> List { get; set; }
    }
    /// <summary>
    /// 移库信息
    /// </summary>
    public class MovingInfo
    {
        /// <summary>
        /// 移出仓库编号 varchar(30)
        /// </summary>
        [XmlElement("mwCode")]
        public string MwCode { get; set; }
        /// <summary>
        /// 移入仓库编号 varchar(30)
        /// </summary>
        [XmlElement("iwCode")]
        public string IwCode { get; set; }
        /// <summary>
        /// 商品代码 varchar(60)
        /// </summary>
        [XmlElement("cmdCode")]
        public string CmdCode { get; set; }
        /// <summary>
        /// 移库数量 decimal(19,2)
        /// </summary>
        [XmlElement("stkNum")]
        public decimal StkNum { get; set; }
        /// <summary>
        /// 车架号 varchar(40)
        /// </summary>
        [XmlElement("vin")]
        public string Vin { get; set; }
        /// <summary>
        /// 合格证编号 varchar(50)
        /// </summary>
        [XmlElement("hgzNo")]
        public string HgzNo { get; set; }
        /// <summary>
        /// 车价 decimal(19,2)
        /// </summary>
        [XmlElement("carPrice")]
        public decimal CarPrice { get; set; }
        /// <summary>
        /// 属性4 varchar(50) ，按约定返回
        /// </summary>
        [XmlElement("field4")]
        public string Field4 { get; set; }
        /// <summary>
        /// 属性5 varchar(50) ，按约定返回
        /// </summary>
        [XmlElement("field5")]
        public string Field5 { get; set; }
        /// <summary>
        /// 属性6 varchar(30) ，按约定返回
        /// </summary>
        [XmlElement("field6")]
        public string Field6 { get; set; }
        /// <summary>
        /// 属性7 varchar(30) ，按约定返回
        /// </summary>
        [XmlElement("field7")]
        public string Field7 { get; set; }
        /// <summary>
        /// 属性8 varchar(30) ，按约定返回
        /// </summary>
        [XmlElement("field8")]
        public string Field8 { get; set; }
        /// <summary>
        /// 属性9 varchar(60) ，按约定返回
        /// </summary>
        [XmlElement("field9")]
        public string Field9 { get; set; }
        /// <summary>
        /// 属性10 varchar(60) ，按约定返回
        /// </summary>
        [XmlElement("field10")]
        public string Field10 { get; set; }
        /// <summary>
        /// 属性11 varchar(100) ，按约定返回
        /// </summary>
        [XmlElement("field11")]
        public string Field11 { get; set; }
        /// <summary>
        /// 属性12 varchar(100) ，按约定返回
        /// </summary>
        [XmlElement("field12")]
        public string Field12 { get; set; }
    }
}
