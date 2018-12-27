using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts
{
    /// <summary>
    /// 收款人账户
    /// </summary>
    public class ACCTTO
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
        /// 收款账号只允许是数字、英文字母和“－”，如果不符合以上格式，系统返回“收款账号字段格式错误”，最大32位  必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 收款人名称，最大50位
        /// </summary>
        [XmlElement(Order = 1)]
        public string NAME { get; set; }
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
        /// 是否转向财务公司内部账户，非必输  1-是，0或空-否
        /// </summary>
        [XmlElement(Order = 5)]
        public int? COLLECT { get; set; }
    }
}
