using System;

class Program
{
    static void Main()
    {
        // ToBoolean
        string boolStr = "true";
        bool boolVal = Convert.ToBoolean(boolStr);
        Console.WriteLine("ToBoolean: " + boolVal); // Outputs: ToBoolean: True

        // ToByte
        string byteStr = "123";
        byte byteVal = Convert.ToByte(byteStr);
        Console.WriteLine("ToByte: " + byteVal); // Outputs: ToByte: 123

        // ToChar
        int charInt = 65;
        char charVal = Convert.ToChar(charInt);
        Console.WriteLine("ToChar: " + charVal); // Outputs: ToChar: A

        // ToDateTime
        string dateTimeStr = "2023-07-24";
        DateTime dateTimeVal = Convert.ToDateTime(dateTimeStr);
        Console.WriteLine("ToDateTime: " + dateTimeVal); // Outputs: ToDateTime: 7/24/2023 12:00:00 AM

        // ToDecimal
        double doubleVal = 123.45;
        decimal decimalVal = Convert.ToDecimal(doubleVal);
        Console.WriteLine("ToDecimal: " + decimalVal); // Outputs: ToDecimal: 123.45

        // ToDouble
        string doubleStr = "123.45";
        double doubleResult = Convert.ToDouble(doubleStr);
        Console.WriteLine("ToDouble: " + doubleResult); // Outputs: ToDouble: 123.45

        // ToInt16
        string int16Str = "32767";
        short int16Val = Convert.ToInt16(int16Str);
        Console.WriteLine("ToInt16: " + int16Val); // Outputs: ToInt16: 32767

        // ToInt32
        string int32Str = "2147483647";
        int int32Val = Convert.ToInt32(int32Str);
        Console.WriteLine("ToInt32: " + int32Val); // Outputs: ToInt32: 2147483647

        // ToInt64
        string int64Str = "9223372036854775807";
        long int64Val = Convert.ToInt64(int64Str);
        Console.WriteLine("ToInt64: " + int64Val); // Outputs: ToInt64: 9223372036854775807

        // ToSByte
        string sbyteStr = "127";
        sbyte sbyteVal = Convert.ToSByte(sbyteStr);
        Console.WriteLine("ToSByte: " + sbyteVal); // Outputs: ToSByte: 127

        // ToSingle
        string singleStr = "123.45";
        float singleVal = Convert.ToSingle(singleStr);
        Console.WriteLine("ToSingle: " + singleVal); // Outputs: ToSingle: 123.45

        // ToString
        int intVal = 123;
        string strVal = Convert.ToString(intVal);
        Console.WriteLine("ToString: " + strVal); // Outputs: ToString: 123

        // ToType
        string typeStr = "123.45";
        Type targetType = typeof(double);
        object typeVal = Convert.ChangeType(typeStr, targetType);
        Console.WriteLine("ToType: " + typeVal); // Outputs: ToType: 123.45

        // ToUInt16
        string uint16Str = "65535";
        ushort uint16Val = Convert.ToUInt16(uint16Str);
        Console.WriteLine("ToUInt16: " + uint16Val); // Outputs: ToUInt16: 65535

        // ToUInt32
        string uint32Str = "4294967295";
        uint uint32Val = Convert.ToUInt32(uint32Str);
        Console.WriteLine("ToUInt32: " + uint32Val); // Outputs: ToUInt32: 4294967295

        // ToUInt64
        string uint64Str = "18446744073709551615";
        ulong uint64Val = Convert.ToUInt64(uint64Str);
        Console.WriteLine("ToUInt64: " + uint64Val); // Outputs: ToUInt64: 18446744073709551615
    }
}
