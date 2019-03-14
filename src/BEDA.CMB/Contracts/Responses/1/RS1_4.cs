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
    /// 1.4.取新的通知响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS1_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// GetNewNotice
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "GetNewNotice";
        /// <summary>
        /// 1.4.取新的通知响应集合
        /// </summary>
        [XmlElement("NTQNTCGTZ")]
        public List<NTQNTCGTZ> List { get; set; }
    }
    /// <summary>
    /// 1.4.取新的通知响应内容
    /// </summary>
    public class NTQNTCGTZ
    {
        /// <summary>
        /// 通知类型	C（8）	
        /// NCCRTTRS-到帐通知； 
        /// NCDBTTRS-付款通知；
        /// NCDRTPAY-直接支付结果通知
        /// NCBCHOPR-批量支付经办结果通知或批量代理清算经办结果通知
        /// NCBUSFIN – 业务完成通知
        /// </summary>
        public string MSGTYP { get; set; }
        /// <summary>
        /// 通知序号	C（18）	 唯一标示一笔通知信息
        /// </summary>
        public string MSGNBR { get; set; }
        /// <summary>
        /// 分行号	N（2,2）
        ///北京	10
        ///离岸分行	12
        ///总行离岸中心	13
        ///广州	20
        ///上海	21
        ///天津	22
        ///重庆	23
        ///沈阳	24
        ///南京	25
        ///武汉	27
        ///成都	28
        ///西安	29
        ///太原	35
        ///郑州	37
        ///石家庄	38
        ///唐山	39
        ///大连	41
        ///长春	43
        ///哈尔滨	45
        ///呼和浩特	47
        ///银川	51
        ///苏州	52
        ///青岛	53
        ///宁波	54
        ///合肥	55
        ///济南	56
        ///杭州	57
        ///温州	58
        ///福州	59
        ///泉州	60
        ///无锡	62
        ///南通	63
        ///烟台	65
        ///东莞	69
        ///南宁	71
        ///西宁	72
        ///长沙	73
        ///深圳	75
        ///佛山	77
        ///南昌	79
        ///贵阳	85
        ///昆明	87
        ///海口	89
        ///乌鲁木齐	91
        ///厦门	92
        ///兰州	93
        ///香港	97
        ///总行会计部	03
        ///总行	01
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 币种代码	C（2,2）
        ///人民币	10
        ///港币	21
        ///澳元	29
        ///美元	32
        ///欧元	35
        ///加拿大元	39
        ///英镑	43
        ///日元	65
        ///新加坡元	69
        ///挪威克朗	83
        ///丹麦克朗	85
        ///瑞士法郎	87
        ///瑞典克朗	88
        /// </summary>
        public string CCYNBR { get; set; }

        #region NCCRTTRS-到帐通知 NCDBTTRS-付款通知 
        /// <summary>
        /// 帐号	C（35）
        /// </summary>
        public string ACCNBR { get; set; }
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
        /// 凭证类型	C（4）
        /// </summary>
        public string BILTYP { get; set; }
        /// <summary>
        /// 凭证描述	Z（12）
        /// </summary>
        public string BILTXT { get; set; }
        /// <summary>
        /// 凭证号码	C（10）	如凭证类型为支票，该字段为支票号码
        /// </summary>
        public string BILNBR { get; set; }
        /// <summary>
        /// 票据号	C（20）
        /// </summary>
        public string NEWBIL { get; set; }
        /// <summary>
        /// 交易套号	C（15）
        /// </summary>
        public string TRSSET { get; set; }
        /// <summary>
        /// 交易流水号	C（15）	银行会计系统交易流水号
        /// </summary>
        public string SEQNBR { get; set; }
        /// <summary>
        /// 摘要	Z（62）有效长度为16字节。若为企业银行客户端经办的交易，则该字段为用途信息（4.0版代发代扣业务除外），若为其它渠道经办的交易，则该字段为交易的简单说明和注解。
        /// </summary>
        public string NARTXT { get; set; }
        /// <summary>
        /// 收付方帐号分行号	N（2） <see cref="BBKNBR"/>
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
        /// 收付方开户行行号	C（20）联行号
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
        /// 母子帐号分行号	N（2）
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
        /// 母子公司开户行行号	C（20）联行号
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
        /// 业务摘要	Z（200）取值为企业银行客户端经办时录入的摘要字段,其他情况为空
        /// </summary>
        public string BUSNAR { get; set; }
        #endregion

        #region NCDRTPAY-直接支付结果通知
        /// <summary>
        /// 业务数据	C（30）	 暂时不用
        /// </summary>
        public string REQDTA { get; set; }
        /// <summary>
        /// 帐号	C（35）
        /// </summary>
        public string KEYVAL { get; set; }
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
        /// 业务请求结果	C（1）	A.6 业务处理结果 如"成功"、"失败"、"退票"、"经办失败"等
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 业务结果描述	Z（92）
        /// </summary>
        public string RTNDSP { get; set; }
        #endregion

        #region NCBCHOPR-批量支付经办结果通知或批量代理清算经办结果通知
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
        #endregion

        #region NCBUSFIN – 业务完成通知
        /// <summary>
        /// 保留字	C（50）	
        /// </summary>
        public string RSV50Z { get; set; }
        #endregion

        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务类型	C（6）
        /// MSGTYP为NCDRTPAY时：N02031-直接支付；N02041-直接集团支付
        /// MSGTYP为NCBCHOPR时： 当FLWTYP=N09010时表示批量代理清算经办结果通知，否表示批量支付经办结果通知
        /// </summary>
        public string FLWTYP { get; set; }
        /// <summary>
        /// 经办日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? OPRDAT { get; set; }
        /// <summary>
        /// 经办日期	D, 对应<see cref="OPRDAT"/>
        /// </summary>
        [XmlElement("OPRDAT")]
        public string OPRDATStr
        {
            get
            {
                return this.OPRDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.OPRDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 对方参考号	C（30）取值为企业银行客户端经办时录入的参考号，其他情况为空
        /// </summary>
        public string YURREF { get; set; }
    }
}
