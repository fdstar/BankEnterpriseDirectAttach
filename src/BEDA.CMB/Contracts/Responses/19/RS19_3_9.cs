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
    /// 19.3.9.商票交易票据业务处理信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_3_9 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKMHTLST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKMHTLST";
        /// <summary>
        /// 19.3.9.商票交易票据业务处理信息响应集合
        /// </summary>
        [XmlElement("NTMCHINFZ")]
        public List<NTMCHINFZ> List { get; set; }
        /// <summary>
        /// 19.3.9.商票交易票据业务处理信息响应内容
        /// 票据质押交易信息
        /// </summary>
        public NTCUSATHZ1 NTCUSATHZ1 { get; set; }
        /// <summary>
        /// 19.3.9.商票交易票据业务处理信息响应内容
        /// 票据质押开票交易信息
        /// </summary>
        public NTCUSATHZ2 NTCUSATHZ2 { get; set; }
        /// <summary>
        /// 19.3.9.商票交易票据业务处理信息响应内容
        /// 票据贴现交易信息
        /// </summary>
        public NTCUSATHZ3 NTCUSATHZ3 { get; set; }
        /// <summary>
        /// 19.3.9.商票交易票据业务处理信息响应内容
        /// 票据背书交易信息
        /// </summary>
        public NTCUSATHZ4 NTCUSATHZ4 { get; set; }
        /// <summary>
        /// 19.3.9.商票交易票据业务处理信息响应内容
        /// 票据赎回交易信息
        /// </summary>
        public NTCUSATHZ5 NTCUSATHZ5 { get; set; }
        /// <summary>
        /// 19.3.9.商票交易票据业务处理信息响应内容
        /// 票据提前兑付交易信息
        /// </summary>
        public NTCUSATHZ6 NTCUSATHZ6 { get; set; }
    }
    /// <summary>
    /// 19.3.9.商票交易票据业务处理信息响应内容
    /// </summary>
    public class NTMCHINFZ
    {
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
        /// 托管机构名称	Z(62)
        /// </summary>
        public string SAVNAM { get; set; }
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
        /// <summary>
        /// 银行保证标志	C(1)
        /// </summary>
        public string BNKFLG { get; set; }
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
    }
}
