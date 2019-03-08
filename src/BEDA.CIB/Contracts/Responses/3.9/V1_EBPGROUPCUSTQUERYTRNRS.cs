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
    /// 3.9.3.11电子商业汇票集团关系查询响应主体
    /// </summary>
    public class V1_EBPGROUPCUSTQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.3.11电子商业汇票集团关系查询响应主体
        /// </summary>
        public EBPGROUPCUSTQUERYTRNRS EBPGROUPCUSTQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.3.11电子商业汇票集团关系查询响应主体
    /// </summary>
    public class EBPGROUPCUSTQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.3.11电子商业汇票集团关系查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPGROUPCUSTQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.11电子商业汇票集团关系查询响应内容
    /// </summary>
    public class EBPGROUPCUSTQUERYTRN_RSBODY
    {
        /// <summary>
        /// 集团客户号	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string GRPCID { get; set; }
        /// <summary>
        /// 集团票据池编号	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string GRPBILLPOOLNO { get; set; }
        /// <summary>
        /// 集团客户名称	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string GRPNAME { get; set; }
        /// <summary>
        /// 集团票据池状态，0-已解约 1-已签约	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public int GRPBILLPOOLSTATUS { get; set; }
        /// <summary>
        /// 成员单位数量	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public int MEMBERCOUNT { get; set; }
        /// <summary>
        /// 集团签约机构号	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public string GRPSIGNORGNO { get; set; }
        /// <summary>
        /// 集团签约机构名称	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public string GRPSIGNORGNAME { get; set; }
        /// <summary>
        /// 集团签约日期 YYYY-MM-DD 必回
        /// </summary>
        [XmlIgnore]
        public DateTime GRPSIGNDATE { get; set; }
        /// <summary>
        /// 集团签约日期，格式yyyy-MM-dd ,对应<see cref="GRPSIGNDATE"/> 必回
        /// </summary>
        [XmlElement("GRPSIGNDATE", Order = 8)]
        public string GRPSIGNDATEStr
        {
            get
            {
                return this.GRPSIGNDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.GRPSIGNDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 集团联系人	非必回
        /// </summary>
        [XmlElement(Order = 9)]
        public string GRPLINKMAN { get; set; }
        /// <summary>
        /// 集团联系电话	必回
        /// </summary>
        [XmlElement(Order = 10)]
        public string GRPLINKPHONE { get; set; }
        /// <summary>
        /// 3.9.3.11电子商业汇票集团关系查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 20)]
        public List<EBPGROUPCUSTQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.3.11电子商业汇票集团关系查询响应内容
    /// </summary>
    public class EBPGROUPCUSTQUERYTRN_CONTENT
    {
        /// <summary>
        /// 小序号	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public int INDX { get; set; }
        /// <summary>
        /// 成员单位客户号	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string MEMBERCID { get; set; }
        /// <summary>
        /// 成员单位客户名称	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string MEMBERNAME { get; set; }
        /// <summary>
        /// 签约机构号	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string MEMBERSIGNROGNO { get; set; }
        /// <summary>
        /// 签约机构名称	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string MEMBERSIGNORGNAME { get; set; }
        /// <summary>
        /// 签约日期 YYYY-MM-DD 必回
        /// </summary>
        [XmlIgnore]
        public DateTime MEMBERSIGNDATE { get; set; }
        /// <summary>
        /// 签约日期，格式yyyy-MM-dd ,对应<see cref="MEMBERSIGNDATE"/> 必回
        /// </summary>
        [XmlElement("MEMBERSIGNDATE", Order = 6)]
        public string MEMBERSIGNDATEStr
        {
            get
            {
                return this.MEMBERSIGNDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.MEMBERSIGNDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 票据池状态，0-已解约 1-已签约	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public string MEMBERBILLPOOLSTATUS { get; set; }
    }
}
