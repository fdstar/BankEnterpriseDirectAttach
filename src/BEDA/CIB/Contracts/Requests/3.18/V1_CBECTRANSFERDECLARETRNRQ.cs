using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.18.11跨境电商收付汇还原申报请求主体
    /// </summary>
    public class V1_CBECTRANSFERDECLARETRNRQ : IRequest<V1_CBECTRANSFERDECLARETRNRS>
    {
        /// <summary>
        /// 3.18.11跨境电商收付汇还原申报请求主体
        /// </summary>
        public CBECTRANSFERDECLARETRNRQ CBECTRANSFERDECLARETRNRQ { get; set; }
    }
    /// <summary>
    /// 3.18.11跨境电商收付汇还原申报请求主体
    /// </summary>
    public class CBECTRANSFERDECLARETRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.18.11跨境电商收付汇还原申报请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBECTRANSFERDECLARETRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.18.11跨境电商收付汇还原申报请求内容
    /// </summary>
    public class CBECTRANSFERDECLARETRN_RQBODY
    {
        /// <summary>
        /// 总批次	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string BATCH_NUM { get; set; }
        /// <summary>
        /// 当前批次号  当前批次不能大于总批次 必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string CURR_BATCH_SEQ { get; set; }
        /// <summary>
        /// 第一批次号关联的TRNUID,当前批次号为1时可以不输，但是当当前批次号不为1时必输，且必须和第一批次对应的TRNUID一样	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string FIRST_BATCH_REFNO { get; set; }
        /// <summary>
        /// 汇款币种 参考：附录中货币种类编码 必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 当前申报汇款总金额	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal CURR_BATCH_TOTAL_AMT
        {
            get
            {
                return this.List?.Sum(c => c.REMIT_AMOUNT) ?? 0;
            }
            set { }
        }
        /// <summary>
        /// 地区机构号5位	必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string BRANCH_NO { get; set; }
        /// <summary>
        /// 国际收支申报编号	必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string BLNC_PYMT_NO { get; set; }
        /// <summary>
        /// 数据类型(字母必须大写) 必输
        /// DBA:涉外收入申报单
        /// DBB:境外汇款申请书
        /// DBD:境内收入申报单
        /// DBE:境内汇款申请书
        /// </summary>
        [XmlElement(Order = 7)]
        public string DATA_TYPE { get; set; }
        /// <summary>
        /// 是否补录字段：(字母必须大写) 正常申报(默认)：N 补录：Y 非必输
        /// </summary>
        [XmlElement(Order = 8)]
        public string BACK_TRACKING { get; set; }
        /// <summary>
        /// 3.18.11跨境电商收付汇还原申报请求集合 申报明细，不能超过100
        /// </summary>
        [XmlElement("CONTENT", Order = 9)]
        public List<CBECTRANSFERDECLARETRNRQ_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.18.11跨境电商收付汇还原申报请求明细
    /// </summary>
    public class CBECTRANSFERDECLARETRNRQ_CONTENT
    {
        /// <summary>
        /// 序号，从1开始递增	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public int SEQ { get; set; }
        /// <summary>
        /// 业务创建日期	必输
        /// </summary>
        [XmlIgnore]
        public DateTime BIZ_DATE { get; set; }
        /// <summary>
        /// 业务创建日期, 对应<see cref="BIZ_DATE"/>	必输
        /// </summary>
        [XmlElement("BIZ_DATE", Order = 1)]
        public string BIZ_DATEStr
        {
            get
            {
                return this.BIZ_DATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BIZ_DATE = tmp;
                }
            }
        }
        /// <summary>
        /// 汇款人类型(字母必须大写) 非必输
        /// C－对公用户(默认）
        /// D－对私中国居民
        /// F－对私中国非居民 需与申报号码中第19位字母所表明的含义一致
        /// 数据类型为以下类型时必填，其他不填
        /// DBB:境外汇款申请书
        /// DBE:境内汇款申请书
        /// </summary>
        [XmlElement(Order = 2)]
        public string REMITTER_TYPE { get; set; }
        /// <summary>
        /// DBA时：收款人类型(字母必须大写)    非必输
        /// C－对公用户（默认）
        /// D－对私中国居民
        /// F－对私中国非居民
        /// 需与申报号码中第19位字母所表明的含义一致
        /// DBD时:收款人类型
        /// C－对公用户（默认）
        /// D-对私
        /// 数据类型为以下类型时必填，其他不填
        /// DBA-涉外收入申报单
        /// DBD:境内收入申报单
        /// </summary>
        [XmlElement(Order = 3)]
        public string PAYEE_TYPE { get; set; }
        /// <summary>
        /// 身份证号码 收款人类型不为C时必输或汇款人类型不为C时必输  非必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string ID_NO { get; set; }
        /// <summary>
        /// 组织机构代码 收款人类型为C时必输或汇款人类型为C时必输 非必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string FIRM_CODE { get; set; }
        /// <summary>
        /// 收款人账号(字母必须大写) 非必输
        /// 数据类型为以下类型时必填，其他不填
        /// DBE:境内汇款申请书
        /// </summary>
        [XmlElement(Order = 6)]
        public string PAYEE_ACCT_NO { get; set; }
        /// <summary>
        /// 收款人名称 必输
        /// 当数据类型为DBB境外汇款申请书 必须以大写英文字符 “（JW）”或“（JN）”开头
        /// </summary>
        [XmlElement(Order = 7)]
        public string PAYEE_NAME { get; set; }
        /// <summary>
        /// 汇款人名称 必输
        /// 当数据类型为DBA涉外收入申报单 必须以大写英文字符 “（JW）”或“（JN）”开头
        /// </summary>
        [XmlElement(Order = 8)]
        public string REMITTER_NAME { get; set; }
        /// <summary>
        /// 汇款金额	必输
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal REMIT_AMOUNT { get; set; }
        /// <summary>
        /// 结售汇汇率   非必输
        /// 如果为收入申报，该字段为结汇汇率
        /// 如果为1汇款申报，该字段为购汇汇率
        /// 当结售汇金额大于0时必填，否则不应该填写
        /// </summary>
        [XmlIgnore]
        public decimal? EXCHNG_RATE { get; set; }
        /// <summary>
        /// 结售汇汇率 对应<see cref="EXCHNG_RATE"/>  非必输
        /// 如果为收入申报，该字段为结汇汇率
        /// 如果为1汇款申报，该字段为购汇汇率
        /// 当结售汇金额大于0时必填，否则不应该填写
        /// </summary>
        [XmlElement("EXCHNG_RATE", Order = 10)]
        public string EXCHNG_RATEStr
        {
            get
            {
                return this.EXCHNG_RATE?.ToString();
            }
            set
            {
                this.EXCHNG_RATE = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 结售汇金额    非必输
        /// 如果为收入申报，该字段为结汇金额
        /// 如果为汇款申报，该字段为购汇金额
        /// 选输项，但不能小于0 若账号不为空则对应金额必须>0；若金额>0，则对应账号不能为空
        /// </summary>
        [XmlIgnore]
        public decimal? EXCHNG_AMT { get; set; }
        /// <summary>
        /// 结售汇金额 对应<see cref="EXCHNG_AMT"/>  非必输
        /// 如果为收入申报，该字段为结汇金额
        /// 如果为汇款申报，该字段为购汇金额
        /// 选输项，但不能小于0 若账号不为空则对应金额必须>0；若金额>0，则对应账号不能为空
        /// </summary>
        [XmlElement("EXCHNG_AMT", Order = 11)]
        public string EXCHNG_AMTStr
        {
            get
            {
                return this.EXCHNG_AMT?.ToString();
            }
            set
            {
                this.EXCHNG_AMT = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 人民币账号   非必输
        /// 如果为收入申报，该字段为结汇账号
        /// 如果为汇款申报，该字段为购汇账号
        /// 结售汇金额、结售汇汇率、人民币账号三个或同时空或同时有值
        /// </summary>
        [XmlElement(Order = 12)]
        public string CASH_ACCT_NO { get; set; }
        /// <summary>
        /// 现汇金额    非必输
        /// 选输项，但不能小于0 若账号不为空则对应金额必须>0；若金额>0，则对应账号不能为空
        /// </summary>
        [XmlIgnore]
        public decimal? CASH_AMT { get; set; }
        /// <summary>
        /// 现汇金额 对应<see cref="CASH_AMT"/>  非必输
        /// 选输项，但不能小于0 若账号不为空则对应金额必须>0；若金额>0，则对应账号不能为空
        /// </summary>
        [XmlElement("CASH_AMT", Order = 13)]
        public string CASH_AMTStr
        {
            get
            {
                return this.CASH_AMT?.ToString();
            }
            set
            {
                this.CASH_AMT = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 外汇账号 非必输
        /// 如果有现汇金额，则该字段不能为空
        /// 现汇金额、现汇帐号或同时空，或同时有值
        /// </summary>
        [XmlElement(Order = 14)]
        public string EXCHNG_ACCT_NO { get; set; }
        /// <summary>
        /// 其他金额    非必输
        /// 选输项，但不能小于0
        /// 若账号不为空则对应金额必须>0；若金额>0，则对应账号不能为空
        /// 结售汇金额, 现汇金额, 其它金额至少输入一项
        /// 结售汇金额、现汇金额、其它金额之和必须等于收入款或汇出款金额
        /// </summary>
        [XmlIgnore]
        public decimal? OTHER_AMT { get; set; }
        /// <summary>
        /// 其他金额 对应<see cref="OTHER_AMT"/>  非必输
        /// 选输项，但不能小于0
        /// 若账号不为空则对应金额必须>0；若金额>0，则对应账号不能为空
        /// 结售汇金额, 现汇金额, 其它金额至少输入一项
        /// 结售汇金额、现汇金额、其它金额之和必须等于收入款或汇出款金额
        /// </summary>
        [XmlElement("OTHER_AMT", Order = 15)]
        public string OTHER_AMTStr
        {
            get
            {
                return this.OTHER_AMT?.ToString();
            }
            set
            {
                this.OTHER_AMT = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 其他账号	非必输
        /// </summary>
        [XmlElement(Order = 16)]
        public string OTHER_ACCT_NO { get; set; }
        /// <summary>
        /// 结算方式(字母必须大写) 必输
        /// －信用证
        /// G－保函
        /// C－托收
        /// T－电汇
        /// D－票汇
        /// M－信汇
        /// O－其他
        /// </summary>
        [XmlElement(Order = 17)]
        public string SETTLE_WAY { get; set; }
        /// <summary>
        /// 国内费用币种 非必输 参考：附录中货币种类编码
        /// 数据类型为以下数据类型时选填，其他不填
        /// DBD:境内收入申报单
        /// DBA-涉外收入申报单
        /// </summary>
        [XmlElement(Order = 18)]
        public string INLAND_CHARGE_CURNCY { get; set; }
        /// <summary>
        /// 国内费用金额    非必输
        /// 选输项，若输入，则输入的金额必须大于0，且没有小数位
        /// 国内扣费币种、金额必须同时输入 若币种不为空则对应金额必须>0；若金额>0，则对应币种不能为空
        /// 数据类型为以下数据类型时选填，其他不填
        /// DBD:境内收入申报单
        /// DBA-涉外收入申报单
        /// </summary>
        [XmlIgnore]
        public decimal? INLAND_CHARGE_AMT { get; set; }
        /// <summary>
        /// 国内费用金额 对应<see cref="INLAND_CHARGE_AMT"/>  非必输
        /// 选输项，若输入，则输入的金额必须大于0，且没有小数位
        /// 国内扣费币种、金额必须同时输入 若币种不为空则对应金额必须>0；若金额>0，则对应币种不能为空
        /// 数据类型为以下数据类型时选填，其他不填
        /// DBD:境内收入申报单
        /// DBA-涉外收入申报单
        /// </summary>
        [XmlElement("INLAND_CHARGE_AMT", Order = 19)]
        public string INLAND_CHARGE_AMTStr
        {
            get
            {
                return this.INLAND_CHARGE_AMT?.ToString();
            }
            set
            {
                this.INLAND_CHARGE_AMT = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 国外费用币种 非必输        参考：附录中货币种类编码
        /// 数据类型为以下数据类型时选填，其他不填
        /// DBA-涉外收入申报单
        /// </summary>
        [XmlElement(Order = 20)]
        public string FOREIGN_CHARGE_CURNCY { get; set; }
        /// <summary>
        /// 国外费用金额   非必输
        /// 数据类型为以下数据类型时选填，其他不填
        /// DBA-涉外收入申报单
        /// </summary>
        [XmlIgnore]
        public decimal? FOREIGN_CHARGE_AMT { get; set; }
        /// <summary>
        /// 国外费用金额 对应<see cref="FOREIGN_CHARGE_AMT"/>  非必输
        /// 数据类型为以下数据类型时选填，其他不填
        /// DBA-涉外收入申报单
        /// </summary>
        [XmlElement("FOREIGN_CHARGE_AMT", Order = 21)]
        public string FOREIGN_CHARGE_AMTStr
        {
            get
            {
                return this.FOREIGN_CHARGE_AMT?.ToString();
            }
            set
            {
                this.FOREIGN_CHARGE_AMT = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 收/付款人常驻国家（地区）代码 非必输 参考附录 结售汇国家地区代码 中的国标（国家代码大写）
        /// 数据类型为以下数据类型时时必填，其他不填
        /// DBA-涉外收入申报单
        /// DBB:境外汇款申请书
        /// DBE-境内汇款申请书
        /// </summary>
        [XmlElement(Order = 22)]
        public string COUNTRY_CODE { get; set; }
        /// <summary>
        /// 收款类型(字母必须大写) 必输
        /// DBD:境内收入申报单
        /// A-预收货款
        /// O-其它
        /// DBA:涉外收入申报单
        /// A-预收货款
        /// R-退款
        /// O-其它
        /// 付款类型：
        /// A-	预付货款
        /// P-货到付款
        /// R-退款
        /// O-其它
        /// </summary>
        [XmlElement(Order = 23)]
        public string RCPT_PYMT_TYPE { get; set; }
        /// <summary>
        /// 交易编码1 附录：国际收支交易编码表中存在 必输
        /// </summary>
        [XmlElement(Order = 24)]
        public string TRADE_CODE_1 { get; set; }
        /// <summary>
        /// 相应金额1 	必输
        /// </summary>
        [XmlElement(Order = 25)]
        public decimal AMOUNT_1 { get; set; }
        /// <summary>
        /// 交易附言1 非必输
        /// 数据类型为以下类型时，必填其他不填
        /// DBA:涉外收入申报单
        /// DBB:境外汇款申请书
        /// DBD:境内收入申报单
        /// /// </summary>
        [XmlElement(Order = 26)]
        public string MEMO_1 { get; set; }
        /// <summary>
        /// 交易编码2 非必输 
        /// 必须在国际收支交易编码表中存在 不能与交易编码1相同
        /// 没有输入交易编码时，相应金额及交易附言不应该填写 有交易金额2或交易附言2时必填
        /// </summary>
        [XmlElement(Order = 27)]
        public string TRADE_CODE_2 { get; set; }
        /// <summary>
        /// 相应金额2  非必输
        /// 有交易编码2时必填 两个交易编码对应的金额之和必须等于收/付款金额
        /// </summary>
        [XmlElement(Order = 28)]
        public decimal AMOUNT_2 { get; set; }
        /// <summary>
        /// 交易附言2	非必输
        /// /// </summary>
        [XmlElement(Order = 29)]
        public string MEMO_2 { get; set; }
        /// <summary>
        /// 最迟装运日期 YYYY-MM-DD 非必输
        /// 数据类型为以下类型时选填，其他不填
        /// DBE-境内汇款申请书
        /// </summary>
        [XmlIgnore]
        public DateTime? LAST_SHIPPING_DATE { get; set; }
        /// <summary>
        /// 最迟装运日期 YYYY-MM-DD, 对应<see cref="LAST_SHIPPING_DATE"/>	非必输
        /// 数据类型为以下类型时选填，其他不填
        /// DBE-境内汇款申请书
        /// </summary>
        [XmlElement("LAST_SHIPPING_DATE", Order = 30)]
        public string LAST_SHIPPING_DATEStr
        {
            get
            {
                return this.LAST_SHIPPING_DATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.LAST_SHIPPING_DATE = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 合同号 非必输
        /// 数据类型为以下类型时必填，其他不填
        /// DBE-境内汇款申请书
        /// DBB:境外汇款申请书
        /// </summary>
        [XmlElement(Order = 31)]
        public string CONTRACT_NO { get; set; }
        /// <summary>
        /// 发票号 非必输
        /// 数据类型为以下类型时必填，其他不填
        /// DBE-境内汇款申请书
        /// DBB:境外汇款申请书
        /// </summary>
        [XmlElement(Order = 32)]
        public string BILL_NO { get; set; }
        /// <summary>
        /// 是否保税货物项下收/付汇(默认为否) (字母必须大写) 必输
        /// Y－是
        /// N－否
        /// </summary>
        [XmlElement(Order = 33)]
        public string IS_BONDED { get; set; }
        /// <summary>
        /// 外汇局批件号/备案表号/业务编号    非必输
        /// 数据类型为以下类型时选填，其他不填
        /// DBA:涉外收入申报单
        /// DBD-境内收入申报单
        /// DBB:境外汇款申请书
        /// DBE-境内汇款申请书
        /// 如果输入交易编码为资本项下交易编码则必输
        /// </summary>
        [XmlElement(Order = 34)]
        public string SAFE_BIZ_NO { get; set; }
        /// <summary>
        /// 外债编号	非必输
        /// 选输项，资本项目项下交易（涉外收支交易编码以“5”、“6”、“7”、“8”和部分“9”开头，具体见10.2.3和10.2.4）的“外汇局批件号/备案表号/业务编号”为必输项。对于资本项目项下交易，如果确实没有对应的“外汇局批件号/备案表号/业务编号”，应填写“N/A”（大写英文字符）
        /// </summary>
        [XmlElement(Order = 35)]
        public string DEBT_NO { get; set; }
        /// <summary>
        /// 收入类型付汇性质(字母必须大写)  非必输  
        /// 当数据类型为：DBA:涉外收入申报单
        /// F-福费廷
        /// T-出口保理
        /// N-出口押汇
        /// D-出口贴现
        /// O-其它
        /// 当数据类型为：DBD:境内收入申报单 DBE:境内汇款申请书
        /// M-深加工结转
        /// X-保税区
        /// E-出口加工区
        /// D-钻石交易所
        /// A-其他特殊经济区
        /// R-汇路引起出口项下跨境收入
        /// C-出口信用保险理赔
        /// I-出口货物保险理赔
        /// N-买方信贷
        /// L-转让信用证
        /// B-背对背信用证
        /// O-其他
        /// 数据类型为
        /// DBA:涉外收入申报单，非必输
        /// DBD:境内收入申报单，必输
        /// DBE:境内汇款申请书，必输
        /// </summary>
        [XmlElement(Order = 36)]
        public string EXCHNG_TYPE { get; set; }
        /// <summary>
        /// 申请(填报)人姓名	必输
        /// </summary>
        [XmlElement(Order = 37)]
        public string APPLY_NAME { get; set; }
        /// <summary>
        /// 申请(填报)人电话	必输
        /// </summary>
        [XmlElement(Order = 38)]
        public string APPLY_TEL { get; set; }
        /// <summary>
        /// 申报日期，YYYY-MM-DD 必输
        /// 按申报主体真实申报日期填写 申报日期>=申报号码中的日期
        /// </summary>
        [XmlIgnore]
        public DateTime APPLY_DATE { get; set; }
        /// <summary>
        /// 申报日期，YYYY-MM-DD  对应<see cref="APPLY_DATE"/>	必输
        /// 按申报主体真实申报日期填写 申报日期>=申报号码中的日期
        /// </summary>
        [XmlElement("APPLY_DATE", Order = 39)]
        public string APPLY_DATEStr
        {
            get
            {
                return this.APPLY_DATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.APPLY_DATE = tmp;
                }
            }
        }
        /// <summary>
        /// 贸易类型(字母必须大写) M：货物贸易核查项下 N：非货物贸易核查项下 必输
        /// </summary>
        [XmlElement(Order = 40)]
        public string TRADE_TYPE { get; set; }
        /// <summary>
        /// 管理申报日期(管理信息) 非必输
        /// 数据类型为 DBB:境外汇款申请书 时必输，且必须和申报日期保持一致
        /// </summary>
        [XmlIgnore]
        public DateTime? MANAGE_APPLY_DATE { get; set; }
        /// <summary>
        /// 管理申报日期(管理信息)  对应<see cref="MANAGE_APPLY_DATE"/>	非必输
        /// 数据类型为 DBB:境外汇款申请书 时必输，且必须和申报日期保持一致
        /// </summary>
        [XmlElement("MANAGE_APPLY_DATE", Order = 41)]
        public string MANAGE_APPLY_DATEStr
        {
            get
            {
                return this.MANAGE_APPLY_DATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.MANAGE_APPLY_DATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.MANAGE_APPLY_DATE = tmp;
                }
            }
        }
    }
}
