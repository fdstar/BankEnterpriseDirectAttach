using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.12.3活期转通知响应主体
    /// </summary>
    public class V1_CCCURR2CALLTRNRS : IResponse
    {
        /// <summary>
        /// 3.12.3活期转通知响应主体
        /// </summary>
        public CCCURR2CALLTRNRS CCCURR2CALLTRNRS { get; set; }
    }
    /// <summary>
    /// 3.12.3活期转通知响应主体
    /// </summary>
    public class CCCURR2CALLTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.12.3活期转通知响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CCCURR2CALLTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.12.3活期转通知响应内容
    /// </summary>
    public class CCCURR2CALLTRN_RSBODY
    {
        /// <summary>
        /// 活期账户信息
        /// </summary>
        [XmlElement(Order = 0)]
        public ACCTAMT CURRACCTINFO { get; set; }
        /// <summary>
        /// 定期账户信息
        /// </summary>
        [XmlElement(Order = 1)]
        public ACCTAMT TIMEACCTINFO { get; set; }
        /// <summary>
        /// 转出金额，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 存期 D01 一天通知 D07 七天通知
        /// </summary>
        [XmlElement(Order = 3)]
        public string TERM { get; set; }
        /// <summary>
        /// 利率，decimal(11,7)，即整数位最长4位，小数位7位
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal INTRST { get; set; }
        /// <summary>
        /// 状态（非必回，弃用，如返回此节点，请跳过处理，将会在高版本中删除此节点）
        /// </summary>
        [XmlElement(Order = 5)]
        public string STATUS { get; set; }
        /// <summary>
        /// 执行情况，（非必回，弃用，如返回此节点，请跳过处理，将会在高版本中删除此节点）
        /// </summary>
        [XmlElement(Order = 6)]
        public string RESULT { get; set; }
        /// <summary>
        /// 指令处理状态
        /// </summary>
        [XmlElement(Order = 7)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
