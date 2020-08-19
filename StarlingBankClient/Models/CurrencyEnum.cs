using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum CurrencyEnum
    {
        UNDEFINED, //TODO: Write general description for this method
        AED, //TODO: Write general description for this method
        AFN, //TODO: Write general description for this method
        ALL, //TODO: Write general description for this method
        AMD, //TODO: Write general description for this method
        ANG, //TODO: Write general description for this method
        AOA, //TODO: Write general description for this method
        ARS, //TODO: Write general description for this method
        AUD, //TODO: Write general description for this method
        AWG, //TODO: Write general description for this method
        AZN, //TODO: Write general description for this method
        BAM, //TODO: Write general description for this method
        BBD, //TODO: Write general description for this method
        BDT, //TODO: Write general description for this method
        BGN, //TODO: Write general description for this method
        BHD, //TODO: Write general description for this method
        BIF, //TODO: Write general description for this method
        BMD, //TODO: Write general description for this method
        BND, //TODO: Write general description for this method
        BOB, //TODO: Write general description for this method
        BOV, //TODO: Write general description for this method
        BRL, //TODO: Write general description for this method
        BSD, //TODO: Write general description for this method
        BTN, //TODO: Write general description for this method
        BWP, //TODO: Write general description for this method
        BYN, //TODO: Write general description for this method
        BYR, //TODO: Write general description for this method
        BZD, //TODO: Write general description for this method
        CAD, //TODO: Write general description for this method
        CDF, //TODO: Write general description for this method
        CHE, //TODO: Write general description for this method
        CHF, //TODO: Write general description for this method
        CHW, //TODO: Write general description for this method
        CLF, //TODO: Write general description for this method
        CLP, //TODO: Write general description for this method
        CNY, //TODO: Write general description for this method
        COP, //TODO: Write general description for this method
        COU, //TODO: Write general description for this method
        CRC, //TODO: Write general description for this method
        CUC, //TODO: Write general description for this method
        CUP, //TODO: Write general description for this method
        CVE, //TODO: Write general description for this method
        CZK, //TODO: Write general description for this method
        DJF, //TODO: Write general description for this method
        DKK, //TODO: Write general description for this method
        DOP, //TODO: Write general description for this method
        DZD, //TODO: Write general description for this method
        EGP, //TODO: Write general description for this method
        ERN, //TODO: Write general description for this method
        ETB, //TODO: Write general description for this method
        EUR, //TODO: Write general description for this method
        FJD, //TODO: Write general description for this method
        FKP, //TODO: Write general description for this method
        GBP, //TODO: Write general description for this method
        GEL, //TODO: Write general description for this method
        GHS, //TODO: Write general description for this method
        GIP, //TODO: Write general description for this method
        GMD, //TODO: Write general description for this method
        GNF, //TODO: Write general description for this method
        GTQ, //TODO: Write general description for this method
        GYD, //TODO: Write general description for this method
        HKD, //TODO: Write general description for this method
        HNL, //TODO: Write general description for this method
        HRK, //TODO: Write general description for this method
        HTG, //TODO: Write general description for this method
        HUF, //TODO: Write general description for this method
        IDR, //TODO: Write general description for this method
        ILS, //TODO: Write general description for this method
        INR, //TODO: Write general description for this method
        IQD, //TODO: Write general description for this method
        IRR, //TODO: Write general description for this method
        ISK, //TODO: Write general description for this method
        JMD, //TODO: Write general description for this method
        JOD, //TODO: Write general description for this method
        JPY, //TODO: Write general description for this method
        KES, //TODO: Write general description for this method
        KGS, //TODO: Write general description for this method
        KHR, //TODO: Write general description for this method
        KMF, //TODO: Write general description for this method
        KPW, //TODO: Write general description for this method
        KRW, //TODO: Write general description for this method
        KWD, //TODO: Write general description for this method
        KYD, //TODO: Write general description for this method
        KZT, //TODO: Write general description for this method
        LAK, //TODO: Write general description for this method
        LBP, //TODO: Write general description for this method
        LKR, //TODO: Write general description for this method
        LRD, //TODO: Write general description for this method
        LSL, //TODO: Write general description for this method
        LTL, //TODO: Write general description for this method
        LYD, //TODO: Write general description for this method
        MAD, //TODO: Write general description for this method
        MDL, //TODO: Write general description for this method
        MGA, //TODO: Write general description for this method
        MKD, //TODO: Write general description for this method
        MMK, //TODO: Write general description for this method
        MNT, //TODO: Write general description for this method
        MOP, //TODO: Write general description for this method
        MRO, //TODO: Write general description for this method
        MRU, //TODO: Write general description for this method
        MUR, //TODO: Write general description for this method
        MVR, //TODO: Write general description for this method
        MWK, //TODO: Write general description for this method
        MXN, //TODO: Write general description for this method
        MXV, //TODO: Write general description for this method
        MYR, //TODO: Write general description for this method
        MZN, //TODO: Write general description for this method
        NAD, //TODO: Write general description for this method
        NGN, //TODO: Write general description for this method
        NIO, //TODO: Write general description for this method
        NOK, //TODO: Write general description for this method
        NPR, //TODO: Write general description for this method
        NZD, //TODO: Write general description for this method
        OMR, //TODO: Write general description for this method
        PAB, //TODO: Write general description for this method
        PEN, //TODO: Write general description for this method
        PGK, //TODO: Write general description for this method
        PHP, //TODO: Write general description for this method
        PKR, //TODO: Write general description for this method
        PLN, //TODO: Write general description for this method
        PYG, //TODO: Write general description for this method
        QAR, //TODO: Write general description for this method
        RON, //TODO: Write general description for this method
        RSD, //TODO: Write general description for this method
        RUB, //TODO: Write general description for this method
        RUR, //TODO: Write general description for this method
        RWF, //TODO: Write general description for this method
        SAR, //TODO: Write general description for this method
        SBD, //TODO: Write general description for this method
        SCR, //TODO: Write general description for this method
        SDG, //TODO: Write general description for this method
        SEK, //TODO: Write general description for this method
        SGD, //TODO: Write general description for this method
        SHP, //TODO: Write general description for this method
        SLL, //TODO: Write general description for this method
        SOS, //TODO: Write general description for this method
        SRD, //TODO: Write general description for this method
        SSP, //TODO: Write general description for this method
        STD, //TODO: Write general description for this method
        STN, //TODO: Write general description for this method
        SVC, //TODO: Write general description for this method
        SYP, //TODO: Write general description for this method
        SZL, //TODO: Write general description for this method
        THB, //TODO: Write general description for this method
        TJS, //TODO: Write general description for this method
        TMT, //TODO: Write general description for this method
        TND, //TODO: Write general description for this method
        TOP, //TODO: Write general description for this method
        TRY, //TODO: Write general description for this method
        TTD, //TODO: Write general description for this method
        TWD, //TODO: Write general description for this method
        TZS, //TODO: Write general description for this method
        UAH, //TODO: Write general description for this method
        UGX, //TODO: Write general description for this method
        USD, //TODO: Write general description for this method
        USN, //TODO: Write general description for this method
        USS, //TODO: Write general description for this method
        UYI, //TODO: Write general description for this method
        UYU, //TODO: Write general description for this method
        UZS, //TODO: Write general description for this method
        VEF, //TODO: Write general description for this method
        VES, //TODO: Write general description for this method
        VND, //TODO: Write general description for this method
        VUV, //TODO: Write general description for this method
        WST, //TODO: Write general description for this method
        XAF, //TODO: Write general description for this method
        XAG, //TODO: Write general description for this method
        XAU, //TODO: Write general description for this method
        XBA, //TODO: Write general description for this method
        XBB, //TODO: Write general description for this method
        XBC, //TODO: Write general description for this method
        XBD, //TODO: Write general description for this method
        XCD, //TODO: Write general description for this method
        XDR, //TODO: Write general description for this method
        XOF, //TODO: Write general description for this method
        XPD, //TODO: Write general description for this method
        XPF, //TODO: Write general description for this method
        XPT, //TODO: Write general description for this method
        XSU, //TODO: Write general description for this method
        XTS, //TODO: Write general description for this method
        XUA, //TODO: Write general description for this method
        XXX, //TODO: Write general description for this method
        YER, //TODO: Write general description for this method
        ZAR, //TODO: Write general description for this method
        ZMW, //TODO: Write general description for this method
        ZWL, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type CurrencyEnum
    /// </summary>
    public static class CurrencyEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "UNDEFINED", "AED", "AFN", "ALL", "AMD", "ANG", "AOA", "ARS", "AUD", "AWG", "AZN", "BAM", "BBD", "BDT", "BGN", "BHD", "BIF", "BMD", "BND", "BOB", "BOV", "BRL", "BSD", "BTN", "BWP", "BYN", "BYR", "BZD", "CAD", "CDF", "CHE", "CHF", "CHW", "CLF", "CLP", "CNY", "COP", "COU", "CRC", "CUC", "CUP", "CVE", "CZK", "DJF", "DKK", "DOP", "DZD", "EGP", "ERN", "ETB", "EUR", "FJD", "FKP", "GBP", "GEL", "GHS", "GIP", "GMD", "GNF", "GTQ", "GYD", "HKD", "HNL", "HRK", "HTG", "HUF", "IDR", "ILS", "INR", "IQD", "IRR", "ISK", "JMD", "JOD", "JPY", "KES", "KGS", "KHR", "KMF", "KPW", "KRW", "KWD", "KYD", "KZT", "LAK", "LBP", "LKR", "LRD", "LSL", "LTL", "LYD", "MAD", "MDL", "MGA", "MKD", "MMK", "MNT", "MOP", "MRO", "MRU", "MUR", "MVR", "MWK", "MXN", "MXV", "MYR", "MZN", "NAD", "NGN", "NIO", "NOK", "NPR", "NZD", "OMR", "PAB", "PEN", "PGK", "PHP", "PKR", "PLN", "PYG", "QAR", "RON", "RSD", "RUB", "RUR", "RWF", "SAR", "SBD", "SCR", "SDG", "SEK", "SGD", "SHP", "SLL", "SOS", "SRD", "SSP", "STD", "STN", "SVC", "SYP", "SZL", "THB", "TJS", "TMT", "TND", "TOP", "TRY", "TTD", "TWD", "TZS", "UAH", "UGX", "USD", "USN", "USS", "UYI", "UYU", "UZS", "VEF", "VES", "VND", "VUV", "WST", "XAF", "XAG", "XAU", "XBA", "XBB", "XBC", "XBD", "XCD", "XDR", "XOF", "XPD", "XPF", "XPT", "XSU", "XTS", "XUA", "XXX", "YER", "ZAR", "ZMW", "ZWL" };

        /// <summary>
        /// Converts a CurrencyEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The CurrencyEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(CurrencyEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case CurrencyEnum.UNDEFINED:
                case CurrencyEnum.AED:
                case CurrencyEnum.AFN:
                case CurrencyEnum.ALL:
                case CurrencyEnum.AMD:
                case CurrencyEnum.ANG:
                case CurrencyEnum.AOA:
                case CurrencyEnum.ARS:
                case CurrencyEnum.AUD:
                case CurrencyEnum.AWG:
                case CurrencyEnum.AZN:
                case CurrencyEnum.BAM:
                case CurrencyEnum.BBD:
                case CurrencyEnum.BDT:
                case CurrencyEnum.BGN:
                case CurrencyEnum.BHD:
                case CurrencyEnum.BIF:
                case CurrencyEnum.BMD:
                case CurrencyEnum.BND:
                case CurrencyEnum.BOB:
                case CurrencyEnum.BOV:
                case CurrencyEnum.BRL:
                case CurrencyEnum.BSD:
                case CurrencyEnum.BTN:
                case CurrencyEnum.BWP:
                case CurrencyEnum.BYN:
                case CurrencyEnum.BYR:
                case CurrencyEnum.BZD:
                case CurrencyEnum.CAD:
                case CurrencyEnum.CDF:
                case CurrencyEnum.CHE:
                case CurrencyEnum.CHF:
                case CurrencyEnum.CHW:
                case CurrencyEnum.CLF:
                case CurrencyEnum.CLP:
                case CurrencyEnum.CNY:
                case CurrencyEnum.COP:
                case CurrencyEnum.COU:
                case CurrencyEnum.CRC:
                case CurrencyEnum.CUC:
                case CurrencyEnum.CUP:
                case CurrencyEnum.CVE:
                case CurrencyEnum.CZK:
                case CurrencyEnum.DJF:
                case CurrencyEnum.DKK:
                case CurrencyEnum.DOP:
                case CurrencyEnum.DZD:
                case CurrencyEnum.EGP:
                case CurrencyEnum.ERN:
                case CurrencyEnum.ETB:
                case CurrencyEnum.EUR:
                case CurrencyEnum.FJD:
                case CurrencyEnum.FKP:
                case CurrencyEnum.GBP:
                case CurrencyEnum.GEL:
                case CurrencyEnum.GHS:
                case CurrencyEnum.GIP:
                case CurrencyEnum.GMD:
                case CurrencyEnum.GNF:
                case CurrencyEnum.GTQ:
                case CurrencyEnum.GYD:
                case CurrencyEnum.HKD:
                case CurrencyEnum.HNL:
                case CurrencyEnum.HRK:
                case CurrencyEnum.HTG:
                case CurrencyEnum.HUF:
                case CurrencyEnum.IDR:
                case CurrencyEnum.ILS:
                case CurrencyEnum.INR:
                case CurrencyEnum.IQD:
                case CurrencyEnum.IRR:
                case CurrencyEnum.ISK:
                case CurrencyEnum.JMD:
                case CurrencyEnum.JOD:
                case CurrencyEnum.JPY:
                case CurrencyEnum.KES:
                case CurrencyEnum.KGS:
                case CurrencyEnum.KHR:
                case CurrencyEnum.KMF:
                case CurrencyEnum.KPW:
                case CurrencyEnum.KRW:
                case CurrencyEnum.KWD:
                case CurrencyEnum.KYD:
                case CurrencyEnum.KZT:
                case CurrencyEnum.LAK:
                case CurrencyEnum.LBP:
                case CurrencyEnum.LKR:
                case CurrencyEnum.LRD:
                case CurrencyEnum.LSL:
                case CurrencyEnum.LTL:
                case CurrencyEnum.LYD:
                case CurrencyEnum.MAD:
                case CurrencyEnum.MDL:
                case CurrencyEnum.MGA:
                case CurrencyEnum.MKD:
                case CurrencyEnum.MMK:
                case CurrencyEnum.MNT:
                case CurrencyEnum.MOP:
                case CurrencyEnum.MRO:
                case CurrencyEnum.MRU:
                case CurrencyEnum.MUR:
                case CurrencyEnum.MVR:
                case CurrencyEnum.MWK:
                case CurrencyEnum.MXN:
                case CurrencyEnum.MXV:
                case CurrencyEnum.MYR:
                case CurrencyEnum.MZN:
                case CurrencyEnum.NAD:
                case CurrencyEnum.NGN:
                case CurrencyEnum.NIO:
                case CurrencyEnum.NOK:
                case CurrencyEnum.NPR:
                case CurrencyEnum.NZD:
                case CurrencyEnum.OMR:
                case CurrencyEnum.PAB:
                case CurrencyEnum.PEN:
                case CurrencyEnum.PGK:
                case CurrencyEnum.PHP:
                case CurrencyEnum.PKR:
                case CurrencyEnum.PLN:
                case CurrencyEnum.PYG:
                case CurrencyEnum.QAR:
                case CurrencyEnum.RON:
                case CurrencyEnum.RSD:
                case CurrencyEnum.RUB:
                case CurrencyEnum.RUR:
                case CurrencyEnum.RWF:
                case CurrencyEnum.SAR:
                case CurrencyEnum.SBD:
                case CurrencyEnum.SCR:
                case CurrencyEnum.SDG:
                case CurrencyEnum.SEK:
                case CurrencyEnum.SGD:
                case CurrencyEnum.SHP:
                case CurrencyEnum.SLL:
                case CurrencyEnum.SOS:
                case CurrencyEnum.SRD:
                case CurrencyEnum.SSP:
                case CurrencyEnum.STD:
                case CurrencyEnum.STN:
                case CurrencyEnum.SVC:
                case CurrencyEnum.SYP:
                case CurrencyEnum.SZL:
                case CurrencyEnum.THB:
                case CurrencyEnum.TJS:
                case CurrencyEnum.TMT:
                case CurrencyEnum.TND:
                case CurrencyEnum.TOP:
                case CurrencyEnum.TRY:
                case CurrencyEnum.TTD:
                case CurrencyEnum.TWD:
                case CurrencyEnum.TZS:
                case CurrencyEnum.UAH:
                case CurrencyEnum.UGX:
                case CurrencyEnum.USD:
                case CurrencyEnum.USN:
                case CurrencyEnum.USS:
                case CurrencyEnum.UYI:
                case CurrencyEnum.UYU:
                case CurrencyEnum.UZS:
                case CurrencyEnum.VEF:
                case CurrencyEnum.VES:
                case CurrencyEnum.VND:
                case CurrencyEnum.VUV:
                case CurrencyEnum.WST:
                case CurrencyEnum.XAF:
                case CurrencyEnum.XAG:
                case CurrencyEnum.XAU:
                case CurrencyEnum.XBA:
                case CurrencyEnum.XBB:
                case CurrencyEnum.XBC:
                case CurrencyEnum.XBD:
                case CurrencyEnum.XCD:
                case CurrencyEnum.XDR:
                case CurrencyEnum.XOF:
                case CurrencyEnum.XPD:
                case CurrencyEnum.XPF:
                case CurrencyEnum.XPT:
                case CurrencyEnum.XSU:
                case CurrencyEnum.XTS:
                case CurrencyEnum.XUA:
                case CurrencyEnum.XXX:
                case CurrencyEnum.YER:
                case CurrencyEnum.ZAR:
                case CurrencyEnum.ZMW:
                case CurrencyEnum.ZWL:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of CurrencyEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of CurrencyEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<CurrencyEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into CurrencyEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed CurrencyEnum value</returns>
        public static CurrencyEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type CurrencyEnum");

            return (CurrencyEnum) index;
        }
    }
} 