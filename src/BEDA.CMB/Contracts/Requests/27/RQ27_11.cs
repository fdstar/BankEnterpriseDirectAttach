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
    /// 27.11.子账户内部户限额查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ27_11 : CMBBase<RQINFO>, IRequest<RS27_11>
    {
        /// <summary>
        /// NTILMQR2
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTILMQR2";
        /// <summary>
        /// 27.11.子账户内部户限额查询请求内容
        /// </summary>
        public NTILMQR2X1 NTILMQR2X1 { get; set; }
    }
    /// <summary>
    /// 27.11.子账户内部户限额查询请求内容
    /// </summary>
    public class NTILMQR2X1
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 下级账号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 生效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? BEGDAT { get; set; }
        /// <summary>
        /// 生效日期	D, 对应<see cref="BEGDAT"/>
        /// </summary>
        [XmlElement("BEGDAT")]
        public string BEGDATStr
        {
            get
            {
                return this.BEGDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.BEGDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BEGDAT = tmp;
                }
            }
        }
    }
}
