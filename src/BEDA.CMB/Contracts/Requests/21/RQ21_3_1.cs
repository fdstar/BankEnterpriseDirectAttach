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
    /// 21.3.1.网银贷记协议签订经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ21_3_1 : CMBBase<RQINFO>, IRequest<RS21_3_1>
    {
        /// <summary>
        /// NTSGNCBC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSGNCBC";
        /// <summary>
        /// 21.3.1.网银贷记协议签订经办请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 21.3.1.网银贷记协议签订经办请求内容
        /// </summary>
        public NTSGNCBCX NTSGNCBCX { get; set; }
    }
    /// <summary>
    /// 21.3.1.网银贷记协议签订经办请求内容
    /// </summary>
    public class NTSGNCBCX
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
        /// 联系电话	C(35)
        /// </summary>
        public string PYETEL { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 单笔业务金额上限	M   不输表示无单笔金额限制
        /// </summary>
        public decimal? SGNLMT { get; set; }
        /// <summary>
        /// 日累计业务笔数上限	N(8)    不输表示无日累计业务笔数限制
        /// </summary>
        public int? DAYCNT { get; set; }
        /// <summary>
        /// 日累计金额上限	N(15)   不输表示无日累计金额上限限制
        /// </summary>
        public decimal? DAYLMT { get; set; }
        /// <summary>
        /// 月累计业务笔数上限	N(8)    不输无月累计业务笔数上限限制
        /// </summary>
        public int? MTHCNT { get; set; }
        /// <summary>
        /// 月累计金额上限	N(15)   不输表示无月累计金额上限
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
        /// 协议失效日期	D   如果不填写则表示协议永久有效
        /// </summary>
        [XmlIgnore]
        public DateTime? IFTDAT { get; set; }
        /// <summary>
        /// 协议失效日期	D, 对应<see cref="IFTDAT"/>
        /// </summary>
        [XmlElement("IFTDAT")]
        public string IFTDATStr
        {
            get
            {
                return this.IFTDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.IFTDAT = null;
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
    }
}
