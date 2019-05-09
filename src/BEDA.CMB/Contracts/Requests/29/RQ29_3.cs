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
    /// 29.3.商户清分处理综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ29_3 : CMBBase<RQINFO>, IRequest<RS29_3>
    {
        /// <summary>
        /// NTSTMQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSTMQRY";
        /// <summary>
        /// 29.3.商户清分处理综合查询请求内容
        /// </summary>
        public NTSTMQRYY1 NTSTMQRYY1 { get; set; }
    }
    /// <summary>
    /// 29.3.商户清分处理综合查询请求内容
    /// </summary>
    public class NTSTMQRYY1
    {
        /// <summary>
        /// 业务模式	C(5) 
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 起始日期	D
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
