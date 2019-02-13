using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.20.8进口信用证承兑通知查询响应主体
    /// </summary>
    public class V1_LCACCEPTNOTICEQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.20.8进口信用证承兑通知查询响应主体
        /// </summary>
        public LCACCEPTNOTICEQUERYTRNRS LCACCEPTNOTICEQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.20.8进口信用证承兑通知查询响应主体
    /// </summary>
    public class LCACCEPTNOTICEQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.20.8进口信用证承兑通知查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public LCACCEPTNOTICEQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.20.8进口信用证承兑通知查询响应内容
    /// </summary>
    public class LCACCEPTNOTICEQUERYTRN_RSBODY
    {
        /// <summary>
        /// 是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.20.8进口信用证承兑通知查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 1)]
        public List<LCACCEPTNOTICEQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.20.8进口信用证承兑通知查询响应明细
    /// </summary>
    public class LCACCEPTNOTICEQUERYTRN_CONTENT
    {
        /// <summary>
        /// 地区机构
        /// </summary>
        [XmlElement(Order = 0)]
        public string BRANCHNO { get; set; }
        /// <summary>
        /// 信用证号
        /// </summary>
        [XmlElement(Order = 1)]
        public string LCREFNO { get; set; }
        /// <summary>
        /// 到单号
        /// </summary>
        [XmlElement(Order = 2)]
        public string BPREFNO { get; set; }
        /// <summary>
        /// 参号
        /// </summary>
        [XmlElement(Order = 3)]
        public string PRBREFNO { get; set; }
        /// <summary>
        /// 到期日,YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime MATURITYDATE { get; set; }
        /// <summary>
        /// 到期日 YYYY-MM-DD, 对应<see cref="MATURITYDATE"/>
        /// </summary>
        [XmlElement("MATURITYDATE", Order = 4)]
        public string MATURITYDATEStr
        {
            get
            {
                return this.MATURITYDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.MATURITYDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 受益人 长度：4*35
        /// </summary>
        [XmlElement(Order = 5)]
        public string BENEFICIARY { get; set; }
        /// <summary>
        /// 承兑日期,YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime ACCEPTDATE { get; set; }
        /// <summary>
        /// 承兑日期 YYYY-MM-DD, 对应<see cref="ACCEPTDATE"/>
        /// </summary>
        [XmlElement("ACCEPTDATE", Order = 6)]
        public string ACCEPTDATEStr
        {
            get
            {
                return this.ACCEPTDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ACCEPTDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 承兑金额(3位币种+金额)
        /// </summary>
        [XmlElement(Order = 7)]
        public string ACCEPTAMT { get; set; }
        /// <summary>
        /// 业务日期,YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime BIZCREDATE { get; set; }
        /// <summary>
        /// 业务日期YYYY-MM-DD, 对应<see cref="BIZCREDATE"/>
        /// </summary>
        [XmlElement("BIZCREDATE", Order = 43)]
        public string BIZCREDATEStr
        {
            get
            {
                return this.BIZCREDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BIZCREDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 系统关联业务编号	必回
        /// </summary>
        [XmlElement(Order = 44)]
        public string XTREFERENCE { get; set; }
        /// <summary>
        /// 通知接收到的日期，格式yyyy-MM-dd HH:mm:ss  必回
        /// </summary>
        [XmlIgnore]
        public DateTime CREATETIME { get; set; }
        /// <summary>
        /// 通知接收到的日期，格式yyyy-MM-dd HH:mm:ss, 对应<see cref="CREATETIME"/>  必回
        /// </summary>
        [XmlElement("CREATETIME", Order = 45)]
        public string CREATETIMEStr
        {
            get
            {
                return this.CREATETIME.ToString("yyyy-MM-dd HH:mm:ss");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CREATETIME = tmp;
                }
            }
        }
    }
}
