using BEDA.CITIC.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Requests
{
    /// <summary>
    /// 合格证邮寄信息推送请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLCERMIQ : RqBase<RS_DLCERMIQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLCERMIQ"; set { } }

        /// <summary>
        /// 品牌编码varchar (10)，区分不同品牌（网络），可空
        /// </summary>
        [XmlElement("brandCD")]
        public string BrandCD { get; set; }
        /// <summary>
        /// 流水号varchar (20)
        /// </summary>
        [XmlElement("serialNo")]
        public string SerialNo { get; set; }
        /// <summary>
        /// 属性1varchar(30)，可空
        /// </summary>
        [XmlElement("field1")]
        public string Field1 { get; set; }
        /// <summary>
        /// 属性2 varchar(60)，可空
        /// </summary>
        [XmlElement("field2")]
        public string Field2 { get; set; }
        /// <summary>
        /// 属性3varchar(100)，可空
        /// </summary>
        [XmlElement("field3")]
        public string Field3 { get; set; }


        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<CertificateExpressInfo> Collection { get; set; }
    }
    /// <summary>
    /// 合格证邮寄信息
    /// </summary>
    public class CertificateExpressInfo
    {
        /// <summary>
        /// 序号 varchar (10)
        /// </summary>
        [XmlElement("dataNo")]
        public string DataNo { get; set; }
        /// <summary>
        /// 主机厂编号varchar(6)，可空
        /// </summary>
        [XmlElement("zzjbh")]
        public string Zzjbh { get; set; }
        /// <summary>
        /// 品牌编号varchar(8)，可空
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
        /// 回执单号 varchar(17)
        /// </summary>
        [XmlElement("rcpNo")]
        public string RcpNo { get; set; }
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
        /// 邮寄时间
        /// </summary>
        [XmlIgnore]
        public DateTime MailingTime { get; set; }
        /// <summary>
        /// 邮寄日期 varchar(8)，格式YYYYMMDD
        /// </summary>
        [XmlElement("dtMail")]
        public string DtMailStr
        {
            get
            {
                return this.MailingTime.ToString("yyyyMMdd");
            }
            set { }
        }
        /// <summary>
        /// 邮寄时间varchar(6)，格式HHMMSS
        /// </summary>
        [XmlElement("tmMail")]
        public string TmMailStr
        {
            get
            {
                return this.MailingTime.ToString("HHmmss");
            }
            set { }
        }
        /// <summary>
        /// 邮寄人 varchar(12)
        /// </summary>
        [XmlElement("usrMail")]
        public string UsrMail { get; set; }
        /// <summary>
        /// 备注varchar(300)，可空
        /// </summary>
        [XmlElement("zmar")]
        public string Zmar { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlIgnore]
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 更新日期varchar(8)，可空，格式YYYYMMDD
        /// </summary>
        [XmlElement("uDate")]
        public string UDateStr
        {
            get
            {
                return this.UpdateTime?.ToString("yyyyMMdd");
            }
            set { }
        }
        /// <summary>
        /// 更新时间varchar(6)，可空，格式HHMMSS 
        /// </summary>
        [XmlElement("uTime")]
        public string UTimeStr
        {
            get
            {
                return this.UpdateTime?.ToString("HHmmss");
            }
            set { }
        }
        /// <summary>
        /// 属性4varchar(30)，可空
        /// </summary>
        [XmlElement("field4")]
        public string Field4 { get; set; }
        /// <summary>
        /// 属性5varchar(60)，可空
        /// </summary>
        [XmlElement("field5")]
        public string Field5 { get; set; }
        /// <summary>
        /// 属性6varchar(100)，可空
        /// </summary>
        [XmlElement("field6")]
        public string Field6 { get; set; }
    }
}