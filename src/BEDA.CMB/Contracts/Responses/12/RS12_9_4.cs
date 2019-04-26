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
    /// 12.9.4.单位基本情况表查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_9_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTBIFQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBIFQRY";
        /// <summary>
        /// 12.9.4.单位基本情况表查询响应内容
        /// </summary>
        public NTBIFQRYZ1 NTBIFQRYZ1 { get; set; }
    }
    /// <summary>
    /// 12.9.4.单位基本情况表查询响应内容
    /// </summary>
    public class NTBIFQRYZ1
    {
        /// <summary>
        /// 可用状态	C(1) 	A:可用; B:不可用
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 单位可以状态	C(1)
        /// 空：等待外汇局审核
        /// A:已核查
        /// B:待核查
        /// C:已停用
        /// </summary>
        public string AVLSTS { get; set; }
        /// <summary>
        /// 保留字30	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
