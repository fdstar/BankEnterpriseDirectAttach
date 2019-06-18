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
    /// 现金池自动规则查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLPARBSQ : RqBase<RS_DLPARBSQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLPARBSQ"; set { } }
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
        /// 查询类型char(1) 0：自动归集参数；1自动下拨参数；2：联动下拨参数
        /// </summary>
        [XmlElement("qryType")]
        public int QryType { get; set; }
    }
}
