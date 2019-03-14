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
    /// 3.8.支付经办（需要网银审批）请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ3_8 : CMBBase<RQINFO>, IRequest<RS3_8>
    {
        /// <summary>
        /// DCPAYREQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "DCPAYREQ";
        /// <summary>
        /// 3.8.支付经办（需要网银审批）请求主体 支付概要
        /// 注意此处只支持 N02030:支付 N02040:集团支付
        /// </summary>
        public SDKPAYRQX SDKPAYRQX { get; set; }
        /// <summary>
        /// 3.8.支付经办（需要网银审批）请求内容  支付明细  
        /// 允许重复次数1~30或者或者 30..1500
        /// 支付条数不超过30条，支付输出有NTQPAYRQZ数据；超过30条，则无
        /// </summary>
        [XmlElement("DCPAYREQX")]
        public List<DCPAYREQX> List { get; set; }
    }
    /// <summary>
    /// 3.8.支付经办（需要网银审批） 支付明细
    /// </summary>
    public class DCPAYREQX
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
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 币种代码	C(2)	附录A.3
        /// 暂时只支持10(人民币)
        /// </summary>
        public string CCYNBR { get; set; } = "10";
        /// <summary>
        /// 结算方式代码	C(1)	N：普通 F：快速
        /// 只对跨行交易有效；同行都是实时到账
        /// </summary>
        public string STLCHN { get; set; }
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
        /// 收方帐户名	Z（62）
        /// 收方帐户名与收方长户名不能同时为空
        /// </summary>
        public string CRTNAM { get; set; }
        /// <summary>
        /// 收方长户名	Z(200)
        /// 收方帐户名与收方长户名不能同时为空
        /// </summary>
        public string LRVEAN { get; set; }
        /// <summary>
        /// 收方行号	C(30)
        /// </summary>
        public string BRDNBR { get; set; }
        /// <summary>
        /// 系统内外标志	 	Y：招行；N：非招行；
        /// </summary>
        public string BNKFLG { get; set; }
        /// <summary>
        /// 收方开户行	Z（62）
        /// 跨行支付（BNKFLG=N）必填
        /// </summary>
        public string CRTBNK { get; set; }
        /// <summary>
        /// 城市代码	C(4)	附录A.18 
        /// 行内支付填写，如果为空跟据收方省份和收方城市自动获取代码
        /// </summary>
        public string CTYCOD { get; set; }
        /// <summary>
        /// 收方省份	Z（18）	附录A.18
        /// 支持省简写，如河南，河北，西藏，新疆，内蒙古，广西，宁夏，青海
        /// </summary>
        public string CRTPVC { get; set; }
        /// <summary>
        /// 收方城市	Z（22）	附录A.18
        /// 支持市简写，如郑州，石家庄，拉萨，呼和浩特，南宁，银川，西宁
        /// </summary>
        public string CRTCTY { get; set; }
        /// <summary>
        /// 收方县/区	Z（22）
        /// 收方帐号开户行所在的县或区，格式为：XX县/区，可为空。如：宝安区。
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
        /// 行内收方账号户名校验	C(1)	1：校验 空或者其他值：不校验
        /// 如果为1，行内收方账号与户名不相符则支付经办失败
        /// </summary>
        public string RCVCHK { get; set; }
        /// <summary>
        /// 保留字段	C(27)
        /// 虚拟户支付时，前10位填虚拟户编号；集团支付不支持虚拟户支付
        /// </summary>
        public string RSVFLD { get; set; }
    }
}
