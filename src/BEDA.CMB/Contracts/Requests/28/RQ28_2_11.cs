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
    /// 28.2.11.大额划拨交易综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ28_2_11 : CMBBase<RQINFO>, IRequest<RS28_2_11>
    {
        /// <summary>
        /// NTQRYGMD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYGMD";
        /// <summary>
        /// 28.2.11.大额划拨交易综合查询请求内容
        /// </summary>
        public NTQRYGMDY1 NTQRYGMDY1 { get; set; }
    }
    /// <summary>
    /// 28.2.11.大额划拨交易综合查询请求内容
    /// </summary>
    public class NTQRYGMDY1
    {
        /// <summary>
        /// 日期类型	C(1)	A：经办日 B：期望日
        /// </summary>
        public string DATFLG { get; set; }
        /// <summary>
        /// 起始日期	D   	开始日期和结束日期间隔不能超过7天，只能查询100天内的业务数据
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
