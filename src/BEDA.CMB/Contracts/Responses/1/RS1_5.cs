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
    /// 1.5.取系统信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS1_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// GetSysInfo
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "GetSysInfo";
        /// <summary>
        /// 1.5.取系统信息响应集合
        /// </summary>
        [XmlElement("NTQSYINFZ")]
        public List<NTQSYINFZ> List { get; set; }
    }
    /// <summary>
    /// 1.5.取系统信息响应内容
    /// </summary>
    public class NTQSYINFZ
    {
        /// <summary>
        /// 用户登录名
        /// </summary>
        public string LGNNAM { get; set; }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string USRNAM { get; set; }
        /// <summary>
        /// 用户上次成功登录时间   日期+时间
        /// </summary>
        public string LGNTIM { get; set; }
        /// <summary>
        /// 用户类型	 	"P"：系统管理员；"S"：普通用户
        /// </summary>
        public string USRTYP { get; set; }
        /// <summary>
        /// 用户所属公司的类型	 	"G"：集团企业；"N"：普通企业
        /// </summary>
        public string CORTYP { get; set; }
        /// <summary>
        /// 用户所属公司名称	
        /// </summary>
        public string CORNAM { get; set; }
        /// <summary>
        /// 用户所属集团公司  对普通企业，和CORNAM一致
        /// </summary>
        public string GRPNAM { get; set; }
        /// <summary>
        /// 是否证书卡用户	 	"Y"：是；"N"：不是
        /// </summary>
        public string ICCLGN { get; set; }
        /// <summary>
        /// 证书卡卡号
        /// </summary>
        public string ICCNBR { get; set; }
    }
}
