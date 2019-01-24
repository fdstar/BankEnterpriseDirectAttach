using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts
{
    /// <summary>
    /// 账户信息
    /// </summary>
    public class ACCT
    {
        /// <summary>
        /// 账号  最长32位
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 名称  最长60位
        /// </summary>
        [XmlElement(Order = 1)]
        public string NAME { get; set; }
    }
    /// <summary>
    /// 账户信息（含金额）
    /// </summary>
    public class ACCTAMT : ACCT
    {
        /// <summary>
        /// 账户余额，，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal BALAMT { get; set; }
    }
    /// <summary>
    /// 付款人账户
    /// </summary>
    public class ACCTFROM : ACCT
    {
        /// <summary>
        /// 开户行名称(可选) 未限制，仅在报文中体现
        /// </summary>
        [XmlElement(Order = 2)]
        public string BANKDESC { get; set; }
        /// <summary>
        /// 兑付城市(可选) 未限制，仅在报文中体现
        /// </summary>
        [XmlElement(Order = 3)]
        public string CITY { get; set; }
    }    /// <summary>
         /// 收款人账户，收款账号只允许是数字、英文字母和“－”，如果不符合以上格式，系统返回“收款账号字段格式错误”
         /// </summary>
    public class ACCTTO : ACCT
    {
        /// <summary>
        /// 是否行内账户,Y/N 必输
        /// </summary>
        [XmlAttribute]
        public string INTERBANK { get; set; }
        /// <summary>
        /// 是否同城转账,Y/N 必输
        /// </summary>
        [XmlAttribute]
        public string LOCAL { get; set; }
        /// <summary>
        /// 收款人开户行名称。非兴业银行账号时，收款人开户行名称必输,且不应包含“兴业银行”字样，否则返回“您的收款账号不是兴业银行账号”并不允许提交，最大50位
        /// </summary>
        [XmlElement(Order = 2)]
        public string BANKDESC { get; set; }
        /// <summary>
        /// 收款人收报行号，12位
        /// </summary>
        [XmlElement(Order = 3)]
        public string BANKNUM { get; set; }
        /// <summary>
        /// 收款人城市，同城无需填写，异地汇款填入收款行城市名称（建议客户端控制，否则可能不能正常转账），最大30位
        /// </summary>
        [XmlElement(Order = 4)]
        public string CITY { get; set; }
        /// <summary>
        /// 是否转向财务公司内部账户，非必输  1-是，0或空-否 注意只有在支付时才可以按需输入该值，否则会导致异常
        /// </summary>
        [XmlElement(Order = 5)]
        public string COLLECT { get; set; }
    }
    /// <summary>
    /// 关联账户信息
    /// </summary>
    public class CORRELATEACCT : ACCT
    {
        /// <summary>
        /// 开户行号，最长15位
        /// </summary>
        [XmlElement(Order = 2)]
        public string BANKNUM { get; set; }
        /// <summary>
        /// 开户行名称，最长60位
        /// </summary>
        [XmlElement(Order = 3)]
        public string BANKDESC { get; set; }
    }
}
