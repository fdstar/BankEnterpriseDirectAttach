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
    /// 32.4.国际信用证修改申请经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ32_4 : CMBBase<RQINFO>, IRequest<RS32_4>
    {
        /// <summary>
        /// NTOPRMDG
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRMDG";
        /// <summary>
        /// 32.4.国际信用证修改申请经办请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 32.4.国际信用证修改申请经办请求内容
        /// </summary>
        public NTOPRMDFX1 NTOPRMDFX1 { get; set; }
    }
    /// <summary>
    /// 32.4.国际信用证修改申请经办请求内容
    /// </summary>
    public class NTOPRMDFX1
    {
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 信用证号   	C(15)
        /// </summary>
        public string LCCNBR { get; set; }
        /// <summary>
        /// 修改模式   	C(1)	S：SWIFT T：TELEX
        /// </summary>
        public string AMDMOD { get; set; }
        /// <summary>
        /// 开证网点	C(6)
        /// </summary>
        public string APPBRN { get; set; }
        /// <summary>
        /// 授信编号	C(25)
        /// </summary>
        public string FCLNBR { get; set; }
        /// <summary>
        /// 申请人分行号	C(2)	附录A.1
        /// </summary>
        public string ACCBBK { get; set; }
        /// <summary>
        /// 申请人账号	C(35)	填写10位申请人客户号
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 币种	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 初始金额   	M
        /// </summary>
        public decimal ORIAMT { get; set; }
        /// <summary>
        /// 变更后金额 	M   变更后金额必须 >= 初始金额
        /// </summary>
        public decimal? TRSAMT { get; set; }
        /// <summary>
        /// 最迟装运日期	D   最迟装运日期应早于或等于有效期 最迟装运日期应早于或等于有效期
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
        /// 有效期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? EPRDAT { get; set; }
        /// <summary>
        /// 有效期	D, 对应<see cref="EPRDAT"/>
        /// </summary>
        [XmlElement("EPRDAT")]
        public string EPRDATStr
        {
            get
            {
                return this.EPRDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.EPRDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EPRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 扣费账号	C(12)   扣费账号的分行号同申请人分行号 当FEECNT=1 时，扣费帐号必输 当FEECNT=2时，扣费帐号不能有值
        /// </summary>
        public string DBTACC { get; set; }
        /// <summary>
        /// 联系人	Z(25)
        /// </summary>
        public string CTTNAM { get; set; }
        /// <summary>
        /// 联系电话	C(30)
        /// </summary>
        public string CTTTEL { get; set; }
        /// <summary>
        /// 费用条款	C(6)	1-请从我司账号扣付 2-由受益人负担，将在付款时扣除 当是’1’ 时，扣费帐号必输
        /// </summary>
        public string FEECNT { get; set; }
        /// <summary>
        /// 离岸标志	C(1)	‘N’在岸，‘Y’离岸
        /// </summary>
        public string OSAFLG { get; set; }
    }
}
