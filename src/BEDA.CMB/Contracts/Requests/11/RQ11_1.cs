using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 11.1.代理清算申请经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ11_1 : CMBBase<RQINFO>, IRequest<RS11_1>
    {
        /// <summary>
        /// NTOPRAGP
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRAGP";
        /// <summary>
        /// 11.1.代理清算申请经办请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 11.1.代理清算申请经办请求集合
        /// </summary>
        [XmlElement("NTOPRAGPX1")]
        public List<NTOPRAGPX1> List { get; set; }
    }
    /// <summary>
    /// 11.1.代理清算申请经办请求内容
    /// </summary>
    public class NTOPRAGPX1
    {
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 转出分行号	C(2)
        /// </summary>
        public string DBTBBK { get; set; }
        /// <summary>
        /// 转出帐号	C(35)
        /// </summary>
        public string DBTACC { get; set; }
        /// <summary>
        /// 汇款人账号	C(35)
        /// </summary>
        public string RMTACC { get; set; }
        /// <summary>
        /// 汇款人名称	Z(100)
        /// </summary>
        public string RMTNAM { get; set; }
        /// <summary>
        /// 汇款人地址	Z(100)
        /// </summary>
        public string RMTADR { get; set; }
        /// <summary>
        /// 汇款行名称	Z(62)
        /// </summary>
        public string RMTBNK { get; set; }
        /// <summary>
        /// 收方分行号	C(2)
        /// </summary>
        public string CRTBBK { get; set; }
        /// <summary>
        /// 收方帐号 	C(35)
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
        /// 收方行地址	Z(62)   当收方行是招行时，必须按“**省**市”格式填写，见A.18 城市代码。
        /// </summary>
        public string CRTADR { get; set; }
        /// <summary>
        /// 系统内外标志	C(1)	Y：招行； N：非招行；    BNKFLG为空时，将依据收方开户行CRTBNK进行判断。CRTBNK内容包含“招行”、"招商行"、"招商银行"时，认为是招行内支付；否则认为跨行支付
        /// </summary>
        public string BNKFLG { get; set; }
        /// <summary>
        /// 收方行号	C(30)   填写该字段支持跨行自动支付
        /// </summary>
        public string BRDNBR { get; set; }
        /// <summary>
        /// 交易币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 结算通道	C(1)	N：普通 F：快速
        /// </summary>
        public string STLCHN { get; set; }
        /// <summary>
        /// 费用负担方	C(1)	O=汇出行承担 二代支付修改
        /// </summary>
        public string CHGFOR { get; set; }
        /// <summary>
        /// 期望日	D   默认为当前日期
        /// </summary>
        [XmlIgnore]
        public DateTime? ExpectedTime { get; set; }
        /// <summary>
        /// 期望日	D   空表示当天
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
        /// 银行摘要	Z(100)
        /// </summary>
        public string NUSAGE { get; set; }
        /// <summary>
        /// 客户附言	Z(210)
        /// </summary>
        public string INFTXT { get; set; }
        /// <summary>
        /// 通知方式一	C(40)   移动电话 or email
        /// </summary>
        public string NTFCH1 { get; set; }
        /// <summary>
        /// 通知方式二	C(20)   email
        /// </summary>
        public string NTFCH2 { get; set; }
        /// <summary>
        /// 业务种类	C(6)	100001=普通汇兑 二代支付新增， 默认100001
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 收费方式	C(1)	N: 实时扣收 Y: 批量扣收 二代支付新增，默认为实时扣收
        /// </summary>
        public string FEEMOD { get; set; }
    }
}
