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
    /// 集团服务归集调拨查询响应主体
    /// </summary>
    public class V1_CMTRANSDETAILTRNRS : IResponse
    {
        /// <summary>
        /// 集团服务归集调拨查询响应主体
        /// </summary>
        public CMTRANSDETAILTRNRS CMTRANSDETAILTRNRS { get; set; }
    }
    /// <summary>
    /// 集团服务归集调拨查询响应主体
    /// </summary>
    public class CMTRANSDETAILTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 集团服务归集调拨查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CMTRANSDETAILTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 集团服务归集调拨查询响应内容
    /// </summary>
    public class CMTRANSDETAILTRN_RSBODY
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 集团服务归集调拨查询明细集合
        /// </summary>
        [XmlElement("CONTENT")]
        public List<CMTRANSDETAILTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 集团服务归集调拨查询明细
    /// </summary>
    public class CMTRANSDETAILTRN_CONTENT
    {
        /// <summary>
        /// 结算中心信息
        /// </summary>
        [XmlElement(Order = 0)]
        public ACCT FUNDACCT { get; set; }
        /// <summary>
        /// 成员单位账户代号
        /// </summary>
        [XmlElement(Order = 1)]
        public ACCT MBRACCT { get; set; }
        /// <summary>
        /// 归集调拨方向，0-下拨；1－归集；
        /// </summary>
        [XmlElement(Order = 2)]
        public int DIRECT { get; set; }
        /// <summary>
        /// 金额，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 可用余额，成员单位留存再结算中心的可用额度，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal AVAILBAL { get; set; }
        /// <summary>
        /// 记账日期，YYYY-MM-DD
        /// </summary>
        [XmlElement(Order = 5)]
        public string DTACCT { get; set; }
        /// <summary>
        /// 记账时间,HH:MM:SS
        /// </summary>
        [XmlElement(Order = 6)]
        public string TMACCT { get; set; }
        /// <summary>
        /// 记账时间，如果获取失败则返回null
        /// </summary>
        [XmlIgnore]
        public DateTime? AccountingTime
        {
            get
            {
                if (DateTime.TryParseExact(DTACCT + TMACCT, new string[] { "yyyy-MM-dd", "yyyy-MM-ddHH:mm:ss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime time))
                {
                    return time;
                }
                return null;
            }
            set
            {
                this.DTACCT = value?.ToString("yyyy-MM-dd");
                this.TMACCT = value?.ToString("HHmmss");
            }
        }
    }
}
