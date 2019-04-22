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
    /// 8.11.4.查询保证金账户响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_11_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTBTFQFU
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBTFQFU";
        /// <summary>
        /// 8.11.4.查询保证金账户响应集合
        /// </summary>
        [XmlElement("NTBTFQFUZ")]
        public List<NTBTFQFUZ> List { get; set; }
    }
    /// <summary>
    /// 8.11.4.查询保证金账户响应内容
    /// </summary>
    public class NTBTFQFUZ
    {
        /// <summary>
        /// 货币代码	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 期货公司编号	C(6)
        /// </summary>
        public string FUTNBR { get; set; }
        /// <summary>
        /// 保证金账号	C(30)
        /// </summary>
        public string MARACT { get; set; }
        /// <summary>
        /// 处理状态	C(1)
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 期货公司名称	Z(20)
        /// </summary>
        public string FUTNAM { get; set; }
    }
}
