using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.18.3跨境电商结汇还原报送响应主体
    /// </summary>
    public class V1_CBECSETTLEMENTDECLARETRNRS : IResponse
    {
        /// <summary>
        /// 3.18.3跨境电商结汇还原报送响应主体
        /// </summary>
        public CBECSETTLEMENTDECLARETRNRS CBECSETTLEMENTDECLARETRNRS { get; set; }
    }
    /// <summary>
    /// 3.18.3跨境电商结汇还原报送响应主体
    /// </summary>
    public class CBECSETTLEMENTDECLARETRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.18.3跨境电商结汇还原报送响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBECSETTLEMENTDECLARETRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.18.3跨境电商结汇还原报送响应内容
    /// </summary>
    public class CBECSETTLEMENTDECLARETRN_RSBODY
    {
        /// <summary>
        /// 结售汇银行流水号	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string EXCHANGEBANKLSH { get; set; }
        /// <summary>
        /// 币种 参见银行币种代码表 必回
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
        public string CURRENCY { get; set; }
        /// <summary>
        /// 总笔数	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public int TOTAL_CNT { get; set; }
        /// <summary>
        /// 总金额	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal TOTAL_AMT { get; set; }
        /// <summary>
        /// 3.18.3跨境电商结汇还原报送响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 5)]
        public List<CBECSETTLEMENTDECLARETRNRS_CONTENT> List { get; set; }
        /// <summary>
        /// 指令处理状态	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
    /// <summary>
    /// 3.18.3跨境电商结汇还原报送响应明细
    /// </summary>
    public class CBECSETTLEMENTDECLARETRNRS_CONTENT : Requests.CBECSETTLEMENTDECLARETRNRQ_CONTENT
    {
        /// <summary>
        /// 外管业务参号	非必回
        /// </summary>
        [XmlElement(Order = 20)]
        public string SAFE_BUSN_NO { get; set; }
        /// <summary>
        /// 处理状态，同指令状态编码	必回
        /// </summary>
        [XmlElement(Order = 21)]
        public XFERPRCCODEEnum STATUS { get; set; }
        /// <summary>
        /// 处理信息	非必回
        /// </summary>
        [XmlElement(Order = 22)]
        public string ERRMSG { get; set; }
    }
}
