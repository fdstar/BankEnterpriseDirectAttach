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
    /// 2.7.查询电子回单信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS2_7 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKCSFDFBRT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKCSFDFBRT";
        /// <summary>
        /// 2.7.查询电子回单信息响应集合
        /// </summary>
        [XmlElement("CSRRCFDFZ1")]
        public List<CSRRCFDFZ1> CSRRCFDFZ1List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    企业银行付款回单
        /// </summary>
        [XmlElement("CSTRFPRTX0")]
        public List<CSTRFPRTX0> CSTRFPRTX0List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    企业银行代发付款回单
        /// </summary>
        [XmlElement("AGNCBPAYZ1")]
        public List<AGNCBPAYZ1> AGNCBPAYZ1List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    企业银行扣费回单
        /// </summary>
        [XmlElement("ABFEEPRTZ1")]
        public List<ABFEEPRTZ1> ABFEEPRTZ1List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    企业银行代发代扣收费回单
        /// </summary>
        [XmlElement("AGFEERRCZ1")]
        public List<AGFEERRCZ1> AGFEERRCZ1List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    企业银行代发代扣收费回单
        /// </summary>
        [XmlElement("AGFEERRCZ2")]
        public List<AGFEERRCZ2> AGFEERRCZ2List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    对公转账付款回单（批量）
        /// </summary>
        [XmlElement("CPRRCSNDX1")]
        public List<CPRRCSNDX1> CPRRCSNDX1List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    对公转账收款回单（批量）；对公转账内部撤销冲账回单（批量）
        /// </summary>
        [XmlElement("CPRRCRCVX1")]
        public List<CPRRCRCVX1> CPRRCRCVX1List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    对公转账退票回单（批量）
        /// </summary>
        [XmlElement("CPRRCRTNX1")]
        public List<CPRRCRTNX1> CPRRCRTNX1List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    国际结算费用借记实时
        /// </summary>
        [XmlElement("ISRRCFDTZ1")]
        public List<ISRRCFDTZ1> ISRRCFDTZ1List { get; set; }
    }
    #region
    /// <summary>
    /// 2.7.查询电子回单信息响应内容
    /// </summary>
    public class CSRRCFDFZ1
    {
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 验证码	C(16)
        /// </summary>
        public string CHKCOD { get; set; }
        /// <summary>
        /// 回单代码	C(8)
        /// </summary>
        public string ITMCOD { get; set; }
        /// <summary>
        /// 流水号	C（16）
        /// </summary>
        public string TRSSEQ { get; set; }
        /// <summary>
        /// 特殊码	C(40)
        /// </summary>
        public string SPLC40 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    企业银行付款回单
    /// </summary>
    public class CSTRFPRTX0
    {
        /// <summary>
        /// 付方户口号	C(35)
        /// </summary>
        public string SNDEAC { get; set; }
        /// <summary>
        /// 付方户名	Z(100)
        /// </summary>
        public string SNDEAN { get; set; }
        /// <summary>
        /// 付方开户行	Z(100)
        /// </summary>
        public string SNDEAB { get; set; }
        /// <summary>
        /// 付方开户地	Z(100)
        /// </summary>
        public string SNDEAA { get; set; }
        /// <summary>
        /// 收方户口号	C(35)
        /// </summary>
        public string RCVEAC { get; set; }
        /// <summary>
        /// 收方户名	Z(100)
        /// </summary>
        public string RCVEAN { get; set; }
        /// <summary>
        /// 收方开户行	Z(100)
        /// </summary>
        public string RCVEAB { get; set; }
        /// <summary>
        /// 收方开户地	Z(100)
        /// </summary>
        public string RCVEAA { get; set; }
        /// <summary>
        /// 票据种类	C(4)
        /// </summary>
        public string BILTYP { get; set; }
        /// <summary>
        /// 票据号码	C(20)
        /// </summary>
        public string BILNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 交易货币	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 代理行交换号	C(20)
        /// </summary>
        public string AGTBBN { get; set; }
        /// <summary>
        /// 代理行行名	Z(100)
        /// </summary>
        public string AGTBKN { get; set; }
        /// <summary>
        /// 汇出地点	Z(100)
        /// </summary>
        public string SMTADR { get; set; }
        /// <summary>
        /// 发起日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ISUDAT { get; set; }
        /// <summary>
        /// 发起日期	D, 对应<see cref="ISUDAT"/>
        /// </summary>
        [XmlElement("ISUDAT")]
        public string ISUDATStr
        {
            get
            {
                return this.ISUDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ISUDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 起息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime RTEDAT { get; set; }
        /// <summary>
        /// 起息日	D, 对应<see cref="RTEDAT"/>
        /// </summary>
        [XmlElement("RTEDAT")]
        public string RTEDATStr
        {
            get
            {
                return this.RTEDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RTEDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 摘要	Z(100)
        /// </summary>
        public string NARTXT { get; set; }
        /// <summary>
        /// 交易流水号	C(15)
        /// </summary>
        public string REFNBR { get; set; }
        /// <summary>
        /// 原交易流水号	C(15)
        /// </summary>
        public string ORGREF { get; set; }
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 附加摘要	C(20)
        /// </summary>
        public string EXTNAR { get; set; }
        /// <summary>
        /// 提出日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime SMTDAT { get; set; }
        /// <summary>
        /// 提出日期	D, 对应<see cref="SMTDAT"/>
        /// </summary>
        [XmlElement("SMTDAT")]
        public string SMTDATStr
        {
            get
            {
                return this.SMTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SMTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 打印顺序	C(6)
        /// </summary>
        public string SEQNBR { get; set; }
        /// <summary>
        /// 票交付方行号	C(12)
        /// </summary>
        public string SNDBK1 { get; set; }
        /// <summary>
        /// 票交收方行号	C(12)
        /// </summary>
        public string RCVBK1 { get; set; }
        /// <summary>
        /// 扩展摘要	Z(100)
        /// </summary>
        public string NARTX1 { get; set; }
        /// <summary>
        /// 凭证顺序号	C(30)
        /// </summary>
        public string PSBSEQ { get; set; }
        /// <summary>
        /// 附加摘要1	Z(62)
        /// </summary>
        public string BNKRM1 { get; set; }
        /// <summary>
        /// 附加摘要2	Z(62)
        /// </summary>
        public string BNKRM2 { get; set; }
        /// <summary>
        /// 附加摘要3	Z(62)
        /// </summary>
        public string BNKRM3 { get; set; }
        /// <summary>
        /// 附加摘要4	Z(62)
        /// </summary>
        public string BNKRM4 { get; set; }
        /// <summary>
        /// 附加摘要5	Z(62)
        /// </summary>
        public string BNKRM5 { get; set; }
        /// <summary>
        /// 附加摘要6	Z(62)
        /// </summary>
        public string BNKRM6 { get; set; }
        /// <summary>
        /// 保留位	C(30)
        /// </summary>
        public string RVSTXT { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    企业银行代发付款回单
    /// </summary>
    public class AGNCBPAYZ1
    {
        /// <summary>
        /// 产品编码	C(8)
        /// </summary>
        public string PRDCOD { get; set; }
        /// <summary>
        /// 合作协议号	C(6)
        /// </summary>
        public string CNVNBR { get; set; }
        /// <summary>
        /// 交易批次号	C(10)
        /// </summary>
        public string BTHNBR { get; set; }
        /// <summary>
        /// 任务实例号	C(13)
        /// </summary>
        public string TSKNBR { get; set; }
        /// <summary>
        /// 收款户口号	C(35)
        /// </summary>
        public string RCVEAC { get; set; }
        /// <summary>
        /// 收款客户名称	Z(62)
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 收款户口开户行	C(6)
        /// </summary>
        public string RCVBRN { get; set; }
        /// <summary>
        /// 付款户口号	C(35)
        /// </summary>
        public string PAYEAC { get; set; }
        /// <summary>
        /// 付款客户名称	Z(62)
        /// </summary>
        public string PAYNAM { get; set; }
        /// <summary>
        /// 付款户口开户行	C(6)
        /// </summary>
        public string PAYBRN { get; set; }
        /// <summary>
        /// 交易货币	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 摘要	Z(62)
        /// </summary>
        public string TRXRMK { get; set; }
        /// <summary>
        /// 交易日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime TRXDAT { get; set; }
        /// <summary>
        /// 交易日期	D, 对应<see cref="TRXDAT"/>
        /// </summary>
        [XmlElement("TRXDAT")]
        public string TRXDATStr
        {
            get
            {
                return this.TRXDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRXDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 交易网点	C(6)
        /// </summary>
        public string TRXBRN { get; set; }
        /// <summary>
        /// 交易套号	C(15)
        /// </summary>
        public string TRXSET { get; set; }
        /// <summary>
        /// 交易流水号	C(15)
        /// </summary>
        public string TRXNBR { get; set; }
        /// <summary>
        /// 交易参考号	C(30)
        /// </summary>
        public string TRSREF { get; set; }
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 特殊码100	Z(100)
        /// </summary>
        public string SPL100 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    企业银行扣费回单
    /// </summary>
    public class ABFEEPRTZ1
    {
        /// <summary>
        /// 发生日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime SYSDAT { get; set; }
        /// <summary>
        /// 发生日期	D, 对应<see cref="SYSDAT"/>
        /// </summary>
        [XmlElement("SYSDAT")]
        public string SYSDATStr
        {
            get
            {
                return this.SYSDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SYSDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 流水号	C(16)
        /// </summary>
        public string SEQNBR { get; set; }
        /// <summary>
        /// 流水号	C(15)
        /// </summary>
        public string TRXSET { get; set; }
        /// <summary>
        /// 部门号	C(6)
        /// </summary>
        public string BRNNBR { get; set; }
        /// <summary>
        /// 账号／户口	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 资金地区	C(3)
        /// </summary>
        public string ACTRGN { get; set; }
        /// <summary>
        /// 钞汇标志	C(1)
        /// </summary>
        public string CCYTYP { get; set; }
        /// <summary>
        /// 账户代码	C(5)
        /// </summary>
        public string ACTCOD { get; set; }
        /// <summary>
        /// 客户号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 账户序号	C(5)
        /// </summary>
        public string ACTSEQ { get; set; }
        /// <summary>
        /// 货币	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 科目／核算种类	C(8)
        /// </summary>
        public string ACCITM { get; set; }
        /// <summary>
        /// 金额码	C(1)
        /// </summary>
        public string AMTCOD { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal AMTTRS { get; set; }
        /// <summary>
        /// 账单摘要	Z(16)
        /// </summary>
        public string NARSMT { get; set; }
        /// <summary>
        /// 业务编号	C(20)
        /// </summary>
        public string BUSNBR { get; set; }
        /// <summary>
        /// 户名	Z(62)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 机构名称	Z(22)
        /// </summary>
        public string BRNNAM { get; set; }
        /// <summary>
        /// 打印实例	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 保留字段	C(80)
        /// </summary>
        public string SPLC80 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    企业银行代发代扣收费回单
    /// </summary>
    public class AGFEERRCZ1
    {
        /// <summary>
        /// 交易流水号	C(15)
        /// </summary>
        public string TRXNBR { get; set; }
        /// <summary>
        /// 合作协议号	C(6)
        /// </summary>
        public string CNVNBR { get; set; }
        /// <summary>
        /// 产品编码	C(8)
        /// </summary>
        public string PRDCOD { get; set; }
        /// <summary>
        /// 交易批次号	C(10)
        /// </summary>
        public string BTHNBR { get; set; }
        /// <summary>
        /// 付费方式	C(1)
        /// </summary>
        public string FEEMOD { get; set; }
        /// <summary>
        /// 付费户口号	C(35)
        /// </summary>
        public string FEEEAC { get; set; }
        /// <summary>
        /// 付费户口名称	Z(62)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 付费户口开户行	C(6)
        /// </summary>
        public string EACBRN { get; set; }
        /// <summary>
        /// 收费货币	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 收费金额	M
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 摘要	Z(62)
        /// </summary>
        public string TRXRMK { get; set; }
        /// <summary>
        /// 交易日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime TRXDAT { get; set; }
        /// <summary>
        /// 交易日期	D, 对应<see cref="TRXDAT"/>
        /// </summary>
        [XmlElement("TRXDAT")]
        public string TRXDATStr
        {
            get
            {
                return this.TRXDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRXDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 交易网点	C(6)
        /// </summary>
        public string TRXBRN { get; set; }
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 特殊码100	C(100)
        /// </summary>
        public string SPL100 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    企业银行代发代扣收费回单
    /// </summary>
    public class AGFEERRCZ2
    {
        /// <summary>
        /// 收费项目	C(5)
        /// </summary>
        public string FEEITM { get; set; }
        /// <summary>
        /// 费用名称	Z(62)
        /// </summary>
        public string FEENAM { get; set; }
        /// <summary>
        /// 收费笔数	N(5)
        /// </summary>
        public int FEENUM { get; set; }
        /// <summary>
        /// 收费币种	C(2)
        /// </summary>
        public string FEECCY { get; set; }
        /// <summary>
        /// 收费金额	M
        /// </summary>
        public decimal FEEAMT { get; set; }
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 特殊码100	C(100)
        /// </summary>
        public string SPL100 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    对公转账付款回单（批量）
    /// </summary>
    public class CPRRCSNDX1
    {
        /// <summary>
        /// 回单类型	C(8)
        /// </summary>
        public string RRCTYP { get; set; }
        /// <summary>
        /// 交易机构	C(6)
        /// </summary>
        public string BRNNBR { get; set; }
        /// <summary>
        /// 付方户口号	C(35)
        /// </summary>
        public string SNDEAC { get; set; }
        /// <summary>
        /// 付方户名	Z(62)
        /// </summary>
        public string SNDEAN { get; set; }
        /// <summary>
        /// 付方开户行	Z(62)
        /// </summary>
        public string SNDEAB { get; set; }
        /// <summary>
        /// 付方开户地	Z(62)
        /// </summary>
        public string SNDEAA { get; set; }
        /// <summary>
        /// 登记户口号	C(35)
        /// </summary>
        public string REGEAC { get; set; }
        /// <summary>
        /// 收方户口号	C(35)
        /// </summary>
        public string RCVEAC { get; set; }
        /// <summary>
        /// 收方户名	Z(62)
        /// </summary>
        public string RCVEAN { get; set; }
        /// <summary>
        /// 收方开户行	Z(62)
        /// </summary>
        public string RCVEAB { get; set; }
        /// <summary>
        /// 收方开户地	Z(62)
        /// </summary>
        public string RCVEAA { get; set; }
        /// <summary>
        /// 凭证种类	C(4)
        /// </summary>
        public string PSBTYP { get; set; }
        /// <summary>
        /// 凭证号码	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 发起日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ISUDAT { get; set; }
        /// <summary>
        /// 发起日期	D, 对应<see cref="ISUDAT"/>
        /// </summary>
        [XmlElement("ISUDAT")]
        public string ISUDATStr
        {
            get
            {
                return this.ISUDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ISUDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 交易货币	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 交易流水	C(30)
        /// </summary>
        public string TRSNBR { get; set; }
        /// <summary>
        /// 任务号	C(13)
        /// </summary>
        public string TSKNBR { get; set; }
        /// <summary>
        /// 汇款编号	C(16)
        /// </summary>
        public string BUSNBR { get; set; }
        /// <summary>
        /// 经办柜员	C(6)
        /// </summary>
        public string TLRNBR { get; set; }
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 摘要	Z(100)
        /// </summary>
        public string NARTXT { get; set; }
        /// <summary>
        /// 扩展摘要	Z(100)
        /// </summary>
        public string NARTX1 { get; set; }
        /// <summary>
        /// 企银业务代码	C(6)
        /// </summary>
        public string REFTCD { get; set; }
        /// <summary>
        /// 特殊码74	C(74)
        /// </summary>
        public string SPLC80 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    对公转账收款回单（批量）；对公转账内部撤销冲账回单（批量）
    /// </summary>
    public class CPRRCRCVX1
    {
        /// <summary>
        /// 回单类型	C(8)
        /// </summary>
        public string RRCTYP { get; set; }
        /// <summary>
        /// 业务类型	Z(100)
        /// </summary>
        public string BUSNAR { get; set; }
        /// <summary>
        /// 交易机构	C(6)
        /// </summary>
        public string BRNNBR { get; set; }
        /// <summary>
        /// 付方户口号	C(35)
        /// </summary>
        public string SNDEAC { get; set; }
        /// <summary>
        /// 付方户名	Z(62)
        /// </summary>
        public string SNDEAN { get; set; }
        /// <summary>
        /// 付方开户行	Z(62)
        /// </summary>
        public string SNDEAB { get; set; }
        /// <summary>
        /// 付方开户地	Z(62)
        /// </summary>
        public string SNDEAA { get; set; }
        /// <summary>
        /// 登记户口号	C(35)
        /// </summary>
        public string REGEAC { get; set; }
        /// <summary>
        /// 收方户口号	C(35)
        /// </summary>
        public string RCVEAC { get; set; }
        /// <summary>
        /// 收方户名	Z(62)
        /// </summary>
        public string RCVEAN { get; set; }
        /// <summary>
        /// 收方开户行	Z(62)
        /// </summary>
        public string RCVEAB { get; set; }
        /// <summary>
        /// 收方开户地	Z(62)
        /// </summary>
        public string RCVEAA { get; set; }
        /// <summary>
        /// 凭证种类	C(4)
        /// </summary>
        public string PSBTYP { get; set; }
        /// <summary>
        /// 凭证号码	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 发起日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ISUDAT { get; set; }
        /// <summary>
        /// 发起日期	D, 对应<see cref="ISUDAT"/>
        /// </summary>
        [XmlElement("ISUDAT")]
        public string ISUDATStr
        {
            get
            {
                return this.ISUDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ISUDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 起息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? VALDAT { get; set; }
        /// <summary>
        /// 起息日	D, 对应<see cref="VALDAT"/>
        /// </summary>
        [XmlElement("VALDAT")]
        public string VALDATStr
        {
            get
            {
                return this.VALDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.VALDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.VALDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 交易货币	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 交易流水	C(30)
        /// </summary>
        public string TRSNBR { get; set; }
        /// <summary>
        /// 原交易流水	C(30)
        /// </summary>
        public string ORGTRS { get; set; }
        /// <summary>
        /// 任务号	C(13)
        /// </summary>
        public string TSKNBR { get; set; }
        /// <summary>
        /// 汇款编号	C(16)
        /// </summary>
        public string BUSNBR { get; set; }
        /// <summary>
        /// 办柜员	C(6)
        /// </summary>
        public string TLRNBR { get; set; }
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 摘要	Z(100)
        /// </summary>
        public string NARTXT { get; set; }
        /// <summary>
        /// 扩展摘要	Z(100)
        /// </summary>
        public string NARTX1 { get; set; }
        /// <summary>
        /// 特殊码80	C(80)
        /// </summary>
        public string SPLC80 { get; set; }
    }
    #endregion
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    对公转账退票回单（批量）
    /// </summary>
    public class CPRRCRTNX1
    {
        /// <summary>
        /// 回单类型	C(8)
        /// </summary>
        public string RRCTYP { get; set; }
        /// <summary>
        /// 交易机构	C(6)
        /// </summary>
        public string BRNNBR { get; set; }
        /// <summary>
        /// 退款户口号	C(35)
        /// </summary>
        public string RTNEAC { get; set; }
        /// <summary>
        /// 退款户名	Z(62)
        /// </summary>
        public string RTNEAN { get; set; }
        /// <summary>
        /// 退款开户行	Z(62)
        /// </summary>
        public string RTNEAB { get; set; }
        /// <summary>
        /// 退款开户地	Z(62)
        /// </summary>
        public string RTNEAA { get; set; }
        /// <summary>
        /// 付方户口号	C(35)
        /// </summary>
        public string SNDEAC { get; set; }
        /// <summary>
        /// 付方户名	Z(62)
        /// </summary>
        public string SNDEAN { get; set; }
        /// <summary>
        /// 付方开户行	Z(62)
        /// </summary>
        public string SNDEAB { get; set; }
        /// <summary>
        /// 付方开户地	Z(62)
        /// </summary>
        public string SNDEAA { get; set; }
        /// <summary>
        /// 登记户口号	C(35)
        /// </summary>
        public string REGEAC { get; set; }
        /// <summary>
        /// 收方户口号	C(35)
        /// </summary>
        public string RCVEAC { get; set; }
        /// <summary>
        /// 收方户名	Z(62)
        /// </summary>
        public string RCVEAN { get; set; }
        /// <summary>
        /// 收方开户行	Z(62)
        /// </summary>
        public string RCVEAB { get; set; }
        /// <summary>
        /// 收方开户地	Z(62)
        /// </summary>
        public string RCVEAA { get; set; }
        /// <summary>
        /// 凭证种类	C(4)
        /// </summary>
        public string PSBTYP { get; set; }
        /// <summary>
        /// 凭证号码	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 退款日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime RTNDAT { get; set; }
        /// <summary>
        /// 退款日期	D, 对应<see cref="RTNDAT"/>
        /// </summary>
        [XmlElement("RTNDAT")]
        public string RTNDATStr
        {
            get
            {
                return this.RTNDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RTNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 原发起日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? ISUDAT { get; set; }
        /// <summary>
        /// 原发起日期	D, 对应<see cref="ISUDAT"/>
        /// </summary>
        [XmlElement("ISUDAT")]
        public string ISUDATStr
        {
            get
            {
                return this.ISUDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.ISUDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ISUDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 交易货币	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 交易流水	C(30)
        /// </summary>
        public string TRSNBR { get; set; }
        /// <summary>
        /// 任务号	C(13)
        /// </summary>
        public string TSKNBR { get; set; }
        /// <summary>
        /// 汇款编号	C(16)
        /// </summary>
        public string BUSNBR { get; set; }
        /// <summary>
        /// 经办柜员	C(6)
        /// </summary>
        public string TLRNBR { get; set; }
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 摘要	Z(100)
        /// </summary>
        public string NARTXT { get; set; }
        /// <summary>
        /// 扩展摘要	Z(100)
        /// </summary>
        public string NARTX1 { get; set; }
        /// <summary>
        /// 特殊码80	C(80)
        /// </summary>
        public string SPLC80 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    国际结算费用借记实时
    /// </summary>
    public class ISRRCFDTZ1
    {
    }
}
