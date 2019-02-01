using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.19.6跨境资金池集中收付汇请求主体
    /// </summary>
    public class V1_CBCPTRANSFERTRNRQ : IRequest<V1_CBCPTRANSFERTRNRS>
    {
        /// <summary>
        /// 3.19.6跨境资金池集中收付汇请求主体
        /// </summary>
        public CBCPTRANSFERTRNRQ CBCPTRANSFERTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.19.6跨境资金池集中收付汇请求主体
    /// </summary>
    public class CBCPTRANSFERTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.19.6跨境资金池集中收付汇请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBCPTRANSFERTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.19.6跨境资金池集中收付汇请求内容
    /// </summary>
    public class CBCPTRANSFERTRN_RQBODY
    {
        /// <summary>
        /// 汇款方式，目前只支持T-电汇。 必输
        /// L－信用证,
        /// G－保函,
        /// C－托收,
        /// T－电汇,(默认)
        /// D－票汇,
        /// M－信汇,
        /// O－其他
        /// </summary>
        [XmlElement(Order = 1)]
        public string REMITWAY { get; set; } = "T";
        /// <summary>
        /// 汇款类型，目前只支持O-境外。 必输
        /// O-境外(默认)
        /// I-境内
        /// </summary>
        [XmlElement(Order = 2)]
        public string REMITTYPE { get; set; } = "O";
        /// <summary>
        /// 汇款人类型，目前只支持C-对公用户。 必输
        /// C－对公用户(默认）,
        /// D－对私中国居民,
        /// F－对私中国非居民
        /// </summary>
        [XmlElement(Order = 3)]
        public string REMITTERTYPE { get; set; } = "C";
        /// <summary>
        /// 汇款账号，18主账号+6位成员子账号	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string REMITTERACCTNO { get; set; }
        /// <summary>
        /// 汇款人名称及地址	非必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string REMITTERNAME { get; set; }
        /// <summary>
        /// 收款账号	必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string TOACCTNO { get; set; }
        /// <summary>
        /// 收款人名称及地址	必输
        /// </summary>
        [XmlElement(Order = 7)]
        public string TOACCTBANE { get; set; }
        /// <summary>
        /// 收款人开户行SWIFT CODE	必输
        /// </summary>
        [XmlElement(Order = 8)]
        public string TOBANKCODE { get; set; }
        /// <summary>
        /// 收款人开户行名称	必输
        /// </summary>
        [XmlElement(Order = 9)]
        public string TOBANKNAME { get; set; }
        /// <summary>
        /// 收款行之代理行SWIFT CODE	非必输
        /// </summary>
        [XmlElement(Order = 10)]
        public string AGENTBANKCODE { get; set; }
        /// <summary>
        /// 收款行之代理行名称	非必输
        /// </summary>
        [XmlElement(Order = 11)]
        public string AGENTBANKNAME { get; set; }
        /// <summary>
        /// 收款行在代理行账号	非必输
        /// </summary>
        [XmlElement(Order = 12)]
        public string TOAGENTACCTNO { get; set; }
        /// <summary>
        /// 汇款币种	必输
        /// </summary>
        [XmlElement(Order = 13)]
        public string CURRENTCY { get; set; }
        /// <summary>
        /// 汇款金额 汇款金额=相应金额1+相应金额2 必输
        /// </summary>
        [XmlElement(Order = 14)]
        public decimal REMITAMOUNT { get; set; }
        /// <summary>
        /// 汇款附言	非必输
        /// </summary>
        [XmlElement(Order = 15)]
        public string REMITMEMO { get; set; }
        /// <summary>
        /// 收款人常驻国家代码	必输
        /// </summary>
        [XmlElement(Order = 16)]
        public string COUNTRYCODE { get; set; }
        /// <summary>
        /// 交易编码1	必输
        /// </summary>
        [XmlElement(Order = 17)]
        public string TRADECODE1 { get; set; }
        /// <summary>
        /// 交易编码2 交易编码1和交易编码2不能一样 非必输
        /// </summary>
        [XmlElement(Order = 18)]
        public string TRADECODE2 { get; set; }
        /// <summary>
        /// 相应币种1	必输
        /// </summary>
        [XmlElement(Order = 19)]
        public string CURRENCY1 { get; set; }
        /// <summary>
        /// 相应币种2	非必输
        /// </summary>
        [XmlElement(Order = 20)]
        public string CURRENCY2 { get; set; }
        /// <summary>
        /// 相应金额1	必输
        /// </summary>
        [XmlElement(Order = 21)]
        public decimal AMOUNT1 { get; set; }
        /// <summary>
        /// 相应金额2 交易金额1+交易金额2=汇款金额 非必输
        /// </summary>
        [XmlIgnore]
        public decimal? AMOUNT2 { get; set; }
        /// <summary>
        /// 相应金额2 交易金额1+交易金额2=汇款金额, 对应<see cref="AMOUNT2"/>	非必输 
        /// </summary>
        [XmlElement("AMOUNT2", Order = 22)]
        public string AMOUNT2Str
        {
            get
            {
                return this.AMOUNT2?.ToString();
            }
            set
            {
                this.AMOUNT2 = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 交易附言1	必输
        /// </summary>
        [XmlElement(Order = 23)]
        public string MEMO1 { get; set; }
        /// <summary>
        /// 交易附言2	非必输
        /// </summary>
        [XmlElement(Order = 24)]
        public string MEMO2 { get; set; }
        /// <summary>
        /// 结算方式，目前只支持T-电汇 必输
        /// T－电汇(默认)
        /// D－票汇
        /// M－信汇
        /// </summary>
        [XmlElement(Order = 25)]
        public string SETTLE_WAY { get; set; } = "T";
        /// <summary>
        /// 付费类型  目前只支持O-其它   必输 
        /// A-预约付款
        /// R-货到付款
        /// P-退款
        /// O-其它(默认) 
        /// </summary>
        [XmlElement(Order = 26)]
        public string PAYTYPE { get; set; } = "O";
        /// <summary>
        /// 是否报税货物项下付款 目前只支持N-否  必输
        /// Y-是 
        /// N-否(默认)
        /// </summary>
        [XmlElement(Order = 27)]
        public string ISBONDED { get; set; } = "N";
        /// <summary>
        /// 外汇局批件号/备案表号/业务编号	非必输
        /// </summary>
        [XmlElement(Order = 28)]
        public string SAFEBIZNO { get; set; }
        /// <summary>
        /// 合同号	必输
        /// </summary>
        [XmlElement(Order = 29)]
        public string CONTRATENO { get; set; }
        /// <summary>
        /// 发票号	必输
        /// </summary>
        [XmlElement(Order = 30)]
        public string BILLNO { get; set; }
        /// <summary>
        /// 申请人姓名	必输
        /// </summary>
        [XmlElement(Order = 31)]
        public string APPLYNAME { get; set; }
        /// <summary>
        /// 申请人电话	必输
        /// </summary>
        [XmlElement(Order = 32)]
        public string APPLYTEL { get; set; }
        /// <summary>
        /// 费用承担  目前只支持SHA  必输
        /// BEN-Beneficiary Customer,
        /// OUR-Ordering Customer,
        /// SHA-Shared(默认)
        /// </summary>
        [XmlElement(Order = 33)]
        public string BEAREXPENSES { get; set; } = "SHA";
        /// <summary>
        /// 贸易类型,字段保留 M-货物贸易核查项下 N-非货物贸易核查项下 非必输
        /// </summary>
        [XmlElement(Order = 34)]
        public string TRADETYPE { get; set; }
    }
}
