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
    /// 定期对账请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLREGREC : RqBase<RS_DLREGREC>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLREGREC"; set { } }
        /// <summary>
        /// 流水号varchar (20)
        /// </summary>
        [XmlElement("serialNo")]
        public string SerialNo { get; set; }
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<RegularReconciliation> Collection { get; set; }
    }
    /// <summary>
    /// 定期对账
    /// </summary>
    public class RegularReconciliation
    {
        /// <summary>
        /// 企业端经销商客户代码 varchar (20)
        /// </summary>
        [XmlElement("cpCustCD")]
        public string CpCustCD { get; set; }
        /// <summary>
        /// 当前实时剩余可发车余额decimal(19.2)
        /// </summary>
        [XmlElement("levavAmt")]
        public decimal LevavAmt { get; set; }
        /// <summary>
        /// 历史累计入账金额decimal(19.2)
        /// </summary>
        [XmlElement("histalAmt")]
        public decimal HistalAmt { get; set; }
        /// <summary>
        /// 发送日期
        /// </summary>
        [XmlIgnore]
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 发送日期 varchar(8)，可空，格式YYYYMMDD，为空时默认取更新日期
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
        /// 发送时间 varchar(6)，可空，格式HHMMSS，为空时默认取更新时间
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
    }
}
