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
    /// 27.1.多级现金池账户历史余额查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ27_1 : CMBBase<RQINFO>, IRequest<RS27_1>
    {
        /// <summary>
        /// NTMTLHBL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMTLHBL";
        /// <summary>
        /// 27.1.多级现金池账户历史余额查询请求内容
        /// </summary>
        public NTMTLHBLY1 NTMTLHBLY1 { get; set; }
    }
    /// <summary>
    /// 27.1.多级现金池账户历史余额查询请求内容
    /// </summary>
    public class NTMTLHBLY1
    {
        /// <summary>
        /// 分行号	N(2)	附录A.1 
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 下级帐户	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 起始日期	D   日期查询范围不能超过31天
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
        /// 结束日期	D
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
