using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 24.4.网银电子对帐业务查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS24_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTNSTLST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTNSTLST";
        /// <summary>
        /// 24.4.网银电子对帐业务查询响应集合
        /// </summary>
        [XmlElement("NTNSTLSTZ")]
        public List<NTNSTLSTZ> List { get; set; }
    }
    /// <summary>
    /// 24.4.网银电子对帐业务查询响应内容
    /// </summary>
    public class NTNSTLSTZ
    {
        /// <summary>
        /// 流程实例号     	C(10)  
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务模式       	C(6)   
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 户口号         	C(35)   
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 对账月份       	C(6)     
        /// </summary>
        public string YERMTH { get; set; }
        /// <summary>
        /// 余额核对状态   	C(1) Y，余额相符 N，余额不符 S, 调节相符 F, 调节不符
        /// </summary>
        public string BALFLG { get; set; }
        /// <summary>
        /// 余额调节原因类型	C(5)   
        /// </summary>
        public string ADJCAS { get; set; }
        /// <summary>
        /// 余额对账不符原因	Z(100)   
        /// </summary>
        public string LOGTXT { get; set; }
        /// <summary>
        /// 业务参考号     	C(30) 
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 经办日         	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 经办日         	D, 对应<see cref="OPRDAT"/>
        /// </summary>
        [XmlElement("OPRDAT")]
        public string OPRDATStr
        {
            get
            {
                return this.OPRDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 请求状态       	C(3)    
        /// </summary>
        public string REQSTS { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)  
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 活期账号    	C(35) 
        /// </summary>
        public string ACCNBR { get; set; }
    }
}
