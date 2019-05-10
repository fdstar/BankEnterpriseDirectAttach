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
    /// 32.1.国际信用证开证经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ32_1 : CMBBase<RQINFO>, IRequest<RS32_1>
    {
        /// <summary>
        /// NTOPRLCB
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRLCB";
        /// <summary>
        /// 32.1.国际信用证开证经办请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 32.1.国际信用证开证经办请求内容
        /// </summary>
        public NTOPRLCBX1 NTOPRLCAX1 { get; set; }
    }
    /// <summary>
    /// 32.1.国际信用证开证经办请求内容
    /// </summary>
    public class NTOPRLCBX1
    {
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 开证方式	C(2)    TL: BY TELETRANSMISSION BT: BY BRIEF TELETRANSMISSION ML: BY AIRMAIL
        /// </summary>
        public string ISUMOD { get; set; }
        /// <summary>
        /// 开证网点	C(6)
        /// </summary>
        public string APPBRN { get; set; }
        /// <summary>
        /// 有效期	D   最迟装运日不能晚于有效期
        /// </summary>
        [XmlIgnore]
        public DateTime EPRDAT { get; set; }
        /// <summary>
        /// 有效期	D, 对应<see cref="EPRDAT"/>
        /// </summary>
        [XmlElement("EPRDAT")]
        public string EPRDATStr
        {
            get
            {
                return this.EPRDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EPRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 有效地点	Z(29)
        /// </summary>
        public string PLCPST { get; set; }
        /// <summary>
        /// 申请人分行号	C(2)	附录A.1
        /// </summary>
        public string ACCBBK { get; set; }
        /// <summary>
        /// 申请人账号	C(35)	填写10位申请人客户号
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 受益人名称	Z(70)   受益人姓名和地址总长度不能超过１４0
        /// </summary>
        public string BNFNAM { get; set; }
        /// <summary>
        /// 受益人地址	Z(70)   受益人姓名和地址总长度不能超过１４0
        /// </summary>
        public string BNFADR { get; set; }
        /// <summary>
        /// 受益人国家代码	C(3)	附录A.6
        /// </summary>
        public string BNFCNR { get; set; }
        /// <summary>
        /// 通知行SWIFT 银行代码	Z(11)   通知行名称、地址、ＳＷＩＦ银行代码 总长度不能超过１３８个字符
        /// </summary>
        public string ADVBID { get; set; }
        /// <summary>
        /// 通知行名称	Z(70)   通知行名称、地址、ＳＷＩＦ银行代码 总长度不能超过１３８个字符
        /// </summary>
        public string ADVBNK { get; set; }
        /// <summary>
        /// 通知行地址	Z(70)   通知行名称、地址、ＳＷＩＦ银行代码 总长度不能超过１３８个字符
        /// </summary>
        public string ADVBAD { get; set; }
        /// <summary>
        /// 币种	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 开证金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 可承兑银行	Z(140)  建议填写：ANY BANK
        /// </summary>
        public string AVLBNK { get; set; }
        /// <summary>
        /// 兑付方式	C(2)    DP：DEF. PAYMENT NG：NEGOTIATION AC：ACCEPTANCE OF DRAFTS SP：PAYMENT
        /// </summary>
        public string AVLTYP { get; set; }
        /// <summary>
        /// 付款期限	C(2)	AT：AT ST：AT SIGHT   根据兑付方式的不同付款期限的可选值不同。AVLTYP= SP时 DRFTIM=ST；AVLTYP= NG时DRFTIM可选所有值；AVLTYP= DP或者AC, DRFTIM可选AT
        /// </summary>
        public string DRFTIM { get; set; }
        /// <summary>
        /// 期限描述	Z(60)   如果付款期限 (DRFTIM==AT)则期限描述不能为空；如果付款期限 (DRFTIM==ST)则期限描述为空
        /// </summary>
        public string DRFDSC { get; set; }
        /// <summary>
        /// Drawn on（出票行）	Z(140)	建议填写：ISSUING BANK
        /// </summary>
        public string DRWBNK { get; set; }
        /// <summary>
        /// 汇票占比	C(3)	建议填写：100 范围（0-100）
        /// </summary>
        public int IVCPER { get; set; }
        /// <summary>
        /// 分批装运标志	C(1)	Y-ALLOWED； N-NOT ALLOWED
        /// </summary>
        public string PRTSHP { get; set; }
        /// <summary>
        /// 转运标志	C(1)	Y - ALLOWED； N - NOT ALLOWED
        /// </summary>
        public string TRNSHP { get; set; }
        /// <summary>
        /// 可转让标志	C(1)	Y：TRANSFERABLE； N：NOT TRANSFERABLE	
        /// </summary>
        public string TRNFRB { get; set; }
        /// <summary>
        /// 信用证保兑标志	C(1)	Y：REQUESTED； N：AUTHORISED IF REQUESTED BY BENEFICIARY
        /// </summary>
        public string CONFMT { get; set; }
        /// <summary>
        /// 装货港或起运地	Z(65)
        /// </summary>
        public string SHPFRM { get; set; }
        /// <summary>
        /// 转运地	Z(65)
        /// </summary>
        public string TRNATO { get; set; }
        /// <summary>
        /// 卸装港或目的地	Z (65)
        /// </summary>
        public string TRNSPT { get; set; }
        /// <summary>
        /// 最迟装运日期	D   有最迟交单期(PRDPRS)时最迟装运日期不能为空；且最迟装运日期必须在有效期(EPRDAT)之前。
        /// </summary>
        [XmlIgnore]
        public DateTime? LTTSHP { get; set; }
        /// <summary>
        /// 最迟装运日期	D, 对应<see cref="LTTSHP"/>
        /// </summary>
        [XmlElement("LTTSHP")]
        public string LTTSHPStr
        {
            get
            {
                return this.LTTSHP?.ToString("yyyyMMdd");
            }
            set
            {
                this.LTTSHP = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.LTTSHP = tmp;
                }
            }
        }
        /// <summary>
        /// 最迟交单期限	C(3)	建议填写：21 最迟交单期限PRDPRS和交单期日期类型DRFTYP必须同时有值或者同时为空
        /// </summary>
        public string PRDPRS { get; set; }
        /// <summary>
        /// 付款账号	C(35)
        /// </summary>
        public string DBTACC { get; set; }
        /// <summary>
        /// 合同编号	C(30)
        /// </summary>
        public string CTRNBR { get; set; }
        /// <summary>
        /// 合同币种	C(2)	附录A.3
        /// </summary>
        public string CTRCCY { get; set; }
        /// <summary>
        /// 合同金额	M
        /// </summary>
        public decimal CTRAMT { get; set; }
        /// <summary>
        /// 联系人	Z(25)
        /// </summary>
        public string CTTNAM { get; set; }
        /// <summary>
        /// 联系电话	C(30)
        /// </summary>
        public string CTTTEL { get; set; }
        /// <summary>
        /// 授信编号	C(25)
        /// </summary>
        public string FCLNBR { get; set; }
        /// <summary>
        /// EMAIL	C(40)
        /// </summary>
        public string NTFCH1 { get; set; }
        /// <summary>
        /// 手机	C(20)
        /// </summary>
        public string NTFCH2 { get; set; }
        /// <summary>
        /// 是否要汇票	C(1)	Y/N
        /// </summary>
        public string DRFFLG { get; set; }
        /// <summary>
        /// 利息基点	C(4)
        /// </summary>
        public string INTPNT { get; set; }
        /// <summary>
        /// 承担方	Z(20)	建议值：BENEFICIARY
        /// </summary>
        public string FEECHG { get; set; }
        /// <summary>
        /// 交单期日期类型	Z(20)	建议值：SHIPMENT    	最迟交单期限PRDPRS和交单期日期类型DRFTYP必须同时有值或者同时为空
        /// </summary>
        public string DRFTYP { get; set; }
        /// <summary>
        /// 离岸标志	C(1)	‘N’在岸，‘Y’离岸 离岸‘Y’时利息率INTRAT和罚息率PSHRAT必输
        /// </summary>
        public string OSAFLG { get; set; }
        /// <summary>
        /// 利息率	C(20)
        /// </summary>
        public string INTRAT { get; set; }
        /// <summary>
        /// 罚息率	C(20)
        /// </summary>
        public string PSHRAT { get; set; }
    }
}
