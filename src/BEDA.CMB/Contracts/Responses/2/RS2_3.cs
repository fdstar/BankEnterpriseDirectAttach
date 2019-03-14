using BEDA.Utils;
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
    /// 2.3.查询账户交易信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS2_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// GetTransInfo
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "GetTransInfo";
        /// <summary>
        /// 2.3.查询账户交易信息响应集合
        /// </summary>
        [XmlElement("NTQTSINFZ")]
        public List<NTQTSINFZ> List { get; set; }
    }
    /// <summary>
    /// 2.3.查询账户交易信息响应内容
    /// </summary>
    public class NTQTSINFZ
    {
        /// <summary>
        /// 交易日	D
        /// </summary>
        public string ETYDAT { get; set; }
        /// <summary>
        /// 交易时间	T
        /// </summary>
        public string ETYTIM { get; set; }
        /// <summary>
        /// 交易时间 由<see cref="ETYDAT"/>和<see cref="ETYTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime TransactionTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.ETYDAT, this.ETYTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return DateTime.MinValue;
            }
        }
        /// <summary>
        /// 起息日	D   开始计息的日期
        /// </summary>
        [XmlIgnore]
        public DateTime? VLTDAT { get; set; }
        /// <summary>
        /// 起息日	D, 对应<see cref="VLTDAT"/>
        /// </summary>
        [XmlElement("VLTDAT")]
        public string VLTDATStr
        {
            get
            {
                return this.VLTDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.VLTDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.VLTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 交易类型	C（8）	附录A.9
        /// </summary>
        public string TRSCOD { get; set; }
        /// <summary>
        /// 摘要	Z（62）若为企业银行客户端经办的交易，则该字段为用途信息（4.0版代发代扣业务除外）若为其它渠道经办的交易，则该字段为交易的简单说明和注解
        /// </summary>
        public string NARYUR { get; set; }
        /// <summary>
        /// 借方金额	M   企业为借方时的交易金额（正数）
        /// </summary>
        [XmlIgnore]
        public decimal? TRSAMTD { get; set; }
        /// <summary>
        /// 借方金额	M   企业为借方时的交易金额（正数） 对应<see cref="TRSAMTD"/>
        /// </summary>
        [XmlElement("TRSAMTD")]
        public string TRSAMTDStr
        {
            get { return this.TRSAMTD?.ToString(); }
            set { this.TRSAMTD = value.TryConvert<decimal>(); }
        }
        /// <summary>
        /// 贷方金额	M   企业为贷方时的交易金额（正数）
        /// </summary>
        [XmlIgnore]
        public decimal? TRSAMTC { get; set; }
        /// <summary>
        /// 贷方金额	M   企业为贷方时的交易金额（正数） 对应<see cref="TRSAMTC"/>
        /// </summary>
        [XmlElement("TRSAMTC")]
        public string TRSAMTCStr
        {
            get { return this.TRSAMTC?.ToString(); }
            set { this.TRSAMTC = value.TryConvert<decimal>(); }
        }
        /// <summary>
        /// 借贷标记	C（1）	C:贷；D:借
        /// </summary>
        public string AMTCDR { get; set; }
        /// <summary>
        /// 余额	M   帐户的联机余额
        /// </summary>
        [XmlIgnore]
        public decimal? TRSBLV { get; set; }
        /// <summary>
        /// 余额	M   帐户的联机余额 对应<see cref="TRSBLV"/>
        /// </summary>
        [XmlElement("TRSBLV")]
        public string TRSBLVStr
        {
            get { return this.TRSBLV?.ToString(); }
            set { this.TRSBLV = value.TryConvert<decimal>(); }
        }
        /// <summary>
        /// 流水号	C（15）   银行会计系统交易流水号
        /// </summary>
        public string REFNBR { get; set; }
        /// <summary>
        /// 流程实例号	N（10）   企业银行交易序号，唯一标示企业银行客户端发起的一笔交易
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务名称	Z（32）
        /// </summary>
        public string BUSNAM { get; set; }
        /// <summary>
        /// 用途	Z（62）
        /// </summary>
        public string NUSAGE { get; set; }
        /// <summary>
        /// 业务参考号	C（30）
        /// 企业银行客户端录入的业务参考号。用企业银行做的交易会有业务参考号，没有票据号，在柜台或其它地方生成的交易有票据号或其它的唯一标识，都统一称为业务参考号
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 业务摘要	Z（200）  对业务的简单说明或注解。企业银行客户端录入的摘要信息
        /// </summary>
        public string BUSNAR { get; set; }
        /// <summary>
        /// 其它摘要	Z（62）   对业务的其它说明或注解（暂不使用）
        /// </summary>
        public string OTRNAR { get; set; }
        /// <summary>
        /// 收/付方开户地区	C（12）   收/付方帐号开户行所在地区，如北京、上海、深圳等
        /// </summary>
        public string C_RPYBBK { get; set; }
        /// <summary>
        /// 收/付方帐户名称	Z（62）
        /// </summary>
        public string RPYNAM { get; set; }
        /// <summary>
        /// 收/付方的转入或转出帐号	N（35）
        /// </summary>
        public string RPYACC { get; set; }
        /// <summary>
        /// 收/付方开户行行号	C（20）
        /// </summary>
        public string RPYBBN { get; set; }
        /// <summary>
        /// 收/付方帐号的开户行的行名	Z（62）
        /// </summary>
        public string RPYBNK { get; set; }
        /// <summary>
        /// 收/付方开户行地址	Z（62）
        /// </summary>
        public string RPYADR { get; set; }
        /// <summary>
        /// 母/子公司所在地区	C（12）   母/子公司帐号的开户行所在地区，如北京、上海、深圳等
        /// </summary>
        public string C_GSBBBK { get; set; }
        /// <summary>
        /// 母/子公司帐号	C（35）
        /// </summary>
        public string GSBACC { get; set; }
        /// <summary>
        /// 母/子公司名称	Z（62）
        /// </summary>
        public string GSBNAM { get; set; }
        /// <summary>
        /// 信息标志	N（1）
        /// 用于标识收/付方帐号和母/子公司的信息。
        /// 为空表示付方帐号和子公司；
        /// 为“1”表示收方帐号和子公司；
        /// 为“2”表示收方帐号和母公司；
        /// 为“3”表示原收方帐号和子公司
        /// </summary>
        public string INFFLG { get; set; }
        /// <summary>
        /// 有否附件信息标志	C(1)	Y/N
        /// </summary>
        public string ATHFLG { get; set; }
        /// <summary>
        /// 票据号	C（20）
        /// </summary>
        public string CHKNBR { get; set; }
        /// <summary>
        /// 冲帐标志	C（1）
        /// *为冲帐，X为补帐 （冲账交易与原交易借贷相反）
        /// </summary>
        public string RSVFLG { get; set; }
        /// <summary>
        /// 扩展摘要	Z（34）
        /// </summary>
        public string NAREXT { get; set; }
        /// <summary>
        /// 交易分析码	C（6）
        /// 1-2位取值含义件附录A.8，3-6位取值含义件附录A.9。
        /// 建议：该字段取值后台没有统一标准，所以附录A.8和A.9不易公开发表。如有客户需要区分不同交易，再根据具体情况提供取值范围
        /// </summary>
        public string TRSANL { get; set; }
        /// <summary>
        /// 商务支付订单号	C(1,50) 由商务支付订单产生
        /// </summary>
        public string REFSUB { get; set; }
        /// <summary>
        /// 企业识别码	N(10)   开通收方识别功能的账户可以通过此码识别付款方
        /// </summary>
        public string FRMCOD { get; set; }
    }
}
