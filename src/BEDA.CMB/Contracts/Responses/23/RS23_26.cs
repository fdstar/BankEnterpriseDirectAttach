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
    /// 23.26.公司卡可入账状态查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS23_26 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQRYEAT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYEAT";
        /// <summary>
        /// 23.26.公司卡可入账状态查询响应内容
        /// </summary>
        public NTQRYEATZ1 NTQRYEATZ1 { get; set; }
    }
    /// <summary>
    /// 23.26.公司卡可入账状态查询响应内容
    /// </summary>
    public class NTQRYEATZ1
    {
        /// <summary>
        /// 可入账标志	C(1)    Y：可入账（大概率可入账，当且仅当卡状态和户状态均为00） N：不可入账（大概率不可入账）
        /// </summary>
        public string AVLFLG { get; set; }
        /// <summary>
        /// 卡状态	C(2)    00：非中止 01：中止所有 02：中止非柜面
        /// </summary>
        public string PSBSTS { get; set; }
        /// <summary>
        /// 户状态	C(2)    00：非中止 01：中止所有 02：中止非柜面
        /// </summary>
        public string ACCSTS { get; set; }
        /// <summary>
        /// 特殊码 30	C(30) 
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
