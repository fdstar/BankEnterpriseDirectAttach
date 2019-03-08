using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.18.1跨境电商汇率查询响应主体
    /// </summary>
    public class V1_QUERYBULLETINTRNRS : IResponse
    {
        /// <summary>
        /// 3.18.1跨境电商汇率查询响应主体
        /// </summary>
        public QUERYBULLETINTRNRS QUERYBULLETINTRNRS { get; set; }
    }
    /// <summary>
    /// 3.18.1跨境电商汇率查询响应主体
    /// </summary>
    public class QUERYBULLETINTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.18.1跨境电商汇率查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public QUERYBULLETINTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.18.1跨境电商汇率查询响应内容
    /// </summary>
    public class QUERYBULLETINTRN_RSBODY
    {
        /// <summary>
        /// 是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.18.1跨境电商汇率查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 1)]
        public List<QUERYBULLETINTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.18.1跨境电商汇率查询响应明细
    /// </summary>
    public class QUERYBULLETINTRN_CONTENT
    {
        /// <summary>
        /// 生效日期 YYYY-MM-DD	非必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string PUBDATE { get; set; }
        /// <summary>
        /// 生效时间 HH:mm:ss	非必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string PUBTIME { get; set; }
        /// <summary>
        /// 生效时间，如果获取失败则返回null
        /// </summary>
        [XmlIgnore]
        public DateTime? EffectiveTime
        {
            get
            {
                if (DateTime.TryParseExact(PUBDATE + PUBTIME, new string[] { "yyyy-MM-dd", "yyyy-MM-ddHH:mm:ss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime time))
                {
                    return time;
                }
                return null;
            }
            set
            {
                this.PUBDATE = value?.ToString("yyyy-MM-dd");
                this.PUBTIME = value?.ToString("HH:mm:ss");
            }
        }
        /// <summary>
        /// 货币单位	非必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string CURRENCYUNIT { get; set; }
        /// <summary>
        /// 币种	非必回
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
        [XmlElement(Order = 3)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 对方币种	非必回
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
        [XmlElement(Order = 4)]
        public string OPPCURRENCY { get; set; }
        /// <summary>
        /// 买入价格	非必回
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal? ORDERPRICE { get; set; }
        /// <summary>
        /// 卖出价格	非必回
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal? AVERAGEPRICE { get; set; }
        /// <summary>
        /// 中间价格	非必回
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal? MIDDLEPRICE { get; set; }
        /// <summary>
        /// 现钞价格	非必回
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal? OOFPRICE { get; set; }
        /// <summary>
        /// 基准价格	非必回
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal? BANCHMARKPRICE { get; set; }
        /// <summary>
        /// 美元折算价格	非必回
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal? DOLLARPRICE { get; set; }
        /// <summary>
        /// 年度决算牌价	非必回
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal? YEARFINALPRICE { get; set; }
    }
}
