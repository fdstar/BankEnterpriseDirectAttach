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
    /// 7.2.查询委托贷款合同响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS7_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// GetALContract
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "GetALContract";
        /// <summary>
        /// 7.2.查询委托贷款合同响应集合    合同信息
        /// </summary>
        [XmlElement("NCACRINFY")]
        public List<NCACRINFY> NCACRINFYList { get; set; }
        /// <summary>
        /// 7.2.查询委托贷款合同响应集合    合同相关账号信息
        /// </summary>
        [XmlElement("NCACRACCY")]
        public List<NCACRACCY> NCACRACCYList { get; set; }
    }
    /// <summary>
    /// 7.2.查询委托贷款合同响应内容    合同信息
    /// </summary>
    public class NCACRINFY
    {
        /// <summary>
        /// 合同号	C(10)
        /// </summary>
        public string LCTNBR { get; set; }
        /// <summary>
        /// 合同类型	C(1)	A：委托合同 B：集团内委托合同
        /// </summary>
        public string LCTTYP { get; set; }
        /// <summary>
        /// 合同名称	Z(42)
        /// </summary>
        public string LCTNAM { get; set; }
        /// <summary>
        /// 结息方式	C(3)
        /// </summary>
        public string LINCOD { get; set; }
        /// <summary>
        /// 利率类型	C(3)    暂不支持上浮利率
        /// </summary>
        public string RATTYP { get; set; }
        /// <summary>
        /// 利率值	F(11,7)
        /// </summary>
        public decimal RATVAL { get; set; }
        /// <summary>
        /// 利率公式	C(4)
        /// </summary>
        public string RATFMF { get; set; }
        /// <summary>
        /// 率相关值	C(15)
        /// </summary>
        public string RLTVAL { get; set; }
        /// <summary>
        /// 手续费公式	C(4)
        /// </summary>
        public string FEEFMF { get; set; }
        /// <summary>
        /// 手续费率	F(5,3)
        /// </summary>
        public decimal FEERTO { get; set; }
        /// <summary>
        /// 手续费值	M
        /// </summary>
        public decimal FEEAMT { get; set; }
    }
    /// <summary>
    /// 7.2.查询委托贷款合同响应内容    合同相关账号信息
    /// </summary>
    public class NCACRACCY
    {
        /// <summary>
        /// 合同号	C(10)
        /// </summary>
        public string LCTNBR { get; set; }
        /// <summary>
        /// 企业编号	C(8)
        /// </summary>
        public string NTBNBR { get; set; }
        /// <summary>
        /// 分行号	C(2,2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账户	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 客户编号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 客户名称	Z(62)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 主体类型	C(1)	‘A’: 委托方 ‘B’: 借款方 ‘’: 集团内的委托贷款
        /// 当为空时表示集团内的委托贷款，可做委托方也可作借款方
        /// </summary>
        public string ENTTYP { get; set; }
    }
}
