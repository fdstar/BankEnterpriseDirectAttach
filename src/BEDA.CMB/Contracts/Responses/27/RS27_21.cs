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
    /// 27.21.查询划拨关系列表响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS27_21 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTMTLRLS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMTLRLS";
        /// <summary>
        /// 27.21.查询划拨关系列表响应集合
        /// </summary>
        [XmlElement("NTMTLRLSZ1")]
        public List<NTMTLRLSZ1> List { get; set; }
    }
    /// <summary>
    /// 27.21.查询划拨关系列表响应内容
    /// </summary>
    public class NTMTLRLSZ1
    {
        /// <summary>
        /// 产品编号	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 关联关系编号	C(5)
        /// </summary>
        public string RLTNBR { get; set; }
        /// <summary>
        /// 上级账号分行号	C(2)
        /// </summary>
        public string TOPBBK { get; set; }
        /// <summary>
        /// 上级账户	C(35)
        /// </summary>
        public string TOPEAC { get; set; }
        /// <summary>
        /// 上级账号币种	C(2)
        /// </summary>
        public string TOPCCY { get; set; }
        /// <summary>
        /// 上级账号名称	Z(200)
        /// </summary>
        public string TOPNAM { get; set; }
        /// <summary>
        /// 下级账号分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 下级账户	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 下级账号币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 下级账号名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 内部户	C(10)
        /// </summary>
        public string INNACC { get; set; }
        /// <summary>
        /// 内部户名称	Z(100)
        /// </summary>
        public string INANAM { get; set; }
        /// <summary>
        /// 状态	C(1)    A：生效；B暂停；D失效
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 头寸余额	F(17,2)
        /// </summary>
        public decimal AVLNOM { get; set; }
        /// <summary>
        /// 上日头寸余额	F(17,2)
        /// </summary>
        public decimal LSTNML { get; set; }
        /// <summary>
        /// 联机余额	F(17,2) 子户联机余额
        /// </summary>
        public decimal ONLBAL { get; set; }
    }
}
