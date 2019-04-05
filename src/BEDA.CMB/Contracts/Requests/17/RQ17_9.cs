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
    /// 17.9.查询虚拟户历史交易请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_9 : CMBBase<RQINFO>, IRequest<RS17_9>
    {
        /// <summary>
        /// NTDMTHLS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMTHLS";
        /// <summary>
        /// 17.9.查询虚拟户历史交易请求内容
        /// </summary>
        public NTDMTHLSY NTDMTHLSY { get; set; }
    }
    /// <summary>
    /// 17.9.查询虚拟户历史交易请求内容
    /// </summary>
    public class NTDMTHLSY
    {
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)   填空表示查询该账号下所有虚拟户信息（包括默认虚拟户）
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 起始日期	D   只能查询近 13 个月的历史交易
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 起始日期	D, 对应<see cref="BEGDAT"/>
        /// </summary>
        [XmlElement("BEGDAT")]
        public string BEGDATStr
        {
            get
            {
                return this.BEGDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BEGDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 结束日期	D   小于当天，大于或等于起始日期，与起始日期相距100天内
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
