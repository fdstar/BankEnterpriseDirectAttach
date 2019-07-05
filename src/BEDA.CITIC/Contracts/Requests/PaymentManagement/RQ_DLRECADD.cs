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
    /// 增加收款单位请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLRECADD : RqBase<RS_DLRECADD>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLRECADD"; set { } }
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<AddPayee> Collection { get; set; }
    }
    /// <summary>
    /// 收款单位
    /// </summary>
    public class AddPayee
    {
        /// <summary>
        /// 中信标识char(1) ，0：中信；1：他行
        /// </summary>
        [XmlElement("citicbankFlag")]
        public int CiticbankFlag { get; set; }
        /// <summary>
        /// 账户类别char(1) ，0：公司；1：个人
        /// </summary>
        [XmlElement("accountType")]
        public int AccountType { get; set; }
        /// <summary>
        /// 账号varchar(32)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 账户名称varchar (122)
        /// </summary>
        [XmlElement("accountName")]
        public string AccountName { get; set; }
        /// <summary>
        /// 账户别名varchar (50)，可空
        /// </summary>
        [XmlElement("accountAlias")]
        public string AccountAlias { get; set; }
        /// <summary>
        /// 开户行名称varchar(122)，中信标识为0时可空；中信标识为1时,开户名称与开户行联行网点号必输一项
        /// </summary>
        [XmlElement("openBankName")]
        public string OpenBankName { get; set; }
        /// <summary>
        /// 开户行联行网点号varchar(20) 中信标识为0时可空; 中信标识为1时,开户名称与开户行联行网点号必输一项
        /// </summary>
        [XmlElement("openBankCode")]
        public string OpenBankCode { get; set; }
        /// <summary>
        /// 货币代码char(2)
        /// </summary>
        [XmlElement("currencyID")]
        public string CurrencyID { get; set; }
        /// <summary>
        /// 城市代码char(4)
        /// </summary>
        [XmlElement("cityID")]
        public string CityID { get; set; }
    }
}
