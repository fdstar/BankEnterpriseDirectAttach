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
    /// 备付金账户余额查询(他行)请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLOTACBL : RqBase<RS_DLOTACBL>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLOTACBL"; set { } }
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<AccQuery> Collection { get; set; }
    }
    /// <summary>
    /// 备付金账户余额查询
    /// </summary>
    public class ReserveAccBalQuery
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
