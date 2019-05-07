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
    /// 27.17.划拨综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ27_17 : CMBBase<RQINFO>, IRequest<RS27_17>
    {
        /// <summary>
        /// NTMTLHTC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMTLHTC";
        /// <summary>
        /// 27.17.划拨综合查询请求内容
        /// </summary>
        public NTMTLHTCY1 NTMTLHTCY1 { get; set; }
    }
    /// <summary>
    /// 27.17.划拨综合查询请求内容
    /// </summary>
    public class NTMTLHTCY1
    {
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 日期类型	C(1)    A经办日、B期望日
        /// </summary>
        public string DATFLG { get; set; }
        /// <summary>
        /// 起始日期	D   	日期查询范围不能超过7天
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
