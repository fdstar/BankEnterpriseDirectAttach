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
    /// 合格证状态查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLCERSTT : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<CertificateStatus> List { get; set; }
    }
    /// <summary>
    ///  合格证状态
    /// </summary>
    public class CertificateStatus
    {
        /// <summary>
        /// 序号 varchar (10)
        /// </summary>
        [XmlElement("dataNo")]
        public string DataNo { get; set; }
        /// <summary>
        /// 主机厂编号varchar(6)
        /// </summary>
        [XmlElement("zzjbh")]
        public string Zzjbh { get; set; }
        /// <summary>
        /// 品牌编号varchar (8)
        /// </summary>
        [XmlElement("zppbh")]
        public string Zppbh { get; set; }
        /// <summary>
        /// SON号 varchar(10)
        /// </summary>
        [XmlElement("vbeln")]
        public string Vbeln { get; set; }
        /// <summary>
        /// VIN码 varchar(18)
        /// </summary>
        [XmlElement("sernr")]
        public string Sernr { get; set; }
        /// <summary>
        /// 快递单号 varchar(20)
        /// </summary>
        [XmlElement("expNo")]
        public string ExpNo { get; set; }
        /// <summary>
        /// 合格证号 varchar(30)
        /// </summary>
        [XmlElement("zeugn")]
        public string Zeugn { get; set; }
        /// <summary>
        /// 处理代码 varchar(1)
        /// </summary>
        [XmlElement("zdeal")]
        public string Zdeal { get; set; }
        /// <summary>
        /// 处理日期 varchar(8)，格式YYYYMMDD
        /// </summary>
        [XmlElement("zdeald")]
        public string Zdeald { get; set; }
        /// <summary>
        /// 处理时间varchar(6)，格式HHMMSS
        /// </summary>
        [XmlElement("zdealt")]
        public string Zdealt { get; set; }
        /// <summary>
        /// 处理时间 由<see cref="Zdeald"/>和<see cref="Zdealt"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? DealTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.Zdeald, this.Zdealt),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 处理人 varchar(12)
        /// </summary>
        [XmlElement("zdealu")]
        public string Zdealu { get; set; }
        /// <summary>
        /// 备注varchar(300)
        /// </summary>
        [XmlElement("zmar")]
        public string Zmar { get; set; }
        /// <summary>
        /// 更新日期varchar(8)，格式YYYYMMDD
        /// </summary>
        [XmlElement("uDate")]
        public string UDate { get; set; }
        /// <summary>
        /// 更新时间varchar(6)，格式HHMMSS
        /// </summary>
        [XmlElement("uTime")]
        public string UTime { get; set; }
        /// <summary>
        /// 更新时间 由<see cref="UDate"/>和<see cref="UTime"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? UpdateTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.UDate, this.UTime),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 属性2 varchar(30)
        /// </summary>
        [XmlElement("field2")]
        public string Field2 { get; set; }
        /// <summary>
        /// 属性3 varchar(60)
        /// </summary>
        [XmlElement("field3")]
        public string Field3 { get; set; }
        /// <summary>
        /// 属性4 varchar(100)
        /// </summary>
        [XmlElement("field4")]
        public string Field4 { get; set; }
    }
}
