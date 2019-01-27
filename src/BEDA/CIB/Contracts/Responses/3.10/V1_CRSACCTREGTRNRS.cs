using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.10.1跨行账户他行账户登记响应主体
    /// </summary>
    public class V1_CRSACCTREGTRNRS:IResponse
    {
        /// <summary>
        /// 3.10.1跨行账户他行账户登记响应主体
        /// </summary>
        public CRSACCTREGTRNRS CRSACCTREGTRNRS { get; set; }
    }
    /// <summary>
    /// 3.10.1跨行账户他行账户登记响应主体
    /// </summary>
    public class CRSACCTREGTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.10.1跨行账户他行账户登记响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CRSACCTREGTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.10.1跨行账户他行账户登记响应内容
    /// </summary>
    public class CRSACCTREGTRN_RSBODY
    {
        /// <summary>
        /// 协议类型1 付款2 查询
        /// </summary>
        [XmlElement(Order = 0)]
        public int AGRMTYPE { get; set; }
        /// <summary>
        /// 业务种类编号 见文档附录:他行核心业务种类代码类型
        /// 00100  电费
        /// 00200  水暖费
        /// 00300  煤气费
        /// 00400  电话费
        /// 00500  通讯费
        /// 00600  保险费
        /// 00700  房屋管理费
        /// 00800  代理服务费
        /// 00900  学教费
        /// 01000  有线电视费
        /// 01100  企业管理费用
        /// 01200  薪金报酬
        /// 02025  贷款还款房贷类	
        /// 02026  贷款还款车贷类
        /// 02027  贷款还款信用卡类
        /// 09001  其他
        /// </summary>
        [XmlElement(Order = 1)]
        public string BUSINESSTYPE { get; set; }
        /// <summary>
        /// 他行帐户信息
        /// </summary>
        [XmlElement(Order = 2)]
        public CORRELATEACCT INTERACCT { get; set; }
        /// <summary>
        /// 发起账户代号，最长32位
        /// </summary>
        [XmlElement(Order = 3)]
        public string OPERACCTID { get; set; }
        /// <summary>
        /// 登记结果1-有效 9-删除
        /// </summary>
        [XmlElement(Order = 4)]
        public int RESULT { get; set; }
    }
}
