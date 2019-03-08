using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.18.8跨境电商付汇响应主体
    /// </summary>
    public class V1_CBECTRANSFERTRNRS : IResponse
    {
        /// <summary>
        /// 3.18.8跨境电商付汇响应主体
        /// </summary>
        public CBECTRANSFERTRNRS CBECTRANSFERTRNRS { get; set; }
    }
    /// <summary>
    /// 3.18.8跨境电商付汇响应主体
    /// </summary>
    public class CBECTRANSFERTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.18.8跨境电商付汇响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBECTRANSFERTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.18.8跨境电商付汇响应内容
    /// </summary>
    public class CBECTRANSFERTRN_RSBODY
    {
        /// <summary>
        /// 关联系统批次号	必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string RLTD_SRVC_NO { get; set; }
        /// <summary>
        /// 发电级别 空:默认为普通 1-紧急 必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string TELE_LVL { get; set; }
        /// <summary>
        /// 备注	非必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string REMARK { get; set; }
        /// <summary>
        /// 业务类型(字母必须大写) 集中付汇:JZF 轧差付汇:GCF 必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string BUSN_TYPE { get; set; }
        /// <summary>
        /// 汇款类型 0-行内 1-境内 2-境外 非必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string PAY_FLAG { get; set; }
        /// <summary>
        /// 地区机构号	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string BRANCH_NO { get; set; }
        /// <summary>
        /// 客户经理（审核员）	非必回
        /// </summary>
        [XmlElement(Order = 6)]
        public string CUST_MGR { get; set; }
        /// <summary>
        /// 汇款币种	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 汇款金额(如果汇款币种是日元，则必须为整数)	必回
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal REMIT_AMOUNT { get; set; }
        /// <summary>
        /// 汇款人帐号（扣款账号）必须是兴业上网登记自有账号 必回
        /// </summary>
        [XmlElement(Order = 9)]
        public string REMITTER_ACCT_NO { get; set; }
        /// <summary>
        /// 扣账币种（扣账币种必须和汇款人账号币别保持一致）	必回
        /// </summary>
        [XmlElement(Order = 10)]
        public string REMIT_CURRENCY { get; set; }
        /// <summary>
        /// 汇款人客户号（企业客户必输: 个人客户无需。）	非必回
        /// </summary>
        [XmlElement(Order = 11)]
        public string REMITTER_NCID { get; set; }
        /// <summary>
        /// 汇款人名称及地址（仅限英文输入）数字 /-？：（）.,'+ a-z A-Z 以及空格(长度140位)	必回
        /// </summary>
        [XmlElement(Order = 12)]
        public string REMITTER_NAME { get; set; }
        /// <summary>
        /// 收款人帐号	必回
        /// </summary>
        [XmlElement(Order = 13)]
        public string PAYEE_ACCT_NO { get; set; }
        /// <summary>
        /// 收款人名称及地址（仅限英文输入）(长度140位) 数字 /-？：（）.,'+ a-z A-Z 以及空格	必回
        /// </summary>
        [XmlElement(Order = 14)]
        public string PAYEE_NAME { get; set; }
        /// <summary>
        /// 收款人常驻国家（仅限英文输入） 数字 /-？：（）.,'+ a-z A-Z 以及空格 参考附录 结售汇国家地区代码 中的国标 必回
        /// </summary>
        [XmlElement(Order = 15)]
        public string COUNTRY_CODE { get; set; }
        /// <summary>
        /// 收款人开户银行账号或清算代码	必回
        /// </summary>
        [XmlElement(Order = 16)]
        public string PAYEE_BANK_ACCT_NO { get; set; }
        /// <summary>
        /// 收款人开户银行SWIFT CODE（仅限英文输入）数字 /-？：（）.,'+ a-z A-Z 以及空格	必回
        /// </summary>
        [XmlElement(Order = 17)]
        public string PAYEE_BANK_CODE { get; set; }
        /// <summary>
        /// 收款人开户银行名称及地址（仅限英文输入）(长度140位)数字 /-？：（）.,'+ a-z A-Z 以及空格	必回
        /// </summary>
        [XmlElement(Order = 18)]
        public string PAYEE_BANK_NAME { get; set; }
        /// <summary>
        /// 收款行代理行代码WIFT CODE	非必回
        /// </summary>
        [XmlElement(Order = 19)]
        public string AGENT_BANK_CODE { get; set; }
        /// <summary>
        /// 收款行代理行名称（仅限英文输入）数字 /-？：（）.,'+ a-z A-Z 以及空格(长度140位)	非必回
        /// </summary>
        [XmlElement(Order = 20)]
        public string AGENT_BANK_NAME { get; set; }
        /// <summary>
        /// 发报行致收报行信息（仅限英文输入）数字 /-？：（）.,'+ a-z A-Z 以及空格(长度140位)	非必回
        /// </summary>
        [XmlElement(Order = 21)]
        public string SEND_MSG { get; set; }
        /// <summary>
        /// 费用类型(字母必须大写) 必回
        /// BEN-Beneficiary Customer
        /// OUR-Ordering Customer
        /// SHA-Shared
        /// </summary>
        [XmlElement(Order = 22)]
        public string BEAR_EXPENSES { get; set; }
        /// <summary>
        /// 费用币别（扣费账号不为空时必输，且必须和扣费账号的币种保持一致）	非必回
        /// </summary>
        [XmlElement(Order = 23)]
        public string BEAR_CURRENCY { get; set; }
        /// <summary>
        /// 扣费账号（当费用承担方不为BEN时,扣费账号必输）必须是兴业上网登记自有账号	非必回
        /// </summary>
        [XmlElement(Order = 24)]
        public string CHANGE_FEE_ACCTNO { get; set; }
        /// <summary>
        /// 汇款附言（仅限英文输入）数字 /-？：（）.,'+ a-z A-Z 以及空格(长度210位)	非必回
        /// </summary>
        [XmlElement(Order = 25)]
        public string REMIT_MEMO { get; set; }
        /// <summary>
        /// 汇款人类型(默认居民机构) (字母必须大写) 必回
        /// CNI：境内非居民个人
        /// CNO：境内非居民机构
        /// DEI：居民个人
        /// DEO：居民机构
        /// </summary>
        [XmlElement(Order = 26)]
        public string REMITTER_TYPE { get; set; }
        /// <summary>
        /// 收款人类型（默认境外机构 出现）(字母必须大写) 必回
        /// CNI：境内非居民个人 
        /// CNO：境内非居民机构
        /// DEI：居民个人
        /// DEO：居民机构
        /// FIN：境外个人
        /// FOR：境外机构
        /// </summary>
        [XmlElement(Order = 27)]
        public string PAYEE_TYPE { get; set; }
        /// <summary>
        /// 贸易类型默认 非货物贸易核查项下 出现）(字母必须大写) 必回
        /// M：货物贸易核查项下
        /// N：非货物贸易核查项下
        /// </summary>
        [XmlElement(Order = 28)]
        public string TRADE_TYPE { get; set; }
        /// <summary>
        /// 申报类型默认境外汇款(字母必须大写) 必回
        /// DBB：境外汇款申请书
        /// DBE：境内汇款申请书
        /// </summary>
        [XmlElement(Order = 29)]
        public string DECLARE_TYPE { get; set; }
        /// <summary>
        /// 基础信息确认标识(字母必须大写) 空：否 X：是 非必回
        /// </summary>
        [XmlElement(Order = 30)]
        public string BASE_INFO_FLAG { get; set; }
        /// <summary>
        /// 结算方式，默认电汇(字母必须大写) 必回
        /// L－信用证
        /// G－保函
        /// C－托收
        /// T－电汇
        /// D－票汇
        /// M－信汇
        /// O－其他
        /// </summary>
        [XmlElement(Order = 31)]
        public string SETTLE_WAY { get; set; }
        /// <summary>
        /// 申报信息确认标识(字母必须大写) 空：否 X：是 非必回
        /// </summary>
        [XmlElement(Order = 32)]
        public string DECLARE_INFO_FLAG { get; set; }
        /// <summary>
        /// 付汇类型(字母必须大写)    必回
        /// A-预付货款
        /// P-货到付款
        /// R-退款
        /// O-其他
        /// </summary>
        [XmlElement(Order = 33)]
        public string PAY_TYPE { get; set; }
        /// <summary>
        /// 申请人电话	必回
        /// </summary>
        [XmlElement(Order = 34)]
        public string APPLY_TEL { get; set; }
        /// <summary>
        /// 申请人姓名,经办人员姓名	必回
        /// </summary>
        [XmlElement(Order = 35)]
        public string APPLY_NAME { get; set; }
        /// <summary>
        /// 交易编码1	必回
        /// </summary>
        [XmlElement(Order = 36)]
        public string TRADE_CODE { get; set; }
        /// <summary>
        /// 交易附言1	必回
        /// </summary>
        [XmlElement(Order = 37)]
        public string TRADE_MEMO { get; set; }
        /// <summary>
        /// 是否保税货物项下付款(默认为否 出现) (字母必须大写) 必回
        /// Y：是
        /// N：否
        /// </summary>
        [XmlElement(Order = 38)]
        public string IS_BONDED { get; set; }
        /// <summary>
        /// 外汇局批件号/备案表号/业务编号	非必回
        /// </summary>
        [XmlElement(Order = 39)]
        public string SAFE_BIZ_NO { get; set; }
        /// <summary>
        /// 付汇性质(行内或者境内时必输) (字母必须大写) 非必回
        ///X：保税区
        ///E：出口加工区
        ///D：钻石交易所
        ///A：其他特殊经济区域
        ///M：深加工结转
        ///O：其他
        /// </summary>
        [XmlElement(Order = 40)]
        public string PAY_PROPERTY { get; set; }
        /// <summary>
        /// 合同号 如果贸易类型是 货物贸易项下，则为必输项，否则可不输。	非必回
        /// </summary>
        [XmlElement(Order = 41)]
        public string CONTRACT_NO { get; set; }
        /// <summary>
        /// 发票号 如果贸易类型是 货物贸易项下，则为必输项，否则可不输。	非必回
        /// </summary>
        [XmlElement(Order = 42)]
        public string BILL_NO { get; set; }
        /// <summary>
        /// 指令处理状态	必回
        /// </summary>
        [XmlElement(Order = 43)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
