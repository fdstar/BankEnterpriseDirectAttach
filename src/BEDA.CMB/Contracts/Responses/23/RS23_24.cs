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
    /// 23.24.取公司卡某日交易（续传）响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS23_24 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCPRTRX
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRTRX";
        /// <summary>
        /// 23.24.取公司卡某日交易（续传）响应集合
        /// </summary>
        [XmlElement("NTCPRTRXZ1")]
        public List<NTCPRTRXZ1> List { get; set; }
        /// <summary>
        /// 23.24.取公司卡某日交易（续传）响应内容 续传标志
        /// </summary>
        public NTCPACTNZ1 NTCPACTNZ1 { get; set; }
    }
    /// <summary>
    /// 23.24.取公司卡某日交易（续传）响应内容
    /// </summary>
    public class NTCPRTRXZ1
    {
        /// <summary>
        /// 公司卡卡号	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 持卡人   	Z(62)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 卡备注   	Z(62)
        /// </summary>
        public string REMARK { get; set; }
        /// <summary>
        /// 交易日期 	D
        /// </summary>
        [XmlIgnore]
        public DateTime ETYDAT { get; set; }
        /// <summary>
        /// 交易日期 	D, 对应<see cref="ETYDAT"/>
        /// </summary>
        [XmlElement("ETYDAT")]
        public string ETYDATStr
        {
            get
            {
                return this.ETYDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ETYDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 交易种类 	C(1)
        /// </summary>
        public string TRXTYP { get; set; }
        /// <summary>
        /// 记账方向 	C(1)
        /// </summary>
        public string BOKDIR { get; set; }
        /// <summary>
        /// 交易金额 	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 余额     	M
        /// </summary>
        public decimal ONLBAL { get; set; }
        /// <summary>
        /// 货币     	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易流水号	C(15)
        /// </summary>
        public string TRXNBR { get; set; }
        /// <summary>
        /// 交易套号       	C(15)
        /// </summary>
        public string TRXSET { get; set; }
        /// <summary>
        /// 渠道           	C(3)
        /// </summary>
        public string CNLCOD { get; set; }
        /// <summary>
        /// 摘要代码       	C(4)
        /// </summary>
        public string TXTCOD { get; set; }
        /// <summary>
        /// 交易摘要       	Z(42)
        /// </summary>
        public string TRXTXT { get; set; }
        /// <summary>
        /// 商户号         	C(15)
        /// </summary>
        public string MCHNBR { get; set; }
        /// <summary>
        /// 商户名称       	Z(62)
        /// </summary>
        public string MCHDES { get; set; }
        /// <summary>
        /// 收付方帐号分行号	C(2)
        /// </summary>
        public string RPYBBK { get; set; }
        /// <summary>
        /// 收付方帐号     	C(35)
        /// </summary>
        public string RPYACC { get; set; }
        /// <summary>
        /// 收付方名称     	Z(62)
        /// </summary>
        public string RPYNAM { get; set; }
        /// <summary>
        /// 收付方开户行行号	C(20)
        /// </summary>
        public string RPYBBN { get; set; }
        /// <summary>
        /// 收付方开户行行名 	Z(62)
        /// </summary>
        public string RPYBNK { get; set; }
        /// <summary>
        /// 收付方开户行地址 	Z(62)
        /// </summary>
        public string RPYADR { get; set; }
        /// <summary>
        /// 母子帐号分行号   	C(2)
        /// </summary>
        public string GSBBBK { get; set; }
        /// <summary>
        /// 母子公司帐号     	C(35)
        /// </summary>
        public string GSBACC { get; set; }
        /// <summary>
        /// 母子公司名称     	Z(62)
        /// </summary>
        public string GSBNAM { get; set; }
        /// <summary>
        /// 母子公司开户行行号	C(20)
        /// </summary>
        public string GSBBBN { get; set; }
        /// <summary>
        /// 母子公司开户行行名	Z(62)
        /// </summary>
        public string GSBBNK { get; set; }
        /// <summary>
        /// 母子公司开户行地址	Z(62)
        /// </summary>
        public string GSBADR { get; set; }
    }
    /// <summary>
    /// 23.24.取公司卡某日交易（续传）响应内容 续传标志
    /// </summary>
    public class NTCPACTNZ1
    {
        /// <summary>
        /// 续传标志	C(1)    Y:有续传，后续还有卡号数据，表示尚未传送完毕 N：无续传，表示已传送完毕
        /// </summary>
        public string CTNFLG { get; set; }
        /// <summary>
        /// 末位记账序号	C(9)    本次查询返回的最后一个记账序号
        /// </summary>
        public string TRSSEQ { get; set; }
    }
}
