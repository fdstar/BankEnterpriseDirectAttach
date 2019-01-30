using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.18.6跨境电商购汇还原报送补录响应主体
    /// </summary>
    public class V1_CBECPURCHASEDECLAREREINTRNRS : IResponse
    {
        /// <summary>
        /// 3.18.6跨境电商购汇还原报送补录响应主体
        /// </summary>
        public CBECPURCHASEDECLAREREINTRNRS CBECPURCHASEDECLAREREINTRNRS { get; set; }
    }
    /// <summary>
    /// 3.18.6跨境电商购汇还原报送补录响应主体
    /// </summary>
    public class CBECPURCHASEDECLAREREINTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.18.6跨境电商购汇还原报送补录响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBECSETTLEMENTDECLAREREINTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.18.6跨境电商购汇还原报送补录响应内容
    /// </summary>
    public class CBECPURCHASEDECLAREREINTRN_RSBODY : Requests.CBECPURCHASEDECLAREREINTRN_RQBODY
    {
        /// <summary>
        /// 外管业务参号	非必回
        /// </summary>
        [XmlElement(Order = 30)]
        public string SAFE_BUSN_NO { get; set; }
        /// <summary>
        /// 指令处理状态	必回
        /// </summary>
        [XmlElement(Order = 31)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
