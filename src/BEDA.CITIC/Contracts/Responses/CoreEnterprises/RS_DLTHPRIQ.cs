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
    /// 第三方监管信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLTHPRIQ : RsBase
    {

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<ThirdPartyRegulatoryInfo> List { get; set; }
    }
    /// <summary>
    /// 第三方监管信息
    /// </summary>
    public class ThirdPartyRegulatoryInfo
    {
        /// <summary>
        /// 车架号 varchar(20)
        /// </summary>
        [XmlElement("chasNo")]
        public string ChasNo { get; set; }
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
        /// 三方协议编号 varchar(22)
        /// </summary>
        [XmlElement("sfxybh")]
        public string Sfxybh { get; set; }
        /// <summary>
        /// 经销商代码 varchar(10)
        /// </summary>
        [XmlElement("kunnr")]
        public string Kunnr { get; set; }
        /// <summary>
        /// 经销商融资专员 varchar(30)
        /// </summary>
        [XmlElement("zrzy")]
        public string Zrzy { get; set; }
        /// <summary>
        /// 联系电话 varchar(30)
        /// </summary>
        [XmlElement("telf1")]
        public string Telf1 { get; set; }
        /// <summary>
        /// 库存融资联系人 varchar(30)
        /// </summary>
        [XmlElement("zkCrz")]
        public string ZkCrz { get; set; }
        /// <summary>
        /// 联系电话 varchar(30)
        /// </summary>
        [XmlElement("kcTel")]
        public string KcTel { get; set; }
        /// <summary>
        /// 零售融资联系人varchar(30)
        /// </summary>
        [XmlElement("lsCrz")]
        public string LsCrz { get; set; }
        /// <summary>
        /// 联系电话 varchar(30)
        /// </summary>
        [XmlElement("lsTel")]
        public string LsTel { get; set; }
        /// <summary>
        /// 合格证邮寄地址varchar(100)
        /// </summary>
        [XmlElement("lsAdr")]
        public string LsAdr { get; set; }
        /// <summary>
        /// 邮编varchar(10)
        /// </summary>
        [XmlElement("pstlz")]
        public string Pstlz { get; set; }
        /// <summary>
        /// 接收人varchar(30)
        /// </summary>
        [XmlElement("zjsr")]
        public string Zjsr { get; set; }
        /// <summary>
        /// 联系电话varchar(30)
        /// </summary>
        [XmlElement("zsTel")]
        public string ZsTel { get; set; }
        /// <summary>
        /// 备用接收人varchar(30)
        /// </summary>
        [XmlElement("byLxr")]
        public string ByLxr { get; set; }
        /// <summary>
        /// 联系电话varchar(30)
        /// </summary>
        [XmlElement("byTel")]
        public string ByTel { get; set; }
        /// <summary>
        /// 第三方监管公司varchar(20)
        /// </summary>
        [XmlElement("jggs")]
        public string Jggs { get; set; }
        /// <summary>
        /// 删除标记varchar(1)
        /// </summary>
        [XmlElement("delflg")]
        public string Delflg { get; set; }
        /// <summary>
        /// 更新日期varchar(8)，格式YYYYMMDD
        /// </summary>
        [XmlElement("uDdate")]
        public string UDdate { get; set; }
        /// <summary>
        /// 更新时间varchar(6)，格式HHMMSS
        /// </summary>
        [XmlElement("uTime")]
        public string UTime { get; set; }
        /// <summary>
        /// 更新时间 由<see cref="UDdate"/>和<see cref="UTime"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? UpdateTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.UDdate, this.UTime),
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
