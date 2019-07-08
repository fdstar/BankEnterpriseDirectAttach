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
    /// 查询收款单位请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLRECQRY : RqBase<RS_DLRECQRY>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLRECQRY"; set { } }
        /// <summary>
        /// 账号varchar (32) 可空
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 账户类型char(1) ，0：公司；1：个人
        /// </summary>
        [XmlElement("accountType")]
        public int AccountType { get; set; }
        /// <summary>
        /// 账户别名varchar (50)，可空
        /// </summary>
        [XmlElement("accountAlias")]
        public string AccountAlias { get; set; }
        /// <summary>
        /// 账户名称varchar (122)，可空
        /// </summary>
        [XmlElement("accountName")]
        public string AccountName { get; set; }
        /// <summary>
        /// 开户行名称varchar (122)，可空
        /// </summary>
        [XmlElement("openBankName")]
        public string OpenBankName { get; set; }
        /// <summary>
        /// 城市代码char(4)，可空
        /// </summary>
        [XmlElement("cityID")]
        public string CityID { get; set; }
    }
}
