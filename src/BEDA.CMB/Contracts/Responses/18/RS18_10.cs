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
    /// 18.10.查询账单正文/原文响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS18_10 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKSWPKGTXT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKSWPKGTXT";
        /// <summary>
        /// 18.10.查询账单正文/原文响应内容 正文
        /// </summary>
        public SWLSISWFZ1 SWLSISWFZ1 { get; set; }
        /// <summary>
        /// 18.10.查询账单正文/原文响应内容 原文
        /// </summary>
        public SWLSISWFZ2 SWLSISWFZ2 { get; set; }
    }
    /// <summary>
    /// 18.10.查询账单正文/原文响应内容 正文
    /// </summary>
    public class SWLSISWFZ1
    {
        /// <summary>
        /// 正文
        /// </summary>
        public string PTRDAT { get; set; }
    }
    /// <summary>
    /// 18.10.查询账单正文/原文响应内容 原文
    /// </summary>
    public class SWLSISWFZ2
    {
        /// <summary>
        /// 原文
        /// </summary>
        public string RAWDAT { get; set; }
    }
}
