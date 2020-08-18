using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum BillingAccountCurrencyEnum
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
    /// Helper for the enum type BillingAccountCurrencyEnum
    /// </summary>
    public static class BillingAccountCurrencyEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "UNDEFINED", "AED", "AFN", "ALL", "AMD", "ANG", "AOA", "ARS", "AUD", "AWG", "AZN", "BAM", "BBD", "BDT", "BGN", "BHD", "BIF", "BMD", "BND", "BOB", "BOV", "BRL", "BSD", "BTN", "BWP", "BYN", "BYR", "BZD", "CAD", "CDF", "CHE", "CHF", "CHW", "CLF", "CLP", "CNY", "COP", "COU", "CRC", "CUC", "CUP", "CVE", "CZK", "DJF", "DKK", "DOP", "DZD", "EGP", "ERN", "ETB", "EUR", "FJD", "FKP", "GBP", "GEL", "GHS", "GIP", "GMD", "GNF", "GTQ", "GYD", "HKD", "HNL", "HRK", "HTG", "HUF", "IDR", "ILS", "INR", "IQD", "IRR", "ISK", "JMD", "JOD", "JPY", "KES", "KGS", "KHR", "KMF", "KPW", "KRW", "KWD", "KYD", "KZT", "LAK", "LBP", "LKR", "LRD", "LSL", "LTL", "LYD", "MAD", "MDL", "MGA", "MKD", "MMK", "MNT", "MOP", "MRO", "MRU", "MUR", "MVR", "MWK", "MXN", "MXV", "MYR", "MZN", "NAD", "NGN", "NIO", "NOK", "NPR", "NZD", "OMR", "PAB", "PEN", "PGK", "PHP", "PKR", "PLN", "PYG", "QAR", "RON", "RSD", "RUB", "RUR", "RWF", "SAR", "SBD", "SCR", "SDG", "SEK", "SGD", "SHP", "SLL", "SOS", "SRD", "SSP", "STD", "STN", "SVC", "SYP", "SZL", "THB", "TJS", "TMT", "TND", "TOP", "TRY", "TTD", "TWD", "TZS", "UAH", "UGX", "USD", "USN", "USS", "UYI", "UYU", "UZS", "VEF", "VES", "VND", "VUV", "WST", "XAF", "XAG", "XAU", "XBA", "XBB", "XBC", "XBD", "XCD", "XDR", "XOF", "XPD", "XPF", "XPT", "XSU", "XTS", "XUA", "XXX", "YER", "ZAR", "ZMW", "ZWL" };

        /// <summary>
        /// Converts a BillingAccountCurrencyEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The BillingAccountCurrencyEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(BillingAccountCurrencyEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case BillingAccountCurrencyEnum.UNDEFINED:
                case BillingAccountCurrencyEnum.AED:
                case BillingAccountCurrencyEnum.AFN:
                case BillingAccountCurrencyEnum.ALL:
                case BillingAccountCurrencyEnum.AMD:
                case BillingAccountCurrencyEnum.ANG:
                case BillingAccountCurrencyEnum.AOA:
                case BillingAccountCurrencyEnum.ARS:
                case BillingAccountCurrencyEnum.AUD:
                case BillingAccountCurrencyEnum.AWG:
                case BillingAccountCurrencyEnum.AZN:
                case BillingAccountCurrencyEnum.BAM:
                case BillingAccountCurrencyEnum.BBD:
                case BillingAccountCurrencyEnum.BDT:
                case BillingAccountCurrencyEnum.BGN:
                case BillingAccountCurrencyEnum.BHD:
                case BillingAccountCurrencyEnum.BIF:
                case BillingAccountCurrencyEnum.BMD:
                case BillingAccountCurrencyEnum.BND:
                case BillingAccountCurrencyEnum.BOB:
                case BillingAccountCurrencyEnum.BOV:
                case BillingAccountCurrencyEnum.BRL:
                case BillingAccountCurrencyEnum.BSD:
                case BillingAccountCurrencyEnum.BTN:
                case BillingAccountCurrencyEnum.BWP:
                case BillingAccountCurrencyEnum.BYN:
                case BillingAccountCurrencyEnum.BYR:
                case BillingAccountCurrencyEnum.BZD:
                case BillingAccountCurrencyEnum.CAD:
                case BillingAccountCurrencyEnum.CDF:
                case BillingAccountCurrencyEnum.CHE:
                case BillingAccountCurrencyEnum.CHF:
                case BillingAccountCurrencyEnum.CHW:
                case BillingAccountCurrencyEnum.CLF:
                case BillingAccountCurrencyEnum.CLP:
                case BillingAccountCurrencyEnum.CNY:
                case BillingAccountCurrencyEnum.COP:
                case BillingAccountCurrencyEnum.COU:
                case BillingAccountCurrencyEnum.CRC:
                case BillingAccountCurrencyEnum.CUC:
                case BillingAccountCurrencyEnum.CUP:
                case BillingAccountCurrencyEnum.CVE:
                case BillingAccountCurrencyEnum.CZK:
                case BillingAccountCurrencyEnum.DJF:
                case BillingAccountCurrencyEnum.DKK:
                case BillingAccountCurrencyEnum.DOP:
                case BillingAccountCurrencyEnum.DZD:
                case BillingAccountCurrencyEnum.EGP:
                case BillingAccountCurrencyEnum.ERN:
                case BillingAccountCurrencyEnum.ETB:
                case BillingAccountCurrencyEnum.EUR:
                case BillingAccountCurrencyEnum.FJD:
                case BillingAccountCurrencyEnum.FKP:
                case BillingAccountCurrencyEnum.GBP:
                case BillingAccountCurrencyEnum.GEL:
                case BillingAccountCurrencyEnum.GHS:
                case BillingAccountCurrencyEnum.GIP:
                case BillingAccountCurrencyEnum.GMD:
                case BillingAccountCurrencyEnum.GNF:
                case BillingAccountCurrencyEnum.GTQ:
                case BillingAccountCurrencyEnum.GYD:
                case BillingAccountCurrencyEnum.HKD:
                case BillingAccountCurrencyEnum.HNL:
                case BillingAccountCurrencyEnum.HRK:
                case BillingAccountCurrencyEnum.HTG:
                case BillingAccountCurrencyEnum.HUF:
                case BillingAccountCurrencyEnum.IDR:
                case BillingAccountCurrencyEnum.ILS:
                case BillingAccountCurrencyEnum.INR:
                case BillingAccountCurrencyEnum.IQD:
                case BillingAccountCurrencyEnum.IRR:
                case BillingAccountCurrencyEnum.ISK:
                case BillingAccountCurrencyEnum.JMD:
                case BillingAccountCurrencyEnum.JOD:
                case BillingAccountCurrencyEnum.JPY:
                case BillingAccountCurrencyEnum.KES:
                case BillingAccountCurrencyEnum.KGS:
                case BillingAccountCurrencyEnum.KHR:
                case BillingAccountCurrencyEnum.KMF:
                case BillingAccountCurrencyEnum.KPW:
                case BillingAccountCurrencyEnum.KRW:
                case BillingAccountCurrencyEnum.KWD:
                case BillingAccountCurrencyEnum.KYD:
                case BillingAccountCurrencyEnum.KZT:
                case BillingAccountCurrencyEnum.LAK:
                case BillingAccountCurrencyEnum.LBP:
                case BillingAccountCurrencyEnum.LKR:
                case BillingAccountCurrencyEnum.LRD:
                case BillingAccountCurrencyEnum.LSL:
                case BillingAccountCurrencyEnum.LTL:
                case BillingAccountCurrencyEnum.LYD:
                case BillingAccountCurrencyEnum.MAD:
                case BillingAccountCurrencyEnum.MDL:
                case BillingAccountCurrencyEnum.MGA:
                case BillingAccountCurrencyEnum.MKD:
                case BillingAccountCurrencyEnum.MMK:
                case BillingAccountCurrencyEnum.MNT:
                case BillingAccountCurrencyEnum.MOP:
                case BillingAccountCurrencyEnum.MRO:
                case BillingAccountCurrencyEnum.MRU:
                case BillingAccountCurrencyEnum.MUR:
                case BillingAccountCurrencyEnum.MVR:
                case BillingAccountCurrencyEnum.MWK:
                case BillingAccountCurrencyEnum.MXN:
                case BillingAccountCurrencyEnum.MXV:
                case BillingAccountCurrencyEnum.MYR:
                case BillingAccountCurrencyEnum.MZN:
                case BillingAccountCurrencyEnum.NAD:
                case BillingAccountCurrencyEnum.NGN:
                case BillingAccountCurrencyEnum.NIO:
                case BillingAccountCurrencyEnum.NOK:
                case BillingAccountCurrencyEnum.NPR:
                case BillingAccountCurrencyEnum.NZD:
                case BillingAccountCurrencyEnum.OMR:
                case BillingAccountCurrencyEnum.PAB:
                case BillingAccountCurrencyEnum.PEN:
                case BillingAccountCurrencyEnum.PGK:
                case BillingAccountCurrencyEnum.PHP:
                case BillingAccountCurrencyEnum.PKR:
                case BillingAccountCurrencyEnum.PLN:
                case BillingAccountCurrencyEnum.PYG:
                case BillingAccountCurrencyEnum.QAR:
                case BillingAccountCurrencyEnum.RON:
                case BillingAccountCurrencyEnum.RSD:
                case BillingAccountCurrencyEnum.RUB:
                case BillingAccountCurrencyEnum.RUR:
                case BillingAccountCurrencyEnum.RWF:
                case BillingAccountCurrencyEnum.SAR:
                case BillingAccountCurrencyEnum.SBD:
                case BillingAccountCurrencyEnum.SCR:
                case BillingAccountCurrencyEnum.SDG:
                case BillingAccountCurrencyEnum.SEK:
                case BillingAccountCurrencyEnum.SGD:
                case BillingAccountCurrencyEnum.SHP:
                case BillingAccountCurrencyEnum.SLL:
                case BillingAccountCurrencyEnum.SOS:
                case BillingAccountCurrencyEnum.SRD:
                case BillingAccountCurrencyEnum.SSP:
                case BillingAccountCurrencyEnum.STD:
                case BillingAccountCurrencyEnum.STN:
                case BillingAccountCurrencyEnum.SVC:
                case BillingAccountCurrencyEnum.SYP:
                case BillingAccountCurrencyEnum.SZL:
                case BillingAccountCurrencyEnum.THB:
                case BillingAccountCurrencyEnum.TJS:
                case BillingAccountCurrencyEnum.TMT:
                case BillingAccountCurrencyEnum.TND:
                case BillingAccountCurrencyEnum.TOP:
                case BillingAccountCurrencyEnum.TRY:
                case BillingAccountCurrencyEnum.TTD:
                case BillingAccountCurrencyEnum.TWD:
                case BillingAccountCurrencyEnum.TZS:
                case BillingAccountCurrencyEnum.UAH:
                case BillingAccountCurrencyEnum.UGX:
                case BillingAccountCurrencyEnum.USD:
                case BillingAccountCurrencyEnum.USN:
                case BillingAccountCurrencyEnum.USS:
                case BillingAccountCurrencyEnum.UYI:
                case BillingAccountCurrencyEnum.UYU:
                case BillingAccountCurrencyEnum.UZS:
                case BillingAccountCurrencyEnum.VEF:
                case BillingAccountCurrencyEnum.VES:
                case BillingAccountCurrencyEnum.VND:
                case BillingAccountCurrencyEnum.VUV:
                case BillingAccountCurrencyEnum.WST:
                case BillingAccountCurrencyEnum.XAF:
                case BillingAccountCurrencyEnum.XAG:
                case BillingAccountCurrencyEnum.XAU:
                case BillingAccountCurrencyEnum.XBA:
                case BillingAccountCurrencyEnum.XBB:
                case BillingAccountCurrencyEnum.XBC:
                case BillingAccountCurrencyEnum.XBD:
                case BillingAccountCurrencyEnum.XCD:
                case BillingAccountCurrencyEnum.XDR:
                case BillingAccountCurrencyEnum.XOF:
                case BillingAccountCurrencyEnum.XPD:
                case BillingAccountCurrencyEnum.XPF:
                case BillingAccountCurrencyEnum.XPT:
                case BillingAccountCurrencyEnum.XSU:
                case BillingAccountCurrencyEnum.XTS:
                case BillingAccountCurrencyEnum.XUA:
                case BillingAccountCurrencyEnum.XXX:
                case BillingAccountCurrencyEnum.YER:
                case BillingAccountCurrencyEnum.ZAR:
                case BillingAccountCurrencyEnum.ZMW:
                case BillingAccountCurrencyEnum.ZWL:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of BillingAccountCurrencyEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of BillingAccountCurrencyEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<BillingAccountCurrencyEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into BillingAccountCurrencyEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed BillingAccountCurrencyEnum value</returns>
        public static BillingAccountCurrencyEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type BillingAccountCurrencyEnum");

            return (BillingAccountCurrencyEnum) index;
        }
    }
} 