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
    /// 27.23.多级现金池内部计价查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ27_23 : CMBBase<RQINFO>, IRequest<RS27_23>
    {
        /// <summary>
        /// NTMTLINT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMTLINT";
        /// <summary>
        /// 27.23.多级现金池内部计价查询请求内容
        /// </summary>
        public NTMTLINTY1 NTMTLINTY1 { get; set; }
    }
    /// <summary>
    /// 27.23.多级现金池内部计价查询请求内容
    /// </summary>
    public class NTMTLINTY1
    {
        /// <summary>
        /// 多级产品编号	C(8)
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
    }
}
