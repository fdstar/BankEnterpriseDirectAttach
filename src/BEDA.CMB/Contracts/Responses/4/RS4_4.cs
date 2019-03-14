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
    /// 4.4.查询交易明细信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS4_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// GetAgentDetail
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "GetAgentDetail";
        /// <summary>
        /// 4.4.查询交易明细信息响应集合
        /// </summary>
        [XmlElement("NTQATDQYZ")]
        public List<NTQATDQYZ> List { get; set; }
    }
    /// <summary>
    /// 4.4.查询交易明细信息响应内容
    /// </summary>
    public class NTQATDQYZ
    {
        /// <summary>
        /// 账号	C(1,35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 户名  测试报文返回该字段
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 户名	Z(1,20)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 注释	Z(20)
        /// </summary>
        public string TRSDSP { get; set; }
        /// <summary>
        /// 状态	C(1)	S：成功；F：失败；C：撤消；I：数据录入(即初始状态)
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 结果描述
        /// </summary>
        public string ERRDSP { get; set; }
        /// <summary>
        /// 系统内标志	C(1)	Y：开户行为招行； N：开户行为他行
        /// </summary>
        public string BNKFLG { get; set; }
        /// <summary>
        /// 他行户口开户行	Z(1,62)
        /// </summary>
        public string EACBNK { get; set; }
        /// <summary>
        /// 他行户口开户地	Z(1,62)
        /// </summary>
        public string EACCTY { get; set; }
    }
}
