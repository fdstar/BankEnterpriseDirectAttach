using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// 汽车状态查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLCCSTPQ : RsBase
    {
        /// <summary>
        /// 总记录数 integer，长度3
        /// </summary>
        [XmlElement("totNum")]
        public int TotNum { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<CarStatusInfo> List { get; set; }
    }
    /// <summary>
    /// 汽车状态
    /// </summary>
    public class CarStatusInfo
    {
        /// <summary>
        /// 车架号 varchar(20)
        /// </summary>
        [XmlElement("chasNo")]
        public string ChasNo { get; set; }
        /// <summary>
        /// 汽车状态 varchar(20)
        /// </summary>
        [XmlElement("carStat")]
        public string CarStat { get; set; }
        /// <summary>
        /// 借款企业组织机构代码 varchar(12)
        /// </summary>
        [XmlElement("orgCode")]
        public string OrgCode { get; set; }
        /// <summary>
        /// 借款企业ID varchar(20)
        /// </summary>
        [XmlElement("lonCpID")]
        public string LonCpID { get; set; }
        /// <summary>
        /// 企业端仓库代码，由企业端提供，企业端仓库代码与SCF系统仓库代码进行映射 varchar(30)
        /// </summary>
        [XmlElement("cpWhCd")]
        public string CpWhCd { get; set; }
        /// <summary>
        /// 银行端仓库代码，SCF业务人员维护到SCF系统 varchar(30)
        /// </summary>
        [XmlElement("bkWhCd")]
        public string BkWhCd { get; set; }
        /// <summary>
        /// 监管仓库名称 varchar(200)
        /// </summary>
        [XmlElement("spvWhNam")]
        public string SpvWhNam { get; set; }
        /// <summary>
        /// 仓库级别 varchar(20)
        /// </summary>
        [XmlElement("whLev")]
        public string WhLev { get; set; }
        /// <summary>
        /// 监管仓库地址 varchar(200)
        /// </summary>
        [XmlElement("spvWhAdd")]
        public string SpvWhAdd { get; set; }
        /// <summary>
        /// 监管仓库联系人 varchar(100)
        /// </summary>
        [XmlElement("spvWhCon")]
        public string SpvWhCon { get; set; }
        /// <summary>
        /// 监管仓库联系电话 varchar(20)
        /// </summary>
        [XmlElement("spvWhTel")]
        public string SpvWhTel { get; set; }
        /// <summary>
        /// 属性4 varchar(30) ，按约定返回
        /// </summary>
        [XmlElement("field4")]
        public string Field4 { get; set; }
        /// <summary>
        /// 属性5 varchar(60) ，按约定返回
        /// </summary>
        [XmlElement("field5")]
        public string Field5 { get; set; }
        /// <summary>
        /// 属性6 varchar(100) ，按约定返回
        /// </summary>
        [XmlElement("field6")]
        public string Field6 { get; set; }
    }
}
