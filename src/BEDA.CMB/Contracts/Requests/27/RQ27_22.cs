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
    /// 27.22.内部计价结息经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ27_22 : CMBBase<RQINFO>, IRequest<RS27_22>
    {
        /// <summary>
        /// NTOPRINT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRINT";
        /// <summary>
        /// 27.22.内部计价结息经办请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
        /// <summary>
        /// 27.22.内部计价结息经办请求内容
        /// </summary>
        public NTOPRINTX1 NTOPRINTX1 { get; set; }
    }
    /// <summary>
    /// 27.22.内部计价结息经办请求内容
    /// </summary>
    public class NTOPRINTX1
    {
        /// <summary>
        /// 产品编号	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 上级账户	C(35)
        /// </summary>
        public string TOPEAC { get; set; }
        /// <summary>
        /// 下级账户	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 结息开始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 结息开始日期	D, 对应<see cref="BEGDAT"/>
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
        /// 结息结束日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 结息结束日期	D, 对应<see cref="ENDDAT"/>
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
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
