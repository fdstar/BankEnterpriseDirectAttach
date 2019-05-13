using BEDA.CMB.Contracts.Requests;
using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEDA.CMB.Samples
{
    partial class Program
    {
        static void Part_21()
        {
            //RQ21_1_1Sample();
            //RQ21_1_2Sample();
            //RQ21_1_3Sample();
            //RQ21_1_4Sample();
            //RQ21_1_5Sample();
            //RQ21_1_6Sample();
            //RQ21_2_1Sample(); //test
            //RQ21_3_1Sample(); //test
            //RQ21_3_2Sample(); //test
            //RQ21_3_3Sample(); //test
            //RQ21_4_1Sample(); //test
        }

        #region 21.网银互联
        /// <summary>
        /// 21.1.1.查询业务经办业务控制信息
        /// </summary>
        public static void RQ21_1_1Sample()
        {
            var rq = new RQ21_1_1()
            {
                NTBUSMODY = new NTBUSMODY
                {
                    BUSCOD = "N31010",
                    // N31010=网银贷记
                    // N31011=网银借记
                    // N31012 = 第三方贷记
                    // N31013=跨行账户信息查询
                }
            };
            var rs = client.Execute<RQ21_1_1, RS21_1_1>(rq, "外围1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 21.1.2.交易查询
        /// </summary>
        public static void RQ21_1_2Sample()
        {
            var rq = new RQ21_1_2()
            {
                NTQRYEBNY1 = new NTQRYEBNY1
                {
                    BUSCOD = "N31010",
                    BUSMOD = "00001",
                    BGNDAT = DateTime.Now.AddDays(-380),
                    ENDDAT = DateTime.Now.AddDays(-374)
                }
            };
            var rs = client.Execute<RQ21_1_2, RS21_1_2>(rq, "外围1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 21.1.3.业务交易明细查询
        /// </summary>
        public static void RQ21_1_3Sample()
        {
            var rq = new RQ21_1_3()
            {
                NTEBPINFX = new NTEBPINFX
                {
                    REQNBR = "0030091466"
                }
            };
            var rs = client.Execute<RQ21_1_3, RS21_1_3>(rq, "外围1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 21.1.4.取企业银行处理结果
        /// </summary>
        public static void RQ21_1_4Sample()
        {
            var rq = new RQ21_1_4()
            {
                NTRTVSTSX = new NTRTVSTSX
                {
                    REQNBR = "0030091466"
                }
            };
            var rs = client.Execute<RQ21_1_4, RS21_1_4>(rq, "外围1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 21.1.5.业务总揽查询
        /// </summary>
        public static void RQ21_1_5Sample()
        {
            var rq = new RQ21_1_5()
            {
                NTQNPEBPY = new NTQNPEBPY
                {
                    QRYACC = "755914749110111",
                    TRXDIR = "O",
                    MSGNBR = "101",
                    BGNDAT = DateTime.Now.AddDays(-380),
                    ENDDAT = DateTime.Now.AddDays(-360)
                }
            };
            var rs = client.Execute<RQ21_1_5, RS21_1_5>(rq, "外围1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 21.1.6.新交易查询-按业务参考号
        /// </summary>
        public static void RQ21_1_6Sample()
        {
            var rq = new RQ21_1_6()
            {
                NTQRYEBYX1 = new NTQRYEBYX1
                {
                    BUSCOD = "N31010",
                    YURREF = "APP83429820190219155056",
                    BGNDAT = DateTime.Now.AddDays(-380),
                    ENDDAT = DateTime.Now.AddDays(-374)
                }
            };
            var rs = client.Execute<RQ21_1_6, RS21_1_6>(rq, "外围1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 21.2.1.网银贷记
        /// </summary>
        public static void RQ21_2_1Sample()
        {
            var rq = new RQ21_2_1()
            {
                NTOPRMODX = new NTOPRMODX
                {
                    BUSMOD = "00001",
                },
                List = new List<NTIBCOPRX>
                {
                    new NTIBCOPRX
                    {
                        SQRNBR="01",
                        BBKNBR="CB",
                        ACCNBR="755914749110111",
                        CNVNBR="0000000074",
                        YURREF=GetYURREF("21.2.1"),
                        CCYNBR="10",
                        TRSAMT=21.21m,
                        CDTNAM="大来闫",
                        CDTEAC="6212880200000030615",
                        CDTBRD="102100099996",
                        TRSTYP="C201",
                        TRSCAT="02002",
                        RMKTXT="CMB Test",
                    }
                }
            };
            var rs = client.Execute<RQ21_2_1, RS21_2_1>(rq, "外围1");
            Console.WriteLine(rs.INFO.ResponseContent); //REQNBR 0030220596
        }
        /// <summary>
        /// 21.3.1.网银贷记协议签订经办
        /// </summary>
        public static void RQ21_3_1Sample()
        {
            var rq = new RQ21_3_1()
            {
                NTOPRMODX = new NTOPRMODX
                {
                    BUSMOD = "00001",
                },
                NTSGNCBCX = new NTSGNCBCX
                {
                    BBKNBR = "CB",
                    ACCNBR = "755914749110111",
                    YURREF = GetYURREF("21.3.1"),
                    EFTDAT = DateTime.Now,
                    SGNLMT = 100000,
                    DAYCNT = 100,
                    DAYLMT = 1000000,
                }
            };
            var rs = client.Execute<RQ21_3_1, RS21_3_1>(rq, "外围1");
            Console.WriteLine(rs.INFO.ResponseContent);//REQNBR 0030220594
        }
        /// <summary>
        /// 21.3.2.网银借记协议签订经办
        /// </summary>
        public static void RQ21_3_2Sample()
        {
            var rq = new RQ21_3_2()
            {
                NTOPRMODX = new NTOPRMODX
                {
                    BUSMOD = "00001",
                },
                NTSGNCBDX = new NTSGNCBDX
                {
                    BBKNBR = "CB",
                    ACCNBR = "755914749110111",
                    YURREF = GetYURREF("21.3.2"),
                    DBTDIR = "DT01",
                    PHNNBR = "15100001111",
                    OPPACC = "6212880200000030615",
                    OPPANA = "大来闫",
                    OPPPNA = "中国工商银行股份有限公司",
                    ACETYP = "TL04",
                    OPPBRD = "102100099996",
                    OPPCST = "000012311",
                    SGNLMT = 100000,
                    DAYCNT = 100,
                    DAYLMT = 1000000.05m,
                    MTHCNT = 1000,
                    MTHLMT = 1000000000.1m,
                    EFTDAT = DateTime.Now,
                    IFTDAT = DateTime.Now.AddMonths(1),
                }
            };
            var rs = client.Execute<RQ21_3_2, RS21_3_2>(rq, "外围1");
            Console.WriteLine(rs.INFO.ResponseContent); // <REQNBR>0030220603</REQNBR>
        }
        /// <summary>
        /// 21.3.3.协议查询
        /// </summary>
        public static void RQ21_3_3Sample()
        {
            var rq = new RQ21_3_3()
            {
                NTQRYCBQX = new NTQRYCBQX
                {
                    QRYBBK = "CB",
                    QRYACC = "755914749110111",
                }
            };
            var rs = client.Execute<RQ21_3_3, RS21_3_3>(rq, "外围1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 21.4.1.网银借记
        /// </summary>
        public static void RQ21_4_1Sample()
        {
            var rq = new RQ21_4_1()
            {
                NTOPRMODX = new NTOPRMODX
                {
                    BUSMOD = "00003",
                },
                List = new List<NTIBDOPRX>
                {
                    new NTIBDOPRX
                    {
                        SQRNBR="01",
                        BBKNBR="CB",
                        ACCNBR="755914749110111",
                        CNVNBR="0000000074",
                        YURREF=GetYURREF("21.4.1"),
                        CCYNBR="10",
                        TRSAMT=21.41m,
                        TRSTYP="D200",
                        TRSCAT="00100",
                        RMKTXT="CMB Test",
                    }
                }
            };
            var rs = client.Execute<RQ21_4_1, RS21_4_1>(rq, "外围1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        #endregion
    }
}
