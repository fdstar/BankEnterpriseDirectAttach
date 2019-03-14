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
    /// 1.8.查询历史通知响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS1_8 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// GetHisNotice
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "GetHisNotice";
        /// <summary>
        /// 1.8.查询历史通知响应集合
        /// </summary>
        [XmlElement("FBDLRHMGZ")]
        public List<FBDLRHMGZ> List { get; set; }
        /// <summary>
        /// NCBCHOPR	批量支付经办结果通知 集合
        /// </summary>
        [XmlElement("NCBCHOPRY")]
        public List<NCBCHOPRY> NCBCHOPRList { get; set; }
        /// <summary>
        /// NCCRTTRS 到帐通知 集合
        /// </summary>
        [XmlElement("NCCRTTRSY")]
        public List<NCCRTTRSY> NCCRTTRSList { get; set; }
        /// <summary>
        /// NCDBTTRS 付款通知
        /// </summary>
        [XmlElement("NCDBTTRSY")]
        public List<NCDBTTRSY> NCDBTTRSList { get; set; }
        /// <summary>
        /// NCDRTPAY 直接支付结果通知 集合
        /// </summary>
        [XmlElement("NCDRTPAYY")]
        public List<NCDRTPAYY> NCDRTPAYList { get; set; }
        /// <summary>
        /// NCBUSFIN 业务完成通知 集合
        /// </summary>
        [XmlElement("NCBUSFINY")]
        public List<NCBUSFINY> NCBUSFINList { get; set; }
    }
    /// <summary>
    /// 1.8.查询历史通知响应内容
    /// </summary>
    public class FBDLRHMGZ
    {
        /// <summary>
        /// 通知类型	C(8)	附录A.16
        /// NCBCHOPR	批量支付经办结果通知
        /// NCCRTTRS 到帐通知
        /// NCDBTTRS 付款通知
        /// NCDRTPAY 直接支付结果通知
        /// NCBUSFIN 业务完成通知
        /// </summary>
        public string MSGTYP { get; set; }
        /// <summary>
        /// 通知序号	C(18)    唯一标识一笔通知
        /// </summary>
        public string MSGNBR { get; set; }
        /// <summary>
        /// 消息创建日期时间	DT
        /// </summary>
        [XmlIgnore]
        public DateTime CRTTIM { get; set; }
        /// <summary>
        /// 消息创建日期时间	DT, 对应<see cref="CRTTIM"/>
        /// </summary>
        [XmlElement("CRTTIM")]
        public string CRTTIMStr
        {
            get
            {
                return this.CRTTIM.ToString("yyyyMMddHHmmss");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMddHHmmss", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CRTTIM = tmp;
                }
            }
        }
        /// <summary>
        /// 服务器接收日期时间	DT
        /// </summary>
        [XmlIgnore]
        public DateTime RCVTIM { get; set; }
        /// <summary>
        /// 服务器接收日期时间	DT, 对应<see cref="RCVTIM"/>
        /// </summary>
        [XmlElement("RCVTIM")]
        public string RCVTIMStr
        {
            get
            {
                return this.RCVTIM.ToString("yyyyMMddHHmmss");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMddHHmmss", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RCVTIM = tmp;
                }
            }
        }
        /// <summary>
        /// 有效开始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime EFTDAT { get; set; }
        /// <summary>
        /// 有效开始日期	D, 对应<see cref="EFTDAT"/>
        /// </summary>
        [XmlElement("EFTDAT")]
        public string EFTDATStr
        {
            get
            {
                return this.EFTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EFTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 有效结束时间日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 有效结束时间日期	D, 对应<see cref="EXPDAT"/>
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
    }
    /// <summary>
    /// B.2历史通知接口格式  NCBCHOPR-批量支付经办结果通知、批量代理清算经办结果通知
    /// </summary>
    public class NCBCHOPRY
    {
        /// <summary>
        /// 通知类型	C（8）	NCBCHOPR-批量支付经办结果通知、批量代理清算经办结果通知
        /// </summary>
        public string MSGTYP { get; set; }
        /// <summary>
        /// 通知序号	C（18） 唯一标示一笔通知信息
        /// </summary>
        public string MSGNBR { get; set; }
        /// <summary>
        /// 业务类型	C（6） 当FLWTYP=N09010时表示批量代理清算经办结果通知，否表示批量支付经办结果通知
        /// </summary>
        public string FLWTYP { get; set; }
        /// <summary>
        /// 业务模式	C（5）
        /// </summary>
        public string FLWCOD { get; set; }
        /// <summary>
        /// 处理结果批号	C（10）
        /// </summary>
        public string RSTSET { get; set; }
        /// <summary>
        /// 保留字	C（30）
        /// </summary>
        public string RSV30Z { get; set; }
    }
    /// <summary>
    /// B.2历史通知接口格式  NCDRTPAY-直接支付结果通知
    /// </summary>
    public class NCDRTPAYY
    {
        /// <summary>
        /// 通知类型	C（8）		NCDRTPAY-直接支付结果通知
        /// </summary>
        public string MSGTYP { get; set; }
        /// <summary>
        /// 通知序号	C（18） 唯一标示一笔通知信息
        /// </summary>
        public string MSGNBR { get; set; }
        /// <summary>
        /// 业务类型	C（6）N02031-直接支付；N02041-直接集团支付
        /// </summary>
        public string FLWTYP { get; set; }
        /// <summary>
        /// 流程实例号	C（10）
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务数据	C（30）暂时不用
        /// </summary>
        public string REQDTA { get; set; }
        /// <summary>
        /// 分行地区码	C（2,2）见附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 帐号	C（35）
        /// </summary>
        public string KEYVAL { get; set; }
        /// <summary>
        /// 币种代码	C（2）见附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 业务参考号	C（30）取值为企业银行客户端经办时录入的参考号，其他情况为空
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 帐户名称	Z（62）
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 金额	M
        /// </summary>
        public decimal ENDAMT { get; set; }
        /// <summary>
        /// 期望日期	D
        /// </summary>
        public string EPTDAT { get; set; }
        /// <summary>
        /// 期望时间	T
        /// </summary>
        public string EPTTIM { get; set; }
        /// <summary>
        /// 期望时间 由<see cref="EPTDAT"/>和<see cref="EPTTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime ExpectedTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.EPTDAT, this.EPTTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return DateTime.MinValue;
            }
        }
        /// <summary>
        /// 经办日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 经办日期	D, 对应<see cref="OPRDAT"/>
        /// </summary>
        [XmlElement("OPRDAT")]
        public string OPRDATStr
        {
            get
            {
                return this.OPRDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 业务请求结果	C（1）	A.6 业务处理结果
        /// S 成功	银行支付成功
        /// F 失败  银行支付失败
        /// B 退票 银行支付被退票
        /// R 否决  企业审批否决
        /// D 过期 企业过期不审批
        /// C 撤消  企业撤销
        /// M 商户撤销订单 商务支付
        /// V 拒绝  委托贷款被借款方拒绝
        /// U 银行挂账
        /// T 退款
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 业务结果描述	Z（92）
        /// </summary>
        public string RTNDSP { get; set; }
    }
    /// <summary>
    /// B.2历史通知接口格式 NCCRTTRS-到帐通知； NCDBTTRS-付款通知；
    /// </summary>
    public class NCCRTTRSY
    {
        /// <summary>
        /// 通知类型	C（8）	NCCRTTRS-到帐通知； NCDBTTRS-付款通知；
        /// </summary>
        public string MSGTYP { get; set; }
        /// <summary>
        /// 通知序号	C（18） 唯一标示一笔通知信息
        /// </summary>
        public string MSGNBR { get; set; }
        /// <summary>
        /// 分行号	N（2,2）	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 帐号	C（35）
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 币种代码	C（2,2）	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal? TRSAMT { get; set; }
        /// <summary>
        /// 余额	M
        /// </summary>
        public decimal BLVAMT { get; set; }
        /// <summary>
        /// 帐户名称	Z（62）
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 交易日期	D
        /// </summary>
        public string TRSDAT { get; set; }
        /// <summary>
        /// 交易时间	T
        /// </summary>
        public string TRSTIM { get; set; }
        /// <summary>
        /// 交易时间 由<see cref="TRSDAT"/>和<see cref="TRSTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime TransactionTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.TRSDAT, this.TRSTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return DateTime.MinValue;
            }
        }
        /// <summary>
        /// 借贷码	C（1）	'C'代表贷方；'D'代表借方
        /// </summary>
        public string AMTCDR { get; set; }
        /// <summary>
        /// 冲补帐标志	C（1）	*代表冲账；X代表补帐
        /// </summary>
        public string RVSTAG { get; set; }
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
        /// 凭证类型	C（4）	附录A.7
        /// </summary>
        public string BILTYP { get; set; }
        /// <summary>
        /// 凭证描述	Z（12） 凭证描述信息
        /// </summary>
        public string BILTXT { get; set; }
        /// <summary>
        /// 凭证号码	C（10） 如凭证类型为支票，该字段为支票号码
        /// </summary>
        public string BILNBR { get; set; }
        /// <summary>
        /// 票据号	C（20）
        /// </summary>
        public string NEWBIL { get; set; }
        /// <summary>
        /// 交易套号	C（8）
        /// </summary>
        public string TRSSET { get; set; }
        /// <summary>
        /// 交易流水号	C（15） 银行会计系统交易流水号
        /// </summary>
        public string SEQNBR { get; set; }
        /// <summary>
        /// 摘要	Z（62）有效长度为16字节。若为企业银行客户端经办的交易，则该字段为用途信息（4.0版代发代扣业务除外），若为其它渠道经办的交易，则该字段为交易的简单说明和注解
        /// </summary>
        public string NARTXT { get; set; }
        /// <summary>
        /// 收付方帐号分行号	N（2） 见附录A.1
        /// </summary>
        public string RPYBBK { get; set; }
        /// <summary>
        /// 收付方帐号	C（35）
        /// </summary>
        public string RPYACC { get; set; }
        /// <summary>
        /// 收付方名称	Z（62）
        /// </summary>
        public string RPYNAM { get; set; }
        /// <summary>
        /// 收付方开户行行号	C（20）
        /// </summary>
        public string RPYBBN { get; set; }
        /// <summary>
        /// 收付方开户行行名	Z（62）
        /// </summary>
        public string RPYBNK { get; set; }
        /// <summary>
        /// 收付方开户行地址	Z（62）
        /// </summary>
        public string RPYADR { get; set; }
        /// <summary>
        /// 母子帐号分行号	N（2） 见附录A.1
        /// </summary>
        public string GSBBBK { get; set; }
        /// <summary>
        /// 母子公司帐号	C（35）
        /// </summary>
        public string GSBACC { get; set; }
        /// <summary>
        /// 母子公司名称	Z（62）
        /// </summary>
        public string GSBNAM { get; set; }
        /// <summary>
        /// 母子公司开户行行号	C（20） 	联行号
        /// </summary>
        public string GSBBBN { get; set; }
        /// <summary>
        /// 母子公司开户行行名	Z（62）
        /// </summary>
        public string GSBBNK { get; set; }
        /// <summary>
        /// 母子公司开户行地址	Z（62）
        /// </summary>
        public string GSBADR { get; set; }
        /// <summary>
        /// 信息标志	C（1）
        /// 为空表示付方帐号和子公司；为“1”表示收方帐号和子公司；为“2”表示收方帐号和母公司，一般用于判断收付方；对于集团公司，如果字段GSBACC不为空，也用于判断母子公司
        /// </summary>
        public string INFFLG { get; set; }
        /// <summary>
        /// 交易分析码	C（6）
        /// 1-2位取值含义件附录A.8，3-6位取值含义件附录A.9。建议：该字段取值后台没有统一标准，所以附录额A.8和A.9不易公开发表。如有客户需要区分不同交易，再根据具体情况提供取值范围
        /// </summary>
        public string TRSANL { get; set; }
        /// <summary>
        /// 对方参考号	C（30）
        /// 取值为企业银行客户端经办时录入的参考号，其他情况为空
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 业务摘要	Z（200）
        /// 取值为企业银行客户端经办时录入的摘要字段,其他情况为空
        /// </summary>
        public string BUSNAR { get; set; }
    }
    /// <summary>
    /// B.2历史通知接口格式 NCCRTTRS-到帐通知； NCDBTTRS-付款通知；
    /// </summary>
    public class NCDBTTRSY : NCCRTTRSY
    {
    }
    /// <summary>
    /// B.2历史通知接口格式 NCBUSFIN – 业务完成通知
    /// </summary>
    public class NCBUSFINY
    {
        /// <summary>
        /// 通知类型	C（8）		NCBUSFIN – 业务完成通知
        /// </summary>
        public string MSGTYP { get; set; }
        /// <summary>
        /// 通知序号	C（18） 唯一标示一笔通知信息
        /// </summary>
        public string MSGNBR { get; set; }
        /// <summary>
        /// 流程实例号	C（10）
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务类型	C（6）
        /// </summary>
        public string FLWTYP { get; set; }
        /// <summary>
        /// 业务数据	C（30）
        /// </summary>
        public string REQDTA { get; set; }
        /// <summary>
        /// 业务键值	C(40)
        /// </summary>
        public string KEYVAL { get; set; }
        /// <summary>
        /// 分行号	C(2) 见附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 帐户名称	Z(62)
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 金额	M
        /// </summary>
        public decimal ENDAMT { get; set; }
        /// <summary>
        /// 币种	C(2) 见附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 经办日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 经办日期	D, 对应<see cref="OPRDAT"/>
        /// </summary>
        [XmlElement("OPRDAT")]
        public string OPRDATStr
        {
            get
            {
                return this.OPRDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 期望日期	D
        /// </summary>
        public string EPTDAT { get; set; }
        /// <summary>
        /// 期望时间	T
        /// </summary>
        public string EPTTIM { get; set; }
        /// <summary>
        /// 期望时间 由<see cref="EPTDAT"/>和<see cref="EPTTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime ExpectedTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.EPTDAT, this.EPTTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return DateTime.MinValue;
            }
        }
        /// <summary>
        /// 对方参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 业务请求结果	C(1)	A.6 业务处理结果
        /// S 成功	银行支付成功
        /// F 失败  银行支付失败
        /// B 退票 银行支付被退票
        /// R 否决  企业审批否决
        /// D 过期 企业过期不审批
        /// C 撤消  企业撤销
        /// M 商户撤销订单 商务支付
        /// V 拒绝  委托贷款被借款方拒绝
        /// U 银行挂账
        /// T 退款
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 业务结果描述	Z(92)
        /// </summary>
        public string RTNDSP { get; set; }
        /// <summary>
        /// 保留字	C（50）
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
