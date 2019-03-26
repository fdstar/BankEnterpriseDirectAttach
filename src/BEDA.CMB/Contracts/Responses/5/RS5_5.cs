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
    /// 5.5.查询来证要素信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS5_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTLCBINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLCBINF";
        /// <summary>
        /// 5.5.查询来证要素信息响应集合
        /// </summary>
        [XmlElement("NTLCBINFZ1")]
        public List<NTLCBINFZ1> List { get; set; }
    }
    /// <summary>
    /// 5.5.查询来证要素信息响应内容
    /// </summary>
    public class NTLCBINFZ1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 开证方式	C(2)
        /// </summary>
        public string ISUMOD { get; set; }
        /// <summary>
        /// 信用证类型	C(2)
        /// </summary>
        public string LCCTPY { get; set; }
        /// <summary>
        /// 有效期	D
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
        /// 申请人分行号	C(2)
        /// </summary>
        public string ACCBBK { get; set; }
        /// <summary>
        /// 申请人账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 申请人名称	Z(100)	
        /// </summary>
        public string APPLCT { get; set; }
        /// <summary>
        /// 申请人地址	Z(100)
        /// </summary>
        public string APPADR { get; set; }
        /// <summary>
        /// 申请人邮编	N(6)
        /// </summary>
        public string APPPST { get; set; }
        /// <summary>
        /// 受益人分行号	C(2)
        /// </summary>
        public string BNFBBK { get; set; }
        /// <summary>
        /// 受益人账号	C(35)
        /// </summary>
        public string BNFACC { get; set; }
        /// <summary>
        /// 受益人名称	Z(100)
        /// </summary>
        public string BNFNAM { get; set; }
        /// <summary>
        /// 受益人开户行名称	Z(100)
        /// </summary>
        public string BNFBNK { get; set; }
        /// <summary>
        /// 受益人地址	Z(100)
        /// </summary>
        public string BNFADR { get; set; }
        /// <summary>
        /// 受益人邮编	N(6)
        /// </summary>
        public string BNFPST { get; set; }
        /// <summary>
        /// 通知行名称	Z(100)
        /// </summary>
        public string ADVBNK { get; set; }
        /// <summary>
        /// 通知行地址	Z(100)
        /// </summary>
        public string ADVBAD { get; set; }
        /// <summary>
        /// 通知行分行号	C(3)
        /// </summary>
        public string ADVBBK { get; set; }
        /// <summary>
        /// 通知行网点	C(6)
        /// </summary>
        public string ADVBRN { get; set; }
        /// <summary>
        /// 币种	C(10)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 开证金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 付款期限	C(2)	
        /// ST: AT SIGHT(即期付款)
        /// UP: AT DAYS AFTER SHIPMENT DATE(运输单据日后)
        /// US: AT DAYS AFTER SIGHT(运输单据)
        /// </summary>
        public string DRFTIM { get; set; }
        /// <summary>
        /// 延期方式	C(1)	
        /// 1：运输单据日后，
        /// 2：见单后，
        /// 3：特别指定日期
        /// </summary>
        public string DFRTYP { get; set; }
        /// <summary>
        /// 特别指定日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? SPCDAT { get; set; }
        /// <summary>
        /// 特别指定日期	D, 对应<see cref="SPCDAT"/>
        /// </summary>
        [XmlElement("SPCDAT")]
        public string SPCDATStr
        {
            get
            {
                return this.SPCDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.SPCDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SPCDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 远期天数	N(3)
        /// </summary>
        public int? DRFDAY { get; set; }
        /// <summary>
        /// 分批装运标志	C(1)	Y-ALLOWED；N-NOT ALLOWED
        /// </summary>
        public string PRTSHP { get; set; }
        /// <summary>
        /// 转运标志	C(1)	Y - ALLOWED；N - NOT ALLOWED
        /// </summary>
        public string TRNSHP { get; set; }
        /// <summary>
        /// 装货港或起运地	Z(65)
        /// </summary>
        public string SHPFRM { get; set; }
        /// <summary>
        /// 卸装港或目的地	Z(65)
        /// </summary>
        public string TRNSPT { get; set; }
        /// <summary>
        /// 最迟装运日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime LTTSHP { get; set; }
        /// <summary>
        /// 最迟装运日期	D, 对应<see cref="LTTSHP"/>
        /// </summary>
        [XmlElement("LTTSHP")]
        public string LTTSHPStr
        {
            get
            {
                return this.LTTSHP.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.LTTSHP = tmp;
                }
            }
        }
        /// <summary>
        /// 最迟交单期限	D
        /// </summary>
        [XmlIgnore]
        public DateTime? PRDPRS { get; set; }
        /// <summary>
        /// 最迟交单期限	D, 对应<see cref="PRDPRS"/>
        /// </summary>
        [XmlElement("PRDPRS")]
        public string PRDPRSStr
        {
            get
            {
                return this.PRDPRS?.ToString("yyyyMMdd");
            }
            set
            {
                this.PRDPRS = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PRDPRS = tmp;
                }
            }
        }
        /// <summary>
        /// 保证金账号	C(35)
        /// </summary>
        public string MGLACC { get; set; }
        /// <summary>
        /// 保证金	M
        /// </summary>
        public decimal? MGLAMT { get; set; }
        /// <summary>
        /// 合同编号	C(30)
        /// </summary>
        public string CTRNBR { get; set; }
        /// <summary>
        /// 联系人	C(21)
        /// </summary>
        public string CTTNAM { get; set; }
        /// <summary>
        /// 联系电话	C(26)
        /// </summary>
        public string CTTTEL { get; set; }
        /// <summary>
        /// 信用证号	C(15)
        /// </summary>
        public string LCCNBR { get; set; }
        /// <summary>
        /// 备注	Z(62)
        /// </summary>
        public string NARTXT { get; set; }
        /// <summary>
        /// 单据编号	C(12)
        /// </summary>
        public string IFSNBR { get; set; }
        /// <summary>
        /// 期望日        	D
        /// </summary>
        public string EPTDAT { get; set; }
        /// <summary>
        /// 期望时间      	T
        /// </summary>
        public string EPTTIM { get; set; }
        /// <summary>
        /// 期望时间 由<see cref="EPTDAT"/>和<see cref="EPTTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? ExpectedTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.EPTDAT, this.EPTTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// EMAIL	Z(40)
        /// </summary>
        public string NTFCH1 { get; set; }
        /// <summary>
        /// 手机	Z(20)
        /// </summary>
        public string NTFCH2 { get; set; }
        /// <summary>
        /// 开证行名称	Z(100)
        /// </summary>
        public string OBKADR { get; set; }
        /// <summary>
        /// 开证行邮编	C(6)
        /// </summary>
        public string OBKPST { get; set; }
        /// <summary>
        /// 开证行电话	C(30)	
        /// </summary>
        public string OBKTEL { get; set; }
        /// <summary>
        /// 开证行传真 C(30)
        /// </summary>
        public string OBKFAX { get; set; }
        /// <summary>
        /// 开证行电传	C(30)
        /// </summary>
        public string OBKELC { get; set; }
        /// <summary>
        /// 是否有附件信息	C(1)	‘Y’：有；‘N’：无
        /// </summary>
        public string ATHFLG { get; set; }
        /// <summary>
        /// 密押	C(8)
        /// </summary>
        public string PSTCHK { get; set; }
    }
}
