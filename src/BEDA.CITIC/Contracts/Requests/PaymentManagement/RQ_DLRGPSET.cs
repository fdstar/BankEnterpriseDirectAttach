using BEDA.CITIC.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Requests
{
    /// <summary>
    /// 收款单位分组设置请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLRGPSET : RqBase<RS_DLRGPSET>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLRGPSET"; set { } }
        /// <summary>
        /// 付款账号char(19)
        /// </summary>
        [XmlElement("payAccount")]
        public string PayAccount { get; set; }
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<PayeeGroupSetting> Collection { get; set; }
    }
    /// <summary>
    /// 收款单位分组设置
    /// </summary>
    public class PayeeGroupSetting
    {
        /// <summary>
        /// 分组设置类型char(1)，A：新增；D：删除
        /// </summary>
        [XmlElement("grpSetType")]
        public string GrpSetType { get; set; }
        /// <summary>
        /// 收款账号varchar (32)
        /// </summary>
        [XmlElement("rcvAccount")]
        public string RcvAccount { get; set; }
    }
}
