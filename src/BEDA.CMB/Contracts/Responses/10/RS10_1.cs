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
    /// 10.1.查询用户有权资源响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS10_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTUSRFCT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTUSRFCT";
        /// <summary>
        /// 10.1.查询用户有权资源响应集合
        /// </summary>
        [XmlElement("NTCACLSTZ1")]
        public List<NTCACLSTZ1> List { get; set; }
    }
    /// <summary>
    /// 10.1.查询用户有权资源响应内容
    /// </summary>
    public class NTCACLSTZ1
    {
        /// <summary>
        /// 业务类型	C(6)
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 资源类型	C(3)	ACC：账号
        /// </summary>
        public string FCTTYP { get; set; }
        /// <summary>
        /// 分行	C(2)	A.1 招行分行
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 资源值	C(35)	为10位数字时表示协议编号；为15位数字时表示10位协议编号+5位子公司协议序号
        /// </summary>
        public string FCTVAL { get; set; }
        /// <summary>
        /// 币种	C(2)	A.3 货币代码表
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 注解	C(62)
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 客户关系号	C(10)
        /// </summary>
        public string RELNBR { get; set; }
        /// <summary>
        /// 资源对应标记	C(3)
        /// </summary>
        public string FCTFLG { get; set; }
        /// <summary>
        /// 分行	C(2)	A.1 招行分行
        /// </summary>
        public string BBKNB2 { get; set; }
        /// <summary>
        /// 资源对应值	C(35)
        /// </summary>
        public string FCTVA2 { get; set; }
        /// <summary>
        /// 币种	C(2)	A.3 货币代码表	
        /// </summary>
        public string CCYNB2 { get; set; }
        /// <summary>
        /// 资源对应值注解	Z(62)
        /// </summary>
        public string ACCNM2 { get; set; }
        /// <summary>
        /// 客户关系号	C(10)
        /// </summary>
        public string RELNB2 { get; set; }
        /// <summary>
        /// 保留字段	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
