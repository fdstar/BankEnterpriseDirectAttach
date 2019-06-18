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
    /// 不归集额度查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLCMGSBQ : RqBase<RS_DLCMGSBQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLCMGSBQ"; set { } }
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
        /// 查询类型 char(1) 0：未启用；1：已启用；为空则查全部
        /// </summary>
        [XmlElement("qryType")]
        public int? QryType { get; set; }
    }
}
