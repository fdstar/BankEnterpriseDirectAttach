using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// 成员单位可用资金查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_CMMACQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<AvailableFunds> List { get; set; }
    }
    /// <summary>
    /// 可用资金
    /// </summary>
    public class AvailableFunds
    {
        /// <summary>
        /// 响应码 char(7)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
        /// <summary>
        /// 响应信息 varchar(254)
        /// </summary>
        [XmlElement("statusText")]
        public string StatusText { get; set; }
        /// <summary>
        /// 成员单位账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 账户名称 varchar(122)
        /// </summary>
        [XmlElement("accountName")]
        public string AccountName { get; set; }
        /// <summary>
        /// 币种 char(2)
        /// </summary>
        [XmlElement("currencyID")]
        public string CurrencyID { get; set; }
        /// <summary>
        /// 开户行名称 varchar(122)
        /// </summary>
        [XmlElement("openBankName")]
        public string OpenBankName { get; set; }
        /// <summary>
        /// 成员单位账户类型 char(1) 0：一般账户；1：归集账户；2：核心账户；3：核心归集账户
        /// </summary>
        public int ACTP { get; set; }
        /// <summary>
        /// 资金管理标志 char(1)  0：自身平衡；1：限额透支；2：全额透支；3：超归集下拨；4：看管；5：委存委贷
        /// </summary>
        public int ZJFG { get; set; }
        /// <summary>
        /// 日终填平序号 char(4)
        /// </summary>
        public string TPXH { get; set; }
        /// <summary>
        /// 可用资金 decimal(15,2)
        /// </summary>
        public decimal ZJBL { get; set; }
        /// <summary>
        /// 实际余额 decimal(15,2)
        /// </summary>
        public decimal ACBL { get; set; }
        /// <summary>
        /// 冻结金额 decimal(15,2)
        /// </summary>
        public decimal FZAM { get; set; }
        /// <summary>
        /// 应付未付金额 decimal(15,2)
        /// </summary>
        public decimal FYAM { get; set; }
        /// <summary>
        /// 自身法人透支可用额度 decimal(15,2)
        /// </summary>
        public decimal ZTKD { get; set; }
        /// <summary>
        /// 自身可用余额decimal(15,2)
        /// </summary>
        public decimal KYBL { get; set; }
        /// <summary>
        /// 集团分配透支额度decimal(15,2)
        /// </summary>
        public decimal TZED { get; set; }
        /// <summary>
        /// 可用集团分配透支金额decimal(15,2)
        /// </summary>
        public decimal TZKD { get; set; }
        /// <summary>
        /// 贡献金额decimal(15,2)
        /// </summary>
        public decimal GXAM { get; set; }
        /// <summary>
        /// 超归集自动下拨额度decimal(15,2)
        /// </summary>
        public decimal XBED { get; set; }
        /// <summary>
        /// 集团看管金额decimal(15,2)
        /// </summary>
        public decimal KGED { get; set; }
        /// <summary>
        /// 成员单位主池ID char(8)
        /// </summary>
        public string MPID { get; set; }
        /// <summary>
        /// 可拨款金额 decimal(15,2)
        /// </summary>
        public decimal BKAM { get; set; }
        /// <summary>
        /// 拨款的核心账号 char(19)
        /// </summary>
        public string HXAC { get; set; }
        /// <summary>
        /// 归集下拨路径char(1) 0：单笔委存委贷；1：直接转帐；2：合笔委存委贷
        /// </summary>
        public int LDPH { get; set; }
    }
}
