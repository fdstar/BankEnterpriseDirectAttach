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
    /// 12.5.4.汇入汇款综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_5_4 : CMBBase<RQINFO>, IRequest<RS12_5_4>
    {
        /// <summary>
        /// NTJZPQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTJZPQRY";
        /// <summary>
        /// 12.5.4.汇入汇款综合查询请求内容
        /// </summary>
        public NTJZPQRYY NTJZPQRYY { get; set; }
    }
    /// <summary>
    /// 12.5.4.汇入汇款综合查询请求内容
    /// </summary>
    public class NTJZPQRYY
    {
        /// <summary>
        /// 业务代码	C(6)   固定为N07111
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 开始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 开始日期	D, 对应<see cref="BGNDAT"/>
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
        /// <summary>
        /// 金额底限	M
        /// </summary>
        public decimal? MINAMT { get; set; }
        /// <summary>
        /// 金额上线	M
        /// </summary>
        public decimal? MAXAMT { get; set; }
    }
}
