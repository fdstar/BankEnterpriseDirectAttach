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
    /// 28.1.4.综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ28_1_4 : CMBBase<RQINFO>, IRequest<RS28_1_4>
    {
        /// <summary>
        /// NTDMAQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMAQRY";
        /// <summary>
        /// 28.1.4.综合查询请求内容
        /// </summary>
        public NTDMAQRYY1 NTDMAQRYY1 { get; set; }
    }
    /// <summary>
    /// 28.1.4.综合查询请求内容
    /// </summary>
    public class NTDMAQRYY1
    {
        /// <summary>
        /// 业务模式	C(6)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 开始日期	D   查询日期范围不能超过7天
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 开始日期	D, 对应<see cref="BEGDAT"/>
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
        /// <summary>
        /// 日期标志	C(1)	A：经办日; B：期望日
        /// </summary>
        public string DATFLG { get; set; }
    }
}
