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
    /// 他行账户余额查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLOACCBL : RqBase<AccQryFromOther, RS_DLOACCBL>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLOACCBL"; set { } }
    }
    /// <summary>
    /// 他行账户信息
    /// </summary>
    public class AccQryFromOther
    {
        /// <summary>
        /// 他行账号 varchar(32)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 查询类型 char(1)  0：本地查询；1：同步余额
        /// </summary>
        [XmlElement("qryType")]
        public int QryType { get; set; }
    }
}
