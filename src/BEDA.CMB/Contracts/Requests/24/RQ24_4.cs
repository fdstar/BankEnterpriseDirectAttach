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
    /// 24.4.网银电子对帐业务查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ24_4 : CMBBase<RQINFO>, IRequest<RS24_4>
    {
        /// <summary>
        /// NTNSTLST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTNSTLST";
        /// <summary>
        /// 24.4.网银电子对帐业务查询请求内容
        /// </summary>
        public NTNSTWACY NTNSTWACY { get; set; }
    }
    /// <summary>
    /// 24.4.网银电子对帐业务查询请求内容
    /// </summary>
    public class NTNSTWACY
    {
        /// <summary>
        /// 开始日期   	D
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 开始日期   	D, 对应<see cref="BGNDAT"/>
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
        /// 结束日期   	D 
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 结束日期   	D , 对应<see cref="ENDDAT"/>
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
        /// 对账月份   	C(6)  
        /// </summary>
        public string YERMTH { get; set; }
        /// <summary>
        /// 经办用户   	Z(30) 
        /// </summary>
        public string OPRLGN { get; set; }
        /// <summary>
        /// 请求状态   	C(30)  
        /// </summary>
        public string AUTSTR { get; set; }
        /// <summary>
        /// 返回结果   	C(30)  
        /// </summary>
        public string RTNSTR { get; set; }
        /// <summary>
        /// 续传键值   	C(80)  
        /// </summary>
        public string CTNKEY { get; set; }
    }
}
