using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ChecksumCheck.Cmdl.Helper
{
    /// <summary>
    /// Implements a 32-bit CRC hash algorithm compatible with Zip etc.
    /// </summary>
    /// <remarks>
    /// Crc32 should only be used for backward compatibility with older file formats
    /// and algorithms. It is not secure enough for new applications.
    /// If you need to call multiple times for the same data either use the HashAlgorithm
    /// interface or remember that the result of one Compute call needs to be ~ (XOR) before
    /// being passed in as the seed for the next Compute call.
    /// </remarks>
    public sealed class Crc32 : HashAlgorithm
    {
        public const UInt32 DefaultPolynomial = 0xEDB88320U;
        public const UInt32 DefaultSeed = 0xFFFFFFFFU;

        private static UInt32[] defaultTable;

        private readonly UInt32 seed;
        private readonly UInt32[] table;

        //INSTANT VB NOTE: The field hash was renamed since Visual Basic does not allow fields to have the same name as methods:
        private UInt32 hash_Renamed;

        public Crc32() : this(DefaultPolynomial, DefaultSeed)
        {
        }

        public Crc32(UInt32 polynomial, UInt32 seed)
        {
            if (!BitConverter.IsLittleEndian)
            {
                throw new PlatformNotSupportedException("Not supported on Big Endian processors");
            }

            table = InitializeTable(polynomial);
            //INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
            //ORIGINAL LINE: this.seed = hash = seed;
            hash_Renamed = seed;
            this.seed = hash_Renamed;
        }

        public override void Initialize()
        {
            hash_Renamed = seed;
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            hash_Renamed = CalculateHash(table, hash_Renamed, array, ibStart, cbSize);
        }

        protected override byte[] HashFinal()
        {
            var hashBuffer = UInt32ToBigEndianBytes(~hash_Renamed);
            HashValue = hashBuffer;
            return hashBuffer;
        }

        public override int HashSize
        {
            get
            {
                return 32;
            }
        }

        public static UInt32 Compute(byte[] buffer)
        {
            return Compute(DefaultSeed, buffer);
        }

        public static UInt32 Compute(UInt32 seed, byte[] buffer)
        {
            return Compute(DefaultPolynomial, seed, buffer);
        }

        public static UInt32 Compute(UInt32 polynomial, UInt32 seed, byte[] buffer)
        {
            return ~CalculateHash(InitializeTable(polynomial), seed, buffer, 0, buffer.Length);
        }

        private static UInt32[] InitializeTable(UInt32 polynomial)
        {
            if (polynomial == DefaultPolynomial && defaultTable != null)
            {
                return defaultTable;
            }

            var createTable = new UInt32[256];
            for (var i = 0; i <= 255; i++)
            {
                var entry = Convert.ToUInt32(i);
                for (var j = 0; j <= 7; j++)
                {
                    if ((entry & 1) == 1)
                    {
                        entry = (uint)((entry >> 1) ^ polynomial);
                    }
                    else
                    {
                        entry = (uint)(entry >> 1);
                    }
                }
                createTable[i] = entry;
            }

            if (polynomial == DefaultPolynomial)
            {
                defaultTable = createTable;
            }

            return createTable;
        }

        private static UInt32 CalculateHash(UInt32[] table, UInt32 seed, IList<byte> buffer, int start, int size)
        {
            //INSTANT VB NOTE: The variable hash was renamed since Visual Basic does not handle local variables named the same as class members well:
            var hash_Renamed = seed;
            var i = start;
            while (i < start + size)
            {
                hash_Renamed = (UInt32)((hash_Renamed >> 8) ^ table[buffer[i] ^ hash_Renamed & 0xFF]);
                i += 1;
            }
            return hash_Renamed;
        }

        private static byte[] UInt32ToBigEndianBytes(UInt32 uint32)
        {
            var result = BitConverter.GetBytes(uint32);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(result);
            }

            return result;
        }
    }
}