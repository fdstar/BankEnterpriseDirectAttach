using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.6.6虚拟子账户余额及交易明细查询请求主体
    /// </summary>
    public class V1_VATSTMTTRNRQ : IRequest<V1_VATSTMTTRNRS>
    {
        /// <summary>
        /// 3.6.6虚拟子账户余额及交易明细查询请求主体
        /// </summary>
        public VATSTMTTRNRQ VATSTMTTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.6.6虚拟子账户余额及交易明细查询请求主体
    /// </summary>
    public class VATSTMTTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.6.6虚拟子账户余额及交易明细查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public VATSTMTRQ VATSTMTRQ { get; set; }
    }
    /// <summary>
    /// 3.6.6虚拟子账户余额及交易明细查询请求内容
    /// </summary>
    public class VATSTMTRQ
    {
        /// <summary>
        /// 支付类型：1－虚拟子账户对外支付	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public int VATTYPE { get; set; } = 1;
        /// <summary>
        /// 实体扣款账户，最大18位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string MAINACCT { get; set; }
        /// <summary>
        /// 虚拟小序号, 最大6位	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string SUBACCT { get; set; }
        /// <summary>
        /// 付款账户信息	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public ACCTFROM ACCTFROM { get; set; }
        /// <summary>
        /// 包含交易流水（未指定起止时间，表示查余额；若指定起止时间，那么：1）开始时间=结束时间；2）开始时间早于结束时间，并且结束时间不为当天。建议查询指定某一天的流水，避免网络传输带来的超时）。日期信息未填写，表示只查询企业内部账户余额。	非必输
        /// </summary>
        [XmlElement(Order = 4)]
        public VATSTMTRQ_INCTRAN INCTRAN { get; set; }
    }
    /// <summary>
    /// 包含交易流水，非必输（未指定起止时间，表示查余额；若指定起止时间，那么：1）开始时间=结束时间；2）开始时间早于结束时间，并且结束时间不为当天。。建议查询指定某一天的流水，避免网络传输带来的超时）
    /// </summary>
    public class VATSTMTRQ_INCTRAN
    {
        /// <summary>
        /// 开始时间 格式：yyyy-MM-dd(必输)
        /// </summary>
        [XmlIgnore]
        public DateTime? DTSTART { get; set; }
        /// <summary>
        /// 开始时间 格式：yyyy-MM-dd ,对应<see cref="DTSTART"/>	必输
        /// </summary>
        [XmlElement("DTSTART", Order = 0)]
        public string DTSTARTStr
        {
            get
            {
                return this.DTSTART?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.DTSTART = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 结束时间 格式：yyyy-MM-dd(必输)
        /// </summary>
        [XmlIgnore]
        public DateTime? DTEND { get; set; }
        /// <summary>
        /// 结束时间 格式：yyyy-MM-dd ,对应<see cref="DTEND"/>	必输
        /// </summary>
        [XmlElement("DTEND", Order = 1)]
        public string DTENDStr
        {
            get
            {
                return this.DTEND?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.DTEND = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 请求响应的页数（代表从第几页开始查询）（必输）
        /// </summary>
        [XmlElement(Order = 2)]
        public int PAGE { get; set; } = 1;
    }
}
