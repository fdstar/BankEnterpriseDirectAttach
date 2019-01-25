using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.13.3历史余额查询请求主体
    /// </summary>
    public class V1_HISBALQUERYTRNRQ : IRequest<V1_HISBALQUERYTRNRS>
    {
        /// <summary>
        /// 3.13.3历史余额查询请求主体
        /// </summary>
        public HISBALQUERYTRNRQ HISBALQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.13.3历史余额查询请求主体
    /// </summary>
    public class HISBALQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 在响应报文中包含该内容 	非必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string CLTCOOKIE { get; set; }
        /// <summary>
        /// 交易请求
        /// </summary>
        [XmlElement(Order = 2)]
        public HISBALQUERYRQ HISBALQUERYRQ { get; set; }
    }
    /// <summary>
    /// 3.13.3历史余额查询请求内容
    /// </summary>
    public class HISBALQUERYRQ
    {
        /// <summary>
        /// 历史余额查询请求明细	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public HISBALQUERYINFO HISBALQUERYINFO { get; set; }
    }
    /// <summary>
    /// 历史余额查询请求明细
    /// </summary>
    public class HISBALQUERYINFO
    {
        /// <summary>
        /// 账户ID,长度18	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 账户名称长度50	非必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTNAME { get; set; }
        /// <summary>
        /// 开始时间 格式：yyyy-MM-dd(必输)
        /// </summary>
        [XmlIgnore]
        public DateTime DTSTART { get; set; }
        /// <summary>
        /// 开始时间 格式：yyyy-MM-dd ,对应<see cref="DTSTART"/>	必输
        /// </summary>
        [XmlElement("DTSTART", Order = 2)]
        public string DTSTARTStr
        {
            get
            {
                return this.DTSTART.ToString("yyyy-MM-dd");
            }
            set
            {
                if (value.TryParse(out DateTime tmp))
                {
                    this.DTSTART = tmp;
                }
            }
        }
        /// <summary>
        /// 结束时间 格式：yyyy-MM-dd(必输)
        /// </summary>
        [XmlIgnore]
        public DateTime DTEND { get; set; }
        /// <summary>
        /// 结束时间 格式：yyyy-MM-dd ,对应<see cref="DTEND"/>	必输
        /// </summary>
        [XmlElement("DTEND", Order = 3)]
        public string DTENDStr
        {
            get
            {
                return this.DTEND.ToString("yyyy-MM-dd");
            }
            set
            {
                if (value.TryParse(out DateTime tmp))
                {
                    this.DTEND = tmp;
                }
            }
        }
    }
}
