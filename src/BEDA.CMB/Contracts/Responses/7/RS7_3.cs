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
    /// 7.3.查询委托贷款可用额度列表响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS7_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQALCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQALCTL";
        /// <summary>
        /// 7.3.查询委托贷款可用额度列表响应集合
        /// </summary>
        [XmlElement("NTNETDZCZ1")]
        public List<NTNETDZCZ1> List { get; set; }
    }
    /// <summary>
    /// 7.3.查询委托贷款可用额度列表响应内容
    /// </summary>
    public class NTNETDZCZ1
    {
        /// <summary>
        /// 额度编号	C(10)
        /// </summary>
        public string CRLNUM { get; set; }
        /// <summary>
        /// 额度组号	C(10)
        /// </summary>
        public string CRLGRP { get; set; }
        /// <summary>
        /// 额度业务组号	C(10)
        /// </summary>
        public string CRLGRB { get; set; }
        /// <summary>
        /// 额度业务连接号	C(10)
        /// </summary>
        public string CRLBUS { get; set; }
        /// <summary>
        /// 申请编号	C(10)
        /// </summary>
        public string APPNUM { get; set; }
        /// <summary>
        /// 申请分行	C(3)	附录A.48招行3位分行
        /// </summary>
        public string APPBBK { get; set; }
        /// <summary>
        /// 申请机构	C(6)
        /// </summary>
        public string APPBRN { get; set; }
        /// <summary>
        /// 申请日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime APPDTE { get; set; }
        /// <summary>
        /// 申请日期	D, 对应<see cref="APPDTE"/>
        /// </summary>
        [XmlElement("APPDTE")]
        public string APPDTEStr
        {
            get
            {
                return this.APPDTE.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.APPDTE = tmp;
                }
            }
        }
        /// <summary>
        /// 进帐分行	C(3)	附录A.48招行3位分行
        /// </summary>
        public string ACCBBK { get; set; }
        /// <summary>
        /// 进帐机构	C(6)
        /// </summary>
        public string ACCBRN { get; set; }
        /// <summary>
        /// 审批分行	C(3)    附录A.48招行3位分行
        /// </summary>
        public string APRBBK { get; set; }
        /// <summary>
        /// 审批机构	C(6)
        /// </summary>
        public string APRBRN { get; set; }
        /// <summary>
        /// 客户号	C(10)
        /// </summary>
        public string CLTCOD { get; set; }
        /// <summary>
        /// 额度	F(17,2)
        /// </summary>
        public decimal CRLCRL { get; set; }
        /// <summary>
        /// 使用额度	F(17,2)
        /// </summary>
        public decimal CRLUSD { get; set; }
        /// <summary>
        /// 实际余额	F(17,2)
        /// </summary>
        public decimal CRLBAL { get; set; }
        /// <summary>
        /// 可用额度	F(17,2)
        /// </summary>
        public decimal CRLAVE { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CRYNUM { get; set; }
        /// <summary>
        /// 授信开关	C(1)
        /// </summary>
        public string CRDYON { get; set; }
        /// <summary>
        /// 产品类别	C(8)	附录A.49信用管理产品类别
        /// </summary>
        public string BUSTYP { get; set; }
        /// <summary>
        /// 期限	N(3)
        /// </summary>
        public int MNHMNH { get; set; }
        /// <summary>
        /// 有效起始日	D
        /// </summary>
        [XmlIgnore]
        public DateTime STRDTV { get; set; }
        /// <summary>
        /// 有效起始日	D, 对应<see cref="STRDTV"/>
        /// </summary>
        [XmlElement("STRDTV")]
        public string STRDTVStr
        {
            get
            {
                return this.STRDTV.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.STRDTV = tmp;
                }
            }
        }
        /// <summary>
        /// 有效终止日	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDTV { get; set; }
        /// <summary>
        /// 有效终止日	D, 对应<see cref="ENDDTV"/>
        /// </summary>
        [XmlElement("ENDDTV")]
        public string ENDDTVStr
        {
            get
            {
                return this.ENDDTV.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDTV = tmp;
                }
            }
        }
        /// <summary>
        /// 主要担保方式	C(5)
        /// </summary>
        public string GRTTYP { get; set; }
        /// <summary>
        /// 风险度	F(5,3)
        /// </summary>
        public decimal RSKRTO { get; set; }
        /// <summary>
        /// 申请状态	C(4)
        /// </summary>
        public string APPSTS { get; set; }
        /// <summary>
        /// 审批日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime APRDTE { get; set; }
        /// <summary>
        /// 审批日期	D, 对应<see cref="APRDTE"/>
        /// </summary>
        [XmlElement("APRDTE")]
        public string APRDTEStr
        {
            get
            {
                return this.APRDTE.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.APRDTE = tmp;
                }
            }
        }
        /// <summary>
        /// 企业代码	C(20)
        /// </summary>
        public string CTFIDC { get; set; }
        /// <summary>
        /// 企业名称	Z(200)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 特殊条件码	C(20)
        /// </summary>
        public string SPLC20 { get; set; }
    }
}
