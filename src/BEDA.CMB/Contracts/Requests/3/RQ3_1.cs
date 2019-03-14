using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 3.1.支付、3.2.内部转账请求主体
    /// 新用户或者用户升级，请使用3.6直接支付接口做直接支付和直接集团支付，请使用3.7直接内转做内部转账
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    [Obsolete("新用户或用户升级请使用3.6直接支付、3.7.直接内转、3.8.支付经办")]
    public class RQ3_1 : CMBBase<RQINFO>, IRequest<RS3_1>
    {
        /// <summary>
        /// Payment
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "Payment";
        /// <summary>
        /// 3.1.支付请求内容 支付概要
        /// </summary>
        public SDKPAYRQX SDKPAYRQX { get; set; }
        /// <summary>
        /// 3.1.支付请求内容  支付明细  
        /// 批量内转最大笔数为30
        /// 非批量内转时重复次数1~30或者或者 30..1500
        /// 支付条数不超过30条，支付输出有NTQPAYRQZ数据；超过30条，则无
        /// </summary>
        [XmlElement("SDKPAYDTX")]
        public List<SDKPAYDTX> List { get; set; }
    }
    /// <summary>
    /// 3.1.支付请求内容 支付概要
    /// </summary>
    public class SDKPAYRQX
    {
        /// <summary>
        /// 业务类别	C(6)	
        /// N02020:内部转帐 批量内转最大笔数为30
        /// N02030:支付
        /// N02031:直接支付
        /// N02040:集团支付
        /// N02041:直接集团支付
        /// 直接集团支付是指使用子公司账号付款,总公司账号联动下划资金的支付
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式编号	C(5)
        /// 直接支付和直接集团支付默认为00001；
        /// 业务模式编号和业务模式名称不能同时为空；
        /// 业务模式编号和业务模式名称同时有值时业务模式编号有效；
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 业务模式名称	
        /// 可经办的业务模式，可通过查询可经办的业务模式信息（ListMode）获得，也可以在通过前置机程序查询获得
        /// </summary>
        public string MODALS { get; set; }
    }
    /// <summary>
    /// 3.1.支付请求内容 支付明细
    /// </summary>
    public class SDKPAYDTX
    {
        /// <summary>
        /// 业务参考号	C（30）
        /// 用于标识该笔业务的编号，企业银行编号+业务类型+业务参考号必须唯一。企业可以自定义业务参考号，也可使用银行缺省值（单笔支付），批量支付须由企业提供。 直联必须用企业提供
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 期望日	D   默认为当前日期
        /// </summary>
        [XmlIgnore]
        public DateTime? ExpectedTime { get; set; }
        /// <summary>
        /// 期望日	D
        /// </summary>
        [XmlElement("EPTDAT")]
        public string EPTDATStr
        {
            get
            {
                return this.ExpectedTime?.ToString("yyyyMMdd");
            }
            set { }
        }
        /// <summary>
        /// 期望时间	T   默认为‘000000’
        /// </summary>
        [XmlElement("EPTTIM")]
        public string EPTTIMStr
        {
            get
            {
                return this.ExpectedTime?.ToString("HHmmss");
            }
            set { }
        }
        /// <summary>
        /// 付方帐号	N（35）	
        /// 企业用于付款的转出帐号，该帐号的币种类型必须与币种字段相符
        /// </summary>
        public string DBTACC { get; set; }
        /// <summary>
        /// 付方开户地区代码	C（2）	附录A.1
        /// </summary>
        public string DBTBBK { get; set; }
        /// <summary>
        /// 付方开户地区	Z（12）	附录A.1
        /// 付方帐号的开户行所在地区，如北京、上海、深圳等。 付方开户地区和付方开户地区代码不能同时为空，同时有值时DBTBBK有效。
        /// </summary>
        public string C_DBTBBK { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 币种代码	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 币种名称	Z（10）	附录A.3
        /// 币种代码和币种名称不能同时为空同时有值时CCYNBR有效。。币种暂时只支持10-人民币
        /// </summary>
        public string C_CCYNBR { get; set; }
        /// <summary>
        /// 结算方式代码	C(1)	N：普通 F：快速
        /// </summary>
        public string STLCHN { get; set; }
        /// <summary>
        /// 结算方式	Z（12）	快速 | 普通
        /// 只对跨行交易有效；同行都是实时到账。 结算方式和结算方式代码不能同时为空，同时有值时STLCHN有效
        /// </summary>
        public string C_STLCHN { get; set; }
        /// <summary>
        /// 用途	Z（62）   对应对账单中的摘要NARTXT
        /// </summary>
        public string NUSAGE { get; set; }
        /// <summary>
        /// 业务摘要	Z（200）用于企业付款时填写说明或者备注
        /// </summary>
        public string BUSNAR { get; set; }
        /// <summary>
        /// 收方帐号	N（35）
        /// 收款企业的转入帐号，该帐号的币种类型必须与币种字段相符
        /// </summary>
        public string CRTACC { get; set; }
        /// <summary>
        /// 收方开户地区代码	C（2）	附录A.1
        /// 此为内部转账专用 开户地区代码与名称不能同时为空
        /// </summary>
        public string CRTBBK { get; set; }
        /// <summary>
        /// 收方开户地区名称	Z（12）	附录A.1
        /// 此为内部转账专用 开户地区代码与名称不能同时为空
        /// </summary>
        public string C_CRTBBK { get; set; }
        /// <summary>
        /// 收方帐户名	Z（62）
        /// </summary>
        public string CRTNAM { get; set; }
        /// <summary>
        /// 收方行号	C(30)
        /// </summary>
        public string BRDNBR { get; set; }
        /// <summary>
        /// 系统内外标志	 	Y：招行；N：非招行；
        /// BNKFLG为空时，将依据收方开户行CRTBNK进行判断。CRTBNK内容包含“招行”、"招商行"、"招商银行"时，认为是招行内支付；否则认为跨行支付
        /// </summary>
        public string BNKFLG { get; set; }
        /// <summary>
        /// 收方开户行	Z（62）
        /// </summary>
        public string CRTBNK { get; set; }
        /// <summary>
        /// 城市代码	C(4)	附录A.18
        /// 行内支付填写，如果为空跟据收方省份和收方城市自动获取代码
        /// </summary>
        public string CTYCOD { get; set; }
        /// <summary>
        /// 收方省份	Z（16）	附录A.18
        /// 支持省简写，如河南，河北，西藏，新疆，内蒙古，广西，宁夏，青海
        /// </summary>
        public string CRTPVC { get; set; }
        /// <summary>
        /// 收方城市	Z（20）	附录A.18
        /// 支持市简写，如郑州，石家庄，拉萨，呼和浩特，南宁，银川，西宁
        /// </summary>
        public string CRTCTY { get; set; }
        /// <summary>
        /// 收方县/区	Z（20）
        /// 收方帐号开户行所在的县或区，格式为：XX县/区，可为空。如：宝安区
        /// </summary>
        public string CRTDTR { get; set; }
        /// <summary>
        /// 收方电子邮件	C（36）
        /// 收款方的电子邮件地址，用于交易 成功后邮件通知
        /// </summary>
        public string NTFCH1 { get; set; }
        /// <summary>
        /// 收方移动电话	C（16）
        /// 收款方的移动电话，用于交易 成功后短信通知
        /// </summary>
        public string NTFCH2 { get; set; }
        /// <summary>
        /// 收方编号	C（20）
        /// 用于标识收款方的编号。非受限收方模式下可重复
        /// </summary>
        public string CRTSQN { get; set; }
        /// <summary>
        /// 业务种类	C(6)	默认100001
        /// 100001=普通汇兑 101001=慈善捐款 101002 =其他
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 保留字段	C(29)
        /// 虚拟户支付时，前10位填虚拟户编号；集团支付不支持虚拟户支付
        /// </summary>
        public string RSV29Z { get; set; }
    }
}
