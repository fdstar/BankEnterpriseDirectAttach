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
    /// 应付账单请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLOWNPAY : RqBase<RS_DLOWNPAY>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLOWNPAY"; set { } }
        /// <summary>
        /// 客户流水号 varchar(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 签约账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 经办标志 char(1) 0：同意；1：拒绝
        /// </summary>
        [XmlElement("tranFlg")]
        public int TranFlg { get; set; }
        /// <summary>
        /// 拒绝原因 varchar(200) 经办标志为1（拒绝）时非空
        /// </summary>
        [XmlElement("refRem")]
        public string RefRem { get; set; }
        /// <summary>
        /// 账单流水号char(20) ，由应付账单经办查询返回
        /// </summary>
        [XmlElement("payOrderNo")]
        public string PayOrderNo { get; set; }
    }
}
