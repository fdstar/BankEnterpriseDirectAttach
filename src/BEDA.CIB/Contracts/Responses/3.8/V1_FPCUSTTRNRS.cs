using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.8.6理产产品客户信息查询响应主体
    /// </summary>
    public class V1_FPCUSTTRNRS : IResponse
    {
        /// <summary>
        /// 3.8.6理产产品客户信息查询响应主体
        /// </summary>
        public FPCUSTTRNRS FPCUSTTRNRS { get; set; }
    }
    /// <summary>
    /// 3.8.6理产产品客户信息查询响应主体
    /// </summary>
    public class FPCUSTTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.8.6理产产品客户信息查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public FPCUSTTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.8.6理产产品客户信息查询响应内容
    /// </summary>
    public class FPCUSTTRN_RSBODY
    {
        /// <summary>
        /// 客户名称，最长50位
        /// </summary>
        [XmlElement(Order = 3)]
        public string CUSTNAME { get; set; }
        /// <summary>
        /// 证件类型
        /// 0 居民身份证或临时身份证     
        /// 1 企业客户营业执照           
        /// 2 企业代码证                 
        /// 3 企业客户其他有效证件
        /// 4 军人身份证                 
        /// 5 武警身份证                 
        /// 6 港、澳、台居民有效身份证   
        /// 7 外国护照                   
        /// 8 个人客户其他有效证件       
        /// 9 中国护照
        /// </summary>
        [XmlElement(Order = 4)]
        public int IDTYPE { get; set; }
        /// <summary>
        /// 证件号码，最长20位
        /// </summary>
        [XmlElement(Order = 5)]
        public string IDNO { get; set; }
        /// <summary>
        /// 手机号码，12位
        /// </summary>
        [XmlElement(Order = 6)]
        public string MOBILE { get; set; }
        /// <summary>
        /// 电话号码，最长30位
        /// </summary>
        [XmlElement(Order = 7)]
        public string PHONE { get; set; }
        /// <summary>
        /// 邮政编码，6位
        /// </summary>
        [XmlElement(Order = 8)]
        public string ZIP { get; set; }
        /// <summary>
        /// 地址，最长60位
        /// </summary>
        [XmlElement(Order = 9)]
        public string ADDR { get; set; }
        /// <summary>
        /// 电子邮箱，最长30位
        /// </summary>
        [XmlElement(Order = 10)]
        public string EMAIL { get; set; }
        /// <summary>
        /// 客户类型  2公司  4同业
        /// </summary>
        [XmlElement(Order = 11)]
        public int CUSTTYPE { get; set; }
    }
}
