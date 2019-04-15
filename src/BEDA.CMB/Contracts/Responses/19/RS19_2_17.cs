using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 19.2.17.交易票据业务处理信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_2_17 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKCUSLST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKCUSLST";
        /// <summary>
        /// 19.2.17.交易票据业务处理信息响应集合
        /// </summary>
        [XmlElement("NTCUSLSTZ")]
        public List<NTCUSLSTZ> List { get; set; }
        /// <summary>
        /// 19.2.17.交易票据业务处理信息响应内容
        /// 用于输出电子票签发或实票签发时返回该批次交易的保证金比例及手续费比例等信息
        /// </summary>
        public NTCUSATHZ0 NTCUSATHZ0 { get; set; }
        /// <summary>
        /// 19.2.17.交易票据业务处理信息响应内容
        /// 票据质押交易信息
        /// </summary>
        public NTCUSATHZ1 NTCUSATHZ1 { get; set; }
        /// <summary>
        /// 19.2.17.交易票据业务处理信息响应内容
        /// 票据质押开票交易信息
        /// </summary>
        public NTCUSATHZ2 NTCUSATHZ2 { get; set; }
        /// <summary>
        /// 19.2.17.交易票据业务处理信息响应内容
        /// 票据贴现交易信息
        /// </summary>
        public NTCUSATHZ3 NTCUSATHZ3 { get; set; }
        /// <summary>
        /// 19.2.17.交易票据业务处理信息响应内容
        /// 票据背书交易信息
        /// </summary>
        public NTCUSATHZ4 NTCUSATHZ4 { get; set; }
        /// <summary>
        /// 19.2.17.交易票据业务处理信息响应内容
        /// 票据赎回交易信息
        /// </summary>
        public NTCUSATHZ5 NTCUSATHZ5 { get; set; }
        /// <summary>
        /// 19.2.17.交易票据业务处理信息响应内容
        /// 票据提前兑付交易信息
        /// </summary>
        public NTCUSATHZ6 NTCUSATHZ6 { get; set; }
    }
    /// <summary>
    /// 19.2.17.交易票据业务处理信息响应内容
    /// </summary>
    public class NTCUSLSTZ
    {
        /// <summary>
        /// 业务请求号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 票据流水号	C(10)
        /// </summary>
        public string SEQNBR { get; set; }
        /// <summary>
        /// 票据类型	C(3)	BCP=银行承兑汇票;CCP=商业承对汇票
        /// </summary>
        public string TKTTYP { get; set; }
        /// <summary>
        /// 网上票据标志	C(1)	E=电子票据签发; A=实物汇票申请
        /// </summary>
        public string NETFLG { get; set; }
        /// <summary>
        /// 汇票号标志	C(4)
        /// </summary>
        public string TKTSQF { get; set; }
        /// <summary>
        /// 票据号	C(20)	
        /// </summary>
        public string TKTSEQ { get; set; }
        /// <summary>
        /// 付款行联行号	C(20)
        /// </summary>
        public string OPNBNK { get; set; }
        /// <summary>
        /// 票据中心标志	C(6)
        /// </summary>
        public string OPNBRH { get; set; }
        /// <summary>
        /// 付款行全称	Z(62)
        /// </summary>
        public string BNKNAM { get; set; }
        /// <summary>
        /// 付款行地址	Z(62)
        /// </summary>
        public string BNKADR { get; set; }
        /// <summary>
        /// 出票人名称	Z(62)
        /// </summary>
        public string PAYNAM { get; set; }
        /// <summary>
        /// 出票人帐号	C(35)	
        /// </summary>
        public string PAYACC { get; set; }
        /// <summary>
        /// 出票人分行号	C(2)
        /// </summary>
        public string PAYBBK { get; set; }
        /// <summary>
        /// 企业银行编号	C(8)
        /// </summary>
        public string MCHNTB { get; set; }
        /// <summary>
        /// 客户编号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 汇票币种	C(2)
        /// </summary>
        public string TKTCUY { get; set; }
        /// <summary>
        /// 汇票金额	M
        /// </summary>
        public decimal? TKTAMT { get; set; }
        /// <summary>
        /// 出票日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? OPNDAT { get; set; }
        /// <summary>
        /// 出票日期	D, 对应<see cref="OPNDAT"/>
        /// </summary>
        [XmlElement("OPNDAT")]
        public string OPNDATStr
        {
            get
            {
                return this.OPNDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.OPNDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? ENDDAT { get; set; }
        /// <summary>
        /// 到期日期	D, 对应<see cref="ENDDAT"/>
        /// </summary>
        [XmlElement("ENDDAT")]
        public string ENDDATStr
        {
            get
            {
                return this.ENDDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.ENDDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 承兑协议号	C(10)
        /// </summary>
        public string TSTSEQ { get; set; }
        /// <summary>
        /// 收款人企业银行编号	C(8)
        /// </summary>
        public string RCVNTB { get; set; }
        /// <summary>
        /// 收款人客户编号	C(6)
        /// </summary>
        public string RCVNBR { get; set; }
        /// <summary>
        /// 收款人开户行联行号	C(6)
        /// </summary>
        public string RCVBNK { get; set; }
        /// <summary>
        /// 收款人票据中心标志	C(6)
        /// </summary>
        public string RCVBRH { get; set; }
        /// <summary>
        /// 收款人开户行名称	Z(62)
        /// </summary>
        public string RBKNAM { get; set; }
        /// <summary>
        /// 收款人名称	Z(62)
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 收款人账号	C(35)	
        /// </summary>
        public string RCVACC { get; set; }
        /// <summary>
        /// 收款人分行号	C(2)
        /// </summary>
        public string RCVBBK { get; set; }
        /// <summary>
        /// 持票人企业银行编号	C(8)
        /// </summary>
        public string LSTNTB { get; set; }
        /// <summary>
        /// 持票人客户编号	C(10)
        /// </summary>
        public string LSTNBR { get; set; }
        /// <summary>
        /// 持票人名称	Z(62)
        /// </summary>
        public string LSTNAM { get; set; }
        /// <summary>
        /// 托管中心标志	C(6)
        /// </summary>
        public string SAVBRH { get; set; }
        /// <summary>
        /// 托管来源标志	C(10)
        /// </summary>
        public string SAVSOC { get; set; }
        /// <summary>
        /// 背书标志	C(1)
        /// </summary>
        public string WRTFLG { get; set; }
        /// <summary>
        /// 不可转让标志	C(1)
        /// </summary>
        public string TRMFLG { get; set; }
        /// <summary>
        /// 票据当前交易状态	C(1)
        /// </summary>
        public string TRSSTA { get; set; }
        /// <summary>
        /// 托管日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? HADIND { get; set; }
        /// <summary>
        /// 托管日期	D, 对应<see cref="HADIND"/>
        /// </summary>
        [XmlElement("HADIND")]
        public string HADINDStr
        {
            get
            {
                return this.HADIND?.ToString("yyyyMMdd");
            }
            set
            {
                this.HADIND = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.HADIND = tmp;
                }
            }
        }
        /// <summary>
        /// 特殊标志	C(1)    ‘P’：表示该票据在对应的交易流水号中作质押用途
        /// </summary>
        public string SPFSTA { get; set; }
        /// <summary>
        /// 汇票状态	C(1)	A.10 汇票状态
        /// </summary>
        public string TKTSTA { get; set; }
        /// <summary>
        /// 记录状态	C(1)	A.11 记录状态
        /// </summary>
        public string RCDSTS { get; set; }
    }
    /// <summary>
    /// 19.2.17.交易票据业务处理信息响应内容
    /// 用于输出电子票签发或实票签发时返回该批次交易的保证金比例及手续费比例等信息
    /// </summary>
    public class NTCUSATHZ0
    {
        /// <summary>
        /// 经办日期	S(8,0)
        /// </summary>
        [XmlIgnore]
        public DateTime? TRSDTA { get; set; }
        /// <summary>
        /// 经办日期	S(8,0), 对应<see cref="TRSDTA"/>
        /// </summary>
        [XmlElement("TRSDTA")]
        public string TRSDTAStr
        {
            get
            {
                return this.TRSDTA?.ToString("yyyyMMdd");
            }
            set
            {
                this.TRSDTA = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 交易流水号	A(10)
        /// </summary>
        public string TRSSEQ { get; set; }
        /// <summary>
        /// 交易类型	A(4)
        /// </summary>
        public string CODTPY { get; set; }
        /// <summary>
        /// 保证金比例	F(5,2)  百分比，无%号
        /// </summary>
        public decimal? BALPER { get; set; }
        /// <summary>
        /// 手续费比例	F(5,2)  百分比，无%号
        /// </summary>
        public decimal? CHGPER { get; set; }
        /// <summary>
        /// 保留字	A(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
    /// <summary>
    /// 19.2.17.交易票据业务处理信息响应内容
    /// 票据质押交易信息
    /// </summary>
    public class NTCUSATHZ1
    {
        /// <summary>
        /// 交易日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? TRSDTA { get; set; }
        /// <summary>
        /// 交易日期	D, 对应<see cref="TRSDTA"/>
        /// </summary>
        [XmlElement("TRSDTA")]
        public string TRSDTAStr
        {
            get
            {
                return this.TRSDTA?.ToString("yyyyMMdd");
            }
            set
            {
                this.TRSDTA = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 交易流水号	C(10)
        /// </summary>
        public string TRSSEQ { get; set; }
        /// <summary>
        /// 交易类型	A(4)    ‘PGAG’：票据质押
        /// </summary>
        public string CODTPY { get; set; }
        /// <summary>
        /// 质押合同号	C(10)
        /// </summary>
        public string CTTSEQ { get; set; }
        /// <summary>
        /// 质押用途	C(1)	E：综合额度 L：质押贷款 P：质押开票
        /// </summary>
        public string TRSAID { get; set; }
        /// <summary>
        /// 质押日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? OPNDTA { get; set; }
        /// <summary>
        /// 质押日期	D, 对应<see cref="OPNDTA"/>
        /// </summary>
        [XmlElement("OPNDTA")]
        public string OPNDTAStr
        {
            get
            {
                return this.OPNDTA?.ToString("yyyyMMdd");
            }
            set
            {
                this.OPNDTA = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPNDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 质押到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? ENDDTA { get; set; }
        /// <summary>
        /// 质押到期日	D, 对应<see cref="ENDDTA"/>
        /// </summary>
        [XmlElement("ENDDTA")]
        public string ENDDTAStr
        {
            get
            {
                return this.ENDDTA?.ToString("yyyyMMdd");
            }
            set
            {
                this.ENDDTA = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 质押比例	C(3)
        /// </summary>
        public string TRSINT { get; set; }
        /// <summary>
        /// 质押贷款金额	M
        /// </summary>
        public decimal? LONAMT { get; set; }
        /// <summary>
        /// 质押手续费	M
        /// </summary>
        public decimal? FEEAMT { get; set; }
        /// <summary>
        /// 新额度编号	C(10)   如果是综合额度质押，需要银行输入新产生的额度编号
        /// </summary>
        public string GRTSEQ { get; set; }
        /// <summary>
        /// 新额度期限描述	Z(62)
        /// </summary>
        public string GRTDSP { get; set; }
    }
    /// <summary>
    /// 19.2.17.交易票据业务处理信息响应内容
    /// 票据质押开票交易信息
    /// </summary>
    public class NTCUSATHZ2
    {
        /// <summary>
        /// 经办日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? TRSDTA { get; set; }
        /// <summary>
        /// 经办日期	D, 对应<see cref="TRSDTA"/>
        /// </summary>
        [XmlElement("TRSDTA")]
        public string TRSDTAStr
        {
            get
            {
                return this.TRSDTA?.ToString("yyyyMMdd");
            }
            set
            {
                this.TRSDTA = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 交易流水号	C(10)
        /// </summary>
        public string TRSSEQ { get; set; }
        /// <summary>
        /// 交易类型	A(4)    ‘PGAG’：票据质押
        /// </summary>
        public string CODTPY { get; set; }
        /// <summary>
        /// 质押日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? OPNDTA { get; set; }
        /// <summary>
        /// 质押日期	D, 对应<see cref="OPNDTA"/>
        /// </summary>
        [XmlElement("OPNDTA")]
        public string OPNDTAStr
        {
            get
            {
                return this.OPNDTA?.ToString("yyyyMMdd");
            }
            set
            {
                this.OPNDTA = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPNDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 质押到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? ENDDTA { get; set; }
        /// <summary>
        /// 质押到期日	D, 对应<see cref="ENDDTA"/>
        /// </summary>
        [XmlElement("ENDDTA")]
        public string ENDDTAStr
        {
            get
            {
                return this.ENDDTA?.ToString("yyyyMMdd");
            }
            set
            {
                this.ENDDTA = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 质押合同号	C(10)
        /// </summary>
        public string CTTSEQ { get; set; }
        /// <summary>
        /// 质押用途	C(1)	E：综合额度 L：质押贷款 P：质押开票
        /// </summary>
        public string TRSAID { get; set; }
        /// <summary>
        /// 质押比例	C(3)
        /// </summary>
        public string TRSINT { get; set; }
        /// <summary>
        /// 质押贷款金额	M
        /// </summary>
        public decimal? LONAMT { get; set; }
        /// <summary>
        /// 质押手续费	M
        /// </summary>
        public decimal? FEEAMT { get; set; }
        /// <summary>
        /// 新开票据号	C(10)
        /// </summary>
        public string SEQNBR { get; set; }
        /// <summary>
        /// 出票日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? DRFOPN { get; set; }
        /// <summary>
        /// 出票日期	D, 对应<see cref="DRFOPN"/>
        /// </summary>
        [XmlElement("DRFOPN")]
        public string DRFOPNStr
        {
            get
            {
                return this.DRFOPN?.ToString("yyyyMMdd");
            }
            set
            {
                this.DRFOPN = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DRFOPN = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? DRFEND { get; set; }
        /// <summary>
        /// 到期日期	D, 对应<see cref="DRFEND"/>
        /// </summary>
        [XmlElement("DRFEND")]
        public string DRFENDStr
        {
            get
            {
                return this.DRFEND?.ToString("yyyyMMdd");
            }
            set
            {
                this.DRFEND = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DRFEND = tmp;
                }
            }
        }
        /// <summary>
        /// 承兑协议号	C(10)
        /// </summary>
        public string SEQGRT { get; set; }
        /// <summary>
        /// 保证金比例	F(5,2)
        /// </summary>
        public decimal? BALPER { get; set; }
        /// <summary>
        /// 手续费比例	F(5,2)
        /// </summary>
        public decimal? CHGPER { get; set; }
        /// <summary>
        /// 保留字段	A(20)
        /// </summary>
        public string RSV30Z { get; set; }
    }
    /// <summary>
    /// 19.2.17.交易票据业务处理信息响应内容
    /// 票据贴现交易信息
    /// </summary>
    public class NTCUSATHZ3
    {
        /// <summary>
        /// 经办日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? TRSDTA { get; set; }
        /// <summary>
        /// 经办日期	D, 对应<see cref="TRSDTA"/>
        /// </summary>
        [XmlElement("TRSDTA")]
        public string TRSDTAStr
        {
            get
            {
                return this.TRSDTA?.ToString("yyyyMMdd");
            }
            set
            {
                this.TRSDTA = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 交易流水号	C(10)
        /// </summary>
        public string TRSSEQ { get; set; }
        /// <summary>
        /// 交易类型	A(4)    PCSH=正常贴现 PBSH=买方付息贴现
        /// </summary>
        public string CODTPY { get; set; }
        /// <summary>
        /// 贴现合同号	C(10)
        /// </summary>
        public string CTTSEQ { get; set; }
        /// <summary>
        /// 贴现利率	T
        /// </summary>
        public string TRSINT { get; set; }
        /// <summary>
        /// 贴现天数	N(3)
        /// </summary>
        public int? TRSDAY { get; set; }
        /// <summary>
        /// 贴现利息总金额	M
        /// </summary>
        public decimal? INTAMT { get; set; }
        /// <summary>
        /// 实付贴现总金额	M
        /// </summary>
        public decimal? TRSAMT { get; set; }
        /// <summary>
        /// 经办张数	C(6)
        /// </summary>
        public string DRFNUM { get; set; }
        /// <summary>
        /// 收方分行号	C(2)
        /// </summary>
        public string CRTBBK { get; set; }
        /// <summary>
        /// 收款帐号	C(35)
        /// </summary>
        public string CRTACC { get; set; }
        /// <summary>
        /// 收方户名	Z(62)
        /// </summary>
        public string CRTNAM { get; set; }
        /// <summary>
        /// 收方行名称	Z(62)
        /// </summary>
        public string CRTBNK { get; set; }
        /// <summary>
        /// 收方行地址	Z(62)
        /// </summary>
        public string CRTADR { get; set; }
        /// <summary>
        /// 票据流水号	C(10)
        /// </summary>
        public string SEQNBR { get; set; }
    }
    /// <summary>
    /// 19.2.17.交易票据业务处理信息响应内容
    /// 票据背书交易信息
    /// </summary>
    public class NTCUSATHZ4
    {
        /// <summary>
        /// 票据流水号	C(10)
        /// </summary>
        public string SEQNBR { get; set; }
        /// <summary>
        /// 交易流水号	C(10)
        /// </summary>
        public string TRSSEQ { get; set; }
        /// <summary>
        /// 交易类型	A(4)    EPTR=票据背书
        /// </summary>
        public string CODTPY { get; set; }
        /// <summary>
        /// 背书日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? PAYDTA { get; set; }
        /// <summary>
        /// 背书日期	D, 对应<see cref="PAYDTA"/>
        /// </summary>
        [XmlElement("PAYDTA")]
        public string PAYDTAStr
        {
            get
            {
                return this.PAYDTA?.ToString("yyyyMMdd");
            }
            set
            {
                this.PAYDTA = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PAYDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 被背书人企业银行编号	C(10)
        /// </summary>
        public string OBJMCH { get; set; }
        /// <summary>
        /// 被背书人客户编号	C(10)
        /// </summary>
        public string OBJNBR { get; set; }
        /// <summary>
        /// 被背书人名称	Z(62)
        /// </summary>
        public string OBJNAM { get; set; }
        /// <summary>
        /// 背书载要	Z(62)
        /// </summary>
        public string PAYDSP { get; set; }
        /// <summary>
        /// 经办日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? TRSDTA { get; set; }
        /// <summary>
        /// 经办日期	D, 对应<see cref="TRSDTA"/>
        /// </summary>
        [XmlElement("TRSDTA")]
        public string TRSDTAStr
        {
            get
            {
                return this.TRSDTA?.ToString("yyyyMMdd");
            }
            set
            {
                this.TRSDTA = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDTA = tmp;
                }
            }
        }
    }
    /// <summary>
    /// 19.2.17.交易票据业务处理信息响应内容
    /// 票据赎回交易信息
    /// </summary>
    public class NTCUSATHZ5
    {
        /// <summary>
        /// 经办日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? TRSDTA { get; set; }
        /// <summary>
        /// 经办日期	D, 对应<see cref="TRSDTA"/>
        /// </summary>
        [XmlElement("TRSDTA")]
        public string TRSDTAStr
        {
            get
            {
                return this.TRSDTA?.ToString("yyyyMMdd");
            }
            set
            {
                this.TRSDTA = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 交易流水号	C(10)
        /// </summary>
        public string TRSSEQ { get; set; }
        /// <summary>
        /// 交易类型	A(4)   PBCK=票据赎回
        /// </summary>
        public string CODTPY { get; set; }
        /// <summary>
        /// 贴现合同号	C(10)
        /// </summary>
        public string CTTSEQ { get; set; }
        /// <summary>
        /// 利率	T
        /// </summary>
        public string TRSINT { get; set; }
        /// <summary>
        /// 实付赎回总金额	M
        /// </summary>
        public decimal? TRSAMT { get; set; }
        /// <summary>
        /// 已付贴现利息总金额	M
        /// </summary>
        public decimal? INTAMT { get; set; }
        /// <summary>
        /// 退回贴现利息总金额	M
        /// </summary>
        public decimal? RETAMT { get; set; }
    }
    /// <summary>
    /// 19.2.17.交易票据业务处理信息响应内容
    /// 票据提前兑付交易信息
    /// </summary>
    public class NTCUSATHZ6
    {
        /// <summary>
        /// 经办日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? TRSDTA { get; set; }
        /// <summary>
        /// 经办日期	D, 对应<see cref="TRSDTA"/>
        /// </summary>
        [XmlElement("TRSDTA")]
        public string TRSDTAStr
        {
            get
            {
                return this.TRSDTA?.ToString("yyyyMMdd");
            }
            set
            {
                this.TRSDTA = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 交易流水号	C(10)
        /// </summary>
        public string TRSSEQ { get; set; }
        /// <summary>
        /// 交易类型	C(4)   ACSH =提前兑付
        /// </summary>
        public string CODTPY { get; set; }
        /// <summary>
        /// 贴现合同号	C(10)
        /// </summary>
        public string ASHSEQ { get; set; }
        /// <summary>
        /// 汇票票面总金额	M
        /// </summary>
        public decimal? TALAMT { get; set; }
        /// <summary>
        /// 提前兑付日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? ASHDAT { get; set; }
        /// <summary>
        /// 提前兑付日	D, 对应<see cref="ASHDAT"/>
        /// </summary>
        [XmlElement("ASHDAT")]
        public string ASHDATStr
        {
            get
            {
                return this.ASHDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.ASHDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ASHDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 提前兑付手续费	M
        /// </summary>
        public decimal? ASHFEE { get; set; }
        /// <summary>
        /// 应退贴现利息	M
        /// </summary>
        public decimal? INTAMT { get; set; }
        /// <summary>
        /// 实付兑付总金额	M
        /// </summary>
        public decimal? ASHAMT { get; set; }
        /// <summary>
        /// 经办张数	C(6)
        /// </summary>
        public string DRFNUM { get; set; }
        /// <summary>
        /// 出票人分行号	C(2)
        /// </summary>
        public string OPNBBK { get; set; }
        /// <summary>
        /// 出票人账号	C(35)	
        /// </summary>
        public string OPNACC { get; set; }
        /// <summary>
        /// 出票人名称	Z(62)
        /// </summary>
        public string PAYNAM { get; set; }
        /// <summary>
        /// 付款行全称	Z(62)
        /// </summary>
        public string BNKNAM { get; set; }
        /// <summary>
        /// 付款行地址	Z(62)
        /// </summary>
        public string BNKADR { get; set; }
    }
}
