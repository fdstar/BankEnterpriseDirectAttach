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
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    国际结算汇出汇款借记
        /// </summary>
        [XmlElement("ISRRCORTZ1")]
        public List<ISRRCORTZ1> ISRRCORTZ1List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    批量结息（离岸）
        /// </summary>
        [XmlElement("ACINTCA2Z")]
        public List<ACINTCA2Z> ACINTCA2ZList { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    批量结息（离岸）
        /// </summary>
        [XmlElement("ACINTST2Z")]
        public List<ACINTST2Z> ACINTST2ZList { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    网上自助结汇回单登记输出接口
        /// </summary>
        [XmlElement("EXICORRBZ1")]
        public List<EXICORRBZ1> EXICORRBZ1List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    银承未用注销回单登记接口
        /// </summary>
        [XmlElement("AMPRTBCKX1")]
        public List<AMPRTBCKX1> AMPRTBCKX1List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    手续费回单登记接口
        /// </summary>
        [XmlElement("AMPRTFEEX1")]
        public List<AMPRTFEEX1> AMPRTFEEX1List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    批量结息回单登记接口
        /// </summary>
        [XmlElement("AMPRTINBX1")]
        public List<AMPRTINBX1> AMPRTINBX1List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    其它结息回单登记接口
        /// </summary>
        [XmlElement("AMPRTINTX1")]
        public List<AMPRTINTX1> AMPRTINTX1List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    还款回单登记接口
        /// </summary>
        [XmlElement("AMPRTPADX1")]
        public List<AMPRTPADX1> AMPRTPADX1List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    放款回单登记接口
        /// </summary>
        [XmlElement("AMPRTUSDX1")]
        public List<AMPRTUSDX1> AMPRTUSDX1List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    冲账回单登记接口
        /// </summary>
        [XmlElement("AMPRTRVSX1")]
        public List<AMPRTRVSX1> AMPRTRVSX1List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    打印结构性存款存入收款回单
        /// </summary>
        [XmlElement("SADPSVHBZ")]
        public List<SADPSVHBZ> SADPSVHBZList { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    打印结构性存款存入收款回单
        /// </summary>
        [XmlElement("SADPSVHBZ0")]
        public List<SADPSVHBZ0> SADPSVHBZ0List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    打印活期付款回单输出接口
        /// </summary>
        [XmlElement("SAFNDRPBZ")]
        public List<SAFNDRPBZ> SAFNDRPBZList { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    打印结构性存款支取付款回单
        /// </summary>
        [XmlElement("SADRWVHBZ")]
        public List<SADRWVHBZ> SADRWVHBZList { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    打印结构性存款支取付款回单
        /// </summary>
        [XmlElement("SADRWVHBZ0")]
        public List<SADRWVHBZ0> SADRWVHBZ0List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    打印活期收款回单输出接口
        /// </summary>
        [XmlElement("SAFNDRRBZ")]
        public List<SAFNDRRBZ> SAFNDRRBZList { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    利息单明细打印输出接口
        /// </summary>
        [XmlElement("SAINTLSBZ")]
        public List<SAINTLSBZ> SAINTLSBZList { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    利息单明细打印输出接口
        /// </summary>
        [XmlElement("SAINTLSBZ0")]
        public List<SAINTLSBZ0> SAINTLSBZ0List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    对公转账回单户名附加接口
        /// </summary>
        [XmlElement("CPRRCEANX1")]
        public List<CPRRCEANX1> CPRRCEANX1List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    对公转账回单户名扩展接口
        /// </summary>
        [XmlElement("CPRRCEXTX1")]
        public List<CPRRCEXTX1> CPRRCEXTX1List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    中间业务平台公司回单输出接口
        /// </summary>
        [XmlElement("MCMIDRRCZ")]
        public List<MCMIDRRCZ> MCMIDRRCZList { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    收款回单（网银互联）   付款回单（网银互联） 
        /// </summary>
        [XmlElement("NPTRFRCTX1")]
        public List<NPTRFRCTX1> NPTRFRCTX1List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    企业银行通知转活期付款回单 
        /// </summary>
        [XmlElement("TDDRWVHCZ")]
        public List<TDDRWVHCZ> TDDRWVHCZList { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    企业银行通知转活期付款回单 
        /// </summary>
        [XmlElement("TDDRWVHCZ0")]
        public List<TDDRWVHCZ0> TDDRWVHCZ0List { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    企业银行定期转活期计息清单 
        /// </summary>
        [XmlElement("TDINTLSBZ")]
        public List<TDINTLSBZ> TDINTLSBZList { get; set; }
        /// <summary>
        /// 2.7.查询电子回单信息响应集合    企业银行定期转活期计息清单 
        /// </summary>
        [XmlElement("TDINTLSBZ0")]
        public List<TDINTLSBZ0> TDINTLSBZ0List { get; set; }
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
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 收费项目	C(5)
        /// </summary>
        public string FEEITM { get; set; }
        /// <summary>
        /// 费用货币	C(3)
        /// </summary>
        public string FEECCY { get; set; }
        /// <summary>
        /// 费用金额	M
        /// </summary>
        public decimal FEEAMT { get; set; }
        /// <summary>
        /// 费用笔数	N(2)
        /// </summary>
        public int FEECNT { get; set; }
        /// <summary>
        /// 特殊码100	C(100)
        /// </summary>
        public string SPL100 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    国际结算汇出汇款借记
    /// </summary>
    public class ISRRCORTZ1
    {
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 回单编号	C(16)
        /// </summary>
        public string EEVNBR { get; set; }
        /// <summary>
        /// 日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime REGDAT { get; set; }
        /// <summary>
        /// 日期	D, 对应<see cref="REGDAT"/>
        /// </summary>
        [XmlElement("REGDAT")]
        public string REGDATStr
        {
            get
            {
                return this.REGDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.REGDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 摘要	Z(22)
        /// </summary>
        public string EVTNAM { get; set; }
        /// <summary>
        /// 业务类型	C(8)
        /// </summary>
        public string EVTCOD { get; set; }
        /// <summary>
        /// 我行业务号	C(16)
        /// </summary>
        public string TRSREF { get; set; }
        /// <summary>
        /// 子编号	C(16)
        /// </summary>
        public string SUBREF { get; set; }
        /// <summary>
        /// 相关编号	C(16)
        /// </summary>
        public string RELNBR { get; set; }
        /// <summary>
        /// 客户参考号	C(40)
        /// </summary>
        public string CLTREF { get; set; }
        /// <summary>
        /// 客户号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 客户中文名称	Z(200)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 客户中文地址	Z(105)
        /// </summary>
        public string CLTADR { get; set; }
        /// <summary>
        /// 客户英文名称	Z(200)
        /// </summary>
        public string CLTNAE { get; set; }
        /// <summary>
        /// 客户英文地址	Z(105)
        /// </summary>
        public string CLTADE { get; set; }
        /// <summary>
        /// 交易货币	C(3)
        /// </summary>
        public string TRXCCY { get; set; }
        /// <summary>
        /// 实际扣账金额	M
        /// </summary>
        public decimal ACTAMT { get; set; }
        /// <summary>
        /// 付汇金额	M
        /// </summary>
        public decimal ORTAMT { get; set; }
        /// <summary>
        /// 国外费用	M
        /// </summary>
        public decimal OVSFEE { get; set; }
        /// <summary>
        /// 起息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime VALDAT { get; set; }
        /// <summary>
        /// 起息日	D, 对应<see cref="VALDAT"/>
        /// </summary>
        [XmlElement("VALDAT")]
        public string VALDATStr
        {
            get
            {
                return this.VALDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.VALDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 户口	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(62)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 钞汇标志	C(1)
        /// </summary>
        public string CCYTYP { get; set; }
        /// <summary>
        /// 账户代码	C(5)
        /// </summary>
        public string ACTCOD { get; set; }
        /// <summary>
        /// 资金地区	C(5)
        /// </summary>
        public string ACTRGN { get; set; }
        /// <summary>
        /// 记帐套号	C(15)
        /// </summary>
        public string TRXSET { get; set; }
        /// <summary>
        /// 收款人名称	Z(100)
        /// </summary>
        public string BNFNAM { get; set; }
        /// <summary>
        /// 收款人帐号	C(35)
        /// </summary>
        public string BNFACC { get; set; }
        /// <summary>
        /// 收款行名址	Z(175)
        /// </summary>
        public string BFBKAD { get; set; }
        /// <summary>
        /// 复核用户名	Z(22)
        /// </summary>
        public string CHKUSR { get; set; }
        /// <summary>
        /// 产品编码	C(8)
        /// </summary>
        public string PRDCOD { get; set; }
        /// <summary>
        /// 特殊码100	C(100)
        /// </summary>
        public string SPL100 { get; set; }
        /// <summary>
        /// 备注	Z(300)
        /// </summary>
        public string REMARK { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    批量结息（离岸）
    /// </summary>
    public class ACINTCA2Z
    {
        /// <summary>
        /// 起息日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime VALDAT { get; set; }
        /// <summary>
        /// 起息日期	D, 对应<see cref="VALDAT"/>
        /// </summary>
        [XmlElement("VALDAT")]
        public string VALDATStr
        {
            get
            {
                return this.VALDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.VALDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime MUTDAT { get; set; }
        /// <summary>
        /// 到期日期	D, 对应<see cref="MUTDAT"/>
        /// </summary>
        [XmlElement("MUTDAT")]
        public string MUTDATStr
        {
            get
            {
                return this.MUTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.MUTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 计息积数	F(17,2)
        /// </summary>
        public decimal INTAUB { get; set; }
        /// <summary>
        /// 利率	F(11,7)
        /// </summary>
        public decimal INRVAL { get; set; }
        /// <summary>
        /// 利息	M
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 摘要	Z(22)
        /// </summary>
        public string INTTXT { get; set; }
        /// <summary>
        /// 回单实例号	C(13)
        /// </summary>
        public string PRTINS { get; set; }
        /// <summary>
        /// 利息税率	F(5,2)
        /// </summary>
        public decimal TAXRAT { get; set; }
        /// <summary>
        /// 利息税	M
        /// </summary>
        public decimal TAXAMT { get; set; }
        /// <summary>
        /// 保留	C(167)
        /// </summary>
        public string RVS200 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    批量结息（离岸）
    /// </summary>
    public class ACINTST2Z
    {
        /// <summary>
        /// 结息日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime INTDAT { get; set; }
        /// <summary>
        /// 结息日期	D, 对应<see cref="INTDAT"/>
        /// </summary>
        [XmlElement("INTDAT")]
        public string INTDATStr
        {
            get
            {
                return this.INTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 流水号	C(15)
        /// </summary>
        public string TRXSET { get; set; }
        /// <summary>
        /// 收款账号	C(35)
        /// </summary>
        public string INSEAC { get; set; }
        /// <summary>
        /// 户名	Z(62)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 货币	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 开户行	C(6)
        /// </summary>
        public string BRNNBR { get; set; }
        /// <summary>
        /// 利息	M
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 结息账户	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 结息方式	C(1)
        /// </summary>
        public string INTTYP { get; set; }
        /// <summary>
        /// 经办	C(6)
        /// </summary>
        public string TLRNBR { get; set; }
        /// <summary>
        /// 经办网点	C(6)
        /// </summary>
        public string TLRBRN { get; set; }
        /// <summary>
        /// 回单实例号	C(13)
        /// </summary>
        public string PRTINS { get; set; }
        /// <summary>
        /// 利息税率	F(5,2)
        /// </summary>
        public decimal TAXRAT { get; set; }
        /// <summary>
        /// 	利息税	M
        /// </summary>
        public decimal TAXAMT { get; set; }
        /// <summary>
        /// 保留	C(167)
        /// </summary>
        public string RVS200 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    网上自助结汇回单登记输出接口
    /// </summary>
    public class EXICORRBZ1
    {
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 回单编号	C(11)
        /// </summary>
        public string EVTNBR { get; set; }
        /// <summary>
        /// 登记日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime REGDAT { get; set; }
        /// <summary>
        /// 登记日期	D, 对应<see cref="REGDAT"/>
        /// </summary>
        [XmlElement("REGDAT")]
        public string REGDATStr
        {
            get
            {
                return this.REGDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.REGDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 业务类型	C(8)
        /// </summary>
        public string EVTCOD { get; set; }
        /// <summary>
        /// 产品号	C(10)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 客户名称	Z(62)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 合同号	C(20)
        /// </summary>
        public string CNTNBR { get; set; }
        /// <summary>
        /// 出款户口	C(35)
        /// </summary>
        public string OUTACC { get; set; }
        /// <summary>
        /// 卖出币种	C(2)
        /// </summary>
        public string OUTCCY { get; set; }
        /// <summary>
        /// 卖出金额	M
        /// </summary>
        public decimal OUTAMT { get; set; }
        /// <summary>
        /// 入款户口	C(35)
        /// </summary>
        public string RCVACC { get; set; }
        /// <summary>
        /// 买入币种	C(2)
        /// </summary>
        public string RCVCCY { get; set; }
        /// <summary>
        /// 买入金额	M
        /// </summary>
        public decimal RCVAMT { get; set; }
        /// <summary>
        /// 钞汇标志	C(1)
        /// </summary>
        public string CCYTYP { get; set; }
        /// <summary>
        /// 成交汇率	F(11,7)
        /// </summary>
        public decimal EXGRAT { get; set; }
        /// <summary>
        /// 市价汇率	F(11,7)
        /// </summary>
        public decimal BRNRAT { get; set; }
        /// <summary>
        /// 说明	Z(300)
        /// </summary>
        public string NARTXT { get; set; }
        /// <summary>
        /// 申报交易编码	C(6)
        /// </summary>
        public string TRSCOD { get; set; }
        /// <summary>
        /// 核准件号	Z(30)
        /// </summary>
        public string VRFNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string TRSREF { get; set; }
        /// <summary>
        /// 网银实例号	C(10)
        /// </summary>
        public string ICONBR { get; set; }
        /// <summary>
        /// 备注	C(100)
        /// </summary>
        public string SPL100 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    银承未用注销回单登记接口
    /// </summary>
    public class AMPRTBCKX1
    {
        /// <summary>
        /// 任务实例号	C(13)
        /// </summary>
        public string TSKNBR { get; set; }
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime TRSDTE { get; set; }
        /// <summary>
        /// 日期	D, 对应<see cref="TRSDTE"/>
        /// </summary>
        [XmlElement("TRSDTE")]
        public string TRSDTEStr
        {
            get
            {
                return this.TRSDTE.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDTE = tmp;
                }
            }
        }
        /// <summary>
        /// 信贷业务编号	C(10)
        /// </summary>
        public string BUSNUM { get; set; }
        /// <summary>
        /// 产品类别	C(8)
        /// </summary>
        public string BUSTYP { get; set; }
        /// <summary>
        /// 出票日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime DRWDTE { get; set; }
        /// <summary>
        /// 出票日期	D, 对应<see cref="DRWDTE"/>
        /// </summary>
        [XmlElement("DRWDTE")]
        public string DRWDTEStr
        {
            get
            {
                return this.DRWDTE.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DRWDTE = tmp;
                }
            }
        }
        /// <summary>
        /// 汇票到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDTE { get; set; }
        /// <summary>
        /// 汇票到期日	D, 对应<see cref="ENDDTE"/>
        /// </summary>
        [XmlElement("ENDDTE")]
        public string ENDDTEStr
        {
            get
            {
                return this.ENDDTE.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDTE = tmp;
                }
            }
        }
        /// <summary>
        /// 出票人全称	Z(200)
        /// </summary>
        public string BILNAM { get; set; }
        /// <summary>
        /// 出票人账号	C(35)
        /// </summary>
        public string BILACC { get; set; }
        /// <summary>
        /// 付款行全称	Z(62)
        /// </summary>
        public string BRNNAM { get; set; }
        /// <summary>
        /// 收款人全称	Z(100)
        /// </summary>
        public string ECLNAM { get; set; }
        /// <summary>
        /// 收款人开户行	Z(62)
        /// </summary>
        public string EBKNAM { get; set; }
        /// <summary>
        /// 收款人账号	C(35)
        /// </summary>
        public string EBKACC { get; set; }
        /// <summary>
        /// 票据号码	C(30)
        /// </summary>
        public string BILNUM { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CRYNUM { get; set; }
        /// <summary>
        /// 出票金额	F(17,2)
        /// </summary>
        public decimal BILAMT { get; set; }
        /// <summary>
        /// 承兑协议编号	Z(80)
        /// </summary>
        public string CONNAM { get; set; }
        /// <summary>
        /// 备注	Z(80)
        /// </summary>
        public string TRSNTE { get; set; }
        /// <summary>
        /// 经办	C(6)
        /// </summary>
        public string ENTUID { get; set; }
        /// <summary>
        /// 复核	C(6)
        /// </summary>
        public string CFMUID { get; set; }
        /// <summary>
        /// 经办时间	T
        /// </summary>
        public string ENTTIM { get; set; }
        /// <summary>
        /// 复核时间	T
        /// </summary>
        public string CFMTIM { get; set; }
        /// <summary>
        /// 预留字段	C(200)
        /// </summary>
        public string RSVFLG { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    手续费回单登记接口
    /// </summary>
    public class AMPRTFEEX1
    {
        /// <summary>
        /// 任务实例号	C(13)
        /// </summary>
        public string TSKNBR { get; set; }
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime TRSDTE { get; set; }
        /// <summary>
        /// 日期	D, 对应<see cref="TRSDTE"/>
        /// </summary>
        [XmlElement("TRSDTE")]
        public string TRSDTEStr
        {
            get
            {
                return this.TRSDTE.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDTE = tmp;
                }
            }
        }
        /// <summary>
        /// 信贷业务编号	C(10)
        /// </summary>
        public string BUSNUM { get; set; }
        /// <summary>
        /// 产品类别	C(8)
        /// </summary>
        public string BUSTYP { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNUM { get; set; }
        /// <summary>
        /// 户名	Z(100)
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 开户行	C(6)
        /// </summary>
        public string BRNNUM { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CRYNUM { get; set; }
        /// <summary>
        /// 扣收金额	F(17,2)
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 备注	Z(80)
        /// </summary>
        public string TRSNTE { get; set; }
        /// <summary>
        /// 经办	C(6)
        /// </summary>
        public string ENTUID { get; set; }
        /// <summary>
        /// 复核	C(6)
        /// </summary>
        public string CFMUID { get; set; }
        /// <summary>
        /// 经办时间	T
        /// </summary>
        public string ENTTIM { get; set; }
        /// <summary>
        /// 复核时间	T
        /// </summary>
        public string CFMTIM { get; set; }
        /// <summary>
        /// 借贷码	C(1)
        /// </summary>
        public string AMTCOD { get; set; }
        /// <summary>
        /// 冲补帐标识	C(1)
        /// </summary>
        public string RVSSBL { get; set; }
        /// <summary>
        /// 客户号	C(10)
        /// </summary>
        public string CLTCOD { get; set; }
        /// <summary>
        /// 预留字段	C(200)
        /// </summary>
        public string RSVFLG { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    批量结息回单登记接口
    /// </summary>
    public class AMPRTINBX1
    {
        /// <summary>
        /// 任务实例号	C(13)
        /// </summary>
        public string TSKNBR { get; set; }
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime TRSDTE { get; set; }
        /// <summary>
        /// 日期	D, 对应<see cref="TRSDTE"/>
        /// </summary>
        [XmlElement("TRSDTE")]
        public string TRSDTEStr
        {
            get
            {
                return this.TRSDTE.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDTE = tmp;
                }
            }
        }
        /// <summary>
        /// 信贷业务编号	C(10)
        /// </summary>
        public string BUSNUM { get; set; }
        /// <summary>
        /// 产品类别	C(8)
        /// </summary>
        public string BUSTYP { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNUM { get; set; }
        /// <summary>
        /// 户名	Z(100)
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 开户行	C(6)
        /// </summary>
        public string BRNNUM { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CRYNUM { get; set; }
        /// <summary>
        /// 应计利息	F(17,2)
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 实扣利息	F(17,2)
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 利息起息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime INTDTV { get; set; }
        /// <summary>
        /// 利息起息日	D, 对应<see cref="INTDTV"/>
        /// </summary>
        [XmlElement("INTDTV")]
        public string INTDTVStr
        {
            get
            {
                return this.INTDTV.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTDTV = tmp;
                }
            }
        }
        /// <summary>
        /// 利息止息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime INTDTM { get; set; }
        /// <summary>
        /// 利息止息日	D, 对应<see cref="INTDTM"/>
        /// </summary>
        [XmlElement("INTDTM")]
        public string INTDTMStr
        {
            get
            {
                return this.INTDTM.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTDTM = tmp;
                }
            }
        }
        /// <summary>
        /// 利率	F(11,7)
        /// </summary>
        public decimal RATRAT { get; set; }
        /// <summary>
        /// 利息本金	F(17,2)
        /// </summary>
        public decimal INTCPT { get; set; }
        /// <summary>
        /// 备注	Z(80)
        /// </summary>
        public string TRSNTE { get; set; }
        /// <summary>
        /// 经办	C(6)
        /// </summary>
        public string ENTUID { get; set; }
        /// <summary>
        /// 复核	C(6)
        /// </summary>
        public string CFMUID { get; set; }
        /// <summary>
        /// 经办时间	T
        /// </summary>
        public string ENTTIM { get; set; }
        /// <summary>
        /// 复核时间	T
        /// </summary>
        public string CFMTIM { get; set; }
        /// <summary>
        /// 借贷码	C(1)
        /// </summary>
        public string AMTCOD { get; set; }
        /// <summary>
        /// 冲补帐标识	C(1)
        /// </summary>
        public string RVSSBL { get; set; }
        /// <summary>
        /// 客户号	C(10)
        /// </summary>
        public string CLTCOD { get; set; }
        /// <summary>
        /// 预留字段	C(200)
        /// </summary>
        public string RSVFLG { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    其它结息回单登记接口
    /// </summary>
    public class AMPRTINTX1 : AMPRTINBX1
    {
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    还款回单登记接口
    /// </summary>
    public class AMPRTPADX1
    {
        /// <summary>
        /// 任务实例号	C(13)
        /// </summary>
        public string TSKNBR { get; set; }
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime TRSDTE { get; set; }
        /// <summary>
        /// 日期	D, 对应<see cref="TRSDTE"/>
        /// </summary>
        [XmlElement("TRSDTE")]
        public string TRSDTEStr
        {
            get
            {
                return this.TRSDTE.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDTE = tmp;
                }
            }
        }
        /// <summary>
        /// 信贷业务编号	C(10)
        /// </summary>
        public string BUSNUM { get; set; }
        /// <summary>
        /// 产品类别	C(8)
        /// </summary>
        public string BUSTYP { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNUM { get; set; }
        /// <summary>
        /// 户名	Z(100)
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 开户行	C(6)
        /// </summary>
        public string BRNNUM { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CRYNUM { get; set; }
        /// <summary>
        /// 金额	F(17,2)
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 备注	Z(80)
        /// </summary>
        public string TRSNTE { get; set; }
        /// <summary>
        /// 经办	C(6)
        /// </summary>
        public string ENTUID { get; set; }
        /// <summary>
        /// 复核	C(6)
        /// </summary>
        public string CFMUID { get; set; }
        /// <summary>
        /// 经办时间	T
        /// </summary>
        public string ENTTIM { get; set; }
        /// <summary>
        /// 复核时间	T
        /// </summary>
        public string CFMTIM { get; set; }
        /// <summary>
        /// 借贷码	C(1)
        /// </summary>
        public string AMTCOD { get; set; }
        /// <summary>
        /// 冲补帐标识	C(1)
        /// </summary>
        public string RVSSBL { get; set; }
        /// <summary>
        /// 客户号	C(10)
        /// </summary>
        public string CLTCOD { get; set; }
        /// <summary>
        /// 预留字段	C(200)
        /// </summary>
        public string RSVFLG { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    放款回单登记接口
    /// </summary>
    public class AMPRTUSDX1 : AMPRTPADX1
    {
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    冲账回单登记接口
    /// </summary>
    public class AMPRTRVSX1
    {
        /// <summary>
        /// 任务实例号	C(13)
        /// </summary>
        public string TSKNBR { get; set; }
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime TRSDTE { get; set; }
        /// <summary>
        /// 日期	D, 对应<see cref="TRSDTE"/>
        /// </summary>
        [XmlElement("TRSDTE")]
        public string TRSDTEStr
        {
            get
            {
                return this.TRSDTE.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDTE = tmp;
                }
            }
        }
        /// <summary>
        /// 信贷业务编号	C(10)
        /// </summary>
        public string BUSNUM { get; set; }
        /// <summary>
        /// 产品类别	C(8)
        /// </summary>
        public string BUSTYP { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNUM { get; set; }
        /// <summary>
        /// 户名	Z(100)
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 开户行	C(6)
        /// </summary>
        public string BRNNUM { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CRYNUM { get; set; }
        /// <summary>
        /// 金额	F(17,2)
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 原交易日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime OLDDTE { get; set; }
        /// <summary>
        /// 原交易日期	D, 对应<see cref="OLDDTE"/>
        /// </summary>
        [XmlElement("OLDDTE")]
        public string OLDDTEStr
        {
            get
            {
                return this.OLDDTE.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OLDDTE = tmp;
                }
            }
        }
        /// <summary>
        /// 备注	Z(80)
        /// </summary>
        public string TRSNTE { get; set; }
        /// <summary>
        /// 经办	C(6)
        /// </summary>
        public string ENTUID { get; set; }
        /// <summary>
        /// 复核	C(6)
        /// </summary>
        public string CFMUID { get; set; }
        /// <summary>
        /// 经办时间	T
        /// </summary>
        public string ENTTIM { get; set; }
        /// <summary>
        /// 复核时间	T
        /// </summary>
        public string CFMTIM { get; set; }
        /// <summary>
        /// 借贷码	C(1)
        /// </summary>
        public string AMTCOD { get; set; }
        /// <summary>
        /// 冲补帐标识	C(1)
        /// </summary>
        public string RVSSBL { get; set; }
        /// <summary>
        /// 客户号	C(10)
        /// </summary>
        public string CLTCOD { get; set; }
        /// <summary>
        /// 预留字段	C(200)
        /// </summary>
        public string RSVFLG { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    打印结构性存款存入收款回单
    /// </summary>
    public class SADPSVHBZ
    {
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 打印日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime PRTDAT { get; set; }
        /// <summary>
        /// 打印日期	D, 对应<see cref="PRTDAT"/>
        /// </summary>
        [XmlElement("PRTDAT")]
        public string PRTDATStr
        {
            get
            {
                return this.PRTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PRTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 任务编码	C(8)
        /// </summary>
        public string TSKCOD { get; set; }
        /// <summary>
        /// 交易流水	C(13)
        /// </summary>
        public string TSKNBR { get; set; }
        /// <summary>
        /// 开户机构	C(6)
        /// </summary>
        public string OPNBRN { get; set; }
        /// <summary>
        /// 开户分行	C(6)
        /// </summary>
        public string OPNBBK { get; set; }
        /// <summary>
        /// 开户城市	C(6)
        /// </summary>
        public string OPNCTY { get; set; }
        /// <summary>
        /// 交易机构	C(6)
        /// </summary>
        public string TRXBRN { get; set; }
        /// <summary>
        /// 交易分行	C(6)
        /// </summary>
        public string TRXBBK { get; set; }
        /// <summary>
        /// 交易城市	C(6)
        /// </summary>
        public string TRXCTY { get; set; }
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
        /// 经办	C(6)
        /// </summary>
        public string OPRUSR { get; set; }
        /// <summary>
        /// 复核	C(6)
        /// </summary>
        public string CHKUSR { get; set; }
        /// <summary>
        /// 授权	C(6)
        /// </summary>
        public string AUTUSR { get; set; }
        /// <summary>
        /// 凭证种类	C(4)
        /// </summary>
        public string PSBCOD { get; set; }
        /// <summary>
        /// 凭证号码	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 户口号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(62)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 产品代码	C(8)
        /// </summary>
        public string PRDCOD { get; set; }
        /// <summary>
        /// 存期	C(6)
        /// </summary>
        public string TERDUR { get; set; }
        /// <summary>
        /// 货币	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 钞汇标志	C(1)
        /// </summary>
        public string CCYTYP { get; set; }
        /// <summary>
        /// 金额	M
        /// </summary>
        public decimal OPNAMT { get; set; }
        /// <summary>
        /// 联机余额	M
        /// </summary>
        public decimal ONLBAL { get; set; }
        /// <summary>
        /// 起息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime INTDAT { get; set; }
        /// <summary>
        /// 起息日	D, 对应<see cref="INTDAT"/>
        /// </summary>
        [XmlElement("INTDAT")]
        public string INTDATStr
        {
            get
            {
                return this.INTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 到期日	D, 对应<see cref="EXPDAT"/>
        /// </summary>
        [XmlElement("EXPDAT")]
        public string EXPDATStr
        {
            get
            {
                return this.EXPDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EXPDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 止息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime EINDAT { get; set; }
        /// <summary>
        /// 止息日	D, 对应<see cref="EINDAT"/>
        /// </summary>
        [XmlElement("EINDAT")]
        public string EINDATStr
        {
            get
            {
                return this.EINDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EINDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 最高利率	F(11,7)
        /// </summary>
        public decimal MTUMST { get; set; }
        /// <summary>
        /// 预期成本率	F(11,7)
        /// </summary>
        public decimal MTUPRE { get; set; }
        /// <summary>
        /// 保底利率	F(11,7)
        /// </summary>
        public decimal MTULST { get; set; }
        /// <summary>
        /// 支取金额	M
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 金额１	M
        /// </summary>
        public decimal EXTAM1 { get; set; }
        /// <summary>
        /// 金额２	M
        /// </summary>
        public decimal EXTAM2 { get; set; }
        /// <summary>
        /// 金额３	M
        /// </summary>
        public decimal EXTAM3 { get; set; }
        /// <summary>
        /// 描述１	C(20)
        /// </summary>
        public string EXTTX1 { get; set; }
        /// <summary>
        /// 描述２	C(20)
        /// </summary>
        public string EXTTX2 { get; set; }
        /// <summary>
        /// 描述３	C(20)
        /// </summary>
        public string EXTTX3 { get; set; }
        /// <summary>
        /// 摘要１	C(40)
        /// </summary>
        public string RMKLN1 { get; set; }
        /// <summary>
        /// 摘要２	C(40)
        /// </summary>
        public string RMKLN2 { get; set; }
        /// <summary>
        /// 摘要３	C(80)
        /// </summary>
        public string RMKLN3 { get; set; }
        /// <summary>
        /// 特殊码	C(80)
        /// </summary>
        public string SPLC80 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    打印结构性存款存入收款回单
    /// </summary>
    public class SADPSVHBZ0
    {
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 客户名	Z(62)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 收款单号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 钞汇户	C(1)
        /// </summary>
        public string CCYTYP { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 金额１	M
        /// </summary>
        public decimal EXTAM1 { get; set; }
        /// <summary>
        /// 金额２	M
        /// </summary>
        public decimal EXTAM2 { get; set; }
        /// <summary>
        /// 描述１	C(20)
        /// </summary>
        public string EXTTX1 { get; set; }
        /// <summary>
        /// 描述２	C(20)
        /// </summary>
        public string EXTTX2 { get; set; }
        /// <summary>
        /// 特殊码	C(80)
        /// </summary>
        public string SPLC80 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    打印活期付款回单输出接口
    /// </summary>
    public class SAFNDRPBZ
    {
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 打印日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime PRTDAT { get; set; }
        /// <summary>
        /// 打印日期	D, 对应<see cref="PRTDAT"/>
        /// </summary>
        [XmlElement("PRTDAT")]
        public string PRTDATStr
        {
            get
            {
                return this.PRTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PRTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 开户机构	C(6)
        /// </summary>
        public string OPNBRN { get; set; }
        /// <summary>
        /// 交易流水	C(13)
        /// </summary>
        public string TSKNBR { get; set; }
        /// <summary>
        /// 户口号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 开户机构	C(6)
        /// </summary>
        public string EACBRN { get; set; }
        /// <summary>
        /// 户口名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 产品代码	C(8)
        /// </summary>
        public string PRDCOD { get; set; }
        /// <summary>
        /// 存期	C(6)
        /// </summary>
        public string TERDUR { get; set; }
        /// <summary>
        /// 货币	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 钞汇标志	C(1)
        /// </summary>
        public string CCYTYP { get; set; }
        /// <summary>
        /// 开户日	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPNDAT { get; set; }
        /// <summary>
        /// 开户日	D, 对应<see cref="OPNDAT"/>
        /// </summary>
        [XmlElement("OPNDAT")]
        public string OPNDATStr
        {
            get
            {
                return this.OPNDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 起息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime INTDAT { get; set; }
        /// <summary>
        /// 起息日	D, 对应<see cref="INTDAT"/>
        /// </summary>
        [XmlElement("INTDAT")]
        public string INTDATStr
        {
            get
            {
                return this.INTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 到期日	D, 对应<see cref="EXPDAT"/>
        /// </summary>
        [XmlElement("EXPDAT")]
        public string EXPDATStr
        {
            get
            {
                return this.EXPDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EXPDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 止息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime EINDAT { get; set; }
        /// <summary>
        /// 止息日	D, 对应<see cref="EINDAT"/>
        /// </summary>
        [XmlElement("EINDAT")]
        public string EINDATStr
        {
            get
            {
                return this.EINDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EINDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 帐户余额	M
        /// </summary>
        public decimal ACTBAL { get; set; }
        /// <summary>
        /// 最高利率	F(11,7)
        /// </summary>
        public decimal MTUMST { get; set; }
        /// <summary>
        /// 预期成本率	F(11,7)
        /// </summary>
        public decimal MTUPRE { get; set; }
        /// <summary>
        /// 保底利率	F(11,7)	
        /// </summary>
        public decimal MTULST { get; set; }
        /// <summary>
        /// 交易机构	C(6)
        /// </summary>
        public string TRXBRN { get; set; }
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
        /// 经办	C(6)
        /// </summary>
        public string OPRUSR { get; set; }
        /// <summary>
        /// 复核	C(6)
        /// </summary>
        public string CHKUSR { get; set; }
        /// <summary>
        /// 授权	C(6)
        /// </summary>
        public string AUTUSR { get; set; }
        /// <summary>
        /// 付款类型1	C(1)
        /// </summary>
        public string TRXTY1 { get; set; }
        /// <summary>
        /// 开户机构	C(6)
        /// </summary>
        public string TRXBR1 { get; set; }
        /// <summary>
        /// 客户名1	Z(62)
        /// </summary>
        public string TRXNM1 { get; set; }
        /// <summary>
        /// 付款单号1	C(35)
        /// </summary>
        public string TRXBL1 { get; set; }
        /// <summary>
        /// 交易金额1	M
        /// </summary>
        public decimal TRXAM1 { get; set; }
        /// <summary>
        /// 金额１	M
        /// </summary>
        public decimal EXTAM1 { get; set; }
        /// <summary>
        /// 金额２	M
        /// </summary>
        public decimal EXTAM2 { get; set; }
        /// <summary>
        /// 金额３	M
        /// </summary>
        public decimal EXTAM3 { get; set; }
        /// <summary>
        /// 描述１	C(20)
        /// </summary>
        public string EXTTX1 { get; set; }
        /// <summary>
        /// 描述２	C(20)
        /// </summary>
        public string EXTTX2 { get; set; }
        /// <summary>
        /// 描述３	C(20)
        /// </summary>
        public string EXTTX3 { get; set; }
        /// <summary>
        /// 摘要１	C(40)
        /// </summary>
        public string RMKLN1 { get; set; }
        /// <summary>
        /// 摘要２	C(40)
        /// </summary>
        public string RMKLN2 { get; set; }
        /// <summary>
        /// 摘要３	C(80)
        /// </summary>
        public string RMKLN3 { get; set; }
        /// <summary>
        /// 特殊码	C(80)
        /// </summary>
        public string SPLC80 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    打印结构性存款支取付款回单
    /// </summary>
    public class SADRWVHBZ
    {
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 打印日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime PRTDAT { get; set; }
        /// <summary>
        /// 打印日期	D, 对应<see cref="PRTDAT"/>
        /// </summary>
        [XmlElement("PRTDAT")]
        public string PRTDATStr
        {
            get
            {
                return this.PRTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PRTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 任务编码	C(8)
        /// </summary>
        public string TSKCOD { get; set; }
        /// <summary>
        /// 交易流水	C(13)
        /// </summary>
        public string TSKNBR { get; set; }
        /// <summary>
        /// 开户机构	C(6)
        /// </summary>
        public string OPNBRN { get; set; }
        /// <summary>
        /// 开户分行	C(6)
        /// </summary>
        public string OPNBBK { get; set; }
        /// <summary>
        /// 开户城市	C(6)
        /// </summary>
        public string OPNCTY { get; set; }
        /// <summary>
        /// 交易机构	C(6)
        /// </summary>
        public string TRXBRN { get; set; }
        /// <summary>
        /// 交易分行	C(6)
        /// </summary>
        public string TRXBBK { get; set; }
        /// <summary>
        /// 交易城市	C(6)
        /// </summary>
        public string TRXCTY { get; set; }
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
        /// 经办	C(6)
        /// </summary>
        public string OPRUSR { get; set; }
        /// <summary>
        /// 复核	C(6)
        /// </summary>
        public string CHKUSR { get; set; }
        /// <summary>
        /// 授权	C(6)
        /// </summary>
        public string AUTUSR { get; set; }
        /// <summary>
        /// 户口号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 证件类别	C(3)
        /// </summary>
        public string CTFTYP { get; set; }
        /// <summary>
        /// 证件号码	Z(30)
        /// </summary>
        public string CTFIDC { get; set; }
        /// <summary>
        /// 产品编码	C(8)
        /// </summary>
        public string PRDCOD { get; set; }
        /// <summary>
        /// 存期	C(6)
        /// </summary>
        public string TERDUR { get; set; }
        /// <summary>
        /// 钞汇标志	C(1)
        /// </summary>
        public string CCYTYP { get; set; }
        /// <summary>
        /// 货币号	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 金额	M
        /// </summary>
        public decimal OPNAMT { get; set; }
        /// <summary>
        /// 联机余额	M
        /// </summary>
        public decimal ONLBAL { get; set; }
        /// <summary>
        /// 开户日	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPNDAT { get; set; }
        /// <summary>
        /// 开户日	D, 对应<see cref="OPNDAT"/>
        /// </summary>
        [XmlElement("OPNDAT")]
        public string OPNDATStr
        {
            get
            {
                return this.OPNDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 关户日	D
        /// </summary>
        [XmlIgnore]
        public DateTime CLSDAT { get; set; }
        /// <summary>
        /// 关户日	D, 对应<see cref="CLSDAT"/>
        /// </summary>
        [XmlElement("CLSDAT")]
        public string CLSDATStr
        {
            get
            {
                return this.CLSDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CLSDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 起息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime INTDAT { get; set; }
        /// <summary>
        /// 起息日	D, 对应<see cref="INTDAT"/>
        /// </summary>
        [XmlElement("INTDAT")]
        public string INTDATStr
        {
            get
            {
                return this.INTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 到期日	D, 对应<see cref="EXPDAT"/>
        /// </summary>
        [XmlElement("EXPDAT")]
        public string EXPDATStr
        {
            get
            {
                return this.EXPDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EXPDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 止息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime EINDAT { get; set; }
        /// <summary>
        /// 止息日	D, 对应<see cref="EINDAT"/>
        /// </summary>
        [XmlElement("EINDAT")]
        public string EINDATStr
        {
            get
            {
                return this.EINDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EINDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 最高利率	F(11,7)
        /// </summary>
        public decimal MTUMST { get; set; }
        /// <summary>
        /// 预期成本率	F(11,7)
        /// </summary>
        public decimal MTUPRE { get; set; }
        /// <summary>
        /// 保底利率	F(11,7)
        /// </summary>
        public decimal MTULST { get; set; }
        /// <summary>
        /// 支取标记	C(1)
        /// </summary>
        public string WDPFLG { get; set; }
        /// <summary>
        /// 支取金额	M
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 利息金额	M
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 利息税金额	M
        /// </summary>
        public decimal TAXAMT { get; set; }
        /// <summary>
        /// 计费货币号	C(2)
        /// </summary>
        public string FEECCY { get; set; }
        /// <summary>
        /// 应收费用金额	M
        /// </summary>
        public decimal FEEAMT { get; set; }
        /// <summary>
        /// 凭证种类	C(4)
        /// </summary>
        public string PSBCOD { get; set; }
        /// <summary>
        /// 凭证号码	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 金额１	M
        /// </summary>
        public decimal EXTAM1 { get; set; }
        /// <summary>
        /// 金额２	M
        /// </summary>
        public decimal EXTAM2 { get; set; }
        /// <summary>
        /// 金额３	M
        /// </summary>
        public decimal EXTAM3 { get; set; }
        /// <summary>
        /// 描述１	C(20)
        /// </summary>
        public string EXTTX1 { get; set; }
        /// <summary>
        /// 描述２	C(20)
        /// </summary>
        public string EXTTX2 { get; set; }
        /// <summary>
        /// 描述３	C(20)
        /// </summary>
        public string EXTTX3 { get; set; }
        /// <summary>
        /// 摘要１	C(40)
        /// </summary>
        public string RMKLN1 { get; set; }
        /// <summary>
        /// 摘要２	C(40)
        /// </summary>
        public string RMKLN2 { get; set; }
        /// <summary>
        /// 摘要３	C(80)
        /// </summary>
        public string RMKLN3 { get; set; }
        /// <summary>
        /// 特殊码	C(80)
        /// </summary>
        public string SPLC80 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    打印结构性存款支取付款回单
    /// </summary>
    public class SADRWVHBZ0 : SADPSVHBZ0
    {
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    打印活期收款回单输出接口
    /// </summary>
    public class SAFNDRRBZ
    {
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 打印日期	D
        /// </summary>
        public string PRTDAT { get; set; }
        /// <summary>
        /// 打印时间	T
        /// </summary>
        public string PRTTIM { get; set; }
        /// <summary>
        /// 打印时间 由<see cref="PRTDAT"/>和<see cref="PRTTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime PrintTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.PRTDAT, this.PRTTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return DateTime.MinValue;
            }
        }
        /// <summary>
        /// 交易流水	C(13)
        /// </summary>
        public string TSKNBR { get; set; }
        /// <summary>
        /// 任务编码	C(8)
        /// </summary>
        public string TSKCOD { get; set; }
        /// <summary>
        /// 开户机构	C(6)
        /// </summary>
        public string EACBRN { get; set; }
        /// <summary>
        /// 户口号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 产品代码	C(8)
        /// </summary>
        public string PRDCOD { get; set; }
        /// <summary>
        /// 存期	C(6)
        /// </summary>
        public string TERDUR { get; set; }
        /// <summary>
        /// 货币	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 钞汇标志	C(1)
        /// </summary>
        public string CCYTYP { get; set; }
        /// <summary>
        /// 起息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime INTDAT { get; set; }
        /// <summary>
        /// 起息日	D, 对应<see cref="INTDAT"/>
        /// </summary>
        [XmlElement("INTDAT")]
        public string INTDATStr
        {
            get
            {
                return this.INTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 到期日	D, 对应<see cref="EXPDAT"/>
        /// </summary>
        [XmlElement("EXPDAT")]
        public string EXPDATStr
        {
            get
            {
                return this.EXPDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EXPDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 止息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime EINDAT { get; set; }
        /// <summary>
        /// 止息日	D, 对应<see cref="EINDAT"/>
        /// </summary>
        [XmlElement("EINDAT")]
        public string EINDATStr
        {
            get
            {
                return this.EINDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EINDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 帐户余额	M
        /// </summary>
        public decimal ACTBAL { get; set; }
        /// <summary>
        /// 支取标记	C(1)
        /// </summary>
        public string WDPFLG { get; set; }
        /// <summary>
        /// 支取金额	M
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 利息金额	M
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 利息税金额	M
        /// </summary>
        public decimal TAXAMT { get; set; }
        /// <summary>
        /// 计费货币号	C(2)
        /// </summary>
        public string FEECCY { get; set; }
        /// <summary>
        /// 应收费用金额	M
        /// </summary>
        public decimal FEEAMT { get; set; }
        /// <summary>
        /// 交易机构	C(6)
        /// </summary>
        public string TRXBRN { get; set; }
        /// <summary>
        /// 交易日期	D
        /// </summary>
        public string TRXDAT { get; set; }
        /// <summary>
        /// 交易时间	T
        /// </summary>
        public string TRXTIM { get; set; }
        /// <summary>
        /// 交易时间 由<see cref="TRXDAT"/>和<see cref="TRXTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime TransactionTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.TRXDAT, this.TRXTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return DateTime.MinValue;
            }
        }
        /// <summary>
        /// 经办	C(6)
        /// </summary>
        public string OPRUSR { get; set; }
        /// <summary>
        /// 复核	C(6)
        /// </summary>
        public string CHKUSR { get; set; }
        /// <summary>
        /// 授权	C(6)
        /// </summary>
        public string AUTUSR { get; set; }
        /// <summary>
        /// 凭证种类	C(4)
        /// </summary>
        public string PSBCOD { get; set; }
        /// <summary>
        /// 凭证号码	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 收款类型	C(1)
        /// </summary>
        public string TRXTY1 { get; set; }
        /// <summary>
        /// 收款户名	Z(62)
        /// </summary>
        public string TRXNM1 { get; set; }
        /// <summary>
        /// 收款单号	C(35)
        /// </summary>
        public string TRXBL1 { get; set; }
        /// <summary>
        /// 收款金额	M
        /// </summary>
        public decimal TRXAM1 { get; set; }
        /// <summary>
        /// 收款机构	C(6)
        /// </summary>
        public string TRXBR1 { get; set; }
        /// <summary>
        /// 金额１	M
        /// </summary>
        public decimal EXTAM1 { get; set; }
        /// <summary>
        /// 金额２	M
        /// </summary>
        public decimal EXTAM2 { get; set; }
        /// <summary>
        /// 金额３	M
        /// </summary>
        public decimal EXTAM3 { get; set; }
        /// <summary>
        /// 描述１	C(20)
        /// </summary>
        public string EXTTX1 { get; set; }
        /// <summary>
        /// 描述２	C(20)
        /// </summary>
        public string EXTTX2 { get; set; }
        /// <summary>
        /// 描述３	C(20)
        /// </summary>
        public string EXTTX3 { get; set; }
        /// <summary>
        /// 摘要１	C(40)
        /// </summary>
        public string RMKLN1 { get; set; }
        /// <summary>
        /// 摘要２	C(40)
        /// </summary>
        public string RMKLN2 { get; set; }
        /// <summary>
        /// 摘要３	C(80)
        /// </summary>
        public string RMKLN3 { get; set; }
        /// <summary>
        /// 特殊码	C(80)
        /// </summary>
        public string SPLC80 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    利息单明细打印输出接口
    /// </summary>
    public class SAINTLSBZ
    {
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 打印日期	D
        /// </summary>
        public string PRTDAT { get; set; }
        /// <summary>
        /// 打印时间	T
        /// </summary>
        public string PRTTIM { get; set; }
        /// <summary>
        /// 打印时间 由<see cref="PRTDAT"/>和<see cref="PRTTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime PrintTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.PRTDAT, this.PRTTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return DateTime.MinValue;
            }
        }
        /// <summary>
        /// 任务实例号	C(13)
        /// </summary>
        public string TSKNBR { get; set; }
        /// <summary>
        /// 任务编码	C(8)
        /// </summary>
        public string TSKCOD { get; set; }
        /// <summary>
        /// 开户机构	C(6)
        /// </summary>
        public string EACBRN { get; set; }
        /// <summary>
        /// 户口号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 产品代码	C(8)
        /// </summary>
        public string PRDCOD { get; set; }
        /// <summary>
        /// 货币	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 存期	C(6)
        /// </summary>
        public string TERDUR { get; set; }
        /// <summary>
        /// 历次扣税	M
        /// </summary>
        public decimal HISTAX { get; set; }
        /// <summary>
        /// 本次扣税	M
        /// </summary>
        public decimal CURTAX { get; set; }
        /// <summary>
        /// 总计税金	M
        /// </summary>
        public decimal ALLTAX { get; set; }
        /// <summary>
        /// 本金	M
        /// </summary>
        public decimal DRWAMT { get; set; }
        /// <summary>
        /// 税后利息	M
        /// </summary>
        public decimal TXDINT { get; set; }
        /// <summary>
        /// 税后本息合计	M
        /// </summary>
        public decimal TXDBAL { get; set; }
        /// <summary>
        /// 支取标志	C(1)
        /// </summary>
        public string WDPFLG { get; set; }
        /// <summary>
        /// 摘要	C(80)
        /// </summary>
        public string RMKLIN { get; set; }
        /// <summary>
        /// 交易机构	C(6)
        /// </summary>
        public string TRXBRN { get; set; }
        /// <summary>
        /// 交易日期	D
        /// </summary>
        public string TRXDAT { get; set; }
        /// <summary>
        /// 交易时间	T
        /// </summary>
        public string TRXTIM { get; set; }
        /// <summary>
        /// 交易时间 由<see cref="TRXDAT"/>和<see cref="TRXTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime TransactionTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.TRXDAT, this.TRXTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return DateTime.MinValue;
            }
        }
        /// <summary>
        /// 经办	C(6)
        /// </summary>
        public string OPRUSR { get; set; }
        /// <summary>
        /// 复核	C(6)
        /// </summary>
        public string CHKUSR { get; set; }
        /// <summary>
        /// 授权	C(6)
        /// </summary>
        public string AUTUSR { get; set; }
        /// <summary>
        /// 金额１	M
        /// </summary>
        public decimal EXTAM1 { get; set; }
        /// <summary>
        /// 金额２	M
        /// </summary>
        public decimal EXTAM2 { get; set; }
        /// <summary>
        /// 金额３	M
        /// </summary>
        public decimal EXTAM3 { get; set; }
        /// <summary>
        /// 描述１	C(20)
        /// </summary>
        public string EXTTX1 { get; set; }
        /// <summary>
        /// 描述２	C(20)
        /// </summary>
        public string EXTTX2 { get; set; }
        /// <summary>
        /// 描述３	C(20)
        /// </summary>
        public string EXTTX3 { get; set; }
        /// <summary>
        /// 摘要１	C(40)
        /// </summary>
        public string RMKLN1 { get; set; }
        /// <summary>
        /// 摘要２	C(40)
        /// </summary>
        public string RMKLN2 { get; set; }
        /// <summary>
        /// 摘要３	C(80)
        /// </summary>
        public string RMKLN3 { get; set; }
        /// <summary>
        /// 特殊码	C(80)
        /// </summary>
        public string SPLC80 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    利息单明细打印输出接口
    /// </summary>
    public class SAINTLSBZ0
    {
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 货币号	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 钞汇户	C(1)
        /// </summary>
        public string CCYTYP { get; set; }
        /// <summary>
        /// 起息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime INTDAT { get; set; }
        /// <summary>
        /// 起息日	D, 对应<see cref="INTDAT"/>
        /// </summary>
        [XmlElement("INTDAT")]
        public string INTDATStr
        {
            get
            {
                return this.INTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 止息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime EINDAT { get; set; }
        /// <summary>
        /// 止息日	D, 对应<see cref="EINDAT"/>
        /// </summary>
        [XmlElement("EINDAT")]
        public string EINDATStr
        {
            get
            {
                return this.EINDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EINDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 计息本金	M
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 利率	F(11,7)
        /// </summary>
        public decimal INTRAT { get; set; }
        /// <summary>
        /// 利息金额	M
        /// </summary>
        public decimal INTRST { get; set; }
        /// <summary>
        /// 应税利息	M
        /// </summary>
        public decimal ITXINT { get; set; }
        /// <summary>
        /// 税率	F(5,2)
        /// </summary>
        public decimal TAXRAT { get; set; }
        /// <summary>
        /// 利息税金额	M
        /// </summary>
        public decimal ITXAMT { get; set; }
        /// <summary>
        /// 税后利息	M
        /// </summary>
        public decimal TXDINT { get; set; }
        /// <summary>
        /// 金额１	M
        /// </summary>
        public decimal EXTAM1 { get; set; }
        /// <summary>
        /// 金额２	M
        /// </summary>
        public decimal EXTAM2 { get; set; }
        /// <summary>
        /// 描述１	C(20)
        /// </summary>
        public string EXTTX1 { get; set; }
        /// <summary>
        /// 描述２	C(20)
        /// </summary>
        public string EXTTX2 { get; set; }
        /// <summary>
        /// 特殊码	C(80)
        /// </summary>
        public string SPLC80 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    对公转账回单户名附加接口
    /// </summary>
    public class CPRRCEANX1
    {
        /// <summary>
        /// 收方户名	Z(122)
        /// </summary>
        public string RCVEAN { get; set; }
        /// <summary>
        /// 预留参考号	C(30)
        /// </summary>
        public string RSVNBR { get; set; }
        /// <summary>
        /// 预留位图	C(40)
        /// </summary>
        public string RSVMAP { get; set; }
        /// <summary>
        /// 预留金额	M
        /// </summary>
        public decimal RSVAMT { get; set; }
        /// <summary>
        /// 预留日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime RSVDAT { get; set; }
        /// <summary>
        /// 预留日期	D, 对应<see cref="RSVDAT"/>
        /// </summary>
        [XmlElement("RSVDAT")]
        public string RSVDATStr
        {
            get
            {
                return this.RSVDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RSVDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 预留备注	Z(200)
        /// </summary>
        public string RSVTXT { get; set; }
        /// <summary>
        /// 特殊码	C(80)	
        /// </summary>
        public string SPLC80 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    对公转账回单户名扩展接口
    /// </summary>
    public class CPRRCEXTX1
    {
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 付方户名	Z(200)
        /// </summary>
        public string SNDEAN { get; set; }
        /// <summary>
        /// 收方户名	Z(200)
        /// </summary>
        public string RCVEAN { get; set; }
        /// <summary>
        /// 备注	Z(200)
        /// </summary>
        public string NARTXT { get; set; }
        /// <summary>
        /// 预留参考号	C(30)
        /// </summary>
        public string RSVNBR { get; set; }
        /// <summary>
        /// 预留位图	C(30)
        /// </summary>
        public string RSVMAP { get; set; }
        /// <summary>
        /// 预留金额	M
        /// </summary>
        public decimal RSVAMT { get; set; }
        /// <summary>
        /// 预留日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime RSVDAT { get; set; }
        /// <summary>
        /// 预留日期	D, 对应<see cref="RSVDAT"/>
        /// </summary>
        [XmlElement("RSVDAT")]
        public string RSVDATStr
        {
            get
            {
                return this.RSVDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RSVDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 预留备注	Z(500)
        /// </summary>
        public string RSVNAR { get; set; }
        /// <summary>
        /// 特殊码	C(80)	
        /// </summary>
        public string SPLC80 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    中间业务平台公司回单输出接口
    /// </summary>
    public class MCMIDRRCZ
    {
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
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
        /// 交易套号	C(15)
        /// </summary>
        public string TRXSET { get; set; }
        /// <summary>
        /// 交易流水	C(15)
        /// </summary>
        public string TRXNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 货币	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 钞汇标志	C(1)
        /// </summary>
        public string CCYTYP { get; set; }
        /// <summary>
        /// 商户号	C(6)	
        /// </summary>
        public string CPRCNV { get; set; }
        /// <summary>
        /// 批次号	C(12)
        /// </summary>
        public string BTHNBR { get; set; }
        /// <summary>
        /// 中间业务参考号	C(26)
        /// </summary>
        public string REFNBR { get; set; }
        /// <summary>
        /// 忽略对账标志	C(1)
        /// </summary>
        public string CHKFLG { get; set; }
        /// <summary>
        /// 任务号	C(13)
        /// </summary>
        public string TSKNBR { get; set; }
        /// <summary>
        /// 转出户口	C(20)
        /// </summary>
        public string PAYEAC { get; set; }
        /// <summary>
        /// 转出户名	Z(62)
        /// </summary>
        public string PAYNAM { get; set; }
        /// <summary>
        /// 转出机构	C(6)
        /// </summary>
        public string PAYBRN { get; set; }
        /// <summary>
        /// 摘要码	C(4)
        /// </summary>
        public string TXTCOD { get; set; }
        /// <summary>
        /// 转入户口	C(20)
        /// </summary>
        public string RCVEAC { get; set; }
        /// <summary>
        /// 转入户名	Z(62)
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 转入机构	C(6)
        /// </summary>
        public string RCVBRN { get; set; }
        /// <summary>
        /// 客户摘要	Z(42)
        /// </summary>
        public string TXTCLT { get; set; }
        /// <summary>
        /// 银行摘要	Z(42)
        /// </summary>
        public string TXTBNK { get; set; }
        /// <summary>
        /// 商户名称	Z(80)
        /// </summary>
        public string CPRNAM { get; set; }
        /// <summary>
        /// 商户流水	C(32)
        /// </summary>
        public string CPRSEQ { get; set; }
        /// <summary>
        /// 商户客户编号	Z(32)
        /// </summary>
        public string CPRACT { get; set; }
        /// <summary>
        /// 特殊码100	C(100)
        /// </summary>
        public string SPL100 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    收款回单（网银互联）   付款回单（网银互联） 
    /// </summary>
    public class NPTRFRCTX1
    {
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 任务实例号	C(13)
        /// </summary>
        public string TSKNBR { get; set; }
        /// <summary>
        /// 交易日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ISUDAT { get; set; }
        /// <summary>
        /// 交易日期	D, 对应<see cref="ISUDAT"/>
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
        /// 交易流水号	C(15)
        /// </summary>
        public string BUSNBR { get; set; }
        /// <summary>
        /// 业务类型	Z(30)
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 交易货币	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 业务参考号	C(35)
        /// </summary>
        public string TRSREF { get; set; }
        /// <summary>
        /// 收方帐号	C(35)
        /// </summary>
        public string RCVACC { get; set; }
        /// <summary>
        /// 收方名称	Z(100)
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 收方银行名称	Z(100)
        /// </summary>
        public string RCVBNK { get; set; }
        /// <summary>
        /// 付方帐号	C(35)
        /// </summary>
        public string SNDACC { get; set; }
        /// <summary>
        /// 付方名称	Z(100)
        /// </summary>
        public string SNDNAM { get; set; }
        /// <summary>
        /// 付方银行名称	Z(100)
        /// </summary>
        public string SNDBNK { get; set; }
        /// <summary>
        /// 摘要	Z(42)
        /// </summary>
        public string TRXTXT { get; set; }
        /// <summary>
        /// 附言	Z(235)
        /// </summary>
        public string RMKTXT { get; set; }
        /// <summary>
        /// 特殊码	C(100)
        /// </summary>
        public string SPL100 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    企业银行通知转活期付款回单
    /// </summary>
    public class TDDRWVHCZ
    {
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 打印日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime PRTDAT { get; set; }
        /// <summary>
        /// 打印日期	D, 对应<see cref="PRTDAT"/>
        /// </summary>
        [XmlElement("PRTDAT")]
        public string PRTDATStr
        {
            get
            {
                return this.PRTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PRTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 任务编码	C(8)
        /// </summary>
        public string TSKCOD { get; set; }
        /// <summary>
        /// 交易流水	C(13)
        /// </summary>
        public string TSKNBR { get; set; }
        /// <summary>
        /// 开户机构	C(6)
        /// </summary>
        public string OPNBRN { get; set; }
        /// <summary>
        /// 开户分行	C(6)
        /// </summary>
        public string OPNBBK { get; set; }
        /// <summary>
        /// 开户城市	C(6)
        /// </summary>
        public string OPNCTY { get; set; }
        /// <summary>
        /// 交易机构	C(6)
        /// </summary>
        public string TRXBRN { get; set; }
        /// <summary>
        /// 交易分行	C(6)
        /// </summary>
        public string TRXBBK { get; set; }
        /// <summary>
        /// 交易城市	C(6)
        /// </summary>
        public string TRXCTY { get; set; }
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
        /// 经办	C(6)
        /// </summary>
        public string OPRUSR { get; set; }
        /// <summary>
        /// 复核	C(6)
        /// </summary>
        public string CHKUSR { get; set; }
        /// <summary>
        /// 授权	C(6)
        /// </summary>
        public string AUTUSR { get; set; }
        /// <summary>
        /// 定期凭证种类	C(1)
        /// </summary>
        public string PSBFG2 { get; set; }
        /// <summary>
        /// 凭证种类	C(4)
        /// </summary>
        public string PSBCD2 { get; set; }
        /// <summary>
        /// 凭证基本类别	C(2)
        /// </summary>
        public string PSBTY2 { get; set; }
        /// <summary>
        /// 凭证号码	C(20)
        /// </summary>
        public string PSBNB2 { get; set; }
        /// <summary>
        /// 户口号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 定期序号	C(5)
        /// </summary>
        public string TDSSEQ { get; set; }
        /// <summary>
        /// 户口名称	C(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 证件类别	C(3)
        /// </summary>
        public string CTFTYP { get; set; }
        /// <summary>
        /// 证件号码	Z(30)
        /// </summary>
        public string CTFIDC { get; set; }
        /// <summary>
        /// 产品编码	C(8)
        /// </summary>
        public string PRDCOD { get; set; }
        /// <summary>
        /// 储蓄种类	C(8)
        /// </summary>
        public string PRDABR { get; set; }
        /// <summary>
        /// 存期	C(6)
        /// </summary>
        public string TERDUR { get; set; }
        /// <summary>
        /// 钞汇标志	C(1)
        /// </summary>
        public string CCYTYP { get; set; }
        /// <summary>
        /// 货币号	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 金额	M
        /// </summary>
        public decimal OPNAMT { get; set; }
        /// <summary>
        /// 联机余额	M
        /// </summary>
        public decimal ONLBAL { get; set; }
        /// <summary>
        /// 开户日	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPNDAT { get; set; }
        /// <summary>
        /// 开户日	D, 对应<see cref="OPNDAT"/>
        /// </summary>
        [XmlElement("OPNDAT")]
        public string OPNDATStr
        {
            get
            {
                return this.OPNDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 关户日	D
        /// </summary>
        [XmlIgnore]
        public DateTime CLSDAT { get; set; }
        /// <summary>
        /// 关户日	D, 对应<see cref="CLSDAT"/>
        /// </summary>
        [XmlElement("CLSDAT")]
        public string CLSDATStr
        {
            get
            {
                return this.CLSDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CLSDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 起息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime INTDAT { get; set; }
        /// <summary>
        /// 起息日	D, 对应<see cref="INTDAT"/>
        /// </summary>
        [XmlElement("INTDAT")]
        public string INTDATStr
        {
            get
            {
                return this.INTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 到期日	D, 对应<see cref="EXPDAT"/>
        /// </summary>
        [XmlElement("EXPDAT")]
        public string EXPDATStr
        {
            get
            {
                return this.EXPDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EXPDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 止息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime EINDAT { get; set; }
        /// <summary>
        /// 止息日	D, 对应<see cref="EINDAT"/>
        /// </summary>
        [XmlElement("EINDAT")]
        public string EINDATStr
        {
            get
            {
                return this.EINDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EINDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 部提利率	F(11,7)
        /// </summary>
        public decimal PPPIVA { get; set; }
        /// <summary>
        /// 提前利率	F(11,7)
        /// </summary>
        public decimal PREIVA { get; set; }
        /// <summary>
        /// 到期利率	F(11,7)
        /// </summary>
        public decimal MTUIVA { get; set; }
        /// <summary>
        /// 超期利率	F(11,7)
        /// </summary>
        public decimal OVRIVA { get; set; }
        /// <summary>
        /// 支取标记	C(1)
        /// </summary>
        public string WDPFLG { get; set; }
        /// <summary>
        /// 业务类型	C(6)
        /// </summary>
        public string TRSKND { get; set; }
        /// <summary>
        /// 交易类型	C(6)
        /// </summary>
        public string TRSCTG { get; set; }
        /// <summary>
        /// 支取金额	M
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 利息金额	M
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 利息税金额	M
        /// </summary>
        public decimal TAXAMT { get; set; }
        /// <summary>
        /// 计费货币号	C(2)
        /// </summary>
        public string FEECCY { get; set; }
        /// <summary>
        /// 应收费用金额	M
        /// </summary>
        public decimal FEEAMT { get; set; }
        /// <summary>
        /// 凭证验证标志	C(4)
        /// </summary>
        public string PSBVLD { get; set; }
        /// <summary>
        /// 定期凭证种类	C(1)
        /// </summary>
        public string PSBFLG { get; set; }
        /// <summary>
        /// 凭证种类	C(4)
        /// </summary>
        public string PSBCOD { get; set; }
        /// <summary>
        /// 凭证基本类别	C(2)
        /// </summary>
        public string PSBTYP { get; set; }
        /// <summary>
        /// 凭证号码	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 是否通知	C(1)
        /// </summary>
        public string INFFLG { get; set; }
        /// <summary>
        /// 通知日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime INFDAT { get; set; }
        /// <summary>
        /// 通知日期	D, 对应<see cref="INFDAT"/>
        /// </summary>
        [XmlElement("INFDAT")]
        public string INFDATStr
        {
            get
            {
                return this.INFDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INFDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 通知序号	S(3,0)
        /// </summary>
        public string INFSEQ { get; set; }
        /// <summary>
        /// 通知到到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime INEDAT { get; set; }
        /// <summary>
        /// 通知到到期日	D, 对应<see cref="INEDAT"/>
        /// </summary>
        [XmlElement("INEDAT")]
        public string INEDATStr
        {
            get
            {
                return this.INEDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INEDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 通知金额	M
        /// </summary>
        public decimal INFAMT { get; set; }
        /// <summary>
        /// 金额１	M
        /// </summary>
        public decimal EXTAM1 { get; set; }
        /// <summary>
        /// 金额２	M
        /// </summary>
        public decimal EXTAM2 { get; set; }
        /// <summary>
        /// 金额３	M
        /// </summary>
        public decimal EXTAM3 { get; set; }
        /// <summary>
        /// 描述１	C(20)
        /// </summary>
        public string EXTTX1 { get; set; }
        /// <summary>
        /// 描述２	C(20)
        /// </summary>
        public string EXTTX2 { get; set; }
        /// <summary>
        /// 描述３	C(20)
        /// </summary>
        public string EXTTX3 { get; set; }
        /// <summary>
        /// 摘要１	C(40)
        /// </summary>
        public string RMKLN1 { get; set; }
        /// <summary>
        /// 摘要２	C(40)
        /// </summary>
        public string RMKLN2 { get; set; }
        /// <summary>
        /// 摘要３	C(80)
        /// </summary>
        public string RMKLN3 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    企业银行通知转活期付款回单
    /// </summary>
    public class TDDRWVHCZ0
    {
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 客户名	Z(62)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 收款单号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 钞汇户	C(1)
        /// </summary>
        public string CCYTYP { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 金额１	M
        /// </summary>
        public decimal EXTAM1 { get; set; }
        /// <summary>
        /// 金额２	M
        /// </summary>
        public decimal EXTAM2 { get; set; }
        /// <summary>
        /// 描述１	C(20)
        /// </summary>
        public string EXTTX1 { get; set; }
        /// <summary>
        /// 描述２	C(20)
        /// </summary>
        public string EXTTX2 { get; set; }
    }
    #endregion
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    企业银行定期转活期计息清单
    /// </summary>
    public class TDINTLSBZ
    {
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string ISTNBR { get; set; }
        /// <summary>
        /// 打印日期	D
        /// </summary>
        public string PRTDAT { get; set; }
        /// <summary>
        /// 打印时间	T
        /// </summary>
        public string PRTTIM { get; set; }
        /// <summary>
        /// 打印时间 由<see cref="PRTDAT"/>和<see cref="PRTTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime PrintTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.PRTDAT, this.PRTTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return DateTime.MinValue;
            }
        }
        /// <summary>
        /// 任务实例号	C(13)
        /// </summary>
        public string TSKNBR { get; set; }
        /// <summary>
        /// 任务编码	C(8)
        /// </summary>
        public string TSKCOD { get; set; }
        /// <summary>
        /// 证件类别	C(3)
        /// </summary>
        public string CTFTYP { get; set; }
        /// <summary>
        /// 证件号码	Z(30)
        /// </summary>
        public string CTFIDC { get; set; }
        /// <summary>
        /// 开户机构	C(6)
        /// </summary>
        public string EACBRN { get; set; }
        /// <summary>
        /// 户口号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 产品代码	C(8)
        /// </summary>
        public string PRDCOD { get; set; }
        /// <summary>
        /// 储蓄种类	C(8)
        /// </summary>
        public string PRDABR { get; set; }
        /// <summary>
        /// 定期序号	C(5)
        /// </summary>
        public string TDSSEQ { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 存期	C(6)
        /// </summary>
        public string TERDUR { get; set; }
        /// <summary>
        /// 户口名称	C(200)
        /// </summary>
        public string EACNA1 { get; set; }
        /// <summary>
        /// 证件类别	C(3)
        /// </summary>
        public string CTFTY1 { get; set; }
        /// <summary>
        /// 证件号码	Z(30)
        /// </summary>
        public string CTFID1 { get; set; }
        /// <summary>
        /// 户口号	C(35)
        /// </summary>
        public string EACNB1 { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNB1 { get; set; }
        /// <summary>
        /// 产品代码	C(8)
        /// </summary>
        public string PRDCD1 { get; set; }
        /// <summary>
        /// 开户行	C(3)
        /// </summary>
        public string BBKNB1 { get; set; }
        /// <summary>
        /// 开户城市	C(6)
        /// </summary>
        public string CTYCD1 { get; set; }
        /// <summary>
        /// 开户机构	C(6)
        /// </summary>
        public string BRNNB1 { get; set; }
        /// <summary>
        /// 历次扣税	M
        /// </summary>
        public decimal HISTAX { get; set; }
        /// <summary>
        /// 本次扣税	M
        /// </summary>
        public decimal CURTAX { get; set; }
        /// <summary>
        /// 总计税金	M
        /// </summary>
        public decimal ALLTAX { get; set; }
        /// <summary>
        /// 本金	M
        /// </summary>
        public decimal DRWAMT { get; set; }
        /// <summary>
        /// 税后利息	M
        /// </summary>
        public decimal TXDINT { get; set; }
        /// <summary>
        /// 税后本息合计	M
        /// </summary>
        public decimal TXDBAL { get; set; }
        /// <summary>
        /// 支取标志	C(1)
        /// </summary>
        public string WDPFLG { get; set; }
        /// <summary>
        /// 摘要	C(80)
        /// </summary>
        public string RMKLIN { get; set; }
        /// <summary>
        /// 交易机构	C(6)
        /// </summary>
        public string TRXBRN { get; set; }
        /// <summary>
        /// 交易日期	D
        /// </summary>
        public string TRXDAT { get; set; }
        /// <summary>
        /// 交易时间	T
        /// </summary>
        public string TRXTIM { get; set; }
        /// <summary>
        /// 交易时间 由<see cref="TRXDAT"/>和<see cref="TRXTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime TransactionTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.TRXDAT, this.TRXTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return DateTime.MinValue;
            }
        }
        /// <summary>
        /// 经办	C(6)
        /// </summary>
        public string OPRUSR { get; set; }
        /// <summary>
        /// 复核	C(6)
        /// </summary>
        public string CHKUSR { get; set; }
        /// <summary>
        /// 授权	C(6)
        /// </summary>
        public string AUTUSR { get; set; }
        /// <summary>
        /// 金额１	M
        /// </summary>
        public decimal EXTAM1 { get; set; }
        /// <summary>
        /// 金额２	M
        /// </summary>
        public decimal EXTAM2 { get; set; }
        /// <summary>
        /// 金额３	M
        /// </summary>
        public decimal EXTAM3 { get; set; }
        /// <summary>
        /// 描述１	C(20)
        /// </summary>
        public string EXTTX1 { get; set; }
        /// <summary>
        /// 描述２	C(20)
        /// </summary>
        public string EXTTX2 { get; set; }
        /// <summary>
        /// 描述３	C(20)
        /// </summary>
        public string EXTTX3 { get; set; }
        /// <summary>
        /// 摘要１	C(40)
        /// </summary>
        public string RMKLN1 { get; set; }
        /// <summary>
        /// 摘要２	C(40)
        /// </summary>
        public string RMKLN2 { get; set; }
        /// <summary>
        /// 摘要３	C(80)
        /// </summary>
        public string RMKLN3 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息响应内容    企业银行定期转活期计息清单
    /// </summary>
    public class TDINTLSBZ0
    {
        /// <summary>
        /// 打印实例号	C(13)
        /// </summary>
        public string IstNbr { get; set; }
        /// <summary>
        /// 货币号	C(2)
        /// </summary>
        public string CcyNbr { get; set; }
        /// <summary>
        /// 钞汇户	C(1)
        /// </summary>
        public string CcyTyp { get; set; }
        /// <summary>
        /// 起息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime IntDat { get; set; }
        /// <summary>
        /// 起息日	D, 对应<see cref="IntDat"/>
        /// </summary>
        [XmlElement("IntDat")]
        public string IntDatStr
        {
            get
            {
                return this.IntDat.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.IntDat = tmp;
                }
            }
        }
        /// <summary>
        /// 止息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime EinDat { get; set; }
        /// <summary>
        /// 止息日	D, 对应<see cref="EinDat"/>
        /// </summary>
        [XmlElement("EinDat")]
        public string EinDatStr
        {
            get
            {
                return this.EinDat.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EinDat = tmp;
                }
            }
        }
        /// <summary>
        /// 计息本金	M
        /// </summary>
        public decimal IntAmt { get; set; }
        /// <summary>
        /// 利率	F(11,7)
        /// </summary>
        public decimal IntRat { get; set; }
        /// <summary>
        /// 利息金额	M
        /// </summary>
        public decimal IntRst { get; set; }
        /// <summary>
        /// 应税利息	M
        /// </summary>
        public decimal ItxInt { get; set; }
        /// <summary>
        /// 税率	F(5,2)
        /// </summary>
        public decimal TaxRat { get; set; }
        /// <summary>
        /// 利息税金额	M
        /// </summary>
        public decimal ItxAmt { get; set; }
        /// <summary>
        /// 税后利息	M
        /// </summary>
        public decimal TxdInt { get; set; }
        /// <summary>
        /// 金额１	M
        /// </summary>
        public decimal ExtAm1 { get; set; }
        /// <summary>
        /// 金额２	M
        /// </summary>
        public decimal ExtAm2 { get; set; }
        /// <summary>
        /// 描述１	C(20)
        /// </summary>
        public string ExtTx1 { get; set; }
        /// <summary>
        /// 描述２	C(20)
        /// </summary>
        public string ExtTx2 { get; set; }
    }
}
