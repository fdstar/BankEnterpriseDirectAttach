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
    /// 20.3.联动支付经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ20_3 : CMBBase<RQINFO>, IRequest<RS20_3>
    {
        /// <summary>
        /// NTOPRLKP
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRLKP";
        /// <summary>
        /// 20.3.联动支付经办请求内容
        /// 只需 BUSMOD 和 MODALS ，且两个参数不能同时为空，必须填一个。（如果两者都不为空以BUSMOD为准）
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
        /// <summary>
        /// 20.3.联动支付经办请求内容
        /// </summary>
        public NTOPRLKPX1 NTOPRLKPX1 { get; set; }
    }
    /// <summary>
    /// 20.3.联动支付经办请求内容
    /// </summary>
    public class NTOPRLKPX1
    {
        /// <summary>
        /// 流水号	C(10)
        /// </summary>
        public string SQRNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 付方分行号	C(2)	A.1 招行分行
        /// </summary>
        public string DBTBBK { get; set; }
        /// <summary>
        /// 付方账号	C(35)
        /// </summary>
        public string DBTACC { get; set; }
        /// <summary>
        /// 授权账号	C(35)
        /// </summary>
        public string AUTEAC { get; set; }
        /// <summary>
        /// 收方帐号	C(35)
        /// </summary>
        public string CRTACC { get; set; }
        /// <summary>
        /// 收方户名	Z(62)
        /// </summary>
        public string CRTNAM { get; set; }
        /// <summary>
        /// 收方行地址	Z(62)
        /// </summary>
        public string CRTADR { get; set; }
        /// <summary>
        /// 收方行名称	Z(62)   行内标志为“Y”且收方行名称为空时赋值为“招商银行”
        /// </summary>
        public string CRTBNK { get; set; }
        /// <summary>
        /// 行内标志	C(1)	跨行交易为“N”，同行交易为“Y”   默认赋值为“Y”
        /// </summary>
        public string BNKFLG { get; set; }
        /// <summary>
        /// 收方大额行号	C(20)
        /// </summary>
        public string RCVBRD { get; set; }
        /// <summary>
        /// 行号类型	C(3)
        /// </summary>
        public string BRDTYP { get; set; }
        /// <summary>
        /// 币种	C(2)	10：人民币
        /// </summary>
        public string CCNBR { get; set; } = "10";
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 结算通道	C(1)	N：普通 F：快速
        /// 只对跨行交易有效；同行都是实时到账。默认为N
        /// </summary>
        public string STLCHN { get; set; }
        /// <summary>
        /// 用途	Z(62)
        /// </summary>
        public string NUSAGE { get; set; }
        /// <summary>
        /// 业务摘要	Z(200)
        /// </summary>
        public string BUSNAR { get; set; }
        /// <summary>
        /// 收方电子邮件	C(40)
        /// </summary>
        public string NTFCH1 { get; set; }
        /// <summary>
        /// 收方移动电话	C(20)
        /// </summary>
        public string NTFCH2 { get; set; }
        /// <summary>
        /// 业务种类	C(6)	100001=普通汇兑 101001=慈善捐款 101002 =其他  默认100001
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 期望日	D   默认为当前日期
        /// </summary>
        [XmlIgnore]
        public DateTime? ExpectedTime { get; set; }
        /// <summary>
        /// 期望日	D   为空时赋值为当天日期
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
        /// 期望时间	T   为空时赋值为000000
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
    }
}
