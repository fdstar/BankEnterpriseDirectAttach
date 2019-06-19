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
    /// 不归集额度计划管理请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLPLMSUB : RqBase<RS_DLPLMSUB>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLPLMSUB"; set { } }
        /// <summary>
        /// 成员单位账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 现金池ID  char(8) 由现金池信息查询结果获取
        /// </summary>
        [XmlElement("poolID")]
        public string PoolID { get; set; }
        /// <summary>
        /// 客户流水号 varchar(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 计划编号 char(10)，由不归集额度计划管理经办查询返回
        /// </summary>
        [XmlElement("planNo")]
        public string PlanNo { get; set; }
        /// <summary>
        /// 操作类型 char(1) 0：启用；1：暂停；2：撤销
        /// </summary>
        [XmlElement("oprateType")]
        public int OprateType { get; set; }
    }
}
