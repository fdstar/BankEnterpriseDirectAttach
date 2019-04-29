using BEDA.Utils;
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
    /// 26.2.移动支票查询可选有权使用人列表响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS26_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTECKUSR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTECKUSR";
        /// <summary>
        /// 26.2.移动支票查询可选有权使用人列表响应集合
        /// </summary>
        [XmlElement("NTECKUSRZ")]
        public List<NTECKUSRZ> List { get; set; }
    }
    /// <summary>
    /// 26.2.移动支票查询可选有权使用人列表响应内容
    /// </summary>
    public class NTECKUSRZ
    {
        /// <summary>
        /// 用户号    	C(10)
        /// </summary>
        public string USRNBR { get; set; }
        /// <summary>
        /// 登录名       	Z(30)
        /// </summary>
        public string LGNNAM { get; set; }
        /// <summary>
        /// 用户姓名  	Z(20)
        /// </summary>
        public string USRNAM { get; set; }
        /// <summary>
        /// 用户类型       	C(1)
        /// </summary>
        public string USRTYP { get; set; }
        /// <summary>
        /// 职务编号	C(1)
        /// </summary>
        public string CORPST { get; set; }
        /// <summary>
        /// 客户关系号	C(10)
        /// </summary>
        public string RELNBR { get; set; }
        /// <summary>
        /// 用户状态	C(1)
        /// </summary>
        public string USRSTS { get; set; }
    }
}
