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
    /// 26.4.批量开票经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ26_4 : CMBBase<RQINFO>, IRequest<RS26_4>
    {
        /// <summary>
        /// NTECKMOP
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTECKMOP";
        /// <summary>
        /// 26.4.批量开票经办请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 26.4.批量开票经办请求集合
        /// </summary>
        [XmlElement("NTECKMOPX")]
        public List<NTECKMOPX> List { get; set; }
        /// <summary>
        /// 26.4.批量开票经办请求内容
        /// </summary>
        public NTECKMKTX NTECKMKTX { get; set; }
    }
    /// <summary>
    /// 26.4.批量开票经办请求内容
    /// </summary>
    public class NTECKMOPX
    {
        /// <summary>
        /// 流水号       	C(10) 
        /// </summary>
        public string SQRNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 分行号   	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号     	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 币种     	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 金额上限 	C(15)
        /// </summary>
        public decimal MAXAMT { get; set; }
        /// <summary>
        /// 生效日期 	C(8)
        /// </summary>
        [XmlIgnore]
        public DateTime EFTDAT { get; set; }
        /// <summary>
        /// 生效日期 	C(8), 对应<see cref="EFTDAT"/>
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
        /// 失效日期 	C(8)
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 失效日期 	C(8), 对应<see cref="EXPDAT"/>
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
        /// <summary>
        /// 托收日期 	C(8)
        /// </summary>
        [XmlIgnore]
        public DateTime ADDDAT { get; set; }
        /// <summary>
        /// 托收日期 	C(8), 对应<see cref="ADDDAT"/>
        /// </summary>
        [XmlElement("ADDDAT")]
        public string ADDDATStr
        {
            get
            {
                return this.ADDDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ADDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 授权使用人	C(10)   输入用户登录名
        /// </summary>
        public string AUTUSR { get; set; }
        /// <summary>
        /// 是否指定收方 	C(1)    Y/N
        /// </summary>
        public string RCVFLG { get; set; }
        /// <summary>
        /// 收方账号     	C(35)   若指定收方，则必填
        /// </summary>
        public string RCVACC { get; set; }
        /// <summary>
        /// 收方户名     	Z(122)  若指定收方，则必填
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 系统内外标志 	C(1) 	Y/N     若指定收方，则必填
        /// </summary>
        public string SYSFLG { get; set; }
        /// <summary>
        /// 支付汇路     	C(3) 	CPS/NPS     若指定收方，则必填
        /// </summary>
        public string PAYCHN { get; set; }
        /// <summary>
        /// 收方行号     	C(30)   若指定收方，并且汇路是NPS，则必填
        /// </summary>
        public string CDTBRD { get; set; }
        /// <summary>
        /// 收方行名称   	Z(200)  	若指定收方，则必填
        /// </summary>
        public string RCVBBK { get; set; }
        /// <summary>
        /// CPS 收方行地址	Z(62)   若指定收方，且汇路为CPS+系统外则必填
        /// </summary>
        public string BNKADR { get; set; }
        /// <summary>
        /// CPS 结算通道  	C(1) 	F/N 若指定收方，且汇路为CPS则必填
        /// </summary>
        public string STLCHN { get; set; }
        /// <summary>
        /// CPS 用途       	Z(62)
        /// </summary>
        public string NUSAGE { get; set; }
        /// <summary>
        /// NPS 附言       	Z(200)
        /// </summary>
        public string BUSNAR { get; set; }
        /// <summary>
        /// 收款人手机    	C(20) 
        /// </summary>
        public string RCVNTF { get; set; }
    }
}
