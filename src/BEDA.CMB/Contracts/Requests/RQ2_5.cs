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
    /// 2.5.查询账户历史余额请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ2_5 : CMBBase<RQINFO>, IRequest<RS2_5>
    {
        /// <summary>
        /// SDKNTQABINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTQABINF";
        /// <summary>
        /// 2.5.查询账户历史余额请求内容
        /// </summary>
        public NTQABINFY NTQABINFY { get; set; }
    }
    /// <summary>
    /// 2.5.查询账户历史余额请求内容
    /// </summary>
    public class NTQABINFY
    {
        /// <summary>
        /// 分行号	N(2)	附录A.1 
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(1,35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 起始日期	D   开始日期与结束日期的间隔不能超过31天
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 起始日期	D, 对应<see cref="BGNDAT"/>
        /// </summary>
        [XmlElement("BGNDAT")]
        public string BGNDATStr
        {
            get
            {
                return this.BGNDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BGNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 结束日期	D   开始日期和结束日期必须早于当日
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 结束日期	D, 对应<see cref="ENDDAT"/>
        /// </summary>
        [XmlElement("ENDDAT")]
        public string ENDDATStr
        {
            get
            {
                return this.ENDDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDAT = tmp;
                }
            }
        }
    }
}
