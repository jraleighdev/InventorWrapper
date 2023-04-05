using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InventorWrapper.Data
{
    public class HoleSizes
    {
        public List<HoleSizeData> AnsiUnifiedScrewThreads { get; set; }

        public HoleSizes()
        {
            AnsiUnifiedScrewThreads = new List<HoleSizeData>
            {
                new HoleSizeData {
                    Size = 0.0118,
                    SizeSuffix = "",
                    ThreadDesignation = "30-318 UNM",
                    CustomThreadDesignation = "30-318 UNM",
                    TPI = 318,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.0138,
                    SizeSuffix = "",
                    ThreadDesignation = "35-282 UNM",
                    CustomThreadDesignation = "35-282 UNM",
                    TPI = 282,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.0157,
                    SizeSuffix = "",
                    ThreadDesignation = "40-254 UNM",
                    CustomThreadDesignation = "40-254 UNM",
                    TPI = 254,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    
                    Size = 0.0177,
                    SizeSuffix = "",
                    ThreadDesignation = "45-254 UNM",
                    CustomThreadDesignation = "45-254 UNM",
                    TPI = 254,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    
                    Size = 0.0197,
                    SizeSuffix = "",
                    ThreadDesignation = "50-203 UNM",
                    CustomThreadDesignation = "50-203 UNM",
                    TPI = 203,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    
                    Size = 0.021,
                    SizeSuffix = "",
                    ThreadDesignation = "0000-160 NS",
                    CustomThreadDesignation = "0000-160 NS",
                    TPI = 160,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    
                    Size = 0.0217,
                    SizeSuffix = "",
                    ThreadDesignation = "55-203 UNM",
                    CustomThreadDesignation = "55-203 UNM",
                    TPI = 203,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    
                    Size = 0.0236,
                    SizeSuffix = "",
                    ThreadDesignation = "60-169 UNM",
                    CustomThreadDesignation = "60-169 UNM",
                    TPI = 169,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    
                    Size = 0.0276,
                    SizeSuffix = "",
                    ThreadDesignation = "70-145 UNM",
                    CustomThreadDesignation = "70-145 UNM",
                    TPI = 145,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    
                    Size = 0.0315,
                    SizeSuffix = "",
                    ThreadDesignation = "80-127 UNM",
                    CustomThreadDesignation = "80-127 UNM",
                    TPI = 127,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.034,
                    SizeSuffix = "",
                    ThreadDesignation = "000-120 NS",
                    CustomThreadDesignation = "000-120 NS",
                    TPI = 120,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.0354,
                    SizeSuffix = "",
                    ThreadDesignation = "90-113 UNM",
                    CustomThreadDesignation = "90-113 UNM",
                    TPI = 113,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.0394,
                    SizeSuffix = "",
                    ThreadDesignation = "100-102 UNM",
                    CustomThreadDesignation = "100-102 UNM",
                    TPI = 102,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.0433,
                    SizeSuffix = "",
                    ThreadDesignation = "110-102 UNM",
                    CustomThreadDesignation = "110-102 UNM",
                    TPI = 102,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.047,
                    SizeSuffix = "",
                    ThreadDesignation = "00-90 NS",
                    CustomThreadDesignation = "00-90 NS",
                    TPI = 90,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.047,
                    SizeSuffix = "",
                    ThreadDesignation = "00-96 NS",
                    CustomThreadDesignation = "00-96 NS",
                    TPI = 96,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.0472,
                    SizeSuffix = "",
                    ThreadDesignation = "120-102 UNM",
                    CustomThreadDesignation = "120-102 UNM",
                    TPI = 102,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.0551,
                    SizeSuffix = "",
                    ThreadDesignation = "140-85 UNM",
                    CustomThreadDesignation = "140-85 UNM",
                    TPI = 85,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.06,
                    SizeSuffix = "(#0)",
                    ThreadDesignation = "0-80 UNF",
                    CustomThreadDesignation = "0-80 UNF",
                    TPI = 80,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.06,
                    SizeSuffix = "(#0)",
                    ThreadDesignation = "0-80 UNF",
                    CustomThreadDesignation = "0-80 UNF",
                    TPI = 80,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.06,
                    SizeSuffix = "(#0)",
                    ThreadDesignation = "0-72 UNF",
                    CustomThreadDesignation = "0-72 UNF",
                    TPI = 72,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.06,
                    SizeSuffix = "(#0)",
                    ThreadDesignation = "0-72 UNF",
                    CustomThreadDesignation = "0-72 UNF",
                    TPI = 72,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.073,
                    SizeSuffix = "(#1)",
                    ThreadDesignation = "1-64 UNC",
                    CustomThreadDesignation = "1-64 UNC",
                    TPI = 64,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.073,
                    SizeSuffix = "(#1)",
                    ThreadDesignation = "1-64 UNC",
                    CustomThreadDesignation = "1-64 UNC",
                    TPI = 64,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.073,
                    SizeSuffix = "(#1)",
                    ThreadDesignation = "1-72 UNF",
                    CustomThreadDesignation = "1-72 UNF",
                    TPI = 72,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.073,
                    SizeSuffix = "(#1)",
                    ThreadDesignation = "1-72 UNF",
                    CustomThreadDesignation = "1-72 UNF",
                    TPI = 72,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.086,
                    SizeSuffix = "(#2)",
                    ThreadDesignation = "2-56 UNC",
                    CustomThreadDesignation = "2-56 UNC",
                    TPI = 56,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.086,
                    SizeSuffix = "(#2)",
                    ThreadDesignation = "2-56 UNC",
                    CustomThreadDesignation = "2-56 UNC",
                    TPI = 56,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.086,
                    SizeSuffix = "(#2)",
                    ThreadDesignation = "2-64 UNF",
                    CustomThreadDesignation = "2-64 UNF",
                    TPI = 64,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.086,
                    SizeSuffix = "(#2)",
                    ThreadDesignation = "2-64 UNF",
                    CustomThreadDesignation = "2-64 UNF",
                    TPI = 64,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.099,
                    SizeSuffix = "(#3)",
                    ThreadDesignation = "3-48 UNC",
                    CustomThreadDesignation = "3-48 UNC",
                    TPI = 48,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.099,
                    SizeSuffix = "(#3)",
                    ThreadDesignation = "3-48 UNC",
                    CustomThreadDesignation = "3-48 UNC",
                    TPI = 48,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.099,
                    SizeSuffix = "(#3)",
                    ThreadDesignation = "3-56 UNF",
                    CustomThreadDesignation = "3-56 UNF",
                    TPI = 56,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.099,
                    SizeSuffix = "(#3)",
                    ThreadDesignation = "3-56 UNF",
                    CustomThreadDesignation = "3-56 UNF",
                    TPI = 56,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.112,
                    SizeSuffix = "(#4)",
                    ThreadDesignation = "4-40 UNC",
                    CustomThreadDesignation = "4-40 UNC",
                    TPI = 40,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.112,
                    SizeSuffix = "(#4)",
                    ThreadDesignation = "4-40 UNC",
                    CustomThreadDesignation = "4-40 UNC",
                    TPI = 40,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.112,
                    SizeSuffix = "(#4)",
                    ThreadDesignation = "4-48 UNF",
                    CustomThreadDesignation = "4-48 UNF",
                    TPI = 48,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.112,
                    SizeSuffix = "(#4)",
                    ThreadDesignation = "4-48 UNF",
                    CustomThreadDesignation = "4-48 UNF",
                    TPI = 48,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.125,
                    SizeSuffix = "(#5)",
                    ThreadDesignation = "5-40 UNC",
                    CustomThreadDesignation = "5-40 UNC",
                    TPI = 40,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.125,
                    SizeSuffix = "(#5)",
                    ThreadDesignation = "5-40 UNC",
                    CustomThreadDesignation = "5-40 UNC",
                    TPI = 40,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.125,
                    SizeSuffix = "(#5)",
                    ThreadDesignation = "5-44 UNF",
                    CustomThreadDesignation = "5-44 UNF",
                    TPI = 44,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.125,
                    SizeSuffix = "(#5)",
                    ThreadDesignation = "5-44 UNF",
                    CustomThreadDesignation = "5-44 UNF",
                    TPI = 44,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.138,
                    SizeSuffix = "(#6)",
                    ThreadDesignation = "6-32 UNC",
                    CustomThreadDesignation = "6-32 UNC",
                    TPI = 32,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.138,
                    SizeSuffix = "(#6)",
                    ThreadDesignation = "6-32 UNC",
                    CustomThreadDesignation = "6-32 UNC",
                    TPI = 32,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.138,
                    SizeSuffix = "(#6)",
                    ThreadDesignation = "6-40 UNF",
                    CustomThreadDesignation = "6-40 UNF",
                    TPI = 40,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.138,
                    SizeSuffix = "(#6)",
                    ThreadDesignation = "6-40 UNF",
                    CustomThreadDesignation = "6-40 UNF",
                    TPI = 40,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.164,
                    SizeSuffix = "(#8)",
                    ThreadDesignation = "8-32 UNC",
                    CustomThreadDesignation = "8-32 UNC",
                    TPI = 32,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.164,
                    SizeSuffix = "(#8)",
                    ThreadDesignation = "8-32 UNC",
                    CustomThreadDesignation = "8-32 UNC",
                    TPI = 32,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.164,
                    SizeSuffix = "(#8)",
                    ThreadDesignation = "8-36 UNF",
                    CustomThreadDesignation = "8-36 UNF",
                    TPI = 36,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.164,
                    SizeSuffix = "(#8)",
                    ThreadDesignation = "8-36 UNF",
                    CustomThreadDesignation = "8-36 UNF",
                    TPI = 36,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.19,
                    SizeSuffix = "(#10)",
                    ThreadDesignation = "10-24 UNC",
                    CustomThreadDesignation = "10-24 UNC",
                    TPI = 24,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.19,
                    SizeSuffix = "(#10)",
                    ThreadDesignation = "10-24 UNC",
                    CustomThreadDesignation = "10-24 UNC",
                    TPI = 24,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.19,
                    SizeSuffix = "(#10)",
                    ThreadDesignation = "10-28 UNS",
                    CustomThreadDesignation = "10-28 UNS",
                    TPI = 28,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.19,
                    SizeSuffix = "(#10)",
                    ThreadDesignation = "10-32 UNF",
                    CustomThreadDesignation = "10-32 UNF",
                    TPI = 32,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.19,
                    SizeSuffix = "(#10)",
                    ThreadDesignation = "10-32 UNF",
                    CustomThreadDesignation = "10-32 UNF",
                    TPI = 32,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.19,
                    SizeSuffix = "(#10)",
                    ThreadDesignation = "10-36 UNS",
                    CustomThreadDesignation = "10-36 UNS",
                    TPI = 36,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.19,
                    SizeSuffix = "(#10)",
                    ThreadDesignation = "10-40 UNS",
                    CustomThreadDesignation = "10-40 UNS",
                    TPI = 40,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.19,
                    SizeSuffix = "(#10)",
                    ThreadDesignation = "10-48 UNS",
                    CustomThreadDesignation = "10-48 UNS",
                    TPI = 48,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.19,
                    SizeSuffix = "(#10)",
                    ThreadDesignation = "10-56 UNS",
                    CustomThreadDesignation = "10-56 UNS",
                    TPI = 56,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.216,
                    SizeSuffix = "(#12)",
                    ThreadDesignation = "12-24 UNC",
                    CustomThreadDesignation = "12-24 UNC",
                    TPI = 24,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.216,
                    SizeSuffix = "(#12)",
                    ThreadDesignation = "12-24 UNC",
                    CustomThreadDesignation = "12-24 UNC",
                    TPI = 24,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.216,
                    SizeSuffix = "(#12)",
                    ThreadDesignation = "12-28 UNF",
                    CustomThreadDesignation = "12-28 UNF",
                    TPI = 28,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.216,
                    SizeSuffix = "(#12)",
                    ThreadDesignation = "12-28 UNF",
                    CustomThreadDesignation = "12-28 UNF",
                    TPI = 28,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.216,
                    SizeSuffix = "(#12)",
                    ThreadDesignation = "12-32 UNEF",
                    CustomThreadDesignation = "12-32 UNEF",
                    TPI = 32,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.216,
                    SizeSuffix = "(#12)",
                    ThreadDesignation = "12-32 UNEF",
                    CustomThreadDesignation = "12-32 UNEF",
                    TPI = 32,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.216,
                    SizeSuffix = "(#12)",
                    ThreadDesignation = "12-36 UNS",
                    CustomThreadDesignation = "12-36 UNS",
                    TPI = 36,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.216,
                    SizeSuffix = "(#12)",
                    ThreadDesignation = "12-40 UNS",
                    CustomThreadDesignation = "12-40 UNS",
                    TPI = 40,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.216,
                    SizeSuffix = "(#12)",
                    ThreadDesignation = "12-48 UNS",
                    CustomThreadDesignation = "12-48 UNS",
                    TPI = 48,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.216,
                    SizeSuffix = "(#12)",
                    ThreadDesignation = "12-56 UNS",
                    CustomThreadDesignation = "12-56 UNS",
                    TPI = 56,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1/4-20 UNC",
                    CustomThreadDesignation = "1/4-20 UNC",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1/4-20 UNC",
                    CustomThreadDesignation = "1/4-20 UNC",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1/4-20 UNC",
                    CustomThreadDesignation = "1/4-20 UNC",
                    TPI = 20,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 0.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1/4-24 UNS",
                    CustomThreadDesignation = "1/4-24 UNS",
                    TPI = 24,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1/4-27 UNS",
                    CustomThreadDesignation = "1/4-27 UNS",
                    TPI = 27,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1/4-28 UNF",
                    CustomThreadDesignation = "1/4-28 UNF",
                    TPI = 28,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1/4-28 UNF",
                    CustomThreadDesignation = "1/4-28 UNF",
                    TPI = 28,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1/4-28 UNF",
                    CustomThreadDesignation = "1/4-28 UNF",
                    TPI = 28,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 0.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1/4-32 UNEF",
                    CustomThreadDesignation = "1/4-32 UNEF",
                    TPI = 32,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1/4-32 UNEF",
                    CustomThreadDesignation = "1/4-32 UNEF",
                    TPI = 32,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1/4-36 UNS",
                    CustomThreadDesignation = "1/4-36 UNS",
                    TPI = 36,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1/4-40 UNS",
                    CustomThreadDesignation = "1/4-40 UNS",
                    TPI = 40,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1/4-48 UNS",
                    CustomThreadDesignation = "1/4-48 UNS",
                    TPI = 48,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1/4-56 UNS",
                    CustomThreadDesignation = "1/4-56 UNS",
                    TPI = 56,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "5/16-18 UNC",
                    CustomThreadDesignation = "5/16-18 UNC",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "5/16-18 UNC",
                    CustomThreadDesignation = "5/16-18 UNC",
                    TPI = 18,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "5/16-18 UNC",
                    CustomThreadDesignation = "5/16-18 UNC",
                    TPI = 18,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 0.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "5/16-20 UN",
                    CustomThreadDesignation = "5/16-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "5/16-20 UN",
                    CustomThreadDesignation = "5/16-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "5/16-24 UNF",
                    CustomThreadDesignation = "5/16-24 UNF",
                    TPI = 24,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "5/16-24 UNF",
                    CustomThreadDesignation = "5/16-24 UNF",
                    TPI = 24,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "5/16-24 UNF",
                    CustomThreadDesignation = "5/16-24 UNF",
                    TPI = 24,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 0.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "5/16-27 UNS",
                    CustomThreadDesignation = "5/16-27 UNS",
                    TPI = 27,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "5/16-28 UN",
                    CustomThreadDesignation = "5/16-28 UN",
                    TPI = 28,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "5/16-28 UN",
                    CustomThreadDesignation = "5/16-28 UN",
                    TPI = 28,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "5/16-32 UNEF",
                    CustomThreadDesignation = "5/16-32 UNEF",
                    TPI = 32,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "5/16-32 UNEF",
                    CustomThreadDesignation = "5/16-32 UNEF",
                    TPI = 32,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "5/16-36 UNS",
                    CustomThreadDesignation = "5/16-36 UNS",
                    TPI = 36,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "5/16-40 UNS",
                    CustomThreadDesignation = "5/16-40 UNS",
                    TPI = 40,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "5/16-48 UNS",
                    CustomThreadDesignation = "5/16-48 UNS",
                    TPI = 48,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3/8-16 UNC",
                    CustomThreadDesignation = "3/8-16 UNC",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3/8-16 UNC",
                    CustomThreadDesignation = "3/8-16 UNC",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3/8-16 UNC",
                    CustomThreadDesignation = "3/8-16 UNC",
                    TPI = 16,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 0.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3/8-18 UNS",
                    CustomThreadDesignation = "3/8-18 UNS",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3/8-20 UN",
                    CustomThreadDesignation = "3/8-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3/8-20 UN",
                    CustomThreadDesignation = "3/8-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3/8-24 UNF",
                    CustomThreadDesignation = "3/8-24 UNF",
                    TPI = 24,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3/8-24 UNF",
                    CustomThreadDesignation = "3/8-24 UNF",
                    TPI = 24,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3/8-24 UNF",
                    CustomThreadDesignation = "3/8-24 UNF",
                    TPI = 24,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 0.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3/8-27 UNS",
                    CustomThreadDesignation = "3/8-27 UNS",
                    TPI = 27,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3/8-28 UN",
                    CustomThreadDesignation = "3/8-28 UN",
                    TPI = 28,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3/8-28 UN",
                    CustomThreadDesignation = "3/8-28 UN",
                    TPI = 28,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3/8-32 UNEF",
                    CustomThreadDesignation = "3/8-32 UNEF",
                    TPI = 32,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3/8-32 UNEF",
                    CustomThreadDesignation = "3/8-32 UNEF",
                    TPI = 32,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3/8-36 UNS",
                    CustomThreadDesignation = "3/8-36 UNS",
                    TPI = 36,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3/8-40 UNS",
                    CustomThreadDesignation = "3/8-40 UNS",
                    TPI = 40,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.39,
                    SizeSuffix = "",
                    ThreadDesignation = "0.390-27 UNS",
                    CustomThreadDesignation = "0.390-27 UNS",
                    TPI = 27,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "7/16-14 UNC",
                    CustomThreadDesignation = "7/16-14 UNC",
                    TPI = 14,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "7/16-14 UNC",
                    CustomThreadDesignation = "7/16-14 UNC",
                    TPI = 14,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "7/16-14 UNC",
                    CustomThreadDesignation = "7/16-14 UNC",
                    TPI = 14,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 0.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "7/16-16 UN",
                    CustomThreadDesignation = "7/16-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "7/16-16 UN",
                    CustomThreadDesignation = "7/16-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "7/16-18 UNS",
                    CustomThreadDesignation = "7/16-18 UNS",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "7/16-20 UNF",
                    CustomThreadDesignation = "7/16-20 UNF",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "7/16-20 UNF",
                    CustomThreadDesignation = "7/16-20 UNF",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "7/16-20 UNF",
                    CustomThreadDesignation = "7/16-20 UNF",
                    TPI = 20,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 0.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "7/16-24 UNS",
                    CustomThreadDesignation = "7/16-24 UNS",
                    TPI = 24,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "7/16-27 UNS",
                    CustomThreadDesignation = "7/16-27 UNS",
                    TPI = 27,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "7/16-28 UNEF",
                    CustomThreadDesignation = "7/16-28 UNEF",
                    TPI = 28,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "7/16-28 UNEF",
                    CustomThreadDesignation = "7/16-28 UNEF",
                    TPI = 28,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "7/16-32 UN",
                    CustomThreadDesignation = "7/16-32 UN",
                    TPI = 32,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "7/16-32 UN",
                    CustomThreadDesignation = "7/16-32 UN",
                    TPI = 32,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1/2-13 UNC",
                    CustomThreadDesignation = "1/2-13 UNC",
                    TPI = 13,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1/2-13 UNC",
                    CustomThreadDesignation = "1/2-13 UNC",
                    TPI = 13,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1/2-13 UNC",
                    CustomThreadDesignation = "1/2-13 UNC",
                    TPI = 13,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 0.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1/2-12 UNS",
                    CustomThreadDesignation = "1/2-12 UNS",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1/2-12 UNS",
                    CustomThreadDesignation = "1/2-12 UNS",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1/2-14 UNS",
                    CustomThreadDesignation = "1/2-14 UNS",
                    TPI = 14,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1/2-16 UN",
                    CustomThreadDesignation = "1/2-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1/2-16 UN",
                    CustomThreadDesignation = "1/2-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1/2-18 UNS",
                    CustomThreadDesignation = "1/2-18 UNS",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1/2-20 UNF",
                    CustomThreadDesignation = "1/2-20 UNF",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1/2-20 UNF",
                    CustomThreadDesignation = "1/2-20 UNF",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1/2-20 UNF",
                    CustomThreadDesignation = "1/2-20 UNF",
                    TPI = 20,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 0.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1/2-24 UNS",
                    CustomThreadDesignation = "1/2-24 UNS",
                    TPI = 24,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1/2-27 UNS",
                    CustomThreadDesignation = "1/2-27 UNS",
                    TPI = 27,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1/2-28 UNEF",
                    CustomThreadDesignation = "1/2-28 UNEF",
                    TPI = 28,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1/2-28 UNEF",
                    CustomThreadDesignation = "1/2-28 UNEF",
                    TPI = 28,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1/2-32 UN",
                    CustomThreadDesignation = "1/2-32 UN",
                    TPI = 32,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1/2-32 UN",
                    CustomThreadDesignation = "1/2-32 UN",
                    TPI = 32,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "9/16-12 UNC",
                    CustomThreadDesignation = "9/16-12 UNC",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "9/16-12 UNC",
                    CustomThreadDesignation = "9/16-12 UNC",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "9/16-12 UNC",
                    CustomThreadDesignation = "9/16-12 UNC",
                    TPI = 12,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 0.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "9/16-14 UNS",
                    CustomThreadDesignation = "9/16-14 UNS",
                    TPI = 14,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "9/16-16 UN",
                    CustomThreadDesignation = "9/16-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "9/16-16 UN",
                    CustomThreadDesignation = "9/16-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "9/16-18 UNF",
                    CustomThreadDesignation = "9/16-18 UNF",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "9/16-18 UNF",
                    CustomThreadDesignation = "9/16-18 UNF",
                    TPI = 18,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "9/16-18 UNF",
                    CustomThreadDesignation = "9/16-18 UNF",
                    TPI = 18,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 0.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "9/16-20 UN",
                    CustomThreadDesignation = "9/16-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "9/16-20 UN",
                    CustomThreadDesignation = "9/16-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "9/16-24 UNEF",
                    CustomThreadDesignation = "9/16-24 UNEF",
                    TPI = 24,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "9/16-24 UNEF",
                    CustomThreadDesignation = "9/16-24 UNEF",
                    TPI = 24,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "9/16-27 UNS",
                    CustomThreadDesignation = "9/16-27 UNS",
                    TPI = 27,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "9/16-28 UN",
                    CustomThreadDesignation = "9/16-28 UN",
                    TPI = 28,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "9/16-28 UN",
                    CustomThreadDesignation = "9/16-28 UN",
                    TPI = 28,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "9/16-32 UN",
                    CustomThreadDesignation = "9/16-32 UN",
                    TPI = 32,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "9/16-32 UN",
                    CustomThreadDesignation = "9/16-32 UN",
                    TPI = 32,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.625,
                    SizeSuffix = "",
                    ThreadDesignation = "5/8-11 UNC",
                    CustomThreadDesignation = "5/8-11 UNC",
                    TPI = 11,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.625,
                    SizeSuffix = "",
                    ThreadDesignation = "5/8-11 UNC",
                    CustomThreadDesignation = "5/8-11 UNC",
                    TPI = 11,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.625,
                    SizeSuffix = "",
                    ThreadDesignation = "5/8-11 UNC",
                    CustomThreadDesignation = "5/8-11 UNC",
                    TPI = 11,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 0.625,
                    SizeSuffix = "",
                    ThreadDesignation = "5/8-12 UN",
                    CustomThreadDesignation = "5/8-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.625,
                    SizeSuffix = "",
                    ThreadDesignation = "5/8-12 UN",
                    CustomThreadDesignation = "5/8-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.625,
                    SizeSuffix = "",
                    ThreadDesignation = "5/8-14 UNS",
                    CustomThreadDesignation = "5/8-14 UNS",
                    TPI = 14,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.625,
                    SizeSuffix = "",
                    ThreadDesignation = "5/8-16 UN",
                    CustomThreadDesignation = "5/8-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.625,
                    SizeSuffix = "",
                    ThreadDesignation = "5/8-16 UN",
                    CustomThreadDesignation = "5/8-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.625,
                    SizeSuffix = "",
                    ThreadDesignation = "5/8-18 UNF",
                    CustomThreadDesignation = "5/8-18 UNF",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.625,
                    SizeSuffix = "",
                    ThreadDesignation = "5/8-18 UNF",
                    CustomThreadDesignation = "5/8-18 UNF",
                    TPI = 18,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.625,
                    SizeSuffix = "",
                    ThreadDesignation = "5/8-18 UNF",
                    CustomThreadDesignation = "5/8-18 UNF",
                    TPI = 18,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 0.625,
                    SizeSuffix = "",
                    ThreadDesignation = "5/8-20 UN",
                    CustomThreadDesignation = "5/8-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.625,
                    SizeSuffix = "",
                    ThreadDesignation = "5/8-20 UN",
                    CustomThreadDesignation = "5/8-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.625,
                    SizeSuffix = "",
                    ThreadDesignation = "5/8-24 UNEF",
                    CustomThreadDesignation = "5/8-24 UNEF",
                    TPI = 24,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.625,
                    SizeSuffix = "",
                    ThreadDesignation = "5/8-24 UNEF",
                    CustomThreadDesignation = "5/8-24 UNEF",
                    TPI = 24,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.625,
                    SizeSuffix = "",
                    ThreadDesignation = "5/8-27 UNS",
                    CustomThreadDesignation = "5/8-27 UNS",
                    TPI = 27,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.625,
                    SizeSuffix = "",
                    ThreadDesignation = "5/8-28 UN",
                    CustomThreadDesignation = "5/8-28 UN",
                    TPI = 28,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.625,
                    SizeSuffix = "",
                    ThreadDesignation = "5/8-28 UN",
                    CustomThreadDesignation = "5/8-28 UN",
                    TPI = 28,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.625,
                    SizeSuffix = "",
                    ThreadDesignation = "5/8-32 UN",
                    CustomThreadDesignation = "5/8-32 UN",
                    TPI = 32,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.625,
                    SizeSuffix = "",
                    ThreadDesignation = "5/8-32 UN",
                    CustomThreadDesignation = "5/8-32 UN",
                    TPI = 32,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "11/16-12 UN",
                    CustomThreadDesignation = "11/16-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "11/16-12 UN",
                    CustomThreadDesignation = "11/16-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "11/16-16 UN",
                    CustomThreadDesignation = "11/16-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "11/16-16 UN",
                    CustomThreadDesignation = "11/16-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "11/16-20 UN",
                    CustomThreadDesignation = "11/16-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "11/16-20 UN",
                    CustomThreadDesignation = "11/16-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "11/16-24 UNEF",
                    CustomThreadDesignation = "11/16-24 UNEF",
                    TPI = 24,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "11/16-24 UNEF",
                    CustomThreadDesignation = "11/16-24 UNEF",
                    TPI = 24,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "11/16-28 UN",
                    CustomThreadDesignation = "11/16-28 UN",
                    TPI = 28,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "11/16-28 UN",
                    CustomThreadDesignation = "11/16-28 UN",
                    TPI = 28,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "11/16-32 UN",
                    CustomThreadDesignation = "11/16-32 UN",
                    TPI = 32,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "11/16-32 UN",
                    CustomThreadDesignation = "11/16-32 UN",
                    TPI = 32,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3/4-10 UNC",
                    CustomThreadDesignation = "3/4-10 UNC",
                    TPI = 10,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3/4-10 UNC",
                    CustomThreadDesignation = "3/4-10 UNC",
                    TPI = 10,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3/4-10 UNC",
                    CustomThreadDesignation = "3/4-10 UNC",
                    TPI = 10,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 0.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3/4-12 UN",
                    CustomThreadDesignation = "3/4-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3/4-12 UN",
                    CustomThreadDesignation = "3/4-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3/4-14 UNS",
                    CustomThreadDesignation = "3/4-14 UNS",
                    TPI = 14,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3/4-16 UNF",
                    CustomThreadDesignation = "3/4-16 UNF",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3/4-16 UNF",
                    CustomThreadDesignation = "3/4-16 UNF",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3/4-16 UNF",
                    CustomThreadDesignation = "3/4-16 UNF",
                    TPI = 16,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 0.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3/4-18 UNS",
                    CustomThreadDesignation = "3/4-18 UNS",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3/4-20 UNEF",
                    CustomThreadDesignation = "3/4-20 UNEF",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3/4-20 UNEF",
                    CustomThreadDesignation = "3/4-20 UNEF",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3/4-24 UNS",
                    CustomThreadDesignation = "3/4-24 UNS",
                    TPI = 24,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3/4-24 UNS",
                    CustomThreadDesignation = "3/4-24 UNS",
                    TPI = 24,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3/4-28 UN",
                    CustomThreadDesignation = "3/4-28 UN",
                    TPI = 28,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3/4-28 UN",
                    CustomThreadDesignation = "3/4-28 UN",
                    TPI = 28,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3/4-32 UN",
                    CustomThreadDesignation = "3/4-32 UN",
                    TPI = 32,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3/4-32 UN",
                    CustomThreadDesignation = "3/4-32 UN",
                    TPI = 32,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.8125,
                    SizeSuffix = "",
                    ThreadDesignation = "13/16-10 UNC",
                    CustomThreadDesignation = "13/16-10 UNC",
                    TPI = 10,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.8125,
                    SizeSuffix = "",
                    ThreadDesignation = "13/16-10 UNC",
                    CustomThreadDesignation = "13/16-10 UNC",
                    TPI = 10,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.8125,
                    SizeSuffix = "",
                    ThreadDesignation = "13/16-12 UN",
                    CustomThreadDesignation = "13/16-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.8125,
                    SizeSuffix = "",
                    ThreadDesignation = "13/16-12 UN",
                    CustomThreadDesignation = "13/16-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.8125,
                    SizeSuffix = "",
                    ThreadDesignation = "13/16-16 UN",
                    CustomThreadDesignation = "13/16-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.8125,
                    SizeSuffix = "",
                    ThreadDesignation = "13/16-16 UN",
                    CustomThreadDesignation = "13/16-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.8125,
                    SizeSuffix = "",
                    ThreadDesignation = "13/16-20 UNEF",
                    CustomThreadDesignation = "13/16-20 UNEF",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.8125,
                    SizeSuffix = "",
                    ThreadDesignation = "13/16-20 UNEF",
                    CustomThreadDesignation = "13/16-20 UNEF",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.8125,
                    SizeSuffix = "",
                    ThreadDesignation = "13/16-28 UN",
                    CustomThreadDesignation = "13/16-28 UN",
                    TPI = 28,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.8125,
                    SizeSuffix = "",
                    ThreadDesignation = "13/16-28 UN",
                    CustomThreadDesignation = "13/16-28 UN",
                    TPI = 28,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.8125,
                    SizeSuffix = "",
                    ThreadDesignation = "13/16-32 UN",
                    CustomThreadDesignation = "13/16-32 UN",
                    TPI = 32,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.8125,
                    SizeSuffix = "",
                    ThreadDesignation = "13/16-32 UN",
                    CustomThreadDesignation = "13/16-32 UN",
                    TPI = 32,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.875,
                    SizeSuffix = "",
                    ThreadDesignation = "7/8-9 UNC",
                    CustomThreadDesignation = "7/8-9 UNC",
                    TPI = 9,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.875,
                    SizeSuffix = "",
                    ThreadDesignation = "7/8-9 UNC",
                    CustomThreadDesignation = "7/8-9 UNC",
                    TPI = 9,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.875,
                    SizeSuffix = "",
                    ThreadDesignation = "7/8-9 UNC",
                    CustomThreadDesignation = "7/8-9 UNC",
                    TPI = 9,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 0.875,
                    SizeSuffix = "",
                    ThreadDesignation = "7/8-10 UNS",
                    CustomThreadDesignation = "7/8-10 UNS",
                    TPI = 10,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.875,
                    SizeSuffix = "",
                    ThreadDesignation = "7/8-12 UN",
                    CustomThreadDesignation = "7/8-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.875,
                    SizeSuffix = "",
                    ThreadDesignation = "7/8-12 UN",
                    CustomThreadDesignation = "7/8-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.875,
                    SizeSuffix = "",
                    ThreadDesignation = "7/8-14 UNF",
                    CustomThreadDesignation = "7/8-14 UNF",
                    TPI = 14,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.875,
                    SizeSuffix = "",
                    ThreadDesignation = "7/8-14 UNF",
                    CustomThreadDesignation = "7/8-14 UNF",
                    TPI = 14,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.875,
                    SizeSuffix = "",
                    ThreadDesignation = "7/8-14 UNF",
                    CustomThreadDesignation = "7/8-14 UNF",
                    TPI = 14,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 0.875,
                    SizeSuffix = "",
                    ThreadDesignation = "7/8-16 UN",
                    CustomThreadDesignation = "7/8-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.875,
                    SizeSuffix = "",
                    ThreadDesignation = "7/8-16 UN",
                    CustomThreadDesignation = "7/8-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.875,
                    SizeSuffix = "",
                    ThreadDesignation = "7/8-18 UNS",
                    CustomThreadDesignation = "7/8-18 UNS",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.875,
                    SizeSuffix = "",
                    ThreadDesignation = "7/8-20 UNEF",
                    CustomThreadDesignation = "7/8-20 UNEF",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.875,
                    SizeSuffix = "",
                    ThreadDesignation = "7/8-20 UNEF",
                    CustomThreadDesignation = "7/8-20 UNEF",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.875,
                    SizeSuffix = "",
                    ThreadDesignation = "7/8-24 UNS",
                    CustomThreadDesignation = "7/8-24 UNS",
                    TPI = 24,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.875,
                    SizeSuffix = "",
                    ThreadDesignation = "7/8-27 UNS",
                    CustomThreadDesignation = "7/8-27 UNS",
                    TPI = 27,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.875,
                    SizeSuffix = "",
                    ThreadDesignation = "7/8-28 UN",
                    CustomThreadDesignation = "7/8-28 UN",
                    TPI = 28,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.875,
                    SizeSuffix = "",
                    ThreadDesignation = "7/8-28 UN",
                    CustomThreadDesignation = "7/8-28 UN",
                    TPI = 28,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.875,
                    SizeSuffix = "",
                    ThreadDesignation = "7/8-32 UN",
                    CustomThreadDesignation = "7/8-32 UN",
                    TPI = 32,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.875,
                    SizeSuffix = "",
                    ThreadDesignation = "7/8-32 UN",
                    CustomThreadDesignation = "7/8-32 UN",
                    TPI = 32,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.9375,
                    SizeSuffix = "",
                    ThreadDesignation = "15/16-9 UNC",
                    CustomThreadDesignation = "15/16-9 UNC",
                    TPI = 9,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.9375,
                    SizeSuffix = "",
                    ThreadDesignation = "15/16-9 UNC",
                    CustomThreadDesignation = "15/16-9 UNC",
                    TPI = 9,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.9375,
                    SizeSuffix = "",
                    ThreadDesignation = "15/16-12 UN",
                    CustomThreadDesignation = "15/16-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.9375,
                    SizeSuffix = "",
                    ThreadDesignation = "15/16-12 UN",
                    CustomThreadDesignation = "15/16-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.9375,
                    SizeSuffix = "",
                    ThreadDesignation = "15/16-16 UN",
                    CustomThreadDesignation = "15/16-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.9375,
                    SizeSuffix = "",
                    ThreadDesignation = "15/16-16 UN",
                    CustomThreadDesignation = "15/16-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.9375,
                    SizeSuffix = "",
                    ThreadDesignation = "15/16-20 UNEF",
                    CustomThreadDesignation = "15/16-20 UNEF",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.9375,
                    SizeSuffix = "",
                    ThreadDesignation = "15/16-20 UNEF",
                    CustomThreadDesignation = "15/16-20 UNEF",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.9375,
                    SizeSuffix = "",
                    ThreadDesignation = "15/16-28 UN",
                    CustomThreadDesignation = "15/16-28 UN",
                    TPI = 28,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.9375,
                    SizeSuffix = "",
                    ThreadDesignation = "15/16-28 UN",
                    CustomThreadDesignation = "15/16-28 UN",
                    TPI = 28,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 0.9375,
                    SizeSuffix = "",
                    ThreadDesignation = "15/16-32 UN",
                    CustomThreadDesignation = "15/16-32 UN",
                    TPI = 32,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 0.9375,
                    SizeSuffix = "",
                    ThreadDesignation = "15/16-32 UN",
                    CustomThreadDesignation = "15/16-32 UN",
                    TPI = 32,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1,
                    SizeSuffix = "",
                    ThreadDesignation = "1-8 UNC",
                    CustomThreadDesignation = "1-8 UNC",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1,
                    SizeSuffix = "",
                    ThreadDesignation = "1-8 UNC",
                    CustomThreadDesignation = "1-8 UNC",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1,
                    SizeSuffix = "",
                    ThreadDesignation = "1-8 UNC",
                    CustomThreadDesignation = "1-8 UNC",
                    TPI = 8,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 1,
                    SizeSuffix = "",
                    ThreadDesignation = "1-10 UNS",
                    CustomThreadDesignation = "1-10 UNS",
                    TPI = 10,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1,
                    SizeSuffix = "",
                    ThreadDesignation = "1-12 UNF",
                    CustomThreadDesignation = "1-12 UNF",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1,
                    SizeSuffix = "",
                    ThreadDesignation = "1-12 UNF",
                    CustomThreadDesignation = "1-12 UNF",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1,
                    SizeSuffix = "",
                    ThreadDesignation = "1-12 UNF",
                    CustomThreadDesignation = "1-12 UNF",
                    TPI = 12,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 1,
                    SizeSuffix = "",
                    ThreadDesignation = "1-14 UNS",
                    CustomThreadDesignation = "1-14 UNS",
                    TPI = 14,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1,
                    SizeSuffix = "",
                    ThreadDesignation = "1-14 UNS",
                    CustomThreadDesignation = "1-14 UNS",
                    TPI = 14,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1,
                    SizeSuffix = "",
                    ThreadDesignation = "1-14 UNS",
                    CustomThreadDesignation = "1-14 UNS",
                    TPI = 14,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 1,
                    SizeSuffix = "",
                    ThreadDesignation = "1-16 UN",
                    CustomThreadDesignation = "1-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1,
                    SizeSuffix = "",
                    ThreadDesignation = "1-16 UN",
                    CustomThreadDesignation = "1-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1,
                    SizeSuffix = "",
                    ThreadDesignation = "1-18 UNS",
                    CustomThreadDesignation = "1-18 UNS",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1,
                    SizeSuffix = "",
                    ThreadDesignation = "1-20 UNEF",
                    CustomThreadDesignation = "1-20 UNEF",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1,
                    SizeSuffix = "",
                    ThreadDesignation = "1-20 UNEF",
                    CustomThreadDesignation = "1-20 UNEF",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1,
                    SizeSuffix = "",
                    ThreadDesignation = "1-24 UNS",
                    CustomThreadDesignation = "1-24 UNS",
                    TPI = 24,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1,
                    SizeSuffix = "",
                    ThreadDesignation = "1-27 UNS",
                    CustomThreadDesignation = "1-27 UNS",
                    TPI = 27,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1,
                    SizeSuffix = "",
                    ThreadDesignation = "1-28 UN",
                    CustomThreadDesignation = "1-28 UN",
                    TPI = 28,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1,
                    SizeSuffix = "",
                    ThreadDesignation = "1-28 UN",
                    CustomThreadDesignation = "1-28 UN",
                    TPI = 28,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1,
                    SizeSuffix = "",
                    ThreadDesignation = "1-32 UN",
                    CustomThreadDesignation = "1-32 UN",
                    TPI = 32,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1,
                    SizeSuffix = "",
                    ThreadDesignation = "1-32 UN",
                    CustomThreadDesignation = "1-32 UN",
                    TPI = 32,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.0625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/16-8 UNC",
                    CustomThreadDesignation = "1 1/16-8 UNC",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.0625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/16-8 UN",
                    CustomThreadDesignation = "1 1/16-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.0625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/16-8 UN",
                    CustomThreadDesignation = "1 1/16-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.0625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/16-12 UN",
                    CustomThreadDesignation = "1 1/16-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.0625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/16-12 UN",
                    CustomThreadDesignation = "1 1/16-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.0625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/16-16 UNC",
                    CustomThreadDesignation = "1 1/16-16 UNC",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.0625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/16-16 UNC",
                    CustomThreadDesignation = "1 1/16-16 UNC",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.0625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/16-18 UNEF",
                    CustomThreadDesignation = "1 1/16-18 UNEF",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.0625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/16-18 UNEF",
                    CustomThreadDesignation = "1 1/16-18 UNEF",
                    TPI = 18,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.0625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/16-20 UN",
                    CustomThreadDesignation = "1 1/16-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.0625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/16-20 UN",
                    CustomThreadDesignation = "1 1/16-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.0625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/16-28 UN",
                    CustomThreadDesignation = "1 1/16-28 UN",
                    TPI = 28,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.0625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/16-28 UN",
                    CustomThreadDesignation = "1 1/16-28 UN",
                    TPI = 28,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/8-7 UNC",
                    CustomThreadDesignation = "1 1/8-7 UNC",
                    TPI = 7,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/8-7 UNC",
                    CustomThreadDesignation = "1 1/8-7 UNC",
                    TPI = 7,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/8-7 UNC",
                    CustomThreadDesignation = "1 1/8-7 UNC",
                    TPI = 7,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 1.125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/8-8 UN",
                    CustomThreadDesignation = "1 1/8-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/8-8 UN",
                    CustomThreadDesignation = "1 1/8-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/8-8 UNC",
                    CustomThreadDesignation = "1 1/8-8 UNC",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/8-10 UNS",
                    CustomThreadDesignation = "1 1/8-10 UNS",
                    TPI = 10,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/8-12 UNF",
                    CustomThreadDesignation = "1 1/8-12 UNF",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/8-12 UNF",
                    CustomThreadDesignation = "1 1/8-12 UNF",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/8-12 UNF",
                    CustomThreadDesignation = "1 1/8-12 UNF",
                    TPI = 12,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 1.125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/8-14 UNS",
                    CustomThreadDesignation = "1 1/8-14 UNS",
                    TPI = 14,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/8-16 UN",
                    CustomThreadDesignation = "1 1/8-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/8-16 UN",
                    CustomThreadDesignation = "1 1/8-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/8-18 UNEF",
                    CustomThreadDesignation = "1 1/8-18 UNEF",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/8-18 UNEF",
                    CustomThreadDesignation = "1 1/8-18 UNEF",
                    TPI = 18,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/8-20 UN",
                    CustomThreadDesignation = "1 1/8-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/8-20 UN",
                    CustomThreadDesignation = "1 1/8-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/8-24 UNS",
                    CustomThreadDesignation = "1 1/8-24 UNS",
                    TPI = 24,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/8-28 UN",
                    CustomThreadDesignation = "1 1/8-28 UN",
                    TPI = 28,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/8-28 UN",
                    CustomThreadDesignation = "1 1/8-28 UN",
                    TPI = 28,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.1875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/16-8 UN",
                    CustomThreadDesignation = "1 3/16-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.1875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/16-8 UN",
                    CustomThreadDesignation = "1 3/16-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.1875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/16-12 UN",
                    CustomThreadDesignation = "1 3/16-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.1875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/16-12 UN",
                    CustomThreadDesignation = "1 3/16-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.1875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/16-16 UN",
                    CustomThreadDesignation = "1 3/16-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.1875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/16-16 UN",
                    CustomThreadDesignation = "1 3/16-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.1875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/16-18 UNEF",
                    CustomThreadDesignation = "1 3/16-18 UNEF",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.1875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/16-18 UNEF",
                    CustomThreadDesignation = "1 3/16-18 UNEF",
                    TPI = 18,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.1875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/16-20 UN",
                    CustomThreadDesignation = "1 3/16-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.1875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/16-20 UN",
                    CustomThreadDesignation = "1 3/16-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.1875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/16-28 UN",
                    CustomThreadDesignation = "1 3/16-28 UN",
                    TPI = 28,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.1875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/16-28 UN",
                    CustomThreadDesignation = "1 3/16-28 UN",
                    TPI = 28,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/4-7 UNC",
                    CustomThreadDesignation = "1 1/4-7 UNC",
                    TPI = 7,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/4-7 UNC",
                    CustomThreadDesignation = "1 1/4-7 UNC",
                    TPI = 7,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/4-7 UNC",
                    CustomThreadDesignation = "1 1/4-7 UNC",
                    TPI = 7,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 1.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/4-8 UN",
                    CustomThreadDesignation = "1 1/4-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/4-8 UN",
                    CustomThreadDesignation = "1 1/4-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/4-8 UNC",
                    CustomThreadDesignation = "1 1/4-8 UNC",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/4-10 UNS",
                    CustomThreadDesignation = "1 1/4-10 UNS",
                    TPI = 10,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/4-12 UNF",
                    CustomThreadDesignation = "1 1/4-12 UNF",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/4-12 UNF",
                    CustomThreadDesignation = "1 1/4-12 UNF",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/4-12 UNF",
                    CustomThreadDesignation = "1 1/4-12 UNF",
                    TPI = 12,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 1.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/4-14 UNS",
                    CustomThreadDesignation = "1 1/4-14 UNS",
                    TPI = 14,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/4-16 UN",
                    CustomThreadDesignation = "1 1/4-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/4-16 UN",
                    CustomThreadDesignation = "1 1/4-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/4-18 UNEF",
                    CustomThreadDesignation = "1 1/4-18 UNEF",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/4-18 UNEF",
                    CustomThreadDesignation = "1 1/4-18 UNEF",
                    TPI = 18,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/4-20 UN",
                    CustomThreadDesignation = "1 1/4-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/4-20 UN",
                    CustomThreadDesignation = "1 1/4-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/4-24 UNS",
                    CustomThreadDesignation = "1 1/4-24 UNS",
                    TPI = 24,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/4-28 UN",
                    CustomThreadDesignation = "1 1/4-28 UN",
                    TPI = 28,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.25,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/4-28 UN",
                    CustomThreadDesignation = "1 1/4-28 UN",
                    TPI = 28,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/16-8 UN",
                    CustomThreadDesignation = "1 5/16-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/16-8 UN",
                    CustomThreadDesignation = "1 5/16-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/16-12 UN",
                    CustomThreadDesignation = "1 5/16-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/16-12 UN",
                    CustomThreadDesignation = "1 5/16-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/16-16 UN",
                    CustomThreadDesignation = "1 5/16-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/16-16 UN",
                    CustomThreadDesignation = "1 5/16-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/16-18 UNEF",
                    CustomThreadDesignation = "1 5/16-18 UNEF",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/16-18 UNEF",
                    CustomThreadDesignation = "1 5/16-18 UNEF",
                    TPI = 18,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/16-20 UN",
                    CustomThreadDesignation = "1 5/16-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/16-20 UN",
                    CustomThreadDesignation = "1 5/16-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/16-28 UN",
                    CustomThreadDesignation = "1 5/16-28 UN",
                    TPI = 28,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/16-28 UN",
                    CustomThreadDesignation = "1 5/16-28 UN",
                    TPI = 28,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/8-6 UNC",
                    CustomThreadDesignation = "1 3/8-6 UNC",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/8-6 UNC",
                    CustomThreadDesignation = "1 3/8-6 UNC",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/8-6 UNC",
                    CustomThreadDesignation = "1 3/8-6 UNC",
                    TPI = 6,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 1.375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/8-8 UN",
                    CustomThreadDesignation = "1 3/8-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/8-8 UN",
                    CustomThreadDesignation = "1 3/8-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/8-10 UNS",
                    CustomThreadDesignation = "1 3/8-10 UNS",
                    TPI = 10,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/8-12 UNF",
                    CustomThreadDesignation = "1 3/8-12 UNF",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/8-12 UNF",
                    CustomThreadDesignation = "1 3/8-12 UNF",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/8-12 UNF",
                    CustomThreadDesignation = "1 3/8-12 UNF",
                    TPI = 12,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 1.375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/8-14 UNS",
                    CustomThreadDesignation = "1 3/8-14 UNS",
                    TPI = 14,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/8-16 UN",
                    CustomThreadDesignation = "1 3/8-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/8-16 UN",
                    CustomThreadDesignation = "1 3/8-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/8-18 UNEF",
                    CustomThreadDesignation = "1 3/8-18 UNEF",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/8-18 UNEF",
                    CustomThreadDesignation = "1 3/8-18 UNEF",
                    TPI = 18,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/8-20 UN",
                    CustomThreadDesignation = "1 3/8-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/8-20 UN",
                    CustomThreadDesignation = "1 3/8-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/8-24 UNS",
                    CustomThreadDesignation = "1 3/8-24 UNS",
                    TPI = 24,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/8-28 UN",
                    CustomThreadDesignation = "1 3/8-28 UN",
                    TPI = 28,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/8-28 UN",
                    CustomThreadDesignation = "1 3/8-28 UN",
                    TPI = 28,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/16-6 UN",
                    CustomThreadDesignation = "1 7/16-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/16-6 UN",
                    CustomThreadDesignation = "1 7/16-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/16-8 UN",
                    CustomThreadDesignation = "1 7/16-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/16-8 UN",
                    CustomThreadDesignation = "1 7/16-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/16-12 UN",
                    CustomThreadDesignation = "1 7/16-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/16-12 UN",
                    CustomThreadDesignation = "1 7/16-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/16-16 UN",
                    CustomThreadDesignation = "1 7/16-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/16-16 UN",
                    CustomThreadDesignation = "1 7/16-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/16-18 UNEF",
                    CustomThreadDesignation = "1 7/16-18 UNEF",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/16-18 UNEF",
                    CustomThreadDesignation = "1 7/16-18 UNEF",
                    TPI = 18,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/16-20 UN",
                    CustomThreadDesignation = "1 7/16-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/16-20 UN",
                    CustomThreadDesignation = "1 7/16-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/16-28 UN",
                    CustomThreadDesignation = "1 7/16-28 UN",
                    TPI = 28,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/16-28 UN",
                    CustomThreadDesignation = "1 7/16-28 UN",
                    TPI = 28,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/2-6 UNC",
                    CustomThreadDesignation = "1 1/2-6 UNC",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/2-6 UNC",
                    CustomThreadDesignation = "1 1/2-6 UNC",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/2-6 UNC",
                    CustomThreadDesignation = "1 1/2-6 UNC",
                    TPI = 6,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 1.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/2-8 UN",
                    CustomThreadDesignation = "1 1/2-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/2-8 UN",
                    CustomThreadDesignation = "1 1/2-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/2-10 UNS",
                    CustomThreadDesignation = "1 1/2-10 UNS",
                    TPI = 10,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/2-12 UNF",
                    CustomThreadDesignation = "1 1/2-12 UNF",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/2-12 UNF",
                    CustomThreadDesignation = "1 1/2-12 UNF",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/2-12 UNF",
                    CustomThreadDesignation = "1 1/2-12 UNF",
                    TPI = 12,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 1.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/2-14 UNS",
                    CustomThreadDesignation = "1 1/2-14 UNS",
                    TPI = 14,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/2-16 UN",
                    CustomThreadDesignation = "1 1/2-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/2-16 UN",
                    CustomThreadDesignation = "1 1/2-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/2-18 UNEF",
                    CustomThreadDesignation = "1 1/2-18 UNEF",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/2-18 UNEF",
                    CustomThreadDesignation = "1 1/2-18 UNEF",
                    TPI = 18,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/2-20 UN",
                    CustomThreadDesignation = "1 1/2-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/2-20 UN",
                    CustomThreadDesignation = "1 1/2-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/2-24 UNS",
                    CustomThreadDesignation = "1 1/2-24 UNS",
                    TPI = 24,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/2-28 UN",
                    CustomThreadDesignation = "1 1/2-28 UN",
                    TPI = 28,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1 1/2-28 UN",
                    CustomThreadDesignation = "1 1/2-28 UN",
                    TPI = 28,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1 9/16-6 UN",
                    CustomThreadDesignation = "1 9/16-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.5,
                    SizeSuffix = "",
                    ThreadDesignation = "1 9/16-6 UN",
                    CustomThreadDesignation = "1 9/16-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 9/16-8 UN",
                    CustomThreadDesignation = "1 9/16-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 9/16-8 UN",
                    CustomThreadDesignation = "1 9/16-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 9/16-12 UN",
                    CustomThreadDesignation = "1 9/16-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 9/16-12 UN",
                    CustomThreadDesignation = "1 9/16-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 9/16-16 UN",
                    CustomThreadDesignation = "1 9/16-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 9/16-16 UN",
                    CustomThreadDesignation = "1 9/16-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 9/16-18 UNEF",
                    CustomThreadDesignation = "1 9/16-18 UNEF",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 9/16-18 UNEF",
                    CustomThreadDesignation = "1 9/16-18 UNEF",
                    TPI = 18,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 9/16-20 UN",
                    CustomThreadDesignation = "1 9/16-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.5625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 9/16-20 UN",
                    CustomThreadDesignation = "1 9/16-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/8-6 UN",
                    CustomThreadDesignation = "1 5/8-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/8-6 UN",
                    CustomThreadDesignation = "1 5/8-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/8-8 UN",
                    CustomThreadDesignation = "1 5/8-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/8-8 UN",
                    CustomThreadDesignation = "1 5/8-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/8-10 UNS",
                    CustomThreadDesignation = "1 5/8-10 UNS",
                    TPI = 10,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/8-12 UN",
                    CustomThreadDesignation = "1 5/8-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/8-12 UN",
                    CustomThreadDesignation = "1 5/8-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/8-14 UNS",
                    CustomThreadDesignation = "1 5/8-14 UNS",
                    TPI = 14,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/8-16 UN",
                    CustomThreadDesignation = "1 5/8-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/8-16 UN",
                    CustomThreadDesignation = "1 5/8-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/8-18 UNEF",
                    CustomThreadDesignation = "1 5/8-18 UNEF",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/8-18 UNEF",
                    CustomThreadDesignation = "1 5/8-18 UNEF",
                    TPI = 18,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/8-20 UN",
                    CustomThreadDesignation = "1 5/8-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/8-20 UN",
                    CustomThreadDesignation = "1 5/8-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.625,
                    SizeSuffix = "",
                    ThreadDesignation = "1 5/8-24 UNS",
                    CustomThreadDesignation = "1 5/8-24 UNS",
                    TPI = 24,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 11/16-6 UN",
                    CustomThreadDesignation = "1 11/16-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 11/16-6 UN",
                    CustomThreadDesignation = "1 11/16-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 11/16-8 UN",
                    CustomThreadDesignation = "1 11/16-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 11/16-8 UN",
                    CustomThreadDesignation = "1 11/16-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 11/16-12 UN",
                    CustomThreadDesignation = "1 11/16-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 11/16-12 UN",
                    CustomThreadDesignation = "1 11/16-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 11/16-16 UN",
                    CustomThreadDesignation = "1 11/16-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 11/16-16 UN",
                    CustomThreadDesignation = "1 11/16-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 11/16-18 UNEF",
                    CustomThreadDesignation = "1 11/16-18 UNEF",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 11/16-18 UNEF",
                    CustomThreadDesignation = "1 11/16-18 UNEF",
                    TPI = 18,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 11/16-20 UN",
                    CustomThreadDesignation = "1 11/16-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.6875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 11/16-20 UN",
                    CustomThreadDesignation = "1 11/16-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.75,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/4-5 UNC",
                    CustomThreadDesignation = "1 3/4-5 UNC",
                    TPI = 5,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.75,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/4-5 UNC",
                    CustomThreadDesignation = "1 3/4-5 UNC",
                    TPI = 5,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.75,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/4-5 UNC",
                    CustomThreadDesignation = "1 3/4-5 UNC",
                    TPI = 5,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 1.75,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/4-6 UN",
                    CustomThreadDesignation = "1 3/4-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.75,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/4-6 UN",
                    CustomThreadDesignation = "1 3/4-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.75,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/4-8 UN",
                    CustomThreadDesignation = "1 3/4-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.75,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/4-8 UN",
                    CustomThreadDesignation = "1 3/4-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.75,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/4-10 UNS",
                    CustomThreadDesignation = "1 3/4-10 UNS",
                    TPI = 10,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.75,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/4-12 UN",
                    CustomThreadDesignation = "1 3/4-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.75,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/4-12 UN",
                    CustomThreadDesignation = "1 3/4-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.75,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/4-14 UNS",
                    CustomThreadDesignation = "1 3/4-14 UNS",
                    TPI = 14,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.75,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/4-16 UN",
                    CustomThreadDesignation = "1 3/4-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.75,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/4-16 UN",
                    CustomThreadDesignation = "1 3/4-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.75,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/4-18 UNS",
                    CustomThreadDesignation = "1 3/4-18 UNS",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.75,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/4-20 UN",
                    CustomThreadDesignation = "1 3/4-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.75,
                    SizeSuffix = "",
                    ThreadDesignation = "1 3/4-20 UN",
                    CustomThreadDesignation = "1 3/4-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.8125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 13/16-6 UN",
                    CustomThreadDesignation = "1 13/16-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.8125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 13/16-6 UN",
                    CustomThreadDesignation = "1 13/16-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.8125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 13/16-8 UN",
                    CustomThreadDesignation = "1 13/16-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.8125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 13/16-8 UN",
                    CustomThreadDesignation = "1 13/16-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.8125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 13/16-12 UN",
                    CustomThreadDesignation = "1 13/16-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.8125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 13/16-12 UN",
                    CustomThreadDesignation = "1 13/16-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.8125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 13/16-16 UN",
                    CustomThreadDesignation = "1 13/16-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.8125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 13/16-16 UN",
                    CustomThreadDesignation = "1 13/16-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.8125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 13/16-20 UN",
                    CustomThreadDesignation = "1 13/16-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.8125,
                    SizeSuffix = "",
                    ThreadDesignation = "1 13/16-20 UN",
                    CustomThreadDesignation = "1 13/16-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/8-6 UN",
                    CustomThreadDesignation = "1 7/8-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/8-6 UN",
                    CustomThreadDesignation = "1 7/8-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/8-8 UN",
                    CustomThreadDesignation = "1 7/8-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/8-8 UN",
                    CustomThreadDesignation = "1 7/8-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/8-10 UNS",
                    CustomThreadDesignation = "1 7/8-10 UNS",
                    TPI = 10,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/8-12 UN",
                    CustomThreadDesignation = "1 7/8-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/8-12 UN",
                    CustomThreadDesignation = "1 7/8-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/8-14 UNS",
                    CustomThreadDesignation = "1 7/8-14 UNS",
                    TPI = 14,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/8-16 UN",
                    CustomThreadDesignation = "1 7/8-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/8-16 UN",
                    CustomThreadDesignation = "1 7/8-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/8-18 UNS",
                    CustomThreadDesignation = "1 7/8-18 UNS",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/8-20 UN",
                    CustomThreadDesignation = "1 7/8-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.875,
                    SizeSuffix = "",
                    ThreadDesignation = "1 7/8-20 UN",
                    CustomThreadDesignation = "1 7/8-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.9375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 15/16-6 UN",
                    CustomThreadDesignation = "1 15/16-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.9375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 15/16-6 UN",
                    CustomThreadDesignation = "1 15/16-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.9375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 15/16-8 UN",
                    CustomThreadDesignation = "1 15/16-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.9375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 15/16-8 UN",
                    CustomThreadDesignation = "1 15/16-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.9375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 15/16-12 UN",
                    CustomThreadDesignation = "1 15/16-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.9375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 15/16-12 UN",
                    CustomThreadDesignation = "1 15/16-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.9375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 15/16-16 UN",
                    CustomThreadDesignation = "1 15/16-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.9375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 15/16-16 UN",
                    CustomThreadDesignation = "1 15/16-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 1.9375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 15/16-20 UN",
                    CustomThreadDesignation = "1 15/16-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 1.9375,
                    SizeSuffix = "",
                    ThreadDesignation = "1 15/16-20 UN",
                    CustomThreadDesignation = "1 15/16-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2,
                    SizeSuffix = "",
                    ThreadDesignation = "2-4.5 UNC",
                    CustomThreadDesignation = "2-4.5 UNC",
                    TPI = 4.5,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2,
                    SizeSuffix = "",
                    ThreadDesignation = "2-4.5 UNC",
                    CustomThreadDesignation = "2-4.5 UNC",
                    TPI = 4.5,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2,
                    SizeSuffix = "",
                    ThreadDesignation = "2-4.5 UNC",
                    CustomThreadDesignation = "2-4.5 UNC",
                    TPI = 4.5,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 2,
                    SizeSuffix = "",
                    ThreadDesignation = "2-6 UN",
                    CustomThreadDesignation = "2-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2,
                    SizeSuffix = "",
                    ThreadDesignation = "2-6 UN",
                    CustomThreadDesignation = "2-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2,
                    SizeSuffix = "",
                    ThreadDesignation = "2-8 UN",
                    CustomThreadDesignation = "2-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2,
                    SizeSuffix = "",
                    ThreadDesignation = "2-8 UN",
                    CustomThreadDesignation = "2-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2,
                    SizeSuffix = "",
                    ThreadDesignation = "2-10 UNS",
                    CustomThreadDesignation = "2-10 UNS",
                    TPI = 10,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2,
                    SizeSuffix = "",
                    ThreadDesignation = "2-12 UN",
                    CustomThreadDesignation = "2-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2,
                    SizeSuffix = "",
                    ThreadDesignation = "2-12 UN",
                    CustomThreadDesignation = "2-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2,
                    SizeSuffix = "",
                    ThreadDesignation = "2-14 UNS",
                    CustomThreadDesignation = "2-14 UNS",
                    TPI = 14,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2,
                    SizeSuffix = "",
                    ThreadDesignation = "2-16 UN",
                    CustomThreadDesignation = "2-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2,
                    SizeSuffix = "",
                    ThreadDesignation = "2-16 UN",
                    CustomThreadDesignation = "2-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2,
                    SizeSuffix = "",
                    ThreadDesignation = "2-18 UNS",
                    CustomThreadDesignation = "2-18 UNS",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2,
                    SizeSuffix = "",
                    ThreadDesignation = "2-20 UN",
                    CustomThreadDesignation = "2-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2,
                    SizeSuffix = "",
                    ThreadDesignation = "2-20 UN",
                    CustomThreadDesignation = "2-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.0625,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/16-16 UNS",
                    CustomThreadDesignation = "2 1/16-16 UNS",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.0625,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/16-16 UNS",
                    CustomThreadDesignation = "2 1/16-16 UNS",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.125,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/8-6 UN",
                    CustomThreadDesignation = "2 1/8-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.125,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/8-6 UN",
                    CustomThreadDesignation = "2 1/8-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.125,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/8-8 UN",
                    CustomThreadDesignation = "2 1/8-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.125,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/8-8 UN",
                    CustomThreadDesignation = "2 1/8-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.125,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/8-12 UN",
                    CustomThreadDesignation = "2 1/8-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.125,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/8-12 UN",
                    CustomThreadDesignation = "2 1/8-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.125,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/8-16 UN",
                    CustomThreadDesignation = "2 1/8-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.125,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/8-16 UN",
                    CustomThreadDesignation = "2 1/8-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.125,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/8-20 UN",
                    CustomThreadDesignation = "2 1/8-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.125,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/8-20 UN",
                    CustomThreadDesignation = "2 1/8-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.1875,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/16-16 UNS",
                    CustomThreadDesignation = "2 3/16-16 UNS",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.1875,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/16-16 UNS",
                    CustomThreadDesignation = "2 3/16-16 UNS",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.25,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/4-4.5 UNC",
                    CustomThreadDesignation = "2 1/4-4.5 UNC",
                    TPI = 4.5,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.25,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/4-4.5 UNC",
                    CustomThreadDesignation = "2 1/4-4.5 UNC",
                    TPI = 4.5,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.25,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/4-4.5 UNC",
                    CustomThreadDesignation = "2 1/4-4.5 UNC",
                    TPI = 4.5,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 2.25,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/4-6 UN",
                    CustomThreadDesignation = "2 1/4-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.25,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/4-6 UN",
                    CustomThreadDesignation = "2 1/4-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.25,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/4-8 UN",
                    CustomThreadDesignation = "2 1/4-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.25,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/4-8 UN",
                    CustomThreadDesignation = "2 1/4-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.25,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/4-10 UNS",
                    CustomThreadDesignation = "2 1/4-10 UNS",
                    TPI = 10,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.25,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/4-12 UN",
                    CustomThreadDesignation = "2 1/4-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.25,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/4-12 UN",
                    CustomThreadDesignation = "2 1/4-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.25,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/4-14 UNS",
                    CustomThreadDesignation = "2 1/4-14 UNS",
                    TPI = 14,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.25,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/4-16 UN",
                    CustomThreadDesignation = "2 1/4-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.25,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/4-16 UN",
                    CustomThreadDesignation = "2 1/4-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.25,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/4-18 UNS",
                    CustomThreadDesignation = "2 1/4-18 UNS",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.25,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/4-20 UN",
                    CustomThreadDesignation = "2 1/4-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.25,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/4-20 UN",
                    CustomThreadDesignation = "2 1/4-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "2 5/16-16 UNS",
                    CustomThreadDesignation = "2 5/16-16 UNS",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.3125,
                    SizeSuffix = "",
                    ThreadDesignation = "2 5/16-16 UNS",
                    CustomThreadDesignation = "2 5/16-16 UNS",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.375,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/8-6 UN",
                    CustomThreadDesignation = "2 3/8-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.375,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/8-6 UN",
                    CustomThreadDesignation = "2 3/8-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.375,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/8-8 UN",
                    CustomThreadDesignation = "2 3/8-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.375,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/8-8 UN",
                    CustomThreadDesignation = "2 3/8-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.375,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/8-12 UN",
                    CustomThreadDesignation = "2 3/8-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.375,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/8-12 UN",
                    CustomThreadDesignation = "2 3/8-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.375,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/8-16 UN",
                    CustomThreadDesignation = "2 3/8-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.375,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/8-16 UN",
                    CustomThreadDesignation = "2 3/8-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.375,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/8-20 UN",
                    CustomThreadDesignation = "2 3/8-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.375,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/8-20 UN",
                    CustomThreadDesignation = "2 3/8-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "2 7/16-16 UNS",
                    CustomThreadDesignation = "2 7/16-16 UNS",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.4375,
                    SizeSuffix = "",
                    ThreadDesignation = "2 7/16-16 UNS",
                    CustomThreadDesignation = "2 7/16-16 UNS",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.5,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/2-4 UNC",
                    CustomThreadDesignation = "2 1/2-4 UNC",
                    TPI = 4,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.5,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/2-4 UNC",
                    CustomThreadDesignation = "2 1/2-4 UNC",
                    TPI = 4,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.5,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/2-4 UNC",
                    CustomThreadDesignation = "2 1/2-4 UNC",
                    TPI = 4,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 2.5,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/2-6 UN",
                    CustomThreadDesignation = "2 1/2-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.5,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/2-6 UN",
                    CustomThreadDesignation = "2 1/2-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.5,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/2-8 UN",
                    CustomThreadDesignation = "2 1/2-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.5,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/2-8 UN",
                    CustomThreadDesignation = "2 1/2-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.5,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/2-10 UNS",
                    CustomThreadDesignation = "2 1/2-10 UNS",
                    TPI = 10,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.5,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/2-12 UN",
                    CustomThreadDesignation = "2 1/2-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.5,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/2-12 UN",
                    CustomThreadDesignation = "2 1/2-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.5,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/2-14 UNS",
                    CustomThreadDesignation = "2 1/2-14 UNS",
                    TPI = 14,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.5,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/2-16 UN",
                    CustomThreadDesignation = "2 1/2-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.5,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/2-16 UN",
                    CustomThreadDesignation = "2 1/2-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.5,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/2-18 UNS",
                    CustomThreadDesignation = "2 1/2-18 UNS",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.5,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/2-20 UN",
                    CustomThreadDesignation = "2 1/2-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.5,
                    SizeSuffix = "",
                    ThreadDesignation = "2 1/2-20 UN",
                    CustomThreadDesignation = "2 1/2-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.625,
                    SizeSuffix = "",
                    ThreadDesignation = "2 5/8-6 UN",
                    CustomThreadDesignation = "2 5/8-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.625,
                    SizeSuffix = "",
                    ThreadDesignation = "2 5/8-6 UN",
                    CustomThreadDesignation = "2 5/8-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.625,
                    SizeSuffix = "",
                    ThreadDesignation = "2 5/8-8 UN",
                    CustomThreadDesignation = "2 5/8-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.625,
                    SizeSuffix = "",
                    ThreadDesignation = "2 5/8-8 UN",
                    CustomThreadDesignation = "2 5/8-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.625,
                    SizeSuffix = "",
                    ThreadDesignation = "2 5/8-12 UN",
                    CustomThreadDesignation = "2 5/8-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.625,
                    SizeSuffix = "",
                    ThreadDesignation = "2 5/8-12 UN",
                    CustomThreadDesignation = "2 5/8-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.625,
                    SizeSuffix = "",
                    ThreadDesignation = "2 5/8-16 UN",
                    CustomThreadDesignation = "2 5/8-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.625,
                    SizeSuffix = "",
                    ThreadDesignation = "2 5/8-16 UN",
                    CustomThreadDesignation = "2 5/8-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.625,
                    SizeSuffix = "",
                    ThreadDesignation = "2 5/8-20 UN",
                    CustomThreadDesignation = "2 5/8-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.625,
                    SizeSuffix = "",
                    ThreadDesignation = "2 5/8-20 UN",
                    CustomThreadDesignation = "2 5/8-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.75,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/4-4 UNC",
                    CustomThreadDesignation = "2 3/4-4 UNC",
                    TPI = 4,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.75,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/4-4 UNC",
                    CustomThreadDesignation = "2 3/4-4 UNC",
                    TPI = 4,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.75,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/4-4 UNC",
                    CustomThreadDesignation = "2 3/4-4 UNC",
                    TPI = 4,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 2.75,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/4-6 UN",
                    CustomThreadDesignation = "2 3/4-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.75,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/4-6 UN",
                    CustomThreadDesignation = "2 3/4-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.75,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/4-8 UN",
                    CustomThreadDesignation = "2 3/4-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.75,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/4-8 UN",
                    CustomThreadDesignation = "2 3/4-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.75,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/4-10 UNS",
                    CustomThreadDesignation = "2 3/4-10 UNS",
                    TPI = 10,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.75,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/4-12 UN",
                    CustomThreadDesignation = "2 3/4-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.75,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/4-12 UN",
                    CustomThreadDesignation = "2 3/4-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.75,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/4-14 UNS",
                    CustomThreadDesignation = "2 3/4-14 UNS",
                    TPI = 14,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.75,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/4-16 UN",
                    CustomThreadDesignation = "2 3/4-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.75,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/4-16 UN",
                    CustomThreadDesignation = "2 3/4-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.75,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/4-18 UNS",
                    CustomThreadDesignation = "2 3/4-18 UNS",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.75,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/4-20 UN",
                    CustomThreadDesignation = "2 3/4-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.75,
                    SizeSuffix = "",
                    ThreadDesignation = "2 3/4-20 UN",
                    CustomThreadDesignation = "2 3/4-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.875,
                    SizeSuffix = "",
                    ThreadDesignation = "2 7/8-6 UN",
                    CustomThreadDesignation = "2 7/8-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.875,
                    SizeSuffix = "",
                    ThreadDesignation = "2 7/8-6 UN",
                    CustomThreadDesignation = "2 7/8-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.875,
                    SizeSuffix = "",
                    ThreadDesignation = "2 7/8-8 UN",
                    CustomThreadDesignation = "2 7/8-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.875,
                    SizeSuffix = "",
                    ThreadDesignation = "2 7/8-8 UN",
                    CustomThreadDesignation = "2 7/8-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.875,
                    SizeSuffix = "",
                    ThreadDesignation = "2 7/8-12 UN",
                    CustomThreadDesignation = "2 7/8-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.875,
                    SizeSuffix = "",
                    ThreadDesignation = "2 7/8-12 UN",
                    CustomThreadDesignation = "2 7/8-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.875,
                    SizeSuffix = "",
                    ThreadDesignation = "2 7/8-16 UN",
                    CustomThreadDesignation = "2 7/8-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.875,
                    SizeSuffix = "",
                    ThreadDesignation = "2 7/8-16 UN",
                    CustomThreadDesignation = "2 7/8-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 2.875,
                    SizeSuffix = "",
                    ThreadDesignation = "2 7/8-20 UN",
                    CustomThreadDesignation = "2 7/8-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 2.875,
                    SizeSuffix = "",
                    ThreadDesignation = "2 7/8-20 UN",
                    CustomThreadDesignation = "2 7/8-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3,
                    SizeSuffix = "",
                    ThreadDesignation = "3-4 UNC",
                    CustomThreadDesignation = "3-4 UNC",
                    TPI = 4,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3,
                    SizeSuffix = "",
                    ThreadDesignation = "3-4 UNC",
                    CustomThreadDesignation = "3-4 UNC",
                    TPI = 4,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3,
                    SizeSuffix = "",
                    ThreadDesignation = "3-4 UNC",
                    CustomThreadDesignation = "3-4 UNC",
                    TPI = 4,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 3,
                    SizeSuffix = "",
                    ThreadDesignation = "3-6 UN",
                    CustomThreadDesignation = "3-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3,
                    SizeSuffix = "",
                    ThreadDesignation = "3-6 UN",
                    CustomThreadDesignation = "3-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3,
                    SizeSuffix = "",
                    ThreadDesignation = "3-8 UN",
                    CustomThreadDesignation = "3-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3,
                    SizeSuffix = "",
                    ThreadDesignation = "3-8 UN",
                    CustomThreadDesignation = "3-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3,
                    SizeSuffix = "",
                    ThreadDesignation = "3-10 UNS",
                    CustomThreadDesignation = "3-10 UNS",
                    TPI = 10,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3,
                    SizeSuffix = "",
                    ThreadDesignation = "3-12 UN",
                    CustomThreadDesignation = "3-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3,
                    SizeSuffix = "",
                    ThreadDesignation = "3-12 UN",
                    CustomThreadDesignation = "3-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3,
                    SizeSuffix = "",
                    ThreadDesignation = "3-14 UNS",
                    CustomThreadDesignation = "3-14 UNS",
                    TPI = 14,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3,
                    SizeSuffix = "",
                    ThreadDesignation = "3-16 UN",
                    CustomThreadDesignation = "3-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3,
                    SizeSuffix = "",
                    ThreadDesignation = "3-16 UN",
                    CustomThreadDesignation = "3-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3,
                    SizeSuffix = "",
                    ThreadDesignation = "3-18 UNS",
                    CustomThreadDesignation = "3-18 UNS",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3,
                    SizeSuffix = "",
                    ThreadDesignation = "3-20 UN",
                    CustomThreadDesignation = "3-20 UN",
                    TPI = 20,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3,
                    SizeSuffix = "",
                    ThreadDesignation = "3-20 UN",
                    CustomThreadDesignation = "3-20 UN",
                    TPI = 20,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.125,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/8-6 UN",
                    CustomThreadDesignation = "3 1/8-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.125,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/8-6 UN",
                    CustomThreadDesignation = "3 1/8-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.125,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/8-8 UN",
                    CustomThreadDesignation = "3 1/8-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.125,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/8-8 UN",
                    CustomThreadDesignation = "3 1/8-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.125,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/8-12 UN",
                    CustomThreadDesignation = "3 1/8-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.125,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/8-12 UN",
                    CustomThreadDesignation = "3 1/8-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.125,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/8-16 UN",
                    CustomThreadDesignation = "3 1/8-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.125,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/8-16 UN",
                    CustomThreadDesignation = "3 1/8-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.25,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/4-4 UNC",
                    CustomThreadDesignation = "3 1/4-4 UNC",
                    TPI = 4,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.25,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/4-4 UNC",
                    CustomThreadDesignation = "3 1/4-4 UNC",
                    TPI = 4,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.25,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/4-4 UNC",
                    CustomThreadDesignation = "3 1/4-4 UNC",
                    TPI = 4,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 3.25,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/4-6 UN",
                    CustomThreadDesignation = "3 1/4-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.25,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/4-6 UN",
                    CustomThreadDesignation = "3 1/4-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.25,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/4-8 UN",
                    CustomThreadDesignation = "3 1/4-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.25,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/4-8 UN",
                    CustomThreadDesignation = "3 1/4-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.25,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/4-10 UNS",
                    CustomThreadDesignation = "3 1/4-10 UNS",
                    TPI = 10,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.25,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/4-12 UN",
                    CustomThreadDesignation = "3 1/4-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.25,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/4-12 UN",
                    CustomThreadDesignation = "3 1/4-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.25,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/4-14 UNS",
                    CustomThreadDesignation = "3 1/4-14 UNS",
                    TPI = 14,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.25,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/4-16 UN",
                    CustomThreadDesignation = "3 1/4-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.25,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/4-16 UN",
                    CustomThreadDesignation = "3 1/4-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.25,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/4-18 UNS",
                    CustomThreadDesignation = "3 1/4-18 UNS",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3 3/8-6 UN",
                    CustomThreadDesignation = "3 3/8-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3 3/8-6 UN",
                    CustomThreadDesignation = "3 3/8-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3 3/8-8 UN",
                    CustomThreadDesignation = "3 3/8-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3 3/8-8 UN",
                    CustomThreadDesignation = "3 3/8-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3 3/8-12 UN",
                    CustomThreadDesignation = "3 3/8-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3 3/8-12 UN",
                    CustomThreadDesignation = "3 3/8-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3 3/8-16 UN",
                    CustomThreadDesignation = "3 3/8-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.375,
                    SizeSuffix = "",
                    ThreadDesignation = "3 3/8-16 UN",
                    CustomThreadDesignation = "3 3/8-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.5,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/2-4 UNC",
                    CustomThreadDesignation = "3 1/2-4 UNC",
                    TPI = 4,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.5,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/2-4 UNC",
                    CustomThreadDesignation = "3 1/2-4 UNC",
                    TPI = 4,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.5,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/2-4 UNC",
                    CustomThreadDesignation = "3 1/2-4 UNC",
                    TPI = 4,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 3.5,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/2-6 UN",
                    CustomThreadDesignation = "3 1/2-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.5,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/2-6 UN",
                    CustomThreadDesignation = "3 1/2-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.5,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/2-8 UN",
                    CustomThreadDesignation = "3 1/2-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.5,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/2-8 UN",
                    CustomThreadDesignation = "3 1/2-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.5,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/2-10 UNS",
                    CustomThreadDesignation = "3 1/2-10 UNS",
                    TPI = 10,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.5,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/2-12 UN",
                    CustomThreadDesignation = "3 1/2-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.5,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/2-12 UN",
                    CustomThreadDesignation = "3 1/2-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.5,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/2-14 UNS",
                    CustomThreadDesignation = "3 1/2-14 UNS",
                    TPI = 14,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.5,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/2-16 UN",
                    CustomThreadDesignation = "3 1/2-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.5,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/2-16 UN",
                    CustomThreadDesignation = "3 1/2-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.5,
                    SizeSuffix = "",
                    ThreadDesignation = "3 1/2-18 UNS",
                    CustomThreadDesignation = "3 1/2-18 UNS",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.625,
                    SizeSuffix = "",
                    ThreadDesignation = "3 5/8-6 UN",
                    CustomThreadDesignation = "3 5/8-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.625,
                    SizeSuffix = "",
                    ThreadDesignation = "3 5/8-6 UN",
                    CustomThreadDesignation = "3 5/8-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.625,
                    SizeSuffix = "",
                    ThreadDesignation = "3 5/8-8 UN",
                    CustomThreadDesignation = "3 5/8-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.625,
                    SizeSuffix = "",
                    ThreadDesignation = "3 5/8-8 UN",
                    CustomThreadDesignation = "3 5/8-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.625,
                    SizeSuffix = "",
                    ThreadDesignation = "3 5/8-12 UN",
                    CustomThreadDesignation = "3 5/8-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.625,
                    SizeSuffix = "",
                    ThreadDesignation = "3 5/8-12 UN",
                    CustomThreadDesignation = "3 5/8-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.625,
                    SizeSuffix = "",
                    ThreadDesignation = "3 5/8-16 UN",
                    CustomThreadDesignation = "3 5/8-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.625,
                    SizeSuffix = "",
                    ThreadDesignation = "3 5/8-16 UN",
                    CustomThreadDesignation = "3 5/8-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3 3/4-4 UNC",
                    CustomThreadDesignation = "3 3/4-4 UNC",
                    TPI = 4,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3 3/4-4 UNC",
                    CustomThreadDesignation = "3 3/4-4 UNC",
                    TPI = 4,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3 3/4-4 UNC",
                    CustomThreadDesignation = "3 3/4-4 UNC",
                    TPI = 4,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 3.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3 3/4-6 UN",
                    CustomThreadDesignation = "3 3/4-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3 3/4-6 UN",
                    CustomThreadDesignation = "3 3/4-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3 3/4-8 UN",
                    CustomThreadDesignation = "3 3/4-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3 3/4-8 UN",
                    CustomThreadDesignation = "3 3/4-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3 3/4-10 UNS",
                    CustomThreadDesignation = "3 3/4-10 UNS",
                    TPI = 10,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3 3/4-12 UN",
                    CustomThreadDesignation = "3 3/4-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3 3/4-12 UN",
                    CustomThreadDesignation = "3 3/4-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3 3/4-14 UNS",
                    CustomThreadDesignation = "3 3/4-14 UNS",
                    TPI = 14,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3 3/4-16 UN",
                    CustomThreadDesignation = "3 3/4-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3 3/4-16 UN",
                    CustomThreadDesignation = "3 3/4-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.75,
                    SizeSuffix = "",
                    ThreadDesignation = "3 3/4-18 UNS",
                    CustomThreadDesignation = "3 3/4-18 UNS",
                    TPI = 18,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.875,
                    SizeSuffix = "",
                    ThreadDesignation = "3 7/8-6 UN",
                    CustomThreadDesignation = "3 7/8-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.875,
                    SizeSuffix = "",
                    ThreadDesignation = "3 7/8-6 UN",
                    CustomThreadDesignation = "3 7/8-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.875,
                    SizeSuffix = "",
                    ThreadDesignation = "3 7/8-8 UN",
                    CustomThreadDesignation = "3 7/8-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.875,
                    SizeSuffix = "",
                    ThreadDesignation = "3 7/8-8 UN",
                    CustomThreadDesignation = "3 7/8-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.875,
                    SizeSuffix = "",
                    ThreadDesignation = "3 7/8-12 UN",
                    CustomThreadDesignation = "3 7/8-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.875,
                    SizeSuffix = "",
                    ThreadDesignation = "3 7/8-12 UN",
                    CustomThreadDesignation = "3 7/8-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 3.875,
                    SizeSuffix = "",
                    ThreadDesignation = "3 7/8-16 UN",
                    CustomThreadDesignation = "3 7/8-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 3.875,
                    SizeSuffix = "",
                    ThreadDesignation = "3 7/8-16 UN",
                    CustomThreadDesignation = "3 7/8-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 4,
                    SizeSuffix = "",
                    ThreadDesignation = "4-4 UNC",
                    CustomThreadDesignation = "4-4 UNC",
                    TPI = 4,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 4,
                    SizeSuffix = "",
                    ThreadDesignation = "4-4 UNC",
                    CustomThreadDesignation = "4-4 UNC",
                    TPI = 4,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 4,
                    SizeSuffix = "",
                    ThreadDesignation = "4-4 UNC",
                    CustomThreadDesignation = "4-4 UNC",
                    TPI = 4,
                    ExternalClass = "1A",
                    InternalClass = "1B"
                },
                new HoleSizeData {
                    Size = 4,
                    SizeSuffix = "",
                    ThreadDesignation = "4-6 UN",
                    CustomThreadDesignation = "4-6 UN",
                    TPI = 6,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 4,
                    SizeSuffix = "",
                    ThreadDesignation = "4-6 UN",
                    CustomThreadDesignation = "4-6 UN",
                    TPI = 6,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 4,
                    SizeSuffix = "",
                    ThreadDesignation = "4-8 UN",
                    CustomThreadDesignation = "4-8 UN",
                    TPI = 8,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 4,
                    SizeSuffix = "",
                    ThreadDesignation = "4-8 UN",
                    CustomThreadDesignation = "4-8 UN",
                    TPI = 8,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 4,
                    SizeSuffix = "",
                    ThreadDesignation = "4-10 UNS",
                    CustomThreadDesignation = "4-10 UNS",
                    TPI = 10,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 4,
                    SizeSuffix = "",
                    ThreadDesignation = "4-12 UN",
                    CustomThreadDesignation = "4-12 UN",
                    TPI = 12,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 4,
                    SizeSuffix = "",
                    ThreadDesignation = "4-12 UN",
                    CustomThreadDesignation = "4-12 UN",
                    TPI = 12,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                },
                new HoleSizeData {
                    Size = 4,
                    SizeSuffix = "",
                    ThreadDesignation = "4-14 UNS",
                    CustomThreadDesignation = "4-14 UNS",
                    TPI = 14,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 4,
                    SizeSuffix = "",
                    ThreadDesignation = "4-16 UN",
                    CustomThreadDesignation = "4-16 UN",
                    TPI = 16,
                    ExternalClass = "2A",
                    InternalClass = "2B"
                },
                new HoleSizeData {
                    Size = 4,
                    SizeSuffix = "",
                    ThreadDesignation = "4-16 UN",
                    CustomThreadDesignation = "4-16 UN",
                    TPI = 16,
                    ExternalClass = "3A",
                    InternalClass = "3B"
                }

            };

            foreach (var thread in AnsiUnifiedScrewThreads)
            {
                thread.Type = "ANSI Unified Screw Threads";
            }
        }
    }

    public class HoleSizeData
    {
        public string Type { get; set; }

        public double Size { get; set; }

        public string SizeSuffix { get; set; }

        public string ThreadDesignation { get; set; }

        public string CustomThreadDesignation { get; set; }

        public double TPI { get; set; }

        public string ExternalClass { get; set; }

        public string InternalClass { get; set; }

    }


}
