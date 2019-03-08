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
    /// 集团服务历史留存金额查询请求主体
    /// </summary>
    public class V1_CMHISBLNCTRNRQ : IRequest<V1_CMHISBLNCTRNRS>
    {
        /// <summary>
        /// 集团服务历史留存金额查询请求主体
        /// </summary>
        public CMHISBLNCTRNRQ CMHISBLNCTRNRQ { get; set; }
    }
    /// <summary>
    /// 集团服务历史留存金额查询请求主体
    /// </summary>
    public class CMHISBLNCTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 集团服务历史留存金额查询内容
        /// </summary>
        [XmlElement(Order = 1)]
        public CMHISBLNCTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 集团服务历史留存金额查询内容
    /// </summary>
    public class CMHISBLNCTRN_RQBODY
    {
        /// <summary>
        /// PAGE查询页码，每页100笔，不输默认第1页，必输
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 结算中心账户信息，必输
        /// </summary>
        [XmlElement(Order = 0)]
        public RQACCT FUNDACCT { get; set; }
        /// <summary>
        /// 成员单位账户信息，必输
        /// 查询结算中心明细时，此处输入结算中心帐号
        /// </summary>
        [XmlElement(Order = 1)]
        public RQACCT MBRACCT { get; set; }
        /// <summary>
        /// 起始日期YYYY-MM-DD	必输
        /// </summary>
        [XmlIgnore]
        public DateTime DTSTART { get; set; }
        /// <summary>
        /// 起始日期YYYY-MM-DD ,对应<see cref="DTSTART"/>	必输
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
        /// 截止日期YYYY-MM-DD	必输
        /// </summary>
        [XmlIgnore]
        public DateTime DTEND { get; set; }
        /// <summary>
        /// 截止日期YYYY-MM-DD ,对应<see cref="DTEND"/>	必输
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
