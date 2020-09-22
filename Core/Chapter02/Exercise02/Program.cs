using System;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
           //  WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
            // WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
            // WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

            WriteLine($"sbyte: Size:{sizeof(sbyte)}, Min:{sbyte.MinValue:N0} Max: {sbyte.MaxValue:N0}.");
            WriteLine($"byte: Size:{sizeof(byte)}, Min:{byte.MinValue:N0} Max: {byte.MaxValue:N0}.");
            WriteLine($"short: Size:{sizeof(short)}, Min:{short.MinValue:N0} Max: {short.MaxValue:N0}.");
            WriteLine($"ushort: Size:{sizeof(ushort)}, Min:{ushort.MinValue:N0} Max: {ushort.MaxValue:N0}.");
            WriteLine($"int: Size:{sizeof(int)}, Min:{int.MinValue:N0} Max: {int.MaxValue:N0}.");
            WriteLine($"uint: Size:{sizeof(uint)}, Min:{uint.MinValue:N0} Max: {uint.MaxValue:N0}.");
            WriteLine($"long: Size:{sizeof(long)}, Min:{ulong.MinValue:N0} Max: {ulong.MaxValue:N0}.");
            WriteLine($"ulong: Size:{sizeof(ulong)}, Min:{ulong.MinValue:N0} Max: {ulong.MaxValue:N0}.");
            WriteLine($"float: Size:{sizeof(float)}, Min:{float.MinValue:N0} Max: {float.MaxValue:N0}.");
            WriteLine($"double: Size:{sizeof(double)}, Min:{double.MinValue:N0} Max: {double.MaxValue:N0}.");
            WriteLine($"decimal: Size:{sizeof(decimal)}, Min:{decimal.MinValue:N0} Max: {decimal.MaxValue:N0}.");
        }
    }
}
