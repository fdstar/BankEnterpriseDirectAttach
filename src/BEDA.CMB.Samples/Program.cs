using BEDA.CMB.Contracts.Requests;
using BEDA.CMB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEDA.CMB.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.系统管理
            //RQ1_4Sample();
            //RQ1_5Sample();
            //RQ1_6Sample();
            //RQ1_8Sample();
            //RQ1_9Sample();
            #endregion

            #region 2.账户管理
            //RQ2_1Sample();
            //RQ2_2Sample();
            //RQ2_3Sample();
            //RQ2_4Sample();
            //RQ2_5Sample();
            //RQ2_6Sample();
            //RQ2_7Sample();
            //RQ2_8Sample();
            //RQ2_9Sample();
            #endregion

            #region 3.支付结算
            //RQ3_3Sample();
            //RQ3_4Sample();
            //RQ3_5Sample();
            //RQ3_6Sample();
            //RQ3_7Sample();
            //RQ3_8Sample();
            //RQ3_9Sample();
            //RQ3_10Sample();
            //RQ3_11Sample();
            #endregion

            #region 4.代发代扣
            //RQ4_1Sample();
            //RQ4_2Sample();
            //RQ4_3Sample();
            //RQ4_4Sample();
            //RQ4_5Sample();
            //RQ4_6Sample();
            //RQ4_7Sample();
            //RQ4_8Sample();
            //RQ4_9Sample();
            //RQ4_10Sample();
            #endregion

            #region 21.网银互联
            //RQ21_1_1Sample();
            //RQ21_1_2Sample();
            //RQ21_1_3Sample();
            #endregion

            Console.ReadLine();
        }

        #region 基础部分
        const string loginName = "银企直连专用集团1";
        const string ip = "127.0.0.1";
        const int port = 8082;
        static ICMBClient client = new CMBClient(ip, port);
        static string GetYURREF(string no)
        {
            var tmp = string.Format("{0:yyyyMMddHHmmss}_{1}", DateTime.Now, no);
            return tmp;
        }
        #endregion

        #region 1.系统管理
        /// <summary>
        /// 1.4.取新的通知
        /// </summary>
        public static void RQ1_4Sample()
        {
            var rq = new RQ1_4();
            var rs = client.Execute<RQ1_4, RS1_4>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 1.5.取系统信息
        /// </summary>
        public static void RQ1_5Sample()
        {
            var rq = new RQ1_5()
            {
                SDKSYINFX = new SDKSYINFX()
            };
            var rs = client.Execute<RQ1_5, RS1_5>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 1.6.查询可经办业务模式
        /// </summary>
        public static void RQ1_6Sample()
        {
            var rq = new RQ1_6()
            {
                SDKMDLSTX = new SDKMDLSTX
                {
                    BUSCOD = "N02030"
                }
            };
            var rs = client.Execute<RQ1_6, RS1_6>(rq, loginName);
            var txt = string.Join("\r", rs.List.Select(x => x.BUSMOD));
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 1.8.查询历史通知
        /// </summary>
        public static void RQ1_8Sample()
        {
            var rq = new RQ1_8()
            {
                FBDLRHMGX = new FBDLRHMGX
                {
                    BGNDAT = DateTime.Now.AddDays(-7),
                    ENDDAT = DateTime.Now,
                    //MSGTYP = "NCBUSFIN"
                    //NCBCHOPR 
                    //NCDRTPAY  
                    //NCCRTTRS
                    //NCDBTTRS
                    //NCBUSFIN
                }
            };
            var rs = client.Execute<RQ1_8, RS1_8>(rq, loginName);
            var txt1 = string.Join("\r", rs.NCDRTPAYList?.Select(x => x.BBKNBR + "," + x.KEYVAL).Distinct());
            var txt2 = string.Join("\r", rs.NCCRTTRSList?.Select(x => x.BBKNBR + "," + x.ACCNBR).Distinct());
            var txt3 = string.Join("\r", rs.NCDBTTRSList?.Select(x => x.BBKNBR + "," + x.ACCNBR).Distinct());
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 1.9.查询历史通知（新）
        /// </summary>
        public static void RQ1_9Sample()
        {
            var rq = new RQ1_9()
            {
                DCHISMSGX = new DCHISMSGX
                {
                    BGNDAT = DateTime.Now.AddDays(-100),
                    ENDDAT = DateTime.Now,
                    RECNUM = "100",
                    MSGTYP = "NCBCHOPR"
                    //NCBCHOPR 
                    //NCDRTPAY  
                    //NCCRTTRS
                    //NCDBTTRS
                    //NCBUSFIN
                }
            };
            var rs = client.Execute<RQ1_9, RS1_9>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        #endregion

        #region 2.账户管理
        /// <summary>
        /// 2.1.查询可查询/可经办的账户列表
        /// </summary>
        public static void RQ2_1Sample()
        {
            var rq = new RQ2_1()
            {
                SDKACLSTX = new SDKACLSTX
                {
                    BUSCOD = "N02030",
                    BUSMOD = "00001"
                }
            };
            var rs = client.Execute<RQ2_1, RS2_1>(rq, loginName);
            var txt = string.Join("\r", rs.List.Select(x => x.BBKNBR + "," + x.ACCNBR));
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 2.2.查询账户详细信息
        /// </summary>
        public static void RQ2_2Sample()
        {
            var rq = new RQ2_2()
            {
                List = new List<SDKACINFX>
                {
                   new SDKACINFX{
                        BBKNBR="59",
                        ACCNBR="591902896732601",
                   },
                   new SDKACINFX{
                       BBKNBR="59",
                       ACCNBR ="591902896810104"
                   }
                }
            };
            var rs = client.Execute<RQ2_2, RS2_2>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 2.3.查询账户交易信息
        /// </summary>
        public static void RQ2_3Sample()
        {
            var rq = new RQ2_3()
            {
                SDKTSINFX = new SDKTSINFX
                {
                    BBKNBR = "59",
                    ACCNBR = "591902896710201",
                    BGNDAT = DateTime.Now.AddYears(-1).AddDays(-10),
                    ENDDAT = DateTime.Now.AddYears(-1).AddDays(-1),
                }
            };
            var rs = client.Execute<RQ2_3, RS2_3>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 2.4.账户交易信息断点查询
        /// </summary>
        public static void RQ2_4Sample()
        {
            var rq = new RQ2_4()
            {
                SDKRBPTRSX = new SDKRBPTRSX
                {
                    BBKNBR = "59",
                    ACCNBR = "591902896710201",
                    TRSDAT = DateTime.Now.AddDays(-370),
                }
            };
            var rs = client.Execute<RQ2_4, RS2_4>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 2.5.查询账户历史余额
        /// </summary>
        public static void RQ2_5Sample()
        {
            var rq = new RQ2_5()
            {
                NTQABINFY = new NTQABINFY
                {
                    BBKNBR = "59",
                    ACCNBR = "591902896710201",
                    BGNDAT = DateTime.Now.AddYears(-1).AddDays(-30),
                    ENDDAT = DateTime.Now.AddYears(-1).AddDays(-5)
                }
            };
            var rs = client.Execute<RQ2_5, RS2_5>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 2.6.查询分行号信息
        /// </summary>
        public static void RQ2_6Sample()
        {
            var rq = new RQ2_6()
            {
                NTACCBBKY = new NTACCBBKY
                {
                    ACCNBR = ""
                }
            };
            var rs = client.Execute<RQ2_6, RS2_6>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 2.7.查询电子回单信息
        /// </summary>
        public static void RQ2_7Sample()
        {
            var rq = new RQ2_7()
            {
                CSRRCFDFY0 = new CSRRCFDFY0
                {
                    EACNBR = "591902896710201",
                    BEGDAT = DateTime.Now.AddDays(-370),
                    ENDDAT = DateTime.Now.AddDays(-369),
                    RRCFLG = 1,
                }
            };
            var rs = client.Execute<RQ2_7, RS2_7>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 2.8.查询电子回单信息（保存图片）
        /// </summary>
        public static void RQ2_8Sample()
        {
            var rq = new RQ2_8()
            {
                CSRRCFDFY0 = new CSRRCFDFY0
                {
                    EACNBR = "591902896710201",
                    BEGDAT = DateTime.Now.AddDays(-370),
                    ENDDAT = DateTime.Now.AddDays(-369),
                    RRCFLG = 1,
                }
            };
            var rs = client.Execute<RQ2_8, RS2_8>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 2.9.批量查询余额
        /// </summary>
        public static void RQ2_9Sample()
        {
            var rq = new RQ2_9()
            {
                List = new List<NTQADINFX>
                {
                   new NTQADINFX{
                        BBKNBR="59",
                        ACCNBR="591902896732601",
                   },
                   new NTQADINFX{
                       BBKNBR="59",
                       ACCNBR ="591902896810104"
                   }
                }
            };
            var rs = client.Execute<RQ2_9, RS2_9>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        #endregion

        #region 3.支付结算
        /// <summary>
        /// 3.3.支付结果列表查询
        /// </summary>
        public static void RQ3_3Sample()
        {
            var rq = new RQ3_3()
            {
                NTQRYSTNY1 = new NTQRYSTNY1
                {
                    BUSCOD = "N02030",
                    BUSMOD = "00001",
                    BGNDAT = DateTime.Now.AddDays(-380),
                    ENDDAT = DateTime.Now.AddDays(-374)
                }
            };
            var rs = client.Execute<RQ3_3, RS3_3>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 3.4.查询收方限制列表
        /// </summary>
        public static void RQ3_4Sample()
        {
            var rq = new RQ3_4()
            {
            };
            var rs = client.Execute<RQ3_4, RS3_4>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 3.5.查询批量支付经办结果
        /// </summary>
        public static void RQ3_5Sample()
        {
            var rq = new RQ3_5()
            {
                SDQPYRSTX = new SDQPYRSTX
                {
                    RSTSET= "Z1KJ37I3J4"
                }
            };
            var rs = client.Execute<RQ3_5, RS3_5>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 3.6.直接支付
        /// </summary>
        public static void RQ3_6Sample()
        {
            var rq = new RQ3_6()
            {
                SDKPAYRQX = new SDKPAYRQX
                {
                    BUSCOD = "N02031",
                },
                List = new List<DCOPDPAYX>
                {
                    new DCOPDPAYX
                    {
                        YURREF= GetYURREF("3.6"),
                        DBTACC="591902896710201",
                        DBTBBK="59",
                        TRSAMT=101.5m,
                        CCYNBR="10",
                        STLCHN="N",
                        NUSAGE="直接支付用途NUSAGE",
                        BUSNAR="业务摘要BUSNAR",
                        CRTACC="6225880230001175",
                        CRTNAM="刘五",
                        BNKFLG="Y",
                    }
                }
            };
            var rs = client.Execute<RQ3_6, RS3_6>(rq, loginName);//20190313194710_3.6
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 3.7.直接内转
        /// </summary>
        public static void RQ3_7Sample()
        {
            var rq = new RQ3_7()
            {
                SDKPAYRQX = new SDKPAYRQX
                {
                    BUSMOD= "00001"
                },
                List = new List<DCOPRTRFX>
                {
                    new DCOPRTRFX
                    {
                        YURREF= GetYURREF("3.7"),
                        DBTACC="591902896710201",
                        DBTBBK="59",
                        TRSAMT=103.5m,
                        CCYNBR="10",
                        NUSAGE="直接内转用途NUSAGE",
                        BUSNAR="直接内转业务摘要BUSNAR",
                        CRTACC="591902896810104",
                    }
                }
            };
            var rs = client.Execute<RQ3_7, RS3_7>(rq, loginName);//20190313200139_3.7
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 3.8.支付经办（需要网银审批）
        /// </summary>
        public static void RQ3_8Sample()
        {
            var rq = new RQ3_8()
            {
                SDKPAYRQX = new SDKPAYRQX
                {
                    BUSCOD = "N02030",
                     BUSMOD= "00001",
                },
                List = new List<DCPAYREQX>
                {
                    new DCPAYREQX
                    {
                        YURREF= GetYURREF("3.8"),
                        DBTACC="591902896710201",
                        DBTBBK="59",
                        TRSAMT=101.5m,
                        CCYNBR="10",
                        STLCHN="N",
                        NUSAGE="支付经办用途NUSAGE",
                        BUSNAR="支付经办业务摘要BUSNAR",
                        CRTACC="6225880230001175",
                        CRTNAM="刘五",
                        BNKFLG="Y",
                        CRTPVC="重庆",
                        CRTCTY="重庆",
                    }
                }
            };
            var rs = client.Execute<RQ3_8, RS3_8>(rq, loginName);//20190313202944_3.8
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        public static void RQ3_9Sample()
        {
            var rq = new RQ3_9()
            {
                List = new List<NTSTLINFX>
                {
                    new NTSTLINFX{
                         REQNBR="0030103551"
                    },
                    new NTSTLINFX{
                         REQNBR="0030103539"
                    },
                    new NTSTLINFX{
                         REQNBR="0030103534"
                    },
                }
            };
            var rs = client.Execute<RQ3_9, RS3_9>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 3.10.跨境划拨额度查询
        /// </summary>
        public static void RQ3_10Sample()
        {
            var rq = new RQ3_10()
            {
                NTBUSMODY = new NTBUSMODY()
            };
            var rs = client.Execute<RQ3_10, RS3_10>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        public static void RQ3_11Sample()
        {
            var rq = new RQ3_11()
            {
                NTQRYSTYX1 = new NTQRYSTYX1
                {
                    BUSCOD = "N02031",
                    YURREF = "20190313194710_3.6",
                    BGNDAT = new DateTime(2018, 03, 15),
                    ENDDAT = new DateTime(2018, 03, 17)
                }
            };
            var rs = client.Execute<RQ3_11, RS3_11>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        #endregion

        #region 4.代发代扣
        /// <summary>
        /// 4.1.查询交易代码
        /// </summary>
        public static void RQ4_1Sample()
        {
            var rq = new RQ4_1()
            {
                NTAGTLS2X = new NTAGTLS2X
                {
                    BUSCOD = "N03020",
                    ACCNBR = "591902896710201",
                }
            };
            var rs = client.Execute<RQ4_1, RS4_1>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 4.2.直接代发代扣
        /// </summary>
        public static void RQ4_2Sample()
        {
            var rq = new RQ4_2()
            {
                SDKATSRQX = new SDKATSRQX
                {
                    BUSCOD = "N03020",
                    BUSMOD = "00001",
                    TRSTYP = "BYTF",
                    DBTACC = "591902896710201",
                    BBKNBR = "59",
                    SUM = 102.5m,
                    TOTAL = 1,
                    YURREF = GetYURREF("4.2"),
                    MEMO = "直接代发代扣MEMO代发",
                },
                List = new List<SDKATDRQX>
                {
                    new SDKATDRQX
                    {
                        ACCNBR="6225880280003345",
                        CLTNAM="王二",
                        TRSAMT=102.5m,
                        BNKFLG="Y",
                    }
                }
            };
            var rs = client.Execute<RQ4_2, RS4_2>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);//REQNBR>0030103687</REQNBR
        }
        /// <summary>
        /// 4.3.查询交易概要信息
        /// </summary>
        public static void RQ4_3Sample()
        {
            var rq = new RQ4_3()
            {
                NTAGCINNY1=new NTAGCINNY1
                {
                    BUSCOD = "N03020",
                    BUSMOD = "00001",
                    BGNDAT = new DateTime(2018, 3, 15),
                    ENDDAT = new DateTime(2018, 3, 20),
                }
            };
            var rs = client.Execute<RQ4_3, RS4_3>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 4.4.查询交易明细信息
        /// </summary>
        public static void RQ4_4Sample()
        {
            var rq = new RQ4_4()
            {
                SDKATDQYX = new SDKATDQYX
                {
                    REQNBR = "0030103687"
                }
            };
            var rs = client.Execute<RQ4_4, RS4_4>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 4.5.代发工资额度查询
        /// </summary>
        public static void RQ4_5Sample()
        {
            var rq = new RQ4_5()
            {
                NTAGCLMTX1 = new NTAGCLMTX1
                {
                    ACCNBR = "591902896710201",
                    BBKNBR = "59"
                }
            };
            var rs = client.Execute<RQ4_5, RS4_5>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 4.6.大批量代发工资经办
        /// </summary>
        public static void RQ4_6Sample()
        {
            var rq = new RQ4_6()
            {
                NTBUSMODY = new NTBUSMODY
                {
                    BUSMOD = "00001"
                },
                NTAGCAGCX1 = new NTAGCAGCX1
                {
                    BEGTAG = "Y",
                    ENDTAG = "Y",
                    TTLAMT = 52.5m,
                    TTLCNT = 1,
                    TTLNUM = 1,
                    CURAMT = 52.5m,
                    TRSTYP = "BYSA",
                    CURCNT = 1,
                    CCYNBR = "10",
                    ACCNBR = "591902896710201",
                    BBKNBR = "59",
                    CCYMKT = "0",
                    NUSAGE = "大批量代发工资经办NUSAGE",
                    YURREF = GetYURREF("4.6"),
                    //ExpectedTime = DateTime.Now.AddYears(-1),
                },
                List = new List<NTAGCDTLY1>
                {
                    new NTAGCDTLY1
                    {
                        TRXSEQ=1,
                        ACCNBR="6225880280003345",
                        ACCNAM="王二",
                        TRSAMT=52.5m,
                        BNKFLG="Y",
                        TRSDSP="王二代发工资"
                    }
                }
            };
            var rs = client.Execute<RQ4_6, RS4_6>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);//<REQNBR>0030103753</REQNBR>
        }
        /// <summary>
        /// 4.7.大批量代发经办
        /// </summary>
        public static void RQ4_7Sample()
        {
            var rq = new RQ4_7()
            {
                NTBUSMODY = new NTBUSMODY
                {
                    BUSMOD = "00001"
                },
                NTAGCAGCX1 = new NTAGCAGCX1
                {
                    BEGTAG = "Y",
                    ENDTAG = "Y",
                    TTLAMT = 152.5m,
                    TTLCNT = 1,
                    TTLNUM = 1,
                    CURAMT = 152.5m,
                    TRSTYP = "BYTF",
                    CURCNT = 1,
                    CCYNBR = "10",
                    ACCNBR = "591902896710201",
                    BBKNBR = "59",
                    CCYMKT = "0",
                    NUSAGE = "代发劳务收入NUSAGE",
                    YURREF = GetYURREF("4.7"),
                    //ExpectedTime = DateTime.Now.AddYears(-1),
                },
                List = new List<NTAGCDTLY1>
                {
                    new NTAGCDTLY1
                    {
                        TRXSEQ=1,
                        ACCNBR="6225880280003345",
                        ACCNAM="王二",
                        TRSAMT=152.5m,
                        BNKFLG="Y",
                        TRSDSP="王二代发劳务收入"
                    }
                }
            };
            var rs = client.Execute<RQ4_7, RS4_7>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);//<REQNBR>0030103771</REQNBR>
        }
        /// <summary>
        /// 4.8.大批量代扣经办
        /// </summary>
        public static void RQ4_8Sample()
        {
            var rq = new RQ4_8()
            {
                NTBUSMODY = new NTBUSMODY
                {
                    BUSMOD = "00001"
                },
                NTAGCAGCX1 = new NTAGCAGCX1
                {
                    BEGTAG = "Y",
                    ENDTAG = "Y",
                    TTLAMT = 32.5m,
                    TTLCNT = 1,
                    TTLNUM = 1,
                    CURAMT = 32.5m,
                    TRSTYP = "AYTL",
                    CURCNT = 1,
                    CCYNBR = "10",
                    ACCNBR = "755915704910503",
                    BBKNBR = "75",
                    CCYMKT = "0",
                    NUSAGE = "代扣电话费NUSAGE",
                    YURREF = GetYURREF("4.8"),
                    //ExpectedTime = DateTime.Now.AddYears(-1),
                },
                List = new List<NTAGCDTLY1>
                {
                    new NTAGCDTLY1
                    {
                        TRXSEQ=1,
                        ACCNBR="6225880230001175",
                        ACCNAM="刘    五",
                        TRSAMT=32.5m,
                        BNKFLG="Y",
                        TRSDSP="刘    五代扣电话费"
                    }
                }
            };
            var rs = client.Execute<RQ4_8, RS4_8>(rq, "银企直连测试用户143");
            Console.WriteLine(rs.INFO.ResponseContent);//<REQNBR>0030103780</REQNBR>
        }
        /// <summary>
        /// 4.9.查询大批量代发代扣明细信息
        /// </summary>
        public static void RQ4_9Sample()
        {
            var rq = new RQ4_9()
            {
                NTAGDINFY1=new NTAGDINFY1
                {
                    REQNBR = "0030103780"
                }
            };
            var rs = client.Execute<RQ4_9, RS4_9>(rq, "银企直连测试用户143");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 4.10.代发结果列表查询-按业务参考号
        /// </summary>
        public static void RQ4_10Sample()
        {
            var rq = new RQ4_10()
            {
                NTAGCINYX1 = new NTAGCINYX1
                {
                    BUSCOD = "N03010",
                    YURREF = "20190314142125_4.6",
                    BGNDAT = new DateTime(2018, 3, 15),
                    ENDDAT = new DateTime(2018, 3, 20),
                }
            };
            var rs = client.Execute<RQ4_10, RS4_10>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        #endregion

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
        #endregion
    }
}
