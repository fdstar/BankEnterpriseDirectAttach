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
    /// 5.1.国内信用证经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ5_1 : CMBBase<RQINFO>, IRequest<RS5_1>
    {
        /// <summary>
        /// DCOPRLCA
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "DCOPRLCA";
        /// <summary>
        /// 5.1.国内信用证经办请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 5.1.国内信用证经办请求集合
        /// </summary>
        [XmlElement("NTOPRLCAX1")]
        public List<NTOPRLCAX1> NTOPRLCAX1List { get; set; }
        /// <summary>
        /// 5.1.国内信用证经办请求集合 货物信息
        /// </summary>
        [XmlElement("DCLCAXMLY")]
        public List<DCLCAXMLY> DCLCAXMLYList { get; set; }
    }
    /// <summary>
    /// 5.1.国内信用证经办请求内容
    /// </summary>
    public class NTOPRLCAX1
    {
        /// <summary>
        /// 业务参考号	C(30)   用于标识该笔业务的编号，企业银行编号+业务类型+业务参考号必须唯一
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 有效期	D   有效期不能早于申请日且在6个月以内
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
        /// 申请人地址	Z(100)
        /// </summary>
        public string APPADR { get; set; }
        /// <summary>
        /// 申请人邮编	N(6)
        /// </summary>
        public string APPPST { get; set; }
        /// <summary>
        /// 受益人账号	C(35)   受益人账户只能是人民币账户
        /// </summary>
        public string BNFACC { get; set; }
        /// <summary>
        /// 受益人名称	Z(70)
        /// </summary>
        public string BNFNAM { get; set; }
        /// <summary>
        /// 受益人开户行名称	Z(100)  填写“招商银行”，默认为“招商银行”
        /// </summary>
        public string BNFBNK { get; set; }
        /// <summary>
        /// 受益人地址	Z(70)   例如：广东省深圳市南山区
        /// </summary>
        public string BNFADR { get; set; }
        /// <summary>
        /// 受益人邮编	N(6)
        /// </summary>
        public string BNFPST { get; set; }
        /// <summary>
        /// 受益人编号	C(20)
        /// </summary>
        public string BNFSQN { get; set; }
        /// <summary>
        /// 开证金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 付款期限	C(2)	ST: 即期  NG: 议付  US: 延期
        /// </summary>
        public string DRFTIM { get; set; }
        /// <summary>
        /// 延期方式	C(1)	1：运输单据日后X天，2：见单后X天，3：特别指定日期 付款期限为议付和延期时必填
        /// </summary>
        public string DFRTYP { get; set; }
        /// <summary>
        /// 特别指定日期	D   DFRTYP=3时必填。不能早于申请日，也不能晚于有效期后6个月
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
        /// 远期天数	N(3)    DFRTYP=1或2时必填。最大值为180天
        /// </summary>
        public int? DRFDAY { get; set; }
        /// <summary>
        /// 分批装运标志	C(1)	Y-ALLOWED； N-NOT ALLOWED
        /// </summary>
        public string PRTSHP { get; set; }
        /// <summary>
        /// 转运标志	C(1)	Y - ALLOWED； N - NOT ALLOWED
        /// </summary>
        public string TRNSHP { get; set; }
        /// <summary>
        /// 装货港或起运地	Z(65)
        /// </summary>
        public string SHPFRM { get; set; }
        /// <summary>
        /// 卸装港或目的地	Z (65)
        /// </summary>
        public string TRNSPT { get; set; }
        /// <summary>
        /// 最迟装运日期	D   不能早于申请日；不能早于期望日；不能晚于有效期
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
        /// 最迟交单期限	D   交单期 小于等于 有效期 且 交单期 大于等于 最迟装运日
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
        /// 保证金	M	默认赋值0   国内信用证 >=0；不能大于开证金额
        /// </summary>
        public decimal? MGLAMT { get; set; }
        /// <summary>
        /// 合同编号	C(30)
        /// </summary>
        public string CTRNBR { get; set; }
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
        /// 期望日	D   默认为当前日期
        /// </summary>
        [XmlIgnore]
        public DateTime? ExpectedTime { get; set; }
        /// <summary>
        /// 期望日	D   默认当前日期
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
        /// 期望时间	T   默认‘000000’
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
        /// EMAIL	C(40)
        /// </summary>
        public string NTFCH1 { get; set; }
        /// <summary>
        /// 手机	C(20)
        /// </summary>
        public string NTFCH2 { get; set; }
    }
    /// <summary>
    /// 5.1.国内信用证经办请求内容 货物信息
    /// </summary>
    public class DCLCAXMLY
    {
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 发票单据	C(1)	Y- 发票注明信用证号码或合同号码；N或空- 不需要
        /// </summary>
        public string INVOICE { get; set; }
        /// <summary>
        /// 海运河运	C(1)	A – 海运 B-河运 空-不需要海河运单据
        /// </summary>
        public string SEA { get; set; }
        /// <summary>
        /// 海运河运单据正本数	N(2)    需要海河运单据时（SEA=A或者B）不能为空
        /// </summary>
        public string LADINGORIGINAL { get; set; }
        /// <summary>
        /// 海运河运单据副本数	N(2)    需要海河运单据时（SEA=A或者B）不能为空
        /// </summary>
        public string LADINGDUPLICATE { get; set; }
        /// <summary>
        /// 海运河运单据收货人	Z(50)    需要海河运单据时（SEA=A或者B）不能为空
        /// </summary>
        public string LADINGCONSIGNEE { get; set; }
        /// <summary>
        /// 海运河运费用	C(1)	Y:已付；N：未付    需要海河运单据时（SEA=A或者B）不能为空
        /// </summary>
        public string LADINGFEE { get; set; }
        /// <summary>
        /// 空运单据收货人	Z(50)	空-不需要空运单据
        /// </summary>
        public string AIR { get; set; }
        /// <summary>
        /// 空运单据费用	C(1)	N- 费用未付 Y-费用已付  需要空运单据时不能为空
        /// </summary>
        public string AIRFEE { get; set; }
        /// <summary>
        /// 铁路公路单据	C(1)	A –铁路 B-公路 空-不需要铁路公路单据
        /// </summary>
        public string RAIL { get; set; }
        /// <summary>
        /// 铁路公路单据收货人	Z(50)  需要铁路公路单据时不能为空
        /// </summary>
        public string RAILCONSIGNEE { get; set; }
        /// <summary>
        /// 铁路公路费用	C(1)	N- 费用未付 Y-费用已付  需要铁路公路单据时不能为空
        /// </summary>
        public string RAILFEE { get; set; }
        /// <summary>
        /// 邮政收据收货人	Z(50)	空表示不需要邮政单据
        /// </summary>
        public string POSTAL { get; set; }
        /// <summary>
        /// 邮政收据正本	N(2)    需要邮政单据时不能为空
        /// </summary>
        public string POSTALANCE { get; set; }
        /// <summary>
        /// 邮政收据副本	N(2)    需要邮政单据时不能为空
        /// </summary>
        public string POSTALDUP { get; set; }
        /// <summary>
        /// 货物收据收货人	Z(50)	空表示不需要货物收据
        /// </summary>
        public string CARGO { get; set; }
        /// <summary>
        /// 货物收据正本	N(2)    需要货物收据时不能为空
        /// </summary>
        public string CARGOANCE { get; set; }
        /// <summary>
        /// 货物收据副本	N(2)    需要货物收据时不能为空
        /// </summary>
        public string CARGODUP { get; set; }
        /// <summary>
        /// 保险单正本	N(2)    空表示不需要保险单据
        /// </summary>
        public string INSURANCE { get; set; }
        /// <summary>
        /// 保险单副本	N(2)    需要保险单据时不能为空
        /// </summary>
        public string INSURDUP { get; set; }
        /// <summary>
        /// 保险金额	M   需要保险单据时不能为空
        /// </summary>
        public decimal? INSURAMT { get; set; }
        /// <summary>
        /// 保险类型	Z(14)   需要保险单据时不能为空
        /// </summary>
        public string INSURTRYE { get; set; }
        /// <summary>
        /// 装箱单数	N(2)
        /// </summary>
        public string ENCASEMENT { get; set; }
        /// <summary>
        /// 其它单据	Z(200)
        /// </summary>
        public string OTHERBILL { get; set; }
        /// <summary>
        /// 单据运输签发日后提交的天数	N(3)
        /// </summary>
        public int? ATDDAYS { get; set; }
        /// <summary>
        /// 货物数量浮动标志	C(1)	不为空则表示浮动
        /// </summary>
        public string CARGOFLAG { get; set; }
        /// <summary>
        /// 信用证金额浮动标志	C(1)	不为空则表示浮动
        /// </summary>
        public string CRTAMTFLAG { get; set; }
        /// <summary>
        /// 货物数量和开证金额向下浮动范围（%）	N(5,2)
        /// 如果CARGOFLAG或CRTAMTFLAG不为空时设置浮动范围。分别设置向上浮动范围UPFLOAT和向下浮动范围ATDFLOAT，或者设置一个上下浮动范围UPDOWNFLOAT。不要两组同时设置
        /// </summary>
        public decimal? ATDFLOAT { get; set; }
        /// <summary>
        /// 货物数量和开证金额向上浮动范围（%）	N(5,2)
        /// 如果CARGOFLAG或CRTAMTFLAG不为空时设置浮动范围。分别设置向上浮动范围UPFLOAT和向下浮动范围ATDFLOAT，或者设置一个上下浮动范围UPDOWNFLOAT。不要两组同时设置
        /// </summary>
        public decimal? UPFLOAT { get; set; }
        /// <summary>
        /// 货物数量和开证金额上下浮动范围（%）	N(5,2)
        /// 如果CARGOFLAG或CRTAMTFLAG不为空时设置浮动范围。分别设置向上浮动范围UPFLOAT和向下浮动范围ATDFLOAT，或者设置一个上下浮动范围UPDOWNFLOAT。不要两组同时设置
        /// </summary>
        public decimal? UPDOWNFLOAT { get; set; }
        /// <summary>
        /// 接受发票金额超过信用证金额标志 	C(1)	Y：接受
        /// </summary>
        public string INVOICEFLAG { get; set; }
        /// <summary>
        /// 备注	Z(6500)
        /// </summary>
        public string NTC { get; set; }
        /// <summary>
        /// 货物描述	Z(6500)
        /// </summary>
        public string GDS { get; set; }
    }
}
