using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 交易流水分页查询响应主体
    /// </summary>
    public class V1_BALNTRADEINQUIRYTRNRS : IResponse
    {
        /// <summary>
        /// 交易流水分页查询响应（返回包含虚拟子账户交易信息）
        /// </summary>
        public BALNTRADEINQUIRYTRNRS BALNTRADEINQUIRYTRNRS { get; set; }
    }
    /// <summary>
    /// 交易流水分页查询响应（返回包含虚拟子账户交易信息）
    /// </summary>
    public class BALNTRADEINQUIRYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 如果客户端发送COOKIE，同步的历史记录不包括原有的CLTCOOKIE，非必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string CLTCOOKIE { get; set; }
        /// <summary>
        /// 交易流水分页查询（返回包含虚拟子账户交易信息）
        /// </summary>
        [XmlElement(Order = 3)]
        public BALNTRADEINRSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 交易流水分页查询结果（返回包含虚拟子账户交易信息）
    /// </summary>
    public class BALNTRADEINRSBODY
    {
        /// <summary>
        /// 是否还有下一页：Y－有,N－否
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 默认货币代码，必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string CURDEF { get; set; }
        /// <summary>
        /// 付款人账户，必回
        /// </summary>
        [XmlElement(Order = 1)]
        public ACCTFROM ACCTFROM { get; set; }
        /// <summary>
        /// 查询结果集合
        /// </summary>
        [XmlElement("CONTENT", Order = 2)]
        public List<BALNTRADEINCONTENT> List { get; set; }
        /// <summary>
        /// 总账余额，和下面可用余额基本一致，除非存在贷款户等业务上冻结或被控制的金额，总账才会比可用大。
        /// </summary>
        [XmlElement(Order = 3)]
        public BALANCE MAIN_LEDGERBAL { get; set; }
        /// <summary>
        /// 可用余额
        /// </summary>
        [XmlElement(Order = 4)]
        public BALANCE MAIN_AVAILBAL { get; set; }
    }
    /// <summary>
    /// 账号余额和交易流水分页查询（返回增加虚拟子账户交易信息）明细
    /// </summary>
    public class BALNTRADEINCONTENT
    {
        /// <summary>
        /// 起始日期，格式yyyy-MM-dd，必回
        /// </summary>
        [XmlIgnore]
        public DateTime DTSTART { get; set; }
        /// <summary>
        /// 起始日期，格式yyyy-MM-dd ,对应<see cref="DTSTART"/>
        /// </summary>
        [XmlElement("DTSTART", Order = 0)]
        public string DTSTARTStr
        {
            get
            {
                return this.DTSTART.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTSTART = tmp;
                }
            }
        }
        /// <summary>
        /// 终止日期，格式yyyy-MM-dd，必回
        /// </summary>
        [XmlIgnore]
        public DateTime DTEND { get; set; }
        /// <summary>
        /// 终止日期，格式yyyy-MM-dd ,对应<see cref="DTEND"/>
        /// </summary>
        [XmlElement("DTEND", Order = 1)]
        public string DTENDStr
        {
            get
            {
                return this.DTEND.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTEND = tmp;
                }
            }
        }
        /// <summary>
        /// 柜员流水号
        /// </summary>
        [XmlElement(Order = 2)]
        public string SRVRTID { get; set; }
        /// <summary>
        /// 交易类型（借(DEBIT/CREDIT)贷类型），必回
        /// </summary>
        [XmlElement(Order = 3)]
        public TRNTYPEEnum TRNTYPE { get; set; }
        /// <summary>
        /// 核心摘要代码，必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string TRNCODE { get; set; }
        /// <summary>
        /// 记账日期，必回，例2017-07-04T11:06:21
        /// </summary>
        [XmlIgnore]
        public DateTime DTACCT { get; set; }
        /// <summary>
        /// 记账日期，必回，例2017-07-04T11:06:21 ,对应<see cref="DTACCT"/>
        /// </summary>
        [XmlElement("DTACCT", Order = 5)]
        public string DTACCTStr
        {
            get
            {
                return this.DTACCT.ToString("yyyy-MM-ddTHH:mm:ss");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-ddTHH:mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTACCT = tmp;
                }
            }
        }
        /// <summary>
        /// 交易金额，为负值表示冲正  必回
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 余额（交易结束后的账户余额（历史余额），不能通过此获取当日余额，这和我行会计日期时间有关系。例如11点批处理，则11点后的操作都会记作第二天的转账）
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal BALAMT { get; set; }
        /// <summary>
        /// 币种 必回
        /// </summary>
        [XmlElement(Order = 8)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 核心备注（非必回）
        /// </summary>
        [XmlElement(Order = 9)]
        public string MEMO { get; set; }
        /// <summary>
        /// 收/付款虚拟子账户序号（非必回）
        /// </summary>
        [XmlElement(Order = 10)]
        public string SUBACCT { get; set; }
        /// <summary>
        /// 收/付款虚拟子账户名（非必回）
        /// </summary>
        [XmlElement(Order = 11)]
        public string SUBACCT_NAME { get; set; }
        /// <summary>
        /// 对方账号（非必回）
        /// </summary>
        [XmlElement(Order = 12)]
        public string CORRELATE_ACCTID { get; set; }
        /// <summary>
        /// 对方账户名称（非必回）
        /// </summary>
        [XmlElement(Order = 13)]
        public string CORRELATE_NAME { get; set; }
        /// <summary>
        /// 本行凭证代号 （非必回）；如果有回复，规则是2位凭证种类+7位凭证代号
        /// </summary>
        [XmlElement(Order = 14)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 他行凭证类型  2位（非必回）
        /// </summary>
        [XmlElement(Order = 15)]
        public string BILLTYPE { get; set; }
        /// <summary>
        /// 他行凭证号码  最大8位（非必回）
        /// </summary>
        [XmlElement(Order = 16)]
        public string BILLNUMBER { get; set; }
        /// <summary>
        /// 附加行名  最大50位（非必回）
        /// </summary>
        [XmlElement(Order = 17)]
        public string CORRELATE_BANKNAME { get; set; }
        /// <summary>
        /// 附加行号  12位（非必回）
        /// </summary>
        [XmlElement(Order = 18)]
        public string CORRELATE_BANKCODE { get; set; }
        /// <summary>
        /// 业务类型  最大20位（非必回）（非必回，摘要代号---业务部门提供）
        /// </summary>
        [XmlElement(Order = 19)]
        public string BUSINESSTYPE { get; set; }
        /// <summary>
        /// 流水唯一标识号，由流水交易日期、核心传票组序号、核心传票组内序号组成，最长30位，例2012042301001825697000003
        /// </summary>
        [XmlElement(Order = 20)]
        public string ATTACHINFO { get; set; }
        /// <summary>
        /// 核心交易流水编号（必回）
        /// </summary>
        [XmlElement(Order = 21)]
        public string HXJYLSBH { get; set; }
        /// <summary>
        /// 摘要简称（非必回）
        /// </summary>
        [XmlElement(Order = 22)]
        public string SUMMNAME { get; set; }
        /// <summary>
        /// 摘要描述（非必回）
        /// </summary>
        [XmlElement(Order = 23)]
        public string SUMMDESC { get; set; }
        /// <summary>
        /// 用途（非必回）
        /// </summary>
        [XmlElement(Order = 24)]
        public string PURPOSE { get; set; }
        /// <summary>
        /// 交易地区机构代码（非必回）
        /// </summary>
        [XmlElement(Order = 25)]
        public string BRANCHNO { get; set; }
        /// <summary>
        /// 渠道种类（非必回），参照附录渠道种类
        /// </summary>
        [XmlElement(Order = 26)]
        public string CHANNELCODE { get; set; }
        /// <summary>
        /// 现转标志（非必回）0 现金 1 转账
        /// </summary>
        [XmlElement(Order = 27)]
        public byte? CASHFLAG { get; set; }
        /// <summary>
        /// 冲补标志（非必回）0 正常 1 当日冲正 2-补帐 3-隔日补账
        /// </summary>
        [XmlElement(Order = 28)]
        public byte? CBBZ { get; set; }
        /// <summary>
        /// 被冲账标志（非必回）0 正常 1 当日被冲正 2-隔日被冲正 3-当日被撤销 4-隔日被撤销
        /// </summary>
        [XmlElement(Order = 29)]
        public byte? BCZBZ { get; set; }
        /// <summary>
        /// 邮路选择（非必回）0 同城票交 3-大额实时 4-小额批量 8-跨行
        /// </summary>
        [XmlElement(Order = 30)]
        public byte? ROUTECHOICE { get; set; }
        /// <summary>
        /// 业务参考号,预留 目前没有值（非必回）
        /// </summary>
        [XmlElement(Order = 31)]
        public string BIZREF { get; set; }
        /// <summary>
        /// 预留无值字段1（非必回）
        /// </summary>
        [XmlElement(Order = 32)]
        public string TEXT1 { get; set; }
        /// <summary>
        /// 预留无值字段2（非必回）
        /// </summary>
        [XmlElement(Order = 33)]
        public string TEXT2 { get; set; }
        /// <summary>
        /// 预留无值字段3（非必回）
        /// </summary>
        [XmlElement(Order = 34)]
        public string TEXT3 { get; set; }
    }
}
