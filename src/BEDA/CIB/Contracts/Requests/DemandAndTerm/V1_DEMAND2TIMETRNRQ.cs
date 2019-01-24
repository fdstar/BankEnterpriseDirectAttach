using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.12.1活期转定期请求主体
    /// </summary>
    public class V1_DEMAND2TIMETRNRQ : IRequest<V1_FINANCINGTRNRS>
    {
        /// <summary>
        /// 3.12.1活期转定期请求主体
        /// </summary>
        public DEMAND2TIMETRNRQ DEMAND2TIMETRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.1活期转定期请求主体
    /// </summary>
    public class DEMAND2TIMETRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.1活期转定期请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public DEMAND2TIMEINFO DEMAND2TIMEINFO { get; set; }
    }
    /// <summary>
    /// 3.12.1活期转定期请求内容
    /// </summary>
    public class DEMAND2TIMEINFO
    {
        /// <summary>
        /// 活期账户代号 18位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string DEMANDACCT { get; set; }
        /// <summary>
        /// 金额，不能为空、空格且金额必须大等于10000，必须为数值型，decimal(17,2)，即整数位最长15位，小数位2位	必输。
        /// </summary>
        [XmlElement(Order = 1)]
        public decimal AMOUNT { get; set; }
        /// <summary>
        /// 存期：M03（3个月）、M06（6个月）、Y01（一年）、Y02（两年）、Y03（三年）、Y05（五年），默认M03 必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string TERM { get; set; } = "M03";
        /// <summary>
        /// 续存标志 ，目前仅支持 2 本息续存 必输
        /// </summary>
        [XmlElement(Order = 3)]
        public int CONTFLAG { get; set; } = 2;
        /// <summary>
        /// 凭证号，8位(指柜面领取的重控凭证，可不填，表示使用电子凭证号)	非必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string VOUCHER { get; set; }
    }
}
