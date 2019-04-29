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
    /// 26.3.单笔开票经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ26_3 : CMBBase<RQINFO>, IRequest<RS26_3>
    {
        /// <summary>
        /// NTECKOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTECKOPR";
        /// <summary>
        /// 26.3.单笔开票经办请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 26.3.单笔开票经办请求内容
        /// </summary>
        public NTECKOPRX NTECKOPRX { get; set; }
        /// <summary>
        /// 26.3.单笔开票经办请求内容
        /// </summary>
        public NTECKRCVX NTECKRCVX { get; set; }
        /// <summary>
        /// 26.3.单笔开票经办请求内容
        /// </summary>
        public NTECKMKTX NTECKMKTX { get; set; }
    }
    /// <summary>
    /// 26.3.单笔开票经办请求内容
    /// </summary>
    public class NTECKOPRX
    {
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 分行号   	C(2)	A.1 招行分行
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号     	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 币种     	C(2)	A.3 货币代码表
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
        /// 授权使用人	C(10)
        /// </summary>
        public string AUTUSR { get; set; }
        /// <summary>
        /// 支票号   	C(10)
        /// </summary>
        public string ECKNBR { get; set; }
        /// <summary>
        /// 虚拟户账号	C（50）   第一位固定为Y，第2到11位为虚拟户账号：如Y1234567890
        /// </summary>
        public string RSV50Z { get; set; }
    }
    /// <summary>
    /// 26.3.单笔开票经办请求内容
    /// </summary>
    public class NTECKRCVX
    {
        /// <summary>
        /// 流水号       	C(10) 
        /// </summary>
        public string SQRNBR { get; set; }
        /// <summary>
        /// 收方账号     	C(35) 
        /// </summary>
        public string RCVACC { get; set; }
        /// <summary>
        /// 收方户名     	Z(122)
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 系统内外标志 	C(1)  	系统内：Y 系统外：N
        /// </summary>
        public string SYSFLG { get; set; }
        /// <summary>
        /// 支付汇路     	C(3)  	CPS/NPS     CPS:他行普通和行内 NPS：他行实时
        /// </summary>
        public string PAYCHN { get; set; }
        /// <summary>
        /// 收方行号     	C(30)   当汇路是NPS时必填
        /// </summary>
        public string CDTBRD { get; set; }
        /// <summary>
        /// 收方行名称   	Z(200)
        /// </summary>
        public string RCVBBK { get; set; }
        /// <summary>
        /// CPS 收方行地址	Z(62)   汇路是CPS并且是系统外时必输 支持省简写，如河南郑州，河北石家庄，北京，重庆
        /// </summary>
        public string BNKADR { get; set; }
        /// <summary>
        /// CPS 结算通道  	C(1)  	F/N     	汇路是CPS时必输 F：快速；N：普通
        /// </summary>
        public string STLCHN { get; set; }
        /// <summary>
        /// CPS 用途       	Z(62)   汇路是CPS时必输
        /// </summary>
        public string NUSAGE { get; set; }
        /// <summary>
        /// NPS 附言       	Z(200)  汇路是NPS时必输
        /// </summary>
        public string BUSNAR { get; set; }
        /// <summary>
        /// 收款人手机    	C(20) 
        /// </summary>
        public string RCVNTF { get; set; }
    }
    /// <summary>
    /// 26.3.单笔开票经办请求内容
    /// </summary>
    public class NTECKMKTX
    {
        /// <summary>
        /// 一事通	C(15)
        /// </summary>
        public string USRNBR { get; set; }
        /// <summary>
        /// 推荐人姓名	Z(62)
        /// </summary>
        public string USRNAM { get; set; }
        /// <summary>
        /// 手机号码	C(20)
        /// </summary>
        public string MBLNBR { get; set; }
        /// <summary>
        /// 一事通2	C(15)
        /// </summary>
        public string USRNB2 { get; set; }
        /// <summary>
        /// 推荐人姓名2	Z(62)
        /// </summary>
        public string USRNA2 { get; set; }
        /// <summary>
        /// 手机号码2	C(20)
        /// </summary>
        public string MBLNB2 { get; set; }
    }
}
