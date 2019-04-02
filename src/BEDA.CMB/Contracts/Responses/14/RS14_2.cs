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
    /// 14.2.查询母子公司户口联机余额响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS14_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKNTQRYFSB
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTQRYFSB";
        /// <summary>
        /// 14.2.查询母子公司户口联机余额响应内容
        /// </summary>
        public NTQRYFSBZ NTQRYFSBZ { get; set; }
    }
    /// <summary>
    /// 14.2.查询母子公司户口联机余额响应内容
    /// </summary>
    public class NTQRYFSBZ
    {
        /// <summary>
        /// 母公司户口号	C(35)
        /// </summary>
        public string FATACC { get; set; }
        /// <summary>
        /// 母公司户口名称	Z(62)
        /// </summary>
        public string FATACN { get; set; }
        /// <summary>
        /// 母公司户口联机余额	M
        /// </summary>
        public decimal FATBAL { get; set; }
        /// <summary>
        /// 母公司联机可用余额	M
        /// </summary>
        public decimal FATAVL { get; set; }
        /// <summary>
        /// 子公司支出户口号	C(35)	A.3 货币代码表
        /// </summary>
        public string SUBACC { get; set; }
        /// <summary>
        /// 子公司支出户口币种	C(2)
        /// </summary>
        public string SUBCCY { get; set; }
        /// <summary>
        /// 子公司支出户口名称	Z(62)
        /// </summary>
        public string SUBACN { get; set; }
        /// <summary>
        /// 子公司支出户口联机余额	M
        /// </summary>
        public decimal SUBBAL { get; set; }
        /// <summary>
        /// 子公司名义额度	M
        /// </summary>
        public decimal? LMTAMT { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
