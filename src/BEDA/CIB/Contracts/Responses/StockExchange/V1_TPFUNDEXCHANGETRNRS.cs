using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.5.4第三方存管银证资金互转响应主体
    /// </summary>
    public class V1_TPFUNDEXCHANGETRNRS : IResponse
    {
        /// <summary>
        /// 3.5.4第三方存管银证资金互转响应主体
        /// </summary>
        public TPFUNDEXCHANGETRNRS TPFUNDEXCHANGETRNRS { get; set; }
    }
    /// <summary>
    /// 3.5.4第三方存管银证资金互转响应主体
    /// </summary>
    public class TPFUNDEXCHANGETRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.5.4第三方存管银证资金互转响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public TPFUNDEXCHANGETRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.5.4第三方存管银证资金互转响应内容
    /// </summary>
    public class TPFUNDEXCHANGETRN_RSBODY
    {
        /// <summary>
        /// 账户代号，最长32位
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 账户名称，最长60位
        /// </summary>
        [XmlElement(Order = 1)]
        public string NAME { get; set; }
        /// <summary>
        /// 资金账户，最长20位
        /// </summary>
        [XmlElement(Order = 2)]
        public string FUNDACCTID { get; set; }
        /// <summary>
        /// 开户券商机构代号，最长8位
        /// </summary>
        [XmlElement(Order = 3)]
        public string BROKER { get; set; }
        /// <summary>
        /// 可支取余额，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal? WDBAL { get; set; }
        /// <summary>
        /// 币种,2位
        /// </summary>
        [XmlElement(Order = 5)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 凭证号，8位，最长9位
        /// </summary>
        [XmlElement(Order = 6)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 转账类型 0 银行转证券 1 证券转银行
        /// </summary>
        [XmlElement(Order = 7)]
        public int TRNTYPE { get; set; }
        /// <summary>
        /// 转账金额，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 指令处理状态	必回
        /// </summary>
        [XmlElement(Order = 9)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
        /// <summary>
        /// 券商名称，2.0版回
        /// </summary>
        [XmlElement(Order = 10)]
        public string TRUSTEENAME { get; set; }
    }
}
