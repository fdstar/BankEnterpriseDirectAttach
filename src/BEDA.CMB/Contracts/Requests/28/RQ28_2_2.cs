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
    /// 28.2.2.虚拟户历史交易查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ28_2_2 : CMBBase<RQINFO>, IRequest<RS28_2_2>
    {
        /// <summary>
        /// NTDMTQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMTQRY";
        /// <summary>
        /// 28.2.2.虚拟户历史交易查询请求内容
        /// </summary>
        public NTDMTQRYY1 NTDMTQRYY1 { get; set; }
    }
    /// <summary>
    /// 28.2.2.虚拟户历史交易查询请求内容
    /// </summary>
    public class NTDMTQRYY1
    {
        /// <summary>
        /// 分行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期结算账户	C(35)
        /// </summary>
        public string INBACC { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)   	为空时查虚拟户所有交易
        /// </summary>
        public string DYANBR { get; set; }
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
        /// 结束日期	D   开始日期和结束日期必须早于当日
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
