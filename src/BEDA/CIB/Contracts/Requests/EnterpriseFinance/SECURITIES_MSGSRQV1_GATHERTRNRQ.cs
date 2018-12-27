using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 单笔托收、子账户托收、回款查询请求主体
    /// </summary>
    public class SECURITIES_MSGSRQV1_GATHERTRNRQ : IRequest<SECURITIES_MSGSRSV1_GATHERTRNRS>
    {
        /// <summary>
        /// 单笔托收、子账户托收、回款查询
        /// </summary>
        public GATHERTRNRQ GATHERTRNRQ { get; set; }
    }
    /// <summary>
    /// 提交托收请求
    /// </summary>
    public class GATHERTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 托收请求节点，如果没有此节点则为查询功能
        /// </summary>
        [XmlElement(Order = 1)]
        public GATHERRQ GATHERRQ { get; set; }
    }
    /// <summary>
    /// 托收请求节点，如果没有此节点则为查询功能
    /// </summary>
    public class GATHERRQ
    {
        /// <summary>
        /// 请求托收信息节点 必输
        /// </summary>
        public GATHERINFO GATHERINFO { get; set; }
    }
    /// <summary>
    /// 请求托收信息节点
    /// </summary>
    public class GATHERINFO
    {
        /// <summary>
        /// 收款账户信息节点 必输
        /// </summary>
        [XmlElement(Order = 0)]
        public GATHER_ACCTTO ACCTTO { get; set; }
        /// <summary>
        /// 单位编码， 4位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string FIRMCODE { get; set; }
        /// <summary>
        /// 人行支付系统5位托收业务编码（区分一代、二代） 必输
        /// 人行二代支付系统5位托收业务编码，说明如下：
        ///00100	电费
        ///00200	水暖费
        ///00300	煤气费
        ///00400	电话费
        ///00500	通讯费
        ///00600	保险费
        ///00700	房屋管理费
        ///00800	代理服务费
        ///00900	学教费
        ///01000	有线电视费
        ///01100	企业管理费
        ///09001	其他
        ///人行一代支付系统5位托收业务编码，说明如下：
        ///00100-电费
        ///00101-家用电费
        ///00102-生成用电费
        ///00200-水暖费
        ///00201-用水费
        ///00202-排水费
        ///00203-直饮水费
        ///00204-污水处理费
        ///00205-暖气费
        ///00300-煤气费
        ///00301-管道煤气费
        ///00400-电话费
        ///00401-市内电话费
        ///00402-长途电话费
        ///00403-移动电话费
        ///00404-电话初装费
        ///00405-IP电话费
        ///00500-通讯费
        ///00501-数据通讯费
        ///00502-线路月租费
        ///00503-代维费
        ///00504-网络使用费
        ///00505-信息服务费
        ///00506-移动电子商务费
        ///00507-网关业务费
        ///00508-手机话费
        ///00600-保险费
        ///00601-续期寿险费
        ///00602-社会保险费
        ///00603-养老保险费
        ///00604-医疗保险费
        ///00605-车辆保险费
        ///00700-房屋管理费
        ///00701-房屋租赁费
        ///00702-租赁服务费
        ///00703-物业管理费
        ///00704-清洁费
        ///00705-保安服务费
        ///00706-电梯维护保养费
        ///00707-绿化费
        ///00708-停车费
        ///00800-代理服务费
        ///00801-押运服务费
        ///00802-票据传递费
        ///00803-代理记账服务费
        ///00900-学教费
        ///00901-报考费
        ///00902-学杂费
        ///00903-保教费
        ///01000-有线电视费
        ///01001-有线电视租赁费
        ///01002-移动电视费
        ///01100-企业管理费用
        ///01101-工商行政管理费
        ///01102-商检费
        ///04900-其他费用
        ///04901-土地使用费
        ///04902-加油卡费
        ///04903-消费贷款
        ///05100-薪金报酬
        ///05101-工资
        ///05102-奖金
        ///05103-养老金
        ///09900-其他代付费用
        ///09901-付福利彩票奖金
        /// </summary>
        [XmlElement(Order = 2)]
        public string BIZCODE { get; set; }
        /// <summary>
        /// 托收摘要代号  非必输 只有二代托收业务编码才有托收摘要代号
        /// 托收业务编码与托收摘要代号对应关系如下：
        /// 00100(电费)摘要代号 007(电费) 是否默认(是)
        /// 00200(水暖费)摘要代号 730(水暖费) 是否默认(是)
        /// 00300(煤气费)摘要代号 009(煤气费) 是否默认(是)
        /// 00300(煤气费)摘要代号 380(燃气费) 是否默认(否)
        /// 00400(电话费)摘要代号 011(固定电话费) 是否默认(是)
        /// 00500(通讯费)摘要代号 754(通讯费) 是否默认(是)
        /// 00600(保险费)摘要代号 601(代理收取保费) 是否默认(是)
        /// 00600(保险费)摘要代号 049(社保费) 是否默认(否)
        /// 00602(社会保险费)摘要代号 049(社保费) 是否默认(是)
        /// 00700(房屋管理费)摘要代号 197(物业管理费) 是否默认(是)
        /// 00800(代理服务费)摘要代号 735(代理服务费) 是否默认(是)
        /// 00900(学教费)摘要代号 844(教育费) 是否默认(是)
        /// 01000(有线电视费)摘要代号 192(有线电视费) 是否默认(是)
        /// 01100(企业管理费)摘要代号 741(企业管理费) 是否默认(是)
        /// 09001(其他)摘要代号 516(费用结算) 是否默认(是)
        /// 09001(其他)摘要代号 747(住房公积金) 是否默认(否)
        /// 09001(其他)摘要代号 125(贷款回收) 是否默认(否)
        /// </summary>
        [XmlElement(Order = 3)]
        public string SUMM { get; set; }
        /// <summary>
        /// 回款期限:1/2/3天 默认为3天
        /// </summary>
        [XmlElement(Order = 4)]
        public int LIMITDAYS { get; set; } = 3;
        /// <summary>
        /// 标题，最大30位
        /// </summary>
        [XmlElement(Order = 5)]
        public string TITLE { get; set; }
        /// <summary>
        /// 托收备注，最大50位
        /// </summary>
        [XmlElement(Order = 6)]
        public string MEMO { get; set; }
        /// <summary>
        /// 交易类型（借0/贷1），可不填。默认为收款（贷），即托收时赋值1。
        /// </summary>
        [XmlElement(Order = 7)]
        public int TRNTYPE { get; set; } = 1;
        /// <summary>
        /// 凭证号，7位数字；可不填，默认使用电子凭证号。	非必输
        /// </summary>
        [XmlElement(Order = 8)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 付款信息节点  必输
        /// </summary>
        [XmlElement(Order = 9)]
        public PAYINFO PAYINFO { get; set; }
    }
    /// <summary>
    /// 收款账户信息节点
    /// </summary>
    public class GATHER_ACCTTO
    {
        /// <summary>
        /// 收款账户(兴业银行账户)，32位
        /// 子账户托收输入22位或24位子账户 必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
    }
    /// <summary>
    /// 付款人账户信息
    /// </summary>
    public class GATHER_ACCTFROM
    {
        /// <summary>
        /// 付款账号，最大32位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 付款账户名称，最大50位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string NAME { get; set; }
        /// <summary>
        /// 付款收报行号，长度12位、他行时必须输入
        /// </summary>
        [XmlElement(Order = 2)]
        public string BANKNUM { get; set; }
        /// <summary>
        /// 付款人开户行名称，最大50位，他行时必须输入
        /// </summary>
        [XmlElement(Order = 3)]
        public string BANKDESC { get; set; }
    }
    /// <summary>
    /// 付款信息节点
    /// </summary>
    public class PAYINFO
    {
        /// <summary>
        /// 序号,最大8位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string INDX { get; set; }
        /// <summary>
        /// 合同号，最大20位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string CONTRACTID { get; set; }
        /// <summary>
        /// 付款人账户信息	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public GATHER_ACCTFROM ACCTFROM { get; set; }
        /// <summary>
        /// 缴费方式    必输
        /// 交易类型<see cref="GATHERINFO.TRNTYPE"/>为1时的缴费方式：
        /// 0表示系统内，  即向本行账户托收  正向托收-系统内缴费
        /// 1表示小额批量，跨行托收   正向托收-小额批量(他行)
        /// 2表示自缴。   正向托收-自缴
        /// 交易类型为0时的缴费方式：
        /// 3-本行账户；   行内反向托收
        /// 4-它行账户。   它行反向托收
        /// </summary>
        [XmlElement(Order = 3)]
        public int PAYMODE { get; set; }
        /// <summary>
        /// 申请收费金额，整数位最长15位，小数2位	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal APPLYAMT { get; set; }
        /// <summary>
        /// 托收用途，最大30位	必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string PURPOSE { get; set; }
        /// <summary>
        /// 业务种类1，最大5位
        /// </summary>
        [XmlElement(Order = 7)]
        public string BIZCODE1 { get; set; }
        /// <summary>
        /// 业务种类2，最大5位
        /// </summary>
        [XmlElement(Order = 8)]
        public string BIZCODE2 { get; set; }
    }
}
