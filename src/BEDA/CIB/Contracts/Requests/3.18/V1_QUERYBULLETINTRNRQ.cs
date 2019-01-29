using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.18.1跨境电商汇率查询请求主体
    /// </summary>
    public class V1_QUERYBULLETINTRNRQ : IRequest<V1_QUERYBULLETINTRNRS>
    {
        /// <summary>
        /// 3.18.1跨境电商汇率查询请求主体
        /// </summary>
        public QUERYBULLETINTRNRQ QUERYBULLETINTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.18.1跨境电商汇率查询请求主体
    /// </summary>
    public class QUERYBULLETINTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.18.1跨境电商汇率查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public QUERYBULLETINTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.18.1跨境电商汇率查询请求内容
    /// </summary>
    public class QUERYBULLETINTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 日期 YYYY-MM-DD	必输
        /// </summary>
        [XmlIgnore]
        public DateTime DATE { get; set; }
        /// <summary>
        /// 日期 YYYY-MM-DD, 对应<see cref="DATE"/>	必输 
        /// </summary>
        [XmlElement("DATE", Order = 1)]
        public string DATEStr
        {
            get
            {
                return this.DATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DATE = tmp;
                }
            }
        }
        /// <summary>
        /// 货币种类	非必输
        ///01	人民币        
        ///11	欧元          
        ///12	英镑          
        ///13	港币          
        ///14	美元          
        ///15	瑞士法郎      
        ///21	瑞典克朗      
        ///22	丹麦克朗      
        ///23	挪威克朗      
        ///27	日元
        ///28	加拿大元      
        ///29	澳大利亚元    
        ///32	马来西亚林吉特
        ///43	新加坡元      
        ///81	澳门元        
        ///84	泰国铢        
        ///87	新西兰元 
        /// </summary>
        [XmlElement(Order = 2)]
        public string CURRENCYCODE { get; set; }
    }
}
