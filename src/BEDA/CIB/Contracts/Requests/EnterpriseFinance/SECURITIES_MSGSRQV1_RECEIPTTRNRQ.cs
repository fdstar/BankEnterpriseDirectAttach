using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 指令回单查询请求主体
    /// </summary>
    public class SECURITIES_MSGSRQV1_RECEIPTTRNRQ : IRequest<SECURITIES_MSGSRSV1_RECEIPTTRNRS>
    {
        /// <summary>
        /// 指令回单查询请求
        /// </summary>
        public RECEIPTTRNRQ RECEIPTTRNRQ { get; set; }
    }
    /// <summary>
    /// 指令回单查询请求
    /// </summary>
    public class RECEIPTTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 指令类型，长度1位，输入1、2、3 必输
        /// 1表示单笔支付指令
        /// 2表示批量支付指令
        /// 3表示代发工资指令
        /// </summary>
        [XmlElement(Order = 1)]
        public int BIZTYPE { get; set; }
    }
}
