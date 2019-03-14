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
    /// 2.4.账户交易信息断点查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS2_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// GetTransInfoEX
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "GetTransInfoEX";
        /// <summary>
        /// 2.4.账户交易信息断点查询响应集合
        /// </summary>
        [XmlElement("NTQTSINFZ")]
        public List<NTQTSINFZ> List { get; set; }
        /// <summary>
        /// 2.4.账户交易信息断点查询续传标志
        /// </summary>
        public NTRBPTRSZ1 NTRBPTRSZ1 { get; set; }
    }
    /// <summary>
    /// 2.4.账户交易信息断点查询续传标志
    /// </summary>
    public class NTRBPTRSZ1
    {
        /// <summary>
        /// 未传完标记	C(1)
        /// 如为Y则表示查询交易日在本次查询完成后，还有数据未查，为N则表示已查完交易日的所有交易
        /// </summary>
        public string COTFLG { get; set; }
        /// <summary>
        /// 末位记账序号	C(9)
        /// 本次查询所查的最大记账序号，如CotFlg为Y，下一次查询输入接口记账序号字段填入此序号+1
        /// </summary>
        public long TRSSEQ { get; set; }
        /// <summary>
        /// 本次查询查到的借记的笔数	C(5)
        /// </summary>
        public int DBTNBR { get; set; }
        /// <summary>
        /// 本次查询查到的借记的金额汇总	M
        /// </summary>
        public decimal DBTAMT { get; set; }
        /// <summary>
        /// 本次查询查到的贷记的笔数	C(2)
        /// </summary>
        public int CRTNBR { get; set; }
        /// <summary>
        /// 本次查询查到的贷记的金额汇总	M
        /// </summary>
        public decimal CRTAMT { get; set; }
    }
}
