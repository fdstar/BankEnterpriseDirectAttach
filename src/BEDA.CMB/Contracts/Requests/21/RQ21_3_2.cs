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
    /// 21.3.2.网银借记协议签订经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ21_3_2 : CMBBase<RQINFO>, IRequest<RS21_3_2>
    {
        /// <summary>
        /// NTSGNCBD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSGNCBD";
        /// <summary>
        /// 21.3.2.网银借记协议签订经办请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 21.3.2.网银借记协议签订经办请求内容
        /// </summary>
        public NTSGNCBDX NTSGNCBDX { get; set; }
    }
    /// <summary>
    /// 21.3.2.网银借记协议签订经办请求内容
    /// </summary>
    public class NTSGNCBDX
    {
        /// <summary>
        /// 银行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 我行账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 协议类型       	C(4)    ‘DT01’我行为付款行‘DT02’我行为收款行
        /// </summary>
        public string DBTDIR { get; set; }
        /// <summary>
        /// 付款人联系电话 	C(35)
        /// </summary>
        public string PHNNBR { get; set; }
        /// <summary>
        /// 他行帐户       	C(35)   DT01时必输；DT02时不填
        /// </summary>
        public string OPPACC { get; set; }
        /// <summary>
        /// 他行帐户名     	Z(100)  DT01时必输；DT02时不填
        /// </summary>
        public string OPPANA { get; set; }
        /// <summary>
        /// 他行帐户开户行名	Z(100)  DT01时必输；DT02时不填
        /// </summary>
        public string OPPPNA { get; set; }
        /// <summary>
        /// 付款人账户类型 	C(4)    ‘TL03’  单位银行结算账户  ‘TL04’  个人借记卡或贷记卡
        /// </summary>
        public string ACETYP { get; set; }
        /// <summary>
        /// 他行行号       	C(12)
        /// </summary>
        public string OPPBRD { get; set; }
        /// <summary>
        /// 收款人客户服务号 	C(60)   DT01时必输
        /// </summary>
        public string OPPCST { get; set; }
        /// <summary>
        /// 业务种类 	C(5)
        /// </summary>
        public string PAYCTG { get; set; }
        /// <summary>
        /// 单笔业务金额上限	M   DT01时必输；DT02时不填
        /// </summary>
        public decimal? SGNLMT { get; set; }
        /// <summary>
        /// 日累计业务笔数上限	N    DT01时必输；DT02时不填
        /// </summary>
        public int? DAYCNT { get; set; }
        /// <summary>
        /// 日累计金额上限	M   DT01时必输；DT02时不填
        /// </summary>
        public decimal? DAYLMT { get; set; }
        /// <summary>
        /// 月累计业务笔数上限	N    DT01时必输；DT02时不填
        /// </summary>
        public int? MTHCNT { get; set; }
        /// <summary>
        /// 月累计金额上限	M   DT01时必输；DT02时不填
        /// </summary>
        public decimal? MTHLMT { get; set; }
        /// <summary>
        /// 协议生效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime EFTDAT { get; set; }
        /// <summary>
        /// 协议生效日期	D, 对应<see cref="EFTDAT"/>
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
        /// 协议失效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime IFTDAT { get; set; }
        /// <summary>
        /// 协议失效日期	D, 对应<see cref="IFTDAT"/>
        /// </summary>
        [XmlElement("IFTDAT")]
        public string IFTDATStr
        {
            get
            {
                return this.IFTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.IFTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 签约说明	Z(256)	
        /// </summary>
        public string RMKINF { get; set; }
        /// <summary>
        /// 附件标志	C(1)
        /// </summary>
        public string ATHFLG { get; set; }
    }
}
