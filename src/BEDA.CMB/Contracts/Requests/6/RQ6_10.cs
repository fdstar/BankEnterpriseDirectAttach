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
    /// 6.10.订单列表查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ6_10 : CMBBase<RQINFO>, IRequest<RS6_10>
    {
        /// <summary>
        /// NTQRYORD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYORD";
        /// <summary>
        /// 6.10.订单列表查询请求内容
        /// </summary>
        public NTQRYORDY1 NTQRYORDY1 { get; set; }
    }
    /// <summary>
    /// 6.10.订单列表查询请求内容
    /// </summary>
    public class NTQRYORDY1
    {
        /// <summary>
        /// 业务模式	C(5)    可通过ListMode接口查询（业务代码N02032），或在前置机上查看
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 日期类型	C(1)	A：经办日期；B：期望日期   未输入则默认按经办日期查询
        /// </summary>
        public string DATFLG { get; set; }
        /// <summary>
        /// 起始日期	D   查询范围不能超过7天
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
